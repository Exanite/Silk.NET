// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [NativeName("Name", "VmaDefragmentationMoveOperation")]
    public enum DefragmentationMoveOperation : int
    {
        [Obsolete("Deprecated in favour of \"Copy\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_COPY")]
        DefragmentationMoveOperationCopy = 0x0,
        [Obsolete("Deprecated in favour of \"Ignore\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_IGNORE")]
        DefragmentationMoveOperationIgnore = 0x1,
        [Obsolete("Deprecated in favour of \"Destroy\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_DESTROY")]
        DefragmentationMoveOperationDestroy = 0x2,
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_COPY")]
        Copy = 0x0,
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_IGNORE")]
        Ignore = 0x1,
        [NativeName("Name", "VMA_DEFRAGMENTATION_MOVE_OPERATION_DESTROY")]
        Destroy = 0x2,
    }
}
