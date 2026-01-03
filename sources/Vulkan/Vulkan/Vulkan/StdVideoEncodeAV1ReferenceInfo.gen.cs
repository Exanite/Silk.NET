// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public unsafe partial struct StdVideoEncodeAV1ReferenceInfo
{
    public StdVideoEncodeAV1ReferenceInfoFlags Flags;

    [NativeTypeName("uint32_t")]
    public uint RefFrameId;
    public StdVideoAV1FrameType FrameType;

    [NativeTypeName("uint8_t")]
    public byte OrderHint;

    [NativeTypeName("uint8_t[3]")]
    public StdVideoEncodeAV1ReferenceInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeAV1ExtensionHeader *")]
    public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;
}
