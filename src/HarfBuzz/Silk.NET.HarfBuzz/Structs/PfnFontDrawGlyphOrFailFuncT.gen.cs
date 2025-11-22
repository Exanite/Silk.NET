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
    public unsafe readonly struct PfnFontDrawGlyphOrFailFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int> Handle => (delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int>) _handle;
        public PfnFontDrawGlyphOrFailFuncT
        (
            delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int> ptr
        ) => _handle = ptr;

        public PfnFontDrawGlyphOrFailFuncT
        (
             FontDrawGlyphOrFailFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFontDrawGlyphOrFailFuncT From(FontDrawGlyphOrFailFuncT proc) => new PfnFontDrawGlyphOrFailFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnFontDrawGlyphOrFailFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnFontDrawGlyphOrFailFuncT(nint pfn)
            => new PfnFontDrawGlyphOrFailFuncT((delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int>) pfn);

        public static implicit operator PfnFontDrawGlyphOrFailFuncT(FontDrawGlyphOrFailFuncT proc)
            => new PfnFontDrawGlyphOrFailFuncT(proc);

        public static explicit operator FontDrawGlyphOrFailFuncT(PfnFontDrawGlyphOrFailFuncT pfn)
            => SilkMarshal.PtrToDelegate<FontDrawGlyphOrFailFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int>(PfnFontDrawGlyphOrFailFuncT pfn) => pfn.Handle;
        public static implicit operator PfnFontDrawGlyphOrFailFuncT(delegate* unmanaged[Cdecl]<FontT*, void*, uint, DrawFuncsT*, void*, void*, int> ptr) => new PfnFontDrawGlyphOrFailFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int FontDrawGlyphOrFailFuncT(FontT* arg0, void* arg1, uint arg2, DrawFuncsT* arg3, void* arg4, void* arg5);
}

