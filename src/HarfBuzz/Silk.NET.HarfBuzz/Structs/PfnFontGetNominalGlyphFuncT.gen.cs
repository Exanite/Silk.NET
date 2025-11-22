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
    public unsafe readonly struct PfnFontGetNominalGlyphFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int>) _handle;
        public PfnFontGetNominalGlyphFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetNominalGlyphFuncT
        (
             FontGetNominalGlyphFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetNominalGlyphFuncT From(FontGetNominalGlyphFuncT proc) => new PfnFontGetNominalGlyphFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetNominalGlyphFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetNominalGlyphFuncT(nint pfn)
            => new PfnFontGetNominalGlyphFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int>) pfn);

        public static implicit operator PfnFontGetNominalGlyphFuncT(FontGetNominalGlyphFuncT proc)
            => new PfnFontGetNominalGlyphFuncT(proc);

        public static explicit operator FontGetNominalGlyphFuncT(PfnFontGetNominalGlyphFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetNominalGlyphFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int>(PfnFontGetNominalGlyphFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetNominalGlyphFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, void*, int> ptr) => new PfnFontGetNominalGlyphFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetNominalGlyphFuncT(FontT* arg0, void* arg1, uint arg2, uint* arg3, void* arg4);
}

