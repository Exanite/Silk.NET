// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceDescriptorBufferPropertiesEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> CombinedImageSamplerDescriptorSingleArray;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> BufferlessPushDescriptors;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> AllowSamplerImageViewPostSubmitCreation;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong DescriptorBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxResourceDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSamplerDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxEmbeddedImmutableSamplerBindings;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxEmbeddedImmutableSamplers;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint BufferCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint ImageCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint ImageViewCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint SamplerCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint AccelerationStructureCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint SamplerDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint CombinedImageSamplerDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint SampledImageDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint StorageImageDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint UniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint RobustUniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint StorageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint RobustStorageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint UniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint RobustUniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint StorageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint RobustStorageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint InputAttachmentDescriptorSize;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint AccelerationStructureDescriptorSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxSamplerDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MaxResourceDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong SamplerDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong ResourceDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong DescriptorBufferAddressSpaceSize;
}
