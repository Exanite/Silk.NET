// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    public unsafe readonly struct PfnVMPrintFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<byte*, void*, void> Handle => (delegate* unmanaged[Cdecl]<byte*, void*, void>) _handle;
        public PfnVMPrintFunc
        (
            delegate* unmanaged[Cdecl]<byte*, void*, void> ptr
        ) => _handle = ptr;

        public PfnVMPrintFunc
        (
             VMPrintFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVMPrintFunc From(VMPrintFunc proc) => new PfnVMPrintFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVMPrintFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVMPrintFunc(nint pfn)
            => new PfnVMPrintFunc((delegate* unmanaged[Cdecl]<byte*, void*, void>) pfn);

        public static implicit operator PfnVMPrintFunc(VMPrintFunc proc)
            => new PfnVMPrintFunc(proc);

        public static explicit operator VMPrintFunc(PfnVMPrintFunc pfn)
            => SilkMarshal.PtrToDelegate<VMPrintFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<byte*, void*, void>(PfnVMPrintFunc pfn) => pfn.Handle;
        public static implicit operator PfnVMPrintFunc(delegate* unmanaged[Cdecl]<byte*, void*, void> ptr) => new PfnVMPrintFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VMPrintFunc(byte* arg0, void* arg1);
}

