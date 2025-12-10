// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public partial struct StdVideoAV1GlobalMotion
{
    [NativeTypeName("uint8_t[8]")]
    public StdVideoAV1GlobalMotionGmType GmType;

    [NativeTypeName("int32_t[8][6]")]
    public StdVideoAV1GlobalMotionGmParams GmParams;
}
