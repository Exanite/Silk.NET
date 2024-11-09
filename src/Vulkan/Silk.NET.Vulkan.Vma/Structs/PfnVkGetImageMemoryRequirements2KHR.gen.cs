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
    public unsafe readonly struct PfnVkGetImageMemoryRequirements2KHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>) _handle;
        public PfnVkGetImageMemoryRequirements2KHR
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetImageMemoryRequirements2KHR
        (
             VkGetImageMemoryRequirements2KHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetImageMemoryRequirements2KHR From(VkGetImageMemoryRequirements2KHR proc) => new PfnVkGetImageMemoryRequirements2KHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetImageMemoryRequirements2KHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetImageMemoryRequirements2KHR(nint pfn)
            => new PfnVkGetImageMemoryRequirements2KHR((delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>) pfn);

        public static implicit operator PfnVkGetImageMemoryRequirements2KHR(VkGetImageMemoryRequirements2KHR proc)
            => new PfnVkGetImageMemoryRequirements2KHR(proc);

        public static explicit operator VkGetImageMemoryRequirements2KHR(PfnVkGetImageMemoryRequirements2KHR pfn)
            => SilkMarshal.PtrToDelegate<VkGetImageMemoryRequirements2KHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void>(PfnVkGetImageMemoryRequirements2KHR pfn) => pfn.Handle;
        public static implicit operator PfnVkGetImageMemoryRequirements2KHR(delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> ptr) => new PfnVkGetImageMemoryRequirements2KHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetImageMemoryRequirements2KHR(VkDevice_T* arg0, VkImageMemoryRequirementsInfo2* arg1, VkMemoryRequirements2* arg2);
}

