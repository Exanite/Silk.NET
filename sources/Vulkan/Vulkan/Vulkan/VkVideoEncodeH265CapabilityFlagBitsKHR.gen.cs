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
public enum VideoEncodeH265CapabilityFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    HrdComplianceBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    PredictionWeightTableGeneratedBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    RowUnalignedSliceSegmentBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    DifferentSliceSegmentTypeBitKHR = 0x00000008,

    [SupportedApiProfile("vulkan")]
    BFrameInL0ListBitKHR = 0x00000010,

    [SupportedApiProfile("vulkan")]
    BFrameInL1ListBitKHR = 0x00000020,

    [SupportedApiProfile("vulkan")]
    PerPictureTypeMinMaxQpBitKHR = 0x00000040,

    [SupportedApiProfile("vulkan")]
    PerSliceSegmentConstantQpBitKHR = 0x00000080,

    [SupportedApiProfile("vulkan")]
    MultipleTilesPerSliceSegmentBitKHR = 0x00000100,

    [SupportedApiProfile("vulkan")]
    MultipleSliceSegmentsPerTileBitKHR = 0x00000200,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_intra_refresh"],
        ImpliesSets = ["VK_KHR_video_encode_queue"],
        RequireAll = true
    )]
    BPictureIntraRefreshBitKHR = 0x00000800,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_encode_h265", "VK_KHR_video_encode_quantization_map"],
        ImpliesSets = [
            "VK_KHR_video_encode_queue+VK_KHR_format_feature_flags2",
            "VK_KHR_video_encode_queue+VK_VERSION_1_3",
        ],
        RequireAll = true
    )]
    CuQpDiffWraparoundBitKHR = 0x00000400,
}
