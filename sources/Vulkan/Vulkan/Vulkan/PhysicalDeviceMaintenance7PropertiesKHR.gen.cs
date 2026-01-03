// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceMaintenance7PropertiesKHR
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint RobustFragmentShadingRateAttachmentAccess;

    [NativeTypeName("VkBool32")]
    public uint SeparateDepthStencilAttachmentAccess;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetTotalUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetTotalStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetTotalBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
}
