// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ClusterAccelerationStructureOpInputNV
{
    [FieldOffset(0)]
    public ClusterAccelerationStructureClustersBottomLevelInputNV* PClustersBottomLevel;

    [FieldOffset(0)]
    public ClusterAccelerationStructureTriangleClusterInputNV* PTriangleClusters;

    [FieldOffset(0)]
    public ClusterAccelerationStructureMoveObjectsInputNV* PMoveObjects;
}
