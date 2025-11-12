// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct MemoryToImageCopy
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PHostPointer;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MemoryRowLength;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MemoryImageHeight;

    [SupportedApiProfile("vulkan")]
    public ImageSubresourceLayers ImageSubresource;

    [SupportedApiProfile("vulkan")]
    public Offset3D ImageOffset;

    [SupportedApiProfile("vulkan")]
    public Extent3D ImageExtent;
}
