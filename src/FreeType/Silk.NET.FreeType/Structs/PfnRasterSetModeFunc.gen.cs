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
    public unsafe readonly struct PfnRasterSetModeFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int>) _handle;
        public PfnRasterSetModeFunc
        (
            delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnRasterSetModeFunc
        (
             RasterSetModeFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterSetModeFunc From(RasterSetModeFunc proc) => new PfnRasterSetModeFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterSetModeFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterSetModeFunc(nint pfn)
            => new PfnRasterSetModeFunc((delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int>) pfn);

        public static implicit operator PfnRasterSetModeFunc(RasterSetModeFunc proc)
            => new PfnRasterSetModeFunc(proc);

        public static explicit operator RasterSetModeFunc(PfnRasterSetModeFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterSetModeFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int>(PfnRasterSetModeFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterSetModeFunc(delegate* unmanaged[Cdecl]<RasterRec*, uint, void*, int> ptr) => new PfnRasterSetModeFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int RasterSetModeFunc(RasterRec* arg0, uint arg1, void* arg2);
}

