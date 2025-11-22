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
    public unsafe readonly struct PfnAllocFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<MemoryRec*, int, void*> Handle => (delegate* unmanaged[Cdecl]<MemoryRec*, int, void*>) _handle;
        public PfnAllocFunc
        (
            delegate* unmanaged[Cdecl]<MemoryRec*, int, void*> ptr
        ) => _handle = ptr;

        public PfnAllocFunc
        (
             AllocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnAllocFunc From(AllocFunc proc) => new PfnAllocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnAllocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnAllocFunc(nint pfn)
            => new PfnAllocFunc((delegate* unmanaged[Cdecl]<MemoryRec*, int, void*>) pfn);

        public static implicit operator PfnAllocFunc(AllocFunc proc)
            => new PfnAllocFunc(proc);

        public static explicit operator AllocFunc(PfnAllocFunc pfn)
            => SilkMarshal.PtrToDelegate<AllocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<MemoryRec*, int, void*>(PfnAllocFunc pfn) => pfn.Handle;
        public static implicit operator PfnAllocFunc(delegate* unmanaged[Cdecl]<MemoryRec*, int, void*> ptr) => new PfnAllocFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* AllocFunc(MemoryRec* arg0, int arg1);
}

