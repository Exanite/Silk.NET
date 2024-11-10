// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "TRACE_LBR_CONFIGURATION")]
    public enum TraceLbrConfiguration : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_NONE")]
        TraceLbrConfigurationNone = 0x0,
        [Obsolete("Deprecated in favour of \"ExcludeKernel\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_KERNEL")]
        TraceLbrConfigurationExcludeKernel = 0x1,
        [Obsolete("Deprecated in favour of \"ExcludeUser\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_USER")]
        TraceLbrConfigurationExcludeUser = 0x2,
        [Obsolete("Deprecated in favour of \"ExcludeJcc\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_JCC")]
        TraceLbrConfigurationExcludeJcc = 0x4,
        [Obsolete("Deprecated in favour of \"ExcludeNearRelCall\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_REL_CALL")]
        TraceLbrConfigurationExcludeNearRelCall = 0x8,
        [Obsolete("Deprecated in favour of \"ExcludeNearIndCall\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_IND_CALL")]
        TraceLbrConfigurationExcludeNearIndCall = 0x10,
        [Obsolete("Deprecated in favour of \"ExcludeNearRet\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_RET")]
        TraceLbrConfigurationExcludeNearRet = 0x20,
        [Obsolete("Deprecated in favour of \"ExcludeNearIndJmp\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_IND_JMP")]
        TraceLbrConfigurationExcludeNearIndJmp = 0x40,
        [Obsolete("Deprecated in favour of \"ExcludeNearRelJmp\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_REL_JMP")]
        TraceLbrConfigurationExcludeNearRelJmp = 0x80,
        [Obsolete("Deprecated in favour of \"ExcludeFarBranch\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_FAR_BRANCH")]
        TraceLbrConfigurationExcludeFarBranch = 0x100,
        [Obsolete("Deprecated in favour of \"CallstackEnable\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_CALLSTACK_ENABLE")]
        TraceLbrConfigurationCallstackEnable = 0x200,
        [Obsolete("Deprecated in favour of \"Sampled\"")]
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_SAMPLED")]
        TraceLbrConfigurationSampled = 0x400,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_NONE")]
        None = 0x0,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_KERNEL")]
        ExcludeKernel = 0x1,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_USER")]
        ExcludeUser = 0x2,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_JCC")]
        ExcludeJcc = 0x4,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_REL_CALL")]
        ExcludeNearRelCall = 0x8,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_IND_CALL")]
        ExcludeNearIndCall = 0x10,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_RET")]
        ExcludeNearRet = 0x20,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_IND_JMP")]
        ExcludeNearIndJmp = 0x40,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_NEAR_REL_JMP")]
        ExcludeNearRelJmp = 0x80,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_EXCLUDE_FAR_BRANCH")]
        ExcludeFarBranch = 0x100,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_CALLSTACK_ENABLE")]
        CallstackEnable = 0x200,
        [NativeName("Name", "TRACE_LBR_CONFIGURATION_SAMPLED")]
        Sampled = 0x400,
    }
}
