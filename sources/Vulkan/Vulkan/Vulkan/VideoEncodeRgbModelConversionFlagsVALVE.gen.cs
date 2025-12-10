// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoEncodeRgbModelConversionFlagsVALVE : uint
{
    None = 0x0,
    RgbIdentityBit = 0x1,
    YcbcrIdentityBit = 0x2,
    Ycbcr709Bit = 0x4,
    Ycbcr601Bit = 0x8,
    Ycbcr2020Bit = 0x10,
}
