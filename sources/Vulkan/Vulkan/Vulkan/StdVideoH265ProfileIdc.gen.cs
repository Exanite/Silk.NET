// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoH265ProfileIdc : uint
{
    Main = 1,
    Main10 = 2,
    MainStillPicture = 3,
    FormatRangeExtensions = 4,
    SccExtensions = 9,
}
