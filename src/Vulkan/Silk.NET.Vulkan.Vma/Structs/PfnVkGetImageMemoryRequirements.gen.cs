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
    public unsafe readonly struct PfnVkGetImageMemoryRequirements : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void>) _handle;
        public PfnVkGetImageMemoryRequirements
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetImageMemoryRequirements
        (
             VkGetImageMemoryRequirements proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetImageMemoryRequirements From(VkGetImageMemoryRequirements proc) => new PfnVkGetImageMemoryRequirements(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetImageMemoryRequirements pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetImageMemoryRequirements(nint pfn)
            => new PfnVkGetImageMemoryRequirements((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void>) pfn);

        public static implicit operator PfnVkGetImageMemoryRequirements(VkGetImageMemoryRequirements proc)
            => new PfnVkGetImageMemoryRequirements(proc);

        public static explicit operator VkGetImageMemoryRequirements(PfnVkGetImageMemoryRequirements pfn)
            => SilkMarshal.PtrToDelegate<VkGetImageMemoryRequirements>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void>(PfnVkGetImageMemoryRequirements pfn) => pfn.Handle;
        public static implicit operator PfnVkGetImageMemoryRequirements(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, Silk.NET.Vulkan.Image, Silk.NET.Vulkan.MemoryRequirements*, void> ptr) => new PfnVkGetImageMemoryRequirements(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetImageMemoryRequirements(Silk.NET.Vulkan.Device arg0, Silk.NET.Vulkan.Image arg1, Silk.NET.Vulkan.MemoryRequirements* arg2);
}

