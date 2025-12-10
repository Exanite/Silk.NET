// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoH265AspectRatioIdc : uint
{
    IdcUnspecified = 0,
    IdcSquare = 1,
    Idc12X11 = 2,
    Idc10X11 = 3,
    Idc16X11 = 4,
    Idc40X33 = 5,
    Idc24X11 = 6,
    Idc20X11 = 7,
    Idc32X11 = 8,
    Idc80X33 = 9,
    Idc18X11 = 10,
    Idc15X11 = 11,
    Idc64X33 = 12,
    Idc160X99 = 13,
    Idc4X3 = 14,
    Idc3X2 = 15,
    Idc2X1 = 16,
    IdcExtendedSar = 255,
}
