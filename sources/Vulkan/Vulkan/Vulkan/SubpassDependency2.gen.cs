// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct SubpassDependency2
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint SrcSubpass;

    [NativeTypeName("uint32_t")]
    public uint DstSubpass;

    [NativeTypeName("VkPipelineStageFlags")]
    public PipelineStageFlags SrcStageMask;

    [NativeTypeName("VkPipelineStageFlags")]
    public PipelineStageFlags DstStageMask;

    [NativeTypeName("VkAccessFlags")]
    public AccessFlags SrcAccessMask;

    [NativeTypeName("VkAccessFlags")]
    public AccessFlags DstAccessMask;

    [NativeTypeName("VkDependencyFlags")]
    public DependencyFlags DependencyFlags;

    [NativeTypeName("int32_t")]
    public int ViewOffset;
}
