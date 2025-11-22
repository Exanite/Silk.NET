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
    [NativeName("Name", "FT_Outline_")]
    public unsafe partial struct Outline
    {
        public Outline
        (
            ushort? nContours = null,
            ushort? nPoints = null,
            Vector* points = null,
            byte* tags = null,
            ushort* contours = null,
            int? flags = null
        ) : this()
        {
            if (nContours is not null)
            {
                NContours = nContours.Value;
            }

            if (nPoints is not null)
            {
                NPoints = nPoints.Value;
            }

            if (points is not null)
            {
                Points = points;
            }

            if (tags is not null)
            {
                Tags = tags;
            }

            if (contours is not null)
            {
                Contours = contours;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "n_contours")]
        public ushort NContours;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "n_points")]
        public ushort NPoints;

        [NativeName("Type", "FT_Vector *")]
        [NativeName("Type.Name", "FT_Vector *")]
        [NativeName("Name", "points")]
        public Vector* Points;

        [NativeName("Type", "unsigned char *")]
        [NativeName("Type.Name", "unsigned char *")]
        [NativeName("Name", "tags")]
        public byte* Tags;

        [NativeName("Type", "unsigned short *")]
        [NativeName("Type.Name", "unsigned short *")]
        [NativeName("Name", "contours")]
        public ushort* Contours;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "flags")]
        public int Flags;
    }
}
