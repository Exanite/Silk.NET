// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum CubicFilterWeightsQCOM : uint
{
    CatmullRom = 0,
    ZeroTangentCardinal = 1,
    BSpline = 2,
    MitchellNetravali = 3,
}
