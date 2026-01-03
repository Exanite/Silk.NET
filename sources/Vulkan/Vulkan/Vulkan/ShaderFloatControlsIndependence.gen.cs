// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum ShaderFloatControlsIndependence : uint
{
    Independence32BitOnly = 0,
    IndependenceAll = 1,
    IndependenceNone = 2,
    Independence32BitOnlyKHR = Independence32BitOnly,
    IndependenceAllKHR = IndependenceAll,
    IndependenceNoneKHR = IndependenceNone,
}
