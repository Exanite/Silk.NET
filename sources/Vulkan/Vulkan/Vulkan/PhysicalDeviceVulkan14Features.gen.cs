// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceVulkan14Features
{
    public StructureType SType;
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint GlobalPriorityQuery;

    [NativeTypeName("VkBool32")]
    public uint ShaderSubgroupRotate;

    [NativeTypeName("VkBool32")]
    public uint ShaderSubgroupRotateClustered;

    [NativeTypeName("VkBool32")]
    public uint ShaderFloatControls2;

    [NativeTypeName("VkBool32")]
    public uint ShaderExpectAssume;

    [NativeTypeName("VkBool32")]
    public uint RectangularLines;

    [NativeTypeName("VkBool32")]
    public uint BresenhamLines;

    [NativeTypeName("VkBool32")]
    public uint SmoothLines;

    [NativeTypeName("VkBool32")]
    public uint StippledRectangularLines;

    [NativeTypeName("VkBool32")]
    public uint StippledBresenhamLines;

    [NativeTypeName("VkBool32")]
    public uint StippledSmoothLines;

    [NativeTypeName("VkBool32")]
    public uint VertexAttributeInstanceRateDivisor;

    [NativeTypeName("VkBool32")]
    public uint VertexAttributeInstanceRateZeroDivisor;

    [NativeTypeName("VkBool32")]
    public uint IndexTypeUint8;

    [NativeTypeName("VkBool32")]
    public uint DynamicRenderingLocalRead;

    [NativeTypeName("VkBool32")]
    public uint Maintenance5;

    [NativeTypeName("VkBool32")]
    public uint Maintenance6;

    [NativeTypeName("VkBool32")]
    public uint PipelineProtectedAccess;

    [NativeTypeName("VkBool32")]
    public uint PipelineRobustness;

    [NativeTypeName("VkBool32")]
    public uint HostImageCopy;

    [NativeTypeName("VkBool32")]
    public uint PushDescriptor;
}
