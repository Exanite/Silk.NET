// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum PipelineExecutableStatisticFormatKHR : uint
{
    [SupportedApiProfile("vulkan")]
    Bool32KHR = 0,

    [SupportedApiProfile("vulkan")]
    Int64KHR = 1,

    [SupportedApiProfile("vulkan")]
    Uint64KHR = 2,

    [SupportedApiProfile("vulkan")]
    Float64KHR = 3,
}
