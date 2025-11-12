// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SubpassDescription
{
    [NativeTypeName("VkSubpassDescriptionFlags")]
    [SupportedApiProfile("vulkan")]
    public SubpassDescriptionFlags Flags;

    [SupportedApiProfile("vulkan")]
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint InputAttachmentCount;

    [NativeTypeName("const VkAttachmentReference *")]
    [SupportedApiProfile("vulkan")]
    public AttachmentReference* PInputAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ColorAttachmentCount;

    [NativeTypeName("const VkAttachmentReference *")]
    [SupportedApiProfile("vulkan")]
    public AttachmentReference* PColorAttachments;

    [NativeTypeName("const VkAttachmentReference *")]
    [SupportedApiProfile("vulkan")]
    public AttachmentReference* PResolveAttachments;

    [NativeTypeName("const VkAttachmentReference *")]
    [SupportedApiProfile("vulkan")]
    public AttachmentReference* PDepthStencilAttachment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PreserveAttachmentCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PPreserveAttachments;
}
