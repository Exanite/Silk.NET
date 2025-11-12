// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceSampleLocationsPropertiesEXT
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkSampleCountFlags")]
    [SupportedApiProfile("vulkan")]
    public SampleCountFlags SampleLocationSampleCounts;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxSampleLocationGridSize;

    [NativeTypeName("float[2]")]
    [SupportedApiProfile("vulkan")]
    public PhysicalDeviceSampleLocationsPropertiesEXTSampleLocationCoordinateRange SampleLocationCoordinateRange;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SampleLocationSubPixelBits;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> VariableSampleLocations;
}
