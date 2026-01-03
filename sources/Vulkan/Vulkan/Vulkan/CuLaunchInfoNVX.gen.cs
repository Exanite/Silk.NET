// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct CuLaunchInfoNVX
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkCuFunctionNVX")]
    public CuFunctionHandleNVX Function;

    [NativeTypeName("uint32_t")]
    public uint GridDimX;

    [NativeTypeName("uint32_t")]
    public uint GridDimY;

    [NativeTypeName("uint32_t")]
    public uint GridDimZ;

    [NativeTypeName("uint32_t")]
    public uint BlockDimX;

    [NativeTypeName("uint32_t")]
    public uint BlockDimY;

    [NativeTypeName("uint32_t")]
    public uint BlockDimZ;

    [NativeTypeName("uint32_t")]
    public uint SharedMemBytes;

    [NativeTypeName("size_t")]
    public nuint ParamCount;

    [NativeTypeName("const void *const *")]
    public void** PParams;

    [NativeTypeName("size_t")]
    public nuint ExtraCount;

    [NativeTypeName("const void *const *")]
    public void** PExtras;
}
