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

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Glyph_Metrics_")]
    public unsafe partial struct GlyphMetrics
    {
        public GlyphMetrics
        (
            int? width = null,
            int? height = null,
            int? horiBearingX = null,
            int? horiBearingY = null,
            int? horiAdvance = null,
            int? vertBearingX = null,
            int? vertBearingY = null,
            int? vertAdvance = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (horiBearingX is not null)
            {
                HoriBearingX = horiBearingX.Value;
            }

            if (horiBearingY is not null)
            {
                HoriBearingY = horiBearingY.Value;
            }

            if (horiAdvance is not null)
            {
                HoriAdvance = horiAdvance.Value;
            }

            if (vertBearingX is not null)
            {
                VertBearingX = vertBearingX.Value;
            }

            if (vertBearingY is not null)
            {
                VertBearingY = vertBearingY.Value;
            }

            if (vertAdvance is not null)
            {
                VertAdvance = vertAdvance.Value;
            }
        }


        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "width")]
        public int Width;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "height")]
        public int Height;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiBearingX")]
        public int HoriBearingX;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiBearingY")]
        public int HoriBearingY;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiAdvance")]
        public int HoriAdvance;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertBearingX")]
        public int VertBearingX;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertBearingY")]
        public int VertBearingY;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertAdvance")]
        public int VertAdvance;
    }
}
