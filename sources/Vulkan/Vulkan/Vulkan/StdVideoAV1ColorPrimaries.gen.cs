// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoAV1ColorPrimaries : uint
{
    Bt709 = 1,
    Unspecified = 2,
    Bt470M = 4,
    Bt470BG = 5,
    Bt601 = 6,
    Smpte240 = 7,
    GenericFilm = 8,
    Bt2020 = 9,
    Xyz = 10,
    Smpte431 = 11,
    Smpte432 = 12,
    Ebu3213 = 22,
    BtUnspecified = Unspecified,
}
