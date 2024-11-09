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
    public unsafe readonly struct PfnVkFreeMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void>) _handle;
        public PfnVkFreeMemory
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void> ptr
        ) => _handle = ptr;

        public PfnVkFreeMemory
        (
             VkFreeMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkFreeMemory From(VkFreeMemory proc) => new PfnVkFreeMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkFreeMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkFreeMemory(nint pfn)
            => new PfnVkFreeMemory((delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void>) pfn);

        public static implicit operator PfnVkFreeMemory(VkFreeMemory proc)
            => new PfnVkFreeMemory(proc);

        public static explicit operator VkFreeMemory(PfnVkFreeMemory pfn)
            => SilkMarshal.PtrToDelegate<VkFreeMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void>(PfnVkFreeMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkFreeMemory(delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, VkAllocationCallbacks*, void> ptr) => new PfnVkFreeMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkFreeMemory(VkDevice_T* arg0, VkDeviceMemory_T* arg1, VkAllocationCallbacks* arg2);
}

