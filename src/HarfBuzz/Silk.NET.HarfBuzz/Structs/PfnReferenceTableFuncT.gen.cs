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
    public unsafe readonly struct PfnReferenceTableFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*> Handle => (delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*>) _handle;
        public PfnReferenceTableFuncT
        (
            delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*> ptr
        ) => _handle = ptr;

        public PfnReferenceTableFuncT
        (
             ReferenceTableFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnReferenceTableFuncT From(ReferenceTableFuncT proc) => new PfnReferenceTableFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnReferenceTableFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnReferenceTableFuncT(nint pfn)
            => new PfnReferenceTableFuncT((delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*>) pfn);

        public static implicit operator PfnReferenceTableFuncT(ReferenceTableFuncT proc)
            => new PfnReferenceTableFuncT(proc);

        public static explicit operator ReferenceTableFuncT(PfnReferenceTableFuncT pfn)
            => SilkMarshal.PtrToDelegate<ReferenceTableFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*>(PfnReferenceTableFuncT pfn) => pfn.Handle;
        public static implicit operator PfnReferenceTableFuncT(delegate* unmanaged[Cdecl]<FaceT*, uint, void*, BlobT*> ptr) => new PfnReferenceTableFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate BlobT* ReferenceTableFuncT(FaceT* arg0, uint arg1, void* arg2);
}

