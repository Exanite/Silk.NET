// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangFpDenormalMode")]
    public enum FpDenormalMode : uint
    {
        [NativeName("Name", "SLANG_FP_DENORM_MODE_ANY")]
        Any = 0x0,
        [NativeName("Name", "SLANG_FP_DENORM_MODE_PRESERVE")]
        Preserve = 0x1,
        [NativeName("Name", "SLANG_FP_DENORM_MODE_FTZ")]
        Ftz = 0x2,
    }
}
