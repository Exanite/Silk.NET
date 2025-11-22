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
    public unsafe readonly struct PfnPaintPopTransformFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void>) _handle;
        public PfnPaintPopTransformFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintPopTransformFuncT
        (
             PaintPopTransformFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintPopTransformFuncT From(PaintPopTransformFuncT proc) => new PfnPaintPopTransformFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintPopTransformFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintPopTransformFuncT(nint pfn)
            => new PfnPaintPopTransformFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void>) pfn);

        public static implicit operator PfnPaintPopTransformFuncT(PaintPopTransformFuncT proc)
            => new PfnPaintPopTransformFuncT(proc);

        public static explicit operator PaintPopTransformFuncT(PfnPaintPopTransformFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintPopTransformFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void>(PfnPaintPopTransformFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintPopTransformFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, void*, void> ptr) => new PfnPaintPopTransformFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintPopTransformFuncT(PaintFuncsT* arg0, void* arg1, void* arg2);
}

