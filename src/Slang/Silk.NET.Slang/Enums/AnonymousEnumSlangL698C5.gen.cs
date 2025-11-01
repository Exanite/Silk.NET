// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [Flags]
    [NativeName("Name", "__AnonymousEnum_slang_L698_C5")]
    public enum AnonymousEnumSlangL698C5 : int
    {
        [NativeName("Name", "SLANG_COMPILE_FLAG_NO_MANGLING")]
        NoMangling = 0x8,
        [NativeName("Name", "SLANG_COMPILE_FLAG_NO_CODEGEN")]
        NoCodegen = 0x10,
        [NativeName("Name", "SLANG_COMPILE_FLAG_OBFUSCATE")]
        Obfuscate = 0x20,
        [NativeName("Name", "SLANG_COMPILE_FLAG_NO_CHECKING")]
        NoChecking = 0x0,
        [NativeName("Name", "SLANG_COMPILE_FLAG_SPLIT_MIXED_TYPES")]
        SplitMixedTypes = 0x0,
    }
}
