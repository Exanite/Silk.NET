// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum ColorSpaceKHR : uint
{
    SrgbNonlinear = 0,
    DisplayP3NonlinearEXT = 1000104001,
    ExtendedSrgbLinearEXT = 1000104002,
    DisplayP3LinearEXT = 1000104003,
    DciP3NonlinearEXT = 1000104004,
    Bt709LinearEXT = 1000104005,
    Bt709NonlinearEXT = 1000104006,
    Bt2020LinearEXT = 1000104007,
    Hdr10St2084EXT = 1000104008,
    DolbyvisionEXT = 1000104009,
    Hdr10HlgEXT = 1000104010,
    AdobergbLinearEXT = 1000104011,
    AdobergbNonlinearEXT = 1000104012,
    PassThroughEXT = 1000104013,
    ExtendedSrgbNonlinearEXT = 1000104014,
    DisplayNativeAMD = 1000213000,
}
