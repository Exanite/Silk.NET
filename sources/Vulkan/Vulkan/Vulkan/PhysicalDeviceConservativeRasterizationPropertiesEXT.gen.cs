// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceConservativeRasterizationPropertiesEXT
{
    public StructureType SType;
    public void* PNext;
    public float PrimitiveOverestimationSize;
    public float MaxExtraPrimitiveOverestimationSize;
    public float ExtraPrimitiveOverestimationSizeGranularity;

    [NativeTypeName("VkBool32")]
    public uint PrimitiveUnderestimation;

    [NativeTypeName("VkBool32")]
    public uint ConservativePointAndLineRasterization;

    [NativeTypeName("VkBool32")]
    public uint DegenerateTrianglesRasterized;

    [NativeTypeName("VkBool32")]
    public uint DegenerateLinesRasterized;

    [NativeTypeName("VkBool32")]
    public uint FullyCoveredFragmentShaderInputVariable;

    [NativeTypeName("VkBool32")]
    public uint ConservativeRasterizationPostDepthCoverage;
}
