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
    public unsafe readonly struct PfnFontGetGlyphExtentsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int>) _handle;
        public PfnFontGetGlyphExtentsFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphExtentsFuncT
        (
             FontGetGlyphExtentsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphExtentsFuncT From(FontGetGlyphExtentsFuncT proc) => new PfnFontGetGlyphExtentsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphExtentsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphExtentsFuncT(nint pfn)
            => new PfnFontGetGlyphExtentsFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphExtentsFuncT(FontGetGlyphExtentsFuncT proc)
            => new PfnFontGetGlyphExtentsFuncT(proc);

        public static explicit operator FontGetGlyphExtentsFuncT(PfnFontGetGlyphExtentsFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphExtentsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int>(PfnFontGetGlyphExtentsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphExtentsFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, GlyphExtentsT*, void*, int> ptr) => new PfnFontGetGlyphExtentsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphExtentsFuncT(FontT* arg0, void* arg1, uint arg2, GlyphExtentsT* arg3, void* arg4);
}

