// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "OSPathKind")]
    public enum OSPathKind : byte
    {
        [NativeName("Name", "None")]
        None = 0x0,
        [NativeName("Name", "Direct")]
        Direct = 0x1,
        [NativeName("Name", "OperatingSystem")]
        OperatingSystem = 0x2,
    }
}
