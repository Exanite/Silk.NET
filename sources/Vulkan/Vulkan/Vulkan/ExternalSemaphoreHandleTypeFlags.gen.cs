// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ExternalSemaphoreHandleTypeFlags : uint
{
    None = 0x0,
    OpaqueFdBit = 0x1,
    OpaqueWin32Bit = 0x2,
    OpaqueWin32KmtBit = 0x4,
    D3D12FenceBit = 0x8,
    SyncFdBit = 0x10,
    ZirconEventBitFUCHSIA = 0x80,
    D3D11FenceBit = D3D12FenceBit,
    OpaqueFdBitKHR = OpaqueFdBit,
    OpaqueWin32BitKHR = OpaqueWin32Bit,
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,
    D3D12FenceBitKHR = D3D12FenceBit,
    SyncFdBitKHR = SyncFdBit,
}
