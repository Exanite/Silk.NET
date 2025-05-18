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
    [NativeName("Name", "VmaDetailedStatistics")]
    public unsafe partial struct DetailedStatistics
    {
        public DetailedStatistics
        (
            Statistics? statistics = null,
            uint? unusedRangeCount = null,
            ulong? allocationSizeMin = null,
            ulong? allocationSizeMax = null,
            ulong? unusedRangeSizeMin = null,
            ulong? unusedRangeSizeMax = null
        ) : this()
        {
            if (statistics is not null)
            {
                Statistics = statistics.Value;
            }

            if (unusedRangeCount is not null)
            {
                UnusedRangeCount = unusedRangeCount.Value;
            }

            if (allocationSizeMin is not null)
            {
                AllocationSizeMin = allocationSizeMin.Value;
            }

            if (allocationSizeMax is not null)
            {
                AllocationSizeMax = allocationSizeMax.Value;
            }

            if (unusedRangeSizeMin is not null)
            {
                UnusedRangeSizeMin = unusedRangeSizeMin.Value;
            }

            if (unusedRangeSizeMax is not null)
            {
                UnusedRangeSizeMax = unusedRangeSizeMax.Value;
            }
        }


        [NativeName("Type", "VmaStatistics")]
        [NativeName("Type.Name", "VmaStatistics")]
        [NativeName("Name", "statistics")]
        public Statistics Statistics;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "unusedRangeCount")]
        public uint UnusedRangeCount;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "allocationSizeMin")]
        public ulong AllocationSizeMin;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "allocationSizeMax")]
        public ulong AllocationSizeMax;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "unusedRangeSizeMin")]
        public ulong UnusedRangeSizeMin;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "unusedRangeSizeMax")]
        public ulong UnusedRangeSizeMax;
    }
}
