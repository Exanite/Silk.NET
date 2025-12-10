// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan13Features
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint RobustImageAccess;

    [NativeTypeName("VkBool32")]
    public uint InlineUniformBlock;

    [NativeTypeName("VkBool32")]
    public uint DescriptorBindingInlineUniformBlockUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint PipelineCreationCacheControl;

    [NativeTypeName("VkBool32")]
    public uint PrivateData;

    [NativeTypeName("VkBool32")]
    public uint ShaderDemoteToHelperInvocation;

    [NativeTypeName("VkBool32")]
    public uint ShaderTerminateInvocation;

    [NativeTypeName("VkBool32")]
    public uint SubgroupSizeControl;

    [NativeTypeName("VkBool32")]
    public uint ComputeFullSubgroups;

    [NativeTypeName("VkBool32")]
    public uint Synchronization2;

    [NativeTypeName("VkBool32")]
    public uint TextureCompressionASTCHDR;

    [NativeTypeName("VkBool32")]
    public uint ShaderZeroInitializeWorkgroupMemory;

    [NativeTypeName("VkBool32")]
    public uint DynamicRendering;

    [NativeTypeName("VkBool32")]
    public uint ShaderIntegerDotProduct;

    [NativeTypeName("VkBool32")]
    public uint Maintenance4;
}
