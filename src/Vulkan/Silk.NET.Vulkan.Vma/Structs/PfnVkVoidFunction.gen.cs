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
    public unsafe readonly struct PfnVkVoidFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void> Handle => (delegate* unmanaged[Cdecl]<void>) _handle;
        public PfnVkVoidFunction
        (
            delegate* unmanaged[Cdecl]<void> ptr
        ) => _handle = ptr;

        public PfnVkVoidFunction
        (
             VkVoidFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkVoidFunction From(VkVoidFunction proc) => new PfnVkVoidFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkVoidFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkVoidFunction(nint pfn)
            => new PfnVkVoidFunction((delegate* unmanaged[Cdecl]<void>) pfn);

        public static implicit operator PfnVkVoidFunction(VkVoidFunction proc)
            => new PfnVkVoidFunction(proc);

        public static explicit operator VkVoidFunction(PfnVkVoidFunction pfn)
            => SilkMarshal.PtrToDelegate<VkVoidFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void>(PfnVkVoidFunction pfn) => pfn.Handle;
        public static implicit operator PfnVkVoidFunction(delegate* unmanaged[Cdecl]<void> ptr) => new PfnVkVoidFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void VkVoidFunction();
}

