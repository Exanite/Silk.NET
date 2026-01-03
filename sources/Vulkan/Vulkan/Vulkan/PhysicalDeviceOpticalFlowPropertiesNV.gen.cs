// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceOpticalFlowPropertiesNV
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public OpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;

    [NativeTypeName("VkOpticalFlowGridSizeFlagsNV")]
    public OpticalFlowGridSizeFlagsNV SupportedHintGridSizes;

    [NativeTypeName("VkBool32")]
    public uint HintSupported;

    [NativeTypeName("VkBool32")]
    public uint CostSupported;

    [NativeTypeName("VkBool32")]
    public uint BidirectionalFlowSupported;

    [NativeTypeName("VkBool32")]
    public uint GlobalFlowSupported;

    [NativeTypeName("uint32_t")]
    public uint MinWidth;

    [NativeTypeName("uint32_t")]
    public uint MinHeight;

    [NativeTypeName("uint32_t")]
    public uint MaxWidth;

    [NativeTypeName("uint32_t")]
    public uint MaxHeight;

    [NativeTypeName("uint32_t")]
    public uint MaxNumRegionsOfInterest;
}
