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
    [NativeName("Name", "VmaAllocatorInfo")]
    public unsafe partial struct AllocatorInfo
    {
        public AllocatorInfo
        (
            Silk.NET.Vulkan.Instance* instance = null,
            Silk.NET.Vulkan.PhysicalDevice* physicalDevice = null,
            Silk.NET.Vulkan.Device* device = null
        ) : this()
        {
            if (instance is not null)
            {
                Instance = instance;
            }

            if (physicalDevice is not null)
            {
                PhysicalDevice = physicalDevice;
            }

            if (device is not null)
            {
                Device = device;
            }
        }


        [NativeName("Type", "VkInstance _Nonnull")]
        [NativeName("Type.Name", "VkInstance _Nonnull")]
        [NativeName("Name", "instance")]
        public Silk.NET.Vulkan.Instance* Instance;

        [NativeName("Type", "VkPhysicalDevice _Nonnull")]
        [NativeName("Type.Name", "VkPhysicalDevice _Nonnull")]
        [NativeName("Name", "physicalDevice")]
        public Silk.NET.Vulkan.PhysicalDevice* PhysicalDevice;

        [NativeName("Type", "VkDevice _Nonnull")]
        [NativeName("Type.Name", "VkDevice _Nonnull")]
        [NativeName("Name", "device")]
        public Silk.NET.Vulkan.Device* Device;
    }
}
