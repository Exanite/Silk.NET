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
    public unsafe readonly struct PfnVMExtFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void> Handle => (delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void>) _handle;
        public PfnVMExtFunction
        (
            delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void> ptr
        ) => _handle = ptr;

        public PfnVMExtFunction
        (
             VMExtFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVMExtFunction From(VMExtFunction proc) => new PfnVMExtFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVMExtFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVMExtFunction(nint pfn)
            => new PfnVMExtFunction((delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void>) pfn);

        public static implicit operator PfnVMExtFunction(VMExtFunction proc)
            => new PfnVMExtFunction(proc);

        public static explicit operator VMExtFunction(PfnVMExtFunction pfn)
            => SilkMarshal.PtrToDelegate<VMExtFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void>(PfnVMExtFunction pfn) => pfn.Handle;
        public static implicit operator PfnVMExtFunction(delegate* unmanaged[Cdecl]<IByteCodeRunner*, VMExecInstHeader*, void*, void> ptr) => new PfnVMExtFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VMExtFunction(IByteCodeRunner* arg0, VMExecInstHeader* arg1, void* arg2);
}

