// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ImageAspectFlags : uint
{
    ColorBit = 0x1,
    DepthBit = 0x2,
    StencilBit = 0x4,
    MetadataBit = 0x8,
    Plane0Bit = 0x10,
    Plane1Bit = 0x20,
    Plane2Bit = 0x40,
    None = 0x0,
    MemoryPlane0BitEXT = 0x80,
    MemoryPlane1BitEXT = 0x100,
    MemoryPlane2BitEXT = 0x200,
    MemoryPlane3BitEXT = 0x400,
    Plane0BitKHR = Plane0Bit,
    Plane1BitKHR = Plane1Bit,
    Plane2BitKHR = Plane2Bit,
    NoneKHR = None,
}
