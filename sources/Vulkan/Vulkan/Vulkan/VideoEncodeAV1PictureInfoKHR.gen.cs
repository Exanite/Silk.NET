// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeAV1PictureInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1PredictionModeKHR PredictionMode;

    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1RateControlGroupKHR RateControlGroup;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ConstantQIndex;

    [NativeTypeName("const StdVideoEncodeAV1PictureInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1PictureInfo* PStdPictureInfo;

    [NativeTypeName("int32_t[7]")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeAV1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> PrimaryReferenceCdfOnly;

    [NativeTypeName("VkBool32")]
    [SupportedApiProfile("vulkan")]
    public MaybeBool<uint> GenerateObuExtensionHeader;
}
