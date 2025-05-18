// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [Flags]
    [NativeName("Name", "VmaAllocatorCreateFlagBits")]
    public enum AllocatorCreateFlagBits : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_EXTERNALLY_SYNCHRONIZED_BIT")]
        ExternallySynchronizedBit = 0x1,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_KHR_DEDICATED_ALLOCATION_BIT")]
        KhrDedicatedAllocationBit = 0x2,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT")]
        KhrBindMemory2Bit = 0x4,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_EXT_MEMORY_BUDGET_BIT")]
        ExtMemoryBudgetBit = 0x8,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_AMD_DEVICE_COHERENT_MEMORY_BIT")]
        AmdDeviceCoherentMemoryBit = 0x10,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_BUFFER_DEVICE_ADDRESS_BIT")]
        BufferDeviceAddressBit = 0x20,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_EXT_MEMORY_PRIORITY_BIT")]
        ExtMemoryPriorityBit = 0x40,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_KHR_MAINTENANCE4_BIT")]
        KhrMaintenance4Bit = 0x80,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_KHR_MAINTENANCE5_BIT")]
        KhrMaintenance5Bit = 0x100,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_KHR_EXTERNAL_MEMORY_WIN32_BIT")]
        KhrExternalMemoryWin32Bit = 0x200,
        [NativeName("Name", "VMA_ALLOCATOR_CREATE_FLAG_BITS_MAX_ENUM")]
        FlagBitsMaxEnum = 0x7FFFFFFF,
    }
}
