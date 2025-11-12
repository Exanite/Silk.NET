// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum OpticalFlowSessionBindingPointNV : uint
{
    [SupportedApiProfile("vulkan")]
    UnknownNV = 0,

    [SupportedApiProfile("vulkan")]
    InputNV = 1,

    [SupportedApiProfile("vulkan")]
    ReferenceNV = 2,

    [SupportedApiProfile("vulkan")]
    HintNV = 3,

    [SupportedApiProfile("vulkan")]
    FlowVectorNV = 4,

    [SupportedApiProfile("vulkan")]
    BackwardFlowVectorNV = 5,

    [SupportedApiProfile("vulkan")]
    CostNV = 6,

    [SupportedApiProfile("vulkan")]
    BackwardCostNV = 7,

    [SupportedApiProfile("vulkan")]
    GlobalFlowNV = 8,
}
