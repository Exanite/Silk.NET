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
    [NativeName("Name", "VmaDefragmentationStats")]
    public unsafe partial struct DefragmentationStats
    {
        public DefragmentationStats
        (
            ulong? bytesMoved = null,
            ulong? bytesFreed = null,
            uint? allocationsMoved = null,
            uint? deviceMemoryBlocksFreed = null
        ) : this()
        {
            if (bytesMoved is not null)
            {
                BytesMoved = bytesMoved.Value;
            }

            if (bytesFreed is not null)
            {
                BytesFreed = bytesFreed.Value;
            }

            if (allocationsMoved is not null)
            {
                AllocationsMoved = allocationsMoved.Value;
            }

            if (deviceMemoryBlocksFreed is not null)
            {
                DeviceMemoryBlocksFreed = deviceMemoryBlocksFreed.Value;
            }
        }


        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "bytesMoved")]
        public ulong BytesMoved;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "bytesFreed")]
        public ulong BytesFreed;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "allocationsMoved")]
        public uint AllocationsMoved;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMemoryBlocksFreed")]
        public uint DeviceMemoryBlocksFreed;
    }
}
