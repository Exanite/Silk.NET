// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L705_C9")]
    [NativeName("Name", "hb_buffer_serialize_format_t")]
    public enum BufferSerializeFormatT : int
    {
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FORMAT_TEXT")]
        Text = 0x54455854,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FORMAT_JSON")]
        Json = 0x4A534F4E,
        [NativeName("Name", "HB_BUFFER_SERIALIZE_FORMAT_INVALID")]
        Invalid = 0x0,
    }
}
