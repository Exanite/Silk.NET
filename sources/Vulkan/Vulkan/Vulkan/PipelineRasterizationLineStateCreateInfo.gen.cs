// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct PipelineRasterizationLineStateCreateInfo
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public LineRasterizationMode LineRasterizationMode;

    [NativeTypeName("VkBool32")]
    public uint StippledLineEnable;

    [NativeTypeName("uint32_t")]
    public uint LineStippleFactor;

    [NativeTypeName("uint16_t")]
    public ushort LineStipplePattern;
}
