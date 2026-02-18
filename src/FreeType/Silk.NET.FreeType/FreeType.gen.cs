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
    public unsafe partial class FreeType : NativeAPI
    {
        [NativeName("Type", "long")]
        [NativeName("Name", "FT_RENDER_POOL_SIZE")]
        public const int RenderPoolSize = unchecked((int) 0x4000);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_MAX_MODULES")]
        public const int MaxModules = unchecked((int) 0x20);
        [NativeName("Type", "long")]
        [NativeName("Name", "TT_CONFIG_OPTION_MAX_RUNNABLE_OPCODES")]
        public const int TTConfigOptionMaxRunnableOpcodes = unchecked((int) 0xF4240);
        [NativeName("Type", "int")]
        [NativeName("Name", "T1_MAX_DICT_DEPTH")]
        public const int T1MaxDictDepth = unchecked((int) 0x5);
        [NativeName("Type", "int")]
        [NativeName("Name", "T1_MAX_SUBRS_CALLS")]
        public const int T1MaxSubrsCalls = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "T1_MAX_CHARSTRINGS_OPERANDS")]
        public const int T1MaxCharstringsOperands = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_X1")]
        public const int CffConfigOptionDarkeningParameterX1 = unchecked((int) 0x1F4);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_Y1")]
        public const int CffConfigOptionDarkeningParameterY1 = unchecked((int) 0x190);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_X2")]
        public const int CffConfigOptionDarkeningParameterX2 = unchecked((int) 0x3E8);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_Y2")]
        public const int CffConfigOptionDarkeningParameterY2 = unchecked((int) 0x113);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_X3")]
        public const int CffConfigOptionDarkeningParameterX3 = unchecked((int) 0x683);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_Y3")]
        public const int CffConfigOptionDarkeningParameterY3 = unchecked((int) 0x113);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_X4")]
        public const int CffConfigOptionDarkeningParameterX4 = unchecked((int) 0x91D);
        [NativeName("Type", "int")]
        [NativeName("Name", "CFF_CONFIG_OPTION_DARKENING_PARAMETER_Y4")]
        public const int CffConfigOptionDarkeningParameterY4 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CHAR_BIT")]
        public const int CharBit = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_USHORT_MAX")]
        public const int UshortMax = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_INT_MAX")]
        public const int IntMax = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "FT_UINT_MAX")]
        public const uint UintMax = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "long")]
        [NativeName("Name", "FT_LONG_MAX")]
        public const int LongMax = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "unsigned long")]
        [NativeName("Name", "FT_ULONG_MAX")]
        public const uint UlongMax = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "long long")]
        [NativeName("Name", "FT_LLONG_MAX")]
        public const long LlongMax = unchecked((long) 0x7FFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned long long")]
        [NativeName("Name", "FT_ULLONG_MAX")]
        public const ulong UllongMax = unchecked((ulong) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_INT64_ZERO")]
        public const int Int64Zero = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_CONTOURS_MAX")]
        public const int OutlineContoursMax = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_POINTS_MAX")]
        public const int OutlinePointsMax = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_NONE")]
        public const int OutlineNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_OWNER")]
        public const int OutlineOwner = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_EVEN_ODD_FILL")]
        public const int OutlineEvenOddFill = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_REVERSE_FILL")]
        public const int OutlineReverseFill = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_IGNORE_DROPOUTS")]
        public const int OutlineIgnoreDropouts = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_SMART_DROPOUTS")]
        public const int OutlineSmartDropouts = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_INCLUDE_STUBS")]
        public const int OutlineIncludeStubs = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_OVERLAP")]
        public const int OutlineOverlap = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_HIGH_PRECISION")]
        public const int OutlineHighPrecision = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OUTLINE_SINGLE_PASS")]
        public const int OutlineSinglePass = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_ON")]
        public const int CurveTagOn = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_CONIC")]
        public const int CurveTagConic = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_CUBIC")]
        public const int CurveTagCubic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_HAS_SCANMODE")]
        public const int CurveTagHasScanmode = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_TOUCH_X")]
        public const int CurveTagTouchX = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_CURVE_TAG_TOUCH_Y")]
        public const int CurveTagTouchY = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_RASTER_FLAG_DEFAULT")]
        public const int RasterFlagDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_RASTER_FLAG_AA")]
        public const int RasterFlagAA = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_RASTER_FLAG_DIRECT")]
        public const int RasterFlagDirect = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_RASTER_FLAG_CLIP")]
        public const int RasterFlagClip = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_RASTER_FLAG_SDF")]
        public const int RasterFlagSdf = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_ERR_BASE")]
        public const int ErrBase = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OPEN_MEMORY")]
        public const int OpenMemory = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OPEN_STREAM")]
        public const int OpenStream = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OPEN_PATHNAME")]
        public const int OpenPathname = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OPEN_DRIVER")]
        public const int OpenDriver = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_OPEN_PARAMS")]
        public const int OpenParams = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_LOAD_DEFAULT")]
        public const int LoadDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_ARGS_ARE_WORDS")]
        public const int SubglyphFlagArgsAreWords = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_ARGS_ARE_XY_VALUES")]
        public const int SubglyphFlagArgsAreXYValues = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_ROUND_XY_TO_GRID")]
        public const int SubglyphFlagRoundXYToGrid = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_SCALE")]
        public const int SubglyphFlagScale = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_XY_SCALE")]
        public const int SubglyphFlagXYScale = unchecked((int) 0x40);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_2X2")]
        public const int SubglyphFlag2X2 = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_SUBGLYPH_FLAG_USE_MY_METRICS")]
        public const int SubglyphFlagUseMYMetrics = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_INSTALLABLE_EMBEDDING")]
        public const int FstypeInstallableEmbedding = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_RESTRICTED_LICENSE_EMBEDDING")]
        public const int FstypeRestrictedLicenseEmbedding = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_PREVIEW_AND_PRINT_EMBEDDING")]
        public const int FstypePreviewAndPrintEmbedding = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_EDITABLE_EMBEDDING")]
        public const int FstypeEditableEmbedding = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_NO_SUBSETTING")]
        public const int FstypeNoSubsetting = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_FSTYPE_BITMAP_EMBEDDING_ONLY")]
        public const int FstypeBitmapEmbeddingOnly = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "FREETYPE_MAJOR")]
        public const int FreetypeMajor = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FREETYPE_MINOR")]
        public const int FreetypeMinor = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "FREETYPE_PATCH")]
        public const int FreetypePatch = unchecked((int) 0x1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 3 in fterrors.h")]
        [NativeApi(EntryPoint = "FT_Error_String")]
        public unsafe partial byte* ErrorString(int error_code);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 3 in fterrors.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "FT_Error_String")]
        public partial string ErrorStringS(int error_code);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2351, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Init_FreeType")]
        public unsafe partial int InitFreeType(LibraryRec** alibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2351, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Init_FreeType")]
        public unsafe partial int InitFreeType(ref LibraryRec* alibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2371, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Done_FreeType")]
        public unsafe partial int DoneFreeType(LibraryRec* library);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filepathname, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filepathname, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte filepathname, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte filepathname, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filepathname, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Face")]
        public unsafe partial int NewFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filepathname, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_base, int file_size, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_base, int file_size, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_base, int file_size, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_base, int file_size, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_base, int file_size, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_New_Memory_Face")]
        public unsafe partial int NewMemoryFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_base, int file_size, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Open_Face")]
        public unsafe partial int OpenFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OpenArgs* args, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Open_Face")]
        public unsafe partial int OpenFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OpenArgs* args, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Open_Face")]
        public unsafe partial int OpenFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly OpenArgs args, int face_index, FaceRec** aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Open_Face")]
        public unsafe partial int OpenFace(LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly OpenArgs args, int face_index, ref FaceRec* aface);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public unsafe partial int AttachFile(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public unsafe partial int AttachFile(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public unsafe partial int AttachFile(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public unsafe partial int AttachFile(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public partial int AttachFile(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_File")]
        public partial int AttachFile(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filepathname);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_Stream")]
        public unsafe partial int AttachStream(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OpenArgs* parameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_Stream")]
        public unsafe partial int AttachStream(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly OpenArgs parameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_Stream")]
        public unsafe partial int AttachStream(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OpenArgs* parameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Attach_Stream")]
        public partial int AttachStream(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly OpenArgs parameters);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2855, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Reference_Face")]
        public unsafe partial int ReferenceFace(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2855, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Reference_Face")]
        public partial int ReferenceFace(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2879, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Done_Face")]
        public unsafe partial int DoneFace(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2879, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Done_Face")]
        public partial int DoneFace(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2926, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Select_Size")]
        public unsafe partial int SelectSize(FaceRec* face, int strike_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2926, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Select_Size")]
        public partial int SelectSize(ref FaceRec face, int strike_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Request_Size")]
        public unsafe partial int RequestSize(FaceRec* face, SizeRequestRec* req);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Request_Size")]
        public unsafe partial int RequestSize(FaceRec* face, ref SizeRequestRec req);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Request_Size")]
        public unsafe partial int RequestSize(ref FaceRec face, SizeRequestRec* req);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Request_Size")]
        public partial int RequestSize(ref FaceRec face, ref SizeRequestRec req);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3139, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Char_Size")]
        public unsafe partial int SetCharSize(FaceRec* face, int char_width, int char_height, uint horz_resolution, uint vert_resolution);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3139, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Char_Size")]
        public partial int SetCharSize(ref FaceRec face, int char_width, int char_height, uint horz_resolution, uint vert_resolution);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3176, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Pixel_Sizes")]
        public unsafe partial int SetPixelSizes(FaceRec* face, uint pixel_width, uint pixel_height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3176, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Pixel_Sizes")]
        public partial int SetPixelSizes(ref FaceRec face, uint pixel_width, uint pixel_height);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3231, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Load_Glyph")]
        public unsafe partial int LoadGlyph(FaceRec* face, uint glyph_index, int load_flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3231, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Load_Glyph")]
        public partial int LoadGlyph(ref FaceRec face, uint glyph_index, int load_flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3281, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Load_Char")]
        public unsafe partial int LoadChar(FaceRec* face, uint char_code, int load_flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3281, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Load_Char")]
        public partial int LoadChar(ref FaceRec face, uint char_code, int load_flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(FaceRec* face, Matrix* matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(FaceRec* face, ref Matrix matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(FaceRec* face, ref Matrix matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(ref FaceRec face, Matrix* matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(ref FaceRec face, Matrix* matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public unsafe partial void SetTransform(ref FaceRec face, ref Matrix matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Transform")]
        public partial void SetTransform(ref FaceRec face, ref Matrix matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(FaceRec* face, Matrix* matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(FaceRec* face, Matrix* matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(FaceRec* face, ref Matrix matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(FaceRec* face, ref Matrix matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(ref FaceRec face, Matrix* matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(ref FaceRec face, Matrix* matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public unsafe partial void GetTransform(ref FaceRec face, ref Matrix matrix, Vector* delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Transform")]
        public partial void GetTransform(ref FaceRec face, ref Matrix matrix, ref Vector delta);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3915, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Render_Glyph")]
        public unsafe partial int RenderGlyph(GlyphSlotRec* slot, RenderMode render_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3915, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Render_Glyph")]
        public partial int RenderGlyph(ref GlyphSlotRec slot, RenderMode render_mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Kerning")]
        public unsafe partial int GetKerning(FaceRec* face, uint left_glyph, uint right_glyph, uint kern_mode, Vector* akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Kerning")]
        public unsafe partial int GetKerning(FaceRec* face, uint left_glyph, uint right_glyph, uint kern_mode, ref Vector akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Kerning")]
        public unsafe partial int GetKerning(ref FaceRec face, uint left_glyph, uint right_glyph, uint kern_mode, Vector* akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Kerning")]
        public partial int GetKerning(ref FaceRec face, uint left_glyph, uint right_glyph, uint kern_mode, ref Vector akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Track_Kerning")]
        public unsafe partial int GetTrackKerning(FaceRec* face, int point_size, int degree, int* akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Track_Kerning")]
        public unsafe partial int GetTrackKerning(FaceRec* face, int point_size, int degree, ref int akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Track_Kerning")]
        public unsafe partial int GetTrackKerning(ref FaceRec face, int point_size, int degree, int* akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Track_Kerning")]
        public partial int GetTrackKerning(ref FaceRec face, int point_size, int degree, ref int akerning);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4110, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Select_Charmap")]
        public unsafe partial int SelectCharmap(FaceRec* face, Encoding encoding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4110, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Select_Charmap")]
        public partial int SelectCharmap(ref FaceRec face, Encoding encoding);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Charmap")]
        public unsafe partial int SetCharmap(FaceRec* face, CharMapRec* charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Charmap")]
        public unsafe partial int SetCharmap(FaceRec* face, ref CharMapRec charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Charmap")]
        public unsafe partial int SetCharmap(ref FaceRec face, CharMapRec* charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Set_Charmap")]
        public partial int SetCharmap(ref FaceRec face, ref CharMapRec charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4163, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Charmap_Index")]
        public unsafe partial int GetCharmapIndex(CharMapRec* charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4163, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Charmap_Index")]
        public partial int GetCharmapIndex(ref CharMapRec charmap);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4198, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Char_Index")]
        public unsafe partial uint GetCharIndex(FaceRec* face, uint charcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4198, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Char_Index")]
        public partial uint GetCharIndex(ref FaceRec face, uint charcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_First_Char")]
        public unsafe partial uint GetFirstChar(FaceRec* face, uint* agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_First_Char")]
        public unsafe partial uint GetFirstChar(FaceRec* face, ref uint agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_First_Char")]
        public unsafe partial uint GetFirstChar(ref FaceRec face, uint* agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_First_Char")]
        public partial uint GetFirstChar(ref FaceRec face, ref uint agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Next_Char")]
        public unsafe partial uint GetNextChar(FaceRec* face, uint char_code, uint* agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Next_Char")]
        public unsafe partial uint GetNextChar(FaceRec* face, uint char_code, ref uint agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Next_Char")]
        public unsafe partial uint GetNextChar(ref FaceRec face, uint char_code, uint* agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Next_Char")]
        public partial uint GetNextChar(ref FaceRec face, uint char_code, ref uint agindex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_Properties")]
        public unsafe partial int FaceProperties(FaceRec* face, uint num_properties, Parameter* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_Properties")]
        public unsafe partial int FaceProperties(FaceRec* face, uint num_properties, ref Parameter properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_Properties")]
        public unsafe partial int FaceProperties(ref FaceRec face, uint num_properties, Parameter* properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_Properties")]
        public partial int FaceProperties(ref FaceRec face, uint num_properties, ref Parameter properties);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public unsafe partial uint GetNameIndex(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public unsafe partial uint GetNameIndex(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public unsafe partial uint GetNameIndex(FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public unsafe partial uint GetNameIndex(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public partial uint GetNameIndex(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Name_Index")]
        public partial uint GetNameIndex(ref FaceRec face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string glyph_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Glyph_Name")]
        public unsafe partial int GetGlyphName(FaceRec* face, uint glyph_index, void* buffer, uint buffer_max);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Glyph_Name")]
        public unsafe partial int GetGlyphName<T0>(FaceRec* face, uint glyph_index, ref T0 buffer, uint buffer_max) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Glyph_Name")]
        public unsafe partial int GetGlyphName(ref FaceRec face, uint glyph_index, void* buffer, uint buffer_max);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Glyph_Name")]
        public partial int GetGlyphName<T0>(ref FaceRec face, uint glyph_index, ref T0 buffer, uint buffer_max) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4524, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Postscript_Name")]
        public unsafe partial byte* GetPostscriptName(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4524, Column 3 in freetype.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "FT_Get_Postscript_Name")]
        public unsafe partial string GetPostscriptNameS(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4524, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_Postscript_Name")]
        public unsafe partial byte* GetPostscriptName(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4524, Column 3 in freetype.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "FT_Get_Postscript_Name")]
        public partial string GetPostscriptNameS(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(GlyphSlotRec* glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, int* p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, uint* p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, int* p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, int* p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public unsafe partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, Matrix* p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_SubGlyph_Info")]
        public partial int GetSubGlyphInfo(ref GlyphSlotRec glyph, uint sub_index, ref int p_index, ref uint p_flags, ref int p_arg1, ref int p_arg2, ref Matrix p_transform);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4699, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_FSType_Flags")]
        public unsafe partial ushort GetFSTypeFlags(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4699, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Get_FSType_Flags")]
        public partial ushort GetFSTypeFlags(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4793, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharVariantIndex")]
        public unsafe partial uint FaceGetCharVariantIndex(FaceRec* face, uint charcode, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4793, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharVariantIndex")]
        public partial uint FaceGetCharVariantIndex(ref FaceRec face, uint charcode, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4830, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        public unsafe partial int FaceGetCharVariantIsDefault(FaceRec* face, uint charcode, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4830, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharVariantIsDefault")]
        public partial int FaceGetCharVariantIsDefault(ref FaceRec face, uint charcode, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4862, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetVariantSelectors")]
        public unsafe partial uint* FaceGetVariantSelectors(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4862, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetVariantSelectors")]
        public unsafe partial uint* FaceGetVariantSelectors(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4896, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetVariantsOfChar")]
        public unsafe partial uint* FaceGetVariantsOfChar(FaceRec* face, uint charcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4896, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetVariantsOfChar")]
        public unsafe partial uint* FaceGetVariantsOfChar(ref FaceRec face, uint charcode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4931, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharsOfVariant")]
        public unsafe partial uint* FaceGetCharsOfVariant(FaceRec* face, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4931, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_GetCharsOfVariant")]
        public unsafe partial uint* FaceGetCharsOfVariant(ref FaceRec face, uint variantSelector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4998, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_MulDiv")]
        public partial int MulDiv(int a, int b, int c);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5034, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_MulFix")]
        public partial int MulFix(int a, int b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5058, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_DivFix")]
        public partial int DivFix(int a, int b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5082, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_RoundFix")]
        public partial int RoundFix(int a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5104, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_CeilFix")]
        public partial int CeilFix(int a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5123, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_FloorFix")]
        public partial int FloorFix(int a);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Vector_Transform")]
        public unsafe partial void VectorTransform(Vector* vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Vector_Transform")]
        public unsafe partial void VectorTransform(Vector* vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Vector_Transform")]
        public unsafe partial void VectorTransform(ref Vector vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Vector_Transform")]
        public partial void VectorTransform(ref Vector vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix matrix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, int* amajor, int* aminor, int* apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, int* amajor, int* aminor, ref int apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, int* amajor, ref int aminor, int* apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, int* amajor, ref int aminor, ref int apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, ref int amajor, int* aminor, int* apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, ref int amajor, int* aminor, ref int apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, ref int amajor, ref int aminor, int* apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Library_Version")]
        public unsafe partial void LibraryVersion(LibraryRec* library, ref int amajor, ref int aminor, ref int apatch);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_CheckTrueTypePatents")]
        public unsafe partial byte FaceCheckTrueTypePatents(FaceRec* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5253, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_CheckTrueTypePatents")]
        public partial byte FaceCheckTrueTypePatents(ref FaceRec face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5282, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_SetUnpatentedHinting")]
        public unsafe partial byte FaceSetUnpatentedHinting(FaceRec* face, byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5282, Column 3 in freetype.h")]
        [NativeApi(EntryPoint = "FT_Face_SetUnpatentedHinting")]
        public partial byte FaceSetUnpatentedHinting(ref FaceRec face, byte value);


        public FreeType(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

