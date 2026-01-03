// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoAV1TransferCharacteristics : uint
{
    Reserved0 = 0,
    Bt709 = 1,
    Unspecified = 2,
    Reserved3 = 3,
    Bt470M = 4,
    Bt470BG = 5,
    Bt601 = 6,
    Smpte240 = 7,
    Linear = 8,
    Log100 = 9,
    Log100Sqrt10 = 10,
    Iec61966 = 11,
    Bt1361 = 12,
    Srgb = 13,
    Bt2020X10Bit = 14,
    Bt2020X12Bit = 15,
    Smpte2084 = 16,
    Smpte428 = 17,
    Hlg = 18,
}
