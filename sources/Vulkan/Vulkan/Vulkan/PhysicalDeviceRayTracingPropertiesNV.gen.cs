// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceRayTracingPropertiesNV
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupHandleSize;

    [NativeTypeName("uint32_t")]
    public uint MaxRecursionDepth;

    [NativeTypeName("uint32_t")]
    public uint MaxShaderGroupStride;

    [NativeTypeName("uint32_t")]
    public uint ShaderGroupBaseAlignment;

    [NativeTypeName("uint64_t")]
    public ulong MaxGeometryCount;

    [NativeTypeName("uint64_t")]
    public ulong MaxInstanceCount;

    [NativeTypeName("uint64_t")]
    public ulong MaxTriangleCount;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetAccelerationStructures;
}
