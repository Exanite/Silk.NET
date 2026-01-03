// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum VideoSessionCreateFlagsKHR : uint
{
    None = 0x0,
    ProtectedContentBit = 0x1,
    AllowEncodeParameterOptimizationsBit = 0x2,
    InlineQueriesBit = 0x4,
    AllowEncodeQuantizationDeltaMapBit = 0x8,
    AllowEncodeEmphasisMapBit = 0x10,
    InlineSessionParametersBit = 0x20,
}
