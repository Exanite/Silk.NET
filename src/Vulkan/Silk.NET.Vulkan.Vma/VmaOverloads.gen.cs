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
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAllocator(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocatorCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocator> pAllocator)
        {
            // SpanOverloader
            return thisApi.CreateAllocator(pCreateInfo, ref pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAllocator(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocatorCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocator* pAllocator)
        {
            // SpanOverloader
            return thisApi.CreateAllocator(in pCreateInfo.GetPinnableReference(), pAllocator);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1671, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAllocator(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocatorCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocator> pAllocator)
        {
            // SpanOverloader
            return thisApi.CreateAllocator(in pCreateInfo.GetPinnableReference(), ref pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1684, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetAllocatorInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Span<AllocatorInfo> pAllocatorInfo)
        {
            // SpanOverloader
            thisApi.GetAllocatorInfo(allocator, ref pAllocatorInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1710, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetMemoryTypeProperties(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeIndex, Span<uint> pFlags)
        {
            // SpanOverloader
            thisApi.GetMemoryTypeProperties(allocator, memoryTypeIndex, ref pFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1738, Column 33 in vk_mem_alloc.h")]
        public static unsafe void CalculateStatistics(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Span<TotalStatistics> pStats)
        {
            // SpanOverloader
            thisApi.CalculateStatistics(allocator, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1753, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetHeapBudgets(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Span<Budget> pBudgets)
        {
            // SpanOverloader
            thisApi.GetHeapBudgets(allocator, ref pBudgets.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1780, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndex(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint memoryTypeBits, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndex(allocator, memoryTypeBits, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1792, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForBufferInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForBufferInfo(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, uint* pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pMemoryTypeIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1804, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FindMemoryTypeIndexForImageInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<uint> pMemoryTypeIndex)
        {
            // SpanOverloader
            return thisApi.FindMemoryTypeIndexForImageInfo(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pMemoryTypeIndex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreatePool(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PoolCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Pool> pPool)
        {
            // SpanOverloader
            return thisApi.CreatePool(allocator, pCreateInfo, ref pPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreatePool(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PoolCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Pool* pPool)
        {
            // SpanOverloader
            return thisApi.CreatePool(allocator, in pCreateInfo.GetPinnableReference(), pPool);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1816, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreatePool(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PoolCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Pool> pPool)
        {
            // SpanOverloader
            return thisApi.CreatePool(allocator, in pCreateInfo.GetPinnableReference(), ref pPool.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1843, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetPoolStatistics(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, Span<Statistics> pPoolStats)
        {
            // SpanOverloader
            thisApi.GetPoolStatistics(allocator, pool, ref pPoolStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1854, Column 33 in vk_mem_alloc.h")]
        public static unsafe void CalculatePoolStatistics(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, Span<DetailedStatistics> pPoolStats)
        {
            // SpanOverloader
            thisApi.CalculatePoolStatistics(allocator, pool, ref pPoolStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1900, Column 33 in vk_mem_alloc.h")]
        public static unsafe void SetPoolName(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Pool pool, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            thisApi.SetPoolName(allocator, pool, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, pCreateInfo, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, pCreateInfo, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1918, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemory(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemory(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, pCreateInfo, allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, pCreateInfo, allocationCount, ref pAllocations.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, pCreateInfo, allocationCount, ref pAllocations.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.MemoryRequirements* pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, pVkMemoryRequirements, in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, ref pAllocations.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), pCreateInfo, allocationCount, ref pAllocations.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Silk.NET.Vulkan.Vma.Allocation* pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, pAllocations, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1944, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.MemoryRequirements> pVkMemoryRequirements, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryPages(allocator, in pVkMemoryRequirements.GetPinnableReference(), in pCreateInfo.GetPinnableReference(), allocationCount, ref pAllocations.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, pCreateInfo, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, pCreateInfo, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1966, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForBuffer(allocator, buffer, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, pCreateInfo, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, pCreateInfo, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, pCreateInfo, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1987, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result AllocateMemoryForImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.AllocateMemoryForImage(allocator, image, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2012, Column 33 in vk_mem_alloc.h")]
        public static unsafe void FreeMemoryPages(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, nuint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocations)
        {
            // SpanOverloader
            thisApi.FreeMemoryPages(allocator, allocationCount, ref pAllocations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2030, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetAllocationInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            thisApi.GetAllocationInfo(allocator, allocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2042, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetAllocationInfo2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Span<AllocationInfo2> pAllocationInfo)
        {
            // SpanOverloader
            thisApi.GetAllocationInfo2(allocator, allocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2053, Column 33 in vk_mem_alloc.h")]
        public static unsafe void SetAllocationUserData<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Span<T0> pUserData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetAllocationUserData(allocator, allocation, ref pUserData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2066, Column 33 in vk_mem_alloc.h")]
        public static unsafe void SetAllocationName(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pName)
        {
            // SpanOverloader
            thisApi.SetAllocationName(allocator, allocation, in pName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2077, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetAllocationMemoryProperties(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, Span<uint> pFlags)
        {
            // SpanOverloader
            thisApi.GetAllocationMemoryProperties(allocator, allocation, ref pFlags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), offsets, sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2238, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result FlushAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.FlushAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Silk.NET.Vulkan.Vma.Allocation* allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, allocations, in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), offsets, sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), offsets, in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), in offsets.GetPinnableReference(), sizes);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2259, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result InvalidateAllocations(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, uint allocationCount, Span<Silk.NET.Vulkan.Vma.Allocation> allocations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> offsets, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> sizes)
        {
            // SpanOverloader
            return thisApi.InvalidateAllocations(allocator, allocationCount, ref allocations.GetPinnableReference(), in offsets.GetPinnableReference(), in sizes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2286, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CopyMemoryToAllocation<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pSrcHostPointer, Silk.NET.Vulkan.Vma.Allocation dstAllocation, ulong dstAllocationLocalOffset, ulong size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CopyMemoryToAllocation(allocator, in pSrcHostPointer.GetPinnableReference(), dstAllocation, dstAllocationLocalOffset, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2314, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CopyAllocationToMemory<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation srcAllocation, ulong srcAllocationLocalOffset, Span<T0> pDstHostPointer, ulong size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CopyAllocationToMemory(allocator, srcAllocation, srcAllocationLocalOffset, ref pDstHostPointer.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentation(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DefragmentationInfo* pInfo, Span<Silk.NET.Vulkan.Vma.DefragmentationContext> pContext)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentation(allocator, pInfo, ref pContext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentation(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DefragmentationInfo> pInfo, Silk.NET.Vulkan.Vma.DefragmentationContext* pContext)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentation(allocator, in pInfo.GetPinnableReference(), pContext);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2354, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentation(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DefragmentationInfo> pInfo, Span<Silk.NET.Vulkan.Vma.DefragmentationContext> pContext)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentation(allocator, in pInfo.GetPinnableReference(), ref pContext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2367, Column 33 in vk_mem_alloc.h")]
        public static unsafe void EndDefragmentation(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, Span<DefragmentationStats> pStats)
        {
            // SpanOverloader
            thisApi.EndDefragmentation(allocator, context, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2382, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BeginDefragmentationPass(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, Span<DefragmentationPassMoveInfo> pPassInfo)
        {
            // SpanOverloader
            return thisApi.BeginDefragmentationPass(allocator, context, ref pPassInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2405, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result EndDefragmentationPass(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.DefragmentationContext context, Span<DefragmentationPassMoveInfo> pPassInfo)
        {
            // SpanOverloader
            return thisApi.EndDefragmentationPass(allocator, context, ref pPassInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2440, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BindBufferMemory2<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Buffer buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindBufferMemory2(allocator, allocation, allocationLocalOffset, buffer, in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2477, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result BindImageMemory2<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, Silk.NET.Vulkan.Image image, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> pNext) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BindImageMemory2(allocator, allocation, allocationLocalOffset, image, in pNext.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2518, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBuffer(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, pBufferCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), pAllocationCreateInfo, minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Silk.NET.Vulkan.Buffer* pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, pBuffer, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2532, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateBufferWithAlignment(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, ulong minAlignment, Span<Silk.NET.Vulkan.Buffer> pBuffer, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithAlignment(allocator, in pBufferCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), minAlignment, ref pBuffer.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer(allocator, allocation, pBufferCreateInfo, ref pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer(allocator, allocation, in pBufferCreateInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2562, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer(allocator, allocation, in pBufferCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.BufferCreateInfo* pBufferCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer2(allocator, allocation, allocationLocalOffset, pBufferCreateInfo, ref pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Silk.NET.Vulkan.Buffer* pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer2(allocator, allocation, allocationLocalOffset, in pBufferCreateInfo.GetPinnableReference(), pBuffer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2590, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingBuffer2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.BufferCreateInfo> pBufferCreateInfo, Span<Silk.NET.Vulkan.Buffer> pBuffer)
        {
            // SpanOverloader
            return thisApi.CreateAliasingBuffer2(allocator, allocation, allocationLocalOffset, in pBufferCreateInfo.GetPinnableReference(), ref pBuffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, pImage, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, pImage, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, pAllocationCreateInfo, ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, pImageCreateInfo, in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, pImage, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCreateInfo* pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), pAllocationCreateInfo, ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Silk.NET.Vulkan.Image* pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), pImage, ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), pAllocation, pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Silk.NET.Vulkan.Vma.Allocation* pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), pAllocation, ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, AllocationInfo* pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pAllocationInfo);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCreateInfo> pAllocationCreateInfo, Span<Silk.NET.Vulkan.Image> pImage, Span<Silk.NET.Vulkan.Vma.Allocation> pAllocation, Span<AllocationInfo> pAllocationInfo)
        {
            // SpanOverloader
            return thisApi.CreateImage(allocator, in pImageCreateInfo.GetPinnableReference(), in pAllocationCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pAllocationInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, Span<Silk.NET.Vulkan.Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage(allocator, allocation, pImageCreateInfo, ref pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Silk.NET.Vulkan.Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage(allocator, allocation, in pImageCreateInfo.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2623, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Span<Silk.NET.Vulkan.Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage(allocator, allocation, in pImageCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Vulkan.ImageCreateInfo* pImageCreateInfo, Span<Silk.NET.Vulkan.Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage2(allocator, allocation, allocationLocalOffset, pImageCreateInfo, ref pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Silk.NET.Vulkan.Image* pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage2(allocator, allocation, allocationLocalOffset, in pImageCreateInfo.GetPinnableReference(), pImage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2630, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateAliasingImage2(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Silk.NET.Vulkan.Vma.Allocation allocation, ulong allocationLocalOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Vulkan.ImageCreateInfo> pImageCreateInfo, Span<Silk.NET.Vulkan.Image> pImage)
        {
            // SpanOverloader
            return thisApi.CreateAliasingImage2(allocator, allocation, allocationLocalOffset, in pImageCreateInfo.GetPinnableReference(), ref pImage.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateVirtualBlock(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualBlockCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualBlock> pVirtualBlock)
        {
            // SpanOverloader
            return thisApi.CreateVirtualBlock(pCreateInfo, ref pVirtualBlock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateVirtualBlock(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualBlockCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.VirtualBlock* pVirtualBlock)
        {
            // SpanOverloader
            return thisApi.CreateVirtualBlock(in pCreateInfo.GetPinnableReference(), pVirtualBlock);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2665, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result CreateVirtualBlock(this Vma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualBlockCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualBlock> pVirtualBlock)
        {
            // SpanOverloader
            return thisApi.CreateVirtualBlock(in pCreateInfo.GetPinnableReference(), ref pVirtualBlock.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2688, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetVirtualAllocationInfo(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, Span<VirtualAllocationInfo> pVirtualAllocInfo)
        {
            // SpanOverloader
            thisApi.GetVirtualAllocationInfo(virtualBlock, allocation, ref pVirtualAllocInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, pCreateInfo, pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualAllocation> pAllocation, ulong* pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, pCreateInfo, ref pAllocation.GetPinnableReference(), pOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VirtualAllocationCreateInfo* pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualAllocation> pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, pCreateInfo, ref pAllocation.GetPinnableReference(), ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, ulong* pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), pAllocation, pOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, Silk.NET.Vulkan.Vma.VirtualAllocation* pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), pAllocation, ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualAllocation> pAllocation, ulong* pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), pOffset);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2703, Column 37 in vk_mem_alloc.h")]
        public static unsafe Silk.NET.Vulkan.Result VirtualAllocate(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VirtualAllocationCreateInfo> pCreateInfo, Span<Silk.NET.Vulkan.Vma.VirtualAllocation> pAllocation, Span<ulong> pOffset)
        {
            // SpanOverloader
            return thisApi.VirtualAllocate(virtualBlock, in pCreateInfo.GetPinnableReference(), ref pAllocation.GetPinnableReference(), ref pOffset.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2730, Column 33 in vk_mem_alloc.h")]
        public static unsafe void SetVirtualAllocationUserData<T0>(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Silk.NET.Vulkan.Vma.VirtualAllocation allocation, Span<T0> pUserData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SetVirtualAllocationUserData(virtualBlock, allocation, ref pUserData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2739, Column 33 in vk_mem_alloc.h")]
        public static unsafe void GetVirtualBlockStatistics(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Span<Statistics> pStats)
        {
            // SpanOverloader
            thisApi.GetVirtualBlockStatistics(virtualBlock, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2748, Column 33 in vk_mem_alloc.h")]
        public static unsafe void CalculateVirtualBlockStatistics(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Span<DetailedStatistics> pStats)
        {
            // SpanOverloader
            thisApi.CalculateVirtualBlockStatistics(virtualBlock, ref pStats.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2773, Column 33 in vk_mem_alloc.h")]
        public static unsafe void FreeVirtualBlockStatsString(this Vma thisApi, Silk.NET.Vulkan.Vma.VirtualBlock virtualBlock, Span<byte> pStatsString)
        {
            // SpanOverloader
            thisApi.FreeVirtualBlockStatsString(virtualBlock, ref pStatsString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2787, Column 33 in vk_mem_alloc.h")]
        public static unsafe void FreeStatsString(this Vma thisApi, Silk.NET.Vulkan.Vma.Allocator allocator, Span<byte> pStatsString)
        {
            // SpanOverloader
            thisApi.FreeStatsString(allocator, ref pStatsString.GetPinnableReference());
        }

    }
}

