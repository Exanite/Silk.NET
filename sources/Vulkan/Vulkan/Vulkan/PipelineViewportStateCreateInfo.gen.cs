// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineViewportStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineViewportStateCreateFlags")]
    public uint Flags;

    [NativeTypeName("uint32_t")]
    public uint ViewportCount;

    [NativeTypeName("const VkViewport *")]
    public Viewport* PViewports;

    [NativeTypeName("uint32_t")]
    public uint ScissorCount;

    [NativeTypeName("const VkRect2D *")]
    public Rect2D* PScissors;
}
