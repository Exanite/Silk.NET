// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ImageCreateFlags : uint
{
    None = 0x0,
    CreateSparseBindingBit = 0x1,
    CreateSparseResidencyBit = 0x2,
    CreateSparseAliasedBit = 0x4,
    CreateMutableFormatBit = 0x8,
    CreateCubeCompatibleBit = 0x10,
    CreateAliasBit = 0x400,
    CreateSplitInstanceBindRegionsBit = 0x40,
    Create2DArrayCompatibleBit = 0x20,
    CreateBlockTexelViewCompatibleBit = 0x80,
    CreateExtendedUsageBit = 0x100,
    CreateProtectedBit = 0x800,
    CreateDisjointBit = 0x200,
    CreateCornerSampledBitNV = 0x2000,
    CreateSampleLocationsCompatibleDepthBitEXT = 0x1000,
    CreateSubsampledBitEXT = 0x4000,
    CreateDescriptorBufferCaptureReplayBitEXT = 0x10000,
    CreateMultisampledRenderToSingleSampledBitEXT = 0x40000,
    Create2DViewCompatibleBitEXT = 0x20000,
    CreateVideoProfileIndependentBitKHR = 0x100000,
    CreateFragmentDensityMapOffsetBitEXT = 0x8000,
    CreateSplitInstanceBindRegionsBitKHR = CreateSplitInstanceBindRegionsBit,
    Create2DArrayCompatibleBitKHR = Create2DArrayCompatibleBit,
    CreateBlockTexelViewCompatibleBitKHR = CreateBlockTexelViewCompatibleBit,
    CreateExtendedUsageBitKHR = CreateExtendedUsageBit,
    CreateDisjointBitKHR = CreateDisjointBit,
    CreateAliasBitKHR = CreateAliasBit,
    CreateFragmentDensityMapOffsetBitQCOM = CreateFragmentDensityMapOffsetBitEXT,
}
