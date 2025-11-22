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
    public unsafe readonly struct PfnPaintLinearGradientFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void>) _handle;
        public PfnPaintLinearGradientFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintLinearGradientFuncT
        (
             PaintLinearGradientFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintLinearGradientFuncT From(PaintLinearGradientFuncT proc) => new PfnPaintLinearGradientFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintLinearGradientFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintLinearGradientFuncT(nint pfn)
            => new PfnPaintLinearGradientFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnPaintLinearGradientFuncT(PaintLinearGradientFuncT proc)
            => new PfnPaintLinearGradientFuncT(proc);

        public static explicit operator PaintLinearGradientFuncT(PfnPaintLinearGradientFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintLinearGradientFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void>(PfnPaintLinearGradientFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintLinearGradientFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, float, float, void*, void> ptr) => new PfnPaintLinearGradientFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintLinearGradientFuncT(PaintFuncsT* arg0, void* arg1, ColorLineT* arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, void* arg9);
}

