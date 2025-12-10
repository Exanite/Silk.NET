// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeAV1PictureInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;
    public VideoEncodeAV1PredictionModeKHR PredictionMode;
    public VideoEncodeAV1RateControlGroupKHR RateControlGroup;

    [NativeTypeName("uint32_t")]
    public uint ConstantQIndex;

    [NativeTypeName("const StdVideoEncodeAV1PictureInfo *")]
    public StdVideoEncodeAV1PictureInfo* PStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    public VideoEncodeAV1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("VkBool32")]
    public uint PrimaryReferenceCdfOnly;

    [NativeTypeName("VkBool32")]
    public uint GenerateObuExtensionHeader;
}
