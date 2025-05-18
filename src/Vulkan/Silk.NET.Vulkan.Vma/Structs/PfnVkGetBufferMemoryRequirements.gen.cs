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
    public unsafe readonly struct PfnVkGetBufferMemoryRequirements : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void>) _handle;
        public PfnVkGetBufferMemoryRequirements
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetBufferMemoryRequirements
        (
             VkGetBufferMemoryRequirements proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetBufferMemoryRequirements From(VkGetBufferMemoryRequirements proc) => new PfnVkGetBufferMemoryRequirements(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetBufferMemoryRequirements pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetBufferMemoryRequirements(nint pfn)
            => new PfnVkGetBufferMemoryRequirements((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void>) pfn);

        public static implicit operator PfnVkGetBufferMemoryRequirements(VkGetBufferMemoryRequirements proc)
            => new PfnVkGetBufferMemoryRequirements(proc);

        public static explicit operator VkGetBufferMemoryRequirements(PfnVkGetBufferMemoryRequirements pfn)
            => SilkMarshal.PtrToDelegate<VkGetBufferMemoryRequirements>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void>(PfnVkGetBufferMemoryRequirements pfn) => pfn.Handle;
        public static implicit operator PfnVkGetBufferMemoryRequirements(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.MemoryRequirements*, void> ptr) => new PfnVkGetBufferMemoryRequirements(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetBufferMemoryRequirements(Silk.NET.Vulkan.Device arg0, Silk.NET.Vulkan.Buffer arg1, Silk.NET.Vulkan.MemoryRequirements* arg2);
}

