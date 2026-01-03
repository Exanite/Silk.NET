// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum PipelineCreateFlags : uint
{
    None = 0x0,
    DisableOptimizationBit = 0x1,
    AllowDerivativesBit = 0x2,
    DerivativeBit = 0x4,
    DispatchBaseBit = 0x10,
    ViewIndexFromDeviceIndexBit = 0x8,
    FailOnPipelineCompileRequiredBit = 0x100,
    EarlyReturnOnFailureBit = 0x200,
    NoProtectedAccessBit = 0x8000000,
    ProtectedAccessOnlyBit = 0x40000000,
    RayTracingNoNullAnyHitShadersBitKHR = 0x4000,
    RayTracingNoNullClosestHitShadersBitKHR = 0x8000,
    RayTracingNoNullMissShadersBitKHR = 0x10000,
    RayTracingNoNullIntersectionShadersBitKHR = 0x20000,
    RayTracingSkipTrianglesBitKHR = 0x1000,
    RayTracingSkipAabbsBitKHR = 0x2000,
    RayTracingShaderGroupHandleCaptureReplayBitKHR = 0x80000,
    DeferCompileBitNV = 0x20,
    RenderingFragmentDensityMapAttachmentBitEXT = 0x400000,
    RenderingFragmentShadingRateAttachmentBitKHR = 0x200000,
    CaptureStatisticsBitKHR = 0x40,
    CaptureInternalRepresentationsBitKHR = 0x80,
    IndirectBindableBitNV = 0x40000,
    LibraryBitKHR = 0x800,
    DescriptorBufferBitEXT = 0x20000000,
    RetainLinkTimeOptimizationInfoBitEXT = 0x800000,
    LinkTimeOptimizationBitEXT = 0x400,
    RayTracingAllowMotionBitNV = 0x100000,
    ColorAttachmentFeedbackLoopBitEXT = 0x2000000,
    DepthStencilAttachmentFeedbackLoopBitEXT = 0x4000000,
    RayTracingOpacityMicromapBitEXT = 0x1000000,
    ViewIndexFromDeviceIndexBitKHR = ViewIndexFromDeviceIndexBit,
    DispatchBaseBitKHR = DispatchBaseBit,
    FailOnPipelineCompileRequiredBitEXT = FailOnPipelineCompileRequiredBit,
    EarlyReturnOnFailureBitEXT = EarlyReturnOnFailureBit,
    NoProtectedAccessBitEXT = NoProtectedAccessBit,
    ProtectedAccessOnlyBitEXT = ProtectedAccessOnlyBit,
}
