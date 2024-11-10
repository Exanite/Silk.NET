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
    public unsafe readonly struct PfnVmaAllocateDeviceMemoryFunction : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void> Handle => (delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void>) _handle;
        public PfnVmaAllocateDeviceMemoryFunction
        (
            delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void> ptr
        ) => _handle = ptr;

        public PfnVmaAllocateDeviceMemoryFunction
        (
             VmaAllocateDeviceMemoryFunction proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVmaAllocateDeviceMemoryFunction From(VmaAllocateDeviceMemoryFunction proc) => new PfnVmaAllocateDeviceMemoryFunction(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVmaAllocateDeviceMemoryFunction pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVmaAllocateDeviceMemoryFunction(nint pfn)
            => new PfnVmaAllocateDeviceMemoryFunction((delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void>) pfn);

        public static implicit operator PfnVmaAllocateDeviceMemoryFunction(VmaAllocateDeviceMemoryFunction proc)
            => new PfnVmaAllocateDeviceMemoryFunction(proc);

        public static explicit operator VmaAllocateDeviceMemoryFunction(PfnVmaAllocateDeviceMemoryFunction pfn)
            => SilkMarshal.PtrToDelegate<VmaAllocateDeviceMemoryFunction>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void>(PfnVmaAllocateDeviceMemoryFunction pfn) => pfn.Handle;
        public static implicit operator PfnVmaAllocateDeviceMemoryFunction(delegate* unmanaged[Cdecl]<Allocator*, uint, Silk.NET.Vulkan.DeviceMemory*, ulong, void*, void> ptr) => new PfnVmaAllocateDeviceMemoryFunction(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VmaAllocateDeviceMemoryFunction(Allocator* arg0, uint arg1, Silk.NET.Vulkan.DeviceMemory* arg2, ulong arg3, void* arg4);
}

