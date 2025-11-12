// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct SamplerCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkSamplerCreateFlags")]
    [SupportedApiProfile("vulkan")]
    public SamplerCreateFlags Flags;

    [SupportedApiProfile("vulkan")]
    public Filter MagFilter;

    [SupportedApiProfile("vulkan")]
    public Filter MinFilter;

    [SupportedApiProfile("vulkan")]
    public SamplerMipmapMode MipmapMode;

    [SupportedApiProfile("vulkan")]
    public SamplerAddressMode AddressModeU;

    [SupportedApiProfile("vulkan")]
    public SamplerAddressMode AddressModeV;

    [SupportedApiProfile("vulkan")]
    public SamplerAddressMode AddressModeW;

    [SupportedApiProfile("vulkan")]
    public float MipLodBias;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> AnisotropyEnable;

    [SupportedApiProfile("vulkan")]
    public float MaxAnisotropy;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> CompareEnable;

    [SupportedApiProfile("vulkan")]
    public CompareOp CompareOp;

    [SupportedApiProfile(
        "vulkan",
        ["VK_EXT_image_view_min_lod"],
        ImpliesSets = [
            "VK_EXT_image_view_min_lod+VK_KHR_get_physical_device_properties2",
            "VK_EXT_image_view_min_lod+VK_VERSION_1_1",
        ]
    )]
    public float MinLod;

    [SupportedApiProfile("vulkan")]
    public float MaxLod;

    [SupportedApiProfile("vulkan")]
    public BorderColor BorderColor;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> UnnormalizedCoordinates;
}
