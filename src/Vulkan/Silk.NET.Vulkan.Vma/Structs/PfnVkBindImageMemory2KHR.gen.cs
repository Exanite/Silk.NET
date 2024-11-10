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
    public unsafe readonly struct PfnVkBindImageMemory2KHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkBindImageMemory2KHR
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkBindImageMemory2KHR
        (
             VkBindImageMemory2KHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkBindImageMemory2KHR From(VkBindImageMemory2KHR proc) => new PfnVkBindImageMemory2KHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkBindImageMemory2KHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkBindImageMemory2KHR(nint pfn)
            => new PfnVkBindImageMemory2KHR((delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkBindImageMemory2KHR(VkBindImageMemory2KHR proc)
            => new PfnVkBindImageMemory2KHR(proc);

        public static explicit operator VkBindImageMemory2KHR(PfnVkBindImageMemory2KHR pfn)
            => SilkMarshal.PtrToDelegate<VkBindImageMemory2KHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result>(PfnVkBindImageMemory2KHR pfn) => pfn.Handle;
        public static implicit operator PfnVkBindImageMemory2KHR(delegate* unmanaged[Cdecl]<VkDevice_T*, uint, VkBindImageMemoryInfo*, Silk.NET.Vulkan.Result> ptr) => new PfnVkBindImageMemory2KHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkBindImageMemory2KHR(VkDevice_T* arg0, uint arg1, VkBindImageMemoryInfo* arg2);
}

