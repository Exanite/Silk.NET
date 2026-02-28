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
    [NativeName("Name", "FT_Bitmap_Size_")]
    public unsafe partial struct BitmapSize
    {
        public BitmapSize
        (
            short? height = null,
            short? width = null,
            long? size = null,
            long? xPpem = null,
            long? yPpem = null
        ) : this()
        {
            if (height is not null)
            {
                Height = height.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (xPpem is not null)
            {
                XPpem = xPpem.Value;
            }

            if (yPpem is not null)
            {
                YPpem = yPpem.Value;
            }
        }


        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "height")]
        public short Height;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "width")]
        public short Width;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "size")]
        public long Size;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "x_ppem")]
        public long XPpem;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "y_ppem")]
        public long YPpem;
    }
}
