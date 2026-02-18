// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangEmitCPUMethod")]
    public enum SlangEmitCPUMethod : int
    {
        [NativeName("Name", "SLANG_EMIT_CPU_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_EMIT_CPU_VIA_CPP")]
        ViaCpp = 0x1,
        [NativeName("Name", "SLANG_EMIT_CPU_VIA_LLVM")]
        ViaLlvm = 0x2,
    }
}
