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
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult>) _handle;
        public PfnVkCreateImage
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult> ptr
        ) => _handle = ptr;

        public PfnVkCreateImage
        (
             VkCreateImage proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkCreateImage From(VkCreateImage proc) => new PfnVkCreateImage(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkCreateImage pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkCreateImage(nint pfn)
            => new PfnVkCreateImage((delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult>) pfn);

        public static implicit operator PfnVkCreateImage(VkCreateImage proc)
            => new PfnVkCreateImage(proc);

        public static explicit operator VkCreateImage(PfnVkCreateImage pfn)
            => SilkMarshal.PtrToDelegate<VkCreateImage>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult>(PfnVkCreateImage pfn) => pfn.Handle;
        public static implicit operator PfnVkCreateImage(delegate* unmanaged[Cdecl]<VkDevice_T*, VkImageCreateInfo*, VkAllocationCallbacks*, VkImage_T**, VkResult> ptr) => new PfnVkCreateImage(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult VkCreateImage(VkDevice_T* arg0, VkImageCreateInfo* arg1, VkAllocationCallbacks* arg2, VkImage_T** arg3);
}

