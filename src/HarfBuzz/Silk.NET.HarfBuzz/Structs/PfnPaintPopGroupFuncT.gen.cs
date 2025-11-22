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
    public unsafe readonly struct PfnPaintPopGroupFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void>) _handle;
        public PfnPaintPopGroupFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintPopGroupFuncT
        (
             PaintPopGroupFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintPopGroupFuncT From(PaintPopGroupFuncT proc) => new PfnPaintPopGroupFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintPopGroupFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintPopGroupFuncT(nint pfn)
            => new PfnPaintPopGroupFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void>) pfn);

        public static implicit operator PfnPaintPopGroupFuncT(PaintPopGroupFuncT proc)
            => new PfnPaintPopGroupFuncT(proc);

        public static explicit operator PaintPopGroupFuncT(PfnPaintPopGroupFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintPopGroupFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void>(PfnPaintPopGroupFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintPopGroupFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, PaintCompositeModeT, void*, void> ptr) => new PfnPaintPopGroupFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintPopGroupFuncT(PaintFuncsT* arg0, void* arg1, PaintCompositeModeT arg2, void* arg3);
}

