// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDescriptorIndexingProperties
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxUpdateAfterBindDescriptorsInAllPools;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ShaderUniformBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ShaderSampledImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ShaderStorageBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ShaderStorageImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> ShaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> RobustBufferAccessUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> QuadDivergentImplicitLod;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageUpdateAfterBindResources;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;
}
