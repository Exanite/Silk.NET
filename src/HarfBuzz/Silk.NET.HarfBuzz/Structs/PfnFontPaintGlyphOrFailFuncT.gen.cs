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
    public unsafe readonly struct PfnFontPaintGlyphOrFailFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int>) _handle;
        public PfnFontPaintGlyphOrFailFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontPaintGlyphOrFailFuncT
        (
             FontPaintGlyphOrFailFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontPaintGlyphOrFailFuncT From(FontPaintGlyphOrFailFuncT proc) => new PfnFontPaintGlyphOrFailFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontPaintGlyphOrFailFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontPaintGlyphOrFailFuncT(nint pfn)
            => new PfnFontPaintGlyphOrFailFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int>) pfn);

        public static implicit operator PfnFontPaintGlyphOrFailFuncT(FontPaintGlyphOrFailFuncT proc)
            => new PfnFontPaintGlyphOrFailFuncT(proc);

        public static explicit operator FontPaintGlyphOrFailFuncT(PfnFontPaintGlyphOrFailFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontPaintGlyphOrFailFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int>(PfnFontPaintGlyphOrFailFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontPaintGlyphOrFailFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, PaintFuncsT*, void*, uint, uint, void*, int> ptr) => new PfnFontPaintGlyphOrFailFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontPaintGlyphOrFailFuncT(FontT* arg0, void* arg1, uint arg2, PaintFuncsT* arg3, void* arg4, uint arg5, uint arg6, void* arg7);
}

