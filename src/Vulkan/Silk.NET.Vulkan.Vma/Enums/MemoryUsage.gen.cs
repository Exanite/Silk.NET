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
