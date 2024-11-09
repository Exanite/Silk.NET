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
    public unsafe readonly struct PfnVkMapMemory : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult>) _handle;
        public PfnVkMapMemory
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult> ptr
        ) => _handle = ptr;

        public PfnVkMapMemory
        (
             VkMapMemory proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkMapMemory From(VkMapMemory proc) => new PfnVkMapMemory(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkMapMemory pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkMapMemory(nint pfn)
            => new PfnVkMapMemory((delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult>) pfn);

        public static implicit operator PfnVkMapMemory(VkMapMemory proc)
            => new PfnVkMapMemory(proc);

        public static explicit operator VkMapMemory(PfnVkMapMemory pfn)
            => SilkMarshal.PtrToDelegate<VkMapMemory>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult>(PfnVkMapMemory pfn) => pfn.Handle;
        public static implicit operator PfnVkMapMemory(delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceMemory_T*, ulong, ulong, uint, void**, VkResult> ptr) => new PfnVkMapMemory(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult VkMapMemory(VkDevice_T* arg0, VkDeviceMemory_T* arg1, ulong arg2, ulong arg3, uint arg4, void** arg5);
}

