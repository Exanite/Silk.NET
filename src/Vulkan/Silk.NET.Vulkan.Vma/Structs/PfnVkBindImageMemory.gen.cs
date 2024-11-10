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
    public unsafe readonly struct PfnVkBindImageMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkBindImageMemory
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkBindImageMemory
        (
             VkBindImageMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkBindImageMemory From(VkBindImageMemory proc) => new PfnVkBindImageMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkBindImageMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkBindImageMemory(nint pfn)
            => new PfnVkBindImageMemory((delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkBindImageMemory(VkBindImageMemory proc)
            => new PfnVkBindImageMemory(proc);

        public static explicit operator VkBindImageMemory(PfnVkBindImageMemory pfn)
            => SilkMarshal.PtrToDelegate<VkBindImageMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result>(PfnVkBindImageMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkBindImageMemory(delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkDeviceMemory_T*, ulong, Silk.NET.Vulkan.Result> ptr) => new PfnVkBindImageMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkBindImageMemory(VkDevice_T* arg0, Silk.NET.Vulkan.Image* arg1, VkDeviceMemory_T* arg2, ulong arg3);
}

