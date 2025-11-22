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
    public unsafe readonly struct PfnPaintPushClipRectangleFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void>) _handle;
        public PfnPaintPushClipRectangleFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintPushClipRectangleFuncT
        (
             PaintPushClipRectangleFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintPushClipRectangleFuncT From(PaintPushClipRectangleFuncT proc) => new PfnPaintPushClipRectangleFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintPushClipRectangleFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintPushClipRectangleFuncT(nint pfn)
            => new PfnPaintPushClipRectangleFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnPaintPushClipRectangleFuncT(PaintPushClipRectangleFuncT proc)
            => new PfnPaintPushClipRectangleFuncT(proc);

        public static explicit operator PaintPushClipRectangleFuncT(PfnPaintPushClipRectangleFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintPushClipRectangleFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void>(PfnPaintPushClipRectangleFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintPushClipRectangleFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, float, float, float, float, void*, void> ptr) => new PfnPaintPushClipRectangleFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintPushClipRectangleFuncT(PaintFuncsT* arg0, void* arg1, float arg2, float arg3, float arg4, float arg5, void* arg6);
}

