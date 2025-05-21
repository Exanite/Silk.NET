// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "BuiltinModuleName")]
    public enum BuiltinModuleName : int
    {
        [NativeName("Name", "Core")]
        Core = 0x0,
        [NativeName("Name", "GLSL")]
        Glsl = 0x1,
    }
}
