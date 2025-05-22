// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangReflectionGenericArgType")]
    public enum ReflectionGenericArgType : int
    {
        [NativeName("Name", "SLANG_GENERIC_ARG_TYPE")]
        Type = 0x0,
        [NativeName("Name", "SLANG_GENERIC_ARG_INT")]
        Int = 0x1,
        [NativeName("Name", "SLANG_GENERIC_ARG_BOOL")]
        Bool = 0x2,
    }
}
