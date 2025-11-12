// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ClusterAccelerationStructureOpTypeNV : uint
{
    [SupportedApiProfile("vulkan")]
    MoveObjectsNV = 0,

    [SupportedApiProfile("vulkan")]
    BuildClustersBottomLevelNV = 1,

    [SupportedApiProfile("vulkan")]
    BuildTriangleClusterNV = 2,

    [SupportedApiProfile("vulkan")]
    BuildTriangleClusterTemplateNV = 3,

    [SupportedApiProfile("vulkan")]
    InstantiateTriangleClusterNV = 4,

    [SupportedApiProfile("vulkan")]
    GetClusterTemplateIndicesNV = 5,
}
