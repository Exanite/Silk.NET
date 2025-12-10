// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
public partial struct AccelerationStructureMotionInstanceDataNV
{
    [FieldOffset(0)]
    public AccelerationStructureInstanceKHR StaticInstance;

    [FieldOffset(0)]
    public AccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;

    [FieldOffset(0)]
    public AccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
}
