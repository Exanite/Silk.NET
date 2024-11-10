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
    public unsafe readonly struct PfnVkFlushMappedMemoryRanges : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result>) _handle;
        public PfnVkFlushMappedMemoryRanges
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result> ptr
        ) => _handle = ptr;

        public PfnVkFlushMappedMemoryRanges
        (
             VkFlushMappedMemoryRanges proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkFlushMappedMemoryRanges From(VkFlushMappedMemoryRanges proc) => new PfnVkFlushMappedMemoryRanges(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkFlushMappedMemoryRanges pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkFlushMappedMemoryRanges(nint pfn)
            => new PfnVkFlushMappedMemoryRanges((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result>) pfn);

        public static implicit operator PfnVkFlushMappedMemoryRanges(VkFlushMappedMemoryRanges proc)
            => new PfnVkFlushMappedMemoryRanges(proc);

        public static explicit operator VkFlushMappedMemoryRanges(PfnVkFlushMappedMemoryRanges pfn)
            => SilkMarshal.PtrToDelegate<VkFlushMappedMemoryRanges>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result>(PfnVkFlushMappedMemoryRanges pfn) => pfn.Handle;
        public static implicit operator PfnVkFlushMappedMemoryRanges(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device*, uint, Silk.NET.Vulkan.MappedMemoryRange*, Silk.NET.Vulkan.Result> ptr) => new PfnVkFlushMappedMemoryRanges(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate Silk.NET.Vulkan.Result VkFlushMappedMemoryRanges(Silk.NET.Vulkan.Device* arg0, uint arg1, Silk.NET.Vulkan.MappedMemoryRange* arg2);
}

