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
    public unsafe readonly struct PfnVkCreateImage : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkCreateImage
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkCreateImage
        (
             VkCreateImage proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkCreateImage From(VkCreateImage proc) => new PfnVkCreateImage(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkCreateImage pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkCreateImage(nint pfn)
            => new PfnVkCreateImage((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkCreateImage(VkCreateImage proc)
            => new PfnVkCreateImage(proc);

        public static explicit operator VkCreateImage(PfnVkCreateImage pfn)
            => SilkMarshal.PtrToDelegate<VkCreateImage>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result>(PfnVkCreateImage pfn) => pfn.Handle;
        public static implicit operator PfnVkCreateImage(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, Silk.NET.Vulkan.ImageCreateInfo*, Silk.NET.Vulkan.AllocationCallbacks*, Silk.NET.Vulkan.Image**, Silk.NET.Vulkan.Result> ptr) => new PfnVkCreateImage(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkCreateImage(Silk.NET.Vulkan.Device* arg0, Silk.NET.Vulkan.ImageCreateInfo* arg1, Silk.NET.Vulkan.AllocationCallbacks* arg2, Silk.NET.Vulkan.Image** arg3);
}

