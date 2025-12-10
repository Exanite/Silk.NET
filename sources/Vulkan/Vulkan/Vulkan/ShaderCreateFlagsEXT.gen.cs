// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum ShaderCreateFlagsEXT : uint
{
    None = 0x0,
    CreateLinkStageBit = 0x1,
    CreateAllowVaryingSubgroupSizeBit = 0x2,
    CreateRequireFullSubgroupsBit = 0x4,
    CreateNoTaskShaderBit = 0x8,
    CreateDispatchBaseBit = 0x10,
    CreateFragmentShadingRateAttachmentBit = 0x20,
    CreateFragmentDensityMapAttachmentBit = 0x40,
    CreateIndirectBindableBit = 0x80,
    Create64BitIndexingBit = 0x8000,
}
