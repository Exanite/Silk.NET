// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct CooperativeMatrixFlexibleDimensionsPropertiesNV
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MGranularity;

    [NativeTypeName("uint32_t")]
    public uint NGranularity;

    [NativeTypeName("uint32_t")]
    public uint KGranularity;
    public ComponentTypeKHR AType;
    public ComponentTypeKHR BType;
    public ComponentTypeKHR CType;
    public ComponentTypeKHR ResultType;

    [NativeTypeName("VkBool32")]
    public uint SaturatingAccumulation;
    public ScopeKHR Scope;

    [NativeTypeName("uint32_t")]
    public uint WorkgroupInvocations;
}
