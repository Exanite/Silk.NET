// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum DebugReportObjectTypeEXT : uint
{
    [SupportedApiProfile("vulkan")]
    UnknownEXT = 0,

    [SupportedApiProfile("vulkan")]
    InstanceEXT = 1,

    [SupportedApiProfile("vulkan")]
    PhysicalDeviceEXT = 2,

    [SupportedApiProfile("vulkan")]
    DeviceEXT = 3,

    [SupportedApiProfile("vulkan")]
    QueueEXT = 4,

    [SupportedApiProfile("vulkan")]
    SemaphoreEXT = 5,

    [SupportedApiProfile("vulkan")]
    CommandBufferEXT = 6,

    [SupportedApiProfile("vulkan")]
    FenceEXT = 7,

    [SupportedApiProfile("vulkan")]
    DeviceMemoryEXT = 8,

    [SupportedApiProfile("vulkan")]
    BufferEXT = 9,

    [SupportedApiProfile("vulkan")]
    ImageEXT = 10,

    [SupportedApiProfile("vulkan")]
    EventEXT = 11,

    [SupportedApiProfile("vulkan")]
    QueryPoolEXT = 12,

    [SupportedApiProfile("vulkan")]
    BufferViewEXT = 13,

    [SupportedApiProfile("vulkan")]
    ImageViewEXT = 14,

    [SupportedApiProfile("vulkan")]
    ShaderModuleEXT = 15,

    [SupportedApiProfile("vulkan")]
    PipelineCacheEXT = 16,

    [SupportedApiProfile("vulkan")]
    PipelineLayoutEXT = 17,

    [SupportedApiProfile("vulkan")]
    RenderPassEXT = 18,

    [SupportedApiProfile("vulkan")]
    PipelineEXT = 19,

    [SupportedApiProfile("vulkan")]
    DescriptorSetLayoutEXT = 20,

    [SupportedApiProfile("vulkan")]
    SamplerEXT = 21,

    [SupportedApiProfile("vulkan")]
    DescriptorPoolEXT = 22,

    [SupportedApiProfile("vulkan")]
    DescriptorSetEXT = 23,

    [SupportedApiProfile("vulkan")]
    FramebufferEXT = 24,

    [SupportedApiProfile("vulkan")]
    CommandPoolEXT = 25,

    [SupportedApiProfile("vulkan")]
    SurfaceKhrEXT = 26,

    [SupportedApiProfile("vulkan")]
    SwapchainKhrEXT = 27,

    [SupportedApiProfile("vulkan")]
    DebugReportCallbackExtEXT = 28,

    [SupportedApiProfile("vulkan")]
    DisplayKhrEXT = 29,

    [SupportedApiProfile("vulkan")]
    DisplayModeKhrEXT = 30,

    [SupportedApiProfile("vulkan")]
    ValidationCacheExtEXT = 33,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    SamplerYcbcrConversionEXT = 1000156000,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report", "VK_VERSION_1_1"], RequireAll = true)]
    DescriptorUpdateTemplateEXT = 1000085000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuModuleNvxEXT = 1000029000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NVX_binary_import"],
        RequireAll = true
    )]
    CuFunctionNvxEXT = 1000029001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ],
        RequireAll = true
    )]
    AccelerationStructureKhrEXT = 1000150000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    AccelerationStructureNvEXT = 1000165000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaModuleNvEXT = 1000307000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_NV_cuda_kernel_launch"],
        ImpliesSets = [
            "VK_NV_cuda_kernel_launch+VK_KHR_get_physical_device_properties2",
            "VK_NV_cuda_kernel_launch+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    CudaFunctionNvEXT = 1000307001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    BufferCollectionFuchsiaEXT = 1000366000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_descriptor_update_template"],
        RequireAll = true
    )]
    DescriptorUpdateTemplateKhrEXT = DescriptorUpdateTemplateEXT,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_debug_report", "VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ],
        RequireAll = true
    )]
    SamplerYcbcrConversionKhrEXT = SamplerYcbcrConversionEXT,
}
