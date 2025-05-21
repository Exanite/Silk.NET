// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangCapabilityID")]
    public enum SlangCapabilityID : int
    {
        [NativeName("Name", "SLANG_CAPABILITY_UNKNOWN")]
        Unknown = 0x0,
    }
}
