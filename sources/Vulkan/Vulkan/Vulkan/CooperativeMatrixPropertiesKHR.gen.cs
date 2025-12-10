// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct CooperativeMatrixPropertiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MSize;

    [NativeTypeName("uint32_t")]
    public uint NSize;

    [NativeTypeName("uint32_t")]
    public uint KSize;
    public ComponentTypeKHR AType;
    public ComponentTypeKHR BType;
    public ComponentTypeKHR CType;
    public ComponentTypeKHR ResultType;

    [NativeTypeName("VkBool32")]
    public uint SaturatingAccumulation;
    public ScopeKHR Scope;
}
