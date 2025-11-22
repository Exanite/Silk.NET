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
    public unsafe readonly struct PfnStreamCloseFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<StreamRec*, void> Handle => (delegate* unmanaged[Cdecl]<StreamRec*, void>) _handle;
        public PfnStreamCloseFunc
        (
            delegate* unmanaged[Cdecl]<StreamRec*, void> ptr
        ) => _handle = ptr;

        public PfnStreamCloseFunc
        (
             StreamCloseFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnStreamCloseFunc From(StreamCloseFunc proc) => new PfnStreamCloseFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnStreamCloseFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnStreamCloseFunc(nint pfn)
            => new PfnStreamCloseFunc((delegate* unmanaged[Cdecl]<StreamRec*, void>) pfn);

        public static implicit operator PfnStreamCloseFunc(StreamCloseFunc proc)
            => new PfnStreamCloseFunc(proc);

        public static explicit operator StreamCloseFunc(PfnStreamCloseFunc pfn)
            => SilkMarshal.PtrToDelegate<StreamCloseFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<StreamRec*, void>(PfnStreamCloseFunc pfn) => pfn.Handle;
        public static implicit operator PfnStreamCloseFunc(delegate* unmanaged[Cdecl]<StreamRec*, void> ptr) => new PfnStreamCloseFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void StreamCloseFunc(StreamRec* arg0);
}

