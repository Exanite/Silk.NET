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
    public unsafe readonly struct PfnVkGetPhysicalDeviceMemoryProperties : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void> Handle => (delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void>) _handle;
        public PfnVkGetPhysicalDeviceMemoryProperties
        (
            delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetPhysicalDeviceMemoryProperties
        (
             VkGetPhysicalDeviceMemoryProperties proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetPhysicalDeviceMemoryProperties From(VkGetPhysicalDeviceMemoryProperties proc) => new PfnVkGetPhysicalDeviceMemoryProperties(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetPhysicalDeviceMemoryProperties pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetPhysicalDeviceMemoryProperties(nint pfn)
            => new PfnVkGetPhysicalDeviceMemoryProperties((delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void>) pfn);

        public static implicit operator PfnVkGetPhysicalDeviceMemoryProperties(VkGetPhysicalDeviceMemoryProperties proc)
            => new PfnVkGetPhysicalDeviceMemoryProperties(proc);

        public static explicit operator VkGetPhysicalDeviceMemoryProperties(PfnVkGetPhysicalDeviceMemoryProperties pfn)
            => SilkMarshal.PtrToDelegate<VkGetPhysicalDeviceMemoryProperties>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void>(PfnVkGetPhysicalDeviceMemoryProperties pfn) => pfn.Handle;
        public static implicit operator PfnVkGetPhysicalDeviceMemoryProperties(delegate* unmanaged[Cdecl]<VkPhysicalDevice_T*, VkPhysicalDeviceMemoryProperties*, void> ptr) => new PfnVkGetPhysicalDeviceMemoryProperties(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice_T* arg0, VkPhysicalDeviceMemoryProperties* arg1);
}

