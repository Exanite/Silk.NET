// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum SurfaceTransformFlagsKHR : uint
{
    None = 0x0,
    IdentityBit = 0x1,
    Rotate90Bit = 0x2,
    Rotate180Bit = 0x4,
    Rotate270Bit = 0x8,
    HorizontalMirrorBit = 0x10,
    HorizontalMirrorRotate90Bit = 0x20,
    HorizontalMirrorRotate180Bit = 0x40,
    HorizontalMirrorRotate270Bit = 0x80,
    InheritBit = 0x100,
}
