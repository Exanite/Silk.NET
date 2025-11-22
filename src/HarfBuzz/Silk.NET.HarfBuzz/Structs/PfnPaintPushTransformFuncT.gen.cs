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
    public unsafe readonly struct PfnPaintPushTransformFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void>) _handle;
        public PfnPaintPushTransformFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintPushTransformFuncT
        (
             PaintPushTransformFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintPushTransformFuncT From(PaintPushTransformFuncT proc) => new PfnPaintPushTransformFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintPushTransformFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintPushTransformFuncT(nint pfn)
            => new PfnPaintPushTransformFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnPaintPushTransformFuncT(PaintPushTransformFuncT proc)
            => new PfnPaintPushTransformFuncT(proc);

        public static explicit operator PaintPushTransformFuncT(PfnPaintPushTransformFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintPushTransformFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void>(PfnPaintPushTransformFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintPushTransformFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, float, float, void*, void> ptr) => new PfnPaintPushTransformFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintPushTransformFuncT(PaintFuncsT* arg0, void* arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7, void* arg8);
}

