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
    public unsafe readonly struct PfnUnicodeDecomposeCompatibilityFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint> Handle => (delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint>) _handle;
        public PfnUnicodeDecomposeCompatibilityFuncT
        (
            delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint> ptr
        ) => _handle = ptr;

        public PfnUnicodeDecomposeCompatibilityFuncT
        (
             UnicodeDecomposeCompatibilityFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUnicodeDecomposeCompatibilityFuncT From(UnicodeDecomposeCompatibilityFuncT proc) => new PfnUnicodeDecomposeCompatibilityFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUnicodeDecomposeCompatibilityFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUnicodeDecomposeCompatibilityFuncT(nint pfn)
            => new PfnUnicodeDecomposeCompatibilityFuncT((delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint>) pfn);

        public static implicit operator PfnUnicodeDecomposeCompatibilityFuncT(UnicodeDecomposeCompatibilityFuncT proc)
            => new PfnUnicodeDecomposeCompatibilityFuncT(proc);

        public static explicit operator UnicodeDecomposeCompatibilityFuncT(PfnUnicodeDecomposeCompatibilityFuncT pfn)
            => SilkMarshal.PtrToDelegate<UnicodeDecomposeCompatibilityFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint>(PfnUnicodeDecomposeCompatibilityFuncT pfn) => pfn.Handle;
        public static implicit operator PfnUnicodeDecomposeCompatibilityFuncT(delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, uint*, void*, uint> ptr) => new PfnUnicodeDecomposeCompatibilityFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint UnicodeDecomposeCompatibilityFuncT(UnicodeFuncsT* arg0, uint arg1, uint* arg2, void* arg3);
}

