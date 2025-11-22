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
    public unsafe readonly struct PfnFontGetGlyphShapeFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void>) _handle;
        public PfnFontGetGlyphShapeFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphShapeFuncT
        (
             FontGetGlyphShapeFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphShapeFuncT From(FontGetGlyphShapeFuncT proc) => new PfnFontGetGlyphShapeFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphShapeFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphShapeFuncT(nint pfn)
            => new PfnFontGetGlyphShapeFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void>) pfn);

        public static implicit operator PfnFontGetGlyphShapeFuncT(FontGetGlyphShapeFuncT proc)
            => new PfnFontGetGlyphShapeFuncT(proc);

        public static explicit operator FontGetGlyphShapeFuncT(PfnFontGetGlyphShapeFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphShapeFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void>(PfnFontGetGlyphShapeFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphShapeFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, void> ptr) => new PfnFontGetGlyphShapeFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void FontGetGlyphShapeFuncT(FontT* arg0, void* arg1, uint arg2, DrawFuncsT* arg3, void* arg4, void* arg5);
}

