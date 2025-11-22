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
    public unsafe readonly struct PfnOutlineCubicToFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int> Handle => (delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int>) _handle;
        public PfnOutlineCubicToFunc
        (
            delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int> ptr
        ) => _handle = ptr;

        public PfnOutlineCubicToFunc
        (
             OutlineCubicToFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnOutlineCubicToFunc From(OutlineCubicToFunc proc) => new PfnOutlineCubicToFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnOutlineCubicToFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnOutlineCubicToFunc(nint pfn)
            => new PfnOutlineCubicToFunc((delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int>) pfn);

        public static implicit operator PfnOutlineCubicToFunc(OutlineCubicToFunc proc)
            => new PfnOutlineCubicToFunc(proc);

        public static explicit operator OutlineCubicToFunc(PfnOutlineCubicToFunc pfn)
            => SilkMarshal.PtrToDelegate<OutlineCubicToFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int>(PfnOutlineCubicToFunc pfn) => pfn.Handle;
        public static implicit operator PfnOutlineCubicToFunc(delegate* unmanaged[Cdecl]<Vector*, Vector*, Vector*, void*, int> ptr) => new PfnOutlineCubicToFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int OutlineCubicToFunc(Vector* arg0, Vector* arg1, Vector* arg2, void* arg3);
}

