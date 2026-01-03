// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct OpticalFlowSessionCreateInfoNV
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint Width;

    [NativeTypeName("uint32_t")]
    public uint Height;
    public Format ImageFormat;
    public Format FlowVectorFormat;
    public Format CostFormat;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public OpticalFlowGridSizeFlagsNV OutputGridSize;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public OpticalFlowGridSizeFlagsNV HintGridSize;
    public OpticalFlowPerformanceLevelNV PerformanceLevel;

    [NativeTypeName("VkOpticalFlowSessionCreateFlagsNV")]
    public OpticalFlowSessionCreateFlagsNV Flags;
}
