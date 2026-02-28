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
    [NativeName("Name", "FT_Matrix_")]
    public unsafe partial struct Matrix
    {
        public Matrix
        (
            long? xx = null,
            long? xy = null,
            long? yx = null,
            long? yy = null
        ) : this()
        {
            if (xx is not null)
            {
                Xx = xx.Value;
            }

            if (xy is not null)
            {
                Xy = xy.Value;
            }

            if (yx is not null)
            {
                Yx = yx.Value;
            }

            if (yy is not null)
            {
                Yy = yy.Value;
            }
        }


        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "xx")]
        public long Xx;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "xy")]
        public long Xy;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "yx")]
        public long Yx;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "yy")]
        public long Yy;
    }
}
