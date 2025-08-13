// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangLanguageVersion")]
    public enum LanguageVersion : int
    {
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_UNKNOWN")]
        LanguageVersionUnknown = 0x0,
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_LEGACY")]
        LanguageVersionLegacy = 0x7E2,
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_2025")]
        LanguageVersion2025 = 0x7E9,
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_2026")]
        LanguageVersion2026 = 0x7EA,
        [NativeName("Name", "SLANG_LANGAUGE_VERSION_DEFAULT")]
        LangaugeVersionDefault = 0x7E2,
        [NativeName("Name", "SLANG_LANGUAGE_VERSION_LATEST")]
        LanguageVersionLatest = 0x7EA,
    }
}
