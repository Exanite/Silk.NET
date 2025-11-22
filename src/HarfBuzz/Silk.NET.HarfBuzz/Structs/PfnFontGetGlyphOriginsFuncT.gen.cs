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
    public unsafe readonly struct PfnFontGetGlyphOriginsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int>) _handle;
        public PfnFontGetGlyphOriginsFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontGetGlyphOriginsFuncT
        (
             FontGetGlyphOriginsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontGetGlyphOriginsFuncT From(FontGetGlyphOriginsFuncT proc) => new PfnFontGetGlyphOriginsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontGetGlyphOriginsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontGetGlyphOriginsFuncT(nint pfn)
            => new PfnFontGetGlyphOriginsFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int>) pfn);

        public static implicit operator PfnFontGetGlyphOriginsFuncT(FontGetGlyphOriginsFuncT proc)
            => new PfnFontGetGlyphOriginsFuncT(proc);

        public static explicit operator FontGetGlyphOriginsFuncT(PfnFontGetGlyphOriginsFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontGetGlyphOriginsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int>(PfnFontGetGlyphOriginsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontGetGlyphOriginsFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, uint*, uint, int*, uint, int*, uint, void*, int> ptr) => new PfnFontGetGlyphOriginsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontGetGlyphOriginsFuncT(FontT* arg0, void* arg1, uint arg2, uint* arg3, uint arg4, int* arg5, uint arg6, int* arg7, uint arg8, void* arg9);
}

