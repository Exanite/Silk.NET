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
    [NativeName("Name", "hb_glyph_extents_t")]
    public unsafe partial struct GlyphExtentsT
    {
        public GlyphExtentsT
        (
            int? xBearing = null,
            int? yBearing = null,
            int? width = null,
            int? height = null
        ) : this()
        {
            if (xBearing is not null)
            {
                XBearing = xBearing.Value;
            }

            if (yBearing is not null)
            {
                YBearing = yBearing.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }
        }


        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "x_bearing")]
        public int XBearing;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "y_bearing")]
        public int YBearing;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "width")]
        public int Width;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "height")]
        public int Height;
    }
}
