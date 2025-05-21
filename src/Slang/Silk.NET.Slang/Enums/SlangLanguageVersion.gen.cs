// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangLanguageVersion")]
    public enum SlangLanguageVersion : int
    {
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_2025")]
        Version2025 = 0x7E9,
    }
}
