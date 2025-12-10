// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoAV1LoopFilter
{
    public StdVideoAV1LoopFilterFlags Flags;

    [NativeTypeName("uint8_t[4]")]
    public StdVideoAV1LoopFilterLoopFilterLevel LoopFilterLevel;

    [NativeTypeName("uint8_t")]
    public byte LoopFilterSharpness;

    [NativeTypeName("uint8_t")]
    public byte UpdateRefDelta;

    [NativeTypeName("int8_t[8]")]
    public StdVideoAV1LoopFilterLoopFilterRefDeltas LoopFilterRefDeltas;

    [NativeTypeName("uint8_t")]
    public byte UpdateModeDelta;

    [NativeTypeName("int8_t[2]")]
    public StdVideoAV1LoopFilterLoopFilterModeDeltas LoopFilterModeDeltas;
}
