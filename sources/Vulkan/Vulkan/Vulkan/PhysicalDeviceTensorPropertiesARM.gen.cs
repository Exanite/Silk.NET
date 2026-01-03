// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceTensorPropertiesARM
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxTensorDimensionCount;

    [NativeTypeName("uint64_t")]
    public ulong MaxTensorElements;

    [NativeTypeName("uint64_t")]
    public ulong MaxPerDimensionTensorElements;

    [NativeTypeName("int64_t")]
    public long MaxTensorStride;

    [NativeTypeName("uint64_t")]
    public ulong MaxTensorSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTensorShaderAccessArrayLength;

    [NativeTypeName("uint32_t")]
    public uint MaxTensorShaderAccessSize;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorSetStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageTensors;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageTensors;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageTensorArrayNonUniformIndexingNative;

    [NativeTypeName("VkShaderStageFlags")]
    public ShaderStageFlags ShaderTensorSupportedStages;
}
