// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum StdVideoAV1ReferenceName : uint
{
    IntraFrame = 0,
    LastFrame = 1,
    Last2Frame = 2,
    Last3Frame = 3,
    GoldenFrame = 4,
    BwdrefFrame = 5,
    Altref2Frame = 6,
    AltrefFrame = 7,
}
