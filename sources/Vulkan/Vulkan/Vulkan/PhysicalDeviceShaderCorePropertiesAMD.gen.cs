// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceShaderCorePropertiesAMD
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint ShaderEngineCount;

    [NativeTypeName("uint32_t")]
    public uint ShaderArraysPerEngineCount;

    [NativeTypeName("uint32_t")]
    public uint ComputeUnitsPerShaderArray;

    [NativeTypeName("uint32_t")]
    public uint SimdPerComputeUnit;

    [NativeTypeName("uint32_t")]
    public uint WavefrontsPerSimd;

    [NativeTypeName("uint32_t")]
    public uint WavefrontSize;

    [NativeTypeName("uint32_t")]
    public uint SgprsPerSimd;

    [NativeTypeName("uint32_t")]
    public uint MinSgprAllocation;

    [NativeTypeName("uint32_t")]
    public uint MaxSgprAllocation;

    [NativeTypeName("uint32_t")]
    public uint SgprAllocationGranularity;

    [NativeTypeName("uint32_t")]
    public uint VgprsPerSimd;

    [NativeTypeName("uint32_t")]
    public uint MinVgprAllocation;

    [NativeTypeName("uint32_t")]
    public uint MaxVgprAllocation;

    [NativeTypeName("uint32_t")]
    public uint VgprAllocationGranularity;
}
