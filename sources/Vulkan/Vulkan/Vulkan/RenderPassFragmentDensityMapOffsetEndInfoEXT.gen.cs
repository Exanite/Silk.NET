// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.Vulkan;

public unsafe partial struct RenderPassFragmentDensityMapOffsetEndInfoEXT
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint FragmentDensityOffsetCount;

    [NativeTypeName("const VkOffset2D *")]
    public Offset2D* PFragmentDensityOffsets;
}
