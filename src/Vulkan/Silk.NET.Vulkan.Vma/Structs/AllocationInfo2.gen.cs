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
    [NativeName("Name", "VmaAllocationInfo2")]
    public unsafe partial struct AllocationInfo2
    {
        public AllocationInfo2
        (
            AllocationInfo? allocationInfo = null,
            ulong? blockSize = null,
            uint? dedicatedMemory = null
        ) : this()
        {
            if (allocationInfo is not null)
            {
                AllocationInfo = allocationInfo.Value;
            }

            if (blockSize is not null)
            {
                BlockSize = blockSize.Value;
            }

            if (dedicatedMemory is not null)
            {
                DedicatedMemory = dedicatedMemory.Value;
            }
        }


        [NativeName("Type", "VmaAllocationInfo")]
        [NativeName("Type.Name", "VmaAllocationInfo")]
        [NativeName("Name", "allocationInfo")]
        public AllocationInfo AllocationInfo;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "blockSize")]
        public ulong BlockSize;

        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "dedicatedMemory")]
        public uint DedicatedMemory;
    }
}
