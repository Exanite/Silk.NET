// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceRayTracingPipelinePropertiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupHandleSize;

    [NativeTypeName("uint32_t")]
    public uint MaxRayRecursionDepth;

    [NativeTypeName("uint32_t")]
    public uint MaxShaderGroupStride;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupBaseAlignment;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupHandleCaptureReplaySize;

    [NativeTypeName("uint32_t")]
    public uint MaxRayDispatchInvocationCount;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupHandleAlignment;

    [NativeTypeName("uint32_t")]
    public uint MaxRayHitAttributeSize;
}
