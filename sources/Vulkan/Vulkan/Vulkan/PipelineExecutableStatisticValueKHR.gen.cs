// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public partial struct PipelineExecutableStatisticValueKHR
{
    [FieldOffset(0)]
    [NativeTypeName("VkBool32")]
    public uint B32;

    [FieldOffset(0)]
    [NativeTypeName("int64_t")]
    public long I64;

    [FieldOffset(0)]
    [NativeTypeName("uint64_t")]
    public ulong U64;

    [FieldOffset(0)]
    public double F64;
}
