// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum ImageViewType : uint
{
    Type1D = 0,
    Type2D = 1,
    Type3D = 2,
    TypeCube = 3,
    Type1DArray = 4,
    Type2DArray = 5,
    TypeCubeArray = 6,
}
