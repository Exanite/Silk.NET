// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum RayTracingShaderGroupTypeKHR : uint
{
    General = 0,
    TrianglesHitGroup = 1,
    ProceduralHitGroup = 2,
    GeneralNV = General,
    TrianglesHitGroupNV = TrianglesHitGroup,
    ProceduralHitGroupNV = ProceduralHitGroup,
}
