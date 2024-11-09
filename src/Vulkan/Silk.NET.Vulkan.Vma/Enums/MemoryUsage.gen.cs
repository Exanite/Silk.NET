// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Vma
{
    [NativeName("Name", "VmaMemoryUsage")]
    public enum MemoryUsage : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_UNKNOWN")]
        MemoryUsageUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"GpuOnly\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_ONLY")]
        MemoryUsageGpuOnly = 0x1,
        [Obsolete("Deprecated in favour of \"CpuOnly\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_ONLY")]
        MemoryUsageCpuOnly = 0x2,
        [Obsolete("Deprecated in favour of \"CpuToGpu\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_TO_GPU")]
        MemoryUsageCpuToGpu = 0x3,
        [Obsolete("Deprecated in favour of \"GpuToCpu\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_TO_CPU")]
        MemoryUsageGpuToCpu = 0x4,
        [Obsolete("Deprecated in favour of \"CpuCopy\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_COPY")]
        MemoryUsageCpuCopy = 0x5,
        [Obsolete("Deprecated in favour of \"GpuLazilyAllocated\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_LAZILY_ALLOCATED")]
        MemoryUsageGpuLazilyAllocated = 0x6,
        [Obsolete("Deprecated in favour of \"Auto\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO")]
        MemoryUsageAuto = 0x7,
        [Obsolete("Deprecated in favour of \"AutoPreferDevice\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO_PREFER_DEVICE")]
        MemoryUsageAutoPreferDevice = 0x8,
        [Obsolete("Deprecated in favour of \"AutoPreferHost\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO_PREFER_HOST")]
        MemoryUsageAutoPreferHost = 0x9,
        [Obsolete("Deprecated in favour of \"MaxEnum\"")]
        [NativeName("Name", "VMA_MEMORY_USAGE_MAX_ENUM")]
        MemoryUsageMaxEnum = 0x7FFFFFFF,
        [NativeName("Name", "VMA_MEMORY_USAGE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_ONLY")]
        GpuOnly = 0x1,
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_ONLY")]
        CpuOnly = 0x2,
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_TO_GPU")]
        CpuToGpu = 0x3,
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_TO_CPU")]
        GpuToCpu = 0x4,
        [NativeName("Name", "VMA_MEMORY_USAGE_CPU_COPY")]
        CpuCopy = 0x5,
        [NativeName("Name", "VMA_MEMORY_USAGE_GPU_LAZILY_ALLOCATED")]
        GpuLazilyAllocated = 0x6,
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO")]
        Auto = 0x7,
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO_PREFER_DEVICE")]
        AutoPreferDevice = 0x8,
        [NativeName("Name", "VMA_MEMORY_USAGE_AUTO_PREFER_HOST")]
        AutoPreferHost = 0x9,
        [NativeName("Name", "VMA_MEMORY_USAGE_MAX_ENUM")]
        MaxEnum = 0x7FFFFFFF,
    }
}
