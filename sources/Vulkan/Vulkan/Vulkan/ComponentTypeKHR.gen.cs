// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum ComponentTypeKHR : uint
{
    Float16 = 0,
    Float32 = 1,
    Float64 = 2,
    Sint8 = 3,
    Sint16 = 4,
    Sint32 = 5,
    Sint64 = 6,
    Uint8 = 7,
    Uint16 = 8,
    Uint32 = 9,
    Uint64 = 10,
    Bfloat16 = 1000141000,
    Sint8PackedNV = 1000491000,
    Uint8PackedNV = 1000491001,
    Float8E4M3EXT = 1000491002,
    Float8E5M2EXT = 1000491003,
    Float16NV = Float16,
    Float32NV = Float32,
    Float64NV = Float64,
    Sint8NV = Sint8,
    Sint16NV = Sint16,
    Sint32NV = Sint32,
    Sint64NV = Sint64,
    Uint8NV = Uint8,
    Uint16NV = Uint16,
    Uint32NV = Uint32,
    Uint64NV = Uint64,
    FloatE4M3NV = Float8E4M3EXT,
    FloatE5M2NV = Float8E5M2EXT,
}
