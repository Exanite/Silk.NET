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
    public unsafe readonly struct PfnPaintImageFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int>) _handle;
        public PfnPaintImageFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int> ptr
        ) => _handle = ptr;

        public PfnPaintImageFuncT
        (
             PaintImageFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintImageFuncT From(PaintImageFuncT proc) => new PfnPaintImageFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintImageFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintImageFuncT(nint pfn)
            => new PfnPaintImageFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int>) pfn);

        public static implicit operator PfnPaintImageFuncT(PaintImageFuncT proc)
            => new PfnPaintImageFuncT(proc);

        public static explicit operator PaintImageFuncT(PfnPaintImageFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintImageFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int>(PfnPaintImageFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintImageFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, BlobT*, uint, uint, uint, float, GlyphExtentsT*, void*, int> ptr) => new PfnPaintImageFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PaintImageFuncT(PaintFuncsT* arg0, void* arg1, BlobT* arg2, uint arg3, uint arg4, uint arg5, float arg6, GlyphExtentsT* arg7, void* arg8);
}

