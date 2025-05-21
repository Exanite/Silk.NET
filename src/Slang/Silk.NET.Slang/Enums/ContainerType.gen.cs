// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "ContainerType")]
    public enum ContainerType : int
    {
        [NativeName("Name", "None")]
        None = 0x0,
        [NativeName("Name", "UnsizedArray")]
        UnsizedArray = 0x1,
        [NativeName("Name", "StructuredBuffer")]
        StructuredBuffer = 0x2,
        [NativeName("Name", "ConstantBuffer")]
        ConstantBuffer = 0x3,
        [NativeName("Name", "ParameterBlock")]
        ParameterBlock = 0x4,
    }
}
