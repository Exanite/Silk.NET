// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct AttachmentDescription
{
    [NativeTypeName("VkAttachmentDescriptionFlags")]
    [SupportedApiProfile("vulkan")]
    public AttachmentDescriptionFlags Flags;

    [SupportedApiProfile("vulkan")]
    public Format Format;

    [SupportedApiProfile("vulkan")]
    public SampleCountFlags Samples;

    [SupportedApiProfile("vulkan")]
    public AttachmentLoadOp LoadOp;

    [SupportedApiProfile("vulkan")]
    public AttachmentStoreOp StoreOp;

    [SupportedApiProfile("vulkan")]
    public AttachmentLoadOp StencilLoadOp;

    [SupportedApiProfile("vulkan")]
    public AttachmentStoreOp StencilStoreOp;

    [SupportedApiProfile("vulkan")]
    public ImageLayout InitialLayout;

    [SupportedApiProfile("vulkan")]
    public ImageLayout FinalLayout;
}
