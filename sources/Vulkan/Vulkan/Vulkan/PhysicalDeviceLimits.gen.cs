// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct PhysicalDeviceLimits
{
    [NativeTypeName("uint32_t")]
    public uint MaxImageDimension1D;

    [NativeTypeName("uint32_t")]
    public uint MaxImageDimension2D;

    [NativeTypeName("uint32_t")]
    public uint MaxImageDimension3D;

    [NativeTypeName("uint32_t")]
    public uint MaxImageDimensionCube;

    [NativeTypeName("uint32_t")]
    public uint MaxImageArrayLayers;

    [NativeTypeName("uint32_t")]
    public uint MaxTexelBufferElements;

    [NativeTypeName("uint32_t")]
    public uint MaxUniformBufferRange;

    [NativeTypeName("uint32_t")]
    public uint MaxStorageBufferRange;

    [NativeTypeName("uint32_t")]
    public uint MaxPushConstantsSize;

    [NativeTypeName("uint32_t")]
    public uint MaxMemoryAllocationCount;

    [NativeTypeName("uint32_t")]
    public uint MaxSamplerAllocationCount;

    [NativeTypeName("VkDeviceSize")]
    public ulong BufferImageGranularity;

    [NativeTypeName("VkDeviceSize")]
    public ulong SparseAddressSpaceSize;

    [NativeTypeName("uint32_t")]
    public uint MaxBoundDescriptorSets;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageDescriptorInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxPerStageResources;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetSamplers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUniformBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetUniformBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetStorageBuffers;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetStorageBuffersDynamic;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetSampledImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetStorageImages;

    [NativeTypeName("uint32_t")]
    public uint MaxDescriptorSetInputAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexInputAttributes;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexInputBindings;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexInputAttributeOffset;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexInputBindingStride;

    [NativeTypeName("uint32_t")]
    public uint MaxVertexOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationGenerationLevel;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationPatchSize;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationControlPerVertexInputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationControlPerVertexOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationControlPerPatchOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationControlTotalOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationEvaluationInputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxTessellationEvaluationOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryShaderInvocations;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryInputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryOutputVertices;

    [NativeTypeName("uint32_t")]
    public uint MaxGeometryTotalOutputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentInputComponents;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentOutputAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentDualSrcAttachments;

    [NativeTypeName("uint32_t")]
    public uint MaxFragmentCombinedOutputResources;

    [NativeTypeName("uint32_t")]
    public uint MaxComputeSharedMemorySize;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupCount MaxComputeWorkGroupCount;

    [NativeTypeName("uint32_t")]
    public uint MaxComputeWorkGroupInvocations;

    [NativeTypeName("uint32_t[3]")]
    public PhysicalDeviceLimitsMaxComputeWorkGroupSize MaxComputeWorkGroupSize;

    [NativeTypeName("uint32_t")]
    public uint SubPixelPrecisionBits;

    [NativeTypeName("uint32_t")]
    public uint SubTexelPrecisionBits;

    [NativeTypeName("uint32_t")]
    public uint MipmapPrecisionBits;

    [NativeTypeName("uint32_t")]
    public uint MaxDrawIndexedIndexValue;

    [NativeTypeName("uint32_t")]
    public uint MaxDrawIndirectCount;
    public float MaxSamplerLodBias;
    public float MaxSamplerAnisotropy;

    [NativeTypeName("uint32_t")]
    public uint MaxViewports;

    [NativeTypeName("uint32_t[2]")]
    public PhysicalDeviceLimitsMaxViewportDimensions MaxViewportDimensions;

    [NativeTypeName("float[2]")]
    public PhysicalDeviceLimitsViewportBoundsRange ViewportBoundsRange;

    [NativeTypeName("uint32_t")]
    public uint ViewportSubPixelBits;

    [NativeTypeName("size_t")]
    public nuint MinMemoryMapAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong MinTexelBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong MinUniformBufferOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong MinStorageBufferOffsetAlignment;

    [NativeTypeName("int32_t")]
    public int MinTexelOffset;

    [NativeTypeName("uint32_t")]
    public uint MaxTexelOffset;

    [NativeTypeName("int32_t")]
    public int MinTexelGatherOffset;

    [NativeTypeName("uint32_t")]
    public uint MaxTexelGatherOffset;
    public float MinInterpolationOffset;
    public float MaxInterpolationOffset;

    [NativeTypeName("uint32_t")]
    public uint SubPixelInterpolationOffsetBits;

    [NativeTypeName("uint32_t")]
    public uint MaxFramebufferWidth;

    [NativeTypeName("uint32_t")]
    public uint MaxFramebufferHeight;

    [NativeTypeName("uint32_t")]
    public uint MaxFramebufferLayers;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags FramebufferColorSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags FramebufferDepthSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags FramebufferStencilSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags FramebufferNoAttachmentsSampleCounts;

    [NativeTypeName("uint32_t")]
    public uint MaxColorAttachments;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags SampledImageColorSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags SampledImageIntegerSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags SampledImageDepthSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags SampledImageStencilSampleCounts;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags StorageImageSampleCounts;

    [NativeTypeName("uint32_t")]
    public uint MaxSampleMaskWords;

    [NativeTypeName("VkBool32")]
    public uint TimestampComputeAndGraphics;
    public float TimestampPeriod;

    [NativeTypeName("uint32_t")]
    public uint MaxClipDistances;

    [NativeTypeName("uint32_t")]
    public uint MaxCullDistances;

    [NativeTypeName("uint32_t")]
    public uint MaxCombinedClipAndCullDistances;

    [NativeTypeName("uint32_t")]
    public uint DiscreteQueuePriorities;

    [NativeTypeName("float[2]")]
    public PhysicalDeviceLimitsPointSizeRange PointSizeRange;

    [NativeTypeName("float[2]")]
    public PhysicalDeviceLimitsLineWidthRange LineWidthRange;
    public float PointSizeGranularity;
    public float LineWidthGranularity;

    [NativeTypeName("VkBool32")]
    public uint StrictLines;

    [NativeTypeName("VkBool32")]
    public uint StandardSampleLocations;

    [NativeTypeName("VkDeviceSize")]
    public ulong OptimalBufferCopyOffsetAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong OptimalBufferCopyRowPitchAlignment;

    [NativeTypeName("VkDeviceSize")]
    public ulong NonCoherentAtomSize;
}
