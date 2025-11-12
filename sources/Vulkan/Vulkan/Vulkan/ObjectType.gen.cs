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
public enum ObjectType : uint
{
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [SupportedApiProfile("vulkan")]
    Instance = 1,

    [SupportedApiProfile("vulkan")]
    PhysicalDevice = 2,

    [SupportedApiProfile("vulkan")]
    Device = 3,

    [SupportedApiProfile("vulkan")]
    Queue = 4,

    [SupportedApiProfile("vulkan")]
    Semaphore = 5,

    [SupportedApiProfile("vulkan")]
    CommandBuffer = 6,

    [SupportedApiProfile("vulkan")]
    Fence = 7,

    [SupportedApiProfile("vulkan")]
    DeviceMemory = 8,

    [SupportedApiProfile("vulkan")]
    Buffer = 9,

    [SupportedApiProfile("vulkan")]
    Image = 10,

    [SupportedApiProfile("vulkan")]
    Event = 11,

    [SupportedApiProfile("vulkan")]
    QueryPool = 12,

    [SupportedApiProfile("vulkan")]
    BufferView = 13,

    [SupportedApiProfile("vulkan")]
    ImageView = 14,

    [SupportedApiProfile("vulkan")]
    ShaderModule = 15,

    [SupportedApiProfile("vulkan")]
    PipelineCache = 16,

    [SupportedApiProfile("vulkan")]
    PipelineLayout = 17,

    [SupportedApiProfile("vulkan")]
    RenderPass = 18,

    [SupportedApiProfile("vulkan")]
    Pipeline = 19,

    [SupportedApiProfile("vulkan")]
    DescriptorSetLayout = 20,

    [SupportedApiProfile("vulkan")]
    Sampler = 21,

    [SupportedApiProfile("vulkan")]
    DescriptorPool = 22,

    [SupportedApiProfile("vulkan")]
    DescriptorSet = 23,

    [SupportedApiProfile("vulkan")]
    Framebuffer = 24,

