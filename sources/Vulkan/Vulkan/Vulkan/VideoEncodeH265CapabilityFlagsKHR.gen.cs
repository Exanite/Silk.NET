// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeH265CapabilityFlagsKHR : uint
{
    None = 0x0,
    HrdComplianceBit = 0x1,
    PredictionWeightTableGeneratedBit = 0x2,
    RowUnalignedSliceSegmentBit = 0x4,
    DifferentSliceSegmentTypeBit = 0x8,
    BFrameInL0ListBit = 0x10,
    BFrameInL1ListBit = 0x20,
    PerPictureTypeMinMaxQpBit = 0x40,
    PerSliceSegmentConstantQpBit = 0x80,
    MultipleTilesPerSliceSegmentBit = 0x100,
    MultipleSliceSegmentsPerTileBit = 0x200,
    BPictureIntraRefreshBit = 0x800,
    CuQpDiffWraparoundBit = 0x400,
}
