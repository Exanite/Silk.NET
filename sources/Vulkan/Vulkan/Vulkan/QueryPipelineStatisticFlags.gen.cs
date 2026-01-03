// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum QueryPipelineStatisticFlags : uint
{
    None = 0x0,
    InputAssemblyVerticesBit = 0x1,
    InputAssemblyPrimitivesBit = 0x2,
    VertexShaderInvocationsBit = 0x4,
    GeometryShaderInvocationsBit = 0x8,
    GeometryShaderPrimitivesBit = 0x10,
    ClippingInvocationsBit = 0x20,
    ClippingPrimitivesBit = 0x40,
    FragmentShaderInvocationsBit = 0x80,
    TessellationControlShaderPatchesBit = 0x100,
    TessellationEvaluationShaderInvocationsBit = 0x200,
    ComputeShaderInvocationsBit = 0x400,
    TaskShaderInvocationsBitEXT = 0x800,
    MeshShaderInvocationsBitEXT = 0x1000,
    ClusterCullingShaderInvocationsBitHUAWEI = 0x2000,
}
