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
    public unsafe readonly struct PfnUnicodeMirroringFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint> Handle => (delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint>) _handle;
        public PfnUnicodeMirroringFuncT
        (
            delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint> ptr
        ) => _handle = ptr;

        public PfnUnicodeMirroringFuncT
        (
             UnicodeMirroringFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUnicodeMirroringFuncT From(UnicodeMirroringFuncT proc) => new PfnUnicodeMirroringFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUnicodeMirroringFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUnicodeMirroringFuncT(nint pfn)
            => new PfnUnicodeMirroringFuncT((delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint>) pfn);

        public static implicit operator PfnUnicodeMirroringFuncT(UnicodeMirroringFuncT proc)
            => new PfnUnicodeMirroringFuncT(proc);

        public static explicit operator UnicodeMirroringFuncT(PfnUnicodeMirroringFuncT pfn)
            => SilkMarshal.PtrToDelegate<UnicodeMirroringFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint>(PfnUnicodeMirroringFuncT pfn) => pfn.Handle;
        public static implicit operator PfnUnicodeMirroringFuncT(delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, uint> ptr) => new PfnUnicodeMirroringFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint UnicodeMirroringFuncT(UnicodeFuncsT* arg0, uint arg1, void* arg2);
}

