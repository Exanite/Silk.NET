// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangSourceLanguage")]
    public enum SourceLanguage : int
    {
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_SLANG")]
        Slang = 0x1,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_HLSL")]
        Hlsl = 0x2,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_GLSL")]
        Glsl = 0x3,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_C")]
        C = 0x4,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_CPP")]
        Cpp = 0x5,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_CUDA")]
        Cuda = 0x6,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_SPIRV")]
        Spirv = 0x7,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_METAL")]
        Metal = 0x8,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_WGSL")]
        Wgsl = 0x9,
        [NativeName("Name", "SLANG_SOURCE_LANGUAGE_COUNT_OF")]
        CountOf = 0xA,
    }
}
