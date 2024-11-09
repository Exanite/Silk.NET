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
    public unsafe readonly struct PfnVkBindBufferMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult>) _handle;
        public PfnVkBindBufferMemory
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult> ptr
        ) => _handle = ptr;

        public PfnVkBindBufferMemory
        (
             VkBindBufferMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkBindBufferMemory From(VkBindBufferMemory proc) => new PfnVkBindBufferMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkBindBufferMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkBindBufferMemory(nint pfn)
            => new PfnVkBindBufferMemory((delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult>) pfn);

        public static implicit operator PfnVkBindBufferMemory(VkBindBufferMemory proc)
            => new PfnVkBindBufferMemory(proc);

        public static explicit operator VkBindBufferMemory(PfnVkBindBufferMemory pfn)
            => SilkMarshal.PtrToDelegate<VkBindBufferMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult>(PfnVkBindBufferMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkBindBufferMemory(delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkDeviceMemory_T*, ulong, VkResult> ptr) => new PfnVkBindBufferMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult VkBindBufferMemory(VkDevice_T* arg0, VkBuffer_T* arg1, VkDeviceMemory_T* arg2, ulong arg3);
}

