// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ExternalMemoryHandleTypeFlags : uint
{
    None = 0x0,
    OpaqueFdBit = 0x1,
    OpaqueWin32Bit = 0x2,
    OpaqueWin32KmtBit = 0x4,
    D3D11TextureBit = 0x8,
    D3D11TextureKmtBit = 0x10,
    D3D12HeapBit = 0x20,
    D3D12ResourceBit = 0x40,
    DmaBufBitEXT = 0x200,
    AndroidHardwareBufferBitANDROID = 0x400,
    HostAllocationBitEXT = 0x80,
    HostMappedForeignMemoryBitEXT = 0x100,
    ZirconVmoBitFUCHSIA = 0x800,
    RdmaAddressBitNV = 0x1000,
    OhNativeBufferBitOHOS = 0x8000,
    ScreenBufferBitQNX = 0x4000,
    MtlbufferBitEXT = 0x10000,
    MtltextureBitEXT = 0x20000,
    MtlheapBitEXT = 0x40000,
    OpaqueFdBitKHR = OpaqueFdBit,
    OpaqueWin32BitKHR = OpaqueWin32Bit,
    OpaqueWin32KmtBitKHR = OpaqueWin32KmtBit,
    D3D11TextureBitKHR = D3D11TextureBit,
    D3D11TextureKmtBitKHR = D3D11TextureKmtBit,
    D3D12HeapBitKHR = D3D12HeapBit,
    D3D12ResourceBitKHR = D3D12ResourceBit,
}
