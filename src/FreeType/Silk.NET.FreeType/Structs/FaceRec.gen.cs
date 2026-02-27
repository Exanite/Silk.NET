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
    [NativeName("Name", "FT_FaceRec_")]
    public unsafe partial struct FaceRec
    {
        public FaceRec
        (
            nint? numFaces = null,
            nint? faceIndex = null,
            nint? faceFlags = null,
            nint? styleFlags = null,
            nint? numGlyphs = null,
            byte* familyName = null,
            byte* styleName = null,
            int? numFixedSizes = null,
            BitmapSize* availableSizes = null,
            int? numCharmaps = null,
            CharMapRec** charmaps = null,
            Generic? generic = null,
            BBox? bbox = null,
            ushort? unitsPerEM = null,
            short? ascender = null,
            short? descender = null,
            short? height = null,
            short? maxAdvanceWidth = null,
            short? maxAdvanceHeight = null,
            short? underlinePosition = null,
            short? underlineThickness = null,
            GlyphSlotRec* glyph = null,
            SizeRec* size = null,
            CharMapRec* charmap = null,
            DriverRec* driver = null,
            MemoryRec* memory = null,
            StreamRec* stream = null,
            ListRec? sizesList = null,
            Generic? autohint = null,
            void* extensions = null,
            FaceInternalRec* @internal = null
        ) : this()
        {
            if (numFaces is not null)
            {
                NumFaces = numFaces.Value;
            }

            if (faceIndex is not null)
            {
                FaceIndex = faceIndex.Value;
            }

            if (faceFlags is not null)
            {
                FaceFlags = faceFlags.Value;
            }

            if (styleFlags is not null)
            {
                StyleFlags = styleFlags.Value;
            }

            if (numGlyphs is not null)
            {
                NumGlyphs = numGlyphs.Value;
            }

            if (familyName is not null)
            {
                FamilyName = familyName;
            }

            if (styleName is not null)
            {
                StyleName = styleName;
            }

            if (numFixedSizes is not null)
            {
                NumFixedSizes = numFixedSizes.Value;
            }

            if (availableSizes is not null)
            {
                AvailableSizes = availableSizes;
            }

            if (numCharmaps is not null)
            {
                NumCharmaps = numCharmaps.Value;
            }

            if (charmaps is not null)
            {
                Charmaps = charmaps;
            }

            if (generic is not null)
            {
                Generic = generic.Value;
            }

            if (bbox is not null)
            {
                Bbox = bbox.Value;
            }

            if (unitsPerEM is not null)
            {
                UnitsPerEM = unitsPerEM.Value;
            }

            if (ascender is not null)
            {
                Ascender = ascender.Value;
            }

            if (descender is not null)
            {
                Descender = descender.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (maxAdvanceWidth is not null)
            {
                MaxAdvanceWidth = maxAdvanceWidth.Value;
            }

            if (maxAdvanceHeight is not null)
            {
                MaxAdvanceHeight = maxAdvanceHeight.Value;
            }

            if (underlinePosition is not null)
            {
                UnderlinePosition = underlinePosition.Value;
            }

            if (underlineThickness is not null)
            {
                UnderlineThickness = underlineThickness.Value;
            }

            if (glyph is not null)
            {
                Glyph = glyph;
            }

            if (size is not null)
            {
                Size = size;
            }

            if (charmap is not null)
            {
                Charmap = charmap;
            }

            if (driver is not null)
            {
                Driver = driver;
            }

            if (memory is not null)
            {
                Memory = memory;
            }

            if (stream is not null)
            {
                Stream = stream;
            }

            if (sizesList is not null)
            {
                SizesList = sizesList.Value;
            }

            if (autohint is not null)
            {
                Autohint = autohint.Value;
            }

            if (extensions is not null)
            {
                Extensions = extensions;
            }

            if (@internal is not null)
            {
                Internal = @internal;
            }
        }


        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "num_faces")]
        public nint NumFaces;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "face_index")]
        public nint FaceIndex;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "face_flags")]
        public nint FaceFlags;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "style_flags")]
        public nint StyleFlags;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "num_glyphs")]
        public nint NumGlyphs;

        [NativeName("Type", "FT_String *")]
        [NativeName("Type.Name", "FT_String *")]
        [NativeName("Name", "family_name")]
        public byte* FamilyName;

        [NativeName("Type", "FT_String *")]
        [NativeName("Type.Name", "FT_String *")]
        [NativeName("Name", "style_name")]
        public byte* StyleName;

        [NativeName("Type", "FT_Int")]
        [NativeName("Type.Name", "FT_Int")]
        [NativeName("Name", "num_fixed_sizes")]
        public int NumFixedSizes;

        [NativeName("Type", "FT_Bitmap_Size *")]
        [NativeName("Type.Name", "FT_Bitmap_Size *")]
        [NativeName("Name", "available_sizes")]
        public BitmapSize* AvailableSizes;

        [NativeName("Type", "FT_Int")]
        [NativeName("Type.Name", "FT_Int")]
        [NativeName("Name", "num_charmaps")]
        public int NumCharmaps;

        [NativeName("Type", "FT_CharMap *")]
        [NativeName("Type.Name", "FT_CharMap *")]
        [NativeName("Name", "charmaps")]
        public CharMapRec** Charmaps;

        [NativeName("Type", "FT_Generic")]
        [NativeName("Type.Name", "FT_Generic")]
        [NativeName("Name", "generic")]
        public Generic Generic;

        [NativeName("Type", "FT_BBox")]
        [NativeName("Type.Name", "FT_BBox")]
        [NativeName("Name", "bbox")]
        public BBox Bbox;

        [NativeName("Type", "FT_UShort")]
        [NativeName("Type.Name", "FT_UShort")]
        [NativeName("Name", "units_per_EM")]
        public ushort UnitsPerEM;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "ascender")]
        public short Ascender;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "descender")]
        public short Descender;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "height")]
        public short Height;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "max_advance_width")]
        public short MaxAdvanceWidth;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "max_advance_height")]
        public short MaxAdvanceHeight;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "underline_position")]
        public short UnderlinePosition;

        [NativeName("Type", "FT_Short")]
        [NativeName("Type.Name", "FT_Short")]
        [NativeName("Name", "underline_thickness")]
        public short UnderlineThickness;

        [NativeName("Type", "FT_GlyphSlot")]
        [NativeName("Type.Name", "FT_GlyphSlot")]
        [NativeName("Name", "glyph")]
        public GlyphSlotRec* Glyph;

        [NativeName("Type", "FT_Size")]
        [NativeName("Type.Name", "FT_Size")]
        [NativeName("Name", "size")]
        public SizeRec* Size;

        [NativeName("Type", "FT_CharMap")]
        [NativeName("Type.Name", "FT_CharMap")]
        [NativeName("Name", "charmap")]
        public CharMapRec* Charmap;

        [NativeName("Type", "FT_Driver")]
        [NativeName("Type.Name", "FT_Driver")]
        [NativeName("Name", "driver")]
        public DriverRec* Driver;

        [NativeName("Type", "FT_Memory")]
        [NativeName("Type.Name", "FT_Memory")]
        [NativeName("Name", "memory")]
        public MemoryRec* Memory;

        [NativeName("Type", "FT_Stream")]
        [NativeName("Type.Name", "FT_Stream")]
        [NativeName("Name", "stream")]
        public StreamRec* Stream;

        [NativeName("Type", "FT_ListRec")]
        [NativeName("Type.Name", "FT_ListRec")]
        [NativeName("Name", "sizes_list")]
        public ListRec SizesList;

        [NativeName("Type", "FT_Generic")]
        [NativeName("Type.Name", "FT_Generic")]
        [NativeName("Name", "autohint")]
        public Generic Autohint;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "extensions")]
        public void* Extensions;

        [NativeName("Type", "FT_Face_Internal")]
        [NativeName("Type.Name", "FT_Face_Internal")]
        [NativeName("Name", "internal")]
        public FaceInternalRec* Internal;
    }
}
