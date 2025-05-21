// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangWriterMode")]
    public enum SlangWriterMode : uint
    {
        [NativeName("Name", "SLANG_WRITER_MODE_TEXT")]
        Text = 0x0,
        [NativeName("Name", "SLANG_WRITER_MODE_BINARY")]
        Binary = 0x1,
    }
}
