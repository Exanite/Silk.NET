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
    public unsafe readonly struct PfnStreamIoFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint> Handle => (delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint>) _handle;
        public PfnStreamIoFunc
        (
            delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint> ptr
        ) => _handle = ptr;

        public PfnStreamIoFunc
        (
             StreamIoFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnStreamIoFunc From(StreamIoFunc proc) => new PfnStreamIoFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnStreamIoFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnStreamIoFunc(nint pfn)
            => new PfnStreamIoFunc((delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint>) pfn);

        public static implicit operator PfnStreamIoFunc(StreamIoFunc proc)
            => new PfnStreamIoFunc(proc);

        public static explicit operator StreamIoFunc(PfnStreamIoFunc pfn)
            => SilkMarshal.PtrToDelegate<StreamIoFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint>(PfnStreamIoFunc pfn) => pfn.Handle;
        public static implicit operator PfnStreamIoFunc(delegate* unmanaged[Cdecl]<StreamRec*, uint, byte*, uint, uint> ptr) => new PfnStreamIoFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint StreamIoFunc(StreamRec* arg0, uint arg1, byte* arg2, uint arg3);
}

