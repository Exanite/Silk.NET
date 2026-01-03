// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoAV1MatrixCoefficients : uint
{
    Identity = 0,
    Bt709 = 1,
    Unspecified = 2,
    Reserved3 = 3,
    Fcc = 4,
    Bt470BG = 5,
    Bt601 = 6,
    Smpte240 = 7,
    SmpteYcgco = 8,
    Bt2020Ncl = 9,
    Bt2020Cl = 10,
    Smpte2085 = 11,
    ChromatNcl = 12,
    ChromatCl = 13,
    Ictcp = 14,
}
