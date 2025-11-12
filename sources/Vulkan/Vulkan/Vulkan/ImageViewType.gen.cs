// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ImageViewType : uint
{
    [SupportedApiProfile("vulkan")]
    Type1D = 0,

    [SupportedApiProfile("vulkan")]
    Type2D = 1,

    [SupportedApiProfile("vulkan")]
    Type3D = 2,

    [SupportedApiProfile("vulkan")]
    TypeCube = 3,

    [SupportedApiProfile("vulkan")]
    Type1DArray = 4,

    [SupportedApiProfile("vulkan")]
    Type2DArray = 5,

    [SupportedApiProfile("vulkan")]
    TypeCubeArray = 6,
}
