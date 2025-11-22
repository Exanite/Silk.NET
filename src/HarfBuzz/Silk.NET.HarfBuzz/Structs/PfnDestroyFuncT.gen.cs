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
    public unsafe readonly struct PfnDestroyFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnDestroyFuncT
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnDestroyFuncT
        (
             DestroyFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnDestroyFuncT From(DestroyFuncT proc) => new PfnDestroyFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnDestroyFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnDestroyFuncT(nint pfn)
            => new PfnDestroyFuncT((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnDestroyFuncT(DestroyFuncT proc)
            => new PfnDestroyFuncT(proc);

        public static explicit operator DestroyFuncT(PfnDestroyFuncT pfn)
            => SilkMarshal.PtrToDelegate<DestroyFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnDestroyFuncT pfn) => pfn.Handle;
        public static implicit operator PfnDestroyFuncT(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnDestroyFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void DestroyFuncT(void* arg0);
}

