// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceMaintenance5Properties
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint EarlyFragmentMultisampleCoverageAfterSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint EarlyFragmentSampleMaskTestBeforeSampleCounting;

    [NativeTypeName("VkBool32")]
    public uint DepthStencilSwizzleOneSupport;

    [NativeTypeName("VkBool32")]
    public uint PolygonModePointSize;

    [NativeTypeName("VkBool32")]
    public uint NonStrictSinglePixelWideLinesUseParallelogram;

    [NativeTypeName("VkBool32")]
    public uint NonStrictWideLinesUseParallelogram;
}
