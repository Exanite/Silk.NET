// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceDescriptorBufferPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint CombinedImageSamplerDescriptorSingleArray;

    [NativeTypeName("VkBool32")]
    public uint BufferlessPushDescriptors;

    [NativeTypeName("VkBool32")]
    public uint AllowSamplerImageViewPostSubmitCreation;

    [NativeTypeName("VkDeviceSize")]
    public ulong DescriptorBufferOffsetAlignment;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint MaxResourceDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint MaxSamplerDescriptorBufferBindings;

    [NativeTypeName("uint32_t")]
    public uint MaxEmbeddedImmutableSamplerBindings;

    [NativeTypeName("uint32_t")]
    public uint MaxEmbeddedImmutableSamplers;

    [NativeTypeName("size_t")]
    public nuint BufferCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint ImageCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint ImageViewCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint SamplerCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint AccelerationStructureCaptureReplayDescriptorDataSize;

    [NativeTypeName("size_t")]
    public nuint SamplerDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint CombinedImageSamplerDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint SampledImageDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint StorageImageDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint UniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint RobustUniformTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint StorageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint RobustStorageTexelBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint UniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint RobustUniformBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint StorageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint RobustStorageBufferDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint InputAttachmentDescriptorSize;

    [NativeTypeName("size_t")]
    public nuint AccelerationStructureDescriptorSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong MaxSamplerDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    public ulong MaxResourceDescriptorBufferRange;

    [NativeTypeName("VkDeviceSize")]
    public ulong SamplerDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong ResourceDescriptorBufferAddressSpaceSize;

    [NativeTypeName("VkDeviceSize")]
    public ulong DescriptorBufferAddressSpaceSize;
}
