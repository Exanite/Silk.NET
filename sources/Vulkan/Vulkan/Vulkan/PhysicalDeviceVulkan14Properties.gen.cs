// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan14Properties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint LineSubPixelPrecisionBits;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexAttribDivisor;

    [NativeTypeName("VkBool32")]
    public uint SupportsNonZeroFirstInstance;

    [NativeTypeName("uint32_t")]
    public uint MaxPushDescriptors;

    [NativeTypeName("VkBool32")]
    public uint DynamicRenderingLocalReadDepthStencilAttachments;

    [NativeTypeName("VkBool32")]
    public uint DynamicRenderingLocalReadMultisampledAttachments;

    [NativeTypeName("VkBool32")]
    public uint EarlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint EarlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint DepthStencilSwizzleOneSupport;

    [NativeTypeName("VkBool32")]
    public uint PolygonModePointSize;

    [NativeTypeName("VkBool32")]
    public uint NonStrictSinglePixelWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    public uint NonStrictWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    public uint BlockTexelViewCompatibleMultipleLayers;

    [NativeTypeName("uint32_t")]
    public uint MaxCombinedImageSamplerDescriptorCount;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateClampCombinerInputs;
    public PipelineRobustnessBufferBehavior DefaultRobustnessStorageBuffers;
    public PipelineRobustnessBufferBehavior DefaultRobustnessUniformBuffers;
    public PipelineRobustnessBufferBehavior DefaultRobustnessVertexInputs;
    public PipelineRobustnessImageBehavior DefaultRobustnessImages;

    [NativeTypeName("uint32_t")]
    public uint CopySrcLayoutCount;
    public ImageLayout* PCopySrcLayouts;

    [NativeTypeName("uint32_t")]
    public uint CopyDstLayoutCount;
    public ImageLayout* PCopyDstLayouts;

    [NativeTypeName("uint8_t[16]")]
    public PhysicalDeviceVulkan14PropertiesOptimalTilingLayoutUUID OptimalTilingLayoutUUID;

    [NativeTypeName("VkBool32")]
    public uint IdenticalMemoryTypeRequirements;
}
