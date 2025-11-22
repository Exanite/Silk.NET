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
    public unsafe readonly struct PfnFontGetGlyphAdvanceFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int>) _handle;
        public PfnFontGetGlyphAdvanceFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphAdvanceFuncT
        (
             FontGetGlyphAdvanceFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphAdvanceFuncT From(FontGetGlyphAdvanceFuncT proc) => new PfnFontGetGlyphAdvanceFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphAdvanceFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphAdvanceFuncT(nint pfn)
            => new PfnFontGetGlyphAdvanceFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphAdvanceFuncT(FontGetGlyphAdvanceFuncT proc)
            => new PfnFontGetGlyphAdvanceFuncT(proc);

        public static explicit operator FontGetGlyphAdvanceFuncT(PfnFontGetGlyphAdvanceFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphAdvanceFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int>(PfnFontGetGlyphAdvanceFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphAdvanceFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, void*, int> ptr) => new PfnFontGetGlyphAdvanceFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphAdvanceFuncT(FontT* arg0, void* arg1, uint arg2, void* arg3);
}

