// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct DisplayPlaneCapabilitiesKHR
{
    [NativeTypeName("VkDisplayPlaneAlphaFlagsKHR")]
    public DisplayPlaneAlphaFlagsKHR SupportedAlpha;
    public Offset2D MinSrcPosition;
    public Offset2D MaxSrcPosition;
    public Extent2D MinSrcExtent;
    public Extent2D MaxSrcExtent;
    public Offset2D MinDstPosition;
    public Offset2D MaxDstPosition;
    public Extent2D MinDstExtent;
    public Extent2D MaxDstExtent;
}
