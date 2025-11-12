// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceMeshShaderPropertiesEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTaskWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupCount MaxTaskWorkGroupCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxTaskWorkGroupSize MaxTaskWorkGroupSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTaskPayloadSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTaskSharedMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTaskPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshWorkGroupTotalCount;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupCount MaxMeshWorkGroupCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceMeshShaderPropertiesEXTMaxMeshWorkGroupSize MaxMeshWorkGroupSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshSharedMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshPayloadAndSharedMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshOutputMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshPayloadAndOutputMemorySize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshOutputVertices;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshOutputPrimitives;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshOutputLayers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMeshMultiviewViewCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MeshOutputPerVertexGranularity;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MeshOutputPerPrimitiveGranularity;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPreferredTaskWorkGroupInvocations;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPreferredMeshWorkGroupInvocations;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersLocalInvocationVertexOutput;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersLocalInvocationPrimitiveOutput;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersCompactVertexOutput;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrefersCompactPrimitiveOutput;
}
