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
    [NativeName("Name", "FT_SizeRec_")]
    public unsafe partial struct SizeRec
    {
        public SizeRec
        (
            FaceRec* face = null,
            Generic? generic = null,
            SizeMetrics? metrics = null,
            SizeInternalRec* @internal = null
        ) : this()
        {
            if (face is not null)
            {
                Face = face;
            }

            if (generic is not null)
            {
                Generic = generic.Value;
            }

            if (metrics is not null)
            {
                Metrics = metrics.Value;
            }

            if (@internal is not null)
            {
                Internal = @internal;
            }
        }


        [NativeName("Type", "FT_Face")]
        [NativeName("Type.Name", "FT_Face")]
        [NativeName("Name", "face")]
        public FaceRec* Face;

        [NativeName("Type", "FT_Generic")]
        [NativeName("Type.Name", "FT_Generic")]
        [NativeName("Name", "generic")]
        public Generic Generic;

        [NativeName("Type", "FT_Size_Metrics")]
        [NativeName("Type.Name", "FT_Size_Metrics")]
        [NativeName("Name", "metrics")]
        public SizeMetrics Metrics;

        [NativeName("Type", "FT_Size_Internal")]
        [NativeName("Type.Name", "FT_Size_Internal")]
        [NativeName("Name", "internal")]
        public SizeInternalRec* Internal;
    }
}
