// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct IndirectCommandsLayoutCreateInfoNV
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkIndirectCommandsLayoutUsageFlagsNV")]
    public IndirectCommandsLayoutUsageFlagsNV Flags;
    public PipelineBindPoint PipelineBindPoint;

    [NativeTypeName("uint32_t")]
    public uint TokenCount;

    [NativeTypeName("const VkIndirectCommandsLayoutTokenNV *")]
    public IndirectCommandsLayoutTokenNV* PTokens;

    [NativeTypeName("uint32_t")]
    public uint StreamCount;

    [NativeTypeName("const uint32_t *")]
    public uint* PStreamStrides;
}
