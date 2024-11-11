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
    [NativeName("Name", "VmaAllocationCreateInfo")]
    public unsafe partial struct AllocationCreateInfo
    {
        public AllocationCreateInfo
        (
            uint? flags = null,
            MemoryUsage? usage = null,
            uint? requiredFlags = null,
            uint? preferredFlags = null,
            uint? memoryTypeBits = null,
            Silk.NET.Vulkan.Vma.Pool? pool = null,
            void* pUserData = null,
            float? priority = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (requiredFlags is not null)
            {
                RequiredFlags = requiredFlags.Value;
            }

            if (preferredFlags is not null)
            {
                PreferredFlags = preferredFlags.Value;
            }

            if (memoryTypeBits is not null)
            {
                MemoryTypeBits = memoryTypeBits.Value;
            }

            if (pool is not null)
            {
                Pool = pool.Value;
            }

            if (pUserData is not null)
            {
                PUserData = pUserData;
            }

            if (priority is not null)
            {
                Priority = priority.Value;
            }
        }


        [NativeName("Type", "VmaAllocationCreateFlags")]
        [NativeName("Type.Name", "VmaAllocationCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "VmaMemoryUsage")]
        [NativeName("Type.Name", "VmaMemoryUsage")]
        [NativeName("Name", "usage")]
        public MemoryUsage Usage;

        [NativeName("Type", "VkMemoryPropertyFlags")]
        [NativeName("Type.Name", "VkMemoryPropertyFlags")]
        [NativeName("Name", "requiredFlags")]
        public uint RequiredFlags;

        [NativeName("Type", "VkMemoryPropertyFlags")]
        [NativeName("Type.Name", "VkMemoryPropertyFlags")]
        [NativeName("Name", "preferredFlags")]
        public uint PreferredFlags;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "memoryTypeBits")]
        public uint MemoryTypeBits;

        [NativeName("Type", "VmaPool _Nullable")]
        [NativeName("Type.Name", "VmaPool _Nullable")]
        [NativeName("Name", "pool")]
        public Silk.NET.Vulkan.Vma.Pool Pool;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "priority")]
        public float Priority;
    }
}
