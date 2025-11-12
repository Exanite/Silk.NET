// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct DisplayPlaneCapabilitiesKHR
{
    [NativeTypeName("VkDisplayPlaneAlphaFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public DisplayPlaneAlphaFlagsKHR SupportedAlpha;

    [SupportedApiProfile("vulkan")]
    public Offset2D MinSrcPosition;

    [SupportedApiProfile("vulkan")]
    public Offset2D MaxSrcPosition;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinSrcExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxSrcExtent;

    [SupportedApiProfile("vulkan")]
    public Offset2D MinDstPosition;

    [SupportedApiProfile("vulkan")]
    public Offset2D MaxDstPosition;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinDstExtent;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxDstExtent;
}
