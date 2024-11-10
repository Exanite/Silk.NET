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
    public unsafe readonly struct PfnVkGetDeviceBufferMemoryRequirementsKHR : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> Handle => (delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>) _handle;
        public PfnVkGetDeviceBufferMemoryRequirementsKHR
        (
            delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> ptr
        ) => _handle = ptr;

        public PfnVkGetDeviceBufferMemoryRequirementsKHR
        (
             VkGetDeviceBufferMemoryRequirementsKHR proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVkGetDeviceBufferMemoryRequirementsKHR From(VkGetDeviceBufferMemoryRequirementsKHR proc) => new PfnVkGetDeviceBufferMemoryRequirementsKHR(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnVkGetDeviceBufferMemoryRequirementsKHR pfn) => (nint) pfn.Handle;
        public static explicit operator PfnVkGetDeviceBufferMemoryRequirementsKHR(nint pfn)
            => new PfnVkGetDeviceBufferMemoryRequirementsKHR((delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>) pfn);

        public static implicit operator PfnVkGetDeviceBufferMemoryRequirementsKHR(VkGetDeviceBufferMemoryRequirementsKHR proc)
            => new PfnVkGetDeviceBufferMemoryRequirementsKHR(proc);

        public static explicit operator VkGetDeviceBufferMemoryRequirementsKHR(PfnVkGetDeviceBufferMemoryRequirementsKHR pfn)
            => SilkMarshal.PtrToDelegate<VkGetDeviceBufferMemoryRequirementsKHR>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void>(PfnVkGetDeviceBufferMemoryRequirementsKHR pfn) => pfn.Handle;
        public static implicit operator PfnVkGetDeviceBufferMemoryRequirementsKHR(delegate* unmanaged[Cdecl]<VkDevice_T*, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> ptr) => new PfnVkGetDeviceBufferMemoryRequirementsKHR(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void VkGetDeviceBufferMemoryRequirementsKHR(VkDevice_T* arg0, VkDeviceBufferMemoryRequirements* arg1, VkMemoryRequirements2* arg2);
}

