// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CuLaunchInfoNVX
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkCuFunctionNVX")]
    [SupportedApiProfile("vulkan")]
    public CuFunctionNVXHandle Function;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint GridDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint GridDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint GridDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BlockDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BlockDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint BlockDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SharedMemBytes;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint ParamCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan")]
    public void** PParams;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint ExtraCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan")]
    public void** PExtras;
}
