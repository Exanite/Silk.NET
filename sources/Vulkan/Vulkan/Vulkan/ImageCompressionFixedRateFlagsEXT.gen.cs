// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ImageCompressionFixedRateFlagsEXT : uint
{
    RateNone = 0x0,
    Rate1BpcBit = 0x1,
    Rate2BpcBit = 0x2,
    Rate3BpcBit = 0x4,
    Rate4BpcBit = 0x8,
    Rate5BpcBit = 0x10,
    Rate6BpcBit = 0x20,
    Rate7BpcBit = 0x40,
    Rate8BpcBit = 0x80,
    Rate9BpcBit = 0x100,
    Rate10BpcBit = 0x200,
    Rate11BpcBit = 0x400,
    Rate12BpcBit = 0x800,
    Rate13BpcBit = 0x1000,
    Rate14BpcBit = 0x2000,
    Rate15BpcBit = 0x4000,
    Rate16BpcBit = 0x8000,
    Rate17BpcBit = 0x10000,
    Rate18BpcBit = 0x20000,
    Rate19BpcBit = 0x40000,
    Rate20BpcBit = 0x80000,
    Rate21BpcBit = 0x100000,
    Rate22BpcBit = 0x200000,
    Rate23BpcBit = 0x400000,
    Rate24BpcBit = 0x800000,
}
