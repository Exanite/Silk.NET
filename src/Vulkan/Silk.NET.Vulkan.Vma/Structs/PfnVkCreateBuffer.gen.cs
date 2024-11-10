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
    public unsafe readonly struct PfnVkCreateBuffer : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkCreateBuffer
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkCreateBuffer
        (
             VkCreateBuffer proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkCreateBuffer From(VkCreateBuffer proc) => new PfnVkCreateBuffer(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkCreateBuffer pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkCreateBuffer(nint pfn)
            => new PfnVkCreateBuffer((delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkCreateBuffer(VkCreateBuffer proc)
            => new PfnVkCreateBuffer(proc);

        public static explicit operator VkCreateBuffer(PfnVkCreateBuffer pfn)
            => SilkMarshal.PtrToDelegate<VkCreateBuffer>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result>(PfnVkCreateBuffer pfn) => pfn.Handle;
        public static implicit operator PfnVkCreateBuffer(delegate* unmanaged[Cdecl]<VkDevice_T*, Silk.NET.Vulkan.BufferCreateInfo*, VkAllocationCallbacks*, Silk.NET.Vulkan.Buffer**, Silk.NET.Vulkan.Result> ptr) => new PfnVkCreateBuffer(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkCreateBuffer(VkDevice_T* arg0, Silk.NET.Vulkan.BufferCreateInfo* arg1, VkAllocationCallbacks* arg2, Silk.NET.Vulkan.Buffer** arg3);
}

