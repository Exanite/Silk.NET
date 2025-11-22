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
    public unsafe readonly struct PfnPaintSweepGradientFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void>) _handle;
        public PfnPaintSweepGradientFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintSweepGradientFuncT
        (
             PaintSweepGradientFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintSweepGradientFuncT From(PaintSweepGradientFuncT proc) => new PfnPaintSweepGradientFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintSweepGradientFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintSweepGradientFuncT(nint pfn)
            => new PfnPaintSweepGradientFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnPaintSweepGradientFuncT(PaintSweepGradientFuncT proc)
            => new PfnPaintSweepGradientFuncT(proc);

        public static explicit operator PaintSweepGradientFuncT(PfnPaintSweepGradientFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintSweepGradientFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void>(PfnPaintSweepGradientFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintSweepGradientFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, ColorLineT*, float, float, float, float, void*, void> ptr) => new PfnPaintSweepGradientFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintSweepGradientFuncT(PaintFuncsT* arg0, void* arg1, ColorLineT* arg2, float arg3, float arg4, float arg5, float arg6, void* arg7);
}

