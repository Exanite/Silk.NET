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

namespace Silk.NET.Vulkan.Vma
{
    public unsafe readonly struct PfnVmaCheckDefragmentationBreakFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, uint> Handle => (delegate* unmanaged[Cdecl]<void*, uint>) _handle;
        public PfnVmaCheckDefragmentationBreakFunction
        (
            delegate* unmanaged[Cdecl]<void*, uint> ptr
        ) => _handle = ptr;

        public PfnVmaCheckDefragmentationBreakFunction
        (
             VmaCheckDefragmentationBreakFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVmaCheckDefragmentationBreakFunction From(VmaCheckDefragmentationBreakFunction proc) => new PfnVmaCheckDefragmentationBreakFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVmaCheckDefragmentationBreakFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVmaCheckDefragmentationBreakFunction(nint pfn)
            => new PfnVmaCheckDefragmentationBreakFunction((delegate* unmanaged[Cdecl]<void*, uint>) pfn);

        public static implicit operator PfnVmaCheckDefragmentationBreakFunction(VmaCheckDefragmentationBreakFunction proc)
            => new PfnVmaCheckDefragmentationBreakFunction(proc);

        public static explicit operator VmaCheckDefragmentationBreakFunction(PfnVmaCheckDefragmentationBreakFunction pfn)
            => SilkMarshal.PtrToDelegate<VmaCheckDefragmentationBreakFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, uint>(PfnVmaCheckDefragmentationBreakFunction pfn) => pfn.Handle;
        public static implicit operator PfnVmaCheckDefragmentationBreakFunction(delegate* unmanaged[Cdecl]<void*, uint> ptr) => new PfnVmaCheckDefragmentationBreakFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint VmaCheckDefragmentationBreakFunction(void* arg0);
}

