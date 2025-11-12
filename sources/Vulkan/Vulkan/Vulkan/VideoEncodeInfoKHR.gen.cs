// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoEncodeInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoEncodeFlagsKHR Flags;

    [NativeTypeName("VkBuffer")]
    [SupportedApiProfile("vulkan")]
    public BufferHandle DstBuffer;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong DstBufferOffset;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong DstBufferRange;

    [SupportedApiProfile("vulkan")]
    public VideoPictureResourceInfoKHR SrcPictureResource;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    [SupportedApiProfile("vulkan")]
    public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ReferenceSlotCount;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    [SupportedApiProfile("vulkan")]
    public VideoReferenceSlotInfoKHR* PReferenceSlots;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint PrecedingExternallyEncodedBytes;
}
