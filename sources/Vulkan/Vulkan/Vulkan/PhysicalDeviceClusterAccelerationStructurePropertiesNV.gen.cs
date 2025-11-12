// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceClusterAccelerationStructurePropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVerticesPerCluster;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTrianglesPerCluster;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClusterScratchByteAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClusterByteAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClusterTemplateByteAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClusterBottomLevelByteAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ClusterTemplateBoundsByteAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxClusterGeometryIndex;
}
