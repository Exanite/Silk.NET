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
    public unsafe readonly struct PfnUnicodeScriptFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT> Handle => (delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT>) _handle;
        public PfnUnicodeScriptFuncT
        (
            delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT> ptr
        ) => _handle = ptr;

        public PfnUnicodeScriptFuncT
        (
             UnicodeScriptFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnUnicodeScriptFuncT From(UnicodeScriptFuncT proc) => new PfnUnicodeScriptFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnUnicodeScriptFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnUnicodeScriptFuncT(nint pfn)
            => new PfnUnicodeScriptFuncT((delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT>) pfn);

        public static implicit operator PfnUnicodeScriptFuncT(UnicodeScriptFuncT proc)
            => new PfnUnicodeScriptFuncT(proc);

        public static explicit operator UnicodeScriptFuncT(PfnUnicodeScriptFuncT pfn)
            => SilkMarshal.PtrToDelegate<UnicodeScriptFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT>(PfnUnicodeScriptFuncT pfn) => pfn.Handle;
        public static implicit operator PfnUnicodeScriptFuncT(delegate* unmanaged[Cdecl]<UnicodeFuncsT*, uint, void*, ScriptT> ptr) => new PfnUnicodeScriptFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate ScriptT UnicodeScriptFuncT(UnicodeFuncsT* arg0, uint arg1, void* arg2);
}

