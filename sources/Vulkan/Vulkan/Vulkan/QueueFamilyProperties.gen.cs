// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct QueueFamilyProperties
{
    [NativeTypeName("VkQueueFlags")]
    [SupportedApiProfile("vulkan")]
    public QueueFlags QueueFlags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueCount;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint TimestampValidBits;

    [SupportedApiProfile("vulkan")]
    public Extent3D MinImageTransferGranularity;
}
