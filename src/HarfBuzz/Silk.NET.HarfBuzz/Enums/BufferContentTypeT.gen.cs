// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L291_C9")]
    [NativeName("Name", "hb_buffer_content_type_t")]
    public enum BufferContentTypeT : int
    {
        [NativeName("Name", "HB_BUFFER_CONTENT_TYPE_INVALID")]
        Invalid = 0x0,
        [NativeName("Name", "HB_BUFFER_CONTENT_TYPE_UNICODE")]
        Unicode = 0x1,
        [NativeName("Name", "HB_BUFFER_CONTENT_TYPE_GLYPHS")]
        Glyphs = 0x2,
    }
}
