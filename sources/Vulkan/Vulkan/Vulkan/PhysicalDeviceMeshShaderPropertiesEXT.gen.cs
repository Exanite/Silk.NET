// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceMeshShaderPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupCount MaxTaskWorkGroupCount;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskPayloadSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxTaskPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupCount MaxMeshWorkGroupCount;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshPayloadAndOutputMemorySize;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputVertices;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputPrimitives;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshOutputLayers;

    [NativeTypeName("uint32_t")]
    public uint MaxMeshMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    public uint MeshOutputPerVertexGranularity;

    [NativeTypeName("uint32_t")]
    public uint MeshOutputPerPrimitiveGranularity;

    [NativeTypeName("uint32_t")]
    public uint MaxPreferredTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t")]
    public uint MaxPreferredMeshWorkGroupInvocations;

    [NativeTypeName("VkBool32")]
    public uint PrefersLocalInvocationVertexOutput;

    [NativeTypeName("VkBool32")]
    public uint PrefersLocalInvocationPrimitiveOutput;

    [NativeTypeName("VkBool32")]
    public uint PrefersCompactVertexOutput;

    [NativeTypeName("VkBool32")]
    public uint PrefersCompactPrimitiveOutput;
}
