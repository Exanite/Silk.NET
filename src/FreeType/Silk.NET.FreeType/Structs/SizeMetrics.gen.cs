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
    [NativeName("Name", "FT_Size_Metrics_")]
    public unsafe partial struct SizeMetrics
    {
        public SizeMetrics
        (
            ushort? xPpem = null,
            ushort? yPpem = null,
            nint? xScale = null,
            nint? yScale = null,
            int? ascender = null,
            int? descender = null,
            int? height = null,
            int? maxAdvance = null
        ) : this()
        {
            if (xPpem is not null)
            {
                XPpem = xPpem.Value;
            }

            if (yPpem is not null)
            {
                YPpem = yPpem.Value;
            }

            if (xScale is not null)
            {
                XScale = xScale.Value;
            }

            if (yScale is not null)
            {
                YScale = yScale.Value;
            }

            if (ascender is not null)
            {
                Ascender = ascender.Value;
            }

            if (descender is not null)
            {
                Descender = descender.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (maxAdvance is not null)
            {
                MaxAdvance = maxAdvance.Value;
            }
        }


        [NativeName("Type", "FT_UShort")]
        [NativeName("Type.Name", "FT_UShort")]
        [NativeName("Name", "x_ppem")]
        public ushort XPpem;

        [NativeName("Type", "FT_UShort")]
        [NativeName("Type.Name", "FT_UShort")]
        [NativeName("Name", "y_ppem")]
        public ushort YPpem;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "x_scale")]
        public nint XScale;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "y_scale")]
        public nint YScale;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "ascender")]
        public int Ascender;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "descender")]
        public int Descender;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "height")]
        public int Height;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "max_advance")]
        public int MaxAdvance;
    }
}
