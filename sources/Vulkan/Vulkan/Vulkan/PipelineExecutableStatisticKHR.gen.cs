// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineExecutableStatisticKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PipelineExecutableStatisticKHRName Name;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan")]
    public PipelineExecutableStatisticKHRDescription Description;

    [SupportedApiProfile("vulkan")]
    public PipelineExecutableStatisticFormatKHR Format;

    [SupportedApiProfile("vulkan")]
    public PipelineExecutableStatisticValueKHR Value;
}
