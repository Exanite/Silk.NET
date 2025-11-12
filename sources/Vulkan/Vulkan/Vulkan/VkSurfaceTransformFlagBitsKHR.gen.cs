// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum SurfaceTransformFlagsKHR : uint
{
    None = 0,

    [SupportedApiProfile("vulkan")]
    IdentityBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    Rotate90BitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    Rotate180BitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    Rotate270BitKHR = 0x00000008,

    [SupportedApiProfile("vulkan")]
    HorizontalMirrorBitKHR = 0x00000010,

    [SupportedApiProfile("vulkan")]
    HorizontalMirrorRotate90BitKHR = 0x00000020,

    [SupportedApiProfile("vulkan")]
    HorizontalMirrorRotate180BitKHR = 0x00000040,

    [SupportedApiProfile("vulkan")]
    HorizontalMirrorRotate270BitKHR = 0x00000080,

    [SupportedApiProfile("vulkan")]
    InheritBitKHR = 0x00000100,
}
