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
    public unsafe readonly struct PfnVkAllocateMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult>) _handle;
        public PfnVkAllocateMemory
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult> ptr
        ) => _handle = ptr;

        public PfnVkAllocateMemory
        (
             VkAllocateMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkAllocateMemory From(VkAllocateMemory proc) => new PfnVkAllocateMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkAllocateMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkAllocateMemory(nint pfn)
            => new PfnVkAllocateMemory((delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult>) pfn);

        public static implicit operator PfnVkAllocateMemory(VkAllocateMemory proc)
            => new PfnVkAllocateMemory(proc);

        public static explicit operator VkAllocateMemory(PfnVkAllocateMemory pfn)
            => SilkMarshal.PtrToDelegate<VkAllocateMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult>(PfnVkAllocateMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkAllocateMemory(delegate* unmanaged[Cdecl]<VkDevice_T*, VkMemoryAllocateInfo*, VkAllocationCallbacks*, VkDeviceMemory_T**, VkResult> ptr) => new PfnVkAllocateMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult VkAllocateMemory(VkDevice_T* arg0, VkMemoryAllocateInfo* arg1, VkAllocationCallbacks* arg2, VkDeviceMemory_T** arg3);
}

