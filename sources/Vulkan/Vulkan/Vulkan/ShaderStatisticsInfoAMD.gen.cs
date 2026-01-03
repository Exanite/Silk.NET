// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct ShaderStatisticsInfoAMD
{
    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags ShaderStageMask;
    public ShaderResourceUsageAMD ResourceUsage;

    [NativeTypeName("uint32_t")]
    public uint NumPhysicalVgprs;

    [NativeTypeName("uint32_t")]
    public uint NumPhysicalSgprs;

    [NativeTypeName("uint32_t")]
    public uint NumAvailableVgprs;

    [NativeTypeName("uint32_t")]
    public uint NumAvailableSgprs;

    [NativeTypeName("uint32_t[3]")]
    public ShaderStatisticsInfoAMDComputeWorkGroupSize ComputeWorkGroupSize;
}
