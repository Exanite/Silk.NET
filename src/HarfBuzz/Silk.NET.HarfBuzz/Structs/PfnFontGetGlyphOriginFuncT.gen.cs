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
    public unsafe readonly struct PfnFontGetGlyphOriginFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int>) _handle;
        public PfnFontGetGlyphOriginFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphOriginFuncT
        (
             FontGetGlyphOriginFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphOriginFuncT From(FontGetGlyphOriginFuncT proc) => new PfnFontGetGlyphOriginFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphOriginFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphOriginFuncT(nint pfn)
            => new PfnFontGetGlyphOriginFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphOriginFuncT(FontGetGlyphOriginFuncT proc)
            => new PfnFontGetGlyphOriginFuncT(proc);

        public static explicit operator FontGetGlyphOriginFuncT(PfnFontGetGlyphOriginFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphOriginFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int>(PfnFontGetGlyphOriginFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphOriginFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, int*, int*, void*, int> ptr) => new PfnFontGetGlyphOriginFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphOriginFuncT(FontT* arg0, void* arg1, uint arg2, int* arg3, int* arg4, void* arg5);
}

