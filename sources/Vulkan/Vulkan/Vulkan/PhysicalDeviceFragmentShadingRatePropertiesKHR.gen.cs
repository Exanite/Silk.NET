// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceFragmentShadingRatePropertiesKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public Extent2D MinFragmentShadingRateAttachmentTexelSize;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxFragmentShadingRateAttachmentTexelSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrimitiveFragmentShadingRateWithMultipleViewports;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> LayeredShadingRateAttachments;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateNonTrivialCombinerOps;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxFragmentSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentSizeAspectRatio;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentShadingRateCoverageSamples;

    [SupportedApiProfile("vulkan")]
    public SampleCountFlags MaxFragmentShadingRateRasterizationSamples;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithShaderDepthStencilWrites;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithSampleMask;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithShaderSampleMask;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithConservativeRasterization;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithFragmentShaderInterlock;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateWithCustomSampleLocations;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> FragmentShadingRateStrictMultiplyCombiner;
}
