// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangResourceAccess")]
    public enum SlangResourceAccess : uint
    {
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_READ")]
        Read = 0x1,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_READ_WRITE")]
        ReadWrite = 0x2,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_RASTER_ORDERED")]
        RasterOrdered = 0x3,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_APPEND")]
        Append = 0x4,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_CONSUME")]
        Consume = 0x5,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_WRITE")]
        Write = 0x6,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_FEEDBACK")]
        Feedback = 0x7,
        [NativeName("Name", "SLANG_RESOURCE_ACCESS_UNKNOWN")]
        Unknown = 0x7FFFFFFF,
    }
}
