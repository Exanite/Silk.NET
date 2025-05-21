// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "OperandDataType")]
    public enum OperandDataType : int
    {
        [NativeName("Name", "General")]
        General = 0x0,
        [NativeName("Name", "Int32")]
        Int32 = 0x1,
        [NativeName("Name", "Int64")]
        Int64 = 0x2,
        [NativeName("Name", "Float32")]
        Float32 = 0x3,
        [NativeName("Name", "Float64")]
        Float64 = 0x4,
        [NativeName("Name", "String")]
        String = 0x5,
    }
}
