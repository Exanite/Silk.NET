// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct RenderingAttachmentInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkImageView")]
    public ImageViewHandle ImageView;
    public ImageLayout ImageLayout;
    public ResolveModeFlags ResolveMode;

    [NativeTypeName("VkImageView")]
    public ImageViewHandle ResolveImageView;
    public ImageLayout ResolveImageLayout;
    public AttachmentLoadOp LoadOp;
    public AttachmentStoreOp StoreOp;
    public ClearValue ClearValue;
}
