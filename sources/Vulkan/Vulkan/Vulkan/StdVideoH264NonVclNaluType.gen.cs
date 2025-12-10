// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoH264NonVclNaluType : uint
{
    Sps = 0,
    Pps = 1,
    Aud = 2,
    Prefix = 3,
    EndOfSequence = 4,
    EndOfStream = 5,
    Precoded = 6,
}
