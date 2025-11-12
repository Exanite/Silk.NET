// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum Filter : uint
{
    [SupportedApiProfile("vulkan")]
    Nearest = 0,

    [SupportedApiProfile("vulkan")]
    Linear = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_filter_cubic"])]
    CubicEXT = 1000015000,

    [SupportedApiProfile("vulkan", ["VK_IMG_filter_cubic"])]
    CubicIMG = CubicEXT,
}
