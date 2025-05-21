// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangSeverity")]
    public enum SlangSeverity : int
    {
        [NativeName("Name", "SLANG_SEVERITY_DISABLED")]
        Disabled = 0x0,
        [NativeName("Name", "SLANG_SEVERITY_NOTE")]
        Note = 0x1,
        [NativeName("Name", "SLANG_SEVERITY_WARNING")]
        Warning = 0x2,
        [NativeName("Name", "SLANG_SEVERITY_ERROR")]
        Error = 0x3,
        [NativeName("Name", "SLANG_SEVERITY_FATAL")]
        Fatal = 0x4,
        [NativeName("Name", "SLANG_SEVERITY_INTERNAL")]
        Internal = 0x5,
    }
}
