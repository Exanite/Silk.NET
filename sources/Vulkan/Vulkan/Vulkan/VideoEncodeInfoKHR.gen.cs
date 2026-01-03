// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkVideoEncodeFlagsKHR")]
    public VideoEncodeFlagsKHR Flags;

    [NativeTypeName("VkBuffer")]
    public BufferHandle DstBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong DstBufferOffset;

    [NativeTypeName("VkDeviceSize")]
    public ulong DstBufferRange;
    public VideoPictureResourceInfoKHR SrcPictureResource;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;

    [NativeTypeName("uint32_t")]
    public uint ReferenceSlotCount;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    public VideoReferenceSlotInfoKHR* PReferenceSlots;

    [NativeTypeName("uint32_t")]
    public uint PrecedingExternallyEncodedBytes;
}
