// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct RenderPassBeginInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkRenderPass")]
    [SupportedApiProfile("vulkan")]
    public RenderPassHandle RenderPass;

    [NativeTypeName("VkFramebuffer")]
    [SupportedApiProfile("vulkan")]
    public FramebufferHandle Framebuffer;

    [SupportedApiProfile("vulkan")]
    public Rect2D RenderArea;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClearValueCount;

    [NativeTypeName("const VkClearValue *")]
    [SupportedApiProfile("vulkan")]
    public ClearValue* PClearValues;
}
