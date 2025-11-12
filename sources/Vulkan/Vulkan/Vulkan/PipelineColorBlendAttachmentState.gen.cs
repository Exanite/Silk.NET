// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct PipelineColorBlendAttachmentState
{
    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> BlendEnable;

    [SupportedApiProfile("vulkan")]
    public BlendFactor SrcColorBlendFactor;

    [SupportedApiProfile("vulkan")]
    public BlendFactor DstColorBlendFactor;

    [SupportedApiProfile("vulkan")]
    public BlendOp ColorBlendOp;

    [SupportedApiProfile("vulkan")]
    public BlendFactor SrcAlphaBlendFactor;

    [SupportedApiProfile("vulkan")]
    public BlendFactor DstAlphaBlendFactor;

    [SupportedApiProfile("vulkan")]
    public BlendOp AlphaBlendOp;

    [NativeTypeName("VkColorComponentFlags")]
    [SupportedApiProfile("vulkan")]
    public ColorComponentFlags ColorWriteMask;
}
