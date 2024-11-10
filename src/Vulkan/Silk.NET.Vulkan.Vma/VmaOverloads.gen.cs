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
    public static class VmaOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAllocator(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocatorCreateInfo> pCreateInfo, AllocatorT** pAllocator)
        {
            // SpanOverloader
            return thisApi.CreateAllocator(in pCreateInfo.GetPinnableReference(), pAllocator);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAllocator(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocatorCreateInfo> pCreateInfo, ref AllocatorT* pAllocator)
        {
            // SpanOverloader
            return thisApi.CreateAllocator(in pCreateInfo.GetPinnableReference(), ref pAllocator);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_vma.h")]
        public static unsafe void GetAllocatorInfo(this Vma thisApi, AllocatorT* allocator, Span<AllocatorInfo> pAllocatorInfo)
        {
            // SpanOverloader
            thisApi.GetAllocatorInfo(allocator, ref pAllocatorInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_vma.h")]
        public static unsafe void GetMemoryTypeProperties(this Vma thisApi, AllocatorT* allocator, uint memoryTypeIndex, Span<uint> pFlags)
        {
            // SpanOverloader
            thisApi.GetMemoryTypeProperties(allocator, memoryTypeIndex, ref pFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_vma.h")]
        public static unsafe void CalculateStatistics(this Vma thisApi, AllocatorT* allocator, Span<TotalStatistics> pStats)
        {
            // SpanOverloader
            thisApi.CalculateStatistics(allocator, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_vma.h")]
        public static unsafe void GetHeapBudgets(this Vma thisApi, AllocatorT* allocator, Span<Budget> pBudgets)
        {
            // SpanOverloader
            thisApi.GetHeapBudgets(allocator, ref pBudgets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, AllocatorT* allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreatePool(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PoolCreateInfo> pCreateInfo, PoolT** pPool)
        {
            // SpanOverloader
            return thisApi.CreatePool(allocator, in pCreateInfo.GetPinnableReference(), pPool);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreatePool(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PoolCreateInfo> pCreateInfo, ref PoolT* pPool)
        {
            // SpanOverloader
            return thisApi.CreatePool(allocator, in pCreateInfo.GetPinnableReference(), ref pPool);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_vma.h")]
        public static unsafe void GetPoolStatistics(this Vma thisApi, AllocatorT* allocator, PoolT* pool, Span<Statistics> pPoolStats)
        {
            // SpanOverloader
            thisApi.GetPoolStatistics(allocator, pool, ref pPoolStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_vma.h")]
        public static unsafe void CalculatePoolStatistics(this Vma thisApi, AllocatorT* allocator, PoolT* pool, Span<DetailedStatistics> pPoolStats)
        {
            // SpanOverloader
            thisApi.CalculatePoolStatistics(allocator, pool, ref pPoolStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_vma.h")]
        public static unsafe void SetPoolName(this Vma thisApi, AllocatorT* allocator, PoolT* pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            thisApi.SetPoolName(allocator, pool, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, pCreateInfo, allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, pCreateInfo, allocationCount, ref pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, AllocationT** pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, AllocationT** pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, ref pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, ref pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, AllocationT** pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, AllocationT** pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, ref AllocationT* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), pCreateInfo, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), pCreateInfo, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, ref buffer.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), pCreateInfo, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), pCreateInfo, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), pCreateInfo, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, ref image.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_vma.h")]
        public static unsafe void GetAllocationInfo(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            thisApi.GetAllocationInfo(allocator, allocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_vma.h")]
        public static unsafe void GetAllocationInfo2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<AllocationInfo2> pAllocationInfo)
        {
            // SpanOverloader
            thisApi.GetAllocationInfo2(allocator, allocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_vma.h")]
        public static unsafe void SetAllocationUserData<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<T0> pUserData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetAllocationUserData(allocator, allocation, ref pUserData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_vma.h")]
        public static unsafe void SetAllocationName(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            thisApi.SetAllocationName(allocator, allocation, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_vma.h")]
        public static unsafe void GetAllocationMemoryProperties(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<uint> pFlags)
        {
            // SpanOverloader
            thisApi.GetAllocationMemoryProperties(allocator, allocation, ref pFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, AllocationT** allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, AllocatorT* allocator, uint allocationCount, ref AllocationT* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CopyMemoryToAllocation<T0>(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcHostPointer, AllocationT* dstAllocation, ulong dstAllocationLocalOffset, ulong size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CopyMemoryToAllocation(allocator, in pSrcHostPointer.GetPinnableReference(), dstAllocation, dstAllocationLocalOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CopyAllocationToMemory<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* srcAllocation, ulong srcAllocationLocalOffset, Span<T0> pDstHostPointer, ulong size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CopyAllocationToMemory(allocator, srcAllocation, srcAllocationLocalOffset, ref pDstHostPointer.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentation(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DefragmentationInfo> pInfo, DefragmentationContextT** pContext)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentation(allocator, in pInfo.GetPinnableReference(), pContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentation(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DefragmentationInfo> pInfo, ref DefragmentationContextT* pContext)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentation(allocator, in pInfo.GetPinnableReference(), ref pContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_vma.h")]
        public static unsafe void EndDefragmentation(this Vma thisApi, AllocatorT* allocator, DefragmentationContextT* context, Span<DefragmentationStats> pStats)
        {
            // SpanOverloader
            thisApi.EndDefragmentation(allocator, context, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentationPass(this Vma thisApi, AllocatorT* allocator, DefragmentationContextT* context, Span<DefragmentationPassMoveInfo> pPassInfo)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentationPass(allocator, context, ref pPassInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result EndDefragmentationPass(this Vma thisApi, AllocatorT* allocator, DefragmentationContextT* context, Span<DefragmentationPassMoveInfo> pPassInfo)
        {
            // SpanOverloader
            return thisApi.EndDefragmentationPass(allocator, context, ref pPassInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2422, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindBufferMemory(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<Silk.NET.Vulkan.Buffer> buffer)
        {
            // SpanOverloader
            return thisApi.BindBufferMemory(allocator, allocation, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindBufferMemory2<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Buffer* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(allocator, allocation, allocationLocalOffset, buffer, in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindBufferMemory2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext)
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(allocator, allocation, allocationLocalOffset, ref buffer.GetPinnableReference(), pNext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindBufferMemory2<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Span<Silk.NET.Vulkan.Buffer> buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(allocator, allocation, allocationLocalOffset, ref buffer.GetPinnableReference(), in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2459, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindImageMemory(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, Span<Silk.NET.Vulkan.Image> image)
        {
            // SpanOverloader
            return thisApi.BindImageMemory(allocator, allocation, ref image.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindImageMemory2<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Image* image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(allocator, allocation, allocationLocalOffset, image, in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindImageMemory2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pNext)
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(allocator, allocation, allocationLocalOffset, ref image.GetPinnableReference(), pNext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result BindImageMemory2<T0>(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, Span<Silk.NET.Vulkan.Image> image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(allocator, allocation, allocationLocalOffset, ref image.GetPinnableReference(), in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer** pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, ref Silk.NET.Vulkan.Buffer* pBuffer, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer(allocator, allocation, in pBufferCreateInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer(allocator, allocation, in pBufferCreateInfo.GetPinnableReference(), ref pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Silk.NET.Vulkan.Buffer** pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer2(allocator, allocation, allocationLocalOffset, in pBufferCreateInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, ref Silk.NET.Vulkan.Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer2(allocator, allocation, allocationLocalOffset, in pBufferCreateInfo.GetPinnableReference(), ref pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2608, Column 33 in vk_vma.h")]
        public static unsafe void DestroyBuffer(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Buffer> buffer, AllocationT* allocation)
        {
            // SpanOverloader
            thisApi.DestroyBuffer(allocator, ref buffer.GetPinnableReference(), allocation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image** pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, AllocationT** pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage, ref pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, AllocatorT* allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ref Silk.NET.Vulkan.Image* pImage, ref AllocationT* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage, ref pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Silk.NET.Vulkan.Image** pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage(allocator, allocation, in pImageCreateInfo.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, ref Silk.NET.Vulkan.Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage(allocator, allocation, in pImageCreateInfo.GetPinnableReference(), ref pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Silk.NET.Vulkan.Image** pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage2(allocator, allocation, allocationLocalOffset, in pImageCreateInfo.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage2(this Vma thisApi, AllocatorT* allocator, AllocationT* allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, ref Silk.NET.Vulkan.Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage2(allocator, allocation, allocationLocalOffset, in pImageCreateInfo.GetPinnableReference(), ref pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2648, Column 33 in vk_vma.h")]
        public static unsafe void DestroyImage(this Vma thisApi, AllocatorT* allocator, Span<Silk.NET.Vulkan.Image> image, AllocationT* allocation)
        {
            // SpanOverloader
            thisApi.DestroyImage(allocator, ref image.GetPinnableReference(), allocation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateVirtualBlock(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualBlockCreateInfo> pCreateInfo, VirtualBlockT** pVirtualBlock)
        {
            // SpanOverloader
            return thisApi.CreateVirtualBlock(in pCreateInfo.GetPinnableReference(), pVirtualBlock);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateVirtualBlock(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualBlockCreateInfo> pCreateInfo, ref VirtualBlockT* pVirtualBlock)
        {
            // SpanOverloader
            return thisApi.CreateVirtualBlock(in pCreateInfo.GetPinnableReference(), ref pVirtualBlock);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_vma.h")]
        public static unsafe void GetVirtualAllocationInfo(this Vma thisApi, VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, Span<VirtualAllocationInfo> pVirtualAllocInfo)
        {
            // SpanOverloader
            thisApi.GetVirtualAllocationInfo(virtualBlock, allocation, ref pVirtualAllocInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, VirtualAllocationT** pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, pCreateInfo, pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, ref VirtualAllocationT* pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, pCreateInfo, ref pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, VirtualAllocationT** pAllocation, ulong* pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), pAllocation, pOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, VirtualAllocationT** pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, ref VirtualAllocationT* pAllocation, ulong* pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), ref pAllocation, pOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_vma.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, VirtualBlockT* virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, ref VirtualAllocationT* pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), ref pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_vma.h")]
        public static unsafe void SetVirtualAllocationUserData<T0>(this Vma thisApi, VirtualBlockT* virtualBlock, VirtualAllocationT* allocation, Span<T0> pUserData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetVirtualAllocationUserData(virtualBlock, allocation, ref pUserData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_vma.h")]
        public static unsafe void GetVirtualBlockStatistics(this Vma thisApi, VirtualBlockT* virtualBlock, Span<Statistics> pStats)
        {
            // SpanOverloader
            thisApi.GetVirtualBlockStatistics(virtualBlock, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_vma.h")]
        public static unsafe void CalculateVirtualBlockStatistics(this Vma thisApi, VirtualBlockT* virtualBlock, Span<DetailedStatistics> pStats)
        {
            // SpanOverloader
            thisApi.CalculateVirtualBlockStatistics(virtualBlock, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_vma.h")]
        public static unsafe void FreeVirtualBlockStatsString(this Vma thisApi, VirtualBlockT* virtualBlock, Span<byte> pStatsString)
        {
            // SpanOverloader
            thisApi.FreeVirtualBlockStatsString(virtualBlock, ref pStatsString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_vma.h")]
        public static unsafe void FreeStatsString(this Vma thisApi, AllocatorT* allocator, Span<byte> pStatsString)
        {
            // SpanOverloader
            thisApi.FreeStatsString(allocator, ref pStatsString.GetPinnableReference());
        }

    }
}

