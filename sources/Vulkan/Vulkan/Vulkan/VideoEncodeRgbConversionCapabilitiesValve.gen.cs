// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeRgbConversionCapabilitiesValve
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeRgbModelConversionFlagsVALVE")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbModelConversionFlagsValve RgbModels;

    [NativeTypeName("VkVideoEncodeRgbRangeCompressionFlagsVALVE")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbRangeCompressionFlagsValve RgbRanges;

    [NativeTypeName("VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbChromaOffsetFlagsValve XChromaOffsets;

    [NativeTypeName("VkVideoEncodeRgbChromaOffsetFlagsVALVE")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbChromaOffsetFlagsValve YChromaOffsets;
}
