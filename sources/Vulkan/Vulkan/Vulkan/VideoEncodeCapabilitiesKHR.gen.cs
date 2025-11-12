// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeCapabilitiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeCapabilityFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeCapabilityFlagsKHR Flags;

    [NativeTypeName("VkVideoEncodeRateControlModeFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRateControlModeFlagsKHR RateControlModes;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxRateControlLayers;

    [NativeTypeName("uint64_t")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxBitrate;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxQualityLevels;

    [SupportedApiProfile("vulkan")]
    public Extent2D EncodeInputPictureGranularity;

    [NativeTypeName("VkVideoEncodeFeedbackFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeFeedbackFlagsKHR SupportedEncodeFeedbackFlags;
}
