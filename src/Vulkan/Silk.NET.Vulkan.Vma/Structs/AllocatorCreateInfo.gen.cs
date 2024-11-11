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
    [NativeName("Name", "VmaAllocatorCreateInfo")]
    public unsafe partial struct AllocatorCreateInfo
    {
        public AllocatorCreateInfo
        (
            uint? flags = null,
            Silk.NET.Vulkan.PhysicalDevice? physicalDevice = null,
            Silk.NET.Vulkan.Device? device = null,
            ulong? preferredLargeHeapBlockSize = null,
            Silk.NET.Vulkan.AllocationCallbacks* pAllocationCallbacks = null,
            DeviceMemoryCallbacks* pDeviceMemoryCallbacks = null,
            ulong* pHeapSizeLimit = null,
            VulkanFunctions* pVulkanFunctions = null,
            Silk.NET.Vulkan.Instance? instance = null,
            uint? vulkanApiVersion = null,
            uint* pTypeExternalMemoryHandleTypes = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (physicalDevice is not null)
            {
                PhysicalDevice = physicalDevice.Value;
            }

            if (device is not null)
            {
                Device = device.Value;
            }

            if (preferredLargeHeapBlockSize is not null)
            {
                PreferredLargeHeapBlockSize = preferredLargeHeapBlockSize.Value;
            }

            if (pAllocationCallbacks is not null)
            {
                PAllocationCallbacks = pAllocationCallbacks;
            }

            if (pDeviceMemoryCallbacks is not null)
            {
                PDeviceMemoryCallbacks = pDeviceMemoryCallbacks;
            }

            if (pHeapSizeLimit is not null)
            {
                PHeapSizeLimit = pHeapSizeLimit;
            }

            if (pVulkanFunctions is not null)
            {
                PVulkanFunctions = pVulkanFunctions;
            }

            if (instance is not null)
            {
                Instance = instance.Value;
            }

            if (vulkanApiVersion is not null)
            {
                VulkanApiVersion = vulkanApiVersion.Value;
            }

            if (pTypeExternalMemoryHandleTypes is not null)
            {
                PTypeExternalMemoryHandleTypes = pTypeExternalMemoryHandleTypes;
            }
        }


        [NativeName("Type", "VmaAllocatorCreateFlags")]
        [NativeName("Type.Name", "VmaAllocatorCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "VkPhysicalDevice _Nonnull")]
        [NativeName("Type.Name", "VkPhysicalDevice _Nonnull")]
        [NativeName("Name", "physicalDevice")]
        public Silk.NET.Vulkan.PhysicalDevice PhysicalDevice;

        [NativeName("Type", "VkDevice _Nonnull")]
        [NativeName("Type.Name", "VkDevice _Nonnull")]
        [NativeName("Name", "device")]
        public Silk.NET.Vulkan.Device Device;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "preferredLargeHeapBlockSize")]
        public ulong PreferredLargeHeapBlockSize;

        [NativeName("Type", "const VkAllocationCallbacks * _Nullable")]
        [NativeName("Type.Name", "const VkAllocationCallbacks * _Nullable")]
        [NativeName("Name", "pAllocationCallbacks")]
        public Silk.NET.Vulkan.AllocationCallbacks* PAllocationCallbacks;

        [NativeName("Type", "const VmaDeviceMemoryCallbacks * _Nullable")]
        [NativeName("Type.Name", "const VmaDeviceMemoryCallbacks * _Nullable")]
        [NativeName("Name", "pDeviceMemoryCallbacks")]
        public DeviceMemoryCallbacks* PDeviceMemoryCallbacks;

        [NativeName("Type", "const VkDeviceSize * _Nullable")]
        [NativeName("Type.Name", "const VkDeviceSize * _Nullable")]
        [NativeName("Name", "pHeapSizeLimit")]
        public ulong* PHeapSizeLimit;

        [NativeName("Type", "const VmaVulkanFunctions * _Nullable")]
        [NativeName("Type.Name", "const VmaVulkanFunctions * _Nullable")]
        [NativeName("Name", "pVulkanFunctions")]
        public VulkanFunctions* PVulkanFunctions;

        [NativeName("Type", "VkInstance _Nonnull")]
        [NativeName("Type.Name", "VkInstance _Nonnull")]
        [NativeName("Name", "instance")]
        public Silk.NET.Vulkan.Instance Instance;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "vulkanApiVersion")]
        public uint VulkanApiVersion;

        [NativeName("Type", "const VkExternalMemoryHandleTypeFlagsKHR * _Nullable")]
        [NativeName("Type.Name", "const VkExternalMemoryHandleTypeFlagsKHR * _Nullable")]
        [NativeName("Name", "pTypeExternalMemoryHandleTypes")]
        public uint* PTypeExternalMemoryHandleTypes;
    }
}
