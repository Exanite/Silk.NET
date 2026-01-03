// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct PerformanceValueDataINTEL
{
    [FieldOffset(0)]
    [NativeTypeName("uint32_t")]
    public uint Value32;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    public ulong Value64;

    [FieldOffset(0)]
    public float ValueFloat;

    [FieldOffset(0)]
    [NativeTypeName("VkBool32")]
    public uint ValueBool;

    [FieldOffset(0)]
    [NativeTypeName("const char *")]
    public sbyte* ValueString;
}
