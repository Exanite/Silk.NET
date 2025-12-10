// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ClusterAccelerationStructureTriangleClusterInputNV
{
    public StructureType SType;
    public void* PNext;
    public Format VertexFormat;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryIndexValue;

    [NativeTypeName("uint32_t")]
    public uint MaxClusterUniqueGeometryCount;

    [NativeTypeName("uint32_t")]
    public uint MaxClusterTriangleCount;

    [NativeTypeName("uint32_t")]
    public uint MaxClusterVertexCount;

    [NativeTypeName("uint32_t")]
    public uint MaxTotalTriangleCount;

    [NativeTypeName("uint32_t")]
    public uint MaxTotalVertexCount;

    [NativeTypeName("uint32_t")]
    public uint MinPositionTruncateBitCount;
}
