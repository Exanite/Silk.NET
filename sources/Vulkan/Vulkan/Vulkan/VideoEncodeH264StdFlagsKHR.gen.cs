// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeH264StdFlagsKHR : uint
{
    None = 0x0,
    SeparateColorPlaneFlagSetBit = 0x1,
    QpprimeYZeroTransformBypassFlagSetBit = 0x2,
    ScalingMatrixPresentFlagSetBit = 0x4,
    ChromaQpIndexOffsetBit = 0x8,
    SecondChromaQpIndexOffsetBit = 0x10,
    PicInitQpMinus26Bit = 0x20,
    WeightedPredFlagSetBit = 0x40,
    WeightedBipredIdcExplicitBit = 0x80,
    WeightedBipredIdcImplicitBit = 0x100,
    Transform8X8ModeFlagSetBit = 0x200,
    DirectSpatialMvPredFlagUnsetBit = 0x400,
    EntropyCodingModeFlagUnsetBit = 0x800,
    EntropyCodingModeFlagSetBit = 0x1000,
    Direct8X8InferenceFlagUnsetBit = 0x2000,
    ConstrainedIntraPredFlagSetBit = 0x4000,
    DeblockingFilterDisabledBit = 0x8000,
    DeblockingFilterEnabledBit = 0x10000,
    DeblockingFilterPartialBit = 0x20000,
    SliceQpDeltaBit = 0x80000,
    DifferentSliceQpDeltaBit = 0x100000,
}
