// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceOpticalFlowPropertiesNV
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public OpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    [SupportedApiProfile("vulkan")]
    public OpticalFlowGridSizeFlagsNV SupportedHintGridSizes;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> HintSupported;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> CostSupported;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> BidirectionalFlowSupported;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> GlobalFlowSupported;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinWidth;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MinHeight;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxWidth;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxHeight;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxNumRegionsOfInterest;
}
