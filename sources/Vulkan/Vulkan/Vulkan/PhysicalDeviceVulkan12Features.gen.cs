// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan12Features
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint SamplerMirrorClampToEdge;

    [NativeTypeName("VkBool32")]
    public uint DrawIndirectCount;

    [NativeTypeName("VkBool32")]
    public uint StorageBuffer8BitAccess;

    [NativeTypeName("VkBool32")]
    public uint UniformAndStorageBuffer8BitAccess;

    [NativeTypeName("VkBool32")]
    public uint StoragePushConstant8;

    [NativeTypeName("VkBool32")]
    public uint ShaderBufferInt64Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderSharedInt64Atomics;

    [NativeTypeName("VkBool32")]
    public uint ShaderFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderInt8;

    [NativeTypeName("VkBool32")]
    public uint DescriptorIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderInputAttachmentArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderUniformTexelBufferArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageTexelBufferArrayDynamicIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderUniformBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderSampledImageArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageImageArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderInputAttachmentArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderUniformTexelBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageTexelBufferArrayNonUniformIndexing;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingUniformBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingSampledImageUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingStorageImageUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingStorageBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingUniformTexelBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingStorageTexelBufferUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingUpdateUnusedWhilePending;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingPartiallyBound;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingVariableDescriptorCount;

    [NativeTypeName("VkBool32")]
    public uint RuntimeDescriptorArray;

    [NativeTypeName("VkBool32")]
    public uint SamplerFilterMinmax;

    [NativeTypeName("VkBool32")]
    public uint ScalarBlockLayout;

    [NativeTypeName("VkBool32")]
    public uint ImagelessFramebuffer;

    [NativeTypeName("VkBool32")]
    public uint UniformBufferStandardLayout;

    [NativeTypeName("VkBool32")]
    public uint ShaderSubgroupExtendedTypes;

    [NativeTypeName("VkBool32")]
    public uint SeparateDepthStencilLayouts;

    [NativeTypeName("VkBool32")]
    public uint HostQueryReset;

    [NativeTypeName("VkBool32")]
    public uint TimelineSemaphore;

    [NativeTypeName("VkBool32")]
    public uint BufferDeviceAddress;

    [NativeTypeName("VkBool32")]
    public uint BufferDeviceAddressCaptureReplay;

    [NativeTypeName("VkBool32")]
    public uint BufferDeviceAddressMultiDevice;

    [NativeTypeName("VkBool32")]
    public uint VulkanMemoryModel;

    [NativeTypeName("VkBool32")]
    public uint VulkanMemoryModelDeviceScope;

    [NativeTypeName("VkBool32")]
    public uint VulkanMemoryModelAvailabilityVisibilityChains;

    [NativeTypeName("VkBool32")]
    public uint ShaderOutputViewportIndex;

    [NativeTypeName("VkBool32")]
    public uint ShaderOutputLayer;

    [NativeTypeName("VkBool32")]
    public uint SubgroupBroadcastDynamicId;
}
