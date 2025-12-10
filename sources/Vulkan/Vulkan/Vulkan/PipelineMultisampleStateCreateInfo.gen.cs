// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineMultisampleStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineMultisampleStateCreateFlags")]
    public uint Flags;
    public SampleCountFlags RasterizationSamples;

    [NativeTypeName("VkBool32")]
    public uint SampleShadingEnable;
    public float MinSampleShading;

    [NativeTypeName("const VkSampleMask *")]
    public uint* PSampleMask;

    [NativeTypeName("VkBool32")]
    public uint AlphaToCoverageEnable;

    [NativeTypeName("VkBool32")]
    public uint AlphaToOneEnable;
}
