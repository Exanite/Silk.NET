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
    public unsafe readonly struct PfnRasterRenderFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int> Handle => (delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int>) _handle;
        public PfnRasterRenderFunc
        (
            delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int> ptr
        ) => _handle = ptr;

        public PfnRasterRenderFunc
        (
             RasterRenderFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterRenderFunc From(RasterRenderFunc proc) => new PfnRasterRenderFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterRenderFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterRenderFunc(nint pfn)
            => new PfnRasterRenderFunc((delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int>) pfn);

        public static implicit operator PfnRasterRenderFunc(RasterRenderFunc proc)
            => new PfnRasterRenderFunc(proc);

        public static explicit operator RasterRenderFunc(PfnRasterRenderFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterRenderFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int>(PfnRasterRenderFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterRenderFunc(delegate* unmanaged[Cdecl]<RasterRec*, RasterParams*, int> ptr) => new PfnRasterRenderFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int RasterRenderFunc(RasterRec* arg0, RasterParams* arg1);
}

