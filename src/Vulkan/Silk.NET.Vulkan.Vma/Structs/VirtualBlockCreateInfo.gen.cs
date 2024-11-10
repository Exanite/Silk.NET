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
    [NativeName("Name", "VmaVirtualBlockCreateInfo")]
    public unsafe partial struct VirtualBlockCreateInfo
    {
        public VirtualBlockCreateInfo
        (
            ulong? size = null,
            uint? flags = null,
            Silk.NET.Vulkan.AllocationCallbacks* pAllocationCallbacks = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pAllocationCallbacks is not null)
            {
                PAllocationCallbacks = pAllocationCallbacks;
            }
        }


        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;

        [NativeName("Type", "VmaVirtualBlockCreateFlags")]
        [NativeName("Type.Name", "VmaVirtualBlockCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "const VkAllocationCallbacks * _Nullable")]
        [NativeName("Type.Name", "const VkAllocationCallbacks * _Nullable")]
        [NativeName("Name", "pAllocationCallbacks")]
        public Silk.NET.Vulkan.AllocationCallbacks* PAllocationCallbacks;
    }
}
