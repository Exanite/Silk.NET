// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct RenderPassMultiviewCreateInfo
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint SubpassCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PViewMasks;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DependencyCount;

    [NativeTypeName("const int32_t *")]
    [SupportedApiProfile("vulkan")]
    public int* PViewOffsets;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint CorrelationMaskCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PCorrelationMasks;
}
