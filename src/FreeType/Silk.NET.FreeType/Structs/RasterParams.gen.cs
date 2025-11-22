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
    [NativeName("Name", "FT_Raster_Params_")]
    public unsafe partial struct RasterParams
    {
        public RasterParams
        (
            Bitmap* target = null,
            void* source = null,
            int? flags = null,
            PfnSpanFunc? graySpans = null,
            PfnSpanFunc? blackSpans = null,
            PfnRasterBitTestFunc? bitTest = null,
            PfnRasterBitSetFunc? bitSet = null,
            void* user = null,
            BBox? clipBox = null
        ) : this()
        {
            if (target is not null)
            {
                Target = target;
            }

            if (source is not null)
            {
                Source = source;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (graySpans is not null)
            {
                GraySpans = graySpans.Value;
            }

            if (blackSpans is not null)
            {
                BlackSpans = blackSpans.Value;
            }

            if (bitTest is not null)
            {
                BitTest = bitTest.Value;
            }

            if (bitSet is not null)
            {
                BitSet = bitSet.Value;
            }

            if (user is not null)
            {
                User = user;
            }

            if (clipBox is not null)
            {
                ClipBox = clipBox.Value;
            }
        }


        [NativeName("Type", "const FT_Bitmap *")]
        [NativeName("Type.Name", "const FT_Bitmap *")]
        [NativeName("Name", "target")]
        public Bitmap* Target;

        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "source")]
        public void* Source;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "flags")]
        public int Flags;

        [NativeName("Type", "FT_SpanFunc")]
        [NativeName("Type.Name", "FT_SpanFunc")]
        [NativeName("Name", "gray_spans")]
        public PfnSpanFunc GraySpans;

        [NativeName("Type", "FT_SpanFunc")]
        [NativeName("Type.Name", "FT_SpanFunc")]
        [NativeName("Name", "black_spans")]
        public PfnSpanFunc BlackSpans;

        [NativeName("Type", "FT_Raster_BitTest_Func")]
        [NativeName("Type.Name", "FT_Raster_BitTest_Func")]
        [NativeName("Name", "bit_test")]
        public PfnRasterBitTestFunc BitTest;

        [NativeName("Type", "FT_Raster_BitSet_Func")]
        [NativeName("Type.Name", "FT_Raster_BitSet_Func")]
        [NativeName("Name", "bit_set")]
        public PfnRasterBitSetFunc BitSet;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "user")]
        public void* User;

        [NativeName("Type", "FT_BBox")]
        [NativeName("Type.Name", "FT_BBox")]
        [NativeName("Name", "clip_box")]
        public BBox ClipBox;
    }
}
