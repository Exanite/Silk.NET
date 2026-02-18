// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangDeclKind")]
    public enum SlangDeclKind : uint
    {
        [NativeName("Name", "SLANG_DECL_KIND_UNSUPPORTED_FOR_REFLECTION")]
        UnsupportedForReflection = 0x0,
        [NativeName("Name", "SLANG_DECL_KIND_STRUCT")]
        Struct = 0x1,
        [NativeName("Name", "SLANG_DECL_KIND_FUNC")]
        Func = 0x2,
        [NativeName("Name", "SLANG_DECL_KIND_MODULE")]
        Module = 0x3,
        [NativeName("Name", "SLANG_DECL_KIND_GENERIC")]
        Generic = 0x4,
        [NativeName("Name", "SLANG_DECL_KIND_VARIABLE")]
        Variable = 0x5,
        [NativeName("Name", "SLANG_DECL_KIND_NAMESPACE")]
        Namespace = 0x6,
        [NativeName("Name", "SLANG_DECL_KIND_ENUM")]
        Enum = 0x7,
    }
}
