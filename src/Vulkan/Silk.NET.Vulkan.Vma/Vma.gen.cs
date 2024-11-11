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
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocatorCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocator* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocatorCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocator pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocatorCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocator* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAllocator")]
        public partial Silk.NET.Vulkan.Result CreateAllocator([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocatorCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocator pAllocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1676, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaDestroyAllocator")]
        public partial void DestroyAllocator(Silk.NET.Vulkan.Vma.Allocator allocator);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocatorInfo")]
        public unsafe partial void GetAllocatorInfo(Silk.NET.Vulkan.Vma.Allocator allocator, AllocatorInfo* pAllocatorInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocatorInfo")]
        public partial void GetAllocatorInfo(Silk.NET.Vulkan.Vma.Allocator allocator, ref AllocatorInfo pAllocatorInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPhysicalDeviceProperties")]
        public unsafe partial void GetPhysicalDeviceProperties(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.PhysicalDeviceProperties** ppPhysicalDeviceProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1692, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPhysicalDeviceProperties")]
        public unsafe partial void GetPhysicalDeviceProperties(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.PhysicalDeviceProperties* ppPhysicalDeviceProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryProperties")]
        public unsafe partial void GetMemoryProperties(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.PhysicalDeviceMemoryProperties** ppPhysicalDeviceMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1700, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryProperties")]
        public unsafe partial void GetMemoryProperties(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.PhysicalDeviceMemoryProperties* ppPhysicalDeviceMemoryProperties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryTypeProperties")]
        public unsafe partial void GetMemoryTypeProperties(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeIndex, uint* pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetMemoryTypeProperties")]
        public partial void GetMemoryTypeProperties(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeIndex, ref uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1717, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetCurrentFrameIndex")]
        public partial void SetCurrentFrameIndex(Silk.NET.Vulkan.Vma.Allocator allocator, uint frameIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculateStatistics")]
        public unsafe partial void CalculateStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, TotalStatistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculateStatistics")]
        public partial void CalculateStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, ref TotalStatistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetHeapBudgets")]
        public unsafe partial void GetHeapBudgets(Silk.NET.Vulkan.Vma.Allocator allocator, Budget* pBudgets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetHeapBudgets")]
        public partial void GetHeapBudgets(Silk.NET.Vulkan.Vma.Allocator allocator, ref Budget pBudgets);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndex(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndex(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndex(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndex")]
        public partial Silk.NET.Vulkan.Result FindMemoryTypeIndex(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForBufferInfo")]
        public partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public unsafe partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, uint* pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFindMemoryTypeIndexForImageInfo")]
        public partial Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref uint pMemoryTypeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial Silk.NET.Vulkan.Result CreatePool(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PoolCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Pool* pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial Silk.NET.Vulkan.Result CreatePool(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PoolCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Pool pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public unsafe partial Silk.NET.Vulkan.Result CreatePool(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PoolCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Pool* pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreatePool")]
        public partial Silk.NET.Vulkan.Result CreatePool(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PoolCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Pool pPool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1823, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaDestroyPool")]
        public partial void DestroyPool(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPoolStatistics")]
        public unsafe partial void GetPoolStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, Statistics* pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPoolStatistics")]
        public partial void GetPoolStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, ref Statistics pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculatePoolStatistics")]
        public unsafe partial void CalculatePoolStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, DetailedStatistics* pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculatePoolStatistics")]
        public partial void CalculatePoolStatistics(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, ref DetailedStatistics pPoolStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1880, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCheckPoolCorruption")]
        public partial Silk.NET.Vulkan.Result CheckPoolCorruption(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPoolName")]
        public unsafe partial void GetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** ppName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetPoolName")]
        public unsafe partial void GetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* ppName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public unsafe partial void SetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public partial void SetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetPoolName")]
        public partial void SetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemory")]
        public partial Silk.NET.Vulkan.Result AllocateMemory(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryPages")]
        public partial Silk.NET.Vulkan.Result AllocateMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.MemoryRequirements pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForBuffer")]
        public partial Silk.NET.Vulkan.Result AllocateMemoryForBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public unsafe partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaAllocateMemoryForImage")]
        public partial Silk.NET.Vulkan.Result AllocateMemoryForImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1998, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeMemory")]
        public partial void FreeMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeMemoryPages")]
        public unsafe partial void FreeMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeMemoryPages")]
        public partial void FreeMemoryPages(Silk.NET.Vulkan.Vma.Allocator allocator, nuint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation pAllocations);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo")]
        public unsafe partial void GetAllocationInfo(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo")]
        public partial void GetAllocationInfo(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo2")]
        public unsafe partial void GetAllocationInfo2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, AllocationInfo2* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationInfo2")]
        public partial void GetAllocationInfo2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ref AllocationInfo2 pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationUserData")]
        public unsafe partial void SetAllocationUserData(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, void* pUserData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationUserData")]
        public partial void SetAllocationUserData<T0>(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ref T0 pUserData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public unsafe partial void SetAllocationName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public partial void SetAllocationName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetAllocationName")]
        public partial void SetAllocationName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationMemoryProperties")]
        public unsafe partial void GetAllocationMemoryProperties(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, uint* pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetAllocationMemoryProperties")]
        public partial void GetAllocationMemoryProperties(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ref uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2153, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaMapMemory")]
        public unsafe partial Silk.NET.Vulkan.Result MapMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, void** ppData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2153, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaMapMemory")]
        public unsafe partial Silk.NET.Vulkan.Result MapMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2166, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaUnmapMemory")]
        public partial void UnmapMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2191, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocation")]
        public partial Silk.NET.Vulkan.Result FlushAllocation(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2218, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocation")]
        public partial Silk.NET.Vulkan.Result InvalidateAllocation(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong offset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFlushAllocations")]
        public partial Silk.NET.Vulkan.Result FlushAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public unsafe partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaInvalidateAllocations")]
        public partial Silk.NET.Vulkan.Result InvalidateAllocations(Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, ref Silk.NET.Vulkan.Vma.Allocation allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ulong sizes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCopyMemoryToAllocation")]
        public unsafe partial Silk.NET.Vulkan.Result CopyMemoryToAllocation(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pSrcHostPointer, Silk.NET.Vulkan.Vma.Allocation dstAllocation, ulong dstAllocationLocalOffset, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCopyMemoryToAllocation")]
        public partial Silk.NET.Vulkan.Result CopyMemoryToAllocation<T0>(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pSrcHostPointer, Silk.NET.Vulkan.Vma.Allocation dstAllocation, ulong dstAllocationLocalOffset, ulong size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCopyAllocationToMemory")]
        public unsafe partial Silk.NET.Vulkan.Result CopyAllocationToMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation srcAllocation, ulong srcAllocationLocalOffset, void* pDstHostPointer, ulong size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCopyAllocationToMemory")]
        public partial Silk.NET.Vulkan.Result CopyAllocationToMemory<T0>(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation srcAllocation, ulong srcAllocationLocalOffset, ref T0 pDstHostPointer, ulong size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2338, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCheckCorruption")]
        public partial Silk.NET.Vulkan.Result CheckCorruption(Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial Silk.NET.Vulkan.Result BeginDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DefragmentationInfo* pInfo, Silk.NET.Vulkan.Vma.DefragmentationContext* pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial Silk.NET.Vulkan.Result BeginDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DefragmentationInfo* pInfo, ref Silk.NET.Vulkan.Vma.DefragmentationContext pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public unsafe partial Silk.NET.Vulkan.Result BeginDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DefragmentationInfo pInfo, Silk.NET.Vulkan.Vma.DefragmentationContext* pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentation")]
        public partial Silk.NET.Vulkan.Result BeginDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DefragmentationInfo pInfo, ref Silk.NET.Vulkan.Vma.DefragmentationContext pContext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentation")]
        public unsafe partial void EndDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, DefragmentationStats* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentation")]
        public partial void EndDefragmentation(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, ref DefragmentationStats pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentationPass")]
        public unsafe partial Silk.NET.Vulkan.Result BeginDefragmentationPass(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, DefragmentationPassMoveInfo* pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBeginDefragmentationPass")]
        public partial Silk.NET.Vulkan.Result BeginDefragmentationPass(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, ref DefragmentationPassMoveInfo pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentationPass")]
        public unsafe partial Silk.NET.Vulkan.Result EndDefragmentationPass(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, DefragmentationPassMoveInfo* pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaEndDefragmentationPass")]
        public partial Silk.NET.Vulkan.Result EndDefragmentationPass(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, ref DefragmentationPassMoveInfo pPassInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2422, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory")]
        public partial Silk.NET.Vulkan.Result BindBufferMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Silk.NET.Vulkan.Buffer buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public unsafe partial Silk.NET.Vulkan.Result BindBufferMemory2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindBufferMemory2")]
        public partial Silk.NET.Vulkan.Result BindBufferMemory2<T0>(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2459, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory")]
        public partial Silk.NET.Vulkan.Result BindImageMemory(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Silk.NET.Vulkan.Image image);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public unsafe partial Silk.NET.Vulkan.Result BindImageMemory2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBindImageMemory2")]
        public partial Silk.NET.Vulkan.Result BindImageMemory2<T0>(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pNext) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBuffer")]
        public partial Silk.NET.Vulkan.Result CreateBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public unsafe partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateBufferWithAlignment")]
        public partial Silk.NET.Vulkan.Result CreateBufferWithAlignment(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer pBuffer, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer")]
        public partial Silk.NET.Vulkan.Result CreateAliasingBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingBuffer2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingBuffer2")]
        public partial Silk.NET.Vulkan.Result CreateAliasingBuffer2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.BufferCreateInfo pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer pBuffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2608, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaDestroyBuffer")]
        public partial void DestroyBuffer(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, Silk.NET.Vulkan.Vma.Allocation allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, AllocationInfo* pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateImage")]
        public partial Silk.NET.Vulkan.Result CreateImage(Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCreateInfo pAllocationCreateInfo, ref Silk.NET.Vulkan.Image pImage, ref Silk.NET.Vulkan.Vma.Allocation pAllocation, ref AllocationInfo pAllocationInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, Silk.NET.Vulkan.Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, ref Silk.NET.Vulkan.Image pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, Silk.NET.Vulkan.Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage")]
        public partial Silk.NET.Vulkan.Result CreateAliasingImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, ref Silk.NET.Vulkan.Image pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, Silk.NET.Vulkan.Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, ref Silk.NET.Vulkan.Image pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public unsafe partial Silk.NET.Vulkan.Result CreateAliasingImage2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, Silk.NET.Vulkan.Image* pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateAliasingImage2")]
        public partial Silk.NET.Vulkan.Result CreateAliasingImage2(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Vulkan.ImageCreateInfo pImageCreateInfo, ref Silk.NET.Vulkan.Image pImage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2648, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaDestroyImage")]
        public partial void DestroyImage(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, Silk.NET.Vulkan.Vma.Allocation allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial Silk.NET.Vulkan.Result CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualBlockCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.VirtualBlock* pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial Silk.NET.Vulkan.Result CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualBlockCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualBlock pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public unsafe partial Silk.NET.Vulkan.Result CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualBlockCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.VirtualBlock* pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCreateVirtualBlock")]
        public partial Silk.NET.Vulkan.Result CreateVirtualBlock([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualBlockCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualBlock pVirtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2678, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaDestroyVirtualBlock")]
        public partial void DestroyVirtualBlock(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2683, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaIsVirtualBlockEmpty")]
        public partial uint IsVirtualBlockEmpty(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualAllocationInfo")]
        public unsafe partial void GetVirtualAllocationInfo(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, VirtualAllocationInfo* pVirtualAllocInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualAllocationInfo")]
        public partial void GetVirtualAllocationInfo(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, ref VirtualAllocationInfo pVirtualAllocInfo);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualAllocation pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualAllocation pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public unsafe partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualAllocation pAllocation, ulong* pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualAllocate")]
        public partial Silk.NET.Vulkan.Result VirtualAllocate(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VirtualAllocationCreateInfo pCreateInfo, ref Silk.NET.Vulkan.Vma.VirtualAllocation pAllocation, ref ulong pOffset);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2713, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaVirtualFree")]
        public partial void VirtualFree(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2725, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaClearVirtualBlock")]
        public partial void ClearVirtualBlock(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetVirtualAllocationUserData")]
        public unsafe partial void SetVirtualAllocationUserData(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, void* pUserData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaSetVirtualAllocationUserData")]
        public partial void SetVirtualAllocationUserData<T0>(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, ref T0 pUserData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualBlockStatistics")]
        public unsafe partial void GetVirtualBlockStatistics(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Statistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaGetVirtualBlockStatistics")]
        public partial void GetVirtualBlockStatistics(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, ref Statistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculateVirtualBlockStatistics")]
        public unsafe partial void CalculateVirtualBlockStatistics(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, DetailedStatistics* pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaCalculateVirtualBlockStatistics")]
        public partial void CalculateVirtualBlockStatistics(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, ref DetailedStatistics pStats);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBuildVirtualBlockStatsString")]
        public unsafe partial void BuildVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, byte** ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBuildVirtualBlockStatsString")]
        public unsafe partial void BuildVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, ref byte* ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public unsafe partial void FreeVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, byte* pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public partial void FreeVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, ref byte pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeVirtualBlockStatsString")]
        public partial void FreeVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBuildStatsString")]
        public unsafe partial void BuildStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, byte** ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaBuildStatsString")]
        public unsafe partial void BuildStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, ref byte* ppStatsString, uint detailedMap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public unsafe partial void FreeStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, byte* pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public partial void FreeStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, ref byte pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_mem_alloc.h")]
        [NativeApi(EntryPoint = "vmaFreeStatsString")]
        public partial void FreeStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pStatsString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1890, Column 33 in vk_mem_alloc.h")]
        public unsafe void GetPoolName(Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] ppNameSa)
        {
            // StringArrayOverloader
            var ppName = (byte**) SilkMarshal.StringArrayToPtr(ppNameSa);
            GetPoolName(allocator, pool, ppName);
            SilkMarshal.CopyPtrToStringArray((nint) ppName, ppNameSa);
            SilkMarshal.Free((nint) ppName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2767, Column 33 in vk_mem_alloc.h")]
        public unsafe void BuildVirtualBlockStatsString(Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, string[] ppStatsStringSa, uint detailedMap)
        {
            // StringArrayOverloader
            var ppStatsString = (byte**) SilkMarshal.StringArrayToPtr(ppStatsStringSa);
            BuildVirtualBlockStatsString(virtualBlock, ppStatsString, detailedMap);
            SilkMarshal.CopyPtrToStringArray((nint) ppStatsString, ppStatsStringSa);
            SilkMarshal.Free((nint) ppStatsString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2782, Column 33 in vk_mem_alloc.h")]
        public unsafe void BuildStatsString(Silk.NET.Vulkan.Vma.Allocator allocator, string[] ppStatsStringSa, uint detailedMap)
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

