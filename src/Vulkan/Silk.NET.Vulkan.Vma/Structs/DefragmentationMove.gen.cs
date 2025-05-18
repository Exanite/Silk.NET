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
    [NativeName("Name", "VmaDefragmentationMove")]
    public unsafe partial struct DefragmentationMove
    {
        public DefragmentationMove
        (
            DefragmentationMoveOperation? operation = null,
            Allocation* srcAllocation = null,
            Allocation* dstTmpAllocation = null
        ) : this()
        {
            if (operation is not null)
            {
                Operation = operation.Value;
            }

            if (srcAllocation is not null)
            {
                SrcAllocation = srcAllocation;
            }

            if (dstTmpAllocation is not null)
            {
                DstTmpAllocation = dstTmpAllocation;
            }
        }


        [NativeName("Type", "VmaDefragmentationMoveOperation")]
        [NativeName("Type.Name", "VmaDefragmentationMoveOperation")]
        [NativeName("Name", "operation")]
        public DefragmentationMoveOperation Operation;

        [NativeName("Type", "VmaAllocation _Nonnull")]
        [NativeName("Type.Name", "VmaAllocation _Nonnull")]
        [NativeName("Name", "srcAllocation")]
        public Allocation* SrcAllocation;

        [NativeName("Type", "VmaAllocation _Nonnull")]
        [NativeName("Type.Name", "VmaAllocation _Nonnull")]
        [NativeName("Name", "dstTmpAllocation")]
        public Allocation* DstTmpAllocation;
    }
}
