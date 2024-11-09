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
        [Obsolete("Deprecated in favour of \"DedicatedMemoryBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT")]
        AllocationCreateDedicatedMemoryBit = 0x1,
        [Obsolete("Deprecated in favour of \"NeverAllocateBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT")]
        AllocationCreateNeverAllocateBit = 0x2,
        [Obsolete("Deprecated in favour of \"MappedBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_MAPPED_BIT")]
        AllocationCreateMappedBit = 0x4,
        [Obsolete("Deprecated in favour of \"UserDataCopyStringBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT")]
        AllocationCreateUserDataCopyStringBit = 0x20,
        [Obsolete("Deprecated in favour of \"UpperAddressBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_UPPER_ADDRESS_BIT")]
        AllocationCreateUpperAddressBit = 0x40,
        [Obsolete("Deprecated in favour of \"DontBindBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_DONT_BIND_BIT")]
        AllocationCreateDontBindBit = 0x80,
        [Obsolete("Deprecated in favour of \"WithinBudgetBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_WITHIN_BUDGET_BIT")]
        AllocationCreateWithinBudgetBit = 0x100,
        [Obsolete("Deprecated in favour of \"CanAliasBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_CAN_ALIAS_BIT")]
        AllocationCreateCanAliasBit = 0x200,
        [Obsolete("Deprecated in favour of \"HostAccessSequentialWriteBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_SEQUENTIAL_WRITE_BIT")]
        AllocationCreateHostAccessSequentialWriteBit = 0x400,
        [Obsolete("Deprecated in favour of \"HostAccessRandomBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_RANDOM_BIT")]
        AllocationCreateHostAccessRandomBit = 0x800,
        [Obsolete("Deprecated in favour of \"HostAccessAllowTransferInsteadBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_HOST_ACCESS_ALLOW_TRANSFER_INSTEAD_BIT")]
        AllocationCreateHostAccessAllowTransferInsteadBit = 0x1000,
        [Obsolete("Deprecated in favour of \"StrategyMinMemoryBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_MEMORY_BIT")]
        AllocationCreateStrategyMinMemoryBit = 0x10000,
        [Obsolete("Deprecated in favour of \"StrategyMinTimeBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_TIME_BIT")]
        AllocationCreateStrategyMinTimeBit = 0x20000,
        [Obsolete("Deprecated in favour of \"StrategyMinOffsetBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MIN_OFFSET_BIT")]
        AllocationCreateStrategyMinOffsetBit = 0x40000,
        [Obsolete("Deprecated in favour of \"StrategyBestFitBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_BEST_FIT_BIT")]
        AllocationCreateStrategyBestFitBit = 0x10000,
        [Obsolete("Deprecated in favour of \"StrategyFirstFitBit\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_FIRST_FIT_BIT")]
        AllocationCreateStrategyFirstFitBit = 0x20000,
        [Obsolete("Deprecated in favour of \"StrategyMask\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_STRATEGY_MASK")]
        AllocationCreateStrategyMask = 0x70000,
        [Obsolete("Deprecated in favour of \"FlagBitsMaxEnum\"")]
        [NativeName("Name", "VMA_ALLOCATION_CREATE_FLAG_BITS_MAX_ENUM")]
        AllocationCreateFlagBitsMaxEnum = 0x7FFFFFFF,
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
