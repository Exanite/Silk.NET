// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum VideoEncodeH265StdFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    SeparateColorPlaneFlagSetBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    SampleAdaptiveOffsetEnabledFlagSetBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    ScalingListDataPresentFlagSetBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    PcmEnabledFlagSetBitKHR = 0x00000008,

    [SupportedApiProfile("vulkan")]
    SpsTemporalMvpEnabledFlagSetBitKHR = 0x00000010,

    [SupportedApiProfile("vulkan")]
    InitQpMinus26BitKHR = 0x00000020,

    [SupportedApiProfile("vulkan")]
    WeightedPredFlagSetBitKHR = 0x00000040,

    [SupportedApiProfile("vulkan")]
    WeightedBipredFlagSetBitKHR = 0x00000080,

    [SupportedApiProfile("vulkan")]
    Log2ParallelMergeLevelMinus2BitKHR = 0x00000100,

    [SupportedApiProfile("vulkan")]
    SignDataHidingEnabledFlagSetBitKHR = 0x00000200,

    [SupportedApiProfile("vulkan")]
    TransformSkipEnabledFlagSetBitKHR = 0x00000400,

    [SupportedApiProfile("vulkan")]
    TransformSkipEnabledFlagUnsetBitKHR = 0x00000800,

    [SupportedApiProfile("vulkan")]
    PpsSliceChromaQpOffsetsPresentFlagSetBitKHR = 0x00001000,

    [SupportedApiProfile("vulkan")]
    TransquantBypassEnabledFlagSetBitKHR = 0x00002000,

    [SupportedApiProfile("vulkan")]
    ConstrainedIntraPredFlagSetBitKHR = 0x00004000,

    [SupportedApiProfile("vulkan")]
    EntropyCodingSyncEnabledFlagSetBitKHR = 0x00008000,

    [SupportedApiProfile("vulkan")]
    DeblockingFilterOverrideEnabledFlagSetBitKHR = 0x00010000,

    [SupportedApiProfile("vulkan")]
    DependentSliceSegmentsEnabledFlagSetBitKHR = 0x00020000,

    [SupportedApiProfile("vulkan")]
    DependentSliceSegmentFlagSetBitKHR = 0x00040000,

    [SupportedApiProfile("vulkan")]
    SliceQpDeltaBitKHR = 0x00080000,

    [SupportedApiProfile("vulkan")]
    DifferentSliceQpDeltaBitKHR = 0x00100000,
}
