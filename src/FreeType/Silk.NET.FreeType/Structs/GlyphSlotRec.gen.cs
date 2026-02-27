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
    [NativeName("Name", "FT_GlyphSlotRec_")]
    public unsafe partial struct GlyphSlotRec
    {
        public GlyphSlotRec
        (
            LibraryRec* library = null,
            FaceRec* face = null,
            GlyphSlotRec* next = null,
            uint? glyphIndex = null,
            Generic? generic = null,
            GlyphMetrics? metrics = null,
            nint? linearHoriAdvance = null,
            nint? linearVertAdvance = null,
            Vector? advance = null,
            GlyphFormat? format = null,
            Bitmap? bitmap = null,
            int? bitmapLeft = null,
            int? bitmapTop = null,
            Outline? outline = null,
            uint? numSubglyphs = null,
            SubGlyphRec* subglyphs = null,
            void* controlData = null,
            int? controlLen = null,
            int? lsbDelta = null,
            int? rsbDelta = null,
            void* other = null,
            SlotInternalRec* @internal = null
        ) : this()
        {
            if (library is not null)
            {
                Library = library;
            }

            if (face is not null)
            {
                Face = face;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (glyphIndex is not null)
            {
                GlyphIndex = glyphIndex.Value;
            }

            if (generic is not null)
            {
                Generic = generic.Value;
            }

            if (metrics is not null)
            {
                Metrics = metrics.Value;
            }

            if (linearHoriAdvance is not null)
            {
                LinearHoriAdvance = linearHoriAdvance.Value;
            }

            if (linearVertAdvance is not null)
            {
                LinearVertAdvance = linearVertAdvance.Value;
            }

            if (advance is not null)
            {
                Advance = advance.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (bitmap is not null)
            {
                Bitmap = bitmap.Value;
            }

            if (bitmapLeft is not null)
            {
                BitmapLeft = bitmapLeft.Value;
            }

            if (bitmapTop is not null)
            {
                BitmapTop = bitmapTop.Value;
            }

            if (outline is not null)
            {
                Outline = outline.Value;
            }

            if (numSubglyphs is not null)
            {
                NumSubglyphs = numSubglyphs.Value;
            }

            if (subglyphs is not null)
            {
                Subglyphs = subglyphs;
            }

            if (controlData is not null)
            {
                ControlData = controlData;
            }

            if (controlLen is not null)
            {
                ControlLen = controlLen.Value;
            }

            if (lsbDelta is not null)
            {
                LsbDelta = lsbDelta.Value;
            }

            if (rsbDelta is not null)
            {
                RsbDelta = rsbDelta.Value;
            }

            if (other is not null)
            {
                Other = other;
            }

            if (@internal is not null)
            {
                Internal = @internal;
            }
        }


        [NativeName("Type", "FT_Library")]
        [NativeName("Type.Name", "FT_Library")]
        [NativeName("Name", "library")]
        public LibraryRec* Library;

        [NativeName("Type", "FT_Face")]
        [NativeName("Type.Name", "FT_Face")]
        [NativeName("Name", "face")]
        public FaceRec* Face;

        [NativeName("Type", "FT_GlyphSlot")]
        [NativeName("Type.Name", "FT_GlyphSlot")]
        [NativeName("Name", "next")]
        public GlyphSlotRec* Next;

        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "glyph_index")]
        public uint GlyphIndex;

        [NativeName("Type", "FT_Generic")]
        [NativeName("Type.Name", "FT_Generic")]
        [NativeName("Name", "generic")]
        public Generic Generic;

        [NativeName("Type", "FT_Glyph_Metrics")]
        [NativeName("Type.Name", "FT_Glyph_Metrics")]
        [NativeName("Name", "metrics")]
        public GlyphMetrics Metrics;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "linearHoriAdvance")]
        public nint LinearHoriAdvance;

        [NativeName("Type", "FT_Fixed")]
        [NativeName("Type.Name", "FT_Fixed")]
        [NativeName("Name", "linearVertAdvance")]
        public nint LinearVertAdvance;

        [NativeName("Type", "FT_Vector")]
        [NativeName("Type.Name", "FT_Vector")]
        [NativeName("Name", "advance")]
        public Vector Advance;

        [NativeName("Type", "FT_Glyph_Format")]
        [NativeName("Type.Name", "FT_Glyph_Format")]
        [NativeName("Name", "format")]
        public GlyphFormat Format;

        [NativeName("Type", "FT_Bitmap")]
        [NativeName("Type.Name", "FT_Bitmap")]
        [NativeName("Name", "bitmap")]
        public Bitmap Bitmap;

        [NativeName("Type", "FT_Int")]
        [NativeName("Type.Name", "FT_Int")]
        [NativeName("Name", "bitmap_left")]
        public int BitmapLeft;

        [NativeName("Type", "FT_Int")]
        [NativeName("Type.Name", "FT_Int")]
        [NativeName("Name", "bitmap_top")]
        public int BitmapTop;

        [NativeName("Type", "FT_Outline")]
        [NativeName("Type.Name", "FT_Outline")]
        [NativeName("Name", "outline")]
        public Outline Outline;

        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "num_subglyphs")]
        public uint NumSubglyphs;

        [NativeName("Type", "FT_SubGlyph")]
        [NativeName("Type.Name", "FT_SubGlyph")]
        [NativeName("Name", "subglyphs")]
        public SubGlyphRec* Subglyphs;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "control_data")]
        public void* ControlData;

        [NativeName("Type", "long")]
        [NativeName("Type.Name", "long")]
        [NativeName("Name", "control_len")]
        public int ControlLen;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "lsb_delta")]
        public int LsbDelta;

        [NativeName("Type", "FT_Pos")]
        [NativeName("Type.Name", "FT_Pos")]
        [NativeName("Name", "rsb_delta")]
        public int RsbDelta;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "other")]
        public void* Other;

        [NativeName("Type", "FT_Slot_Internal")]
        [NativeName("Type.Name", "FT_Slot_Internal")]
        [NativeName("Name", "internal")]
        public SlotInternalRec* Internal;
    }
}
