// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineDepthStencilStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineDepthStencilStateCreateFlags")]
    public PipelineDepthStencilStateCreateFlags Flags;

    [NativeTypeName("VkBool32")]
    public uint DepthTestEnable;

    [NativeTypeName("VkBool32")]
    public uint DepthWriteEnable;
    public CompareOp DepthCompareOp;

    [NativeTypeName("VkBool32")]
    public uint DepthBoundsTestEnable;

    [NativeTypeName("VkBool32")]
    public uint StencilTestEnable;
    public StencilOpState Front;
    public StencilOpState Back;
    public float MinDepthBounds;
    public float MaxDepthBounds;
}
