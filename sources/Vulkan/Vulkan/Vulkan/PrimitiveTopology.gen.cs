// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PrimitiveTopology : uint
{
    [SupportedApiProfile("vulkan")]
    PointList = 0,

    [SupportedApiProfile("vulkan")]
    LineList = 1,

    [SupportedApiProfile("vulkan")]
    LineStrip = 2,

    [SupportedApiProfile("vulkan")]
    TriangleList = 3,

    [SupportedApiProfile("vulkan")]
    TriangleStrip = 4,

    [SupportedApiProfile("vulkan")]
    TriangleFan = 5,

    [SupportedApiProfile("vulkan")]
    LineListWithAdjacency = 6,

    [SupportedApiProfile("vulkan")]
    LineStripWithAdjacency = 7,

    [SupportedApiProfile("vulkan")]
    TriangleListWithAdjacency = 8,

    [SupportedApiProfile("vulkan")]
    TriangleStripWithAdjacency = 9,

    [SupportedApiProfile("vulkan")]
    PatchList = 10,
}