    [SupportedApiProfile("vulkan")]
    CommandPool = 25,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    DescriptorUpdateTemplate = 1000085000,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_COMPUTE_VERSION_1_1",
            "VK_COMPUTE_VERSION_1_2",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_1",
            "VK_GRAPHICS_VERSION_1_2",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_1",
            "VK_VERSION_1_2",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.1"
    )]
    SamplerYcbcrConversion = 1000156000,

    [SupportedApiProfile(
        "vulkan",
        [
            "VK_BASE_VERSION_1_3",
            "VK_BASE_VERSION_1_4",
            "VK_COMPUTE_VERSION_1_3",
            "VK_COMPUTE_VERSION_1_4",
            "VK_GRAPHICS_VERSION_1_3",
            "VK_GRAPHICS_VERSION_1_4",
            "VK_VERSION_1_3",
            "VK_VERSION_1_4",
        ],
        MinVersion = "1.3"
    )]
    PrivateDataSlot = 1000295000,

    [SupportedApiProfile("vulkan", ["VK_KHR_surface"])]
    SurfaceKHR = 1000000000,

    [SupportedApiProfile("vulkan", ["VK_KHR_swapchain"], ImpliesSets = ["VK_KHR_surface"])]
    SwapchainKHR = 1000001000,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplayKHR = 1000002000,

    [SupportedApiProfile("vulkan", ["VK_KHR_display"], ImpliesSets = ["VK_KHR_surface"])]
    DisplayModeKHR = 1000002001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_report"])]
    DebugReportCallbackEXT = 1000011000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionKHR = 1000023000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_video_queue"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_synchronization2", "VK_VERSION_1_3"]
    )]
    VideoSessionParametersKHR = 1000023001,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuModuleNVX = 1000029000,

    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    CuFunctionNVX = 1000029001,

    [SupportedApiProfile("vulkan", ["VK_EXT_debug_utils"])]
    DebugUtilsMessengerEXT = 1000128000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_acceleration_structure"],
        ImpliesSets = [
            "VK_KHR_deferred_host_operations+VK_VERSION_1_1+VK_EXT_descriptor_indexing+VK_KHR_buffer_device_address",
            "VK_KHR_deferred_host_operations+VK_VERSION_1_2",
        ]
    )]
    AccelerationStructureKHR = 1000150000,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_cache"])]
    ValidationCacheEXT = 1000160000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_ray_tracing"],
        ImpliesSets = [
            "VK_KHR_get_physical_device_properties2+VK_KHR_get_memory_requirements2",
            "VK_VERSION_1_1",
        ]
    )]
    AccelerationStructureNV = 1000165000,

    [SupportedApiProfile("vulkan", ["VK_INTEL_performance_query"])]
    PerformanceConfigurationIntel = 1000210000,

    [SupportedApiProfile("vulkan", ["VK_KHR_deferred_host_operations"])]
    DeferredOperationKHR = 1000268000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_device_generated_commands"],
        ImpliesSets = ["VK_VERSION_1_1+VK_KHR_buffer_device_address", "VK_VERSION_1_2"]
    )]
    IndirectCommandsLayoutNV = 1000277000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_FUCHSIA_buffer_collection"],
        ImpliesSets = [
            "VK_FUCHSIA_external_memory+VK_KHR_sampler_ycbcr_conversion",
            "VK_FUCHSIA_external_memory+VK_VERSION_1_1",
        ]
    )]
    BufferCollectionFuchsia = 1000366000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_opacity_micromap"],
        ImpliesSets = [
            "VK_KHR_acceleration_structure+VK_KHR_synchronization2",
            "VK_KHR_acceleration_structure+VK_VERSION_1_3",
        ]
    )]
    MicromapEXT = 1000396000,

    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorARM = 1000460000,

    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    TensorViewARM = 1000460001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_NV_optical_flow"],
        ImpliesSets = [
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_KHR_get_physical_device_properties2",
            "VK_KHR_format_feature_flags2+VK_KHR_synchronization2+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    OpticalFlowSessionNV = 1000464000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_shader_object"],
        ImpliesSets = [
            "VK_KHR_dynamic_rendering+VK_KHR_get_physical_device_properties2",
            "VK_KHR_dynamic_rendering+VK_VERSION_1_1",
            "VK_VERSION_1_3",
        ]
    )]
    ShaderEXT = 1000482000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_pipeline_binary"],
        ImpliesSets = [
            "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
            "VK_KHR_pipeline_binary+VK_VERSION_1_4",
        ]
    )]
    PipelineBinaryKHR = 1000483000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_ARM_data_graph"],
        ImpliesSets = ["VK_KHR_deferred_host_operations", "VK_KHR_maintenance5", "VK_VERSION_1_3"]
    )]
    DataGraphPipelineSessionARM = 1000507000,

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    ExternalComputeQueueNV = 1000556000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectCommandsLayoutEXT = 1000572000,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_device_generated_commands"],
        ImpliesSets = [
            "VK_KHR_maintenance5+VK_KHR_buffer_device_address",
            "VK_KHR_maintenance5+VK_VERSION_1_2",
            "VK_VERSION_1_3",
        ]
    )]
    IndirectExecutionSetEXT = 1000572001,

    [SupportedApiProfile("vulkan", ["VK_KHR_descriptor_update_template"])]
    DescriptorUpdateTemplateKHR = DescriptorUpdateTemplate,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_sampler_ycbcr_conversion"],
        ImpliesSets = [
            "VK_KHR_maintenance1+VK_KHR_bind_memory2+VK_KHR_get_memory_requirements2+VK_KHR_get_physical_device_properties2",
            "VK_VERSION_1_1",
        ]
    )]
    SamplerYcbcrConversionKHR = SamplerYcbcrConversion,

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_private_data"],
        ImpliesSets = [
            "VK_EXT_private_data+VK_KHR_get_physical_device_properties2",
            "VK_EXT_private_data+VK_VERSION_1_1",
        ]
    )]
    PrivateDataSlotEXT = PrivateDataSlot,
}
