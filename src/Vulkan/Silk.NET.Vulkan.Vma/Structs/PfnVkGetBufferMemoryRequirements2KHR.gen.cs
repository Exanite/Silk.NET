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
    public unsafe readonly struct PfnVkGetBufferMemoryRequirements2KHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>) _handle;
        public PfnVkGetBufferMemoryRequirements2KHR
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetBufferMemoryRequirements2KHR
        (
             VkGetBufferMemoryRequirements2KHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetBufferMemoryRequirements2KHR From(VkGetBufferMemoryRequirements2KHR proc) => new PfnVkGetBufferMemoryRequirements2KHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetBufferMemoryRequirements2KHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetBufferMemoryRequirements2KHR(nint pfn)
            => new PfnVkGetBufferMemoryRequirements2KHR((delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>) pfn);

        public static implicit operator PfnVkGetBufferMemoryRequirements2KHR(VkGetBufferMemoryRequirements2KHR proc)
            => new PfnVkGetBufferMemoryRequirements2KHR(proc);

        public static explicit operator VkGetBufferMemoryRequirements2KHR(PfnVkGetBufferMemoryRequirements2KHR pfn)
            => SilkMarshal.PtrToDelegate<VkGetBufferMemoryRequirements2KHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>(PfnVkGetBufferMemoryRequirements2KHR pfn) => pfn.Handle;
        public static implicit operator PfnVkGetBufferMemoryRequirements2KHR(delegate* unmanaged[Cdecl]<VkDevice_T*, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> ptr) => new PfnVkGetBufferMemoryRequirements2KHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetBufferMemoryRequirements2KHR(VkDevice_T* arg0, VkBufferMemoryRequirementsInfo2* arg1, VkMemoryRequirements2* arg2);
}

