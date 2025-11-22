// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "__AnonymousEnum_fterrors_L195_C3")]
    public enum AnonymousEnumFterrorsL195C3 : int
    {
        [NativeName("Name", "FT_Err_Ok")]
        Ok = 0x0,
        [NativeName("Name", "FT_Err_Cannot_Open_Resource")]
        CannotOpenResource = 0x1,
        [NativeName("Name", "FT_Err_Unknown_File_Format")]
        UnknownFileFormat = 0x2,
        [NativeName("Name", "FT_Err_Invalid_File_Format")]
        InvalidFileFormat = 0x3,
        [NativeName("Name", "FT_Err_Invalid_Version")]
        InvalidVersion = 0x4,
        [NativeName("Name", "FT_Err_Lower_Module_Version")]
        LowerModuleVersion = 0x5,
        [NativeName("Name", "FT_Err_Invalid_Argument")]
        InvalidArgument = 0x6,
        [NativeName("Name", "FT_Err_Unimplemented_Feature")]
        UnimplementedFeature = 0x7,
        [NativeName("Name", "FT_Err_Invalid_Table")]
        InvalidTable = 0x8,
        [NativeName("Name", "FT_Err_Invalid_Offset")]
        InvalidOffset = 0x9,
        [NativeName("Name", "FT_Err_Array_Too_Large")]
        ArrayTooLarge = 0xA,
        [NativeName("Name", "FT_Err_Missing_Module")]
        MissingModule = 0xB,
        [NativeName("Name", "FT_Err_Missing_Property")]
        MissingProperty = 0xC,
        [NativeName("Name", "FT_Err_Invalid_Glyph_Index")]
        InvalidGlyphIndex = 0x10,
        [NativeName("Name", "FT_Err_Invalid_Character_Code")]
        InvalidCharacterCode = 0x11,
        [NativeName("Name", "FT_Err_Invalid_Glyph_Format")]
        InvalidGlyphFormat = 0x12,
        [NativeName("Name", "FT_Err_Cannot_Render_Glyph")]
        CannotRenderGlyph = 0x13,
        [NativeName("Name", "FT_Err_Invalid_Outline")]
        InvalidOutline = 0x14,
        [NativeName("Name", "FT_Err_Invalid_Composite")]
        InvalidComposite = 0x15,
        [NativeName("Name", "FT_Err_Too_Many_Hints")]
        TooManyHints = 0x16,
        [NativeName("Name", "FT_Err_Invalid_Pixel_Size")]
        InvalidPixelSize = 0x17,
        [NativeName("Name", "FT_Err_Invalid_SVG_Document")]
        InvalidSvgDocument = 0x18,
        [NativeName("Name", "FT_Err_Invalid_Handle")]
        InvalidHandle = 0x20,
        [NativeName("Name", "FT_Err_Invalid_Library_Handle")]
        InvalidLibraryHandle = 0x21,
        [NativeName("Name", "FT_Err_Invalid_Driver_Handle")]
        InvalidDriverHandle = 0x22,
        [NativeName("Name", "FT_Err_Invalid_Face_Handle")]
        InvalidFaceHandle = 0x23,
        [NativeName("Name", "FT_Err_Invalid_Size_Handle")]
        InvalidSizeHandle = 0x24,
        [NativeName("Name", "FT_Err_Invalid_Slot_Handle")]
        InvalidSlotHandle = 0x25,
        [NativeName("Name", "FT_Err_Invalid_CharMap_Handle")]
        InvalidCharMapHandle = 0x26,
        [NativeName("Name", "FT_Err_Invalid_Cache_Handle")]
        InvalidCacheHandle = 0x27,
        [NativeName("Name", "FT_Err_Invalid_Stream_Handle")]
        InvalidStreamHandle = 0x28,
        [NativeName("Name", "FT_Err_Too_Many_Drivers")]
        TooManyDrivers = 0x30,
        [NativeName("Name", "FT_Err_Too_Many_Extensions")]
        TooManyExtensions = 0x31,
        [NativeName("Name", "FT_Err_Out_Of_Memory")]
        OutOfMemory = 0x40,
        [NativeName("Name", "FT_Err_Unlisted_Object")]
        UnlistedObject = 0x41,
        [NativeName("Name", "FT_Err_Cannot_Open_Stream")]
        CannotOpenStream = 0x51,
        [NativeName("Name", "FT_Err_Invalid_Stream_Seek")]
        InvalidStreamSeek = 0x52,
        [NativeName("Name", "FT_Err_Invalid_Stream_Skip")]
        InvalidStreamSkip = 0x53,
        [NativeName("Name", "FT_Err_Invalid_Stream_Read")]
        InvalidStreamRead = 0x54,
        [NativeName("Name", "FT_Err_Invalid_Stream_Operation")]
        InvalidStreamOperation = 0x55,
        [NativeName("Name", "FT_Err_Invalid_Frame_Operation")]
        InvalidFrameOperation = 0x56,
        [NativeName("Name", "FT_Err_Nested_Frame_Access")]
        NestedFrameAccess = 0x57,
        [NativeName("Name", "FT_Err_Invalid_Frame_Read")]
        InvalidFrameRead = 0x58,
        [NativeName("Name", "FT_Err_Raster_Uninitialized")]
        RasterUninitialized = 0x60,
        [NativeName("Name", "FT_Err_Raster_Corrupted")]
        RasterCorrupted = 0x61,
        [NativeName("Name", "FT_Err_Raster_Overflow")]
        RasterOverflow = 0x62,
        [NativeName("Name", "FT_Err_Raster_Negative_Height")]
        RasterNegativeHeight = 0x63,
        [NativeName("Name", "FT_Err_Too_Many_Caches")]
        TooManyCaches = 0x70,
        [NativeName("Name", "FT_Err_Invalid_Opcode")]
        InvalidOpcode = 0x80,
        [NativeName("Name", "FT_Err_Too_Few_Arguments")]
        TooFewArguments = 0x81,
        [NativeName("Name", "FT_Err_Stack_Overflow")]
        StackOverflow = 0x82,
        [NativeName("Name", "FT_Err_Code_Overflow")]
        CodeOverflow = 0x83,
        [NativeName("Name", "FT_Err_Bad_Argument")]
        BadArgument = 0x84,
        [NativeName("Name", "FT_Err_Divide_By_Zero")]
        DivideByZero = 0x85,
        [NativeName("Name", "FT_Err_Invalid_Reference")]
        InvalidReference = 0x86,
        [NativeName("Name", "FT_Err_Debug_OpCode")]
        DebugOpCode = 0x87,
        [NativeName("Name", "FT_Err_ENDF_In_Exec_Stream")]
        EndfInExecStream = 0x88,
        [NativeName("Name", "FT_Err_Nested_DEFS")]
        NestedDefs = 0x89,
        [NativeName("Name", "FT_Err_Invalid_CodeRange")]
        InvalidCodeRange = 0x8A,
        [NativeName("Name", "FT_Err_Execution_Too_Long")]
        ExecutionTooLong = 0x8B,
        [NativeName("Name", "FT_Err_Too_Many_Function_Defs")]
        TooManyFunctionDefs = 0x8C,
        [NativeName("Name", "FT_Err_Too_Many_Instruction_Defs")]
        TooManyInstructionDefs = 0x8D,
        [NativeName("Name", "FT_Err_Table_Missing")]
        TableMissing = 0x8E,
        [NativeName("Name", "FT_Err_Horiz_Header_Missing")]
        HorizHeaderMissing = 0x8F,
        [NativeName("Name", "FT_Err_Locations_Missing")]
        LocationsMissing = 0x90,
        [NativeName("Name", "FT_Err_Name_Table_Missing")]
        NameTableMissing = 0x91,
        [NativeName("Name", "FT_Err_CMap_Table_Missing")]
        CMapTableMissing = 0x92,
        [NativeName("Name", "FT_Err_Hmtx_Table_Missing")]
        HmtxTableMissing = 0x93,
        [NativeName("Name", "FT_Err_Post_Table_Missing")]
        PostTableMissing = 0x94,
        [NativeName("Name", "FT_Err_Invalid_Horiz_Metrics")]
        InvalidHorizMetrics = 0x95,
        [NativeName("Name", "FT_Err_Invalid_CharMap_Format")]
        InvalidCharMapFormat = 0x96,
        [NativeName("Name", "FT_Err_Invalid_PPem")]
        InvalidPPem = 0x97,
        [NativeName("Name", "FT_Err_Invalid_Vert_Metrics")]
        InvalidVertMetrics = 0x98,
        [NativeName("Name", "FT_Err_Could_Not_Find_Context")]
        CouldNotFindContext = 0x99,
        [NativeName("Name", "FT_Err_Invalid_Post_Table_Format")]
        InvalidPostTableFormat = 0x9A,
        [NativeName("Name", "FT_Err_Invalid_Post_Table")]
        InvalidPostTable = 0x9B,
        [NativeName("Name", "FT_Err_DEF_In_Glyf_Bytecode")]
        DefInGlyfBytecode = 0x9C,
        [NativeName("Name", "FT_Err_Missing_Bitmap")]
        MissingBitmap = 0x9D,
        [NativeName("Name", "FT_Err_Missing_SVG_Hooks")]
        MissingSvgHooks = 0x9E,
        [NativeName("Name", "FT_Err_Syntax_Error")]
        SyntaxError = 0xA0,
        [NativeName("Name", "FT_Err_Stack_Underflow")]
        StackUnderflow = 0xA1,
        [NativeName("Name", "FT_Err_Ignore")]
        Ignore = 0xA2,
        [NativeName("Name", "FT_Err_No_Unicode_Glyph_Name")]
        NoUnicodeGlyphName = 0xA3,
        [NativeName("Name", "FT_Err_Glyph_Too_Big")]
        GlyphTooBig = 0xA4,
        [NativeName("Name", "FT_Err_Missing_Startfont_Field")]
        MissingStartfontField = 0xB0,
        [NativeName("Name", "FT_Err_Missing_Font_Field")]
        MissingFontField = 0xB1,
        [NativeName("Name", "FT_Err_Missing_Size_Field")]
        MissingSizeField = 0xB2,
        [NativeName("Name", "FT_Err_Missing_Fontboundingbox_Field")]
        MissingFontboundingboxField = 0xB3,
        [NativeName("Name", "FT_Err_Missing_Chars_Field")]
        MissingCharsField = 0xB4,
        [NativeName("Name", "FT_Err_Missing_Startchar_Field")]
        MissingStartcharField = 0xB5,
        [NativeName("Name", "FT_Err_Missing_Encoding_Field")]
        MissingEncodingField = 0xB6,
        [NativeName("Name", "FT_Err_Missing_Bbx_Field")]
        MissingBbxField = 0xB7,
        [NativeName("Name", "FT_Err_Bbx_Too_Big")]
        BbxTooBig = 0xB8,
        [NativeName("Name", "FT_Err_Corrupted_Font_Header")]
        CorruptedFontHeader = 0xB9,
        [NativeName("Name", "FT_Err_Corrupted_Font_Glyphs")]
        CorruptedFontGlyphs = 0xBA,
        [NativeName("Name", "FT_Err_Max")]
        Max = 0xBB,
    }
}
