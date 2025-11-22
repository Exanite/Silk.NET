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
    public unsafe readonly struct PfnPaintPushClipGlyphFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void>) _handle;
        public PfnPaintPushClipGlyphFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintPushClipGlyphFuncT
        (
             PaintPushClipGlyphFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintPushClipGlyphFuncT From(PaintPushClipGlyphFuncT proc) => new PfnPaintPushClipGlyphFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintPushClipGlyphFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintPushClipGlyphFuncT(nint pfn)
            => new PfnPaintPushClipGlyphFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void>) pfn);

        public static implicit operator PfnPaintPushClipGlyphFuncT(PaintPushClipGlyphFuncT proc)
            => new PfnPaintPushClipGlyphFuncT(proc);

        public static explicit operator PaintPushClipGlyphFuncT(PfnPaintPushClipGlyphFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintPushClipGlyphFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void>(PfnPaintPushClipGlyphFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintPushClipGlyphFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, uint, FontT*, void*, void> ptr) => new PfnPaintPushClipGlyphFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintPushClipGlyphFuncT(PaintFuncsT* arg0, void* arg1, uint arg2, FontT* arg3, void* arg4);
}

