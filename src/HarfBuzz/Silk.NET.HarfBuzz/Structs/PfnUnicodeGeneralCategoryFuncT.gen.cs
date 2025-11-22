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
    public unsafe readonly struct PfnUnicodeGeneralCategoryFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT> Handle => (delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT>) _handle;
        public PfnUnicodeGeneralCategoryFuncT
        (
            delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT> ptr
        ) => _handle = ptr;

        public PfnUnicodeGeneralCategoryFuncT
        (
             UnicodeGeneralCategoryFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUnicodeGeneralCategoryFuncT From(UnicodeGeneralCategoryFuncT proc) => new PfnUnicodeGeneralCategoryFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUnicodeGeneralCategoryFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUnicodeGeneralCategoryFuncT(nint pfn)
            => new PfnUnicodeGeneralCategoryFuncT((delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT>) pfn);

        public static implicit operator PfnUnicodeGeneralCategoryFuncT(UnicodeGeneralCategoryFuncT proc)
            => new PfnUnicodeGeneralCategoryFuncT(proc);

        public static explicit operator UnicodeGeneralCategoryFuncT(PfnUnicodeGeneralCategoryFuncT pfn)
            => SilkMarshal.PtrToDelegate<UnicodeGeneralCategoryFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT>(PfnUnicodeGeneralCategoryFuncT pfn) => pfn.Handle;
        public static implicit operator PfnUnicodeGeneralCategoryFuncT(delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, UnicodeGeneralCategoryT> ptr) => new PfnUnicodeGeneralCategoryFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate UnicodeGeneralCategoryT UnicodeGeneralCategoryFuncT(UnicodeFuncsT* arg0, uint arg1, void* arg2);
}

