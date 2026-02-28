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
            long? width = null,
            long? height = null,
            long? horiBearingX = null,
            long? horiBearingY = null,
            long? horiAdvance = null,
            long? vertBearingX = null,
            long? vertBearingY = null,
            long? vertAdvance = null
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
        public long Width;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "height")]
        public long Height;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiBearingX")]
        public long HoriBearingX;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiBearingY")]
        public long HoriBearingY;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "horiAdvance")]
        public long HoriAdvance;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertBearingX")]
        public long VertBearingX;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertBearingY")]
        public long VertBearingY;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "vertAdvance")]
        public long VertAdvance;
    }
}
