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
    public unsafe readonly struct PfnRasterDoneFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RasterRec*, void> Handle => (delegate* unmanaged[Cdecl]<RasterRec*, void>) _handle;
        public PfnRasterDoneFunc
        (
            delegate* unmanaged[Cdecl]<RasterRec*, void> ptr
        ) => _handle = ptr;

        public PfnRasterDoneFunc
        (
             RasterDoneFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterDoneFunc From(RasterDoneFunc proc) => new PfnRasterDoneFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterDoneFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterDoneFunc(nint pfn)
            => new PfnRasterDoneFunc((delegate* unmanaged[Cdecl]<RasterRec*, void>) pfn);

        public static implicit operator PfnRasterDoneFunc(RasterDoneFunc proc)
            => new PfnRasterDoneFunc(proc);

        public static explicit operator RasterDoneFunc(PfnRasterDoneFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterDoneFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RasterRec*, void>(PfnRasterDoneFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterDoneFunc(delegate* unmanaged[Cdecl]<RasterRec*, void> ptr) => new PfnRasterDoneFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RasterDoneFunc(RasterRec* arg0);
}

