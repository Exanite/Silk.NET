// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

public enum VendorId : uint
{
    Khronos = 65536,
    Viv = 65537,
    Vsi = 65538,
    Kazan = 65539,
    Codeplay = 65540,
    Mesa = 65541,
    Pocl = 65542,
    Mobileye = 65543,
}
