// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangWriterChannel")]
    public enum WriterChannel : uint
    {
        [NativeName("Name", "SLANG_WRITER_CHANNEL_DIAGNOSTIC")]
        Diagnostic = 0x0,
        [NativeName("Name", "SLANG_WRITER_CHANNEL_STD_OUTPUT")]
        StdOutput = 0x1,
        [NativeName("Name", "SLANG_WRITER_CHANNEL_STD_ERROR")]
        StdError = 0x2,
        [NativeName("Name", "SLANG_WRITER_CHANNEL_COUNT_OF")]
        CountOf = 0x3,
    }
}
