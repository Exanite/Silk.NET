// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [NativeName("Name", "VmaVirtualBlockCreateFlagBits")]
    public enum VirtualBlockCreateFlagBits : int
    {
        [Obsolete("Deprecated in favour of \"LinearAlgorithmBit\"")]
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_LINEAR_ALGORITHM_BIT")]
        VirtualBlockCreateLinearAlgorithmBit = 0x1,
        [Obsolete("Deprecated in favour of \"AlgorithmMask\"")]
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_ALGORITHM_MASK")]
        VirtualBlockCreateAlgorithmMask = 0x1,
        [Obsolete("Deprecated in favour of \"FlagBitsMaxEnum\"")]
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_FLAG_BITS_MAX_ENUM")]
        VirtualBlockCreateFlagBitsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_LINEAR_ALGORITHM_BIT")]
        LinearAlgorithmBit = 0x1,
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_ALGORITHM_MASK")]
        AlgorithmMask = 0x1,
        [NativeName("Name", "VMA_VIRTUAL_BLOCK_CREATE_FLAG_BITS_MAX_ENUM")]
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
