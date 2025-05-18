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
    public unsafe readonly struct PfnVkMapMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkMapMemory
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkMapMemory
        (
             VkMapMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkMapMemory From(VkMapMemory proc) => new PfnVkMapMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkMapMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkMapMemory(nint pfn)
            => new PfnVkMapMemory((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkMapMemory(VkMapMemory proc)
            => new PfnVkMapMemory(proc);

        public static explicit operator VkMapMemory(PfnVkMapMemory pfn)
            => SilkMarshal.PtrToDelegate<VkMapMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result>(PfnVkMapMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkMapMemory(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.DeviceMemory, ulong, ulong, uint, void**, Silk.NET.Vulkan.Result> ptr) => new PfnVkMapMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkMapMemory(Silk.NET.Vulkan.Device arg0, Silk.NET.Vulkan.DeviceMemory arg1, ulong arg2, ulong arg3, uint arg4, void** arg5);
}

