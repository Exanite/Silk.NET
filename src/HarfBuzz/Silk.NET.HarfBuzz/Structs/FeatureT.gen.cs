// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.HarfBuzz
{
    [NativeName("Name", "hb_feature_t")]
    public unsafe partial struct FeatureT
    {
        public FeatureT
        (
            uint? tag = null,
            uint? value = null,
            uint? start = null,
            uint? end = null
        ) : this()
        {
            if (tag is not null)
            {
                Tag = tag.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }

            if (start is not null)
            {
                Start = start.Value;
            }

            if (end is not null)
            {
                End = end.Value;
            }
        }


        [NativeName("Type", "hb_tag_t")]
        [NativeName("Type.Name", "hb_tag_t")]
        [NativeName("Name", "tag")]
        public uint Tag;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "value")]
        public uint Value;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "start")]
        public uint Start;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "end")]
        public uint End;
    }
}
