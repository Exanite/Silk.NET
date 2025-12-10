// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceDescriptorIndexingFeatures
{
    public StructureType SType;
    public void* PNext;

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
}
