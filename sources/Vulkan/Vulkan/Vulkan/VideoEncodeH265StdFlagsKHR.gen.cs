// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeH265StdFlagsKHR : uint
{
    None = 0x0,
    SeparateColorPlaneFlagSetBit = 0x1,
    SampleAdaptiveOffsetEnabledFlagSetBit = 0x2,
    ScalingListDataPresentFlagSetBit = 0x4,
    PcmEnabledFlagSetBit = 0x8,
    SpsTemporalMvpEnabledFlagSetBit = 0x10,
    InitQpMinus26Bit = 0x20,
    WeightedPredFlagSetBit = 0x40,
    WeightedBipredFlagSetBit = 0x80,
    Log2ParallelMergeLevelMinus2Bit = 0x100,
    SignDataHidingEnabledFlagSetBit = 0x200,
    TransformSkipEnabledFlagSetBit = 0x400,
    TransformSkipEnabledFlagUnsetBit = 0x800,
    PpsSliceChromaQpOffsetsPresentFlagSetBit = 0x1000,
    TransquantBypassEnabledFlagSetBit = 0x2000,
    ConstrainedIntraPredFlagSetBit = 0x4000,
    EntropyCodingSyncEnabledFlagSetBit = 0x8000,
    DeblockingFilterOverrideEnabledFlagSetBit = 0x10000,
    DependentSliceSegmentsEnabledFlagSetBit = 0x20000,
    DependentSliceSegmentFlagSetBit = 0x40000,
    SliceQpDeltaBit = 0x80000,
    DifferentSliceQpDeltaBit = 0x100000,
}
