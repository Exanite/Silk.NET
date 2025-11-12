// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct RenderPassCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkRenderPassCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public RenderPassCreateFlags Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint AttachmentCount;

    [NativeTypeName("const VkAttachmentDescription *")]
    [SupportedApiProfile("vulkan")]
    public AttachmentDescription* PAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubpassCount;

    [NativeTypeName("const VkSubpassDescription *")]
    [SupportedApiProfile("vulkan")]
    public SubpassDescription* PSubpasses;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DependencyCount;

    [NativeTypeName("const VkSubpassDependency *")]
    [SupportedApiProfile("vulkan")]
    public SubpassDependency* PDependencies;
}
