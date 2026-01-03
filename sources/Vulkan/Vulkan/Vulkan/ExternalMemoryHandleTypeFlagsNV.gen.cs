// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ExternalMemoryHandleTypeFlagsNV : uint
{
    None = 0x0,
    OpaqueWin32Bit = 0x1,
    OpaqueWin32KmtBit = 0x2,
    D3D11ImageBit = 0x4,
    D3D11ImageKmtBit = 0x8,
}
