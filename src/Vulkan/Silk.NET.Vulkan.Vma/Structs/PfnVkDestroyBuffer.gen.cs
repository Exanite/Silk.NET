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
    public unsafe readonly struct PfnVkDestroyBuffer : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void>) _handle;
        public PfnVkDestroyBuffer
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void> ptr
        ) => _handle = ptr;

        public PfnVkDestroyBuffer
        (
             VkDestroyBuffer proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkDestroyBuffer From(VkDestroyBuffer proc) => new PfnVkDestroyBuffer(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkDestroyBuffer pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkDestroyBuffer(nint pfn)
            => new PfnVkDestroyBuffer((delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void>) pfn);

        public static implicit operator PfnVkDestroyBuffer(VkDestroyBuffer proc)
            => new PfnVkDestroyBuffer(proc);

        public static explicit operator VkDestroyBuffer(PfnVkDestroyBuffer pfn)
            => SilkMarshal.PtrToDelegate<VkDestroyBuffer>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void>(PfnVkDestroyBuffer pfn) => pfn.Handle;
        public static implicit operator PfnVkDestroyBuffer(delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkAllocationCallbacks*, void> ptr) => new PfnVkDestroyBuffer(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkDestroyBuffer(VkDevice_T* arg0, VkBuffer_T* arg1, VkAllocationCallbacks* arg2);
}

