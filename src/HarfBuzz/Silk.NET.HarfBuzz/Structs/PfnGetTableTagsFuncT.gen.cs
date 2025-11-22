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
    public unsafe readonly struct PfnGetTableTagsFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint> Handle => (delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint>) _handle;
        public PfnGetTableTagsFuncT
        (
            delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint> ptr
        ) => _handle = ptr;

        public PfnGetTableTagsFuncT
        (
             GetTableTagsFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnGetTableTagsFuncT From(GetTableTagsFuncT proc) => new PfnGetTableTagsFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnGetTableTagsFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnGetTableTagsFuncT(nint pfn)
            => new PfnGetTableTagsFuncT((delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint>) pfn);

        public static implicit operator PfnGetTableTagsFuncT(GetTableTagsFuncT proc)
            => new PfnGetTableTagsFuncT(proc);

        public static explicit operator GetTableTagsFuncT(PfnGetTableTagsFuncT pfn)
            => SilkMarshal.PtrToDelegate<GetTableTagsFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint>(PfnGetTableTagsFuncT pfn) => pfn.Handle;
        public static implicit operator PfnGetTableTagsFuncT(delegate* unmanaged[Cdecl]<FaceT*, uint, uint*, uint*, void*, uint> ptr) => new PfnGetTableTagsFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint GetTableTagsFuncT(FaceT* arg0, uint arg1, uint* arg2, uint* arg3, void* arg4);
}

