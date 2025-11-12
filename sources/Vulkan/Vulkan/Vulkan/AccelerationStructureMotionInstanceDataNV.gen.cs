// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[StructLayout(LayoutKind.Explicit)]
[SupportedApiProfile("vulkan")]
public partial struct AccelerationStructureMotionInstanceDataNV
{
    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureInstanceKHR StaticInstance;

    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureMatrixMotionInstanceNV MatrixMotionInstance;

    [FieldOffset(0)]
    [SupportedApiProfile("vulkan")]
    public AccelerationStructureSRTMotionInstanceNV SrtMotionInstance;
}
