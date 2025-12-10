// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct DescriptorDataEXT
{
    [FieldOffset(0)]
    [NativeTypeName("const VkSampler *")]
    public SamplerHandle* PSampler;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    public DescriptorImageInfo* PCombinedImageSampler;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    public DescriptorImageInfo* PInputAttachmentImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    public DescriptorImageInfo* PSampledImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorImageInfo *")]
    public DescriptorImageInfo* PStorageImage;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    public DescriptorAddressInfoEXT* PUniformTexelBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    public DescriptorAddressInfoEXT* PStorageTexelBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    public DescriptorAddressInfoEXT* PUniformBuffer;

    [FieldOffset(0)]
    [NativeTypeName("const VkDescriptorAddressInfoEXT *")]
    public DescriptorAddressInfoEXT* PStorageBuffer;

    [FieldOffset(0)]
    [NativeTypeName("VkDeviceAddress")]
    public ulong AccelerationStructure;
}
