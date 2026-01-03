// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineCoverageModulationStateCreateInfoNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineCoverageModulationStateCreateFlagsNV")]
    public uint Flags;
    public CoverageModulationModeNV CoverageModulationMode;

    [NativeTypeName("VkBool32")]
    public uint CoverageModulationTableEnable;

    [NativeTypeName("uint32_t")]
    public uint CoverageModulationTableCount;

    [NativeTypeName("const float *")]
    public float* PCoverageModulationTable;
}
