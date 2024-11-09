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
    [NativeName("Name", "VmaPoolCreateInfo")]
    public unsafe partial struct PoolCreateInfo
    {
        public PoolCreateInfo
        (
            uint? memoryTypeIndex = null,
            uint? flags = null,
            ulong? blockSize = null,
            nuint? minBlockCount = null,
            nuint? maxBlockCount = null,
            float? priority = null,
            ulong? minAllocationAlignment = null,
            void* pMemoryAllocateNext = null
        ) : this()
        {
            if (memoryTypeIndex is not null)
            {
                MemoryTypeIndex = memoryTypeIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (blockSize is not null)
            {
                BlockSize = blockSize.Value;
            }

            if (minBlockCount is not null)
            {
                MinBlockCount = minBlockCount.Value;
            }

            if (maxBlockCount is not null)
            {
                MaxBlockCount = maxBlockCount.Value;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }

            if (minAllocationAlignment is not null)
            {
                MinAllocationAlignment = minAllocationAlignment.Value;
            }

            if (pMemoryAllocateNext is not null)
            {
                PMemoryAllocateNext = pMemoryAllocateNext;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeIndex")]
        public uint MemoryTypeIndex;

        [NativeName("Type", "VmaPoolCreateFlags")]
        [NativeName("Type.Name", "VmaPoolCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "blockSize")]
        public ulong BlockSize;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "minBlockCount")]
        public nuint MinBlockCount;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "maxBlockCount")]
        public nuint MaxBlockCount;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "priority")]
        public float Priority;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "minAllocationAlignment")]
        public ulong MinAllocationAlignment;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pMemoryAllocateNext")]
        public void* PMemoryAllocateNext;
    }
}
