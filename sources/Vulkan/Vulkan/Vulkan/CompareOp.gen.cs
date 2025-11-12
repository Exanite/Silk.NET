// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum CompareOp : uint
{
    [SupportedApiProfile("vulkan")]
    Never = 0,

    [SupportedApiProfile("vulkan")]
    Less = 1,

    [SupportedApiProfile("vulkan")]
    Equal = 2,

    [SupportedApiProfile("vulkan")]
    LessOrEqual = 3,

    [SupportedApiProfile("vulkan")]
    Greater = 4,

    [SupportedApiProfile("vulkan")]
    NotEqual = 5,

    [SupportedApiProfile("vulkan")]
    GreaterOrEqual = 6,

    [SupportedApiProfile("vulkan")]
    Always = 7,
}
