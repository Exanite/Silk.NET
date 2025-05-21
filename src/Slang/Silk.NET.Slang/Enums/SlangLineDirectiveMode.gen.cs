// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangLineDirectiveMode")]
    public enum SlangLineDirectiveMode : uint
    {
        [NativeName("Name", "SLANG_LINE_DIRECTIVE_MODE_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_LINE_DIRECTIVE_MODE_NONE")]
        None = 0x1,
        [NativeName("Name", "SLANG_LINE_DIRECTIVE_MODE_STANDARD")]
        Standard = 0x2,
        [NativeName("Name", "SLANG_LINE_DIRECTIVE_MODE_GLSL")]
        Glsl = 0x3,
        [NativeName("Name", "SLANG_LINE_DIRECTIVE_MODE_SOURCE_MAP")]
        SourceMap = 0x4,
    }
}
