// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [Flags]
    [NativeName("Name", "VmaVirtualAllocationCreateFlagBits")]
    public enum VirtualAllocationCreateFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"UpperAddressBit\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_UPPER_ADDRESS_BIT")]
        VirtualAllocationCreateUpperAddressBit = 0x40,
        [Obsolete("Deprecated in favour of \"StrategyMinMemoryBit\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT")]
        VirtualAllocationCreateStrategyMinMemoryBit = 0x10000,
        [Obsolete("Deprecated in favour of \"StrategyMinTimeBit\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT")]
        VirtualAllocationCreateStrategyMinTimeBit = 0x20000,
        [Obsolete("Deprecated in favour of \"StrategyMinOffsetBit\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_OFFSET_BIT")]
        VirtualAllocationCreateStrategyMinOffsetBit = 0x40000,
        [Obsolete("Deprecated in favour of \"StrategyMask\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MASK")]
        VirtualAllocationCreateStrategyMask = 0x70000,
        [Obsolete("Deprecated in favour of \"FlagBitsMaxEnum\"")]
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM")]
        VirtualAllocationCreateFlagBitsMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_UPPER_ADDRESS_BIT")]
        UpperAddressBit = 0x40,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT")]
        StrategyMinMemoryBit = 0x10000,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT")]
        StrategyMinTimeBit = 0x20000,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MIN_OFFSET_BIT")]
        StrategyMinOffsetBit = 0x40000,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_STRATEGY_MASK")]
        StrategyMask = 0x70000,
        [NativeName("Name", "VMA_VIRTUAL_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM")]
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
