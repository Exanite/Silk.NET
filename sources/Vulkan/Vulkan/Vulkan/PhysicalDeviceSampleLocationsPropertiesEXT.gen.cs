// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceSampleLocationsPropertiesEXT
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkSampleCountFlags")]
    public SampleCountFlags SampleLocationSampleCounts;
    public Extent2D MaxSampleLocationGridSize;

    [NativeTypeName("float[2]")]
    public PhysicalDeviceSampleLocationsPropertiesEXTSampleLocationCoordinateRange SampleLocationCoordinateRange;

    [NativeTypeName("uint32_t")]
    public uint SampleLocationSubPixelBits;

    [NativeTypeName("VkBool32")]
    public uint VariableSampleLocations;
}
