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
    [NativeName("Name", "VmaStatistics")]
    public unsafe partial struct Statistics
    {
        public Statistics
        (
            uint? blockCount = null,
            uint? allocationCount = null,
            ulong? blockBytes = null,
            ulong? allocationBytes = null
        ) : this()
        {
            if (blockCount is not null)
            {
                BlockCount = blockCount.Value;
            }

            if (allocationCount is not null)
            {
                AllocationCount = allocationCount.Value;
            }

            if (blockBytes is not null)
            {
                BlockBytes = blockBytes.Value;
            }

            if (allocationBytes is not null)
            {
                AllocationBytes = allocationBytes.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockCount")]
        public uint BlockCount;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "allocationCount")]
        public uint AllocationCount;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "blockBytes")]
        public ulong BlockBytes;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "allocationBytes")]
        public ulong AllocationBytes;
    }
}
