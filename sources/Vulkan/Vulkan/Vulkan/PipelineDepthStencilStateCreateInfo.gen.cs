// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineDepthStencilStateCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineDepthStencilStateCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public PipelineDepthStencilStateCreateFlags Flags;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DepthTestEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DepthWriteEnable;

    [SupportedApiProfile("vulkan")]
    public CompareOp DepthCompareOp;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DepthBoundsTestEnable;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> StencilTestEnable;

    [SupportedApiProfile("vulkan")]
    public StencilOpState Front;

    [SupportedApiProfile("vulkan")]
    public StencilOpState Back;

    [SupportedApiProfile("vulkan")]
    public float MinDepthBounds;

    [SupportedApiProfile("vulkan")]
    public float MaxDepthBounds;
}
