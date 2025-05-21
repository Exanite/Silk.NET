// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangDebugInfoFormat")]
    public enum SlangDebugInfoFormat : uint
    {
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_C7")]
        C7 = 0x1,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_PDB")]
        Pdb = 0x2,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_STABS")]
        Stabs = 0x3,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_COFF")]
        Coff = 0x4,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_DWARF")]
        Dwarf = 0x5,
        [NativeName("Name", "SLANG_DEBUG_INFO_FORMAT_COUNT_OF")]
        CountOf = 0x6,
    }
}
