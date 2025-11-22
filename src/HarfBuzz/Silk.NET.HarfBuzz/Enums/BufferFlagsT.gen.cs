// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L396_C9")]
    [NativeName("Name", "hb_buffer_flags_t")]
    public enum BufferFlagsT : int
    {
        [NativeName("Name", "HB_BUFFER_FLAG_DEFAULT")]
        Default = 0x0,
        [NativeName("Name", "HB_BUFFER_FLAG_BOT")]
        Bot = 0x1,
        [NativeName("Name", "HB_BUFFER_FLAG_EOT")]
        Eot = 0x2,
        [NativeName("Name", "HB_BUFFER_FLAG_PRESERVE_DEFAULT_IGNORABLES")]
        PreserveDefaultIgnorables = 0x4,
        [NativeName("Name", "HB_BUFFER_FLAG_REMOVE_DEFAULT_IGNORABLES")]
        RemoveDefaultIgnorables = 0x8,
        [NativeName("Name", "HB_BUFFER_FLAG_DO_NOT_INSERT_DOTTED_CIRCLE")]
        DONotInsertDottedCircle = 0x10,
        [NativeName("Name", "HB_BUFFER_FLAG_VERIFY")]
        Verify = 0x20,
        [NativeName("Name", "HB_BUFFER_FLAG_PRODUCE_UNSAFE_TO_CONCAT")]
        ProduceUnsafeToConcat = 0x40,
        [NativeName("Name", "HB_BUFFER_FLAG_PRODUCE_SAFE_TO_INSERT_TATWEEL")]
        ProduceSafeToInsertTatweel = 0x80,
        [NativeName("Name", "HB_BUFFER_FLAG_DEFINED")]
        Defined = 0xFF,
    }
}
