// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoDecodeAV1PictureInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("const StdVideoDecodeAV1PictureInfo *")]
    public StdVideoDecodeAV1PictureInfo* PStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    public VideoDecodeAV1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("uint32_t")]
    public uint FrameHeaderOffset;

    [NativeTypeName("uint32_t")]
    public uint TileCount;

    [NativeTypeName("const uint32_t *")]
    public uint* PTileOffsets;

    [NativeTypeName("const uint32_t *")]
    public uint* PTileSizes;
}
