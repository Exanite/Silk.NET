// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public enum OpacityMicromapSpecialIndexEXT
{
    [SupportedApiProfile("vulkan")]
    FullyTransparentEXT = -1,

    [SupportedApiProfile("vulkan")]
    FullyOpaqueEXT = -2,

    [SupportedApiProfile("vulkan")]
    FullyUnknownTransparentEXT = -3,

    [SupportedApiProfile("vulkan")]
    FullyUnknownOpaqueEXT = -4,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap", "VK_NV_cluster_acceleration_structure"],
        ImpliesSets = ["VK_KHR_acceleration_structure"],
        RequireAll = true
    )]
    ClusterGeometryDisableOpacityMicromapNV = -5,
}
