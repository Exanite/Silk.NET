// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct RenderingInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkRenderingFlags")]
    [SupportedApiProfile("vulkan")]
    public RenderingFlags Flags;

    [SupportedApiProfile("vulkan")]
    public Rect2D RenderArea;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint LayerCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ViewMask;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ColorAttachmentCount;

    [NativeTypeName("const VkRenderingAttachmentInfo *")]
    [SupportedApiProfile("vulkan")]
    public RenderingAttachmentInfo* PColorAttachments;

    [NativeTypeName("const VkRenderingAttachmentInfo *")]
    [SupportedApiProfile("vulkan")]
    public RenderingAttachmentInfo* PDepthAttachment;

    [NativeTypeName("const VkRenderingAttachmentInfo *")]
    [SupportedApiProfile("vulkan")]
    public RenderingAttachmentInfo* PStencilAttachment;
}
