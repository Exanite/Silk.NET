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
    [NativeName("Name", "VmaBudget")]
    public unsafe partial struct Budget
    {
        public Budget
        (
            Statistics? statistics = null,
            ulong? usage = null,
            ulong? value = null
        ) : this()
        {
            if (statistics is not null)
            {
                Statistics = statistics.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "VmaStatistics")]
        [NativeName("Type.Name", "VmaStatistics")]
        [NativeName("Name", "statistics")]
        public Statistics Statistics;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "usage")]
        public ulong Usage;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "budget")]
        public ulong Value;
    }
}
