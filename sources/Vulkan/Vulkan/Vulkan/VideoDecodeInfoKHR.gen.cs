// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoDecodeInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkVideoDecodeFlagsKHR")]
    public uint Flags;

    [NativeTypeName("VkBuffer")]
    public BufferHandle SrcBuffer;

    [NativeTypeName("VkDeviceSize")]
    public ulong SrcBufferOffset;

    [NativeTypeName("VkDeviceSize")]
    public ulong SrcBufferRange;
    public VideoPictureResourceInfoKHR DstPictureResource;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    public VideoReferenceSlotInfoKHR* PSetupReferenceSlot;

    [NativeTypeName("uint32_t")]
    public uint ReferenceSlotCount;

    [NativeTypeName("const VkVideoReferenceSlotInfoKHR *")]
    public VideoReferenceSlotInfoKHR* PReferenceSlots;
}
