// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangPathType")]
    public enum PathType : uint
    {
        [NativeName("Name", "SLANG_PATH_TYPE_DIRECTORY")]
        Directory = 0x0,
        [NativeName("Name", "SLANG_PATH_TYPE_FILE")]
        File = 0x1,
    }
}
