// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangImageFormat")]
    public enum ImageFormat : uint
    {
        [NativeName("Name", "SLANG_IMAGE_FORMAT_unknown")]
        Unknown = 0x0,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba32f")]
        Rgba32f = 0x1,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba16f")]
        Rgba16f = 0x2,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg32f")]
        Rg32f = 0x3,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg16f")]
        Rg16f = 0x4,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r11f_g11f_b10f")]
        R11fG11fB10f = 0x5,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r32f")]
        R32f = 0x6,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r16f")]
        R16f = 0x7,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba16")]
        Rgba16 = 0x8,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgb10_a2")]
        Rgb10A2 = 0x9,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba8")]
        Rgba8 = 0xA,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg16")]
        Rg16 = 0xB,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg8")]
        Rg8 = 0xC,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r16")]
        R16 = 0xD,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r8")]
        R8 = 0xE,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba16_snorm")]
        Rgba16Snorm = 0xF,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba8_snorm")]
        Rgba8Snorm = 0x10,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg16_snorm")]
        Rg16Snorm = 0x11,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg8_snorm")]
        Rg8Snorm = 0x12,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r16_snorm")]
        R16Snorm = 0x13,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r8_snorm")]
        R8Snorm = 0x14,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba32i")]
        Rgba32i = 0x15,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba16i")]
        Rgba16i = 0x16,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba8i")]
        Rgba8i = 0x17,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg32i")]
        Rg32i = 0x18,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg16i")]
        Rg16i = 0x19,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg8i")]
        Rg8i = 0x1A,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r32i")]
        R32i = 0x1B,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r16i")]
        R16i = 0x1C,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r8i")]
        R8i = 0x1D,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba32ui")]
        Rgba32ui = 0x1E,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba16ui")]
        Rgba16ui = 0x1F,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgb10_a2ui")]
        Rgb10A2ui = 0x20,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rgba8ui")]
        Rgba8ui = 0x21,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg32ui")]
        Rg32ui = 0x22,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg16ui")]
        Rg16ui = 0x23,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_rg8ui")]
        Rg8ui = 0x24,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r32ui")]
        R32ui = 0x25,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r16ui")]
        R16ui = 0x26,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r8ui")]
        R8ui = 0x27,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r64ui")]
        R64ui = 0x28,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_r64i")]
        R64i = 0x29,
        [NativeName("Name", "SLANG_IMAGE_FORMAT_bgra8")]
        Bgra8 = 0x2A,
    }
}
