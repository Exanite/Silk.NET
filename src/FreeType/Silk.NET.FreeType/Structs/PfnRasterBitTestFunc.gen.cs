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
    public unsafe readonly struct PfnRasterBitTestFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, int, void*, int> Handle => (delegate* unmanaged[Cdecl]<int, int, void*, int>) _handle;
        public PfnRasterBitTestFunc
        (
            delegate* unmanaged[Cdecl]<int, int, void*, int> ptr
        ) => _handle = ptr;

        public PfnRasterBitTestFunc
        (
             RasterBitTestFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterBitTestFunc From(RasterBitTestFunc proc) => new PfnRasterBitTestFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterBitTestFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterBitTestFunc(nint pfn)
            => new PfnRasterBitTestFunc((delegate* unmanaged[Cdecl]<int, int, void*, int>) pfn);

        public static implicit operator PfnRasterBitTestFunc(RasterBitTestFunc proc)
            => new PfnRasterBitTestFunc(proc);

        public static explicit operator RasterBitTestFunc(PfnRasterBitTestFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterBitTestFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, int, void*, int>(PfnRasterBitTestFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterBitTestFunc(delegate* unmanaged[Cdecl]<int, int, void*, int> ptr) => new PfnRasterBitTestFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int RasterBitTestFunc(int arg0, int arg1, void* arg2);
}

