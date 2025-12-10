// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct SurfaceCapabilitiesKHR
{
    [NativeTypeName("uint32_t")]
    public uint MinImageCount;

    [NativeTypeName("uint32_t")]
    public uint MaxImageCount;
    public Extent2D CurrentExtent;
    public Extent2D MinImageExtent;
    public Extent2D MaxImageExtent;

    [NativeTypeName("uint32_t")]
    public uint MaxImageArrayLayers;

    [NativeTypeName("VkSurfaceTransformFlagsKHR")]
    public SurfaceTransformFlagsKHR SupportedTransforms;
    public SurfaceTransformFlagsKHR CurrentTransform;

    [NativeTypeName("VkCompositeAlphaFlagsKHR")]
    public CompositeAlphaFlagsKHR SupportedCompositeAlpha;

    [NativeTypeName("VkImageUsageFlags")]
    public ImageUsageFlags SupportedUsageFlags;
}
