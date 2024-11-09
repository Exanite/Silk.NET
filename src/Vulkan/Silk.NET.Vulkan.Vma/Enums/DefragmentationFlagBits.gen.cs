// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [Flags]
    [NativeName("Name", "VmaDefragmentationFlagBits")]
    public enum DefragmentationFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"AlgorithmFastBit\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_FAST_BIT")]
        DefragmentationFlagAlgorithmFastBit = 0x1,
        [Obsolete("Deprecated in favour of \"AlgorithmBalancedBit\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_BALANCED_BIT")]
        DefragmentationFlagAlgorithmBalancedBit = 0x2,
        [Obsolete("Deprecated in favour of \"AlgorithmFullBit\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_FULL_BIT")]
        DefragmentationFlagAlgorithmFullBit = 0x4,
        [Obsolete("Deprecated in favour of \"AlgorithmExtensiveBit\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_EXTENSIVE_BIT")]
        DefragmentationFlagAlgorithmExtensiveBit = 0x8,
        [Obsolete("Deprecated in favour of \"AlgorithmMask\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_MASK")]
        DefragmentationFlagAlgorithmMask = 0xF,
        [Obsolete("Deprecated in favour of \"BitsMaxEnum\"")]
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_BITS_MAX_ENUM")]
        DefragmentationFlagBitsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_FAST_BIT")]
        AlgorithmFastBit = 0x1,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_BALANCED_BIT")]
        AlgorithmBalancedBit = 0x2,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_FULL_BIT")]
        AlgorithmFullBit = 0x4,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_EXTENSIVE_BIT")]
        AlgorithmExtensiveBit = 0x8,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_ALGORITHM_MASK")]
        AlgorithmMask = 0xF,
        [NativeName("Name", "VMA_DEFRAGMENTATION_FLAG_BITS_MAX_ENUM")]
        BitsMaxEnum = 0x7FFFFFFF,
    }
}
