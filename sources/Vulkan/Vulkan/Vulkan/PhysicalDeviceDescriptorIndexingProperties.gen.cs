// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceDescriptorIndexingProperties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint MaxUpdateAfterBindDescriptorsInAllPools;

    [NativeTypeName("VkBool32")]
    public uint ShaderUniformBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderSampledImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint RobustBufferAccessUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint QuadDivergentImplicitLod;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageUpdateAfterBindResources;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
}
