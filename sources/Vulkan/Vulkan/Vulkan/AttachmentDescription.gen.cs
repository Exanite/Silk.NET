// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct AttachmentDescription
{
    [NativeTypeName("VkAttachmentDescriptionFlags")]
    public AttachmentDescriptionFlags Flags;
    public Format Format;
    public SampleCountFlags Samples;
    public AttachmentLoadOp LoadOp;
    public AttachmentStoreOp StoreOp;
    public AttachmentLoadOp StencilLoadOp;
    public AttachmentStoreOp StencilStoreOp;
    public ImageLayout InitialLayout;
    public ImageLayout FinalLayout;
}
