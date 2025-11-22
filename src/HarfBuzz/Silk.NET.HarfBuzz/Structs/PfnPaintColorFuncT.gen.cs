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
    public unsafe readonly struct PfnPaintColorFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void> Handle => (delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void>) _handle;
        public PfnPaintColorFuncT
        (
            delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void> ptr
        ) => _handle = ptr;

        public PfnPaintColorFuncT
        (
             PaintColorFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnPaintColorFuncT From(PaintColorFuncT proc) => new PfnPaintColorFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnPaintColorFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnPaintColorFuncT(nint pfn)
            => new PfnPaintColorFuncT((delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void>) pfn);

        public static implicit operator PfnPaintColorFuncT(PaintColorFuncT proc)
            => new PfnPaintColorFuncT(proc);

        public static explicit operator PaintColorFuncT(PfnPaintColorFuncT pfn)
            => SilkMarshal.PtrToDelegate<PaintColorFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void>(PfnPaintColorFuncT pfn) => pfn.Handle;
        public static implicit operator PfnPaintColorFuncT(delegate* unmanaged[Cdecl]<PaintFuncsT*, void*, int, uint, void*, void> ptr) => new PfnPaintColorFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PaintColorFuncT(PaintFuncsT* arg0, void* arg1, int arg2, uint arg3, void* arg4);
}

