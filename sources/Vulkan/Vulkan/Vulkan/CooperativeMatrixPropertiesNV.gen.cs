// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CooperativeMatrixPropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint NSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint KSize;

    [NativeTypeName("VkComponentTypeNV")]
    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR AType;

    [NativeTypeName("VkComponentTypeNV")]
    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR BType;

    [NativeTypeName("VkComponentTypeNV")]
    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR CType;

    [NativeTypeName("VkComponentTypeNV")]
    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR DType;

    [NativeTypeName("VkScopeNV")]
    [SupportedApiProfile("vulkan")]
    public ScopeKHR Scope;
}
