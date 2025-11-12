// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct SurfaceCapabilitiesKHR
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinImageCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageCount;

    [SupportedApiProfile("vulkan")]
    public Extent2D CurrentExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinImageExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxImageExtent;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageArrayLayers;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public SurfaceTransformFlagsKHR SupportedTransforms;

    [SupportedApiProfile("vulkan")]
    public SurfaceTransformFlagsKHR CurrentTransform;

    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public CompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeTypeName("VkImageUsageFlags")]
    [SupportedApiProfile("vulkan")]
    public ImageUsageFlags SupportedUsageFlags;
}
