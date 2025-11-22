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

namespace Silk.NET.HarfBuzz
{
    public unsafe readonly struct PfnPaintCustomPaletteColorFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int>) _handle;
        public PfnPaintCustomPaletteColorFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int> ptr
        ) => _handle = ptr;

        public PfnPaintCustomPaletteColorFuncT
        (
             PaintCustomPaletteColorFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintCustomPaletteColorFuncT From(PaintCustomPaletteColorFuncT proc) => new PfnPaintCustomPaletteColorFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintCustomPaletteColorFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintCustomPaletteColorFuncT(nint pfn)
            => new PfnPaintCustomPaletteColorFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int>) pfn);

        public static implicit operator PfnPaintCustomPaletteColorFuncT(PaintCustomPaletteColorFuncT proc)
            => new PfnPaintCustomPaletteColorFuncT(proc);

        public static explicit operator PaintCustomPaletteColorFuncT(PfnPaintCustomPaletteColorFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintCustomPaletteColorFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int>(PfnPaintCustomPaletteColorFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintCustomPaletteColorFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, uint*, void*, int> ptr) => new PfnPaintCustomPaletteColorFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PaintCustomPaletteColorFuncT(PaintFuncsT* arg0, void* arg1, uint arg2, uint* arg3, void* arg4);
}

