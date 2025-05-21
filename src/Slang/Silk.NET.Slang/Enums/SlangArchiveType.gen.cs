// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangArchiveType")]
    public enum SlangArchiveType : int
    {
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_UNDEFINED")]
        Undefined = 0x0,
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_ZIP")]
        Zip = 0x1,
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_RIFF")]
        Riff = 0x2,
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_RIFF_DEFLATE")]
        RiffDeflate = 0x3,
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_RIFF_LZ4")]
        RiffLZ4 = 0x4,
        [NativeName("Name", "SLANG_ARCHIVE_TYPE_COUNT_OF")]
        CountOf = 0x5,
    }
}
