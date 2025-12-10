// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct ConvertCooperativeVectorMatrixInfoNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("size_t")]
    public nuint SrcSize;
    public DeviceOrHostAddressConstKHR SrcData;

    [NativeTypeName("size_t *")]
    public nuint* PDstSize;
    public DeviceOrHostAddressKHR DstData;
    public ComponentTypeKHR SrcComponentType;
    public ComponentTypeKHR DstComponentType;

    [NativeTypeName("uint32_t")]
    public uint NumRows;

    [NativeTypeName("uint32_t")]
    public uint NumColumns;
    public CooperativeVectorMatrixLayoutNV SrcLayout;

    [NativeTypeName("size_t")]
    public nuint SrcStride;
    public CooperativeVectorMatrixLayoutNV DstLayout;

    [NativeTypeName("size_t")]
    public nuint DstStride;
}
