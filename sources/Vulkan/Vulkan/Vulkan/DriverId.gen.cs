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
public enum DriverId : uint
{
    [SupportedApiProfile("vulkan")]
    AmdProprietary = 1,

    [SupportedApiProfile("vulkan")]
    AmdOpenSource = 2,

    [SupportedApiProfile("vulkan")]
    MesaRadv = 3,

    [SupportedApiProfile("vulkan")]
    NvidiaProprietary = 4,

    [SupportedApiProfile("vulkan")]
    IntelProprietaryWindows = 5,

    [SupportedApiProfile("vulkan")]
    IntelOpenSourceMESA = 6,

    [SupportedApiProfile("vulkan")]
    ImaginationProprietary = 7,

    [SupportedApiProfile("vulkan")]
    QualcommProprietary = 8,

    [SupportedApiProfile("vulkan")]
    ArmProprietary = 9,

    [SupportedApiProfile("vulkan")]
    GoogleSwiftshader = 10,

    [SupportedApiProfile("vulkan")]
    GgpProprietary = 11,

    [SupportedApiProfile("vulkan")]
    BroadcomProprietary = 12,

    [SupportedApiProfile("vulkan")]
    MesaLlvmpipe = 13,

    [SupportedApiProfile("vulkan")]
    Moltenvk = 14,

    [SupportedApiProfile("vulkan")]
    CoreaviProprietary = 15,

    [SupportedApiProfile("vulkan")]
    JuiceProprietary = 16,

    [SupportedApiProfile("vulkan")]
    VerisiliconProprietary = 17,

    [SupportedApiProfile("vulkan")]
    MesaTurnip = 18,

    [SupportedApiProfile("vulkan")]
    MesaV3Dv = 19,

    [SupportedApiProfile("vulkan")]
    MesaPanvk = 20,

    [SupportedApiProfile("vulkan")]
    SamsungProprietary = 21,

    [SupportedApiProfile("vulkan")]
    MesaVenus = 22,

    [SupportedApiProfile("vulkan")]
    MesaDozen = 23,

    [SupportedApiProfile("vulkan")]
    MesaNvk = 24,

    [SupportedApiProfile("vulkan")]
    ImaginationOpenSourceMESA = 25,

    [SupportedApiProfile("vulkan")]
    MesaHoneykrisp = 26,

    [SupportedApiProfile("vulkan")]
    VulkanScEmulationOnVulkan = 27,

    [SupportedApiProfile("vulkan")]
    MesaKosmickrisp = 28,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    AmdProprietaryKHR = AmdProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    AmdOpenSourceKHR = AmdOpenSource,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    MesaRadvKHR = MesaRadv,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    NvidiaProprietaryKHR = NvidiaProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    IntelProprietaryWindowsKHR = IntelProprietaryWindows,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    IntelOpenSourceMesaKHR = IntelOpenSourceMESA,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    ImaginationProprietaryKHR = ImaginationProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    QualcommProprietaryKHR = QualcommProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    ArmProprietaryKHR = ArmProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    GoogleSwiftshaderKHR = GoogleSwiftshader,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    GgpProprietaryKHR = GgpProprietary,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_driver_properties"],
        ImpliesSets = [
            "VK_KHR_driver_properties+VK_KHR_get_physical_device_properties2",
            "VK_KHR_driver_properties+VK_VERSION_1_1",
        ]
    )]
    BroadcomProprietaryKHR = BroadcomProprietary,
}
