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
    public unsafe readonly struct PfnRasterBitSetFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, int, void*, void> Handle => (delegate* unmanaged[Cdecl]<int, int, void*, void>) _handle;
        public PfnRasterBitSetFunc
        (
            delegate* unmanaged[Cdecl]<int, int, void*, void> ptr
        ) => _handle = ptr;

        public PfnRasterBitSetFunc
        (
             RasterBitSetFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterBitSetFunc From(RasterBitSetFunc proc) => new PfnRasterBitSetFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterBitSetFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterBitSetFunc(nint pfn)
            => new PfnRasterBitSetFunc((delegate* unmanaged[Cdecl]<int, int, void*, void>) pfn);

        public static implicit operator PfnRasterBitSetFunc(RasterBitSetFunc proc)
            => new PfnRasterBitSetFunc(proc);

        public static explicit operator RasterBitSetFunc(PfnRasterBitSetFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterBitSetFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, int, void*, void>(PfnRasterBitSetFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterBitSetFunc(delegate* unmanaged[Cdecl]<int, int, void*, void> ptr) => new PfnRasterBitSetFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RasterBitSetFunc(int arg0, int arg1, void* arg2);
}

