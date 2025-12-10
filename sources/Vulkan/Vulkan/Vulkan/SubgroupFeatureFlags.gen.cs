// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum SubgroupFeatureFlags : uint
{
    None = 0x0,
    BasicBit = 0x1,
    VoteBit = 0x2,
    ArithmeticBit = 0x4,
    BallotBit = 0x8,
    ShuffleBit = 0x10,
    ShuffleRelativeBit = 0x20,
    ClusteredBit = 0x40,
    QuadBit = 0x80,
    RotateBit = 0x200,
    RotateClusteredBit = 0x400,
    PartitionedBitNV = 0x100,
    RotateBitKHR = RotateBit,
    RotateClusteredBitKHR = RotateClusteredBit,
}
