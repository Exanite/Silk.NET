// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PerformanceCounterDescriptionKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public PerformanceCounterDescriptionFlagsKHR Flags;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PerformanceCounterDescriptionKHRName Name;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PerformanceCounterDescriptionKHRCategory Category;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PerformanceCounterDescriptionKHRDescription Description;
}
