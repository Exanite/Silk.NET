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
    public unsafe readonly struct PfnVkGetDeviceImageMemoryRequirementsKHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void>) _handle;
        public PfnVkGetDeviceImageMemoryRequirementsKHR
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetDeviceImageMemoryRequirementsKHR
        (
             VkGetDeviceImageMemoryRequirementsKHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetDeviceImageMemoryRequirementsKHR From(VkGetDeviceImageMemoryRequirementsKHR proc) => new PfnVkGetDeviceImageMemoryRequirementsKHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetDeviceImageMemoryRequirementsKHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetDeviceImageMemoryRequirementsKHR(nint pfn)
            => new PfnVkGetDeviceImageMemoryRequirementsKHR((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void>) pfn);

        public static implicit operator PfnVkGetDeviceImageMemoryRequirementsKHR(VkGetDeviceImageMemoryRequirementsKHR proc)
            => new PfnVkGetDeviceImageMemoryRequirementsKHR(proc);

        public static explicit operator VkGetDeviceImageMemoryRequirementsKHR(PfnVkGetDeviceImageMemoryRequirementsKHR pfn)
            => SilkMarshal.PtrToDelegate<VkGetDeviceImageMemoryRequirementsKHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void>(PfnVkGetDeviceImageMemoryRequirementsKHR pfn) => pfn.Handle;
        public static implicit operator PfnVkGetDeviceImageMemoryRequirementsKHR(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceImageMemoryRequirements*, Silk.NET.Vulkan.MemoryRequirements2*, void> ptr) => new PfnVkGetDeviceImageMemoryRequirementsKHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetDeviceImageMemoryRequirementsKHR(Silk.NET.Vulkan.Device* arg0, Silk.NET.Vulkan.DeviceImageMemoryRequirements* arg1, Silk.NET.Vulkan.MemoryRequirements2* arg2);
}

