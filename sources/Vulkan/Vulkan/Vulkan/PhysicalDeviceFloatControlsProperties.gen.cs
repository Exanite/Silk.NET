// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PhysicalDeviceFloatControlsProperties
{
    public StructureType SType;
    public void* PNext;
    public ShaderFloatControlsIndependence DenormBehaviorIndependence;
    public ShaderFloatControlsIndependence RoundingModeIndependence;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderSignedZeroInfNanPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormPreserveFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderDenormFlushToZeroFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTEFloat64;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat16;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat32;

    [NativeTypeName("VkBool32")]
    public uint ShaderRoundingModeRTZFloat64;
}
