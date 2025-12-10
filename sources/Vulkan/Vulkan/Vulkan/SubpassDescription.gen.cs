// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct SubpassDescription
{
    [NativeTypeName("VkSubpassDescriptionFlags")]
    public SubpassDescriptionFlags Flags;
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("uint32_t")]
    public uint InputAttachmentCount;

    [NativeTypeName("const VkAttachmentReference *")]
    public AttachmentReference* PInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint ColorAttachmentCount;

    [NativeTypeName("const VkAttachmentReference *")]
    public AttachmentReference* PColorAttachments;

    [NativeTypeName("const VkAttachmentReference *")]
    public AttachmentReference* PResolveAttachments;

    [NativeTypeName("const VkAttachmentReference *")]
    public AttachmentReference* PDepthStencilAttachment;

    [NativeTypeName("uint32_t")]
    public uint PreserveAttachmentCount;

    [NativeTypeName("const uint32_t *")]
    public uint* PPreserveAttachments;
}
