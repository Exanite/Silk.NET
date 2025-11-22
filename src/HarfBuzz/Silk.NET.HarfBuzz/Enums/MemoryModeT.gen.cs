// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-blob_L69_C9")]
    [NativeName("Name", "hb_memory_mode_t")]
    public enum MemoryModeT : int
    {
        [NativeName("Name", "HB_MEMORY_MODE_DUPLICATE")]
        Duplicate = 0x0,
        [NativeName("Name", "HB_MEMORY_MODE_READONLY")]
        Readonly = 0x1,
        [NativeName("Name", "HB_MEMORY_MODE_WRITABLE")]
        Writable = 0x2,
        [NativeName("Name", "HB_MEMORY_MODE_READONLY_MAY_MAKE_WRITABLE")]
        ReadonlyMayMakeWritable = 0x3,
    }
}
