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
    public unsafe readonly struct PfnDrawQuadraticToFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void>) _handle;
        public PfnDrawQuadraticToFuncT
        (
            delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnDrawQuadraticToFuncT
        (
             DrawQuadraticToFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDrawQuadraticToFuncT From(DrawQuadraticToFuncT proc) => new PfnDrawQuadraticToFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDrawQuadraticToFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDrawQuadraticToFuncT(nint pfn)
            => new PfnDrawQuadraticToFuncT((delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnDrawQuadraticToFuncT(DrawQuadraticToFuncT proc)
            => new PfnDrawQuadraticToFuncT(proc);

        public static explicit operator DrawQuadraticToFuncT(PfnDrawQuadraticToFuncT pfn)
            => SilkMarshal.PtrToDelegate<DrawQuadraticToFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void>(PfnDrawQuadraticToFuncT pfn) => pfn.Handle;
        public static implicit operator PfnDrawQuadraticToFuncT(delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, void*, void> ptr) => new PfnDrawQuadraticToFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DrawQuadraticToFuncT(DrawFuncsT* arg0, void* arg1, DrawStateT* arg2, float arg3, float arg4, float arg5, float arg6, void* arg7);
}

