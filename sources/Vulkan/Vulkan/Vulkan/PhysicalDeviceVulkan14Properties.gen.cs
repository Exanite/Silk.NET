// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceVulkan14Properties
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint LineSubPixelPrecisionBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexAttribDivisor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> SupportsNonZeroFirstInstance;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPushDescriptors;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DynamicRenderingLocalReadDepthStencilAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DynamicRenderingLocalReadMultisampledAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> EarlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> EarlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> DepthStencilSwizzleOneSupport;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PolygonModePointSize;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> NonStrictSinglePixelWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> NonStrictWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> BlockTexelViewCompatibleMultipleLayers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxCombinedImageSamplerDescriptorCount;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateClampCombinerInputs;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;

    [SupportedApiProfile("vulkan")]
    public PipelineRobustnessImageBehavior DefaultRobustnessImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CopySrcLayoutCount;

    [SupportedApiProfile("vulkan")]
    public ImageLayout* PCopySrcLayouts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CopyDstLayoutCount;

    [SupportedApiProfile("vulkan")]
    public ImageLayout* PCopyDstLayouts;

    [NativeTypeName("uint8_t[16]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceVulkan14PropertiesOptimalTilingLayoutUUID OptimalTilingLayoutUUID;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> IdenticalMemoryTypeRequirements;
}
