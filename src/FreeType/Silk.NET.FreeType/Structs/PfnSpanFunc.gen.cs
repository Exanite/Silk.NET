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

namespace Silk.NET.FreeType
{
    public unsafe readonly struct PfnSpanFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<int, int, Span*, void*, void> Handle => (delegate* unmanaged[Cdecl]<int, int, Span*, void*, void>) _handle;
        public PfnSpanFunc
        (
            delegate* unmanaged[Cdecl]<int, int, Span*, void*, void> ptr
        ) => _handle = ptr;

        public PfnSpanFunc
        (
             SpanFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnSpanFunc From(SpanFunc proc) => new PfnSpanFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnSpanFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnSpanFunc(nint pfn)
            => new PfnSpanFunc((delegate* unmanaged[Cdecl]<int, int, Span*, void*, void>) pfn);

        public static implicit operator PfnSpanFunc(SpanFunc proc)
            => new PfnSpanFunc(proc);

        public static explicit operator SpanFunc(PfnSpanFunc pfn)
            => SilkMarshal.PtrToDelegate<SpanFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<int, int, Span*, void*, void>(PfnSpanFunc pfn) => pfn.Handle;
        public static implicit operator PfnSpanFunc(delegate* unmanaged[Cdecl]<int, int, Span*, void*, void> ptr) => new PfnSpanFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SpanFunc(int arg0, int arg1, Span* arg2, void* arg3);
}

