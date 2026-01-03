// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct VideoEncodeH264GopRemainingFrameInfoKHR
{
    public StructureType SType;

    [NativeTypeName("const void *")]
    public void* PNext;

    [NativeTypeName("VkBool32")]
    public uint UseGopRemainingFrames;

    [NativeTypeName("uint32_t")]
    public uint GopRemainingI;

    [NativeTypeName("uint32_t")]
    public uint GopRemainingP;

    [NativeTypeName("uint32_t")]
    public uint GopRemainingB;
}
