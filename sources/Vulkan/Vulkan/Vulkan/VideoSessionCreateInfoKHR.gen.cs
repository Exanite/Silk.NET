// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoSessionCreateInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    public uint QueueFamilyIndex;

    [NativeTypeName("VkVideoSessionCreateFlagsKHR")]
    public VideoSessionCreateFlagsKHR Flags;

    [NativeTypeName("const VkVideoProfileInfoKHR *")]
    public VideoProfileInfoKHR* PVideoProfile;
    public Format PictureFormat;
    public Extent2D MaxCodedExtent;
    public Format ReferencePictureFormat;

    [NativeTypeName("uint32_t")]
    public uint MaxDpbSlots;

    [NativeTypeName("uint32_t")]
    public uint MaxActiveReferencePictures;

    [NativeTypeName("const VkExtensionProperties *")]
    public ExtensionProperties* PStdHeaderVersion;
}
