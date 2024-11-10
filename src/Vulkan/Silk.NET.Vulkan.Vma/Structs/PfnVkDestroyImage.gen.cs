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
    public unsafe readonly struct PfnVkDestroyImage : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void>) _handle;
        public PfnVkDestroyImage
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void> ptr
        ) => _handle = ptr;

        public PfnVkDestroyImage
        (
             VkDestroyImage proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkDestroyImage From(VkDestroyImage proc) => new PfnVkDestroyImage(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkDestroyImage pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkDestroyImage(nint pfn)
            => new PfnVkDestroyImage((delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void>) pfn);

        public static implicit operator PfnVkDestroyImage(VkDestroyImage proc)
            => new PfnVkDestroyImage(proc);

        public static explicit operator VkDestroyImage(PfnVkDestroyImage pfn)
            => SilkMarshal.PtrToDelegate<VkDestroyImage>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void>(PfnVkDestroyImage pfn) => pfn.Handle;
        public static implicit operator PfnVkDestroyImage(delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.Image*, VkAllocationCallbacks*, void> ptr) => new PfnVkDestroyImage(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkDestroyImage(VkDevice_T* arg0, Silk.NET.Vulkan.Image* arg1, VkAllocationCallbacks* arg2);
}

