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
    [NativeName("Name", "VmaDefragmentationInfo")]
    public unsafe partial struct DefragmentationInfo
    {
        public DefragmentationInfo
        (
            uint? flags = null,
            PoolT* pool = null,
            ulong? maxBytesPerPass = null,
            uint? maxAllocationsPerPass = null,
            PfnVmaCheckDefragmentationBreakFunction? pfnBreakCallback = null,
            void* pBreakCallbackUserData = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pool is not null)
            {
                Pool = pool;
            }

            if (maxBytesPerPass is not null)
            {
                MaxBytesPerPass = maxBytesPerPass.Value;
            }

            if (maxAllocationsPerPass is not null)
            {
                MaxAllocationsPerPass = maxAllocationsPerPass.Value;
            }

            if (pfnBreakCallback is not null)
            {
                PfnBreakCallback = pfnBreakCallback.Value;
            }

            if (pBreakCallbackUserData is not null)
            {
                PBreakCallbackUserData = pBreakCallbackUserData;
            }
        }


        [NativeName("Type", "VmaDefragmentationFlags")]
        [NativeName("Type.Name", "VmaDefragmentationFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "VmaPool _Nullable")]
        [NativeName("Type.Name", "VmaPool _Nullable")]
        [NativeName("Name", "pool")]
        public PoolT* Pool;

        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "maxBytesPerPass")]
        public ulong MaxBytesPerPass;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxAllocationsPerPass")]
        public uint MaxAllocationsPerPass;

        [NativeName("Type", "PFN_vmaCheckDefragmentationBreakFunction _Nullable")]
        [NativeName("Type.Name", "PFN_vmaCheckDefragmentationBreakFunction _Nullable")]
        [NativeName("Name", "pfnBreakCallback")]
        public PfnVmaCheckDefragmentationBreakFunction PfnBreakCallback;

        [NativeName("Type", "void * _Nullable")]
        [NativeName("Type.Name", "void * _Nullable")]
        [NativeName("Name", "pBreakCallbackUserData")]
        public void* PBreakCallbackUserData;
    }
}
