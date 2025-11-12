// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ConvertCooperativeVectorMatrixInfoNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint SrcSize;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressConstKHR SrcData;

    [NativeTypeName("size_t *")]
    [SupportedApiProfile("vulkan")]
    public nuint* PDstSize;

    [SupportedApiProfile("vulkan")]
    public DeviceOrHostAddressKHR DstData;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR SrcComponentType;

    [SupportedApiProfile("vulkan")]
    public ComponentTypeKHR DstComponentType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint NumRows;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint NumColumns;

    [SupportedApiProfile("vulkan")]
    public CooperativeVectorMatrixLayoutNV SrcLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint SrcStride;

    [SupportedApiProfile("vulkan")]
    public CooperativeVectorMatrixLayoutNV DstLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint DstStride;
}
