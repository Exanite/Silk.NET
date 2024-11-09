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
    [NativeName("Name", "VmaVulkanFunctions")]
    public unsafe partial struct VulkanFunctions
    {
        public VulkanFunctions
        (
            PfnVkGetInstanceProcAddr? vkGetInstanceProcAddr = null,
            PfnVkGetDeviceProcAddr? vkGetDeviceProcAddr = null,
            PfnVkGetPhysicalDeviceProperties? vkGetPhysicalDeviceProperties = null,
            PfnVkGetPhysicalDeviceMemoryProperties? vkGetPhysicalDeviceMemoryProperties = null,
            PfnVkAllocateMemory? vkAllocateMemory = null,
            PfnVkFreeMemory? vkFreeMemory = null,
            PfnVkMapMemory? vkMapMemory = null,
            PfnVkUnmapMemory? vkUnmapMemory = null,
            PfnVkFlushMappedMemoryRanges? vkFlushMappedMemoryRanges = null,
            PfnVkFlushMappedMemoryRanges? vkInvalidateMappedMemoryRanges = null,
            PfnVkBindBufferMemory? vkBindBufferMemory = null,
            PfnVkBindImageMemory? vkBindImageMemory = null,
            PfnVkGetBufferMemoryRequirements? vkGetBufferMemoryRequirements = null,
            PfnVkGetImageMemoryRequirements? vkGetImageMemoryRequirements = null,
            PfnVkCreateBuffer? vkCreateBuffer = null,
            PfnVkDestroyBuffer? vkDestroyBuffer = null,
            PfnVkCreateImage? vkCreateImage = null,
            PfnVkDestroyImage? vkDestroyImage = null,
            PfnVkCmdCopyBuffer? vkCmdCopyBuffer = null,
            PfnVkGetBufferMemoryRequirements2KHR? vkGetBufferMemoryRequirements2KHR = null,
            PfnVkGetImageMemoryRequirements2KHR? vkGetImageMemoryRequirements2KHR = null,
            PfnVkBindBufferMemory2KHR? vkBindBufferMemory2KHR = null,
            PfnVkBindImageMemory2KHR? vkBindImageMemory2KHR = null,
            PfnVkGetPhysicalDeviceMemoryProperties2KHR? vkGetPhysicalDeviceMemoryProperties2KHR = null,
            PfnVkGetDeviceBufferMemoryRequirementsKHR? vkGetDeviceBufferMemoryRequirements = null,
            PfnVkGetDeviceImageMemoryRequirementsKHR? vkGetDeviceImageMemoryRequirements = null,
            void* vkGetMemoryWin32HandleKHR = null
        ) : this()
        {
            if (vkGetInstanceProcAddr is not null)
            {
                VkGetInstanceProcAddr = vkGetInstanceProcAddr.Value;
            }

            if (vkGetDeviceProcAddr is not null)
            {
                VkGetDeviceProcAddr = vkGetDeviceProcAddr.Value;
            }

            if (vkGetPhysicalDeviceProperties is not null)
            {
                VkGetPhysicalDeviceProperties = vkGetPhysicalDeviceProperties.Value;
            }

            if (vkGetPhysicalDeviceMemoryProperties is not null)
            {
                VkGetPhysicalDeviceMemoryProperties = vkGetPhysicalDeviceMemoryProperties.Value;
            }

            if (vkAllocateMemory is not null)
            {
                VkAllocateMemory = vkAllocateMemory.Value;
            }

            if (vkFreeMemory is not null)
            {
                VkFreeMemory = vkFreeMemory.Value;
            }

            if (vkMapMemory is not null)
            {
                VkMapMemory = vkMapMemory.Value;
            }

            if (vkUnmapMemory is not null)
            {
                VkUnmapMemory = vkUnmapMemory.Value;
            }

            if (vkFlushMappedMemoryRanges is not null)
            {
                VkFlushMappedMemoryRanges = vkFlushMappedMemoryRanges.Value;
            }

            if (vkInvalidateMappedMemoryRanges is not null)
            {
                VkInvalidateMappedMemoryRanges = vkInvalidateMappedMemoryRanges.Value;
            }

            if (vkBindBufferMemory is not null)
            {
                VkBindBufferMemory = vkBindBufferMemory.Value;
            }

            if (vkBindImageMemory is not null)
            {
                VkBindImageMemory = vkBindImageMemory.Value;
            }

            if (vkGetBufferMemoryRequirements is not null)
            {
                VkGetBufferMemoryRequirements = vkGetBufferMemoryRequirements.Value;
            }

            if (vkGetImageMemoryRequirements is not null)
            {
                VkGetImageMemoryRequirements = vkGetImageMemoryRequirements.Value;
            }

            if (vkCreateBuffer is not null)
            {
                VkCreateBuffer = vkCreateBuffer.Value;
            }

            if (vkDestroyBuffer is not null)
            {
                VkDestroyBuffer = vkDestroyBuffer.Value;
            }

            if (vkCreateImage is not null)
            {
                VkCreateImage = vkCreateImage.Value;
            }

            if (vkDestroyImage is not null)
            {
                VkDestroyImage = vkDestroyImage.Value;
            }

            if (vkCmdCopyBuffer is not null)
            {
                VkCmdCopyBuffer = vkCmdCopyBuffer.Value;
            }

            if (vkGetBufferMemoryRequirements2KHR is not null)
            {
                VkGetBufferMemoryRequirements2KHR = vkGetBufferMemoryRequirements2KHR.Value;
            }

            if (vkGetImageMemoryRequirements2KHR is not null)
            {
                VkGetImageMemoryRequirements2KHR = vkGetImageMemoryRequirements2KHR.Value;
            }

            if (vkBindBufferMemory2KHR is not null)
            {
                VkBindBufferMemory2KHR = vkBindBufferMemory2KHR.Value;
            }

            if (vkBindImageMemory2KHR is not null)
            {
                VkBindImageMemory2KHR = vkBindImageMemory2KHR.Value;
            }

            if (vkGetPhysicalDeviceMemoryProperties2KHR is not null)
            {
                VkGetPhysicalDeviceMemoryProperties2KHR = vkGetPhysicalDeviceMemoryProperties2KHR.Value;
            }

            if (vkGetDeviceBufferMemoryRequirements is not null)
            {
                VkGetDeviceBufferMemoryRequirements = vkGetDeviceBufferMemoryRequirements.Value;
            }

            if (vkGetDeviceImageMemoryRequirements is not null)
            {
                VkGetDeviceImageMemoryRequirements = vkGetDeviceImageMemoryRequirements.Value;
            }

            if (vkGetMemoryWin32HandleKHR is not null)
            {
                VkGetMemoryWin32HandleKHR = vkGetMemoryWin32HandleKHR;
            }
        }


        [NativeName("Type", "PFN_vkGetInstanceProcAddr _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetInstanceProcAddr _Nullable")]
        [NativeName("Name", "vkGetInstanceProcAddr")]
        public PfnVkGetInstanceProcAddr VkGetInstanceProcAddr;

        [NativeName("Type", "PFN_vkGetDeviceProcAddr _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetDeviceProcAddr _Nullable")]
        [NativeName("Name", "vkGetDeviceProcAddr")]
        public PfnVkGetDeviceProcAddr VkGetDeviceProcAddr;

        [NativeName("Type", "PFN_vkGetPhysicalDeviceProperties _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetPhysicalDeviceProperties _Nullable")]
        [NativeName("Name", "vkGetPhysicalDeviceProperties")]
        public PfnVkGetPhysicalDeviceProperties VkGetPhysicalDeviceProperties;

        [NativeName("Type", "PFN_vkGetPhysicalDeviceMemoryProperties _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetPhysicalDeviceMemoryProperties _Nullable")]
        [NativeName("Name", "vkGetPhysicalDeviceMemoryProperties")]
        public PfnVkGetPhysicalDeviceMemoryProperties VkGetPhysicalDeviceMemoryProperties;

        [NativeName("Type", "PFN_vkAllocateMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkAllocateMemory _Nullable")]
        [NativeName("Name", "vkAllocateMemory")]
        public PfnVkAllocateMemory VkAllocateMemory;

        [NativeName("Type", "PFN_vkFreeMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkFreeMemory _Nullable")]
        [NativeName("Name", "vkFreeMemory")]
        public PfnVkFreeMemory VkFreeMemory;

        [NativeName("Type", "PFN_vkMapMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkMapMemory _Nullable")]
        [NativeName("Name", "vkMapMemory")]
        public PfnVkMapMemory VkMapMemory;

        [NativeName("Type", "PFN_vkUnmapMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkUnmapMemory _Nullable")]
        [NativeName("Name", "vkUnmapMemory")]
        public PfnVkUnmapMemory VkUnmapMemory;

        [NativeName("Type", "PFN_vkFlushMappedMemoryRanges _Nullable")]
        [NativeName("Type.Name", "PFN_vkFlushMappedMemoryRanges _Nullable")]
        [NativeName("Name", "vkFlushMappedMemoryRanges")]
        public PfnVkFlushMappedMemoryRanges VkFlushMappedMemoryRanges;

        [NativeName("Type", "PFN_vkInvalidateMappedMemoryRanges _Nullable")]
        [NativeName("Type.Name", "PFN_vkInvalidateMappedMemoryRanges _Nullable")]
        [NativeName("Name", "vkInvalidateMappedMemoryRanges")]
        public PfnVkFlushMappedMemoryRanges VkInvalidateMappedMemoryRanges;

        [NativeName("Type", "PFN_vkBindBufferMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkBindBufferMemory _Nullable")]
        [NativeName("Name", "vkBindBufferMemory")]
        public PfnVkBindBufferMemory VkBindBufferMemory;

        [NativeName("Type", "PFN_vkBindImageMemory _Nullable")]
        [NativeName("Type.Name", "PFN_vkBindImageMemory _Nullable")]
        [NativeName("Name", "vkBindImageMemory")]
        public PfnVkBindImageMemory VkBindImageMemory;

        [NativeName("Type", "PFN_vkGetBufferMemoryRequirements _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetBufferMemoryRequirements _Nullable")]
        [NativeName("Name", "vkGetBufferMemoryRequirements")]
        public PfnVkGetBufferMemoryRequirements VkGetBufferMemoryRequirements;

        [NativeName("Type", "PFN_vkGetImageMemoryRequirements _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetImageMemoryRequirements _Nullable")]
        [NativeName("Name", "vkGetImageMemoryRequirements")]
        public PfnVkGetImageMemoryRequirements VkGetImageMemoryRequirements;

        [NativeName("Type", "PFN_vkCreateBuffer _Nullable")]
        [NativeName("Type.Name", "PFN_vkCreateBuffer _Nullable")]
        [NativeName("Name", "vkCreateBuffer")]
        public PfnVkCreateBuffer VkCreateBuffer;

        [NativeName("Type", "PFN_vkDestroyBuffer _Nullable")]
        [NativeName("Type.Name", "PFN_vkDestroyBuffer _Nullable")]
        [NativeName("Name", "vkDestroyBuffer")]
        public PfnVkDestroyBuffer VkDestroyBuffer;

        [NativeName("Type", "PFN_vkCreateImage _Nullable")]
        [NativeName("Type.Name", "PFN_vkCreateImage _Nullable")]
        [NativeName("Name", "vkCreateImage")]
        public PfnVkCreateImage VkCreateImage;

        [NativeName("Type", "PFN_vkDestroyImage _Nullable")]
        [NativeName("Type.Name", "PFN_vkDestroyImage _Nullable")]
        [NativeName("Name", "vkDestroyImage")]
        public PfnVkDestroyImage VkDestroyImage;

        [NativeName("Type", "PFN_vkCmdCopyBuffer _Nullable")]
        [NativeName("Type.Name", "PFN_vkCmdCopyBuffer _Nullable")]
        [NativeName("Name", "vkCmdCopyBuffer")]
        public PfnVkCmdCopyBuffer VkCmdCopyBuffer;

        [NativeName("Type", "PFN_vkGetBufferMemoryRequirements2KHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetBufferMemoryRequirements2KHR _Nullable")]
        [NativeName("Name", "vkGetBufferMemoryRequirements2KHR")]
        public PfnVkGetBufferMemoryRequirements2KHR VkGetBufferMemoryRequirements2KHR;

        [NativeName("Type", "PFN_vkGetImageMemoryRequirements2KHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetImageMemoryRequirements2KHR _Nullable")]
        [NativeName("Name", "vkGetImageMemoryRequirements2KHR")]
        public PfnVkGetImageMemoryRequirements2KHR VkGetImageMemoryRequirements2KHR;

        [NativeName("Type", "PFN_vkBindBufferMemory2KHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkBindBufferMemory2KHR _Nullable")]
        [NativeName("Name", "vkBindBufferMemory2KHR")]
        public PfnVkBindBufferMemory2KHR VkBindBufferMemory2KHR;

        [NativeName("Type", "PFN_vkBindImageMemory2KHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkBindImageMemory2KHR _Nullable")]
        [NativeName("Name", "vkBindImageMemory2KHR")]
        public PfnVkBindImageMemory2KHR VkBindImageMemory2KHR;

        [NativeName("Type", "PFN_vkGetPhysicalDeviceMemoryProperties2KHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetPhysicalDeviceMemoryProperties2KHR _Nullable")]
        [NativeName("Name", "vkGetPhysicalDeviceMemoryProperties2KHR")]
        public PfnVkGetPhysicalDeviceMemoryProperties2KHR VkGetPhysicalDeviceMemoryProperties2KHR;

        [NativeName("Type", "PFN_vkGetDeviceBufferMemoryRequirementsKHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetDeviceBufferMemoryRequirementsKHR _Nullable")]
        [NativeName("Name", "vkGetDeviceBufferMemoryRequirements")]
        public PfnVkGetDeviceBufferMemoryRequirementsKHR VkGetDeviceBufferMemoryRequirements;

        [NativeName("Type", "PFN_vkGetDeviceImageMemoryRequirementsKHR _Nullable")]
        [NativeName("Type.Name", "PFN_vkGetDeviceImageMemoryRequirementsKHR _Nullable")]
        [NativeName("Name", "vkGetDeviceImageMemoryRequirements")]
        public PfnVkGetDeviceImageMemoryRequirementsKHR VkGetDeviceImageMemoryRequirements;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "vkGetMemoryWin32HandleKHR")]
        public void* VkGetMemoryWin32HandleKHR;
    }
}
