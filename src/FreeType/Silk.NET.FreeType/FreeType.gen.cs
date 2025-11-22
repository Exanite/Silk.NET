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
        [NativeName("Name", "ft_outline_none")]
        public const int OutlineNone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_owner")]
        public const int OutlineOwner = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_even_odd_fill")]
        public const int OutlineEvenOddFill = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_reverse_fill")]
        public const int OutlineReverseFill = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_ignore_dropouts")]
        public const int OutlineIgnoreDropouts = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_high_precision")]
        public const int OutlineHighPrecision = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_outline_single_pass")]
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
        [NativeName("Name", "FT_Curve_Tag_On")]
        public const int CurveTagOn = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_Curve_Tag_Conic")]
        public const int CurveTagConic = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_Curve_Tag_Cubic")]
        public const int CurveTagCubic = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_Curve_Tag_Touch_X")]
        public const int CurveTagTouchX = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "FT_Curve_Tag_Touch_Y")]
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
        [NativeName("Name", "ft_raster_flag_default")]
        public const int RasterFlagDefault = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_raster_flag_aa")]
        public const int RasterFlagAa = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_raster_flag_direct")]
        public const int RasterFlagDirect = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_raster_flag_clip")]
        public const int RasterFlagClip = unchecked((int) 0x4);
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
        [NativeName("Name", "ft_open_memory")]
        public const int OpenMemory = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_open_stream")]
        public const int OpenStream = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_open_pathname")]
        public const int OpenPathname = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_open_driver")]
        public const int OpenDriver = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ft_open_params")]
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


        public FreeType(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

