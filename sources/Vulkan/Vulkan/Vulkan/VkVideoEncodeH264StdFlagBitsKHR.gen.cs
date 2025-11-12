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
public enum VideoEncodeH264StdFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    SeparateColorPlaneFlagSetBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    QpprimeYZeroTransformBypassFlagSetBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    ScalingMatrixPresentFlagSetBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    ChromaQpIndexOffsetBitKHR = 0x00000008,

    [SupportedApiProfile("vulkan")]
    SecondChromaQpIndexOffsetBitKHR = 0x00000010,

    [SupportedApiProfile("vulkan")]
    PicInitQpMinus26BitKHR = 0x00000020,

    [SupportedApiProfile("vulkan")]
    WeightedPredFlagSetBitKHR = 0x00000040,

    [SupportedApiProfile("vulkan")]
    WeightedBipredIdcExplicitBitKHR = 0x00000080,

    [SupportedApiProfile("vulkan")]
    WeightedBipredIdcImplicitBitKHR = 0x00000100,

    [SupportedApiProfile("vulkan")]
    Transform8X8ModeFlagSetBitKHR = 0x00000200,

    [SupportedApiProfile("vulkan")]
    DirectSpatialMvPredFlagUnsetBitKHR = 0x00000400,

    [SupportedApiProfile("vulkan")]
    EntropyCodingModeFlagUnsetBitKHR = 0x00000800,

    [SupportedApiProfile("vulkan")]
    EntropyCodingModeFlagSetBitKHR = 0x00001000,

    [SupportedApiProfile("vulkan")]
    Direct8X8InferenceFlagUnsetBitKHR = 0x00002000,

    [SupportedApiProfile("vulkan")]
    ConstrainedIntraPredFlagSetBitKHR = 0x00004000,

    [SupportedApiProfile("vulkan")]
    DeblockingFilterDisabledBitKHR = 0x00008000,

    [SupportedApiProfile("vulkan")]
    DeblockingFilterEnabledBitKHR = 0x00010000,

    [SupportedApiProfile("vulkan")]
    DeblockingFilterPartialBitKHR = 0x00020000,

    [SupportedApiProfile("vulkan")]
    SliceQpDeltaBitKHR = 0x00080000,

    [SupportedApiProfile("vulkan")]
    DifferentSliceQpDeltaBitKHR = 0x00100000,
}
