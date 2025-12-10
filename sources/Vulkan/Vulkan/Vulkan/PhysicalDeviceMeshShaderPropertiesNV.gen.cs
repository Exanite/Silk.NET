// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceMeshShaderPropertiesNV
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxDrawMeshTasksCount;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesNVMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskTotalMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskOutputCount;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesNVMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshTotalMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputVertices;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputPrimitives;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    public uint MeshOutputPerVertexGranularity;

    [NativeTypeName("uint32_t")]
    public uint MeshOutputPerPrimitiveGranularity;
}
