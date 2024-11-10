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
    [NativeName("Name", "VmaAllocationInfo")]
    public unsafe partial struct AllocationInfo
    {
        public AllocationInfo
        (
            uint? memoryType = null,
            Silk.NET.Vulkan.DeviceMemory* deviceMemory = null,
            ulong? offset = null,
            ulong? size = null,
            void* pMappedData = null,
            void* pUserData = null,
            byte* pName = null
        ) : this()
        {
            if (memoryType is not null)
            {
                MemoryType = memoryType.Value;
            }

            if (deviceMemory is not null)
            {
                DeviceMemory = deviceMemory;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pMappedData is not null)
            {
                PMappedData = pMappedData;
            }

            if (pUserData is not null)
            {
                PUserData = pUserData;
            }

            if (pName is not null)
            {
                PName = pName;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryType")]
        public uint MemoryType;

        [NativeName("Type", "VkDeviceMemory _Nullable")]
        [NativeName("Type.Name", "VkDeviceMemory _Nullable")]
        [NativeName("Name", "deviceMemory")]
        public Silk.NET.Vulkan.DeviceMemory* DeviceMemory;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pMappedData")]
        public void* PMappedData;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;

        [NativeName("Type", "const char * _Nullable")]
        [NativeName("Type.Name", "const char * _Nullable")]
        [NativeName("Name", "pName")]
        public byte* PName;
    }
}
