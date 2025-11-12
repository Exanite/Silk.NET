// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct DisplaySurfaceCreateInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDisplaySurfaceCreateFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public uint Flags;

    [NativeTypeName("VkDisplayModeKHR")]
    [SupportedApiProfile("vulkan")]
    public DisplayModeKHRHandle DisplayMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PlaneIndex;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PlaneStackIndex;

    [SupportedApiProfile("vulkan")]
    public SurfaceTransformFlagsKHR Transform;

    [SupportedApiProfile("vulkan")]
    public float GlobalAlpha;

    [SupportedApiProfile("vulkan")]
    public DisplayPlaneAlphaFlagsKHR AlphaMode;

    [SupportedApiProfile("vulkan")]
    public Extent2D ImageExtent;
}
