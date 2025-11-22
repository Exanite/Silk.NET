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
    public unsafe readonly struct PfnFontGetNominalGlyphsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint>) _handle;
        public PfnFontGetNominalGlyphsFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint> ptr
        ) => _handle = ptr;

        public PfnFontGetNominalGlyphsFuncT
        (
             FontGetNominalGlyphsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetNominalGlyphsFuncT From(FontGetNominalGlyphsFuncT proc) => new PfnFontGetNominalGlyphsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetNominalGlyphsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetNominalGlyphsFuncT(nint pfn)
            => new PfnFontGetNominalGlyphsFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint>) pfn);

        public static implicit operator PfnFontGetNominalGlyphsFuncT(FontGetNominalGlyphsFuncT proc)
            => new PfnFontGetNominalGlyphsFuncT(proc);

        public static explicit operator FontGetNominalGlyphsFuncT(PfnFontGetNominalGlyphsFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetNominalGlyphsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint>(PfnFontGetNominalGlyphsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetNominalGlyphsFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, uint*, uint, void*, uint> ptr) => new PfnFontGetNominalGlyphsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint FontGetNominalGlyphsFuncT(FontT* arg0, void* arg1, uint arg2, uint* arg3, uint arg4, uint* arg5, uint arg6, void* arg7);
}

