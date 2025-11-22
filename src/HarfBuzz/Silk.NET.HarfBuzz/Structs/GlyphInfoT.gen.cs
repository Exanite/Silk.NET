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
    [NativeName("Name", "hb_glyph_info_t")]
    public unsafe partial struct GlyphInfoT
    {
        public GlyphInfoT
        (
            uint? codepoint = null,
            uint? mask = null,
            uint? cluster = null,
            VarIntT? var1 = null,
            VarIntT? var2 = null
        ) : this()
        {
            if (codepoint is not null)
            {
                Codepoint = codepoint.Value;
            }

            if (mask is not null)
            {
                Mask = mask.Value;
            }

            if (cluster is not null)
            {
                Cluster = cluster.Value;
            }

            if (var1 is not null)
            {
                Var1 = var1.Value;
            }

            if (var2 is not null)
            {
                Var2 = var2.Value;
            }
        }


        [NativeName("Type", "hb_codepoint_t")]
        [NativeName("Type.Name", "hb_codepoint_t")]
        [NativeName("Name", "codepoint")]
        public uint Codepoint;

        [NativeName("Type", "hb_mask_t")]
        [NativeName("Type.Name", "hb_mask_t")]
        [NativeName("Name", "mask")]
        public uint Mask;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cluster")]
        public uint Cluster;

        [NativeName("Type", "hb_var_int_t")]
        [NativeName("Type.Name", "hb_var_int_t")]
        [NativeName("Name", "var1")]
        public VarIntT Var1;

        [NativeName("Type", "hb_var_int_t")]
        [NativeName("Type.Name", "hb_var_int_t")]
        [NativeName("Name", "var2")]
        public VarIntT Var2;
    }
}
