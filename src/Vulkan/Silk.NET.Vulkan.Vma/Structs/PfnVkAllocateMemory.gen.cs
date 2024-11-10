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
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkAllocateMemory
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkAllocateMemory
        (
             VkAllocateMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkAllocateMemory From(VkAllocateMemory proc) => new PfnVkAllocateMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkAllocateMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkAllocateMemory(nint pfn)
            => new PfnVkAllocateMemory((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkAllocateMemory(VkAllocateMemory proc)
            => new PfnVkAllocateMemory(proc);

        public static explicit operator VkAllocateMemory(PfnVkAllocateMemory pfn)
            => SilkMarshal.PtrToDelegate<VkAllocateMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result>(PfnVkAllocateMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkAllocateMemory(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.MemoryAllocateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.DeviceMemory**, Silk.NET.Vulkan.Result> ptr) => new PfnVkAllocateMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkAllocateMemory(Silk.NET.Vulkan.Device* arg0, Silk.NET.Vulkan.MemoryAllocateInfo* arg1, Silk.NET.Vulkan.AllocationCallbacks* arg2, Silk.NET.Vulkan.DeviceMemory** arg3);
}

