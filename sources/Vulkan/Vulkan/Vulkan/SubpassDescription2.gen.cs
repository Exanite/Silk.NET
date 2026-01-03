// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct SubpassDescription2
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkSubpassDescriptionFlags")]
    public SubpassDescriptionFlags Flags;
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("uint32_t")]
    public uint ViewMask;

    [NativeTypeName("uint32_t")]
    public uint InputAttachmentCount;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public AttachmentReference2* PInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint ColorAttachmentCount;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public AttachmentReference2* PColorAttachments;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public AttachmentReference2* PResolveAttachments;

    [NativeTypeName("const VkAttachmentReference2 *")]
    public AttachmentReference2* PDepthStencilAttachment;

    [NativeTypeName("uint32_t")]
    public uint PreserveAttachmentCount;

    [NativeTypeName("const uint32_t *")]
    public uint* PPreserveAttachments;
}
