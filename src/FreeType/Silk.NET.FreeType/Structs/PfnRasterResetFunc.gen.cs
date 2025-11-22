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
    public unsafe readonly struct PfnRasterResetFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void> Handle => (delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void>) _handle;
        public PfnRasterResetFunc
        (
            delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void> ptr
        ) => _handle = ptr;

        public PfnRasterResetFunc
        (
             RasterResetFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnRasterResetFunc From(RasterResetFunc proc) => new PfnRasterResetFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnRasterResetFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnRasterResetFunc(nint pfn)
            => new PfnRasterResetFunc((delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void>) pfn);

        public static implicit operator PfnRasterResetFunc(RasterResetFunc proc)
            => new PfnRasterResetFunc(proc);

        public static explicit operator RasterResetFunc(PfnRasterResetFunc pfn)
            => SilkMarshal.PtrToDelegate<RasterResetFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void>(PfnRasterResetFunc pfn) => pfn.Handle;
        public static implicit operator PfnRasterResetFunc(delegate* unmanaged[Cdecl]<RasterRec*, byte*, uint, void> ptr) => new PfnRasterResetFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void RasterResetFunc(RasterRec* arg0, byte* arg1, uint arg2);
}

