// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum SamplerYcbcrModelConversion : uint
{
    RgbIdentity = 0,
    YcbcrIdentity = 1,
    Ycbcr709 = 2,
    Ycbcr601 = 3,
    Ycbcr2020 = 4,
    RgbIdentityKHR = RgbIdentity,
    YcbcrIdentityKHR = YcbcrIdentity,
    Ycbcr709KHR = Ycbcr709,
    Ycbcr601KHR = Ycbcr601,
    Ycbcr2020KHR = Ycbcr2020,
}
