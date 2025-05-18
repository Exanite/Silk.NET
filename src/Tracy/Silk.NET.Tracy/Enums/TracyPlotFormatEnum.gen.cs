// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Tracy
{
    [NativeName("Name", "TracyPlotFormatEnum")]
    public enum TracyPlotFormatEnum : int
    {
        [NativeName("Name", "TracyPlotFormatNumber")]
        Number = 0x0,
        [NativeName("Name", "TracyPlotFormatMemory")]
        Memory = 0x1,
        [NativeName("Name", "TracyPlotFormatPercentage")]
        Percentage = 0x2,
        [NativeName("Name", "TracyPlotFormatWatt")]
        Watt = 0x3,
    }
}
