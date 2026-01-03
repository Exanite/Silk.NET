// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeCapabilitiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkVideoEncodeCapabilityFlagsKHR")]
    public VideoEncodeCapabilityFlagsKHR Flags;

    [NativeTypeName("VkVideoEncodeRateControlModeFlagsKHR")]
    public VideoEncodeRateControlModeFlagsKHR RateControlModes;

    [NativeTypeName("uint32_t")]
    public uint MaxRateControlLayers;

    [NativeTypeName("uint64_t")]
    public ulong MaxBitrate;

    [NativeTypeName("uint32_t")]
    public uint MaxQualityLevels;
    public Extent2D EncodeInputPictureGranularity;

    [NativeTypeName("VkVideoEncodeFeedbackFlagsKHR")]
    public VideoEncodeFeedbackFlagsKHR SupportedEncodeFeedbackFlags;
}
