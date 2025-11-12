// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineViewportStateCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPipelineViewportStateCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ViewportCount;

    [NativeTypeName("const VkViewport *")]
    [SupportedApiProfile("vulkan")]
    public Viewport* PViewports;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ScissorCount;

    [NativeTypeName("const VkRect2D *")]
    [SupportedApiProfile("vulkan")]
    public Rect2D* PScissors;
}
