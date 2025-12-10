// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan12Properties
{
    public StructureType SType;
    public void* PNext;
    public DriverId DriverID;

    [NativeTypeName("char[256]")]
    public PhysicalDeviceVulkan12PropertiesDriverName DriverName;

    [NativeTypeName("char[256]")]
    public PhysicalDeviceVulkan12PropertiesDriverInfo DriverInfo;
    public ConformanceVersion ConformanceVersion;
    public ShaderFloatControlsIndependence DenormBehaviorIndependence;
    public ShaderFloatControlsIndependence RoundingModeIndependence;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat64;

    [NativeTypeName("uint32_t")]
    public uint MaxUpdateAfterBindDescriptorsInAllPools;

    [NativeTypeName("VkBool32")]
    public uint ShaderUniformBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderSampledImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageBufferArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderStorageImageArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint ShaderInputAttachmentArrayNonUniformIndexingNative;

    [NativeTypeName("VkBool32")]
    public uint RobustBufferAccessUpdateAfterBind;

    [NativeTypeName("VkBool32")]
    public uint QuadDivergentImplicitLod;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUpdateAfterBindInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageUpdateAfterBindResources;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUpdateAfterBindInputAttachments;

    [NativeTypeName("VkResolveModeFlags")]
    public ResolveModeFlags SupportedDepthResolveModes;

    [NativeTypeName("VkResolveModeFlags")]
    public ResolveModeFlags SupportedStencilResolveModes;

    [NativeTypeName("VkBool32")]
    public uint IndependentResolveNone;

    [NativeTypeName("VkBool32")]
    public uint IndependentResolve;

    [NativeTypeName("VkBool32")]
    public uint FilterMinmaxSingleComponentFormats;

    [NativeTypeName("VkBool32")]
    public uint FilterMinmaxImageComponentMapping;

    [NativeTypeName("uint64_t")]
    public ulong MaxTimelineSemaphoreValueDifference;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags FramebufferIntegerColorSampleCounts;
}
