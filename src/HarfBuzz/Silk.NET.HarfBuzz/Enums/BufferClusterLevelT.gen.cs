// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("AnonymousName", "__AnonymousEnum_hb-buffer_L461_C9")]
    [NativeName("Name", "hb_buffer_cluster_level_t")]
    public enum BufferClusterLevelT : int
    {
        [NativeName("Name", "HB_BUFFER_CLUSTER_LEVEL_MONOTONE_GRAPHEMES")]
        MonotoneGraphemes = 0x0,
        [NativeName("Name", "HB_BUFFER_CLUSTER_LEVEL_MONOTONE_CHARACTERS")]
        MonotoneCharacters = 0x1,
        [NativeName("Name", "HB_BUFFER_CLUSTER_LEVEL_CHARACTERS")]
        Characters = 0x2,
        [NativeName("Name", "HB_BUFFER_CLUSTER_LEVEL_GRAPHEMES")]
        Graphemes = 0x3,
        [NativeName("Name", "HB_BUFFER_CLUSTER_LEVEL_DEFAULT")]
        Default = 0x0,
    }
}
