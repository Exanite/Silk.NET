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
    [NativeName("AnonymousName", "__AnonymousRecord_hb-paint_L332_C9")]
    [NativeName("Name", "hb_color_stop_t")]
    public unsafe partial struct ColorStopT
    {
        public ColorStopT
        (
            float? offset = null,
            int? isForeground = null,
            uint? color = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (isForeground is not null)
            {
                IsForeground = isForeground.Value;
            }

            if (color is not null)
            {
                Color = color.Value;
            }
        }


        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "offset")]
        public float Offset;

        [NativeName("Type", "hb_bool_t")]
        [NativeName("Type.Name", "hb_bool_t")]
        [NativeName("Name", "is_foreground")]
        public int IsForeground;

        [NativeName("Type", "hb_color_t")]
        [NativeName("Type.Name", "hb_color_t")]
        [NativeName("Name", "color")]
        public uint Color;
    }
}
