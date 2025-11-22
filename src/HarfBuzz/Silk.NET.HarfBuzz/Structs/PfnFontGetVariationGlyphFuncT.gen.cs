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
    public unsafe readonly struct PfnFontGetVariationGlyphFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int>) _handle;
        public PfnFontGetVariationGlyphFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetVariationGlyphFuncT
        (
             FontGetVariationGlyphFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetVariationGlyphFuncT From(FontGetVariationGlyphFuncT proc) => new PfnFontGetVariationGlyphFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetVariationGlyphFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetVariationGlyphFuncT(nint pfn)
            => new PfnFontGetVariationGlyphFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int>) pfn);

        public static implicit operator PfnFontGetVariationGlyphFuncT(FontGetVariationGlyphFuncT proc)
            => new PfnFontGetVariationGlyphFuncT(proc);

        public static explicit operator FontGetVariationGlyphFuncT(PfnFontGetVariationGlyphFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetVariationGlyphFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int>(PfnFontGetVariationGlyphFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetVariationGlyphFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, uint*, void*, int> ptr) => new PfnFontGetVariationGlyphFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetVariationGlyphFuncT(FontT* arg0, void* arg1, uint arg2, uint arg3, uint* arg4, void* arg5);
}

