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
    public unsafe readonly struct PfnFontGetGlyphKerningFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int>) _handle;
        public PfnFontGetGlyphKerningFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphKerningFuncT
        (
             FontGetGlyphKerningFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphKerningFuncT From(FontGetGlyphKerningFuncT proc) => new PfnFontGetGlyphKerningFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphKerningFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphKerningFuncT(nint pfn)
            => new PfnFontGetGlyphKerningFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphKerningFuncT(FontGetGlyphKerningFuncT proc)
            => new PfnFontGetGlyphKerningFuncT(proc);

        public static explicit operator FontGetGlyphKerningFuncT(PfnFontGetGlyphKerningFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphKerningFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int>(PfnFontGetGlyphKerningFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphKerningFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint, void*, int> ptr) => new PfnFontGetGlyphKerningFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphKerningFuncT(FontT* arg0, void* arg1, uint arg2, uint arg3, void* arg4);
}

