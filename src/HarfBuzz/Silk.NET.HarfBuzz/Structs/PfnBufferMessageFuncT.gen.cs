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
    public unsafe readonly struct PfnBufferMessageFuncT : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int> Handle => (delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int>) _handle;
        public PfnBufferMessageFuncT
        (
            delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int> ptr
        ) => _handle = ptr;

        public PfnBufferMessageFuncT
        (
             BufferMessageFuncT proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnBufferMessageFuncT From(BufferMessageFuncT proc) => new PfnBufferMessageFuncT(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnBufferMessageFuncT pfn) => (nint) pfn.Handle;
        public static explicit operator PfnBufferMessageFuncT(nint pfn)
            => new PfnBufferMessageFuncT((delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int>) pfn);

        public static implicit operator PfnBufferMessageFuncT(BufferMessageFuncT proc)
            => new PfnBufferMessageFuncT(proc);

        public static explicit operator BufferMessageFuncT(PfnBufferMessageFuncT pfn)
            => SilkMarshal.PtrToDelegate<BufferMessageFuncT>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int>(PfnBufferMessageFuncT pfn) => pfn.Handle;
        public static implicit operator PfnBufferMessageFuncT(delegate* unmanaged[Cdecl]<BufferT*, FontT*, byte*, void*, int> ptr) => new PfnBufferMessageFuncT(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int BufferMessageFuncT(BufferT* arg0, FontT* arg1, byte* arg2, void* arg3);
}

