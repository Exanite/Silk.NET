// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangEmitSpirvMethod")]
    public enum EmitSpirvMethod : int
    {
        [NativeName("Name", "SLANG_EMIT_SPIRV_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_EMIT_SPIRV_VIA_GLSL")]
        ViaGlsl = 0x1,
        [NativeName("Name", "SLANG_EMIT_SPIRV_DIRECTLY")]
        Directly = 0x2,
    }
}
