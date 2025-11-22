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
    [NativeName("Name", "hb_font_extents_t")]
    public unsafe partial struct FontExtentsT
    {
        public FontExtentsT
        (
            int? ascender = null,
            int? descender = null,
            int? lineGap = null,
            int? reserved9 = null,
            int? reserved8 = null,
            int? reserved7 = null,
            int? reserved6 = null,
            int? reserved5 = null,
            int? reserved4 = null,
            int? reserved3 = null,
            int? reserved2 = null,
            int? reserved1 = null
        ) : this()
        {
            if (ascender is not null)
            {
                Ascender = ascender.Value;
            }

            if (descender is not null)
            {
                Descender = descender.Value;
            }

            if (lineGap is not null)
            {
                LineGap = lineGap.Value;
            }

            if (reserved9 is not null)
            {
                Reserved9 = reserved9.Value;
            }

            if (reserved8 is not null)
            {
                Reserved8 = reserved8.Value;
            }

            if (reserved7 is not null)
            {
                Reserved7 = reserved7.Value;
            }

            if (reserved6 is not null)
            {
                Reserved6 = reserved6.Value;
            }

            if (reserved5 is not null)
            {
                Reserved5 = reserved5.Value;
            }

            if (reserved4 is not null)
            {
                Reserved4 = reserved4.Value;
            }

            if (reserved3 is not null)
            {
                Reserved3 = reserved3.Value;
            }

            if (reserved2 is not null)
            {
                Reserved2 = reserved2.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }
        }


        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "ascender")]
        public int Ascender;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "descender")]
        public int Descender;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "line_gap")]
        public int LineGap;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved9")]
        public int Reserved9;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved8")]
        public int Reserved8;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved7")]
        public int Reserved7;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved6")]
        public int Reserved6;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved5")]
        public int Reserved5;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved4")]
        public int Reserved4;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved3")]
        public int Reserved3;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved2")]
        public int Reserved2;

        [NativeName("Type", "hb_position_t")]
        [NativeName("Type.Name", "hb_position_t")]
        [NativeName("Name", "reserved1")]
        public int Reserved1;
    }
}
