// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangDiagnosticColor")]
    public enum SlangDiagnosticColor : int
    {
        [NativeName("Name", "SLANG_DIAGNOSTIC_COLOR_AUTO")]
        Auto = 0x0,
        [NativeName("Name", "SLANG_DIAGNOSTIC_COLOR_ALWAYS")]
        Always = 0x1,
        [NativeName("Name", "SLANG_DIAGNOSTIC_COLOR_NEVER")]
        Never = 0x2,
    }
}
