// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoVP9ColorConfig
{
    public StdVideoVP9ColorConfigFlags Flags;

    [NativeTypeName("uint8_t")]
    public byte BitDepth;

    [NativeTypeName("uint8_t")]
    public byte SubsamplingX;

    [NativeTypeName("uint8_t")]
    public byte SubsamplingY;

    [NativeTypeName("uint8_t")]
    public byte Reserved1;
    public StdVideoVP9ColorSpace ColorSpace;
}
