// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoDecodeAV1PictureInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("const StdVideoDecodeAV1PictureInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1PictureInfo* PStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    [SupportedApiProfile("vulkan")]
    public VideoDecodeAV1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint FrameHeaderOffset;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint TileCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PTileOffsets;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PTileSizes;
}
