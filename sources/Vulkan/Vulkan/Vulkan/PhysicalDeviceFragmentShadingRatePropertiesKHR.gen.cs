// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceFragmentShadingRatePropertiesKHR
{
    public StructureType SType;
    public void* PNext;
    public Extent2D MinFragmentShadingRateAttachmentTexelSize;
    public Extent2D MaxFragmentShadingRateAttachmentTexelSize;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;

    [NativeTypeName("VkBool32")]
    public uint PrimitiveFragmentShadingRateWithMultipleViewports;

    [NativeTypeName("VkBool32")]
    public uint LayeredShadingRateAttachments;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateNonTrivialCombinerOps;
    public Extent2D MaxFragmentSize;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentSizeAspectRatio;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentShadingRateCoverageSamples;
    public SampleCountFlags MaxFragmentShadingRateRasterizationSamples;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithShaderDepthStencilWrites;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithSampleMask;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithShaderSampleMask;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithConservativeRasterization;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithFragmentShaderInterlock;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateWithCustomSampleLocations;

    [NativeTypeName("VkBool32")]
    public uint FragmentShadingRateStrictMultiplyCombiner;
}
