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
    public unsafe readonly struct PfnFontGetGlyphNameFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int>) _handle;
        public PfnFontGetGlyphNameFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphNameFuncT
        (
             FontGetGlyphNameFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphNameFuncT From(FontGetGlyphNameFuncT proc) => new PfnFontGetGlyphNameFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphNameFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphNameFuncT(nint pfn)
            => new PfnFontGetGlyphNameFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphNameFuncT(FontGetGlyphNameFuncT proc)
            => new PfnFontGetGlyphNameFuncT(proc);

        public static explicit operator FontGetGlyphNameFuncT(PfnFontGetGlyphNameFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphNameFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int>(PfnFontGetGlyphNameFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphNameFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, byte*, uint, void*, int> ptr) => new PfnFontGetGlyphNameFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphNameFuncT(FontT* arg0, void* arg1, uint arg2, byte* arg3, uint arg4, void* arg5);
}

