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
    public unsafe readonly struct PfnPaintColorGlyphFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int>) _handle;
        public PfnPaintColorGlyphFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int> ptr
        ) => _handle = ptr;

        public PfnPaintColorGlyphFuncT
        (
             PaintColorGlyphFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintColorGlyphFuncT From(PaintColorGlyphFuncT proc) => new PfnPaintColorGlyphFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintColorGlyphFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintColorGlyphFuncT(nint pfn)
            => new PfnPaintColorGlyphFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int>) pfn);

        public static implicit operator PfnPaintColorGlyphFuncT(PaintColorGlyphFuncT proc)
            => new PfnPaintColorGlyphFuncT(proc);

        public static explicit operator PaintColorGlyphFuncT(PfnPaintColorGlyphFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintColorGlyphFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int>(PfnPaintColorGlyphFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintColorGlyphFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, int> ptr) => new PfnPaintColorGlyphFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PaintColorGlyphFuncT(PaintFuncsT* arg0, void* arg1, uint arg2, FontT* arg3, void* arg4);
}

