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
    public unsafe readonly struct PfnRasterNewFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, RasterRec**, int> Handle => (delegate* unmanaged[Cdecl]<void*, RasterRec**, int>) _handle;
        public PfnRasterNewFunc
        (
            delegate* unmanaged[Cdecl]<void*, RasterRec**, int> ptr
        ) => _handle = ptr;

        public PfnRasterNewFunc
        (
             RasterNewFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterNewFunc From(RasterNewFunc proc) => new PfnRasterNewFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterNewFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterNewFunc(nint pfn)
            => new PfnRasterNewFunc((delegate* unmanaged[Cdecl]<void*, RasterRec**, int>) pfn);

        public static implicit operator PfnRasterNewFunc(RasterNewFunc proc)
            => new PfnRasterNewFunc(proc);

        public static explicit operator RasterNewFunc(PfnRasterNewFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterNewFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, RasterRec**, int>(PfnRasterNewFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterNewFunc(delegate* unmanaged[Cdecl]<void*, RasterRec**, int> ptr) => new PfnRasterNewFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int RasterNewFunc(void* arg0, RasterRec** arg1);
}

