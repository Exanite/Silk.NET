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

namespace Silk.NET.FreeType
{
    public unsafe readonly struct PfnOutlineConicToFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int> Handle => (delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int>) _handle;
        public PfnOutlineConicToFunc
        (
            delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int> ptr
        ) => _handle = ptr;

        public PfnOutlineConicToFunc
        (
             OutlineConicToFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnOutlineConicToFunc From(OutlineConicToFunc proc) => new PfnOutlineConicToFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnOutlineConicToFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnOutlineConicToFunc(nint pfn)
            => new PfnOutlineConicToFunc((delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int>) pfn);

        public static implicit operator PfnOutlineConicToFunc(OutlineConicToFunc proc)
            => new PfnOutlineConicToFunc(proc);

        public static explicit operator OutlineConicToFunc(PfnOutlineConicToFunc pfn)
            => SilkMarshal.PtrToDelegate<OutlineConicToFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int>(PfnOutlineConicToFunc pfn) => pfn.Handle;
        public static implicit operator PfnOutlineConicToFunc(delegate* unmanaged[Cdecl]<Vector*, Vector*, void*, int> ptr) => new PfnOutlineConicToFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int OutlineConicToFunc(Vector* arg0, Vector* arg1, void* arg2);
}

