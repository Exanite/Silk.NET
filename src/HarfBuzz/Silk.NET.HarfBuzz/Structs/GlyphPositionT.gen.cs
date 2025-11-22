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
    [NativeName("Name", "hb_glyph_position_t")]
    public unsafe partial struct GlyphPositionT
    {
        public GlyphPositionT
        (
            int? xAdvance = null,
            int? yAdvance = null,
            int? xOffset = null,
            int? yOffset = null,
            VarIntT? var = null
        ) : this()
        {
            if (xAdvance is not null)
            {
                XAdvance = xAdvance.Value;
            }

            if (yAdvance is not null)
            {
                YAdvance = yAdvance.Value;
            }

            if (xOffset is not null)
            {
                XOffset = xOffset.Value;
            }

            if (yOffset is not null)
            {
                YOffset = yOffset.Value;
            }

            if (var is not null)
            {
                Var = var.Value;
            }
        }


        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "x_advance")]
        public int XAdvance;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "y_advance")]
        public int YAdvance;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "x_offset")]
        public int XOffset;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "y_offset")]
        public int YOffset;

        [NativeName("Type", "hb_var_int_t")]
        [NativeName("Type.Name", "hb_var_int_t")]
        [NativeName("Name", "var")]
        public VarIntT Var;
    }
}
