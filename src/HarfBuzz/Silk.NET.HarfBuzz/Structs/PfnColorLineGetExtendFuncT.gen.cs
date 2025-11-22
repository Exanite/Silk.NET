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
    public unsafe readonly struct PfnColorLineGetExtendFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT> Handle => (delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT>) _handle;
        public PfnColorLineGetExtendFuncT
        (
            delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT> ptr
        ) => _handle = ptr;

        public PfnColorLineGetExtendFuncT
        (
             ColorLineGetExtendFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnColorLineGetExtendFuncT From(ColorLineGetExtendFuncT proc) => new PfnColorLineGetExtendFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnColorLineGetExtendFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnColorLineGetExtendFuncT(nint pfn)
            => new PfnColorLineGetExtendFuncT((delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT>) pfn);

        public static implicit operator PfnColorLineGetExtendFuncT(ColorLineGetExtendFuncT proc)
            => new PfnColorLineGetExtendFuncT(proc);

        public static explicit operator ColorLineGetExtendFuncT(PfnColorLineGetExtendFuncT pfn)
            => SilkMarshal.PtrToDelegate<ColorLineGetExtendFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT>(PfnColorLineGetExtendFuncT pfn) => pfn.Handle;
        public static implicit operator PfnColorLineGetExtendFuncT(delegate* unmanaged[Cdecl]<ColorLineT*, void*, void*, PaintExtendT> ptr) => new PfnColorLineGetExtendFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate PaintExtendT ColorLineGetExtendFuncT(ColorLineT* arg0, void* arg1, void* arg2);
}

