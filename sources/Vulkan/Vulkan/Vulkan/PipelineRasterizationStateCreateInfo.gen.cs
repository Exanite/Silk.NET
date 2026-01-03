// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineRasterizationStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineRasterizationStateCreateFlags")]
    public uint Flags;

    [NativeTypeName("VkBool32")]
    public uint DepthClampEnable;

    [NativeTypeName("VkBool32")]
    public uint RasterizerDiscardEnable;
    public PolygonMode PolygonMode;

    [NativeTypeName("VkCullModeFlags")]
    public CullModeFlags CullMode;
    public FrontFace FrontFace;

    [NativeTypeName("VkBool32")]
    public uint DepthBiasEnable;
    public float DepthBiasConstantFactor;
    public float DepthBiasClamp;
    public float DepthBiasSlopeFactor;
    public float LineWidth;
}
