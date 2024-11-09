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
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void>) _handle;
        public PfnVkGetImageMemoryRequirements
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetImageMemoryRequirements
        (
             VkGetImageMemoryRequirements proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetImageMemoryRequirements From(VkGetImageMemoryRequirements proc) => new PfnVkGetImageMemoryRequirements(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetImageMemoryRequirements pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetImageMemoryRequirements(nint pfn)
            => new PfnVkGetImageMemoryRequirements((delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void>) pfn);

        public static implicit operator PfnVkGetImageMemoryRequirements(VkGetImageMemoryRequirements proc)
            => new PfnVkGetImageMemoryRequirements(proc);

        public static explicit operator VkGetImageMemoryRequirements(PfnVkGetImageMemoryRequirements pfn)
            => SilkMarshal.PtrToDelegate<VkGetImageMemoryRequirements>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void>(PfnVkGetImageMemoryRequirements pfn) => pfn.Handle;
        public static implicit operator PfnVkGetImageMemoryRequirements(delegate* unmanaged[Cdecl]<VkDevice_T*, VkImage_T*, VkMemoryRequirements*, void> ptr) => new PfnVkGetImageMemoryRequirements(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetImageMemoryRequirements(VkDevice_T* arg0, VkImage_T* arg1, VkMemoryRequirements* arg2);
}

