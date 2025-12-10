// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineColorBlendStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkPipelineColorBlendStateCreateFlags")]
    public PipelineColorBlendStateCreateFlags Flags;

    [NativeTypeName("VkBool32")]
    public uint LogicOpEnable;
    public LogicOp LogicOp;

    [NativeTypeName("uint32_t")]
    public uint AttachmentCount;

    [NativeTypeName("const VkPipelineColorBlendAttachmentState *")]
    public PipelineColorBlendAttachmentState* PAttachments;

    [NativeTypeName("float[4]")]
    public PipelineColorBlendStateCreateInfoBlendConstants BlendConstants;
}
