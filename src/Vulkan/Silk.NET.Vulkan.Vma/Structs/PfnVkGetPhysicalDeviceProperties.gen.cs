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
    public unsafe readonly struct PfnVkGetPhysicalDeviceProperties : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void>) _handle;
        public PfnVkGetPhysicalDeviceProperties
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetPhysicalDeviceProperties
        (
             VkGetPhysicalDeviceProperties proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetPhysicalDeviceProperties From(VkGetPhysicalDeviceProperties proc) => new PfnVkGetPhysicalDeviceProperties(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetPhysicalDeviceProperties pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetPhysicalDeviceProperties(nint pfn)
            => new PfnVkGetPhysicalDeviceProperties((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void>) pfn);

        public static implicit operator PfnVkGetPhysicalDeviceProperties(VkGetPhysicalDeviceProperties proc)
            => new PfnVkGetPhysicalDeviceProperties(proc);

        public static explicit operator VkGetPhysicalDeviceProperties(PfnVkGetPhysicalDeviceProperties pfn)
            => SilkMarshal.PtrToDelegate<VkGetPhysicalDeviceProperties>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void>(PfnVkGetPhysicalDeviceProperties pfn) => pfn.Handle;
        public static implicit operator PfnVkGetPhysicalDeviceProperties(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.PhysicalDevice*, Silk.NET.Vulkan.PhysicalDeviceProperties*, void> ptr) => new PfnVkGetPhysicalDeviceProperties(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetPhysicalDeviceProperties(Silk.NET.Vulkan.PhysicalDevice* arg0, Silk.NET.Vulkan.PhysicalDeviceProperties* arg1);
}

