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
    public unsafe readonly struct PfnDrawMoveToFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void>) _handle;
        public PfnDrawMoveToFuncT
        (
            delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnDrawMoveToFuncT
        (
             DrawMoveToFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDrawMoveToFuncT From(DrawMoveToFuncT proc) => new PfnDrawMoveToFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDrawMoveToFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDrawMoveToFuncT(nint pfn)
            => new PfnDrawMoveToFuncT((delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void>) pfn);

        public static implicit operator PfnDrawMoveToFuncT(DrawMoveToFuncT proc)
            => new PfnDrawMoveToFuncT(proc);

        public static explicit operator DrawMoveToFuncT(PfnDrawMoveToFuncT pfn)
            => SilkMarshal.PtrToDelegate<DrawMoveToFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void>(PfnDrawMoveToFuncT pfn) => pfn.Handle;
        public static implicit operator PfnDrawMoveToFuncT(delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, void*, void> ptr) => new PfnDrawMoveToFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DrawMoveToFuncT(DrawFuncsT* arg0, void* arg1, DrawStateT* arg2, float arg3, float arg4, void* arg5);
}

