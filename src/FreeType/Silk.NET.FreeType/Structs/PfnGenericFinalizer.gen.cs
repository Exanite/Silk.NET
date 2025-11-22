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

namespace Silk.NET.FreeType
{
    public unsafe readonly struct PfnGenericFinalizer : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnGenericFinalizer
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnGenericFinalizer
        (
             GenericFinalizer proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnGenericFinalizer From(GenericFinalizer proc) => new PfnGenericFinalizer(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnGenericFinalizer pfn) => (nint) pfn.Handle;
        public static explicit operator PfnGenericFinalizer(nint pfn)
            => new PfnGenericFinalizer((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnGenericFinalizer(GenericFinalizer proc)
            => new PfnGenericFinalizer(proc);

        public static explicit operator GenericFinalizer(PfnGenericFinalizer pfn)
            => SilkMarshal.PtrToDelegate<GenericFinalizer>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnGenericFinalizer pfn) => pfn.Handle;
        public static implicit operator PfnGenericFinalizer(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnGenericFinalizer(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void GenericFinalizer(void* arg0);
}

