// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct RenderingAttachmentInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan")]
    public ImageViewHandle ImageView;

    [SupportedApiProfile("vulkan")]
    public ImageLayout ImageLayout;

    [SupportedApiProfile("vulkan")]
    public ResolveModeFlags ResolveMode;

    [NativeTypeName("VkImageView")]
    [SupportedApiProfile("vulkan")]
    public ImageViewHandle ResolveImageView;

    [SupportedApiProfile("vulkan")]
    public ImageLayout ResolveImageLayout;

    [SupportedApiProfile("vulkan")]
    public AttachmentLoadOp LoadOp;

    [SupportedApiProfile("vulkan")]
    public AttachmentStoreOp StoreOp;

    [SupportedApiProfile("vulkan")]
    public ClearValue ClearValue;
}
