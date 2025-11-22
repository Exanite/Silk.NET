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
    [NativeName("Name", "FT_Bitmap_")]
    public unsafe partial struct Bitmap
    {
        public Bitmap
        (
            uint? rows = null,
            uint? width = null,
            int? pitch = null,
            byte* buffer = null,
            ushort? numGrays = null,
            byte? pixelMode = null,
            byte? paletteMode = null,
            void* palette = null
        ) : this()
        {
            if (rows is not null)
            {
                Rows = rows.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (pitch is not null)
            {
                Pitch = pitch.Value;
            }

            if (buffer is not null)
            {
                Buffer = buffer;
            }

            if (numGrays is not null)
            {
                NumGrays = numGrays.Value;
            }

            if (pixelMode is not null)
            {
                PixelMode = pixelMode.Value;
            }

            if (paletteMode is not null)
            {
                PaletteMode = paletteMode.Value;
            }

            if (palette is not null)
            {
                Palette = palette;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "rows")]
        public uint Rows;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "width")]
        public uint Width;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "pitch")]
        public int Pitch;

        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "buffer")]
        public byte* Buffer;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "num_grays")]
        public ushort NumGrays;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "pixel_mode")]
        public byte PixelMode;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "palette_mode")]
        public byte PaletteMode;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "palette")]
        public void* Palette;
    }
}
