// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct PhysicalDeviceLimits
{
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageDimension1D;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageDimension2D;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageDimension3D;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageDimensionCube;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxImageArrayLayers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTexelBufferElements;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxUniformBufferRange;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxStorageBufferRange;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPushConstantsSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxMemoryAllocationCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSamplerAllocationCount;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong BufferImageGranularity;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong SparseAddressSpaceSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxBoundDescriptorSets;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorSamplers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorUniformBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorStorageBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorSampledImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorStorageImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageDescriptorInputAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxPerStageResources;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetSamplers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUniformBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetStorageBuffers;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetSampledImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetStorageImages;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDescriptorSetInputAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexInputAttributes;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexInputBindings;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexInputAttributeOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexInputBindingStride;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxVertexOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationGenerationLevel;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationPatchSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationControlPerVertexInputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationControlPerVertexOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationControlPerPatchOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationControlTotalOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationEvaluationInputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTessellationEvaluationOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGeometryShaderInvocations;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGeometryInputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGeometryOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGeometryOutputVertices;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxGeometryTotalOutputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentInputComponents;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentOutputAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentDualSrcAttachments;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFragmentCombinedOutputResources;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxComputeSharedMemorySize;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupCount MaxComputeWorkGroupCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxComputeWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupSize MaxComputeWorkGroupSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubPixelPrecisionBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubTexelPrecisionBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MipmapPrecisionBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDrawIndexedIndexValue;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDrawIndirectCount;

    [SupportedApiProfile("vulkan")]
    public float MaxSamplerLodBias;

    [SupportedApiProfile("vulkan")]
    public float MaxSamplerAnisotropy;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxViewports;

    [NativeTypeName("uint32_t[2]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsMaxViewportDimensions MaxViewportDimensions;

    [NativeTypeName("float[2]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsViewportBoundsRange ViewportBoundsRange;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ViewportSubPixelBits;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan")]
    public nuint MinMemoryMapAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MinTexelBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MinUniformBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MinStorageBufferOffsetAlignment;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int MinTexelOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTexelOffset;

    [NativeTypeName("int32_t")]
    [SupportedApiProfile("vulkan")]
    public int MinTexelGatherOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxTexelGatherOffset;

    [SupportedApiProfile("vulkan")]
    public float MinInterpolationOffset;

    [SupportedApiProfile("vulkan")]
    public float MaxInterpolationOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubPixelInterpolationOffsetBits;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFramebufferWidth;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFramebufferHeight;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxFramebufferLayers;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags FramebufferColorSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags FramebufferDepthSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags FramebufferStencilSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags FramebufferNoAttachmentsSampleCounts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxColorAttachments;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags SampledImageColorSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags SampledImageIntegerSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags SampledImageDepthSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags SampledImageStencilSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags StorageImageSampleCounts;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxSampleMaskWords;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> TimestampComputeAndGraphics;

    [SupportedApiProfile("vulkan")]
    public float TimestampPeriod;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxClipDistances;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxCullDistances;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxCombinedClipAndCullDistances;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DiscreteQueuePriorities;

    [NativeTypeName("float[2]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsPointSizeRange PointSizeRange;

    [NativeTypeName("float[2]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceLimitsLineWidthRange LineWidthRange;

    [SupportedApiProfile("vulkan")]
    public float PointSizeGranularity;

    [SupportedApiProfile("vulkan")]
    public float LineWidthGranularity;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> StrictLines;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> StandardSampleLocations;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong OptimalBufferCopyOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong OptimalBufferCopyRowPitchAlignment;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong NonCoherentAtomSize;
}
