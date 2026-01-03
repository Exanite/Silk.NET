// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum PipelineStageFlags : uint
{
    TopOfPipeBit = 0x1,
    DrawIndirectBit = 0x2,
    VertexInputBit = 0x4,
    VertexShaderBit = 0x8,
    TessellationControlShaderBit = 0x10,
    TessellationEvaluationShaderBit = 0x20,
    GeometryShaderBit = 0x40,
    FragmentShaderBit = 0x80,
    EarlyFragmentTestsBit = 0x100,
    LateFragmentTestsBit = 0x200,
    ColorAttachmentOutputBit = 0x400,
    ComputeShaderBit = 0x800,
    TransferBit = 0x1000,
    BottomOfPipeBit = 0x2000,
    HostBit = 0x4000,
    AllGraphicsBit = 0x8000,
    AllCommandsBit = 0x10000,
    None = 0x0,
    TransformFeedbackBitEXT = 0x1000000,
    ConditionalRenderingBitEXT = 0x40000,
    AccelerationStructureBuildBitKHR = 0x2000000,
    RayTracingShaderBitKHR = 0x200000,
    FragmentDensityProcessBitEXT = 0x800000,
    FragmentShadingRateAttachmentBitKHR = 0x400000,
    TaskShaderBitEXT = 0x80000,
    MeshShaderBitEXT = 0x100000,
    CommandPreprocessBitEXT = 0x20000,
    ShadingRateImageBitNV = FragmentShadingRateAttachmentBitKHR,
    RayTracingShaderBitNV = RayTracingShaderBitKHR,
    AccelerationStructureBuildBitNV = AccelerationStructureBuildBitKHR,
    TaskShaderBitNV = TaskShaderBitEXT,
    MeshShaderBitNV = MeshShaderBitEXT,
    CommandPreprocessBitNV = CommandPreprocessBitEXT,
    NoneKHR = None,
}
