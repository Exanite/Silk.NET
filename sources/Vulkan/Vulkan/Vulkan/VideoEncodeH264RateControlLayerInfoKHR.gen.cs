// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeH264RateControlLayerInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint UseMinQp;
    public VideoEncodeH264QpKHR MinQp;

    [NativeTypeName("VkBool32")]
    public uint UseMaxQp;
    public VideoEncodeH264QpKHR MaxQp;

    [NativeTypeName("VkBool32")]
    public uint UseMaxFrameSize;
    public VideoEncodeH264FrameSizeKHR MaxFrameSize;
}
