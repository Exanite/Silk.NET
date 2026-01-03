// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[Flags]
public enum SubpassDescriptionFlags : uint
{
    None = 0x0,
    PerViewAttributesBitNVX = 0x1,
    PerViewPositionXOnlyBitNVX = 0x2,
    FragmentRegionBitQCOM = 0x4,
    ShaderResolveBitQCOM = 0x8,
    TileShadingApronBitQCOM = 0x100,
    RasterizationOrderAttachmentColorAccessBitEXT = 0x10,
    RasterizationOrderAttachmentDepthAccessBitEXT = 0x20,
    RasterizationOrderAttachmentStencilAccessBitEXT = 0x40,
    EnableLegacyDitheringBitEXT = 0x80,
    RasterizationOrderAttachmentColorAccessBitARM = RasterizationOrderAttachmentColorAccessBitEXT,
    RasterizationOrderAttachmentDepthAccessBitARM = RasterizationOrderAttachmentDepthAccessBitEXT,
    RasterizationOrderAttachmentStencilAccessBitARM =
        RasterizationOrderAttachmentStencilAccessBitEXT,
}
