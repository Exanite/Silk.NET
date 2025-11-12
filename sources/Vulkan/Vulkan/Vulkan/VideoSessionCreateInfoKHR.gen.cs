// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct VideoSessionCreateInfoKHR
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueFamilyIndex;

    [NativeTypeName("VkVideoSessionCreateFlagsKHR")]
    [SupportedApiProfile("vulkan")]
    public VideoSessionCreateFlagsKHR Flags;

    [NativeTypeName("const VkVideoProfileInfoKHR *")]
    [SupportedApiProfile("vulkan")]
    public VideoProfileInfoKHR* PVideoProfile;

    [SupportedApiProfile("vulkan")]
    public Format PictureFormat;

    [SupportedApiProfile("vulkan")]
    public Extent2D MaxCodedExtent;

    [SupportedApiProfile("vulkan")]
    public Format ReferencePictureFormat;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxDpbSlots;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint MaxActiveReferencePictures;

    [NativeTypeName("const VkExtensionProperties *")]
    [SupportedApiProfile("vulkan")]
    public ExtensionProperties* PStdHeaderVersion;
}
