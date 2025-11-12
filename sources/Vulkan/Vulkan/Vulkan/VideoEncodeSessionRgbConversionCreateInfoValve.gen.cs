// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeSessionRgbConversionCreateInfoValve
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbModelConversionFlagsValve RgbModel;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbRangeCompressionFlagsValve RgbRange;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbChromaOffsetFlagsValve XChromaOffset;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeRgbChromaOffsetFlagsValve YChromaOffset;
}
