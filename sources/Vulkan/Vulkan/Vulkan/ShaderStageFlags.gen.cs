// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ShaderStageFlags : uint
{
    None = 0x0,
    VertexBit = 0x1,
    TessellationControlBit = 0x2,
    TessellationEvaluationBit = 0x4,
    GeometryBit = 0x8,
    FragmentBit = 0x10,
    ComputeBit = 0x20,
    AllGraphics = 0x1F,
    All = 0x7FFFFFFF,
    RaygenBitKHR = 0x100,
    AnyHitBitKHR = 0x200,
    ClosestHitBitKHR = 0x400,
    MissBitKHR = 0x800,
    IntersectionBitKHR = 0x1000,
    CallableBitKHR = 0x2000,
    TaskBitEXT = 0x40,
    MeshBitEXT = 0x80,
    SubpassShadingBitHUAWEI = 0x4000,
    ClusterCullingBitHUAWEI = 0x80000,
    RaygenBitNV = RaygenBitKHR,
    AnyHitBitNV = AnyHitBitKHR,
    ClosestHitBitNV = ClosestHitBitKHR,
    MissBitNV = MissBitKHR,
    IntersectionBitNV = IntersectionBitKHR,
    CallableBitNV = CallableBitKHR,
    TaskBitNV = TaskBitEXT,
    MeshBitNV = MeshBitEXT,
}
