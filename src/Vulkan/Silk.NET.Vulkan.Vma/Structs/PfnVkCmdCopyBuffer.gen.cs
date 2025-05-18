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
    public unsafe readonly struct PfnVkCmdCopyBuffer : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void>) _handle;
        public PfnVkCmdCopyBuffer
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void> ptr
        ) => _handle = ptr;

        public PfnVkCmdCopyBuffer
        (
             VkCmdCopyBuffer proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkCmdCopyBuffer From(VkCmdCopyBuffer proc) => new PfnVkCmdCopyBuffer(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkCmdCopyBuffer pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkCmdCopyBuffer(nint pfn)
            => new PfnVkCmdCopyBuffer((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void>) pfn);

        public static implicit operator PfnVkCmdCopyBuffer(VkCmdCopyBuffer proc)
            => new PfnVkCmdCopyBuffer(proc);

        public static explicit operator VkCmdCopyBuffer(PfnVkCmdCopyBuffer pfn)
            => SilkMarshal.PtrToDelegate<VkCmdCopyBuffer>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void>(PfnVkCmdCopyBuffer pfn) => pfn.Handle;
        public static implicit operator PfnVkCmdCopyBuffer(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.CommandBuffer, Silk.NET.Vulkan.Buffer, Silk.NET.Vulkan.Buffer, uint, Silk.NET.Vulkan.BufferCopy*, void> ptr) => new PfnVkCmdCopyBuffer(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkCmdCopyBuffer(Silk.NET.Vulkan.CommandBuffer arg0, Silk.NET.Vulkan.Buffer arg1, Silk.NET.Vulkan.Buffer arg2, uint arg3, Silk.NET.Vulkan.BufferCopy* arg4);
}

