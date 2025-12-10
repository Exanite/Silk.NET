// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public partial struct PerformanceCounterResultKHR
{
    [FieldOffset(0)]
    [NativeTypeName("int32_t")]
    public int Int32;

    [FieldOffset(0)]
    [NativeTypeName("int64_t")]
    public long Int64;

    [FieldOffset(0)]
    [NativeTypeName("uint32_t")]
    public uint Uint32;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    public ulong Uint64;

    [FieldOffset(0)]
    public float Float32;

    [FieldOffset(0)]
    public double Float64;
}
