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
    [NativeName("Name", "FT_BBox_")]
    public unsafe partial struct BBox
    {
        public BBox
        (
            long? xMin = null,
            long? yMin = null,
            long? xMax = null,
            long? yMax = null
        ) : this()
        {
            if (xMin is not null)
            {
                XMin = xMin.Value;
            }

            if (yMin is not null)
            {
                YMin = yMin.Value;
            }

            if (xMax is not null)
            {
                XMax = xMax.Value;
            }

            if (yMax is not null)
            {
                YMax = yMax.Value;
            }
        }


        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "xMin")]
        public long XMin;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "yMin")]
        public long YMin;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "xMax")]
        public long XMax;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "yMax")]
        public long YMax;
    }
}
