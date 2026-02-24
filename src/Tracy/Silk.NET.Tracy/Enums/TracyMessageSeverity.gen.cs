// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Tracy
{
    [NativeName("Name", "TracyMessageSeverity")]
    public enum TracyMessageSeverity : int
    {
        [NativeName("Name", "TracyMessageSeverityTrace")]
        Trace = 0x0,
        [NativeName("Name", "TracyMessageSeverityDebug")]
        Debug = 0x1,
        [NativeName("Name", "TracyMessageSeverityInfo")]
        Info = 0x2,
        [NativeName("Name", "TracyMessageSeverityWarning")]
        Warning = 0x3,
        [NativeName("Name", "TracyMessageSeverityError")]
        Error = 0x4,
        [NativeName("Name", "TracyMessageSeverityFatal")]
        Fatal = 0x5,
    }
}
