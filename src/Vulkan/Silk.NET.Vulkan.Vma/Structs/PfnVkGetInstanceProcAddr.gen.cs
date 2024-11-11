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
    public unsafe readonly struct PfnVkGetInstanceProcAddr : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction> Handle => (delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction>) _handle;
        public PfnVkGetInstanceProcAddr
        (
            delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction> ptr
        ) => _handle = ptr;

        public PfnVkGetInstanceProcAddr
        (
             VkGetInstanceProcAddr proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetInstanceProcAddr From(VkGetInstanceProcAddr proc) => new PfnVkGetInstanceProcAddr(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetInstanceProcAddr pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetInstanceProcAddr(nint pfn)
            => new PfnVkGetInstanceProcAddr((delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction>) pfn);

        public static implicit operator PfnVkGetInstanceProcAddr(VkGetInstanceProcAddr proc)
            => new PfnVkGetInstanceProcAddr(proc);

        public static explicit operator VkGetInstanceProcAddr(PfnVkGetInstanceProcAddr pfn)
            => SilkMarshal.PtrToDelegate<VkGetInstanceProcAddr>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction>(PfnVkGetInstanceProcAddr pfn) => pfn.Handle;
        public static implicit operator PfnVkGetInstanceProcAddr(delegate* unmanaged[Cdecl]<Silk.NET.Vulkan.Instance, byte*, PfnVkVoidFunction> ptr) => new PfnVkGetInstanceProcAddr(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate PfnVkVoidFunction VkGetInstanceProcAddr(Silk.NET.Vulkan.Instance arg0, byte* arg1);
}

