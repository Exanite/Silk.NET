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
    public unsafe readonly struct PfnFontGetGlyphContourPointFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int>) _handle;
        public PfnFontGetGlyphContourPointFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphContourPointFuncT
        (
             FontGetGlyphContourPointFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphContourPointFuncT From(FontGetGlyphContourPointFuncT proc) => new PfnFontGetGlyphContourPointFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphContourPointFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphContourPointFuncT(nint pfn)
            => new PfnFontGetGlyphContourPointFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphContourPointFuncT(FontGetGlyphContourPointFuncT proc)
            => new PfnFontGetGlyphContourPointFuncT(proc);

        public static explicit operator FontGetGlyphContourPointFuncT(PfnFontGetGlyphContourPointFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphContourPointFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int>(PfnFontGetGlyphContourPointFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphContourPointFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, int*, int*, void*, int> ptr) => new PfnFontGetGlyphContourPointFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphContourPointFuncT(FontT* arg0, void* arg1, uint arg2, uint arg3, int* arg4, int* arg5, void* arg6);
}

