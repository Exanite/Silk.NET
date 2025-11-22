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
    [NativeName("Name", "FT_UnitVector_")]
    public unsafe partial struct UnitVector
    {
        public UnitVector
        (
            short? x = null,
            short? y = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }
        }


        [NativeName("Type", "FT_F2Dot14")]
        [NativeName("Type.Name", "FT_F2Dot14")]
        [NativeName("Name", "x")]
        public short X;

        [NativeName("Type", "FT_F2Dot14")]
        [NativeName("Type.Name", "FT_F2Dot14")]
        [NativeName("Name", "y")]
        public short Y;
    }
}
