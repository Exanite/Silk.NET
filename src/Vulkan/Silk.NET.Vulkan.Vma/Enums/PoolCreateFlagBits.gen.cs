// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [Flags]
    [NativeName("Name", "VmaPoolCreateFlagBits")]
    public enum PoolCreateFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"IgnoreBufferImageGranularityBit\"")]
        [NativeName("Name", "VMA_POOL_CREATE_IGNORE_BUFFER_IMAGE_GRANULARITY_BIT")]
        PoolCreateIgnoreBufferImageGranularityBit = 0x2,
        [Obsolete("Deprecated in favour of \"LinearAlgorithmBit\"")]
        [NativeName("Name", "VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT")]
        PoolCreateLinearAlgorithmBit = 0x4,
        [Obsolete("Deprecated in favour of \"AlgorithmMask\"")]
        [NativeName("Name", "VMA_POOL_CREATE_ALGORITHM_MASK")]
        PoolCreateAlgorithmMask = 0x4,
        [Obsolete("Deprecated in favour of \"FlagBitsMaxEnum\"")]
        [NativeName("Name", "VMA_POOL_CREATE_FLAG_BITS_MAX_ENUM")]
        PoolCreateFlagBitsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "VMA_POOL_CREATE_IGNORE_BUFFER_IMAGE_GRANULARITY_BIT")]
        IgnoreBufferImageGranularityBit = 0x2,
        [NativeName("Name", "VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT")]
        LinearAlgorithmBit = 0x4,
        [NativeName("Name", "VMA_POOL_CREATE_ALGORITHM_MASK")]
        AlgorithmMask = 0x4,
        [NativeName("Name", "VMA_POOL_CREATE_FLAG_BITS_MAX_ENUM")]
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
