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
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void>) _handle;
        public PfnVkGetBufferMemoryRequirements
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetBufferMemoryRequirements
        (
             VkGetBufferMemoryRequirements proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetBufferMemoryRequirements From(VkGetBufferMemoryRequirements proc) => new PfnVkGetBufferMemoryRequirements(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetBufferMemoryRequirements pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetBufferMemoryRequirements(nint pfn)
            => new PfnVkGetBufferMemoryRequirements((delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void>) pfn);

        public static implicit operator PfnVkGetBufferMemoryRequirements(VkGetBufferMemoryRequirements proc)
            => new PfnVkGetBufferMemoryRequirements(proc);

        public static explicit operator VkGetBufferMemoryRequirements(PfnVkGetBufferMemoryRequirements pfn)
            => SilkMarshal.PtrToDelegate<VkGetBufferMemoryRequirements>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void>(PfnVkGetBufferMemoryRequirements pfn) => pfn.Handle;
        public static implicit operator PfnVkGetBufferMemoryRequirements(delegate* unmanaged[Cdecl]<VkDevice_T*, VkBuffer_T*, VkMemoryRequirements*, void> ptr) => new PfnVkGetBufferMemoryRequirements(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetBufferMemoryRequirements(VkDevice_T* arg0, VkBuffer_T* arg1, VkMemoryRequirements* arg2);
}

