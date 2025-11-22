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
    public unsafe readonly struct PfnDrawClosePathFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void> Handle => (delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void>) _handle;
        public PfnDrawClosePathFuncT
        (
            delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void> ptr
        ) => _handle = ptr;

        public PfnDrawClosePathFuncT
        (
             DrawClosePathFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDrawClosePathFuncT From(DrawClosePathFuncT proc) => new PfnDrawClosePathFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDrawClosePathFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDrawClosePathFuncT(nint pfn)
            => new PfnDrawClosePathFuncT((delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void>) pfn);

        public static implicit operator PfnDrawClosePathFuncT(DrawClosePathFuncT proc)
            => new PfnDrawClosePathFuncT(proc);

        public static explicit operator DrawClosePathFuncT(PfnDrawClosePathFuncT pfn)
            => SilkMarshal.PtrToDelegate<DrawClosePathFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void>(PfnDrawClosePathFuncT pfn) => pfn.Handle;
        public static implicit operator PfnDrawClosePathFuncT(delegate* unmanaged[Cdecl]<DrawFuncsT*, void*, DrawStateT*, void*, void> ptr) => new PfnDrawClosePathFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DrawClosePathFuncT(DrawFuncsT* arg0, void* arg1, DrawStateT* arg2, void* arg3);
}

