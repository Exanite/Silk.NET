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
    public static class HarfBuzzOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 215, Column 1 in hb-common.h")]
        public static unsafe uint TagFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len)
        {
            // SpanOverloader
            return thisApi.TagFromString(in str.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 219, Column 1 in hb-common.h")]
        public static unsafe void TagToString(this HarfBuzz thisApi, uint tag, Span<byte> buf)
        {
            // SpanOverloader
            thisApi.TagToString(tag, ref buf.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 1 in hb-common.h")]
        public static unsafe DirectionT DirectionFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len)
        {
            // SpanOverloader
            return thisApi.DirectionFromString(in str.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-common.h")]
        public static unsafe LanguageImplT* LanguageFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len)
        {
            // SpanOverloader
            return thisApi.LanguageFromString(in str.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 1 in hb-common.h")]
        public static unsafe ScriptT ScriptFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len)
        {
            // SpanOverloader
            return thisApi.ScriptFromString(in str.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        public static unsafe int FeatureFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, Span<FeatureT> feature)
        {
            // SpanOverloader
            return thisApi.FeatureFromString(str, len, ref feature.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        public static unsafe int FeatureFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len, FeatureT* feature)
        {
            // SpanOverloader
            return thisApi.FeatureFromString(in str.GetPinnableReference(), len, feature);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        public static unsafe int FeatureFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len, Span<FeatureT> feature)
        {
            // SpanOverloader
            return thisApi.FeatureFromString(in str.GetPinnableReference(), len, ref feature.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 426, Column 1 in hb-common.h")]
        public static unsafe int FeatureFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, Span<FeatureT> feature)
        {
            // SpanOverloader
            return thisApi.FeatureFromString(str, len, ref feature.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        public static unsafe void FeatureToString(this HarfBuzz thisApi, FeatureT* feature, Span<byte> buf, uint size)
        {
            // SpanOverloader
            thisApi.FeatureToString(feature, ref buf.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        public static unsafe void FeatureToString(this HarfBuzz thisApi, Span<FeatureT> feature, byte* buf, uint size)
        {
            // SpanOverloader
            thisApi.FeatureToString(ref feature.GetPinnableReference(), buf, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        public static unsafe void FeatureToString(this HarfBuzz thisApi, Span<FeatureT> feature, Span<byte> buf, uint size)
        {
            // SpanOverloader
            thisApi.FeatureToString(ref feature.GetPinnableReference(), ref buf.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 430, Column 1 in hb-common.h")]
        public static unsafe void FeatureToString(this HarfBuzz thisApi, Span<FeatureT> feature, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size)
        {
            // SpanOverloader
            thisApi.FeatureToString(ref feature.GetPinnableReference(), buf, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        public static unsafe int VariationFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* str, int len, Span<VariationT> variation)
        {
            // SpanOverloader
            return thisApi.VariationFromString(str, len, ref variation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        public static unsafe int VariationFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len, VariationT* variation)
        {
            // SpanOverloader
            return thisApi.VariationFromString(in str.GetPinnableReference(), len, variation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        public static unsafe int VariationFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len, Span<VariationT> variation)
        {
            // SpanOverloader
            return thisApi.VariationFromString(in str.GetPinnableReference(), len, ref variation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 450, Column 1 in hb-common.h")]
        public static unsafe int VariationFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string str, int len, Span<VariationT> variation)
        {
            // SpanOverloader
            return thisApi.VariationFromString(str, len, ref variation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        public static unsafe void VariationToString(this HarfBuzz thisApi, VariationT* variation, Span<byte> buf, uint size)
        {
            // SpanOverloader
            thisApi.VariationToString(variation, ref buf.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        public static unsafe void VariationToString(this HarfBuzz thisApi, Span<VariationT> variation, byte* buf, uint size)
        {
            // SpanOverloader
            thisApi.VariationToString(ref variation.GetPinnableReference(), buf, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        public static unsafe void VariationToString(this HarfBuzz thisApi, Span<VariationT> variation, Span<byte> buf, uint size)
        {
            // SpanOverloader
            thisApi.VariationToString(ref variation.GetPinnableReference(), ref buf.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 454, Column 1 in hb-common.h")]
        public static unsafe void VariationToString(this HarfBuzz thisApi, Span<VariationT> variation, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint size)
        {
            // SpanOverloader
            thisApi.VariationToString(ref variation.GetPinnableReference(), buf, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 528, Column 1 in hb-common.h")]
        public static unsafe void* Realloc<T0>(this HarfBuzz thisApi, Span<T0> ptr, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.Realloc(ref ptr.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 1 in hb-common.h")]
        public static unsafe void Free<T0>(this HarfBuzz thisApi, Span<T0> ptr) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Free(ref ptr.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreate<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreate(data, length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreate(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy)
        {
            // SpanOverloader
            return thisApi.BlobCreate(in data.GetPinnableReference(), length, mode, user_data, destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreate<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreate(in data.GetPinnableReference(), length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreate<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreate(data, length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateOrFail<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreateOrFail(data, length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateOrFail(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint length, MemoryModeT mode, void* user_data, PfnDestroyFuncT destroy)
        {
            // SpanOverloader
            return thisApi.BlobCreateOrFail(in data.GetPinnableReference(), length, mode, user_data, destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateOrFail<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreateOrFail(in data.GetPinnableReference(), length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 94, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateOrFail<T0>(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint length, MemoryModeT mode, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobCreateOrFail(data, length, mode, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 101, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateFromFile(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name)
        {
            // SpanOverloader
            return thisApi.BlobCreateFromFile(in file_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 104, Column 1 in hb-blob.h")]
        public static unsafe BlobT* BlobCreateFromFileOrFail(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name)
        {
            // SpanOverloader
            return thisApi.BlobCreateFromFileOrFail(in file_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        public static unsafe int BlobSetUserData<T0>(this HarfBuzz thisApi, BlobT* blob, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobSetUserData(blob, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        public static unsafe int BlobSetUserData(this HarfBuzz thisApi, BlobT* blob, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.BlobSetUserData(blob, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 130, Column 1 in hb-blob.h")]
        public static unsafe int BlobSetUserData<T0>(this HarfBuzz thisApi, BlobT* blob, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BlobSetUserData(blob, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 138, Column 1 in hb-blob.h")]
        public static unsafe void* BlobGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlobT* blob, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.BlobGetUserData(blob, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 153, Column 1 in hb-blob.h")]
        public static unsafe byte* BlobGetData(this HarfBuzz thisApi, BlobT* blob, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.BlobGetData(blob, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 156, Column 1 in hb-blob.h")]
        public static unsafe byte* BlobGetDataWritable(this HarfBuzz thisApi, BlobT* blob, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.BlobGetDataWritable(blob, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeFuncsSetUserData<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UnicodeFuncsSetUserData(ufuncs, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeFuncsSetUserData(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.UnicodeFuncsSetUserData(ufuncs, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeFuncsSetUserData<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.UnicodeFuncsSetUserData(ufuncs, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 320, Column 1 in hb-unicode.h")]
        public static unsafe void* UnicodeFuncsGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeFuncsT* ufuncs, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.UnicodeFuncsGetUserData(ufuncs, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 479, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetCombiningClassFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeCombiningClassFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetCombiningClassFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetGeneralCategoryFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeGeneralCategoryFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetGeneralCategoryFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetMirroringFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetMirroringFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 527, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetScriptFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeScriptFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetScriptFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetComposeFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeComposeFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetComposeFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 559, Column 1 in hb-unicode.h")]
        public static unsafe void UnicodeFuncsSetDecomposeFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetDecomposeFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 630, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeCompose(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, uint a, uint b, Span<uint> ab)
        {
            // SpanOverloader
            return thisApi.UnicodeCompose(ufuncs, a, b, ref ab.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeDecompose(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, uint ab, uint* a, Span<uint> b)
        {
            // SpanOverloader
            return thisApi.UnicodeDecompose(ufuncs, ab, a, ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeDecompose(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, uint ab, Span<uint> a, uint* b)
        {
            // SpanOverloader
            return thisApi.UnicodeDecompose(ufuncs, ab, ref a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 1 in hb-unicode.h")]
        public static unsafe int UnicodeDecompose(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, uint ab, Span<uint> a, Span<uint> b)
        {
            // SpanOverloader
            return thisApi.UnicodeDecompose(ufuncs, ab, ref a.GetPinnableReference(), ref b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        public static unsafe int SetSetUserData<T0>(this HarfBuzz thisApi, SetT* set, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSetUserData(set, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        public static unsafe int SetSetUserData(this HarfBuzz thisApi, SetT* set, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.SetSetUserData(set, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-set.h")]
        public static unsafe int SetSetUserData<T0>(this HarfBuzz thisApi, SetT* set, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SetSetUserData(set, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-set.h")]
        public static unsafe void* SetGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.SetGetUserData(set, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 1 in hb-set.h")]
        public static unsafe void SetAddSortedArray(this HarfBuzz thisApi, SetT* set, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> sorted_codepoints, uint num_codepoints)
        {
            // SpanOverloader
            thisApi.SetAddSortedArray(set, in sorted_codepoints.GetPinnableReference(), num_codepoints);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 1 in hb-set.h")]
        public static unsafe int SetNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> codepoint)
        {
            // SpanOverloader
            return thisApi.SetNext(set, ref codepoint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 179, Column 1 in hb-set.h")]
        public static unsafe int SetPrevious(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> codepoint)
        {
            // SpanOverloader
            return thisApi.SetPrevious(set, ref codepoint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        public static unsafe int SetNextRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, Span<uint> last)
        {
            // SpanOverloader
            return thisApi.SetNextRange(set, first, ref last.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        public static unsafe int SetNextRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> first, uint* last)
        {
            // SpanOverloader
            return thisApi.SetNextRange(set, ref first.GetPinnableReference(), last);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 1 in hb-set.h")]
        public static unsafe int SetNextRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> first, Span<uint> last)
        {
            // SpanOverloader
            return thisApi.SetNextRange(set, ref first.GetPinnableReference(), ref last.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        public static unsafe int SetPreviousRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint* first, Span<uint> last)
        {
            // SpanOverloader
            return thisApi.SetPreviousRange(set, first, ref last.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        public static unsafe int SetPreviousRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> first, uint* last)
        {
            // SpanOverloader
            return thisApi.SetPreviousRange(set, ref first.GetPinnableReference(), last);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 190, Column 1 in hb-set.h")]
        public static unsafe int SetPreviousRange(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, Span<uint> first, Span<uint> last)
        {
            // SpanOverloader
            return thisApi.SetPreviousRange(set, ref first.GetPinnableReference(), ref last.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 196, Column 1 in hb-set.h")]
        public static unsafe uint SetNextMany(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SetT* set, uint codepoint, Span<uint> @out, uint size)
        {
            // SpanOverloader
            return thisApi.SetNextMany(set, codepoint, ref @out.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        public static unsafe int MapSetUserData<T0>(this HarfBuzz thisApi, MapT* map, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.MapSetUserData(map, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        public static unsafe int MapSetUserData(this HarfBuzz thisApi, MapT* map, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.MapSetUserData(map, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 71, Column 1 in hb-map.h")]
        public static unsafe int MapSetUserData<T0>(this HarfBuzz thisApi, MapT* map, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.MapSetUserData(map, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-map.h")]
        public static unsafe void* MapGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.MapGetUserData(map, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, uint* key, Span<uint> value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, idx, key, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, Span<uint> key, uint* value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, idx, ref key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, int* idx, Span<uint> key, Span<uint> value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, idx, ref key.GetPinnableReference(), ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, Span<int> idx, uint* key, uint* value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, ref idx.GetPinnableReference(), key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, Span<int> idx, uint* key, Span<uint> value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, ref idx.GetPinnableReference(), key, ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, Span<int> idx, Span<uint> key, uint* value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, ref idx.GetPinnableReference(), ref key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 128, Column 1 in hb-map.h")]
        public static unsafe int MapNext(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MapT* map, Span<int> idx, Span<uint> key, Span<uint> value)
        {
            // SpanOverloader
            return thisApi.MapNext(map, ref idx.GetPinnableReference(), ref key.GetPinnableReference(), ref value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 67, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateOrFailUsing(this HarfBuzz thisApi, BlobT* blob, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateOrFailUsing(blob, index, in loader_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFail(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name, uint index)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFail(in file_name.GetPinnableReference(), index);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFailUsing(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFailUsing(file_name, index, in loader_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFailUsing(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFailUsing(in file_name.GetPinnableReference(), index, loader_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFailUsing(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFailUsing(in file_name.GetPinnableReference(), index, in loader_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFailUsing(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFailUsing(in file_name.GetPinnableReference(), index, loader_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 76, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateFromFileOrFailUsing(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file_name, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> loader_name)
        {
            // SpanOverloader
            return thisApi.FaceCreateFromFileOrFailUsing(file_name, index, in loader_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 106, Column 1 in hb-face.h")]
        public static unsafe FaceT* FaceCreateForTables<T0>(this HarfBuzz thisApi, PfnReferenceTableFuncT reference_table_func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FaceCreateForTables(reference_table_func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        public static unsafe int FaceSetUserData<T0>(this HarfBuzz thisApi, FaceT* face, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FaceSetUserData(face, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        public static unsafe int FaceSetUserData(this HarfBuzz thisApi, FaceT* face, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.FaceSetUserData(face, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 1 in hb-face.h")]
        public static unsafe int FaceSetUserData<T0>(this HarfBuzz thisApi, FaceT* face, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FaceSetUserData(face, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 1 in hb-face.h")]
        public static unsafe void* FaceGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.FaceGetUserData(face, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 188, Column 1 in hb-face.h")]
        public static unsafe void FaceSetGetTableTagsFunc<T0>(this HarfBuzz thisApi, FaceT* face, PfnGetTableTagsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FaceSetGetTableTagsFunc(face, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        public static unsafe uint FaceGetTableTags(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, uint* table_count, Span<uint> table_tags)
        {
            // SpanOverloader
            return thisApi.FaceGetTableTags(face, start_offset, table_count, ref table_tags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        public static unsafe uint FaceGetTableTags(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, Span<uint> table_count, uint* table_tags)
        {
            // SpanOverloader
            return thisApi.FaceGetTableTags(face, start_offset, ref table_count.GetPinnableReference(), table_tags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 194, Column 1 in hb-face.h")]
        public static unsafe uint FaceGetTableTags(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceT* face, uint start_offset, Span<uint> table_count, Span<uint> table_tags)
        {
            // SpanOverloader
            return thisApi.FaceGetTableTags(face, start_offset, ref table_count.GetPinnableReference(), ref table_tags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-face.h")]
        public static unsafe void FaceBuilderSortTables(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> tags)
        {
            // SpanOverloader
            thisApi.FaceBuilderSortTables(face, in tags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 1 in hb-draw.h")]
        public static unsafe void DrawFuncsSetMoveToFunc<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawFuncsSetMoveToFunc(dfuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 226, Column 1 in hb-draw.h")]
        public static unsafe void DrawFuncsSetLineToFunc<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, PfnDrawMoveToFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawFuncsSetLineToFunc(dfuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 1 in hb-draw.h")]
        public static unsafe void DrawFuncsSetQuadraticToFunc<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, PfnDrawQuadraticToFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawFuncsSetQuadraticToFunc(dfuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 1 in hb-draw.h")]
        public static unsafe void DrawFuncsSetCubicToFunc<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, PfnDrawCubicToFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawFuncsSetCubicToFunc(dfuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 274, Column 1 in hb-draw.h")]
        public static unsafe void DrawFuncsSetClosePathFunc<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, PfnDrawClosePathFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawFuncsSetClosePathFunc(dfuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        public static unsafe int DrawFuncsSetUserData<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DrawFuncsSetUserData(dfuncs, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        public static unsafe int DrawFuncsSetUserData(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.DrawFuncsSetUserData(dfuncs, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 1 in hb-draw.h")]
        public static unsafe int DrawFuncsSetUserData<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DrawFuncsSetUserData(dfuncs, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 300, Column 1 in hb-draw.h")]
        public static unsafe void* DrawFuncsGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawFuncsT* dfuncs, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.DrawFuncsGetUserData(dfuncs, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        public static unsafe void DrawMoveTo(this HarfBuzz thisApi, DrawFuncsT* dfuncs, void* draw_data, Span<DrawStateT> st, float to_x, float to_y)
        {
            // SpanOverloader
            thisApi.DrawMoveTo(dfuncs, draw_data, ref st.GetPinnableReference(), to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        public static unsafe void DrawMoveTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, DrawStateT* st, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawMoveTo(dfuncs, ref draw_data.GetPinnableReference(), st, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 311, Column 1 in hb-draw.h")]
        public static unsafe void DrawMoveTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, Span<DrawStateT> st, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawMoveTo(dfuncs, ref draw_data.GetPinnableReference(), ref st.GetPinnableReference(), to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        public static unsafe void DrawLineTo(this HarfBuzz thisApi, DrawFuncsT* dfuncs, void* draw_data, Span<DrawStateT> st, float to_x, float to_y)
        {
            // SpanOverloader
            thisApi.DrawLineTo(dfuncs, draw_data, ref st.GetPinnableReference(), to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        public static unsafe void DrawLineTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, DrawStateT* st, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawLineTo(dfuncs, ref draw_data.GetPinnableReference(), st, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 1 in hb-draw.h")]
        public static unsafe void DrawLineTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, Span<DrawStateT> st, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawLineTo(dfuncs, ref draw_data.GetPinnableReference(), ref st.GetPinnableReference(), to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        public static unsafe void DrawQuadraticTo(this HarfBuzz thisApi, DrawFuncsT* dfuncs, void* draw_data, Span<DrawStateT> st, float control_x, float control_y, float to_x, float to_y)
        {
            // SpanOverloader
            thisApi.DrawQuadraticTo(dfuncs, draw_data, ref st.GetPinnableReference(), control_x, control_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        public static unsafe void DrawQuadraticTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, DrawStateT* st, float control_x, float control_y, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawQuadraticTo(dfuncs, ref draw_data.GetPinnableReference(), st, control_x, control_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 321, Column 1 in hb-draw.h")]
        public static unsafe void DrawQuadraticTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, Span<DrawStateT> st, float control_x, float control_y, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawQuadraticTo(dfuncs, ref draw_data.GetPinnableReference(), ref st.GetPinnableReference(), control_x, control_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        public static unsafe void DrawCubicTo(this HarfBuzz thisApi, DrawFuncsT* dfuncs, void* draw_data, Span<DrawStateT> st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y)
        {
            // SpanOverloader
            thisApi.DrawCubicTo(dfuncs, draw_data, ref st.GetPinnableReference(), control1_x, control1_y, control2_x, control2_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        public static unsafe void DrawCubicTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, DrawStateT* st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawCubicTo(dfuncs, ref draw_data.GetPinnableReference(), st, control1_x, control1_y, control2_x, control2_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 1 in hb-draw.h")]
        public static unsafe void DrawCubicTo<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, Span<DrawStateT> st, float control1_x, float control1_y, float control2_x, float control2_y, float to_x, float to_y) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawCubicTo(dfuncs, ref draw_data.GetPinnableReference(), ref st.GetPinnableReference(), control1_x, control1_y, control2_x, control2_y, to_x, to_y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        public static unsafe void DrawClosePath(this HarfBuzz thisApi, DrawFuncsT* dfuncs, void* draw_data, Span<DrawStateT> st)
        {
            // SpanOverloader
            thisApi.DrawClosePath(dfuncs, draw_data, ref st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        public static unsafe void DrawClosePath<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, DrawStateT* st) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawClosePath(dfuncs, ref draw_data.GetPinnableReference(), st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 1 in hb-draw.h")]
        public static unsafe void DrawClosePath<T0>(this HarfBuzz thisApi, DrawFuncsT* dfuncs, Span<T0> draw_data, Span<DrawStateT> st) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawClosePath(dfuncs, ref draw_data.GetPinnableReference(), ref st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        public static unsafe int PaintFuncsSetUserData<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PaintFuncsSetUserData(funcs, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        public static unsafe int PaintFuncsSetUserData(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.PaintFuncsSetUserData(funcs, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 1 in hb-paint.h")]
        public static unsafe int PaintFuncsSetUserData<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PaintFuncsSetUserData(funcs, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 1 in hb-paint.h")]
        public static unsafe void* PaintFuncsGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PaintFuncsT* funcs, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.PaintFuncsGetUserData(funcs, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, ColorLineT* color_line, uint start, uint* count, Span<ColorStopT> color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(color_line, start, count, ref color_stops.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, ColorLineT* color_line, uint start, Span<uint> count, ColorStopT* color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(color_line, start, ref count.GetPinnableReference(), color_stops);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, ColorLineT* color_line, uint start, Span<uint> count, Span<ColorStopT> color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(color_line, start, ref count.GetPinnableReference(), ref color_stops.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, Span<ColorLineT> color_line, uint start, uint* count, ColorStopT* color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(ref color_line.GetPinnableReference(), start, count, color_stops);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, Span<ColorLineT> color_line, uint start, uint* count, Span<ColorStopT> color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(ref color_line.GetPinnableReference(), start, count, ref color_stops.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, Span<ColorLineT> color_line, uint start, Span<uint> count, ColorStopT* color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(ref color_line.GetPinnableReference(), start, ref count.GetPinnableReference(), color_stops);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 432, Column 1 in hb-paint.h")]
        public static unsafe uint ColorLineGetColorStops(this HarfBuzz thisApi, Span<ColorLineT> color_line, uint start, Span<uint> count, Span<ColorStopT> color_stops)
        {
            // SpanOverloader
            return thisApi.ColorLineGetColorStops(ref color_line.GetPinnableReference(), start, ref count.GetPinnableReference(), ref color_stops.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 1 in hb-paint.h")]
        public static unsafe PaintExtendT ColorLineGetExtend(this HarfBuzz thisApi, Span<ColorLineT> color_line)
        {
            // SpanOverloader
            return thisApi.ColorLineGetExtend(ref color_line.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 726, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPushTransformFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPushTransformFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPushTransformFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPopTransformFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPopTransformFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 760, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetColorGlyphFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintColorGlyphFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetColorGlyphFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPushClipGlyphFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPushClipGlyphFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPushClipGlyphFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 794, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPushClipRectangleFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPushClipRectangleFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPushClipRectangleFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPopClipFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPopClipFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetColorFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintColorFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetColorFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetImageFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintImageFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetImageFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetLinearGradientFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetLinearGradientFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 879, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetRadialGradientFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintLinearGradientFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetRadialGradientFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetSweepGradientFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintSweepGradientFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetSweepGradientFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPushGroupFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPopTransformFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPushGroupFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetPopGroupFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintPopGroupFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetPopGroupFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-paint.h")]
        public static unsafe void PaintFuncsSetCustomPaletteColorFunc<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, PfnPaintCustomPaletteColorFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintFuncsSetCustomPaletteColorFunc(funcs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 956, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushTransform<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, float xx, float yx, float xy, float yy, float dx, float dy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushTransform(funcs, ref paint_data.GetPinnableReference(), xx, yx, xy, yy, dx, dy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushFontTransform<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushFontTransform(funcs, ref paint_data.GetPinnableReference(), font);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushInverseFontTransform<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushInverseFontTransform(funcs, ref paint_data.GetPinnableReference(), font);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 970, Column 1 in hb-paint.h")]
        public static unsafe void PaintPopTransform<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPopTransform(funcs, ref paint_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 1 in hb-paint.h")]
        public static unsafe int PaintColorGlyph<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, uint glyph, FontT* font) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PaintColorGlyph(funcs, ref paint_data.GetPinnableReference(), glyph, font);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 978, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushClipGlyph<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, uint glyph, FontT* font) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushClipGlyph(funcs, ref paint_data.GetPinnableReference(), glyph, font);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 983, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushClipRectangle<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, float xmin, float ymin, float xmax, float ymax) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushClipRectangle(funcs, ref paint_data.GetPinnableReference(), xmin, ymin, xmax, ymax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 988, Column 1 in hb-paint.h")]
        public static unsafe void PaintPopClip<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPopClip(funcs, ref paint_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 991, Column 1 in hb-paint.h")]
        public static unsafe void PaintColor<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, int is_foreground, uint color) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintColor(funcs, ref paint_data.GetPinnableReference(), is_foreground, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        public static unsafe void PaintImage(this HarfBuzz thisApi, PaintFuncsT* funcs, void* paint_data, BlobT* image, uint width, uint height, uint format, float slant, Span<GlyphExtentsT> extents)
        {
            // SpanOverloader
            thisApi.PaintImage(funcs, paint_data, image, width, height, format, slant, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        public static unsafe void PaintImage<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, BlobT* image, uint width, uint height, uint format, float slant, GlyphExtentsT* extents) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintImage(funcs, ref paint_data.GetPinnableReference(), image, width, height, format, slant, extents);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 1 in hb-paint.h")]
        public static unsafe void PaintImage<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, BlobT* image, uint width, uint height, uint format, float slant, Span<GlyphExtentsT> extents) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintImage(funcs, ref paint_data.GetPinnableReference(), image, width, height, format, slant, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        public static unsafe void PaintLinearGradient(this HarfBuzz thisApi, PaintFuncsT* funcs, void* paint_data, Span<ColorLineT> color_line, float x0, float y0, float x1, float y1, float x2, float y2)
        {
            // SpanOverloader
            thisApi.PaintLinearGradient(funcs, paint_data, ref color_line.GetPinnableReference(), x0, y0, x1, y1, x2, y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        public static unsafe void PaintLinearGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, ColorLineT* color_line, float x0, float y0, float x1, float y1, float x2, float y2) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintLinearGradient(funcs, ref paint_data.GetPinnableReference(), color_line, x0, y0, x1, y1, x2, y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-paint.h")]
        public static unsafe void PaintLinearGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, Span<ColorLineT> color_line, float x0, float y0, float x1, float y1, float x2, float y2) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintLinearGradient(funcs, ref paint_data.GetPinnableReference(), ref color_line.GetPinnableReference(), x0, y0, x1, y1, x2, y2);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        public static unsafe void PaintRadialGradient(this HarfBuzz thisApi, PaintFuncsT* funcs, void* paint_data, Span<ColorLineT> color_line, float x0, float y0, float r0, float x1, float y1, float r1)
        {
            // SpanOverloader
            thisApi.PaintRadialGradient(funcs, paint_data, ref color_line.GetPinnableReference(), x0, y0, r0, x1, y1, r1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        public static unsafe void PaintRadialGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, ColorLineT* color_line, float x0, float y0, float r0, float x1, float y1, float r1) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintRadialGradient(funcs, ref paint_data.GetPinnableReference(), color_line, x0, y0, r0, x1, y1, r1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1012, Column 1 in hb-paint.h")]
        public static unsafe void PaintRadialGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, Span<ColorLineT> color_line, float x0, float y0, float r0, float x1, float y1, float r1) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintRadialGradient(funcs, ref paint_data.GetPinnableReference(), ref color_line.GetPinnableReference(), x0, y0, r0, x1, y1, r1);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        public static unsafe void PaintSweepGradient(this HarfBuzz thisApi, PaintFuncsT* funcs, void* paint_data, Span<ColorLineT> color_line, float x0, float y0, float start_angle, float end_angle)
        {
            // SpanOverloader
            thisApi.PaintSweepGradient(funcs, paint_data, ref color_line.GetPinnableReference(), x0, y0, start_angle, end_angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        public static unsafe void PaintSweepGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, ColorLineT* color_line, float x0, float y0, float start_angle, float end_angle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintSweepGradient(funcs, ref paint_data.GetPinnableReference(), color_line, x0, y0, start_angle, end_angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 1 in hb-paint.h")]
        public static unsafe void PaintSweepGradient<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, Span<ColorLineT> color_line, float x0, float y0, float start_angle, float end_angle) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintSweepGradient(funcs, ref paint_data.GetPinnableReference(), ref color_line.GetPinnableReference(), x0, y0, start_angle, end_angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1026, Column 1 in hb-paint.h")]
        public static unsafe void PaintPushGroup<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPushGroup(funcs, ref paint_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1029, Column 1 in hb-paint.h")]
        public static unsafe void PaintPopGroup<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, PaintCompositeModeT mode) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PaintPopGroup(funcs, ref paint_data.GetPinnableReference(), mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        public static unsafe int PaintCustomPaletteColor(this HarfBuzz thisApi, PaintFuncsT* funcs, void* paint_data, uint color_index, Span<uint> color)
        {
            // SpanOverloader
            return thisApi.PaintCustomPaletteColor(funcs, paint_data, color_index, ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        public static unsafe int PaintCustomPaletteColor<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, uint color_index, uint* color) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PaintCustomPaletteColor(funcs, ref paint_data.GetPinnableReference(), color_index, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1033, Column 1 in hb-paint.h")]
        public static unsafe int PaintCustomPaletteColor<T0>(this HarfBuzz thisApi, PaintFuncsT* funcs, Span<T0> paint_data, uint color_index, Span<uint> color) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.PaintCustomPaletteColor(funcs, ref paint_data.GetPinnableReference(), color_index, ref color.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        public static unsafe int FontFuncsSetUserData<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontFuncsSetUserData(ffuncs, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        public static unsafe int FontFuncsSetUserData(this HarfBuzz thisApi, FontFuncsT* ffuncs, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.FontFuncsSetUserData(ffuncs, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 73, Column 1 in hb-font.h")]
        public static unsafe int FontFuncsSetUserData<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontFuncsSetUserData(ffuncs, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 81, Column 1 in hb-font.h")]
        public static unsafe void* FontFuncsGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontFuncsT* ffuncs, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.FontFuncsGetUserData(ffuncs, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 605, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetFontHExtentsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetFontHExtentsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 621, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetFontVExtentsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetFontExtentsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetFontVExtentsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 637, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetNominalGlyphFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetNominalGlyphFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetNominalGlyphFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 653, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetNominalGlyphsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetNominalGlyphsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetNominalGlyphsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 669, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetVariationGlyphFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetVariationGlyphFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphHAdvanceFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphHAdvanceFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 701, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphVAdvanceFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphAdvanceFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphVAdvanceFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 717, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphHAdvancesFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphHAdvancesFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 733, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphVAdvancesFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphAdvancesFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphVAdvancesFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphHOriginFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphHOriginFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 765, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphVOriginFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphOriginFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphVOriginFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 781, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphHOriginsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphHOriginsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 797, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphVOriginsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphOriginsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphVOriginsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 813, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphHKerningFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphHKerningFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphExtentsFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphExtentsFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphExtentsFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 845, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphContourPointFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphContourPointFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphContourPointFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 861, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphNameFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphNameFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphNameFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 877, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetGlyphFromNameFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphFromNameFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphFromNameFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 893, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetDrawGlyphOrFailFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontDrawGlyphOrFailFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetDrawGlyphOrFailFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 1 in hb-font.h")]
        public static unsafe void FontFuncsSetPaintGlyphOrFailFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetPaintGlyphOrFailFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 1 in hb-font.h")]
        public static unsafe int FontGetHExtents(this HarfBuzz thisApi, FontT* font, Span<FontExtentsT> extents)
        {
            // SpanOverloader
            return thisApi.FontGetHExtents(font, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 1 in hb-font.h")]
        public static unsafe int FontGetVExtents(this HarfBuzz thisApi, FontT* font, Span<FontExtentsT> extents)
        {
            // SpanOverloader
            return thisApi.FontGetVExtents(font, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 1 in hb-font.h")]
        public static unsafe int FontGetNominalGlyph(this HarfBuzz thisApi, FontT* font, uint unicode, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetNominalGlyph(font, unicode, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 927, Column 1 in hb-font.h")]
        public static unsafe int FontGetVariationGlyph(this HarfBuzz thisApi, FontT* font, uint unicode, uint variation_selector, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetVariationGlyph(font, unicode, variation_selector, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        public static unsafe uint FontGetNominalGlyphs(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_unicode, uint unicode_stride, Span<uint> first_glyph, uint glyph_stride)
        {
            // SpanOverloader
            return thisApi.FontGetNominalGlyphs(font, count, first_unicode, unicode_stride, ref first_glyph.GetPinnableReference(), glyph_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        public static unsafe uint FontGetNominalGlyphs(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_unicode, uint unicode_stride, uint* first_glyph, uint glyph_stride)
        {
            // SpanOverloader
            return thisApi.FontGetNominalGlyphs(font, count, in first_unicode.GetPinnableReference(), unicode_stride, first_glyph, glyph_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 932, Column 1 in hb-font.h")]
        public static unsafe uint FontGetNominalGlyphs(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_unicode, uint unicode_stride, Span<uint> first_glyph, uint glyph_stride)
        {
            // SpanOverloader
            return thisApi.FontGetNominalGlyphs(font, count, in first_unicode.GetPinnableReference(), unicode_stride, ref first_glyph.GetPinnableReference(), glyph_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphHAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphHAdvances(font, count, first_glyph, glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphHAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphHAdvances(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_advance, advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 947, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphHAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphHAdvances(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphVAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphVAdvances(font, count, first_glyph, glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphVAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphVAdvances(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_advance, advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 954, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphVAdvances(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphVAdvances(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigin(font, glyph, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigin(font, glyph, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigin(font, glyph, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigin(font, glyph, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigin(font, glyph, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 966, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigin(font, glyph, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, first_glyph, glyph_stride, first_x, x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, first_glyph, glyph_stride, ref first_x.GetPinnableReference(), x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, first_glyph, glyph_stride, ref first_x.GetPinnableReference(), x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_x, x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_x, x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_x.GetPinnableReference(), x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphHOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphHOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_x.GetPinnableReference(), x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, int* first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, first_glyph, glyph_stride, first_x, x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, first_glyph, glyph_stride, ref first_x.GetPinnableReference(), x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, first_glyph, glyph_stride, ref first_x.GetPinnableReference(), x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_x, x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, first_x, x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, int* first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_x.GetPinnableReference(), x_stride, first_y, y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 981, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphVOrigins(this HarfBuzz thisApi, FontT* font, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_x, uint x_stride, Span<int> first_y, uint y_stride)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphVOrigins(font, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_x.GetPinnableReference(), x_stride, ref first_y.GetPinnableReference(), y_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 995, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphExtents(this HarfBuzz thisApi, FontT* font, uint glyph, Span<GlyphExtentsT> extents)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphExtents(font, glyph, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPoint(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPoint(font, glyph, point_index, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPoint(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPoint(font, glyph, point_index, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1000, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPoint(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPoint(font, glyph, point_index, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1005, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphName(this HarfBuzz thisApi, FontT* font, uint glyph, Span<byte> name, uint size)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphName(font, glyph, ref name.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphFromName(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphFromName(font, name, len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphFromName(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int len, uint* glyph)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphFromName(font, in name.GetPinnableReference(), len, glyph);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphFromName(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphFromName(font, in name.GetPinnableReference(), len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1009, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphFromName(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphFromName(font, name, len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1014, Column 1 in hb-font.h")]
        public static unsafe int FontDrawGlyphOrFail<T0>(this HarfBuzz thisApi, FontT* font, uint glyph, DrawFuncsT* dfuncs, Span<T0> draw_data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontDrawGlyphOrFail(font, glyph, dfuncs, ref draw_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1019, Column 1 in hb-font.h")]
        public static unsafe int FontPaintGlyphOrFail<T0>(this HarfBuzz thisApi, FontT* font, uint glyph, PaintFuncsT* pfuncs, Span<T0> paint_data, uint palette_index, uint foreground) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontPaintGlyphOrFail(font, glyph, pfuncs, ref paint_data.GetPinnableReference(), palette_index, foreground);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1030, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyph(this HarfBuzz thisApi, FontT* font, uint unicode, uint variation_selector, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGetGlyph(font, unicode, variation_selector, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1035, Column 1 in hb-font.h")]
        public static unsafe void FontGetExtentsForDirection(this HarfBuzz thisApi, FontT* font, DirectionT direction, Span<FontExtentsT> extents)
        {
            // SpanOverloader
            thisApi.FontGetExtentsForDirection(font, direction, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvanceForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvanceForDirection(font, glyph, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvanceForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvanceForDirection(font, glyph, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1039, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvanceForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvanceForDirection(font, glyph, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvancesForDirection(this HarfBuzz thisApi, FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvancesForDirection(font, direction, count, first_glyph, glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvancesForDirection(this HarfBuzz thisApi, FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, int* first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvancesForDirection(font, direction, count, in first_glyph.GetPinnableReference(), glyph_stride, first_advance, advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1044, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphAdvancesForDirection(this HarfBuzz thisApi, FontT* font, DirectionT direction, uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> first_glyph, uint glyph_stride, Span<int> first_advance, uint advance_stride)
        {
            // SpanOverloader
            thisApi.FontGetGlyphAdvancesForDirection(font, direction, count, in first_glyph.GetPinnableReference(), glyph_stride, ref first_advance.GetPinnableReference(), advance_stride);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphOriginForDirection(font, glyph, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1052, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        public static unsafe void FontAddGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontAddGlyphOriginForDirection(font, glyph, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        public static unsafe void FontAddGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.FontAddGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1057, Column 1 in hb-font.h")]
        public static unsafe void FontAddGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontAddGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        public static unsafe void FontSubtractGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontSubtractGlyphOriginForDirection(font, glyph, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        public static unsafe void FontSubtractGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.FontSubtractGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1062, Column 1 in hb-font.h")]
        public static unsafe void FontSubtractGlyphOriginForDirection(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontSubtractGlyphOriginForDirection(font, glyph, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphKerningForDirection(this HarfBuzz thisApi, FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphKerningForDirection(font, first_glyph, second_glyph, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphKerningForDirection(this HarfBuzz thisApi, FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphKerningForDirection(font, first_glyph, second_glyph, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1068, Column 1 in hb-font.h")]
        public static unsafe void FontGetGlyphKerningForDirection(this HarfBuzz thisApi, FontT* font, uint first_glyph, uint second_glyph, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            thisApi.FontGetGlyphKerningForDirection(font, first_glyph, second_glyph, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1074, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphExtentsForOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, DirectionT direction, Span<GlyphExtentsT> extents)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphExtentsForOrigin(font, glyph, direction, ref extents.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPointForOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, DirectionT direction, int* x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPointForOrigin(font, glyph, point_index, direction, x, ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPointForOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, DirectionT direction, Span<int> x, int* y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPointForOrigin(font, glyph, point_index, direction, ref x.GetPinnableReference(), y);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1080, Column 1 in hb-font.h")]
        public static unsafe int FontGetGlyphContourPointForOrigin(this HarfBuzz thisApi, FontT* font, uint glyph, uint point_index, DirectionT direction, Span<int> x, Span<int> y)
        {
            // SpanOverloader
            return thisApi.FontGetGlyphContourPointForOrigin(font, glyph, point_index, direction, ref x.GetPinnableReference(), ref y.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1087, Column 1 in hb-font.h")]
        public static unsafe void FontGlyphToString(this HarfBuzz thisApi, FontT* font, uint glyph, Span<byte> s, uint size)
        {
            // SpanOverloader
            thisApi.FontGlyphToString(font, glyph, ref s.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        public static unsafe int FontGlyphFromString(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* s, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGlyphFromString(font, s, len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        public static unsafe int FontGlyphFromString(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s, int len, uint* glyph)
        {
            // SpanOverloader
            return thisApi.FontGlyphFromString(font, in s.GetPinnableReference(), len, glyph);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        public static unsafe int FontGlyphFromString(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> s, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGlyphFromString(font, in s.GetPinnableReference(), len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1092, Column 1 in hb-font.h")]
        public static unsafe int FontGlyphFromString(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string s, int len, Span<uint> glyph)
        {
            // SpanOverloader
            return thisApi.FontGlyphFromString(font, s, len, ref glyph.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1098, Column 1 in hb-font.h")]
        public static unsafe void FontDrawGlyph<T0>(this HarfBuzz thisApi, FontT* font, uint glyph, DrawFuncsT* dfuncs, Span<T0> draw_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontDrawGlyph(font, glyph, dfuncs, ref draw_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 1 in hb-font.h")]
        public static unsafe void FontPaintGlyph<T0>(this HarfBuzz thisApi, FontT* font, uint glyph, PaintFuncsT* pfuncs, Span<T0> paint_data, uint palette_index, uint foreground) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontPaintGlyph(font, glyph, pfuncs, ref paint_data.GetPinnableReference(), palette_index, foreground);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        public static unsafe int FontSetUserData<T0>(this HarfBuzz thisApi, FontT* font, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontSetUserData(font, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        public static unsafe int FontSetUserData(this HarfBuzz thisApi, FontT* font, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.FontSetUserData(font, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 1 in hb-font.h")]
        public static unsafe int FontSetUserData<T0>(this HarfBuzz thisApi, FontT* font, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.FontSetUserData(font, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1140, Column 1 in hb-font.h")]
        public static unsafe void* FontGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontT* font, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.FontGetUserData(font, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1171, Column 1 in hb-font.h")]
        public static unsafe void FontSetFuncs<T0>(this HarfBuzz thisApi, FontT* font, FontFuncsT* klass, Span<T0> font_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontSetFuncs(font, klass, ref font_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1178, Column 1 in hb-font.h")]
        public static unsafe void FontSetFuncsData<T0>(this HarfBuzz thisApi, FontT* font, Span<T0> font_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontSetFuncsData(font, ref font_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1183, Column 1 in hb-font.h")]
        public static unsafe int FontSetFuncsUsing(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.FontSetFuncsUsing(font, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        public static unsafe void FontGetScale(this HarfBuzz thisApi, FontT* font, int* x_scale, Span<int> y_scale)
        {
            // SpanOverloader
            thisApi.FontGetScale(font, x_scale, ref y_scale.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        public static unsafe void FontGetScale(this HarfBuzz thisApi, FontT* font, Span<int> x_scale, int* y_scale)
        {
            // SpanOverloader
            thisApi.FontGetScale(font, ref x_scale.GetPinnableReference(), y_scale);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1195, Column 1 in hb-font.h")]
        public static unsafe void FontGetScale(this HarfBuzz thisApi, FontT* font, Span<int> x_scale, Span<int> y_scale)
        {
            // SpanOverloader
            thisApi.FontGetScale(font, ref x_scale.GetPinnableReference(), ref y_scale.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        public static unsafe void FontGetPpem(this HarfBuzz thisApi, FontT* font, uint* x_ppem, Span<uint> y_ppem)
        {
            // SpanOverloader
            thisApi.FontGetPpem(font, x_ppem, ref y_ppem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        public static unsafe void FontGetPpem(this HarfBuzz thisApi, FontT* font, Span<uint> x_ppem, uint* y_ppem)
        {
            // SpanOverloader
            thisApi.FontGetPpem(font, ref x_ppem.GetPinnableReference(), y_ppem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1208, Column 1 in hb-font.h")]
        public static unsafe void FontGetPpem(this HarfBuzz thisApi, FontT* font, Span<uint> x_ppem, Span<uint> y_ppem)
        {
            // SpanOverloader
            thisApi.FontGetPpem(font, ref x_ppem.GetPinnableReference(), ref y_ppem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, float* x_embolden, float* y_embolden, Span<int> in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, x_embolden, y_embolden, ref in_place.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, float* x_embolden, Span<float> y_embolden, int* in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, x_embolden, ref y_embolden.GetPinnableReference(), in_place);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, float* x_embolden, Span<float> y_embolden, Span<int> in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, x_embolden, ref y_embolden.GetPinnableReference(), ref in_place.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, Span<float> x_embolden, float* y_embolden, int* in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, ref x_embolden.GetPinnableReference(), y_embolden, in_place);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, Span<float> x_embolden, float* y_embolden, Span<int> in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, ref x_embolden.GetPinnableReference(), y_embolden, ref in_place.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, Span<float> x_embolden, Span<float> y_embolden, int* in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, ref x_embolden.GetPinnableReference(), ref y_embolden.GetPinnableReference(), in_place);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1231, Column 1 in hb-font.h")]
        public static unsafe void FontGetSyntheticBold(this HarfBuzz thisApi, FontT* font, Span<float> x_embolden, Span<float> y_embolden, Span<int> in_place)
        {
            // SpanOverloader
            thisApi.FontGetSyntheticBold(font, ref x_embolden.GetPinnableReference(), ref y_embolden.GetPinnableReference(), ref in_place.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1242, Column 1 in hb-font.h")]
        public static unsafe void FontSetVariations(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VariationT> variations, uint variations_length)
        {
            // SpanOverloader
            thisApi.FontSetVariations(font, in variations.GetPinnableReference(), variations_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1252, Column 1 in hb-font.h")]
        public static unsafe void FontSetVarCoordsDesign(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords, uint coords_length)
        {
            // SpanOverloader
            thisApi.FontSetVarCoordsDesign(font, in coords.GetPinnableReference(), coords_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1257, Column 1 in hb-font.h")]
        public static unsafe float* FontGetVarCoordsDesign(this HarfBuzz thisApi, FontT* font, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.FontGetVarCoordsDesign(font, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1261, Column 1 in hb-font.h")]
        public static unsafe void FontSetVarCoordsNormalized(this HarfBuzz thisApi, FontT* font, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint coords_length)
        {
            // SpanOverloader
            thisApi.FontSetVarCoordsNormalized(font, in coords.GetPinnableReference(), coords_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1266, Column 1 in hb-font.h")]
        public static unsafe int* FontGetVarCoordsNormalized(this HarfBuzz thisApi, FontT* font, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.FontGetVarCoordsNormalized(font, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 169, Column 1 in hb-buffer.h")]
        public static unsafe GlyphFlagsT GlyphInfoGetGlyphFlags(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphInfoT> info)
        {
            // SpanOverloader
            return thisApi.GlyphInfoGetGlyphFlags(in info.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        public static unsafe int SegmentPropertiesEqual(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> b)
        {
            // SpanOverloader
            return thisApi.SegmentPropertiesEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        public static unsafe int SegmentPropertiesEqual(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* b)
        {
            // SpanOverloader
            return thisApi.SegmentPropertiesEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 1 in hb-buffer.h")]
        public static unsafe int SegmentPropertiesEqual(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> b)
        {
            // SpanOverloader
            return thisApi.SegmentPropertiesEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 1 in hb-buffer.h")]
        public static unsafe uint SegmentPropertiesHash(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> p)
        {
            // SpanOverloader
            return thisApi.SegmentPropertiesHash(in p.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        public static unsafe void SegmentPropertiesOverlay(this HarfBuzz thisApi, SegmentPropertiesT* p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> src)
        {
            // SpanOverloader
            thisApi.SegmentPropertiesOverlay(p, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        public static unsafe void SegmentPropertiesOverlay(this HarfBuzz thisApi, Span<SegmentPropertiesT> p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* src)
        {
            // SpanOverloader
            thisApi.SegmentPropertiesOverlay(ref p.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 1 in hb-buffer.h")]
        public static unsafe void SegmentPropertiesOverlay(this HarfBuzz thisApi, Span<SegmentPropertiesT> p, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> src)
        {
            // SpanOverloader
            thisApi.SegmentPropertiesOverlay(ref p.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        public static unsafe int BufferSetUserData<T0>(this HarfBuzz thisApi, BufferT* buffer, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BufferSetUserData(buffer, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        public static unsafe int BufferSetUserData(this HarfBuzz thisApi, BufferT* buffer, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.BufferSetUserData(buffer, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 272, Column 1 in hb-buffer.h")]
        public static unsafe int BufferSetUserData<T0>(this HarfBuzz thisApi, BufferT* buffer, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.BufferSetUserData(buffer, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 279, Column 1 in hb-buffer.h")]
        public static unsafe void* BufferGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.BufferGetUserData(buffer, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-buffer.h")]
        public static unsafe void BufferSetSegmentProperties(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props)
        {
            // SpanOverloader
            thisApi.BufferSetSegmentProperties(buffer, in props.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 339, Column 1 in hb-buffer.h")]
        public static unsafe void BufferGetSegmentProperties(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferT* buffer, Span<SegmentPropertiesT> props)
        {
            // SpanOverloader
            thisApi.BufferGetSegmentProperties(buffer, ref props.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 597, Column 1 in hb-buffer.h")]
        public static unsafe void BufferAddUtf8(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, int text_length, uint item_offset, int item_length)
        {
            // SpanOverloader
            thisApi.BufferAddUtf8(buffer, in text.GetPinnableReference(), text_length, item_offset, item_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 604, Column 1 in hb-buffer.h")]
        public static unsafe void BufferAddUtf16(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> text, int text_length, uint item_offset, int item_length)
        {
            // SpanOverloader
            thisApi.BufferAddUtf16(buffer, in text.GetPinnableReference(), text_length, item_offset, item_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 1 in hb-buffer.h")]
        public static unsafe void BufferAddUtf32(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> text, int text_length, uint item_offset, int item_length)
        {
            // SpanOverloader
            thisApi.BufferAddUtf32(buffer, in text.GetPinnableReference(), text_length, item_offset, item_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 1 in hb-buffer.h")]
        public static unsafe void BufferAddLatin1(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> text, int text_length, uint item_offset, int item_length)
        {
            // SpanOverloader
            thisApi.BufferAddLatin1(buffer, in text.GetPinnableReference(), text_length, item_offset, item_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 625, Column 1 in hb-buffer.h")]
        public static unsafe void BufferAddCodepoints(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> text, int text_length, uint item_offset, int item_length)
        {
            // SpanOverloader
            thisApi.BufferAddCodepoints(buffer, in text.GetPinnableReference(), text_length, item_offset, item_length);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 1 in hb-buffer.h")]
        public static unsafe GlyphInfoT* BufferGetGlyphInfos(this HarfBuzz thisApi, BufferT* buffer, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.BufferGetGlyphInfos(buffer, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 651, Column 1 in hb-buffer.h")]
        public static unsafe GlyphPositionT* BufferGetGlyphPositions(this HarfBuzz thisApi, BufferT* buffer, Span<uint> length)
        {
            // SpanOverloader
            return thisApi.BufferGetGlyphPositions(buffer, ref length.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 712, Column 1 in hb-buffer.h")]
        public static unsafe BufferSerializeFormatT BufferSerializeFormatFromString(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> str, int len)
        {
            // SpanOverloader
            return thisApi.BufferSerializeFormatFromString(in str.GetPinnableReference(), len);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeGlyphs(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeGlyphs(buffer, start, end, ref buf.GetPinnableReference(), buf_size, buf_consumed, font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeGlyphs(buffer, start, end, ref buf.GetPinnableReference(), buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 721, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeGlyphs(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeUnicode(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, Span<uint> buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeUnicode(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeUnicode(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, uint* buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeUnicode(buffer, start, end, ref buf.GetPinnableReference(), buf_size, buf_consumed, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeUnicode(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, Span<uint> buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeUnicode(buffer, start, end, ref buf.GetPinnableReference(), buf_size, ref buf_consumed.GetPinnableReference(), format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 732, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerializeUnicode(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, Span<uint> buf_consumed, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerializeUnicode(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerialize(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, byte* buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerialize(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerialize(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, uint* buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerialize(buffer, start, end, ref buf.GetPinnableReference(), buf_size, buf_consumed, font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerialize(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, Span<byte> buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerialize(buffer, start, end, ref buf.GetPinnableReference(), buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 1 in hb-buffer.h")]
        public static unsafe uint BufferSerialize(this HarfBuzz thisApi, BufferT* buffer, uint start, uint end, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buf, uint buf_size, Span<uint> buf_consumed, FontT* font, BufferSerializeFormatT format, BufferSerializeFlagsT flags)
        {
            // SpanOverloader
            return thisApi.BufferSerialize(buffer, start, end, buf, buf_size, ref buf_consumed.GetPinnableReference(), font, format, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        public static unsafe int BufferDeserializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, FontT* font, BufferSerializeFormatT format)
        {
            // SpanOverloader
            return thisApi.BufferDeserializeGlyphs(buffer, in buf.GetPinnableReference(), buf_len, end_ptr, font, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 753, Column 1 in hb-buffer.h")]
        public static unsafe int BufferDeserializeGlyphs(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, FontT* font, BufferSerializeFormatT format)
        {
            // SpanOverloader
            return thisApi.BufferDeserializeGlyphs(buffer, in buf.GetPinnableReference(), buf_len, in end_ptr, font, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        public static unsafe int BufferDeserializeUnicode(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** end_ptr, BufferSerializeFormatT format)
        {
            // SpanOverloader
            return thisApi.BufferDeserializeUnicode(buffer, in buf.GetPinnableReference(), buf_len, end_ptr, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 761, Column 1 in hb-buffer.h")]
        public static unsafe int BufferDeserializeUnicode(this HarfBuzz thisApi, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> buf, int buf_len, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* end_ptr, BufferSerializeFormatT format)
        {
            // SpanOverloader
            return thisApi.BufferDeserializeUnicode(buffer, in buf.GetPinnableReference(), buf_len, in end_ptr, format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 1 in hb-buffer.h")]
        public static unsafe void BufferSetMessageFunc<T0>(this HarfBuzz thisApi, BufferT* buffer, PfnBufferMessageFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.BufferSetMessageFunc(buffer, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 1 in hb-deprecated.h")]
        public static unsafe void FontFuncsSetGlyphFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetVariationGlyphFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 1 in hb-deprecated.h")]
        public static unsafe void UnicodeFuncsSetEastasianWidthFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeMirroringFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetEastasianWidthFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 216, Column 1 in hb-deprecated.h")]
        public static unsafe void UnicodeFuncsSetDecomposeCompatibilityFunc<T0>(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, PfnUnicodeDecomposeCompatibilityFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.UnicodeFuncsSetDecomposeCompatibilityFunc(ufuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 221, Column 1 in hb-deprecated.h")]
        public static unsafe uint UnicodeDecomposeCompatibility(this HarfBuzz thisApi, UnicodeFuncsT* ufuncs, uint u, Span<uint> decomposed)
        {
            // SpanOverloader
            return thisApi.UnicodeDecomposeCompatibility(ufuncs, u, ref decomposed.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 250, Column 1 in hb-deprecated.h")]
        public static unsafe void FontFuncsSetGlyphVKerningFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphKerningFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphVKerningFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 335, Column 1 in hb-deprecated.h")]
        public static unsafe void FontFuncsSetGlyphShapeFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetGlyphShapeFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 1 in hb-deprecated.h")]
        public static unsafe void FontFuncsSetDrawGlyphFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontGetGlyphShapeFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetDrawGlyphFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 371, Column 1 in hb-deprecated.h")]
        public static unsafe void FontFuncsSetPaintGlyphFunc<T0>(this HarfBuzz thisApi, FontFuncsT* ffuncs, PfnFontPaintGlyphOrFailFuncT func, Span<T0> user_data, PfnDestroyFuncT destroy) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontFuncsSetPaintGlyphFunc(ffuncs, func, ref user_data.GetPinnableReference(), destroy);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 377, Column 1 in hb-deprecated.h")]
        public static unsafe void FontGetGlyphShape<T0>(this HarfBuzz thisApi, FontT* font, uint glyph, DrawFuncsT* dfuncs, Span<T0> draw_data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FontGetGlyphShape(font, glyph, dfuncs, ref draw_data.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 44, Column 1 in hb-shape.h")]
        public static unsafe void Shape(this HarfBuzz thisApi, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> features, uint num_features)
        {
            // SpanOverloader
            thisApi.Shape(font, buffer, in features.GetPinnableReference(), num_features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        public static unsafe int ShapeFull(this HarfBuzz thisApi, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapeFull(font, buffer, in features.GetPinnableReference(), num_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 1 in hb-shape.h")]
        public static unsafe int ShapeFull(this HarfBuzz thisApi, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> features, uint num_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapeFull(font, buffer, in features.GetPinnableReference(), num_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, props, in user_features.GetPinnableReference(), num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, props, in user_features.GetPinnableReference(), num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, in props.GetPinnableReference(), user_features, num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, in props.GetPinnableReference(), user_features, num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 56, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, props, in user_features.GetPinnableReference(), num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, props, in user_features.GetPinnableReference(), num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, in props.GetPinnableReference(), user_features, num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, in props.GetPinnableReference(), user_features, num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, user_features, num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, user_features, num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, in user_features.GetPinnableReference(), num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, in user_features.GetPinnableReference(), num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, props, in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), user_features, num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), user_features, num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), user_features, num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), user_features, num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreate2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreate2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, user_features, num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, user_features, num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, in user_features.GetPinnableReference(), num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, in user_features.GetPinnableReference(), num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SegmentPropertiesT* props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, props, in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), user_features, num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), user_features, num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), user_features, num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FeatureT* user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), user_features, num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, coords, num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, coords, num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 79, Column 1 in hb-shape-plan.h")]
        public static unsafe ShapePlanT* ShapePlanCreateCached2(this HarfBuzz thisApi, FaceT* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SegmentPropertiesT> props, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> user_features, uint num_user_features, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords, uint num_coords, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* shaper_list)
        {
            // SpanOverloader
            return thisApi.ShapePlanCreateCached2(face, in props.GetPinnableReference(), in user_features.GetPinnableReference(), num_user_features, in coords.GetPinnableReference(), num_coords, in shaper_list);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        public static unsafe int ShapePlanSetUserData<T0>(this HarfBuzz thisApi, ShapePlanT* shape_plan, UserDataKeyT* key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ShapePlanSetUserData(shape_plan, key, ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        public static unsafe int ShapePlanSetUserData(this HarfBuzz thisApi, ShapePlanT* shape_plan, Span<UserDataKeyT> key, void* data, PfnDestroyFuncT destroy, int replace)
        {
            // SpanOverloader
            return thisApi.ShapePlanSetUserData(shape_plan, ref key.GetPinnableReference(), data, destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 98, Column 1 in hb-shape-plan.h")]
        public static unsafe int ShapePlanSetUserData<T0>(this HarfBuzz thisApi, ShapePlanT* shape_plan, Span<UserDataKeyT> key, Span<T0> data, PfnDestroyFuncT destroy, int replace) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.ShapePlanSetUserData(shape_plan, ref key.GetPinnableReference(), ref data.GetPinnableReference(), destroy, replace);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 1 in hb-shape-plan.h")]
        public static unsafe void* ShapePlanGetUserData(this HarfBuzz thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ShapePlanT* shape_plan, Span<UserDataKeyT> key)
        {
            // SpanOverloader
            return thisApi.ShapePlanGetUserData(shape_plan, ref key.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 110, Column 1 in hb-shape-plan.h")]
        public static unsafe int ShapePlanExecute(this HarfBuzz thisApi, ShapePlanT* shape_plan, FontT* font, BufferT* buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FeatureT> features, uint num_features)
        {
            // SpanOverloader
            return thisApi.ShapePlanExecute(shape_plan, font, buffer, in features.GetPinnableReference(), num_features);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, uint* major, uint* minor, Span<uint> micro)
        {
            // SpanOverloader
            thisApi.Version(major, minor, ref micro.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, uint* major, Span<uint> minor, uint* micro)
        {
            // SpanOverloader
            thisApi.Version(major, ref minor.GetPinnableReference(), micro);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, uint* major, Span<uint> minor, Span<uint> micro)
        {
            // SpanOverloader
            thisApi.Version(major, ref minor.GetPinnableReference(), ref micro.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, Span<uint> major, uint* minor, uint* micro)
        {
            // SpanOverloader
            thisApi.Version(ref major.GetPinnableReference(), minor, micro);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, Span<uint> major, uint* minor, Span<uint> micro)
        {
            // SpanOverloader
            thisApi.Version(ref major.GetPinnableReference(), minor, ref micro.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, Span<uint> major, Span<uint> minor, uint* micro)
        {
            // SpanOverloader
            thisApi.Version(ref major.GetPinnableReference(), ref minor.GetPinnableReference(), micro);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 80, Column 1 in hb-version.h")]
        public static unsafe void Version(this HarfBuzz thisApi, Span<uint> major, Span<uint> minor, Span<uint> micro)
        {
            // SpanOverloader
            thisApi.Version(ref major.GetPinnableReference(), ref minor.GetPinnableReference(), ref micro.GetPinnableReference());
        }

    }
}

