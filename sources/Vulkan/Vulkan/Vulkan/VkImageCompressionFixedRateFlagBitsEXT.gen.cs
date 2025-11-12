// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
[Flags]
public enum ImageCompressionFixedRateFlagsEXT : uint
{
    [SupportedApiProfile("vulkan")]
    RateNoneEXT = 0,

    [SupportedApiProfile("vulkan")]
    Rate1BpcBitEXT = 0x00000001,

    [SupportedApiProfile("vulkan")]
    Rate2BpcBitEXT = 0x00000002,

    [SupportedApiProfile("vulkan")]
    Rate3BpcBitEXT = 0x00000004,

    [SupportedApiProfile("vulkan")]
    Rate4BpcBitEXT = 0x00000008,

    [SupportedApiProfile("vulkan")]
    Rate5BpcBitEXT = 0x00000010,

    [SupportedApiProfile("vulkan")]
    Rate6BpcBitEXT = 0x00000020,

    [SupportedApiProfile("vulkan")]
    Rate7BpcBitEXT = 0x00000040,

    [SupportedApiProfile("vulkan")]
    Rate8BpcBitEXT = 0x00000080,

    [SupportedApiProfile("vulkan")]
    Rate9BpcBitEXT = 0x00000100,

    [SupportedApiProfile("vulkan")]
    Rate10BpcBitEXT = 0x00000200,

    [SupportedApiProfile("vulkan")]
    Rate11BpcBitEXT = 0x00000400,

    [SupportedApiProfile("vulkan")]
    Rate12BpcBitEXT = 0x00000800,

    [SupportedApiProfile("vulkan")]
    Rate13BpcBitEXT = 0x00001000,

    [SupportedApiProfile("vulkan")]
    Rate14BpcBitEXT = 0x00002000,

    [SupportedApiProfile("vulkan")]
    Rate15BpcBitEXT = 0x00004000,

    [SupportedApiProfile("vulkan")]
    Rate16BpcBitEXT = 0x00008000,

    [SupportedApiProfile("vulkan")]
    Rate17BpcBitEXT = 0x00010000,

    [SupportedApiProfile("vulkan")]
    Rate18BpcBitEXT = 0x00020000,

    [SupportedApiProfile("vulkan")]
    Rate19BpcBitEXT = 0x00040000,

    [SupportedApiProfile("vulkan")]
    Rate20BpcBitEXT = 0x00080000,

    [SupportedApiProfile("vulkan")]
    Rate21BpcBitEXT = 0x00100000,

    [SupportedApiProfile("vulkan")]
    Rate22BpcBitEXT = 0x00200000,

    [SupportedApiProfile("vulkan")]
    Rate23BpcBitEXT = 0x00400000,

    [SupportedApiProfile("vulkan")]
    Rate24BpcBitEXT = 0x00800000,
}
