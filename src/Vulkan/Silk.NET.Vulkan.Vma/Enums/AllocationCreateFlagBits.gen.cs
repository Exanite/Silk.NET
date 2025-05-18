// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [Flags]
    [NativeName("Name", "VmaAllocationCreateFlagBits")]
    public enum AllocationCreateFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT")]
        DedicatedMemoryBit = 0x1,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT")]
        NeverAllocateBit = 0x2,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_MAPPED_BIT")]
        MappedBit = 0x4,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT")]
        UserDataCopyStringBit = 0x20,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_UPPER_ADDRESS_BIT")]
        UpperAddressBit = 0x40,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_DONT_BIND_BIT")]
        DontBindBit = 0x80,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_WITHIN_BUDGET_BIT")]
        WithinBudgetBit = 0x100,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_CAN_ALIAS_BIT")]
        CanAliasBit = 0x200,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_SEQUENTIAL_WRITE_BIT")]
        HostAccessSequentialWriteBit = 0x400,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_RANDOM_BIT")]
        HostAccessRandomBit = 0x800,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_ALLOW_TRANSFER_INSTEAD_BIT")]
        HostAccessAllowTransferInsteadBit = 0x1000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT")]
        StrategyMinMemoryBit = 0x10000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT")]
        StrategyMinTimeBit = 0x20000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_OFFSET_BIT")]
        StrategyMinOffsetBit = 0x40000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT")]
        StrategyBestFitBit = 0x10000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT")]
        StrategyFirstFitBit = 0x20000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MASK")]
        StrategyMask = 0x70000,
        [NativeName("Name", "VMA_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM")]
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
