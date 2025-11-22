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
    public unsafe readonly struct PfnFontGetGlyphFromNameFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int>) _handle;
        public PfnFontGetGlyphFromNameFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphFromNameFuncT
        (
             FontGetGlyphFromNameFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphFromNameFuncT From(FontGetGlyphFromNameFuncT proc) => new PfnFontGetGlyphFromNameFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphFromNameFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphFromNameFuncT(nint pfn)
            => new PfnFontGetGlyphFromNameFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphFromNameFuncT(FontGetGlyphFromNameFuncT proc)
            => new PfnFontGetGlyphFromNameFuncT(proc);

        public static explicit operator FontGetGlyphFromNameFuncT(PfnFontGetGlyphFromNameFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphFromNameFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int>(PfnFontGetGlyphFromNameFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphFromNameFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, byte*, int, uint*, void*, int> ptr) => new PfnFontGetGlyphFromNameFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphFromNameFuncT(FontT* arg0, void* arg1, byte* arg2, int arg3, uint* arg4, void* arg5);
}

