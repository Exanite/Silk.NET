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
    public unsafe readonly struct PfnDrawCubicToFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void> Handle => (delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void>) _handle;
        public PfnDrawCubicToFuncT
        (
            delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void> ptr
        ) => _handle = ptr;

        public PfnDrawCubicToFuncT
        (
             DrawCubicToFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDrawCubicToFuncT From(DrawCubicToFuncT proc) => new PfnDrawCubicToFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDrawCubicToFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDrawCubicToFuncT(nint pfn)
            => new PfnDrawCubicToFuncT((delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void>) pfn);

        public static implicit operator PfnDrawCubicToFuncT(DrawCubicToFuncT proc)
            => new PfnDrawCubicToFuncT(proc);

        public static explicit operator DrawCubicToFuncT(PfnDrawCubicToFuncT pfn)
            => SilkMarshal.PtrToDelegate<DrawCubicToFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void>(PfnDrawCubicToFuncT pfn) => pfn.Handle;
        public static implicit operator PfnDrawCubicToFuncT(delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, float, float, float, float, float, float, void*, void> ptr) => new PfnDrawCubicToFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DrawCubicToFuncT(DrawFuncsT* arg0, void* arg1, DrawStateT* arg2, float arg3, float arg4, float arg5, float arg6, float arg7, float arg8, void* arg9);
}

