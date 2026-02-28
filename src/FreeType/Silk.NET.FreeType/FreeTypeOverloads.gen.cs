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
    public static class FreeTypeOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        public static unsafe int NewFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filepathname, long face_index, FaceRec** aface)
        {
            // SpanOverloader
            return thisApi.NewFace(library, in filepathname.GetPinnableReference(), face_index, aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2574, Column 3 in freetype.h")]
        public static unsafe int NewFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filepathname, long face_index, ref FaceRec* aface)
        {
            // SpanOverloader
            return thisApi.NewFace(library, in filepathname.GetPinnableReference(), face_index, ref aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        public static unsafe int NewMemoryFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_base, long file_size, long face_index, FaceRec** aface)
        {
            // SpanOverloader
            return thisApi.NewMemoryFace(library, in file_base.GetPinnableReference(), file_size, face_index, aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2614, Column 3 in freetype.h")]
        public static unsafe int NewMemoryFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file_base, long file_size, long face_index, ref FaceRec* aface)
        {
            // SpanOverloader
            return thisApi.NewMemoryFace(library, in file_base.GetPinnableReference(), file_size, face_index, ref aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        public static unsafe int OpenFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpenArgs> args, long face_index, FaceRec** aface)
        {
            // SpanOverloader
            return thisApi.OpenFace(library, in args.GetPinnableReference(), face_index, aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2763, Column 3 in freetype.h")]
        public static unsafe int OpenFace(this FreeType thisApi, LibraryRec* library, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpenArgs> args, long face_index, ref FaceRec* aface)
        {
            // SpanOverloader
            return thisApi.OpenFace(library, in args.GetPinnableReference(), face_index, ref aface);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        public static unsafe int AttachFile(this FreeType thisApi, FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filepathname)
        {
            // SpanOverloader
            return thisApi.AttachFile(face, in filepathname.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        public static unsafe int AttachFile(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filepathname)
        {
            // SpanOverloader
            return thisApi.AttachFile(ref face.GetPinnableReference(), filepathname);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        public static unsafe int AttachFile(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filepathname)
        {
            // SpanOverloader
            return thisApi.AttachFile(ref face.GetPinnableReference(), in filepathname.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2789, Column 3 in freetype.h")]
        public static unsafe int AttachFile(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filepathname)
        {
            // SpanOverloader
            return thisApi.AttachFile(ref face.GetPinnableReference(), filepathname);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        public static unsafe int AttachStream(this FreeType thisApi, FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpenArgs> parameters)
        {
            // SpanOverloader
            return thisApi.AttachStream(face, in parameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        public static unsafe int AttachStream(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OpenArgs* parameters)
        {
            // SpanOverloader
            return thisApi.AttachStream(ref face.GetPinnableReference(), parameters);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2825, Column 3 in freetype.h")]
        public static unsafe int AttachStream(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<OpenArgs> parameters)
        {
            // SpanOverloader
            return thisApi.AttachStream(ref face.GetPinnableReference(), in parameters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2855, Column 3 in freetype.h")]
        public static unsafe int ReferenceFace(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.ReferenceFace(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2879, Column 3 in freetype.h")]
        public static unsafe int DoneFace(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.DoneFace(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 2926, Column 3 in freetype.h")]
        public static unsafe int SelectSize(this FreeType thisApi, Span<FaceRec> face, int strike_index)
        {
            // SpanOverloader
            return thisApi.SelectSize(ref face.GetPinnableReference(), strike_index);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        public static unsafe int RequestSize(this FreeType thisApi, FaceRec* face, Span<SizeRequestRec> req)
        {
            // SpanOverloader
            return thisApi.RequestSize(face, ref req.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        public static unsafe int RequestSize(this FreeType thisApi, Span<FaceRec> face, SizeRequestRec* req)
        {
            // SpanOverloader
            return thisApi.RequestSize(ref face.GetPinnableReference(), req);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3090, Column 3 in freetype.h")]
        public static unsafe int RequestSize(this FreeType thisApi, Span<FaceRec> face, Span<SizeRequestRec> req)
        {
            // SpanOverloader
            return thisApi.RequestSize(ref face.GetPinnableReference(), ref req.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3139, Column 3 in freetype.h")]
        public static unsafe int SetCharSize(this FreeType thisApi, Span<FaceRec> face, long char_width, long char_height, uint horz_resolution, uint vert_resolution)
        {
            // SpanOverloader
            return thisApi.SetCharSize(ref face.GetPinnableReference(), char_width, char_height, horz_resolution, vert_resolution);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3176, Column 3 in freetype.h")]
        public static unsafe int SetPixelSizes(this FreeType thisApi, Span<FaceRec> face, uint pixel_width, uint pixel_height)
        {
            // SpanOverloader
            return thisApi.SetPixelSizes(ref face.GetPinnableReference(), pixel_width, pixel_height);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3231, Column 3 in freetype.h")]
        public static unsafe int LoadGlyph(this FreeType thisApi, Span<FaceRec> face, uint glyph_index, int load_flags)
        {
            // SpanOverloader
            return thisApi.LoadGlyph(ref face.GetPinnableReference(), glyph_index, load_flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3281, Column 3 in freetype.h")]
        public static unsafe int LoadChar(this FreeType thisApi, Span<FaceRec> face, ulong char_code, int load_flags)
        {
            // SpanOverloader
            return thisApi.LoadChar(ref face.GetPinnableReference(), char_code, load_flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, FaceRec* face, Matrix* matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.SetTransform(face, matrix, ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, FaceRec* face, Span<Matrix> matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.SetTransform(face, ref matrix.GetPinnableReference(), delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, FaceRec* face, Span<Matrix> matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.SetTransform(face, ref matrix.GetPinnableReference(), ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, Span<FaceRec> face, Matrix* matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.SetTransform(ref face.GetPinnableReference(), matrix, delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, Span<FaceRec> face, Matrix* matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.SetTransform(ref face.GetPinnableReference(), matrix, ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, Span<FaceRec> face, Span<Matrix> matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.SetTransform(ref face.GetPinnableReference(), ref matrix.GetPinnableReference(), delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3683, Column 3 in freetype.h")]
        public static unsafe void SetTransform(this FreeType thisApi, Span<FaceRec> face, Span<Matrix> matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.SetTransform(ref face.GetPinnableReference(), ref matrix.GetPinnableReference(), ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, FaceRec* face, Matrix* matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.GetTransform(face, matrix, ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, FaceRec* face, Span<Matrix> matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.GetTransform(face, ref matrix.GetPinnableReference(), delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, FaceRec* face, Span<Matrix> matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.GetTransform(face, ref matrix.GetPinnableReference(), ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, Span<FaceRec> face, Matrix* matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.GetTransform(ref face.GetPinnableReference(), matrix, delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, Span<FaceRec> face, Matrix* matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.GetTransform(ref face.GetPinnableReference(), matrix, ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, Span<FaceRec> face, Span<Matrix> matrix, Vector* delta)
        {
            // SpanOverloader
            thisApi.GetTransform(ref face.GetPinnableReference(), ref matrix.GetPinnableReference(), delta);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3716, Column 3 in freetype.h")]
        public static unsafe void GetTransform(this FreeType thisApi, Span<FaceRec> face, Span<Matrix> matrix, Span<Vector> delta)
        {
            // SpanOverloader
            thisApi.GetTransform(ref face.GetPinnableReference(), ref matrix.GetPinnableReference(), ref delta.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 3915, Column 3 in freetype.h")]
        public static unsafe int RenderGlyph(this FreeType thisApi, Span<GlyphSlotRec> slot, RenderMode render_mode)
        {
            // SpanOverloader
            return thisApi.RenderGlyph(ref slot.GetPinnableReference(), render_mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        public static unsafe int GetKerning(this FreeType thisApi, FaceRec* face, uint left_glyph, uint right_glyph, uint kern_mode, Span<Vector> akerning)
        {
            // SpanOverloader
            return thisApi.GetKerning(face, left_glyph, right_glyph, kern_mode, ref akerning.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        public static unsafe int GetKerning(this FreeType thisApi, Span<FaceRec> face, uint left_glyph, uint right_glyph, uint kern_mode, Vector* akerning)
        {
            // SpanOverloader
            return thisApi.GetKerning(ref face.GetPinnableReference(), left_glyph, right_glyph, kern_mode, akerning);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4022, Column 3 in freetype.h")]
        public static unsafe int GetKerning(this FreeType thisApi, Span<FaceRec> face, uint left_glyph, uint right_glyph, uint kern_mode, Span<Vector> akerning)
        {
            // SpanOverloader
            return thisApi.GetKerning(ref face.GetPinnableReference(), left_glyph, right_glyph, kern_mode, ref akerning.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        public static unsafe int GetTrackKerning(this FreeType thisApi, FaceRec* face, long point_size, int degree, Span<long> akerning)
        {
            // SpanOverloader
            return thisApi.GetTrackKerning(face, point_size, degree, ref akerning.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        public static unsafe int GetTrackKerning(this FreeType thisApi, Span<FaceRec> face, long point_size, int degree, long* akerning)
        {
            // SpanOverloader
            return thisApi.GetTrackKerning(ref face.GetPinnableReference(), point_size, degree, akerning);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4066, Column 3 in freetype.h")]
        public static unsafe int GetTrackKerning(this FreeType thisApi, Span<FaceRec> face, long point_size, int degree, Span<long> akerning)
        {
            // SpanOverloader
            return thisApi.GetTrackKerning(ref face.GetPinnableReference(), point_size, degree, ref akerning.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4110, Column 3 in freetype.h")]
        public static unsafe int SelectCharmap(this FreeType thisApi, Span<FaceRec> face, Encoding encoding)
        {
            // SpanOverloader
            return thisApi.SelectCharmap(ref face.GetPinnableReference(), encoding);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        public static unsafe int SetCharmap(this FreeType thisApi, FaceRec* face, Span<CharMapRec> charmap)
        {
            // SpanOverloader
            return thisApi.SetCharmap(face, ref charmap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        public static unsafe int SetCharmap(this FreeType thisApi, Span<FaceRec> face, CharMapRec* charmap)
        {
            // SpanOverloader
            return thisApi.SetCharmap(ref face.GetPinnableReference(), charmap);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4141, Column 3 in freetype.h")]
        public static unsafe int SetCharmap(this FreeType thisApi, Span<FaceRec> face, Span<CharMapRec> charmap)
        {
            // SpanOverloader
            return thisApi.SetCharmap(ref face.GetPinnableReference(), ref charmap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4163, Column 3 in freetype.h")]
        public static unsafe int GetCharmapIndex(this FreeType thisApi, Span<CharMapRec> charmap)
        {
            // SpanOverloader
            return thisApi.GetCharmapIndex(ref charmap.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4198, Column 3 in freetype.h")]
        public static unsafe uint GetCharIndex(this FreeType thisApi, Span<FaceRec> face, ulong charcode)
        {
            // SpanOverloader
            return thisApi.GetCharIndex(ref face.GetPinnableReference(), charcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        public static unsafe ulong GetFirstChar(this FreeType thisApi, FaceRec* face, Span<uint> agindex)
        {
            // SpanOverloader
            return thisApi.GetFirstChar(face, ref agindex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        public static unsafe ulong GetFirstChar(this FreeType thisApi, Span<FaceRec> face, uint* agindex)
        {
            // SpanOverloader
            return thisApi.GetFirstChar(ref face.GetPinnableReference(), agindex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4253, Column 3 in freetype.h")]
        public static unsafe ulong GetFirstChar(this FreeType thisApi, Span<FaceRec> face, Span<uint> agindex)
        {
            // SpanOverloader
            return thisApi.GetFirstChar(ref face.GetPinnableReference(), ref agindex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        public static unsafe ulong GetNextChar(this FreeType thisApi, FaceRec* face, ulong char_code, Span<uint> agindex)
        {
            // SpanOverloader
            return thisApi.GetNextChar(face, char_code, ref agindex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        public static unsafe ulong GetNextChar(this FreeType thisApi, Span<FaceRec> face, ulong char_code, uint* agindex)
        {
            // SpanOverloader
            return thisApi.GetNextChar(ref face.GetPinnableReference(), char_code, agindex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4290, Column 3 in freetype.h")]
        public static unsafe ulong GetNextChar(this FreeType thisApi, Span<FaceRec> face, ulong char_code, Span<uint> agindex)
        {
            // SpanOverloader
            return thisApi.GetNextChar(ref face.GetPinnableReference(), char_code, ref agindex.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        public static unsafe int FaceProperties(this FreeType thisApi, FaceRec* face, uint num_properties, Span<Parameter> properties)
        {
            // SpanOverloader
            return thisApi.FaceProperties(face, num_properties, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        public static unsafe int FaceProperties(this FreeType thisApi, Span<FaceRec> face, uint num_properties, Parameter* properties)
        {
            // SpanOverloader
            return thisApi.FaceProperties(ref face.GetPinnableReference(), num_properties, properties);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4395, Column 3 in freetype.h")]
        public static unsafe int FaceProperties(this FreeType thisApi, Span<FaceRec> face, uint num_properties, Span<Parameter> properties)
        {
            // SpanOverloader
            return thisApi.FaceProperties(ref face.GetPinnableReference(), num_properties, ref properties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        public static unsafe uint GetNameIndex(this FreeType thisApi, FaceRec* face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> glyph_name)
        {
            // SpanOverloader
            return thisApi.GetNameIndex(face, in glyph_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        public static unsafe uint GetNameIndex(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* glyph_name)
        {
            // SpanOverloader
            return thisApi.GetNameIndex(ref face.GetPinnableReference(), glyph_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        public static unsafe uint GetNameIndex(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> glyph_name)
        {
            // SpanOverloader
            return thisApi.GetNameIndex(ref face.GetPinnableReference(), in glyph_name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4437, Column 3 in freetype.h")]
        public static unsafe uint GetNameIndex(this FreeType thisApi, Span<FaceRec> face, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string glyph_name)
        {
            // SpanOverloader
            return thisApi.GetNameIndex(ref face.GetPinnableReference(), glyph_name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        public static unsafe int GetGlyphName<T0>(this FreeType thisApi, FaceRec* face, uint glyph_index, Span<T0> buffer, uint buffer_max) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlyphName(face, glyph_index, ref buffer.GetPinnableReference(), buffer_max);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        public static unsafe int GetGlyphName(this FreeType thisApi, Span<FaceRec> face, uint glyph_index, void* buffer, uint buffer_max)
        {
            // SpanOverloader
            return thisApi.GetGlyphName(ref face.GetPinnableReference(), glyph_index, buffer, buffer_max);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4484, Column 3 in freetype.h")]
        public static unsafe int GetGlyphName<T0>(this FreeType thisApi, Span<FaceRec> face, uint glyph_index, Span<T0> buffer, uint buffer_max) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGlyphName(ref face.GetPinnableReference(), glyph_index, ref buffer.GetPinnableReference(), buffer_max);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4524, Column 3 in freetype.h")]
        public static unsafe byte* GetPostscriptName(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.GetPostscriptName(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, GlyphSlotRec* glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(glyph, sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, int* p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, p_index, ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, uint* p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), p_flags, ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, int* p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), p_arg1, ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, int* p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), p_arg2, ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Matrix* p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), p_transform);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4604, Column 3 in freetype.h")]
        public static unsafe int GetSubGlyphInfo(this FreeType thisApi, Span<GlyphSlotRec> glyph, uint sub_index, Span<int> p_index, Span<uint> p_flags, Span<int> p_arg1, Span<int> p_arg2, Span<Matrix> p_transform)
        {
            // SpanOverloader
            return thisApi.GetSubGlyphInfo(ref glyph.GetPinnableReference(), sub_index, ref p_index.GetPinnableReference(), ref p_flags.GetPinnableReference(), ref p_arg1.GetPinnableReference(), ref p_arg2.GetPinnableReference(), ref p_transform.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4699, Column 3 in freetype.h")]
        public static unsafe ushort GetFSTypeFlags(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.GetFSTypeFlags(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4793, Column 3 in freetype.h")]
        public static unsafe uint FaceGetCharVariantIndex(this FreeType thisApi, Span<FaceRec> face, ulong charcode, ulong variantSelector)
        {
            // SpanOverloader
            return thisApi.FaceGetCharVariantIndex(ref face.GetPinnableReference(), charcode, variantSelector);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4830, Column 3 in freetype.h")]
        public static unsafe int FaceGetCharVariantIsDefault(this FreeType thisApi, Span<FaceRec> face, ulong charcode, ulong variantSelector)
        {
            // SpanOverloader
            return thisApi.FaceGetCharVariantIsDefault(ref face.GetPinnableReference(), charcode, variantSelector);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4862, Column 3 in freetype.h")]
        public static unsafe uint* FaceGetVariantSelectors(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.FaceGetVariantSelectors(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4896, Column 3 in freetype.h")]
        public static unsafe uint* FaceGetVariantsOfChar(this FreeType thisApi, Span<FaceRec> face, ulong charcode)
        {
            // SpanOverloader
            return thisApi.FaceGetVariantsOfChar(ref face.GetPinnableReference(), charcode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4931, Column 3 in freetype.h")]
        public static unsafe uint* FaceGetCharsOfVariant(this FreeType thisApi, Span<FaceRec> face, ulong variantSelector)
        {
            // SpanOverloader
            return thisApi.FaceGetCharsOfVariant(ref face.GetPinnableReference(), variantSelector);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        public static unsafe void VectorTransform(this FreeType thisApi, Vector* vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> matrix)
        {
            // SpanOverloader
            thisApi.VectorTransform(vector, in matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        public static unsafe void VectorTransform(this FreeType thisApi, Span<Vector> vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* matrix)
        {
            // SpanOverloader
            thisApi.VectorTransform(ref vector.GetPinnableReference(), matrix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5146, Column 3 in freetype.h")]
        public static unsafe void VectorTransform(this FreeType thisApi, Span<Vector> vector, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> matrix)
        {
            // SpanOverloader
            thisApi.VectorTransform(ref vector.GetPinnableReference(), in matrix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, int* amajor, int* aminor, Span<int> apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, amajor, aminor, ref apatch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, int* amajor, Span<int> aminor, int* apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, amajor, ref aminor.GetPinnableReference(), apatch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, int* amajor, Span<int> aminor, Span<int> apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, amajor, ref aminor.GetPinnableReference(), ref apatch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, Span<int> amajor, int* aminor, int* apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, ref amajor.GetPinnableReference(), aminor, apatch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, Span<int> amajor, int* aminor, Span<int> apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, ref amajor.GetPinnableReference(), aminor, ref apatch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, Span<int> amajor, Span<int> aminor, int* apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, ref amajor.GetPinnableReference(), ref aminor.GetPinnableReference(), apatch);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5217, Column 3 in freetype.h")]
        public static unsafe void LibraryVersion(this FreeType thisApi, LibraryRec* library, Span<int> amajor, Span<int> aminor, Span<int> apatch)
        {
            // SpanOverloader
            thisApi.LibraryVersion(library, ref amajor.GetPinnableReference(), ref aminor.GetPinnableReference(), ref apatch.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5253, Column 3 in freetype.h")]
        public static unsafe byte FaceCheckTrueTypePatents(this FreeType thisApi, Span<FaceRec> face)
        {
            // SpanOverloader
            return thisApi.FaceCheckTrueTypePatents(ref face.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5282, Column 3 in freetype.h")]
        public static unsafe byte FaceSetUnpatentedHinting(this FreeType thisApi, Span<FaceRec> face, byte value)
        {
            // SpanOverloader
            return thisApi.FaceSetUnpatentedHinting(ref face.GetPinnableReference(), value);
        }

    }
}

