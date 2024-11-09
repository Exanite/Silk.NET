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
    public unsafe partial class Vma : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_VULKAN_VERSION")]
        public const int VulkanVersion = unchecked((int) 0xF4DF8);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_DEDICATED_ALLOCATION")]
        public const int DedicatedAllocation = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_BIND_MEMORY2")]
        public const int BindMemory2 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_MEMORY_BUDGET")]
        public const int MemoryBudget = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_BUFFER_DEVICE_ADDRESS")]
        public const int BufferDeviceAddress = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_MEMORY_PRIORITY")]
        public const int MemoryPriority = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_KHR_MAINTENANCE4")]
        public const int KhrMaintenance4 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_KHR_MAINTENANCE5")]
        public const int KhrMaintenance5 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_EXTERNAL_MEMORY")]
        public const int ExternalMemory = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_EXTERNAL_MEMORY_WIN32")]
        public const int ExternalMemoryWin32 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "VMA_STATS_STRING_ENABLED")]
        public const int StatsStringEnabled = unchecked((int) 0x1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial VkResult CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocatorCreateInfo* pCreateInfo, AllocatorT** pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial VkResult CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocatorCreateInfo* pCreateInfo, ref AllocatorT* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial VkResult CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocatorCreateInfo pCreateInfo, AllocatorT** pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial VkResult CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocatorCreateInfo pCreateInfo, ref AllocatorT* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyAllocator")]
        public unsafe partial void DestroyAllocator(AllocatorT* allocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocatorInfo")]
        public unsafe partial void GetAllocatorInfo(AllocatorT* allocator, AllocatorInfo* pAllocatorInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocatorInfo")]
        public unsafe partial void GetAllocatorInfo(AllocatorT* allocator, ref AllocatorInfo pAllocatorInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPhysicalDeviceProperties")]
        public unsafe partial void GetPhysicalDeviceProperties(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkPhysicalDeviceProperties** ppPhysicalDeviceProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPhysicalDeviceProperties")]
        public unsafe partial void GetPhysicalDeviceProperties(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkPhysicalDeviceProperties* ppPhysicalDeviceProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryProperties")]
        public unsafe partial void GetMemoryProperties(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkPhysicalDeviceMemoryProperties** ppPhysicalDeviceMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryProperties")]
        public unsafe partial void GetMemoryProperties(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkPhysicalDeviceMemoryProperties* ppPhysicalDeviceMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryTypeProperties")]
        public unsafe partial void GetMemoryTypeProperties(AllocatorT* allocator, uint memoryTypeIndex, uint* pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryTypeProperties")]
        public unsafe partial void GetMemoryTypeProperties(AllocatorT* allocator, uint memoryTypeIndex, ref uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetCurrentFrameIndex")]
        public unsafe partial void SetCurrentFrameIndex(AllocatorT* allocator, uint frameIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculateStatistics")]
        public unsafe partial void CalculateStatistics(AllocatorT* allocator, TotalStatistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculateStatistics")]
        public unsafe partial void CalculateStatistics(AllocatorT* allocator, ref TotalStatistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetHeapBudgets")]
        public unsafe partial void GetHeapBudgets(AllocatorT* allocator, Budget* pBudgets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetHeapBudgets")]
        public unsafe partial void GetHeapBudgets(AllocatorT* allocator, ref Budget pBudgets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial VkResult FindMemoryTypeIndex(AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial VkResult FindMemoryTypeIndex(AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial VkResult FindMemoryTypeIndex(AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial VkResult FindMemoryTypeIndex(AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForBufferInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial VkResult FindMemoryTypeIndexForImageInfo(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial VkResult CreatePool(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PoolCreateInfo* pCreateInfo, PoolT** pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial VkResult CreatePool(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PoolCreateInfo* pCreateInfo, ref PoolT* pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial VkResult CreatePool(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PoolCreateInfo pCreateInfo, PoolT** pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial VkResult CreatePool(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PoolCreateInfo pCreateInfo, ref PoolT* pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1823, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyPool")]
        public unsafe partial void DestroyPool(AllocatorT* allocator, PoolT* pool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPoolStatistics")]
        public unsafe partial void GetPoolStatistics(AllocatorT* allocator, PoolT* pool, Statistics* pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPoolStatistics")]
        public unsafe partial void GetPoolStatistics(AllocatorT* allocator, PoolT* pool, ref Statistics pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculatePoolStatistics")]
        public unsafe partial void CalculatePoolStatistics(AllocatorT* allocator, PoolT* pool, DetailedStatistics* pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculatePoolStatistics")]
        public unsafe partial void CalculatePoolStatistics(AllocatorT* allocator, PoolT* pool, ref DetailedStatistics pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1880, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCheckPoolCorruption")]
        public unsafe partial VkResult CheckPoolCorruption(AllocatorT* allocator, PoolT* pool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPoolName")]
        public unsafe partial void GetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** ppName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetPoolName")]
        public unsafe partial void GetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* ppName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public unsafe partial void SetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public unsafe partial void SetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public unsafe partial void SetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial VkResult AllocateMemory(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, AllocationT** pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkMemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, AllocationT** pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial VkResult AllocateMemoryPages(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkMemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial VkResult AllocateMemoryForBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial VkResult AllocateMemoryForImage(AllocatorT* allocator, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1998, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeMemory")]
        public unsafe partial void FreeMemory(AllocatorT* allocator, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeMemoryPages")]
        public unsafe partial void FreeMemoryPages(AllocatorT* allocator, nuint allocationCount, AllocationT** pAllocations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeMemoryPages")]
        public unsafe partial void FreeMemoryPages(AllocatorT* allocator, nuint allocationCount, ref AllocationT* pAllocations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo")]
        public unsafe partial void GetAllocationInfo(AllocatorT* allocator, AllocationT* allocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo")]
        public unsafe partial void GetAllocationInfo(AllocatorT* allocator, AllocationT* allocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo2")]
        public unsafe partial void GetAllocationInfo2(AllocatorT* allocator, AllocationT* allocation, AllocationInfo2* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo2")]
        public unsafe partial void GetAllocationInfo2(AllocatorT* allocator, AllocationT* allocation, ref AllocationInfo2 pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationUserData")]
        public unsafe partial void SetAllocationUserData(AllocatorT* allocator, AllocationT* allocation, void* pUserData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationUserData")]
        public unsafe partial void SetAllocationUserData<T0>(AllocatorT* allocator, AllocationT* allocation, ref T0 pUserData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public unsafe partial void SetAllocationName(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public unsafe partial void SetAllocationName(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public unsafe partial void SetAllocationName(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationMemoryProperties")]
        public unsafe partial void GetAllocationMemoryProperties(AllocatorT* allocator, AllocationT* allocation, uint* pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationMemoryProperties")]
        public unsafe partial void GetAllocationMemoryProperties(AllocatorT* allocator, AllocationT* allocation, ref uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2153, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaMapMemory")]
        public unsafe partial VkResult MapMemory(AllocatorT* allocator, AllocationT* allocation, void** ppData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2153, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaMapMemory")]
        public unsafe partial VkResult MapMemory(AllocatorT* allocator, AllocationT* allocation, ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2166, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaUnmapMemory")]
        public unsafe partial void UnmapMemory(AllocatorT* allocator, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2191, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocation")]
        public unsafe partial VkResult FlushAllocation(AllocatorT* allocator, AllocationT* allocation, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2218, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocation")]
        public unsafe partial VkResult InvalidateAllocation(AllocatorT* allocator, AllocationT* allocation, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial VkResult FlushAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial VkResult InvalidateAllocations(AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCopyMemoryToAllocation")]
        public unsafe partial VkResult CopyMemoryToAllocation(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcHostPointer, AllocationT* dstAllocation, ulong dstAllocationLocalOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCopyMemoryToAllocation")]
        public unsafe partial VkResult CopyMemoryToAllocation<T0>(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcHostPointer, AllocationT* dstAllocation, ulong dstAllocationLocalOffset, ulong size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCopyAllocationToMemory")]
        public unsafe partial VkResult CopyAllocationToMemory(AllocatorT* allocator, AllocationT* srcAllocation, ulong srcAllocationLocalOffset, void* pDstHostPointer, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCopyAllocationToMemory")]
        public unsafe partial VkResult CopyAllocationToMemory<T0>(AllocatorT* allocator, AllocationT* srcAllocation, ulong srcAllocationLocalOffset, ref T0 pDstHostPointer, ulong size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2338, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCheckCorruption")]
        public unsafe partial VkResult CheckCorruption(AllocatorT* allocator, uint memoryTypeBits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial VkResult BeginDefragmentation(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DefragmentationInfo* pInfo, DefragmentationContextT** pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial VkResult BeginDefragmentation(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DefragmentationInfo* pInfo, ref DefragmentationContextT* pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial VkResult BeginDefragmentation(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DefragmentationInfo pInfo, DefragmentationContextT** pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial VkResult BeginDefragmentation(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DefragmentationInfo pInfo, ref DefragmentationContextT* pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentation")]
        public unsafe partial void EndDefragmentation(AllocatorT* allocator, DefragmentationContextT* context, DefragmentationStats* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentation")]
        public unsafe partial void EndDefragmentation(AllocatorT* allocator, DefragmentationContextT* context, ref DefragmentationStats pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentationPass")]
        public unsafe partial VkResult BeginDefragmentationPass(AllocatorT* allocator, DefragmentationContextT* context, DefragmentationPassMoveInfo* pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentationPass")]
        public unsafe partial VkResult BeginDefragmentationPass(AllocatorT* allocator, DefragmentationContextT* context, ref DefragmentationPassMoveInfo pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentationPass")]
        public unsafe partial VkResult EndDefragmentationPass(AllocatorT* allocator, DefragmentationContextT* context, DefragmentationPassMoveInfo* pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentationPass")]
        public unsafe partial VkResult EndDefragmentationPass(AllocatorT* allocator, DefragmentationContextT* context, ref DefragmentationPassMoveInfo pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2422, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory")]
        public unsafe partial VkResult BindBufferMemory(AllocatorT* allocator, AllocationT* allocation, VkBuffer_T* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2422, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory")]
        public unsafe partial VkResult BindBufferMemory(AllocatorT* allocator, AllocationT* allocation, ref VkBuffer_T buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public unsafe partial VkResult BindBufferMemory2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public unsafe partial VkResult BindBufferMemory2<T0>(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, VkBuffer_T* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public unsafe partial VkResult BindBufferMemory2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public unsafe partial VkResult BindBufferMemory2<T0>(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, ref VkBuffer_T buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2459, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory")]
        public unsafe partial VkResult BindImageMemory(AllocatorT* allocator, AllocationT* allocation, VkImage_T* image);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2459, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory")]
        public unsafe partial VkResult BindImageMemory(AllocatorT* allocator, AllocationT* allocation, ref VkImage_T image);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public unsafe partial VkResult BindImageMemory2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public unsafe partial VkResult BindImageMemory2<T0>(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, VkImage_T* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public unsafe partial VkResult BindImageMemory2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public unsafe partial VkResult BindImageMemory2<T0>(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, ref VkImage_T image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial VkResult CreateBuffer(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, VkBuffer_T** pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial VkResult CreateBufferWithAlignment(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref VkBuffer_T* pBuffer, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial VkResult CreateAliasingBuffer(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, VkBuffer_T** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial VkResult CreateAliasingBuffer(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, ref VkBuffer_T* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial VkResult CreateAliasingBuffer(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, VkBuffer_T** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial VkResult CreateAliasingBuffer(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, ref VkBuffer_T* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial VkResult CreateAliasingBuffer2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, VkBuffer_T** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial VkResult CreateAliasingBuffer2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkBufferCreateInfo* pBufferCreateInfo, ref VkBuffer_T* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial VkResult CreateAliasingBuffer2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, VkBuffer_T** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial VkResult CreateAliasingBuffer2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkBufferCreateInfo pBufferCreateInfo, ref VkBuffer_T* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2608, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyBuffer")]
        public unsafe partial void DestroyBuffer(AllocatorT* allocator, VkBuffer_T* buffer, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2608, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyBuffer")]
        public unsafe partial void DestroyBuffer(AllocatorT* allocator, ref VkBuffer_T buffer, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, VkImage_T** pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, AllocationT** pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial VkResult CreateImage(AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref VkImage_T* pImage, ref AllocationT* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial VkResult CreateAliasingImage(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, VkImage_T** pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial VkResult CreateAliasingImage(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, ref VkImage_T* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial VkResult CreateAliasingImage(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, VkImage_T** pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial VkResult CreateAliasingImage(AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, ref VkImage_T* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial VkResult CreateAliasingImage2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, VkImage_T** pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial VkResult CreateAliasingImage2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VkImageCreateInfo* pImageCreateInfo, ref VkImage_T* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial VkResult CreateAliasingImage2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, VkImage_T** pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial VkResult CreateAliasingImage2(AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VkImageCreateInfo pImageCreateInfo, ref VkImage_T* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2648, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyImage")]
        public unsafe partial void DestroyImage(AllocatorT* allocator, VkImage_T* image, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2648, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyImage")]
        public unsafe partial void DestroyImage(AllocatorT* allocator, ref VkImage_T image, AllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial VkResult CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualBlockCreateInfo* pCreateInfo, VirtualBlockT** pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial VkResult CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualBlockCreateInfo* pCreateInfo, ref VirtualBlockT* pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial VkResult CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualBlockCreateInfo pCreateInfo, VirtualBlockT** pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial VkResult CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualBlockCreateInfo pCreateInfo, ref VirtualBlockT* pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaDestroyVirtualBlock")]
        public unsafe partial void DestroyVirtualBlock(VirtualBlockT* virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2683, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaIsVirtualBlockEmpty")]
        public unsafe partial uint IsVirtualBlockEmpty(VirtualBlockT* virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualAllocationInfo")]
        public unsafe partial void GetVirtualAllocationInfo(VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, VirtualAllocationInfo* pVirtualAllocInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualAllocationInfo")]
        public unsafe partial void GetVirtualAllocationInfo(VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, ref VirtualAllocationInfo pVirtualAllocInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, VirtualAllocationT** pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, VirtualAllocationT** pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, ref VirtualAllocationT* pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, ref VirtualAllocationT* pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, VirtualAllocationT** pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, VirtualAllocationT** pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, ref VirtualAllocationT* pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial VkResult VirtualAllocate(VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, ref VirtualAllocationT* pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2713, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaVirtualFree")]
        public unsafe partial void VirtualFree(VirtualBlockT* virtualBlock, VirtualAllocationT* allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2725, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaClearVirtualBlock")]
        public unsafe partial void ClearVirtualBlock(VirtualBlockT* virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetVirtualAllocationUserData")]
        public unsafe partial void SetVirtualAllocationUserData(VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, void* pUserData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaSetVirtualAllocationUserData")]
        public unsafe partial void SetVirtualAllocationUserData<T0>(VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, ref T0 pUserData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualBlockStatistics")]
        public unsafe partial void GetVirtualBlockStatistics(VirtualBlockT* virtualBlock, Statistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualBlockStatistics")]
        public unsafe partial void GetVirtualBlockStatistics(VirtualBlockT* virtualBlock, ref Statistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculateVirtualBlockStatistics")]
        public unsafe partial void CalculateVirtualBlockStatistics(VirtualBlockT* virtualBlock, DetailedStatistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaCalculateVirtualBlockStatistics")]
        public unsafe partial void CalculateVirtualBlockStatistics(VirtualBlockT* virtualBlock, ref DetailedStatistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBuildVirtualBlockStatsString")]
        public unsafe partial void BuildVirtualBlockStatsString(VirtualBlockT* virtualBlock, byte** ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBuildVirtualBlockStatsString")]
        public unsafe partial void BuildVirtualBlockStatsString(VirtualBlockT* virtualBlock, ref byte* ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public unsafe partial void FreeVirtualBlockStatsString(VirtualBlockT* virtualBlock, byte* pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public unsafe partial void FreeVirtualBlockStatsString(VirtualBlockT* virtualBlock, ref byte pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public unsafe partial void FreeVirtualBlockStatsString(VirtualBlockT* virtualBlock, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBuildStatsString")]
        public unsafe partial void BuildStatsString(AllocatorT* allocator, byte** ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaBuildStatsString")]
        public unsafe partial void BuildStatsString(AllocatorT* allocator, ref byte* ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public unsafe partial void FreeStatsString(AllocatorT* allocator, byte* pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public unsafe partial void FreeStatsString(AllocatorT* allocator, ref byte pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_vma.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public unsafe partial void FreeStatsString(AllocatorT* allocator, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_vma.h")]
        public unsafe void GetPoolName(AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppNameSa)
        {
            // StringArrayOverloader
            var ppName = (byte**) SilkMarshal.StringArrayToPtr(ppNameSa);
            GetPoolName(allocator, pool, ppName);
            SilkMarshal.CopyPtrToStringArray((nint) ppName, ppNameSa);
            SilkMarshal.Free((nint) ppName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_vma.h")]
        public unsafe void BuildVirtualBlockStatsString(VirtualBlockT* virtualBlock, string[] ppStatsStringSa, uint detailedMap)
        {
            // StringArrayOverloader
            var ppStatsString = (byte**) SilkMarshal.StringArrayToPtr(ppStatsStringSa);
            BuildVirtualBlockStatsString(virtualBlock, ppStatsString, detailedMap);
            SilkMarshal.CopyPtrToStringArray((nint) ppStatsString, ppStatsStringSa);
            SilkMarshal.Free((nint) ppStatsString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_vma.h")]
        public unsafe void BuildStatsString(AllocatorT* allocator, string[] ppStatsStringSa, uint detailedMap)
        {
            // StringArrayOverloader
            var ppStatsString = (byte**) SilkMarshal.StringArrayToPtr(ppStatsStringSa);
            BuildStatsString(allocator, ppStatsString, detailedMap);
            SilkMarshal.CopyPtrToStringArray((nint) ppStatsString, ppStatsStringSa);
            SilkMarshal.Free((nint) ppStatsString);
        }


        public Vma(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

