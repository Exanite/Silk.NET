// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangPassThrough")]
    public enum SlangPassThrough : int
    {
        [NativeName("Name", "SLANG_PASS_THROUGH_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_PASS_THROUGH_FXC")]
        Fxc = 0x1,
        [NativeName("Name", "SLANG_PASS_THROUGH_DXC")]
        Dxc = 0x2,
        [NativeName("Name", "SLANG_PASS_THROUGH_GLSLANG")]
        Glslang = 0x3,
        [NativeName("Name", "SLANG_PASS_THROUGH_SPIRV_DIS")]
        SpirvDis = 0x4,
        [NativeName("Name", "SLANG_PASS_THROUGH_CLANG")]
        Clang = 0x5,
        [NativeName("Name", "SLANG_PASS_THROUGH_VISUAL_STUDIO")]
        VisualStudio = 0x6,
        [NativeName("Name", "SLANG_PASS_THROUGH_GCC")]
        Gcc = 0x7,
        [NativeName("Name", "SLANG_PASS_THROUGH_GENERIC_C_CPP")]
        GenericCCpp = 0x8,
        [NativeName("Name", "SLANG_PASS_THROUGH_NVRTC")]
        Nvrtc = 0x9,
        [NativeName("Name", "SLANG_PASS_THROUGH_LLVM")]
        Llvm = 0xA,
        [NativeName("Name", "SLANG_PASS_THROUGH_SPIRV_OPT")]
        SpirvOpt = 0xB,
        [NativeName("Name", "SLANG_PASS_THROUGH_METAL")]
        Metal = 0xC,
        [NativeName("Name", "SLANG_PASS_THROUGH_TINT")]
        Tint = 0xD,
        [NativeName("Name", "SLANG_PASS_THROUGH_SPIRV_LINK")]
        SpirvLink = 0xE,
        [NativeName("Name", "SLANG_PASS_THROUGH_COUNT_OF")]
        CountOf = 0xF,
    }
}
