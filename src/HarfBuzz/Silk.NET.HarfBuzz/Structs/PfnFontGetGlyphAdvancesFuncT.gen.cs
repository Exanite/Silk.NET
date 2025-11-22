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
    public unsafe readonly struct PfnFontGetGlyphAdvancesFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void>) _handle;
        public PfnFontGetGlyphAdvancesFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphAdvancesFuncT
        (
             FontGetGlyphAdvancesFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphAdvancesFuncT From(FontGetGlyphAdvancesFuncT proc) => new PfnFontGetGlyphAdvancesFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphAdvancesFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphAdvancesFuncT(nint pfn)
            => new PfnFontGetGlyphAdvancesFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void>) pfn);

        public static implicit operator PfnFontGetGlyphAdvancesFuncT(FontGetGlyphAdvancesFuncT proc)
            => new PfnFontGetGlyphAdvancesFuncT(proc);

        public static explicit operator FontGetGlyphAdvancesFuncT(PfnFontGetGlyphAdvancesFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphAdvancesFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void>(PfnFontGetGlyphAdvancesFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphAdvancesFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, void*, void> ptr) => new PfnFontGetGlyphAdvancesFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void FontGetGlyphAdvancesFuncT(FontT* arg0, void* arg1, uint arg2, uint* arg3, uint arg4, int* arg5, uint arg6, void* arg7);
}

