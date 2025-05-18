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
    public unsafe readonly struct PfnVkGetDeviceProcAddr : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction>) _handle;
        public PfnVkGetDeviceProcAddr
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction> ptr
        ) => _handle = ptr;

        public PfnVkGetDeviceProcAddr
        (
             VkGetDeviceProcAddr proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetDeviceProcAddr From(VkGetDeviceProcAddr proc) => new PfnVkGetDeviceProcAddr(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetDeviceProcAddr pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetDeviceProcAddr(nint pfn)
            => new PfnVkGetDeviceProcAddr((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction>) pfn);

        public static implicit operator PfnVkGetDeviceProcAddr(VkGetDeviceProcAddr proc)
            => new PfnVkGetDeviceProcAddr(proc);

        public static explicit operator VkGetDeviceProcAddr(PfnVkGetDeviceProcAddr pfn)
            => SilkMarshal.PtrToDelegate<VkGetDeviceProcAddr>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction>(PfnVkGetDeviceProcAddr pfn) => pfn.Handle;
        public static implicit operator PfnVkGetDeviceProcAddr(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Device, byte*, PfnVkVoidFunction> ptr) => new PfnVkGetDeviceProcAddr(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate PfnVkVoidFunction VkGetDeviceProcAddr(Silk.NET.Vulkan.Device arg0, byte* arg1);
}

