// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum DebugReportObjectTypeEXT : uint
{
    Unknown = 0,
    Instance = 1,
    PhysicalDevice = 2,
    Device = 3,
    Queue = 4,
    Semaphore = 5,
    CommandBuffer = 6,
    Fence = 7,
    DeviceMemory = 8,
    Buffer = 9,
    Image = 10,
    Event = 11,
    QueryPool = 12,
    BufferView = 13,
    ImageView = 14,
    ShaderModule = 15,
    PipelineCache = 16,
    PipelineLayout = 17,
    RenderPass = 18,
    Pipeline = 19,
    DescriptorSetLayout = 20,
    Sampler = 21,
    DescriptorPool = 22,
    DescriptorSet = 23,
    Framebuffer = 24,
    CommandPool = 25,
    SurfaceKhr = 26,
    SwapchainKhr = 27,
    DebugReportCallbackExt = 28,
    DisplayKhr = 29,
    DisplayModeKhr = 30,
    ValidationCacheExt = 33,
    SamplerYcbcrConversion = 1000156000,
    DescriptorUpdateTemplate = 1000085000,
    CuModuleNvx = 1000029000,
    CuFunctionNvx = 1000029001,
    AccelerationStructureKhr = 1000150000,
    AccelerationStructureNv = 1000165000,
    CudaModuleNv = 1000307000,
    CudaFunctionNv = 1000307001,
    BufferCollectionFuchsia = 1000366000,
    DescriptorUpdateTemplateKhr = DescriptorUpdateTemplate,
    SamplerYcbcrConversionKhr = SamplerYcbcrConversion,
}
