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
    public unsafe readonly struct PfnVkUnmapMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void>) _handle;
        public PfnVkUnmapMemory
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void> ptr
        ) => _handle = ptr;

        public PfnVkUnmapMemory
        (
             VkUnmapMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkUnmapMemory From(VkUnmapMemory proc) => new PfnVkUnmapMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkUnmapMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkUnmapMemory(nint pfn)
            => new PfnVkUnmapMemory((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void>) pfn);

        public static implicit operator PfnVkUnmapMemory(VkUnmapMemory proc)
            => new PfnVkUnmapMemory(proc);

        public static explicit operator VkUnmapMemory(PfnVkUnmapMemory pfn)
            => SilkMarshal.PtrToDelegate<VkUnmapMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void>(PfnVkUnmapMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkUnmapMemory(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.DeviceMemory*, void> ptr) => new PfnVkUnmapMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkUnmapMemory(Silk.NET.Vulkan.Device* arg0, Silk.NET.Vulkan.DeviceMemory* arg1);
}

