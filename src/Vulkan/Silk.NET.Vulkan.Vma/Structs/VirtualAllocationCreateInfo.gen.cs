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
    [NativeName("Name", "VmaVirtualAllocationCreateInfo")]
    public unsafe partial struct VirtualAllocationCreateInfo
    {
        public VirtualAllocationCreateInfo
        (
            ulong? size = null,
            ulong? alignment = null,
            uint? flags = null,
            void* pUserData = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pUserData is not null)
            {
                PUserData = pUserData;
            }
        }


        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "alignment")]
        public ulong Alignment;

        [NativeName("Type", "VmaVirtualAllocationCreateFlags")]
        [NativeName("Type.Name", "VmaVirtualAllocationCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;
    }
}
