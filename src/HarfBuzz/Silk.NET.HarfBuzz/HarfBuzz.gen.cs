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

namespace Silk.NET.HarfBuzz
{
    public unsafe partial class HarfBuzz : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "HB_FEATURE_GLOBAL_START")]
        public const int FeatureGlobalStart = unchecked((int) 0x0);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "HB_UNICODE_MAX")]
        public const uint UnicodeMax = unchecked((uint) 0x10FFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "HB_FONT_NO_VAR_NAMED_INSTANCE")]
        public const uint FontNoVarNamedInstance = unchecked((uint) 0xFFFFFFFFFFFFFFFF);
        [NativeName("Type", "unsigned int")]
        [NativeName("Name", "HB_BUFFER_REPLACEMENT_CODEPOINT_DEFAULT")]
        public const uint BufferReplacementCodepointDefault = unchecked((uint) 0xFFFD);
        [NativeName("Type", "int")]
        [NativeName("Name", "HB_UNICODE_COMBINING_CLASS_CCC133")]
        public const int UnicodeCombiningClassCcc133 = unchecked((int) 0x85);
        [NativeName("Type", "int")]
        [NativeName("Name", "HB_VERSION_MAJOR")]
        public const int VersionMajor = unchecked((int) 0xC);
        [NativeName("Type", "int")]
        [NativeName("Name", "HB_VERSION_MINOR")]
        public const int VersionMinor = unchecked((int) 0x3);
        [NativeName("Type", "int")]
        [NativeName("Name", "HB_VERSION_MICRO")]
        public const int VersionMicro = unchecked((int) 0x2);
        [NativeName("Type", "")]
        [NativeName("Name", "HB_VERSION_STRING")]
        public const string LibraryVersionString = unchecked((string) "12.3.2");

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_from_string")]
        public unsafe partial uint TagFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_from_string")]
        public partial uint TagFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_from_string")]
        public partial uint TagFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_to_string")]
        public unsafe partial void TagToString(uint tag, byte* buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_to_string")]
        public partial void TagToString(uint tag, ref byte buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_tag_to_string")]
        public partial void TagToString(uint tag, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_direction_from_string")]
        public unsafe partial DirectionT DirectionFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_direction_from_string")]
        public partial DirectionT DirectionFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_direction_from_string")]
        public partial DirectionT DirectionFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_direction_to_string")]
        public unsafe partial byte* DirectionToString(DirectionT direction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 1 in hb-common.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_direction_to_string")]
        public partial string DirectionToStringS(DirectionT direction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_from_string")]
        public unsafe partial LanguageImplT* LanguageFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_from_string")]
        public unsafe partial LanguageImplT* LanguageFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_from_string")]
        public unsafe partial LanguageImplT* LanguageFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_to_string")]
        public unsafe partial byte* LanguageToString([Flow(Silk.NET.Core.Native.FlowDirection.In)] LanguageImplT* language);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 1 in hb-common.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_language_to_string")]
        public unsafe partial string LanguageToStringS([Flow(Silk.NET.Core.Native.FlowDirection.In)] LanguageImplT* language);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_get_default")]
        public unsafe partial LanguageImplT* LanguageGetDefault();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_language_matches")]
        public unsafe partial int LanguageMatches([Flow(Silk.NET.Core.Native.FlowDirection.In)] LanguageImplT* language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LanguageImplT* specific);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 346, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_from_iso15924_tag")]
        public partial ScriptT ScriptFromIso15924Tag(uint tag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_from_string")]
        public unsafe partial ScriptT ScriptFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_from_string")]
        public partial ScriptT ScriptFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_from_string")]
        public partial ScriptT ScriptFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_to_iso15924_tag")]
        public partial uint ScriptToIso15924Tag(ScriptT script);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_script_get_horizontal_direction")]
        public partial DirectionT ScriptGetHorizontalDirection(ScriptT script);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public unsafe partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, FeatureT* feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public unsafe partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, ref FeatureT feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public unsafe partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len, FeatureT* feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len, ref FeatureT feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public unsafe partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, FeatureT* feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_from_string")]
        public partial int FeatureFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, ref FeatureT feature);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public unsafe partial void FeatureToString(FeatureT* feature, byte* buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public unsafe partial void FeatureToString(FeatureT* feature, ref byte buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public unsafe partial void FeatureToString(FeatureT* feature, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public unsafe partial void FeatureToString(ref FeatureT feature, byte* buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public partial void FeatureToString(ref FeatureT feature, ref byte buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_feature_to_string")]
        public partial void FeatureToString(ref FeatureT feature, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public unsafe partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, VariationT* variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public unsafe partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, ref VariationT variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public unsafe partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len, VariationT* variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len, ref VariationT variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public unsafe partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, VariationT* variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_from_string")]
        public partial int VariationFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, ref VariationT variation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public unsafe partial void VariationToString(VariationT* variation, byte* buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public unsafe partial void VariationToString(VariationT* variation, ref byte buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public unsafe partial void VariationToString(VariationT* variation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public unsafe partial void VariationToString(ref VariationT variation, byte* buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public partial void VariationToString(ref VariationT variation, ref byte buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_variation_to_string")]
        public partial void VariationToString(ref VariationT variation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 481, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_color_get_alpha")]
        public partial byte ColorGetAlpha(uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_color_get_red")]
        public partial byte ColorGetRed(uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 489, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_color_get_green")]
        public partial byte ColorGetGreen(uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 493, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_color_get_blue")]
        public partial byte ColorGetBlue(uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 524, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_malloc")]
        public unsafe partial void* Malloc(nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 526, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_calloc")]
        public unsafe partial void* Calloc(nuint nmemb, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_realloc")]
        public unsafe partial void* Realloc(void* ptr, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_realloc")]
        public unsafe partial void* Realloc<T0>(ref T0 ptr, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_free")]
        public unsafe partial void Free(void* ptr);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 1 in hb-common.h")]
        [NativeApi(EntryPoint = "hb_free")]
        public partial void Free<T0>(ref T0 ptr) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create")]
        public unsafe partial BlobT* BlobCreate<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_or_fail")]
        public unsafe partial BlobT* BlobCreateOrFail<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 101, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file")]
        public unsafe partial BlobT* BlobCreateFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 101, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file")]
        public unsafe partial BlobT* BlobCreateFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 101, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file")]
        public unsafe partial BlobT* BlobCreateFromFile([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file_or_fail")]
        public unsafe partial BlobT* BlobCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file_or_fail")]
        public unsafe partial BlobT* BlobCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_from_file_or_fail")]
        public unsafe partial BlobT* BlobCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 113, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_create_sub_blob")]
        public unsafe partial BlobT* BlobCreateSubBlob(BlobT* parent, uint offset, uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_copy_writable_or_fail")]
        public unsafe partial BlobT* BlobCopyWritableOrFail(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 121, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_empty")]
        public unsafe partial BlobT* BlobGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 124, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_reference")]
        public unsafe partial BlobT* BlobReference(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_destroy")]
        public unsafe partial void BlobDestroy(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_set_user_data")]
        public unsafe partial int BlobSetUserData(BlobT* blob, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_set_user_data")]
        public unsafe partial int BlobSetUserData<T0>(BlobT* blob, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_set_user_data")]
        public unsafe partial int BlobSetUserData(BlobT* blob, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_set_user_data")]
        public unsafe partial int BlobSetUserData<T0>(BlobT* blob, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_user_data")]
        public unsafe partial void* BlobGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlobT* blob, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_user_data")]
        public unsafe partial void* BlobGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlobT* blob, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_make_immutable")]
        public unsafe partial void BlobMakeImmutable(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_is_immutable")]
        public unsafe partial int BlobIsImmutable(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_length")]
        public unsafe partial uint BlobGetLength(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_data")]
        public unsafe partial byte* BlobGetData(BlobT* blob, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 1 in hb-blob.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_blob_get_data")]
        public unsafe partial string BlobGetDataS(BlobT* blob, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_data")]
        public unsafe partial byte* BlobGetData(BlobT* blob, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 1 in hb-blob.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_blob_get_data")]
        public unsafe partial string BlobGetDataS(BlobT* blob, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_data_writable")]
        public unsafe partial byte* BlobGetDataWritable(BlobT* blob, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-blob.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_blob_get_data_writable")]
        public unsafe partial string BlobGetDataWritableS(BlobT* blob, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-blob.h")]
        [NativeApi(EntryPoint = "hb_blob_get_data_writable")]
        public unsafe partial byte* BlobGetDataWritable(BlobT* blob, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-blob.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_blob_get_data_writable")]
        public unsafe partial string BlobGetDataWritableS(BlobT* blob, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 296, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_get_default")]
        public unsafe partial UnicodeFuncsT* UnicodeFuncsGetDefault();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_create")]
        public unsafe partial UnicodeFuncsT* UnicodeFuncsCreate(UnicodeFuncsT* parent);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_get_empty")]
        public unsafe partial UnicodeFuncsT* UnicodeFuncsGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_reference")]
        public unsafe partial UnicodeFuncsT* UnicodeFuncsReference(UnicodeFuncsT* ufuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 309, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_destroy")]
        public unsafe partial void UnicodeFuncsDestroy(UnicodeFuncsT* ufuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_user_data")]
        public unsafe partial int UnicodeFuncsSetUserData(UnicodeFuncsT* ufuncs, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_user_data")]
        public unsafe partial int UnicodeFuncsSetUserData<T0>(UnicodeFuncsT* ufuncs, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_user_data")]
        public unsafe partial int UnicodeFuncsSetUserData(UnicodeFuncsT* ufuncs, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_user_data")]
        public unsafe partial int UnicodeFuncsSetUserData<T0>(UnicodeFuncsT* ufuncs, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_get_user_data")]
        public unsafe partial void* UnicodeFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeFuncsT* ufuncs, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_get_user_data")]
        public unsafe partial void* UnicodeFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeFuncsT* ufuncs, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_make_immutable")]
        public unsafe partial void UnicodeFuncsMakeImmutable(UnicodeFuncsT* ufuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_is_immutable")]
        public unsafe partial int UnicodeFuncsIsImmutable(UnicodeFuncsT* ufuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_get_parent")]
        public unsafe partial UnicodeFuncsT* UnicodeFuncsGetParent(UnicodeFuncsT* ufuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
        public unsafe partial void UnicodeFuncsSetCombiningClassFunc(UnicodeFuncsT* ufuncs, PfnUnicodeCombiningClassFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_combining_class_func")]
        public unsafe partial void UnicodeFuncsSetCombiningClassFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeCombiningClassFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_general_category_func")]
        public unsafe partial void UnicodeFuncsSetGeneralCategoryFunc(UnicodeFuncsT* ufuncs, PfnUnicodeGeneralCategoryFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_general_category_func")]
        public unsafe partial void UnicodeFuncsSetGeneralCategoryFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeGeneralCategoryFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
        public unsafe partial void UnicodeFuncsSetMirroringFunc(UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_mirroring_func")]
        public unsafe partial void UnicodeFuncsSetMirroringFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_script_func")]
        public unsafe partial void UnicodeFuncsSetScriptFunc(UnicodeFuncsT* ufuncs, PfnUnicodeScriptFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_script_func")]
        public unsafe partial void UnicodeFuncsSetScriptFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeScriptFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_compose_func")]
        public unsafe partial void UnicodeFuncsSetComposeFunc(UnicodeFuncsT* ufuncs, PfnUnicodeComposeFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_compose_func")]
        public unsafe partial void UnicodeFuncsSetComposeFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeComposeFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_decompose_func")]
        public unsafe partial void UnicodeFuncsSetDecomposeFunc(UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_decompose_func")]
        public unsafe partial void UnicodeFuncsSetDecomposeFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 578, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_combining_class")]
        public unsafe partial UnicodeCombiningClassT UnicodeCombiningClass(UnicodeFuncsT* ufuncs, uint unicode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 594, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_general_category")]
        public unsafe partial UnicodeGeneralCategoryT UnicodeGeneralCategory(UnicodeFuncsT* ufuncs, uint unicode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_mirroring")]
        public unsafe partial uint UnicodeMirroring(UnicodeFuncsT* ufuncs, uint unicode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 626, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_script")]
        public unsafe partial ScriptT UnicodeScript(UnicodeFuncsT* ufuncs, uint unicode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 630, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_compose")]
        public unsafe partial int UnicodeCompose(UnicodeFuncsT* ufuncs, uint a, uint b, uint* ab);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 630, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_compose")]
        public unsafe partial int UnicodeCompose(UnicodeFuncsT* ufuncs, uint a, uint b, ref uint ab);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose")]
        public unsafe partial int UnicodeDecompose(UnicodeFuncsT* ufuncs, uint ab, uint* a, uint* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose")]
        public unsafe partial int UnicodeDecompose(UnicodeFuncsT* ufuncs, uint ab, uint* a, ref uint b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose")]
        public unsafe partial int UnicodeDecompose(UnicodeFuncsT* ufuncs, uint ab, ref uint a, uint* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose")]
        public unsafe partial int UnicodeDecompose(UnicodeFuncsT* ufuncs, uint ab, ref uint a, ref uint b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_create")]
        public unsafe partial SetT* SetCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_empty")]
        public unsafe partial SetT* SetGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_reference")]
        public unsafe partial SetT* SetReference(SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_destroy")]
        public unsafe partial void SetDestroy(SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_set_user_data")]
        public unsafe partial int SetSetUserData(SetT* set, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_set_user_data")]
        public unsafe partial int SetSetUserData<T0>(SetT* set, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_set_user_data")]
        public unsafe partial int SetSetUserData(SetT* set, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_set_user_data")]
        public unsafe partial int SetSetUserData<T0>(SetT* set, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_user_data")]
        public unsafe partial void* SetGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_user_data")]
        public unsafe partial void* SetGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_allocation_successful")]
        public unsafe partial int SetAllocationSuccessful([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_copy")]
        public unsafe partial SetT* SetCopy([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_clear")]
        public unsafe partial void SetClear(SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_is_empty")]
        public unsafe partial int SetIsEmpty([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_invert")]
        public unsafe partial void SetInvert(SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 101, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_is_inverted")]
        public unsafe partial int SetIsInverted([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_has")]
        public unsafe partial int SetHas([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_add")]
        public unsafe partial void SetAdd(SetT* set, uint codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 112, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_add_range")]
        public unsafe partial void SetAddRange(SetT* set, uint first, uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_add_sorted_array")]
        public unsafe partial void SetAddSortedArray(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* sorted_codepoints, uint num_codepoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_add_sorted_array")]
        public unsafe partial void SetAddSortedArray(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint sorted_codepoints, uint num_codepoints);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 122, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_del")]
        public unsafe partial void SetDel(SetT* set, uint codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 126, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_del_range")]
        public unsafe partial void SetDelRange(SetT* set, uint first, uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_is_equal")]
        public unsafe partial int SetIsEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 135, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_hash")]
        public unsafe partial uint SetHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_is_subset")]
        public unsafe partial int SetIsSubset([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* larger_set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_set")]
        public unsafe partial void SetSet(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 146, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_union")]
        public unsafe partial void SetUnion(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 150, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_intersect")]
        public unsafe partial void SetIntersect(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_subtract")]
        public unsafe partial void SetSubtract(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 158, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_symmetric_difference")]
        public unsafe partial void SetSymmetricDifference(SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 162, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_population")]
        public unsafe partial uint SetGetPopulation([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 166, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_min")]
        public unsafe partial uint SetGetMin([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 170, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_get_max")]
        public unsafe partial uint SetGetMax([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next")]
        public unsafe partial int SetNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next")]
        public unsafe partial int SetNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous")]
        public unsafe partial int SetPrevious([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous")]
        public unsafe partial int SetPrevious([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint codepoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_range")]
        public unsafe partial int SetNextRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, uint* last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_range")]
        public unsafe partial int SetNextRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, ref uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_range")]
        public unsafe partial int SetNextRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint first, uint* last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_range")]
        public unsafe partial int SetNextRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint first, ref uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous_range")]
        public unsafe partial int SetPreviousRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, uint* last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous_range")]
        public unsafe partial int SetPreviousRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, ref uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous_range")]
        public unsafe partial int SetPreviousRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint first, uint* last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_previous_range")]
        public unsafe partial int SetPreviousRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, ref uint first, ref uint last);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_many")]
        public unsafe partial uint SetNextMany([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint codepoint, uint* @out, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 1 in hb-set.h")]
        [NativeApi(EntryPoint = "hb_set_next_many")]
        public unsafe partial uint SetNextMany([Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint codepoint, ref uint @out, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 59, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_create")]
        public unsafe partial MapT* MapCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 62, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_get_empty")]
        public unsafe partial MapT* MapGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 65, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_reference")]
        public unsafe partial MapT* MapReference(MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_destroy")]
        public unsafe partial void MapDestroy(MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_set_user_data")]
        public unsafe partial int MapSetUserData(MapT* map, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_set_user_data")]
        public unsafe partial int MapSetUserData<T0>(MapT* map, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_set_user_data")]
        public unsafe partial int MapSetUserData(MapT* map, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_set_user_data")]
        public unsafe partial int MapSetUserData<T0>(MapT* map, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_get_user_data")]
        public unsafe partial void* MapGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_get_user_data")]
        public unsafe partial void* MapGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_allocation_successful")]
        public unsafe partial int MapAllocationSuccessful([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_copy")]
        public unsafe partial MapT* MapCopy([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_clear")]
        public unsafe partial void MapClear(MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_is_empty")]
        public unsafe partial int MapIsEmpty([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 96, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_get_population")]
        public unsafe partial uint MapGetPopulation([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_is_equal")]
        public unsafe partial int MapIsEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 103, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_hash")]
        public unsafe partial uint MapHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_set")]
        public unsafe partial void MapSet(MapT* map, uint key, uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_get")]
        public unsafe partial uint MapGet([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 115, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_del")]
        public unsafe partial void MapDel(MapT* map, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 119, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_has")]
        public unsafe partial int MapHas([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, uint key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_update")]
        public unsafe partial void MapUpdate(MapT* map, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, uint* key, uint* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, uint* key, ref uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, ref uint key, uint* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, ref uint key, ref uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, ref int idx, uint* key, uint* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, ref int idx, uint* key, ref uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, ref int idx, ref uint key, uint* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_next")]
        public unsafe partial int MapNext([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, ref int idx, ref uint key, ref uint value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_keys")]
        public unsafe partial void MapKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, SetT* keys);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-map.h")]
        [NativeApi(EntryPoint = "hb_map_values")]
        public unsafe partial void MapValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, SetT* values);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 43, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_count")]
        public unsafe partial uint FaceCount(BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 59, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create")]
        public unsafe partial FaceT* FaceCreate(BlobT* blob, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_or_fail")]
        public unsafe partial FaceT* FaceCreateOrFail(BlobT* blob, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_or_fail_using")]
        public unsafe partial FaceT* FaceCreateOrFailUsing(BlobT* blob, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_or_fail_using")]
        public unsafe partial FaceT* FaceCreateOrFailUsing(BlobT* blob, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_or_fail_using")]
        public unsafe partial FaceT* FaceCreateOrFailUsing(BlobT* blob, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail")]
        public unsafe partial FaceT* FaceCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail")]
        public unsafe partial FaceT* FaceCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail")]
        public unsafe partial FaceT* FaceCreateFromFileOrFail([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_from_file_or_fail_using")]
        public unsafe partial FaceT* FaceCreateFromFileOrFailUsing([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string loader_name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_list_loaders")]
        public unsafe partial byte** FaceListLoaders();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_for_tables")]
        public unsafe partial FaceT* FaceCreateForTables(PfnReferenceTableFuncT reference_table_func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_create_for_tables")]
        public unsafe partial FaceT* FaceCreateForTables<T0>(PfnReferenceTableFuncT reference_table_func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_empty")]
        public unsafe partial FaceT* FaceGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_reference")]
        public unsafe partial FaceT* FaceReference(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_destroy")]
        public unsafe partial void FaceDestroy(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_user_data")]
        public unsafe partial int FaceSetUserData(FaceT* face, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_user_data")]
        public unsafe partial int FaceSetUserData<T0>(FaceT* face, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_user_data")]
        public unsafe partial int FaceSetUserData(FaceT* face, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_user_data")]
        public unsafe partial int FaceSetUserData<T0>(FaceT* face, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_user_data")]
        public unsafe partial void* FaceGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_user_data")]
        public unsafe partial void* FaceGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 131, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_make_immutable")]
        public unsafe partial void FaceMakeImmutable(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 134, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_is_immutable")]
        public unsafe partial int FaceIsImmutable(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_reference_table")]
        public unsafe partial BlobT* FaceReferenceTable([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint tag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_reference_blob")]
        public unsafe partial BlobT* FaceReferenceBlob(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_index")]
        public unsafe partial void FaceSetIndex(FaceT* face, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 149, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_index")]
        public unsafe partial uint FaceGetIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 152, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_upem")]
        public unsafe partial void FaceSetUpem(FaceT* face, uint upem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_upem")]
        public unsafe partial uint FaceGetUpem([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 159, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_glyph_count")]
        public unsafe partial void FaceSetGlyphCount(FaceT* face, uint glyph_count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_glyph_count")]
        public unsafe partial uint FaceGetGlyphCount([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_get_table_tags_func")]
        public unsafe partial void FaceSetGetTableTagsFunc(FaceT* face, PfnGetTableTagsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_set_get_table_tags_func")]
        public unsafe partial void FaceSetGetTableTagsFunc<T0>(FaceT* face, PfnGetTableTagsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_table_tags")]
        public unsafe partial uint FaceGetTableTags([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, uint* table_count, uint* table_tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_table_tags")]
        public unsafe partial uint FaceGetTableTags([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, uint* table_count, ref uint table_tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_table_tags")]
        public unsafe partial uint FaceGetTableTags([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, ref uint table_count, uint* table_tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_get_table_tags")]
        public unsafe partial uint FaceGetTableTags([Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, ref uint table_count, ref uint table_tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_collect_unicodes")]
        public unsafe partial void FaceCollectUnicodes(FaceT* face, SetT* @out);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 209, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_collect_nominal_glyph_mapping")]
        public unsafe partial void FaceCollectNominalGlyphMapping(FaceT* face, MapT* mapping, SetT* unicodes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 214, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_collect_variation_selectors")]
        public unsafe partial void FaceCollectVariationSelectors(FaceT* face, SetT* @out);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_collect_variation_unicodes")]
        public unsafe partial void FaceCollectVariationUnicodes(FaceT* face, uint variation_selector, SetT* @out);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_builder_create")]
        public unsafe partial FaceT* FaceBuilderCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_builder_add_table")]
        public unsafe partial int FaceBuilderAddTable(FaceT* face, uint tag, BlobT* blob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_builder_sort_tables")]
        public unsafe partial void FaceBuilderSortTables(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-face.h")]
        [NativeApi(EntryPoint = "hb_face_builder_sort_tables")]
        public unsafe partial void FaceBuilderSortTables(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint tags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_move_to_func")]
        public unsafe partial void DrawFuncsSetMoveToFunc(DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_move_to_func")]
        public unsafe partial void DrawFuncsSetMoveToFunc<T0>(DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 226, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_line_to_func")]
        public unsafe partial void DrawFuncsSetLineToFunc(DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 226, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_line_to_func")]
        public unsafe partial void DrawFuncsSetLineToFunc<T0>(DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
        public unsafe partial void DrawFuncsSetQuadraticToFunc(DrawFuncsT* dfuncs, PfnDrawQuadraticToFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_quadratic_to_func")]
        public unsafe partial void DrawFuncsSetQuadraticToFunc<T0>(DrawFuncsT* dfuncs, PfnDrawQuadraticToFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
        public unsafe partial void DrawFuncsSetCubicToFunc(DrawFuncsT* dfuncs, PfnDrawCubicToFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_cubic_to_func")]
        public unsafe partial void DrawFuncsSetCubicToFunc<T0>(DrawFuncsT* dfuncs, PfnDrawCubicToFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_close_path_func")]
        public unsafe partial void DrawFuncsSetClosePathFunc(DrawFuncsT* dfuncs, PfnDrawClosePathFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_close_path_func")]
        public unsafe partial void DrawFuncsSetClosePathFunc<T0>(DrawFuncsT* dfuncs, PfnDrawClosePathFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_create")]
        public unsafe partial DrawFuncsT* DrawFuncsCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_get_empty")]
        public unsafe partial DrawFuncsT* DrawFuncsGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_reference")]
        public unsafe partial DrawFuncsT* DrawFuncsReference(DrawFuncsT* dfuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 289, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_destroy")]
        public unsafe partial void DrawFuncsDestroy(DrawFuncsT* dfuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_user_data")]
        public unsafe partial int DrawFuncsSetUserData(DrawFuncsT* dfuncs, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_user_data")]
        public unsafe partial int DrawFuncsSetUserData<T0>(DrawFuncsT* dfuncs, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_user_data")]
        public unsafe partial int DrawFuncsSetUserData(DrawFuncsT* dfuncs, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_set_user_data")]
        public unsafe partial int DrawFuncsSetUserData<T0>(DrawFuncsT* dfuncs, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_get_user_data")]
        public unsafe partial void* DrawFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawFuncsT* dfuncs, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_get_user_data")]
        public unsafe partial void* DrawFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawFuncsT* dfuncs, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_make_immutable")]
        public unsafe partial void DrawFuncsMakeImmutable(DrawFuncsT* dfuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_funcs_is_immutable")]
        public unsafe partial int DrawFuncsIsImmutable(DrawFuncsT* dfuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_move_to")]
        public unsafe partial void DrawMoveTo(DrawFuncsT* dfuncs, void* draw_data, DrawStateT* st, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_move_to")]
        public unsafe partial void DrawMoveTo(DrawFuncsT* dfuncs, void* draw_data, ref DrawStateT st, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_move_to")]
        public unsafe partial void DrawMoveTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, DrawStateT* st, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_move_to")]
        public unsafe partial void DrawMoveTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, ref DrawStateT st, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_line_to")]
        public unsafe partial void DrawLineTo(DrawFuncsT* dfuncs, void* draw_data, DrawStateT* st, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_line_to")]
        public unsafe partial void DrawLineTo(DrawFuncsT* dfuncs, void* draw_data, ref DrawStateT st, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_line_to")]
        public unsafe partial void DrawLineTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, DrawStateT* st, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_line_to")]
        public unsafe partial void DrawLineTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, ref DrawStateT st, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_quadratic_to")]
        public unsafe partial void DrawQuadraticTo(DrawFuncsT* dfuncs, void* draw_data, DrawStateT* st, float control_x, float control_y, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_quadratic_to")]
        public unsafe partial void DrawQuadraticTo(DrawFuncsT* dfuncs, void* draw_data, ref DrawStateT st, float control_x, float control_y, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_quadratic_to")]
        public unsafe partial void DrawQuadraticTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, DrawStateT* st, float control_x, float control_y, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_quadratic_to")]
        public unsafe partial void DrawQuadraticTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, ref DrawStateT st, float control_x, float control_y, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_cubic_to")]
        public unsafe partial void DrawCubicTo(DrawFuncsT* dfuncs, void* draw_data, DrawStateT* st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_cubic_to")]
        public unsafe partial void DrawCubicTo(DrawFuncsT* dfuncs, void* draw_data, ref DrawStateT st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_cubic_to")]
        public unsafe partial void DrawCubicTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, DrawStateT* st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_cubic_to")]
        public unsafe partial void DrawCubicTo<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, ref DrawStateT st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_close_path")]
        public unsafe partial void DrawClosePath(DrawFuncsT* dfuncs, void* draw_data, DrawStateT* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_close_path")]
        public unsafe partial void DrawClosePath(DrawFuncsT* dfuncs, void* draw_data, ref DrawStateT st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_close_path")]
        public unsafe partial void DrawClosePath<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, DrawStateT* st) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        [NativeApi(EntryPoint = "hb_draw_close_path")]
        public unsafe partial void DrawClosePath<T0>(DrawFuncsT* dfuncs, ref T0 draw_data, ref DrawStateT st) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_create")]
        public unsafe partial PaintFuncsT* PaintFuncsCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_get_empty")]
        public unsafe partial PaintFuncsT* PaintFuncsGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_reference")]
        public unsafe partial PaintFuncsT* PaintFuncsReference(PaintFuncsT* funcs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_destroy")]
        public unsafe partial void PaintFuncsDestroy(PaintFuncsT* funcs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_user_data")]
        public unsafe partial int PaintFuncsSetUserData(PaintFuncsT* funcs, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_user_data")]
        public unsafe partial int PaintFuncsSetUserData<T0>(PaintFuncsT* funcs, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_user_data")]
        public unsafe partial int PaintFuncsSetUserData(PaintFuncsT* funcs, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_user_data")]
        public unsafe partial int PaintFuncsSetUserData<T0>(PaintFuncsT* funcs, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_get_user_data")]
        public unsafe partial void* PaintFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] PaintFuncsT* funcs, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_get_user_data")]
        public unsafe partial void* PaintFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] PaintFuncsT* funcs, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_make_immutable")]
        public unsafe partial void PaintFuncsMakeImmutable(PaintFuncsT* funcs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_is_immutable")]
        public unsafe partial int PaintFuncsIsImmutable(PaintFuncsT* funcs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ColorLineT* color_line, uint start, uint* count, ColorStopT* color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ColorLineT* color_line, uint start, uint* count, ref ColorStopT color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ColorLineT* color_line, uint start, ref uint count, ColorStopT* color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ColorLineT* color_line, uint start, ref uint count, ref ColorStopT color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ref ColorLineT color_line, uint start, uint* count, ColorStopT* color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ref ColorLineT color_line, uint start, uint* count, ref ColorStopT color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public unsafe partial uint ColorLineGetColorStops(ref ColorLineT color_line, uint start, ref uint count, ColorStopT* color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_color_stops")]
        public partial uint ColorLineGetColorStops(ref ColorLineT color_line, uint start, ref uint count, ref ColorStopT color_stops);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_extend")]
        public unsafe partial PaintExtendT ColorLineGetExtend(ColorLineT* color_line);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_color_line_get_extend")]
        public partial PaintExtendT ColorLineGetExtend(ref ColorLineT color_line);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 726, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_transform_func")]
        public unsafe partial void PaintFuncsSetPushTransformFunc(PaintFuncsT* funcs, PfnPaintPushTransformFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 726, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_transform_func")]
        public unsafe partial void PaintFuncsSetPushTransformFunc<T0>(PaintFuncsT* funcs, PfnPaintPushTransformFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
        public unsafe partial void PaintFuncsSetPopTransformFunc(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_transform_func")]
        public unsafe partial void PaintFuncsSetPopTransformFunc<T0>(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 760, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
        public unsafe partial void PaintFuncsSetColorGlyphFunc(PaintFuncsT* funcs, PfnPaintColorGlyphFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 760, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_color_glyph_func")]
        public unsafe partial void PaintFuncsSetColorGlyphFunc<T0>(PaintFuncsT* funcs, PfnPaintColorGlyphFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
        public unsafe partial void PaintFuncsSetPushClipGlyphFunc(PaintFuncsT* funcs, PfnPaintPushClipGlyphFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_clip_glyph_func")]
        public unsafe partial void PaintFuncsSetPushClipGlyphFunc<T0>(PaintFuncsT* funcs, PfnPaintPushClipGlyphFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
        public unsafe partial void PaintFuncsSetPushClipRectangleFunc(PaintFuncsT* funcs, PfnPaintPushClipRectangleFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_clip_rectangle_func")]
        public unsafe partial void PaintFuncsSetPushClipRectangleFunc<T0>(PaintFuncsT* funcs, PfnPaintPushClipRectangleFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
        public unsafe partial void PaintFuncsSetPopClipFunc(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_clip_func")]
        public unsafe partial void PaintFuncsSetPopClipFunc<T0>(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_color_func")]
        public unsafe partial void PaintFuncsSetColorFunc(PaintFuncsT* funcs, PfnPaintColorFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_color_func")]
        public unsafe partial void PaintFuncsSetColorFunc<T0>(PaintFuncsT* funcs, PfnPaintColorFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_image_func")]
        public unsafe partial void PaintFuncsSetImageFunc(PaintFuncsT* funcs, PfnPaintImageFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_image_func")]
        public unsafe partial void PaintFuncsSetImageFunc<T0>(PaintFuncsT* funcs, PfnPaintImageFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
        public unsafe partial void PaintFuncsSetLinearGradientFunc(PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_linear_gradient_func")]
        public unsafe partial void PaintFuncsSetLinearGradientFunc<T0>(PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
        public unsafe partial void PaintFuncsSetRadialGradientFunc(PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_radial_gradient_func")]
        public unsafe partial void PaintFuncsSetRadialGradientFunc<T0>(PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
        public unsafe partial void PaintFuncsSetSweepGradientFunc(PaintFuncsT* funcs, PfnPaintSweepGradientFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_sweep_gradient_func")]
        public unsafe partial void PaintFuncsSetSweepGradientFunc<T0>(PaintFuncsT* funcs, PfnPaintSweepGradientFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_group_func")]
        public unsafe partial void PaintFuncsSetPushGroupFunc(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_push_group_func")]
        public unsafe partial void PaintFuncsSetPushGroupFunc<T0>(PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_group_func")]
        public unsafe partial void PaintFuncsSetPopGroupFunc(PaintFuncsT* funcs, PfnPaintPopGroupFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_pop_group_func")]
        public unsafe partial void PaintFuncsSetPopGroupFunc<T0>(PaintFuncsT* funcs, PfnPaintPopGroupFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
        public unsafe partial void PaintFuncsSetCustomPaletteColorFunc(PaintFuncsT* funcs, PfnPaintCustomPaletteColorFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_funcs_set_custom_palette_color_func")]
        public unsafe partial void PaintFuncsSetCustomPaletteColorFunc<T0>(PaintFuncsT* funcs, PfnPaintCustomPaletteColorFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_transform")]
        public unsafe partial void PaintPushTransform(PaintFuncsT* funcs, void* paint_data, float xx, float yx, float xy, float yy, float dx, float dy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_transform")]
        public unsafe partial void PaintPushTransform<T0>(PaintFuncsT* funcs, ref T0 paint_data, float xx, float yx, float xy, float yy, float dx, float dy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_font_transform")]
        public unsafe partial void PaintPushFontTransform(PaintFuncsT* funcs, void* paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_font_transform")]
        public unsafe partial void PaintPushFontTransform<T0>(PaintFuncsT* funcs, ref T0 paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_inverse_font_transform")]
        public unsafe partial void PaintPushInverseFontTransform(PaintFuncsT* funcs, void* paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_inverse_font_transform")]
        public unsafe partial void PaintPushInverseFontTransform<T0>(PaintFuncsT* funcs, ref T0 paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 970, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_transform")]
        public unsafe partial void PaintPopTransform(PaintFuncsT* funcs, void* paint_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 970, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_transform")]
        public unsafe partial void PaintPopTransform<T0>(PaintFuncsT* funcs, ref T0 paint_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_color_glyph")]
        public unsafe partial int PaintColorGlyph(PaintFuncsT* funcs, void* paint_data, uint glyph, FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_color_glyph")]
        public unsafe partial int PaintColorGlyph<T0>(PaintFuncsT* funcs, ref T0 paint_data, uint glyph, FontT* font) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_clip_glyph")]
        public unsafe partial void PaintPushClipGlyph(PaintFuncsT* funcs, void* paint_data, uint glyph, FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_clip_glyph")]
        public unsafe partial void PaintPushClipGlyph<T0>(PaintFuncsT* funcs, ref T0 paint_data, uint glyph, FontT* font) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 983, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_clip_rectangle")]
        public unsafe partial void PaintPushClipRectangle(PaintFuncsT* funcs, void* paint_data, float xmin, float ymin, float xmax, float ymax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 983, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_clip_rectangle")]
        public unsafe partial void PaintPushClipRectangle<T0>(PaintFuncsT* funcs, ref T0 paint_data, float xmin, float ymin, float xmax, float ymax) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_clip")]
        public unsafe partial void PaintPopClip(PaintFuncsT* funcs, void* paint_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_clip")]
        public unsafe partial void PaintPopClip<T0>(PaintFuncsT* funcs, ref T0 paint_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_color")]
        public unsafe partial void PaintColor(PaintFuncsT* funcs, void* paint_data, int is_foreground, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_color")]
        public unsafe partial void PaintColor<T0>(PaintFuncsT* funcs, ref T0 paint_data, int is_foreground, uint color) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_image")]
        public unsafe partial void PaintImage(PaintFuncsT* funcs, void* paint_data, BlobT* image, uint width, uint height, uint format, float slant, GlyphExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_image")]
        public unsafe partial void PaintImage(PaintFuncsT* funcs, void* paint_data, BlobT* image, uint width, uint height, uint format, float slant, ref GlyphExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_image")]
        public unsafe partial void PaintImage<T0>(PaintFuncsT* funcs, ref T0 paint_data, BlobT* image, uint width, uint height, uint format, float slant, GlyphExtentsT* extents) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_image")]
        public unsafe partial void PaintImage<T0>(PaintFuncsT* funcs, ref T0 paint_data, BlobT* image, uint width, uint height, uint format, float slant, ref GlyphExtentsT extents) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_linear_gradient")]
        public unsafe partial void PaintLinearGradient(PaintFuncsT* funcs, void* paint_data, ColorLineT* color_line, float x0, float y0, float x1, float y1, float x2, float y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_linear_gradient")]
        public unsafe partial void PaintLinearGradient(PaintFuncsT* funcs, void* paint_data, ref ColorLineT color_line, float x0, float y0, float x1, float y1, float x2, float y2);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_linear_gradient")]
        public unsafe partial void PaintLinearGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ColorLineT* color_line, float x0, float y0, float x1, float y1, float x2, float y2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_linear_gradient")]
        public unsafe partial void PaintLinearGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ref ColorLineT color_line, float x0, float y0, float x1, float y1, float x2, float y2) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_radial_gradient")]
        public unsafe partial void PaintRadialGradient(PaintFuncsT* funcs, void* paint_data, ColorLineT* color_line, float x0, float y0, float r0, float x1, float y1, float r1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_radial_gradient")]
        public unsafe partial void PaintRadialGradient(PaintFuncsT* funcs, void* paint_data, ref ColorLineT color_line, float x0, float y0, float r0, float x1, float y1, float r1);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_radial_gradient")]
        public unsafe partial void PaintRadialGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ColorLineT* color_line, float x0, float y0, float r0, float x1, float y1, float r1) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_radial_gradient")]
        public unsafe partial void PaintRadialGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ref ColorLineT color_line, float x0, float y0, float r0, float x1, float y1, float r1) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_sweep_gradient")]
        public unsafe partial void PaintSweepGradient(PaintFuncsT* funcs, void* paint_data, ColorLineT* color_line, float x0, float y0, float start_angle, float end_angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_sweep_gradient")]
        public unsafe partial void PaintSweepGradient(PaintFuncsT* funcs, void* paint_data, ref ColorLineT color_line, float x0, float y0, float start_angle, float end_angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_sweep_gradient")]
        public unsafe partial void PaintSweepGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ColorLineT* color_line, float x0, float y0, float start_angle, float end_angle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_sweep_gradient")]
        public unsafe partial void PaintSweepGradient<T0>(PaintFuncsT* funcs, ref T0 paint_data, ref ColorLineT color_line, float x0, float y0, float start_angle, float end_angle) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1026, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_group")]
        public unsafe partial void PaintPushGroup(PaintFuncsT* funcs, void* paint_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1026, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_push_group")]
        public unsafe partial void PaintPushGroup<T0>(PaintFuncsT* funcs, ref T0 paint_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1029, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_group")]
        public unsafe partial void PaintPopGroup(PaintFuncsT* funcs, void* paint_data, PaintCompositeModeT mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1029, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_pop_group")]
        public unsafe partial void PaintPopGroup<T0>(PaintFuncsT* funcs, ref T0 paint_data, PaintCompositeModeT mode) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_custom_palette_color")]
        public unsafe partial int PaintCustomPaletteColor(PaintFuncsT* funcs, void* paint_data, uint color_index, uint* color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_custom_palette_color")]
        public unsafe partial int PaintCustomPaletteColor(PaintFuncsT* funcs, void* paint_data, uint color_index, ref uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_custom_palette_color")]
        public unsafe partial int PaintCustomPaletteColor<T0>(PaintFuncsT* funcs, ref T0 paint_data, uint color_index, uint* color) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        [NativeApi(EntryPoint = "hb_paint_custom_palette_color")]
        public unsafe partial int PaintCustomPaletteColor<T0>(PaintFuncsT* funcs, ref T0 paint_data, uint color_index, ref uint color) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_create")]
        public unsafe partial FontFuncsT* FontFuncsCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 64, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_get_empty")]
        public unsafe partial FontFuncsT* FontFuncsGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_reference")]
        public unsafe partial FontFuncsT* FontFuncsReference(FontFuncsT* ffuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_destroy")]
        public unsafe partial void FontFuncsDestroy(FontFuncsT* ffuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_user_data")]
        public unsafe partial int FontFuncsSetUserData(FontFuncsT* ffuncs, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_user_data")]
        public unsafe partial int FontFuncsSetUserData<T0>(FontFuncsT* ffuncs, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_user_data")]
        public unsafe partial int FontFuncsSetUserData(FontFuncsT* ffuncs, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_user_data")]
        public unsafe partial int FontFuncsSetUserData<T0>(FontFuncsT* ffuncs, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_get_user_data")]
        public unsafe partial void* FontFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontFuncsT* ffuncs, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_get_user_data")]
        public unsafe partial void* FontFuncsGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontFuncsT* ffuncs, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_make_immutable")]
        public unsafe partial void FontFuncsMakeImmutable(FontFuncsT* ffuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_is_immutable")]
        public unsafe partial int FontFuncsIsImmutable(FontFuncsT* ffuncs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 605, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
        public unsafe partial void FontFuncsSetFontHExtentsFunc(FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 605, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_font_h_extents_func")]
        public unsafe partial void FontFuncsSetFontHExtentsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 621, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
        public unsafe partial void FontFuncsSetFontVExtentsFunc(FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 621, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_font_v_extents_func")]
        public unsafe partial void FontFuncsSetFontVExtentsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 637, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
        public unsafe partial void FontFuncsSetNominalGlyphFunc(FontFuncsT* ffuncs, PfnFontGetNominalGlyphFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 637, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_nominal_glyph_func")]
        public unsafe partial void FontFuncsSetNominalGlyphFunc<T0>(FontFuncsT* ffuncs, PfnFontGetNominalGlyphFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 653, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
        public unsafe partial void FontFuncsSetNominalGlyphsFunc(FontFuncsT* ffuncs, PfnFontGetNominalGlyphsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 653, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_nominal_glyphs_func")]
        public unsafe partial void FontFuncsSetNominalGlyphsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetNominalGlyphsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
        public unsafe partial void FontFuncsSetVariationGlyphFunc(FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_variation_glyph_func")]
        public unsafe partial void FontFuncsSetVariationGlyphFunc<T0>(FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
        public unsafe partial void FontFuncsSetGlyphHAdvanceFunc(FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_advance_func")]
        public unsafe partial void FontFuncsSetGlyphHAdvanceFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 701, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
        public unsafe partial void FontFuncsSetGlyphVAdvanceFunc(FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 701, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_advance_func")]
        public unsafe partial void FontFuncsSetGlyphVAdvanceFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
        public unsafe partial void FontFuncsSetGlyphHAdvancesFunc(FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_advances_func")]
        public unsafe partial void FontFuncsSetGlyphHAdvancesFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 733, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
        public unsafe partial void FontFuncsSetGlyphVAdvancesFunc(FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 733, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_advances_func")]
        public unsafe partial void FontFuncsSetGlyphVAdvancesFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
        public unsafe partial void FontFuncsSetGlyphHOriginFunc(FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_origin_func")]
        public unsafe partial void FontFuncsSetGlyphHOriginFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 765, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
        public unsafe partial void FontFuncsSetGlyphVOriginFunc(FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 765, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_origin_func")]
        public unsafe partial void FontFuncsSetGlyphVOriginFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
        public unsafe partial void FontFuncsSetGlyphHOriginsFunc(FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_origins_func")]
        public unsafe partial void FontFuncsSetGlyphHOriginsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 797, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
        public unsafe partial void FontFuncsSetGlyphVOriginsFunc(FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 797, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_origins_func")]
        public unsafe partial void FontFuncsSetGlyphVOriginsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 813, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
        public unsafe partial void FontFuncsSetGlyphHKerningFunc(FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 813, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_h_kerning_func")]
        public unsafe partial void FontFuncsSetGlyphHKerningFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
        public unsafe partial void FontFuncsSetGlyphExtentsFunc(FontFuncsT* ffuncs, PfnFontGetGlyphExtentsFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_extents_func")]
        public unsafe partial void FontFuncsSetGlyphExtentsFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphExtentsFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
        public unsafe partial void FontFuncsSetGlyphContourPointFunc(FontFuncsT* ffuncs, PfnFontGetGlyphContourPointFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_contour_point_func")]
        public unsafe partial void FontFuncsSetGlyphContourPointFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphContourPointFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 861, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_name_func")]
        public unsafe partial void FontFuncsSetGlyphNameFunc(FontFuncsT* ffuncs, PfnFontGetGlyphNameFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 861, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_name_func")]
        public unsafe partial void FontFuncsSetGlyphNameFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphNameFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
        public unsafe partial void FontFuncsSetGlyphFromNameFunc(FontFuncsT* ffuncs, PfnFontGetGlyphFromNameFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_from_name_func")]
        public unsafe partial void FontFuncsSetGlyphFromNameFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphFromNameFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
        public unsafe partial void FontFuncsSetDrawGlyphOrFailFunc(FontFuncsT* ffuncs, PfnFontDrawGlyphOrFailFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_draw_glyph_or_fail_func")]
        public unsafe partial void FontFuncsSetDrawGlyphOrFailFunc<T0>(FontFuncsT* ffuncs, PfnFontDrawGlyphOrFailFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
        public unsafe partial void FontFuncsSetPaintGlyphOrFailFunc(FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_paint_glyph_or_fail_func")]
        public unsafe partial void FontFuncsSetPaintGlyphOrFailFunc<T0>(FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_h_extents")]
        public unsafe partial int FontGetHExtents(FontT* font, FontExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_h_extents")]
        public unsafe partial int FontGetHExtents(FontT* font, ref FontExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_v_extents")]
        public unsafe partial int FontGetVExtents(FontT* font, FontExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_v_extents")]
        public unsafe partial int FontGetVExtents(FontT* font, ref FontExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyph")]
        public unsafe partial int FontGetNominalGlyph(FontT* font, uint unicode, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyph")]
        public unsafe partial int FontGetNominalGlyph(FontT* font, uint unicode, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_variation_glyph")]
        public unsafe partial int FontGetVariationGlyph(FontT* font, uint unicode, uint variation_selector, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_variation_glyph")]
        public unsafe partial int FontGetVariationGlyph(FontT* font, uint unicode, uint variation_selector, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyphs")]
        public unsafe partial uint FontGetNominalGlyphs(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_unicode, uint unicode_stride, uint* first_glyph, uint glyph_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyphs")]
        public unsafe partial uint FontGetNominalGlyphs(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_unicode, uint unicode_stride, ref uint first_glyph, uint glyph_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyphs")]
        public unsafe partial uint FontGetNominalGlyphs(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_unicode, uint unicode_stride, uint* first_glyph, uint glyph_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_nominal_glyphs")]
        public unsafe partial uint FontGetNominalGlyphs(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_unicode, uint unicode_stride, ref uint first_glyph, uint glyph_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_advance")]
        public unsafe partial int FontGetGlyphHAdvance(FontT* font, uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 943, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_advance")]
        public unsafe partial int FontGetGlyphVAdvance(FontT* font, uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_advances")]
        public unsafe partial void FontGetGlyphHAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_advances")]
        public unsafe partial void FontGetGlyphHAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_advances")]
        public unsafe partial void FontGetGlyphHAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_advances")]
        public unsafe partial void FontGetGlyphHAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_advances")]
        public unsafe partial void FontGetGlyphVAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_advances")]
        public unsafe partial void FontGetGlyphVAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_advances")]
        public unsafe partial void FontGetGlyphVAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_advances")]
        public unsafe partial void FontGetGlyphVAdvances(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origin")]
        public unsafe partial int FontGetGlyphHOrigin(FontT* font, uint glyph, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origin")]
        public unsafe partial int FontGetGlyphHOrigin(FontT* font, uint glyph, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origin")]
        public unsafe partial int FontGetGlyphHOrigin(FontT* font, uint glyph, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origin")]
        public unsafe partial int FontGetGlyphHOrigin(FontT* font, uint glyph, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origin")]
        public unsafe partial int FontGetGlyphVOrigin(FontT* font, uint glyph, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origin")]
        public unsafe partial int FontGetGlyphVOrigin(FontT* font, uint glyph, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origin")]
        public unsafe partial int FontGetGlyphVOrigin(FontT* font, uint glyph, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origin")]
        public unsafe partial int FontGetGlyphVOrigin(FontT* font, uint glyph, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_origins")]
        public unsafe partial int FontGetGlyphHOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_x, uint x_stride, int* first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_origins")]
        public unsafe partial int FontGetGlyphVOrigins(FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_x, uint x_stride, ref int first_y, uint y_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_h_kerning")]
        public unsafe partial int FontGetGlyphHKerning(FontT* font, uint left_glyph, uint right_glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_extents")]
        public unsafe partial int FontGetGlyphExtents(FontT* font, uint glyph, GlyphExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_extents")]
        public unsafe partial int FontGetGlyphExtents(FontT* font, uint glyph, ref GlyphExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point")]
        public unsafe partial int FontGetGlyphContourPoint(FontT* font, uint glyph, uint point_index, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point")]
        public unsafe partial int FontGetGlyphContourPoint(FontT* font, uint glyph, uint point_index, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point")]
        public unsafe partial int FontGetGlyphContourPoint(FontT* font, uint glyph, uint point_index, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point")]
        public unsafe partial int FontGetGlyphContourPoint(FontT* font, uint glyph, uint point_index, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_name")]
        public unsafe partial int FontGetGlyphName(FontT* font, uint glyph, byte* name, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_name")]
        public unsafe partial int FontGetGlyphName(FontT* font, uint glyph, ref byte name, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_name")]
        public unsafe partial int FontGetGlyphName(FontT* font, uint glyph, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_from_name")]
        public unsafe partial int FontGetGlyphFromName(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_draw_glyph_or_fail")]
        public unsafe partial int FontDrawGlyphOrFail(FontT* font, uint glyph, DrawFuncsT* dfuncs, void* draw_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_draw_glyph_or_fail")]
        public unsafe partial int FontDrawGlyphOrFail<T0>(FontT* font, uint glyph, DrawFuncsT* dfuncs, ref T0 draw_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1019, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_paint_glyph_or_fail")]
        public unsafe partial int FontPaintGlyphOrFail(FontT* font, uint glyph, PaintFuncsT* pfuncs, void* paint_data, uint palette_index, uint foreground);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1019, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_paint_glyph_or_fail")]
        public unsafe partial int FontPaintGlyphOrFail<T0>(FontT* font, uint glyph, PaintFuncsT* pfuncs, ref T0 paint_data, uint palette_index, uint foreground) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1030, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph")]
        public unsafe partial int FontGetGlyph(FontT* font, uint unicode, uint variation_selector, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1030, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph")]
        public unsafe partial int FontGetGlyph(FontT* font, uint unicode, uint variation_selector, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_extents_for_direction")]
        public unsafe partial void FontGetExtentsForDirection(FontT* font, DirectionT direction, FontExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_extents_for_direction")]
        public unsafe partial void FontGetExtentsForDirection(FontT* font, DirectionT direction, ref FontExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        public unsafe partial void FontGetGlyphAdvanceForDirection(FontT* font, uint glyph, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        public unsafe partial void FontGetGlyphAdvanceForDirection(FontT* font, uint glyph, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        public unsafe partial void FontGetGlyphAdvanceForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advance_for_direction")]
        public unsafe partial void FontGetGlyphAdvanceForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        public unsafe partial void FontGetGlyphAdvancesForDirection(FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        public unsafe partial void FontGetGlyphAdvancesForDirection(FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        public unsafe partial void FontGetGlyphAdvancesForDirection(FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, int* first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_advances_for_direction")]
        public unsafe partial void FontGetGlyphAdvancesForDirection(FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint first_glyph, uint glyph_stride, ref int first_advance, uint advance_stride);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        public unsafe partial void FontGetGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        public unsafe partial void FontGetGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        public unsafe partial void FontGetGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_origin_for_direction")]
        public unsafe partial void FontGetGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        public unsafe partial void FontAddGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        public unsafe partial void FontAddGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        public unsafe partial void FontAddGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_add_glyph_origin_for_direction")]
        public unsafe partial void FontAddGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        public unsafe partial void FontSubtractGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        public unsafe partial void FontSubtractGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        public unsafe partial void FontSubtractGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_subtract_glyph_origin_for_direction")]
        public unsafe partial void FontSubtractGlyphOriginForDirection(FontT* font, uint glyph, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        public unsafe partial void FontGetGlyphKerningForDirection(FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        public unsafe partial void FontGetGlyphKerningForDirection(FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        public unsafe partial void FontGetGlyphKerningForDirection(FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_kerning_for_direction")]
        public unsafe partial void FontGetGlyphKerningForDirection(FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1074, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_extents_for_origin")]
        public unsafe partial int FontGetGlyphExtentsForOrigin(FontT* font, uint glyph, DirectionT direction, GlyphExtentsT* extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1074, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_extents_for_origin")]
        public unsafe partial int FontGetGlyphExtentsForOrigin(FontT* font, uint glyph, DirectionT direction, ref GlyphExtentsT extents);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        public unsafe partial int FontGetGlyphContourPointForOrigin(FontT* font, uint glyph, uint point_index, DirectionT direction, int* x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        public unsafe partial int FontGetGlyphContourPointForOrigin(FontT* font, uint glyph, uint point_index, DirectionT direction, int* x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        public unsafe partial int FontGetGlyphContourPointForOrigin(FontT* font, uint glyph, uint point_index, DirectionT direction, ref int x, int* y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_contour_point_for_origin")]
        public unsafe partial int FontGetGlyphContourPointForOrigin(FontT* font, uint glyph, uint point_index, DirectionT direction, ref int x, ref int y);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_to_string")]
        public unsafe partial void FontGlyphToString(FontT* font, uint glyph, byte* s, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_to_string")]
        public unsafe partial void FontGlyphToString(FontT* font, uint glyph, ref byte s, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_to_string")]
        public unsafe partial void FontGlyphToString(FontT* font, uint glyph, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte s, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte s, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s, int len, uint* glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_glyph_from_string")]
        public unsafe partial int FontGlyphFromString(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s, int len, ref uint glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1098, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_draw_glyph")]
        public unsafe partial void FontDrawGlyph(FontT* font, uint glyph, DrawFuncsT* dfuncs, void* draw_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1098, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_draw_glyph")]
        public unsafe partial void FontDrawGlyph<T0>(FontT* font, uint glyph, DrawFuncsT* dfuncs, ref T0 draw_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_paint_glyph")]
        public unsafe partial void FontPaintGlyph(FontT* font, uint glyph, PaintFuncsT* pfuncs, void* paint_data, uint palette_index, uint foreground);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_paint_glyph")]
        public unsafe partial void FontPaintGlyph<T0>(FontT* font, uint glyph, PaintFuncsT* pfuncs, ref T0 paint_data, uint palette_index, uint foreground) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1117, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_create")]
        public unsafe partial FontT* FontCreate(FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1120, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_create_sub_font")]
        public unsafe partial FontT* FontCreateSubFont(FontT* parent);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_empty")]
        public unsafe partial FontT* FontGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1126, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_reference")]
        public unsafe partial FontT* FontReference(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1129, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_destroy")]
        public unsafe partial void FontDestroy(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_user_data")]
        public unsafe partial int FontSetUserData(FontT* font, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_user_data")]
        public unsafe partial int FontSetUserData<T0>(FontT* font, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_user_data")]
        public unsafe partial int FontSetUserData(FontT* font, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_user_data")]
        public unsafe partial int FontSetUserData<T0>(FontT* font, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_user_data")]
        public unsafe partial void* FontGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_user_data")]
        public unsafe partial void* FontGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1144, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_make_immutable")]
        public unsafe partial void FontMakeImmutable(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1147, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_is_immutable")]
        public unsafe partial int FontIsImmutable(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1150, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_serial")]
        public unsafe partial uint FontGetSerial(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1153, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_changed")]
        public unsafe partial void FontChanged(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1156, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_parent")]
        public unsafe partial void FontSetParent(FontT* font, FontT* parent);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1160, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_parent")]
        public unsafe partial FontT* FontGetParent(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1163, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_face")]
        public unsafe partial void FontSetFace(FontT* font, FaceT* face);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1167, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_face")]
        public unsafe partial FaceT* FontGetFace(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs")]
        public unsafe partial void FontSetFuncs(FontT* font, FontFuncsT* klass, void* font_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs")]
        public unsafe partial void FontSetFuncs<T0>(FontT* font, FontFuncsT* klass, ref T0 font_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs_data")]
        public unsafe partial void FontSetFuncsData(FontT* font, void* font_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs_data")]
        public unsafe partial void FontSetFuncsData<T0>(FontT* font, ref T0 font_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1183, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs_using")]
        public unsafe partial int FontSetFuncsUsing(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1183, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs_using")]
        public unsafe partial int FontSetFuncsUsing(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1183, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_funcs_using")]
        public unsafe partial int FontSetFuncsUsing(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1187, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_list_funcs")]
        public unsafe partial byte** FontListFuncs();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1190, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_scale")]
        public unsafe partial void FontSetScale(FontT* font, int x_scale, int y_scale);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_scale")]
        public unsafe partial void FontGetScale(FontT* font, int* x_scale, int* y_scale);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_scale")]
        public unsafe partial void FontGetScale(FontT* font, int* x_scale, ref int y_scale);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_scale")]
        public unsafe partial void FontGetScale(FontT* font, ref int x_scale, int* y_scale);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_scale")]
        public unsafe partial void FontGetScale(FontT* font, ref int x_scale, ref int y_scale);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1203, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_ppem")]
        public unsafe partial void FontSetPpem(FontT* font, uint x_ppem, uint y_ppem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_ppem")]
        public unsafe partial void FontGetPpem(FontT* font, uint* x_ppem, uint* y_ppem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_ppem")]
        public unsafe partial void FontGetPpem(FontT* font, uint* x_ppem, ref uint y_ppem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_ppem")]
        public unsafe partial void FontGetPpem(FontT* font, ref uint x_ppem, uint* y_ppem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_ppem")]
        public unsafe partial void FontGetPpem(FontT* font, ref uint x_ppem, ref uint y_ppem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1217, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_ptem")]
        public unsafe partial void FontSetPtem(FontT* font, float ptem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1220, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_ptem")]
        public unsafe partial float FontGetPtem(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1223, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_is_synthetic")]
        public unsafe partial int FontIsSynthetic(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1226, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_synthetic_bold")]
        public unsafe partial void FontSetSyntheticBold(FontT* font, float x_embolden, float y_embolden, int in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, float* x_embolden, float* y_embolden, int* in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, float* x_embolden, float* y_embolden, ref int in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, float* x_embolden, ref float y_embolden, int* in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, float* x_embolden, ref float y_embolden, ref int in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, ref float x_embolden, float* y_embolden, int* in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, ref float x_embolden, float* y_embolden, ref int in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, ref float x_embolden, ref float y_embolden, int* in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_bold")]
        public unsafe partial void FontGetSyntheticBold(FontT* font, ref float x_embolden, ref float y_embolden, ref int in_place);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1236, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_synthetic_slant")]
        public unsafe partial void FontSetSyntheticSlant(FontT* font, float slant);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1239, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_synthetic_slant")]
        public unsafe partial float FontGetSyntheticSlant(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1242, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_variations")]
        public unsafe partial void FontSetVariations(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VariationT* variations, uint variations_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1242, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_variations")]
        public unsafe partial void FontSetVariations(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly VariationT variations, uint variations_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1247, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_variation")]
        public unsafe partial void FontSetVariation(FontT* font, uint tag, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1252, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_var_coords_design")]
        public unsafe partial void FontSetVarCoordsDesign(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* coords, uint coords_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1252, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_var_coords_design")]
        public unsafe partial void FontSetVarCoordsDesign(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly float coords, uint coords_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1257, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_var_coords_design")]
        public unsafe partial float* FontGetVarCoordsDesign(FontT* font, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1257, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_var_coords_design")]
        public unsafe partial float* FontGetVarCoordsDesign(FontT* font, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1261, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_var_coords_normalized")]
        public unsafe partial void FontSetVarCoordsNormalized(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint coords_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1261, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_var_coords_normalized")]
        public unsafe partial void FontSetVarCoordsNormalized(FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint coords_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1266, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_var_coords_normalized")]
        public unsafe partial int* FontGetVarCoordsNormalized(FontT* font, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1266, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_var_coords_normalized")]
        public unsafe partial int* FontGetVarCoordsNormalized(FontT* font, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1281, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_set_var_named_instance")]
        public unsafe partial void FontSetVarNamedInstance(FontT* font, uint instance_index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1285, Column 1 in hb-font.h")]
        [NativeApi(EntryPoint = "hb_font_get_var_named_instance")]
        public unsafe partial uint FontGetVarNamedInstance(FontT* font);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_glyph_info_get_glyph_flags")]
        public unsafe partial GlyphFlagsT GlyphInfoGetGlyphFlags([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphInfoT* info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_glyph_info_get_glyph_flags")]
        public partial GlyphFlagsT GlyphInfoGetGlyphFlags([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphInfoT info);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_equal")]
        public unsafe partial int SegmentPropertiesEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_equal")]
        public unsafe partial int SegmentPropertiesEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_equal")]
        public unsafe partial int SegmentPropertiesEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_equal")]
        public partial int SegmentPropertiesEqual([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_hash")]
        public unsafe partial uint SegmentPropertiesHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_hash")]
        public partial uint SegmentPropertiesHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_overlay")]
        public unsafe partial void SegmentPropertiesOverlay(SegmentPropertiesT* p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_overlay")]
        public unsafe partial void SegmentPropertiesOverlay(SegmentPropertiesT* p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_overlay")]
        public unsafe partial void SegmentPropertiesOverlay(ref SegmentPropertiesT p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_segment_properties_overlay")]
        public partial void SegmentPropertiesOverlay(ref SegmentPropertiesT p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_create")]
        public unsafe partial BufferT* BufferCreate();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_create_similar")]
        public unsafe partial BufferT* BufferCreateSimilar([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 259, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_reset")]
        public unsafe partial void BufferReset(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 263, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_empty")]
        public unsafe partial BufferT* BufferGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_reference")]
        public unsafe partial BufferT* BufferReference(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 269, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_destroy")]
        public unsafe partial void BufferDestroy(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_user_data")]
        public unsafe partial int BufferSetUserData(BufferT* buffer, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_user_data")]
        public unsafe partial int BufferSetUserData<T0>(BufferT* buffer, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_user_data")]
        public unsafe partial int BufferSetUserData(BufferT* buffer, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_user_data")]
        public unsafe partial int BufferSetUserData<T0>(BufferT* buffer, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_user_data")]
        public unsafe partial void* BufferGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_user_data")]
        public unsafe partial void* BufferGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 298, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_content_type")]
        public unsafe partial void BufferSetContentType(BufferT* buffer, BufferContentTypeT content_type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 302, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_content_type")]
        public unsafe partial BufferContentTypeT BufferGetContentType([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 306, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_unicode_funcs")]
        public unsafe partial void BufferSetUnicodeFuncs(BufferT* buffer, UnicodeFuncsT* unicode_funcs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_unicode_funcs")]
        public unsafe partial UnicodeFuncsT* BufferGetUnicodeFuncs([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_direction")]
        public unsafe partial void BufferSetDirection(BufferT* buffer, DirectionT direction);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_direction")]
        public unsafe partial DirectionT BufferGetDirection([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_script")]
        public unsafe partial void BufferSetScript(BufferT* buffer, ScriptT script);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 324, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_script")]
        public unsafe partial ScriptT BufferGetScript([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_language")]
        public unsafe partial void BufferSetLanguage(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LanguageImplT* language);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_language")]
        public unsafe partial LanguageImplT* BufferGetLanguage([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_segment_properties")]
        public unsafe partial void BufferSetSegmentProperties(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_segment_properties")]
        public unsafe partial void BufferSetSegmentProperties(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_segment_properties")]
        public unsafe partial void BufferGetSegmentProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, SegmentPropertiesT* props);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_segment_properties")]
        public unsafe partial void BufferGetSegmentProperties([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, ref SegmentPropertiesT props);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_guess_segment_properties")]
        public unsafe partial void BufferGuessSegmentProperties(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_flags")]
        public unsafe partial void BufferSetFlags(BufferT* buffer, BufferFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 415, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_flags")]
        public unsafe partial BufferFlagsT BufferGetFlags([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_cluster_level")]
        public unsafe partial void BufferSetClusterLevel(BufferT* buffer, BufferClusterLevelT cluster_level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 516, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_cluster_level")]
        public unsafe partial BufferClusterLevelT BufferGetClusterLevel([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_replacement_codepoint")]
        public unsafe partial void BufferSetReplacementCodepoint(BufferT* buffer, uint replacement);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 533, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_replacement_codepoint")]
        public unsafe partial uint BufferGetReplacementCodepoint([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 536, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_invisible_glyph")]
        public unsafe partial void BufferSetInvisibleGlyph(BufferT* buffer, uint invisible);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 540, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_invisible_glyph")]
        public unsafe partial uint BufferGetInvisibleGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_not_found_glyph")]
        public unsafe partial void BufferSetNotFoundGlyph(BufferT* buffer, uint not_found);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_not_found_glyph")]
        public unsafe partial uint BufferGetNotFoundGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 550, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_not_found_variation_selector_glyph")]
        public unsafe partial void BufferSetNotFoundVariationSelectorGlyph(BufferT* buffer, uint not_found_variation_selector);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 554, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_not_found_variation_selector_glyph")]
        public unsafe partial uint BufferGetNotFoundVariationSelectorGlyph([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 557, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_random_state")]
        public unsafe partial void BufferSetRandomState(BufferT* buffer, uint state);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_random_state")]
        public unsafe partial uint BufferGetRandomState([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 568, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_clear_contents")]
        public unsafe partial void BufferClearContents(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_pre_allocate")]
        public unsafe partial int BufferPreAllocate(BufferT* buffer, uint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 576, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_allocation_successful")]
        public unsafe partial int BufferAllocationSuccessful(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_reverse")]
        public unsafe partial void BufferReverse(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_reverse_range")]
        public unsafe partial void BufferReverseRange(BufferT* buffer, uint start, uint end);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 586, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_reverse_clusters")]
        public unsafe partial void BufferReverseClusters(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add")]
        public unsafe partial void BufferAdd(BufferT* buffer, uint codepoint, uint cluster);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf8")]
        public unsafe partial void BufferAddUtf8(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf8")]
        public unsafe partial void BufferAddUtf8(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf8")]
        public unsafe partial void BufferAddUtf8(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf16")]
        public unsafe partial void BufferAddUtf16(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf16")]
        public unsafe partial void BufferAddUtf16(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ushort text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf32")]
        public unsafe partial void BufferAddUtf32(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_utf32")]
        public unsafe partial void BufferAddUtf32(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_latin1")]
        public unsafe partial void BufferAddLatin1(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_latin1")]
        public unsafe partial void BufferAddLatin1(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_latin1")]
        public unsafe partial void BufferAddLatin1(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_codepoints")]
        public unsafe partial void BufferAddCodepoints(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_add_codepoints")]
        public unsafe partial void BufferAddCodepoints(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint text, int text_length, uint item_offset, int item_length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 632, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_append")]
        public unsafe partial void BufferAppend(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* source, uint start, uint end);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 638, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_length")]
        public unsafe partial int BufferSetLength(BufferT* buffer, uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 642, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_length")]
        public unsafe partial uint BufferGetLength([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_glyph_infos")]
        public unsafe partial GlyphInfoT* BufferGetGlyphInfos(BufferT* buffer, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_glyph_infos")]
        public unsafe partial GlyphInfoT* BufferGetGlyphInfos(BufferT* buffer, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_glyph_positions")]
        public unsafe partial GlyphPositionT* BufferGetGlyphPositions(BufferT* buffer, uint* length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_get_glyph_positions")]
        public unsafe partial GlyphPositionT* BufferGetGlyphPositions(BufferT* buffer, ref uint length);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 655, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_has_positions")]
        public unsafe partial int BufferHasPositions(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_normalize_glyphs")]
        public unsafe partial void BufferNormalizeGlyphs(BufferT* buffer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 712, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_format_from_string")]
        public unsafe partial BufferSerializeFormatT BufferSerializeFormatFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 712, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_format_from_string")]
        public partial BufferSerializeFormatT BufferSerializeFormatFromString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 712, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_format_from_string")]
        public partial BufferSerializeFormatT BufferSerializeFormatFromString([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_format_to_string")]
        public unsafe partial byte* BufferSerializeFormatToString(BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 1 in hb-buffer.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_buffer_serialize_format_to_string")]
        public partial string BufferSerializeFormatToStringS(BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 718, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_list_formats")]
        public unsafe partial byte** BufferSerializeListFormats();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_glyphs")]
        public unsafe partial uint BufferSerializeGlyphs(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, uint* buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, ref uint buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, uint* buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, ref uint buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, uint* buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize_unicode")]
        public unsafe partial uint BufferSerializeUnicode(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, ref uint buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, ref byte buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_serialize")]
        public unsafe partial uint BufferSerialize(BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, ref uint buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_glyphs")]
        public unsafe partial int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, FontT* font, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_deserialize_unicode")]
        public unsafe partial int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, BufferSerializeFormatT format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 831, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_diff")]
        public unsafe partial BufferDiffFlagsT BufferDiff(BufferT* buffer, BufferT* reference, uint dottedcircle_glyph, uint position_fuzz);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_message_func")]
        public unsafe partial void BufferSetMessageFunc(BufferT* buffer, PfnBufferMessageFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 1 in hb-buffer.h")]
        [NativeApi(EntryPoint = "hb_buffer_set_message_func")]
        public unsafe partial void BufferSetMessageFunc<T0>(BufferT* buffer, PfnBufferMessageFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_func")]
        public unsafe partial void FontFuncsSetGlyphFunc(FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_func")]
        public unsafe partial void FontFuncsSetGlyphFunc<T0>(FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
        public unsafe partial void UnicodeFuncsSetEastasianWidthFunc(UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_eastasian_width_func")]
        public unsafe partial void UnicodeFuncsSetEastasianWidthFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_eastasian_width")]
        public unsafe partial uint UnicodeEastasianWidth(UnicodeFuncsT* ufuncs, uint unicode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func")]
        public unsafe partial void UnicodeFuncsSetDecomposeCompatibilityFunc(UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeCompatibilityFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_funcs_set_decompose_compatibility_func")]
        public unsafe partial void UnicodeFuncsSetDecomposeCompatibilityFunc<T0>(UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeCompatibilityFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose_compatibility")]
        public unsafe partial uint UnicodeDecomposeCompatibility(UnicodeFuncsT* ufuncs, uint u, uint* decomposed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_unicode_decompose_compatibility")]
        public unsafe partial uint UnicodeDecomposeCompatibility(UnicodeFuncsT* ufuncs, uint u, ref uint decomposed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
        public unsafe partial void FontFuncsSetGlyphVKerningFunc(FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_v_kerning_func")]
        public unsafe partial void FontFuncsSetGlyphVKerningFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_v_kerning")]
        public unsafe partial int FontGetGlyphVKerning(FontT* font, uint top_glyph, uint bottom_glyph);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
        public unsafe partial void FontFuncsSetGlyphShapeFunc(FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_glyph_shape_func")]
        public unsafe partial void FontFuncsSetGlyphShapeFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
        public unsafe partial void FontFuncsSetDrawGlyphFunc(FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_draw_glyph_func")]
        public unsafe partial void FontFuncsSetDrawGlyphFunc<T0>(FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 371, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
        public unsafe partial void FontFuncsSetPaintGlyphFunc(FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, void* user_data, PfnDestroyFuncT destroy);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 371, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_funcs_set_paint_glyph_func")]
        public unsafe partial void FontFuncsSetPaintGlyphFunc<T0>(FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, ref T0 user_data, PfnDestroyFuncT destroy) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_shape")]
        public unsafe partial void FontGetGlyphShape(FontT* font, uint glyph, DrawFuncsT* dfuncs, void* draw_data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 1 in hb-deprecated.h")]
        [NativeApi(EntryPoint = "hb_font_get_glyph_shape")]
        public unsafe partial void FontGetGlyphShape<T0>(FontT* font, uint glyph, DrawFuncsT* dfuncs, ref T0 draw_data) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape")]
        public unsafe partial void Shape(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* features, uint num_features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape")]
        public unsafe partial void Shape(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT features, uint num_features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape_full")]
        public unsafe partial int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape_full")]
        public unsafe partial int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape_full")]
        public unsafe partial int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape_full")]
        public unsafe partial int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-shape.h")]
        [NativeApi(EntryPoint = "hb_shape_list_shapers")]
        public unsafe partial byte** ShapeListShapers();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create")]
        public unsafe partial ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create2")]
        public unsafe partial ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_create_cached2")]
        public unsafe partial ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_get_empty")]
        public unsafe partial ShapePlanT* ShapePlanGetEmpty();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 92, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_reference")]
        public unsafe partial ShapePlanT* ShapePlanReference(ShapePlanT* shape_plan);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_destroy")]
        public unsafe partial void ShapePlanDestroy(ShapePlanT* shape_plan);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_set_user_data")]
        public unsafe partial int ShapePlanSetUserData(ShapePlanT* shape_plan, UserDataKeyT* key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_set_user_data")]
        public unsafe partial int ShapePlanSetUserData<T0>(ShapePlanT* shape_plan, UserDataKeyT* key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_set_user_data")]
        public unsafe partial int ShapePlanSetUserData(ShapePlanT* shape_plan, ref UserDataKeyT key, void* data, PfnDestroyFuncT destroy, int replace);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_set_user_data")]
        public unsafe partial int ShapePlanSetUserData<T0>(ShapePlanT* shape_plan, ref UserDataKeyT key, ref T0 data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_get_user_data")]
        public unsafe partial void* ShapePlanGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapePlanT* shape_plan, UserDataKeyT* key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_get_user_data")]
        public unsafe partial void* ShapePlanGetUserData([Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapePlanT* shape_plan, ref UserDataKeyT key);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 110, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_execute")]
        public unsafe partial int ShapePlanExecute(ShapePlanT* shape_plan, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* features, uint num_features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 110, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_execute")]
        public unsafe partial int ShapePlanExecute(ShapePlanT* shape_plan, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT features, uint num_features);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-shape-plan.h")]
        [NativeApi(EntryPoint = "hb_shape_plan_get_shaper")]
        public unsafe partial byte* ShapePlanGetShaper(ShapePlanT* shape_plan);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-shape-plan.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_shape_plan_get_shaper")]
        public unsafe partial string ShapePlanGetShaperS(ShapePlanT* shape_plan);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 1 in hb-style.h")]
        [NativeApi(EntryPoint = "hb_style_get_value")]
        public unsafe partial float StyleGetValue(FontT* font, StyleTagT style_tag);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(uint* major, uint* minor, uint* micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(uint* major, uint* minor, ref uint micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(uint* major, ref uint minor, uint* micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(uint* major, ref uint minor, ref uint micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(ref uint major, uint* minor, uint* micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(ref uint major, uint* minor, ref uint micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public unsafe partial void Version(ref uint major, ref uint minor, uint* micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version")]
        public partial void Version(ref uint major, ref uint minor, ref uint micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 85, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version_string")]
        public unsafe partial byte* VersionString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 85, Column 1 in hb-version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "hb_version_string")]
        public partial string VersionStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 88, Column 1 in hb-version.h")]
        [NativeApi(EntryPoint = "hb_version_atleast")]
        public partial int VersionAtleast(uint major, uint minor, uint micro);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, FontT* font, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeGlyphs(buffer, buf, buf_len, end_ptr, font, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, FontT* font, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeGlyphs(buffer, in buf, buf_len, end_ptr, font, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeGlyphs(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, FontT* font, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeGlyphs(buffer, buf, buf_len, end_ptr, font, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeUnicode(buffer, buf, buf_len, end_ptr, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeUnicode(buffer, in buf, buf_len, end_ptr, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        public unsafe int BufferDeserializeUnicode(BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] end_ptrSa, BufferSerializeFormatT format)
        {
            // StringArrayOverloader
            var end_ptr = (byte**) SilkMarshal.StringArrayToPtr(end_ptrSa);
            var ret = BufferDeserializeUnicode(buffer, buf, buf_len, end_ptr, format);
            SilkMarshal.CopyPtrToStringArray((nint) end_ptr, end_ptrSa);
            SilkMarshal.Free((nint) end_ptr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        public unsafe int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapeFull(font, buffer, features, num_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        public unsafe int ShapeFull(FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapeFull(font, buffer, in features, num_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate(face, props, user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate(face, props, in user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate(face, in props, user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate(face, in props, in user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached(face, props, user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached(face, props, in user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached(face, in props, user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached(face, in props, in user_features, num_user_features, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, props, user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, props, in user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, props, in user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, in props, user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, in props, user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, in props, in user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreate2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreate2(face, in props, in user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, props, user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, props, user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, props, in user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, props, in user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, in props, user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, in props, user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, in props, in user_features, num_user_features, coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public unsafe ShapePlanT* ShapePlanCreateCached2(FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly SegmentPropertiesT props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FeatureT user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly int coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] shaper_listSa)
        {
            // StringArrayOverloader
            var shaper_list = (byte**) SilkMarshal.StringArrayToPtr(shaper_listSa);
            var ret = ShapePlanCreateCached2(face, in props, in user_features, num_user_features, in coords, num_coords, shaper_list);
            SilkMarshal.CopyPtrToStringArray((nint) shaper_list, shaper_listSa);
            SilkMarshal.Free((nint) shaper_list);
            return ret;
        }


        public HarfBuzz(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

