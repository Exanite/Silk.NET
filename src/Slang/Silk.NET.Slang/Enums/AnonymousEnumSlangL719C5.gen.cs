// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [Flags]
    [NativeName("Name", "__AnonymousEnum_slang_L719_C5")]
    public enum AnonymousEnumSlangL719C5 : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SLANG_TARGET_FLAG_PARAMETER_BLOCKS_USE_REGISTER_SPACES")]
        ParameterBlocksUseRegisterSpaces = 0x10,
        [NativeName("Name", "SLANG_TARGET_FLAG_GENERATE_WHOLE_PROGRAM")]
        GenerateWholeProgram = 0x100,
        [NativeName("Name", "SLANG_TARGET_FLAG_DUMP_IR")]
        DumpIR = 0x200,
        [NativeName("Name", "SLANG_TARGET_FLAG_GENERATE_SPIRV_DIRECTLY")]
        GenerateSpirvDirectly = 0x400,
    }
}
