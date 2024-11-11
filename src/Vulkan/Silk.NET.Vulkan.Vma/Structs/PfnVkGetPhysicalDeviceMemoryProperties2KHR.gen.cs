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
    public unsafe readonly struct PfnVkGetPhysicalDeviceMemoryProperties2KHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void>) _handle;
        public PfnVkGetPhysicalDeviceMemoryProperties2KHR
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetPhysicalDeviceMemoryProperties2KHR
        (
             VkGetPhysicalDeviceMemoryProperties2KHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetPhysicalDeviceMemoryProperties2KHR From(VkGetPhysicalDeviceMemoryProperties2KHR proc) => new PfnVkGetPhysicalDeviceMemoryProperties2KHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetPhysicalDeviceMemoryProperties2KHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetPhysicalDeviceMemoryProperties2KHR(nint pfn)
            => new PfnVkGetPhysicalDeviceMemoryProperties2KHR((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void>) pfn);

        public static implicit operator PfnVkGetPhysicalDeviceMemoryProperties2KHR(VkGetPhysicalDeviceMemoryProperties2KHR proc)
            => new PfnVkGetPhysicalDeviceMemoryProperties2KHR(proc);

        public static explicit operator VkGetPhysicalDeviceMemoryProperties2KHR(PfnVkGetPhysicalDeviceMemoryProperties2KHR pfn)
            => SilkMarshal.PtrToDelegate<VkGetPhysicalDeviceMemoryProperties2KHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void>(PfnVkGetPhysicalDeviceMemoryProperties2KHR pfn) => pfn.Handle;
        public static implicit operator PfnVkGetPhysicalDeviceMemoryProperties2KHR(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2*, void> ptr) => new PfnVkGetPhysicalDeviceMemoryProperties2KHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetPhysicalDeviceMemoryProperties2KHR(Silk.NET.Vulkan.PhysicalDevice arg0, Silk.NET.Vulkan.PhysicalDeviceMemoryProperties2* arg1);
}

