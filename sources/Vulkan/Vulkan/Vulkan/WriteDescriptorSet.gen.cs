// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct WriteDescriptorSet
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDescriptorSet")]
    [SupportedApiProfile("vulkan")]
    public DescriptorSetHandle DstSet;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstBinding;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DstArrayElement;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DescriptorCount;

    [SupportedApiProfile("vulkan")]
    public DescriptorType DescriptorType;

    [NativeTypeName("const VkDescriptorImageInfo *")]
    [SupportedApiProfile("vulkan")]
    public DescriptorImageInfo* PImageInfo;

    [NativeTypeName("const VkDescriptorBufferInfo *")]
    [SupportedApiProfile("vulkan")]
    public DescriptorBufferInfo* PBufferInfo;

    [NativeTypeName("const VkBufferView *")]
    [SupportedApiProfile("vulkan")]
    public BufferViewHandle* PTexelBufferView;
}
