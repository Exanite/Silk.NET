// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoCodecOperationFlagsKHR : uint
{
    None = 0x0,
    EncodeH264Bit = 0x10000,
    EncodeH265Bit = 0x20000,
    DecodeH264Bit = 0x1,
    DecodeH265Bit = 0x2,
    DecodeAv1Bit = 0x4,
    EncodeAv1Bit = 0x40000,
    DecodeVp9Bit = 0x8,
}
