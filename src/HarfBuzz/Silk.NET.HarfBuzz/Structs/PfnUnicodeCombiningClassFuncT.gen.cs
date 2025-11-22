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
    public unsafe readonly struct PfnUnicodeCombiningClassFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT> Handle => (delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT>) _handle;
        public PfnUnicodeCombiningClassFuncT
        (
            delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT> ptr
        ) => _handle = ptr;

        public PfnUnicodeCombiningClassFuncT
        (
             UnicodeCombiningClassFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUnicodeCombiningClassFuncT From(UnicodeCombiningClassFuncT proc) => new PfnUnicodeCombiningClassFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUnicodeCombiningClassFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUnicodeCombiningClassFuncT(nint pfn)
            => new PfnUnicodeCombiningClassFuncT((delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT>) pfn);

        public static implicit operator PfnUnicodeCombiningClassFuncT(UnicodeCombiningClassFuncT proc)
            => new PfnUnicodeCombiningClassFuncT(proc);

        public static explicit operator UnicodeCombiningClassFuncT(PfnUnicodeCombiningClassFuncT pfn)
            => SilkMarshal.PtrToDelegate<UnicodeCombiningClassFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT>(PfnUnicodeCombiningClassFuncT pfn) => pfn.Handle;
        public static implicit operator PfnUnicodeCombiningClassFuncT(delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeCombiningClassT> ptr) => new PfnUnicodeCombiningClassFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate UnicodeCombiningClassT UnicodeCombiningClassFuncT(UnicodeFuncsT* arg0, uint arg1, void* arg2);
}

