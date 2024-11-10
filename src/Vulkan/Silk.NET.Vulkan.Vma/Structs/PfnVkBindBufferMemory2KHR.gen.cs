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
    public unsafe readonly struct PfnVkBindBufferMemory2KHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkBindBufferMemory2KHR
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkBindBufferMemory2KHR
        (
             VkBindBufferMemory2KHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkBindBufferMemory2KHR From(VkBindBufferMemory2KHR proc) => new PfnVkBindBufferMemory2KHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkBindBufferMemory2KHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkBindBufferMemory2KHR(nint pfn)
            => new PfnVkBindBufferMemory2KHR((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkBindBufferMemory2KHR(VkBindBufferMemory2KHR proc)
            => new PfnVkBindBufferMemory2KHR(proc);

        public static explicit operator VkBindBufferMemory2KHR(PfnVkBindBufferMemory2KHR pfn)
            => SilkMarshal.PtrToDelegate<VkBindBufferMemory2KHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result>(PfnVkBindBufferMemory2KHR pfn) => pfn.Handle;
        public static implicit operator PfnVkBindBufferMemory2KHR(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.BindBufferMemoryInfo*, Silk.NET.Vulkan.Result> ptr) => new PfnVkBindBufferMemory2KHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkBindBufferMemory2KHR(Silk.NET.Vulkan.Device* arg0, uint arg1, Silk.NET.Vulkan.BindBufferMemoryInfo* arg2);
}

