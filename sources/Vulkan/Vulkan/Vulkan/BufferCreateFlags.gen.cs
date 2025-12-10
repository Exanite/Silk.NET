// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum BufferCreateFlags : uint
{
    None = 0x0,
    SparseBindingBit = 0x1,
    SparseResidencyBit = 0x2,
    SparseAliasedBit = 0x4,
    ProtectedBit = 0x8,
    DeviceAddressCaptureReplayBit = 0x10,
    DescriptorBufferCaptureReplayBitEXT = 0x20,
    VideoProfileIndependentBitKHR = 0x40,
    DeviceAddressCaptureReplayBitEXT = DeviceAddressCaptureReplayBit,
    DeviceAddressCaptureReplayBitKHR = DeviceAddressCaptureReplayBit,
}
