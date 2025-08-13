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

namespace Silk.NET.Slang
{
    public static class SlangOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 21, Column 29 in slang-deprecated.h")]
        public static unsafe IGlobalSession* SpCreateSession(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> deprecated)
        {
            // SpanOverloader
            return thisApi.SpCreateSession(in deprecated.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 26, Column 20 in slang-deprecated.h")]
        public static unsafe void SpDestroySession(this Slang thisApi, Span<IGlobalSession> session)
        {
            // SpanOverloader
            thisApi.SpDestroySession(ref session.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSessionSetSharedLibraryLoader(this Slang thisApi, IGlobalSession* session, Span<ISharedLibraryLoader> loader)
        {
            // SpanOverloader
            thisApi.SpSessionSetSharedLibraryLoader(session, ref loader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSessionSetSharedLibraryLoader(this Slang thisApi, Span<IGlobalSession> session, ISharedLibraryLoader* loader)
        {
            // SpanOverloader
            thisApi.SpSessionSetSharedLibraryLoader(ref session.GetPinnableReference(), loader);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSessionSetSharedLibraryLoader(this Slang thisApi, Span<IGlobalSession> session, Span<ISharedLibraryLoader> loader)
        {
            // SpanOverloader
            thisApi.SpSessionSetSharedLibraryLoader(ref session.GetPinnableReference(), ref loader.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 36, Column 42 in slang-deprecated.h")]
        public static unsafe ISharedLibraryLoader* SpSessionGetSharedLibraryLoader(this Slang thisApi, Span<IGlobalSession> session)
        {
            // SpanOverloader
            return thisApi.SpSessionGetSharedLibraryLoader(ref session.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 5 in slang-deprecated.h")]
        public static unsafe int SpSessionCheckCompileTargetSupport(this Slang thisApi, Span<IGlobalSession> session, CompileTarget target)
        {
            // SpanOverloader
            return thisApi.SpSessionCheckCompileTargetSupport(ref session.GetPinnableReference(), target);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 5 in slang-deprecated.h")]
        public static unsafe int SpSessionCheckPassThroughSupport(this Slang thisApi, Span<IGlobalSession> session, PassThrough passThrough)
        {
            // SpanOverloader
            return thisApi.SpSessionCheckPassThroughSupport(ref session.GetPinnableReference(), passThrough);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(session, sourcePath, in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(session, in sourcePath.GetPinnableReference(), sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(session, in sourcePath.GetPinnableReference(), in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(session, in sourcePath.GetPinnableReference(), sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(session, sourcePath, in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), in sourcePath.GetPinnableReference(), sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), in sourcePath.GetPinnableReference(), in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), in sourcePath.GetPinnableReference(), sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, in sourceString.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddBuiltins(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString)
        {
            // SpanOverloader
            thisApi.SpAddBuiltins(ref session.GetPinnableReference(), sourcePath, sourceString);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 57, Column 36 in slang-deprecated.h")]
        public static unsafe ICompileRequest* SpCreateCompileRequest(this Slang thisApi, Span<IGlobalSession> session)
        {
            // SpanOverloader
            return thisApi.SpCreateCompileRequest(ref session.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 20 in slang-deprecated.h")]
        public static unsafe void SpDestroyCompileRequest(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            thisApi.SpDestroyCompileRequest(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetFileSystem(this Slang thisApi, ICompileRequest* request, Span<IFileSystem> fileSystem)
        {
            // SpanOverloader
            thisApi.SpSetFileSystem(request, ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetFileSystem(this Slang thisApi, Span<ICompileRequest> request, IFileSystem* fileSystem)
        {
            // SpanOverloader
            thisApi.SpSetFileSystem(ref request.GetPinnableReference(), fileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetFileSystem(this Slang thisApi, Span<ICompileRequest> request, Span<IFileSystem> fileSystem)
        {
            // SpanOverloader
            thisApi.SpSetFileSystem(ref request.GetPinnableReference(), ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetCompileFlags(this Slang thisApi, Span<ICompileRequest> request, uint flags)
        {
            // SpanOverloader
            thisApi.SpSetCompileFlags(ref request.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 33 in slang-deprecated.h")]
        public static unsafe uint SpGetCompileFlags(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetCompileFlags(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDumpIntermediates(this Slang thisApi, Span<ICompileRequest> request, int enable)
        {
            // SpanOverloader
            thisApi.SpSetDumpIntermediates(ref request.GetPinnableReference(), enable);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDumpIntermediatePrefix(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> prefix)
        {
            // SpanOverloader
            thisApi.SpSetDumpIntermediatePrefix(request, in prefix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDumpIntermediatePrefix(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* prefix)
        {
            // SpanOverloader
            thisApi.SpSetDumpIntermediatePrefix(ref request.GetPinnableReference(), prefix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDumpIntermediatePrefix(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> prefix)
        {
            // SpanOverloader
            thisApi.SpSetDumpIntermediatePrefix(ref request.GetPinnableReference(), in prefix.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDumpIntermediatePrefix(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string prefix)
        {
            // SpanOverloader
            thisApi.SpSetDumpIntermediatePrefix(ref request.GetPinnableReference(), prefix);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetLineDirectiveMode(this Slang thisApi, Span<ICompileRequest> request, LineDirectiveMode mode)
        {
            // SpanOverloader
            thisApi.SpSetLineDirectiveMode(ref request.GetPinnableReference(), mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetLineDirectiveMode(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, LineDirectiveMode mode)
        {
            // SpanOverloader
            thisApi.SpSetTargetLineDirectiveMode(ref request.GetPinnableReference(), targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetForceGLSLScalarBufferLayout(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, bool forceScalarLayout)
        {
            // SpanOverloader
            thisApi.SpSetTargetForceGLSLScalarBufferLayout(ref request.GetPinnableReference(), targetIndex, forceScalarLayout);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetUseMinimumSlangOptimization(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, bool val)
        {
            // SpanOverloader
            thisApi.SpSetTargetUseMinimumSlangOptimization(ref request.GetPinnableReference(), targetIndex, val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetIgnoreCapabilityCheck(this Slang thisApi, Span<ICompileRequest> request, bool val)
        {
            // SpanOverloader
            thisApi.SpSetIgnoreCapabilityCheck(ref request.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetCodeGenTarget(this Slang thisApi, Span<ICompileRequest> request, CompileTarget target)
        {
            // SpanOverloader
            thisApi.SpSetCodeGenTarget(ref request.GetPinnableReference(), target);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddCodeGenTarget(this Slang thisApi, Span<ICompileRequest> request, CompileTarget target)
        {
            // SpanOverloader
            return thisApi.SpAddCodeGenTarget(ref request.GetPinnableReference(), target);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetProfile(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, ProfileID profile)
        {
            // SpanOverloader
            thisApi.SpSetTargetProfile(ref request.GetPinnableReference(), targetIndex, profile);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetFlags(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, uint flags)
        {
            // SpanOverloader
            thisApi.SpSetTargetFlags(ref request.GetPinnableReference(), targetIndex, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetFloatingPointMode(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, FloatingPointMode mode)
        {
            // SpanOverloader
            thisApi.SpSetTargetFloatingPointMode(ref request.GetPinnableReference(), targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTargetCapability(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, CapabilityID capability)
        {
            // SpanOverloader
            thisApi.SpAddTargetCapability(ref request.GetPinnableReference(), targetIndex, capability);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetTargetMatrixLayoutMode(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, MatrixLayoutMode mode)
        {
            // SpanOverloader
            thisApi.SpSetTargetMatrixLayoutMode(ref request.GetPinnableReference(), targetIndex, mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetMatrixLayoutMode(this Slang thisApi, Span<ICompileRequest> request, MatrixLayoutMode mode)
        {
            // SpanOverloader
            thisApi.SpSetMatrixLayoutMode(ref request.GetPinnableReference(), mode);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDebugInfoLevel(this Slang thisApi, Span<ICompileRequest> request, DebugInfoLevel level)
        {
            // SpanOverloader
            thisApi.SpSetDebugInfoLevel(ref request.GetPinnableReference(), level);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDebugInfoFormat(this Slang thisApi, Span<ICompileRequest> request, DebugInfoFormat format)
        {
            // SpanOverloader
            thisApi.SpSetDebugInfoFormat(ref request.GetPinnableReference(), format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetOptimizationLevel(this Slang thisApi, Span<ICompileRequest> request, OptimizationLevel level)
        {
            // SpanOverloader
            thisApi.SpSetOptimizationLevel(ref request.GetPinnableReference(), level);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetOutputContainerFormat(this Slang thisApi, Span<ICompileRequest> request, ContainerFormat format)
        {
            // SpanOverloader
            thisApi.SpSetOutputContainerFormat(ref request.GetPinnableReference(), format);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetPassThrough(this Slang thisApi, Span<ICompileRequest> request, PassThrough passThrough)
        {
            // SpanOverloader
            thisApi.SpSetPassThrough(ref request.GetPinnableReference(), passThrough);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDiagnosticCallback<T0>(this Slang thisApi, ICompileRequest* request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> userData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SpSetDiagnosticCallback(request, callback, in userData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDiagnosticCallback(this Slang thisApi, Span<ICompileRequest> request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userData)
        {
            // SpanOverloader
            thisApi.SpSetDiagnosticCallback(ref request.GetPinnableReference(), callback, userData);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDiagnosticCallback<T0>(this Slang thisApi, Span<ICompileRequest> request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> userData) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.SpSetDiagnosticCallback(ref request.GetPinnableReference(), callback, in userData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetWriter(this Slang thisApi, ICompileRequest* request, WriterChannel channel, Span<IWriter> writer)
        {
            // SpanOverloader
            thisApi.SpSetWriter(request, channel, ref writer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetWriter(this Slang thisApi, Span<ICompileRequest> request, WriterChannel channel, IWriter* writer)
        {
            // SpanOverloader
            thisApi.SpSetWriter(ref request.GetPinnableReference(), channel, writer);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetWriter(this Slang thisApi, Span<ICompileRequest> request, WriterChannel channel, Span<IWriter> writer)
        {
            // SpanOverloader
            thisApi.SpSetWriter(ref request.GetPinnableReference(), channel, ref writer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in slang-deprecated.h")]
        public static unsafe IWriter* SpGetWriter(this Slang thisApi, Span<ICompileRequest> request, WriterChannel channel)
        {
            // SpanOverloader
            return thisApi.SpGetWriter(ref request.GetPinnableReference(), channel);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddSearchPath(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> searchDir)
        {
            // SpanOverloader
            thisApi.SpAddSearchPath(request, in searchDir.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddSearchPath(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* searchDir)
        {
            // SpanOverloader
            thisApi.SpAddSearchPath(ref request.GetPinnableReference(), searchDir);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddSearchPath(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> searchDir)
        {
            // SpanOverloader
            thisApi.SpAddSearchPath(ref request.GetPinnableReference(), in searchDir.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddSearchPath(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string searchDir)
        {
            // SpanOverloader
            thisApi.SpAddSearchPath(ref request.GetPinnableReference(), searchDir);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(request, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(request, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(request, in key.GetPinnableReference(), in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(request, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(request, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), in key.GetPinnableReference(), in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpAddPreprocessorDefine(ref request.GetPinnableReference(), key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        public static unsafe int SpProcessCommandLineArguments(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** args, int argCount)
        {
            // SpanOverloader
            return thisApi.SpProcessCommandLineArguments(ref request.GetPinnableReference(), args, argCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        public static unsafe int SpProcessCommandLineArguments(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* args, int argCount)
        {
            // SpanOverloader
            return thisApi.SpProcessCommandLineArguments(ref request.GetPinnableReference(), in args, argCount);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddTranslationUnit(this Slang thisApi, ICompileRequest* request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpAddTranslationUnit(request, language, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddTranslationUnit(this Slang thisApi, Span<ICompileRequest> request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            // SpanOverloader
            return thisApi.SpAddTranslationUnit(ref request.GetPinnableReference(), language, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddTranslationUnit(this Slang thisApi, Span<ICompileRequest> request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpAddTranslationUnit(ref request.GetPinnableReference(), language, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddTranslationUnit(this Slang thisApi, Span<ICompileRequest> request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            // SpanOverloader
            return thisApi.SpAddTranslationUnit(ref request.GetPinnableReference(), language, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDefaultModuleName(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> defaultModuleName)
        {
            // SpanOverloader
            thisApi.SpSetDefaultModuleName(request, in defaultModuleName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDefaultModuleName(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* defaultModuleName)
        {
            // SpanOverloader
            thisApi.SpSetDefaultModuleName(ref request.GetPinnableReference(), defaultModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDefaultModuleName(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> defaultModuleName)
        {
            // SpanOverloader
            thisApi.SpSetDefaultModuleName(ref request.GetPinnableReference(), in defaultModuleName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDefaultModuleName(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string defaultModuleName)
        {
            // SpanOverloader
            thisApi.SpSetDefaultModuleName(ref request.GetPinnableReference(), defaultModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(request, translationUnitIndex, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(request, translationUnitIndex, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(request, translationUnitIndex, in key.GetPinnableReference(), in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(request, translationUnitIndex, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(request, translationUnitIndex, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, in key.GetPinnableReference(), in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, in key.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, in value.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        public static unsafe void SpTranslationUnitAddPreprocessorDefine(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value)
        {
            // SpanOverloader
            thisApi.SpTranslationUnitAddPreprocessorDefine(ref request.GetPinnableReference(), translationUnitIndex, key, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceFile(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceFile(request, translationUnitIndex, in path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceFile(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceFile(ref request.GetPinnableReference(), translationUnitIndex, path);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceFile(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceFile(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceFile(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceFile(ref request.GetPinnableReference(), translationUnitIndex, path);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(request, translationUnitIndex, path, in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(request, translationUnitIndex, in path.GetPinnableReference(), source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(request, translationUnitIndex, in path.GetPinnableReference(), in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(request, translationUnitIndex, in path.GetPinnableReference(), source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(request, translationUnitIndex, path, in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, in source.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceString(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceString(ref request.GetPinnableReference(), translationUnitIndex, path, source);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(request, basePath, in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(request, in basePath.GetPinnableReference(), libData, libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(request, in basePath.GetPinnableReference(), in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(request, basePath, in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), basePath, libData, libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), basePath, in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), in basePath.GetPinnableReference(), libData, libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), in basePath.GetPinnableReference(), in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize)
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), basePath, libData, libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        public static unsafe int SpAddLibraryReference<T0>(this Slang thisApi, Span<ICompileRequest> request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> libData, nuint libDataSize) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpAddLibraryReference(ref request.GetPinnableReference(), basePath, in libData.GetPinnableReference(), libDataSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(request, translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, in sourceBegin.GetPinnableReference(), sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, in sourceEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceStringSpan(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceStringSpan(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBegin, sourceEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(request, translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob* sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(request, translationUnitIndex, in path.GetPinnableReference(), sourceBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(request, translationUnitIndex, in path.GetPinnableReference(), ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(request, translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, IBlob* sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), sourceBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, in path.GetPinnableReference(), ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, path, sourceBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        public static unsafe void SpAddTranslationUnitSourceBlob(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Span<IBlob> sourceBlob)
        {
            // SpanOverloader
            thisApi.SpAddTranslationUnitSourceBlob(ref request.GetPinnableReference(), translationUnitIndex, path, ref sourceBlob.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        public static unsafe ProfileID SpFindProfile(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpFindProfile(session, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        public static unsafe ProfileID SpFindProfile(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            // SpanOverloader
            return thisApi.SpFindProfile(ref session.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        public static unsafe ProfileID SpFindProfile(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpFindProfile(ref session.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        public static unsafe ProfileID SpFindProfile(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            // SpanOverloader
            return thisApi.SpFindProfile(ref session.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        public static unsafe CapabilityID SpFindCapability(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpFindCapability(session, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        public static unsafe CapabilityID SpFindCapability(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            // SpanOverloader
            return thisApi.SpFindCapability(ref session.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        public static unsafe CapabilityID SpFindCapability(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpFindCapability(ref session.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        public static unsafe CapabilityID SpFindCapability(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            // SpanOverloader
            return thisApi.SpFindCapability(ref session.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPoint(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPoint(request, translationUnitIndex, in name.GetPinnableReference(), stage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPoint(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPoint(ref request.GetPinnableReference(), translationUnitIndex, name, stage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPoint(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPoint(ref request.GetPinnableReference(), translationUnitIndex, in name.GetPinnableReference(), stage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPoint(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPoint(ref request.GetPinnableReference(), translationUnitIndex, name, stage);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(request, translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(request, translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, in genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, name, stage, genericArgCount, genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, name, stage, genericArgCount, in genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, in name.GetPinnableReference(), stage, genericArgCount, in genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, name, stage, genericArgCount, genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public static unsafe int SpAddEntryPointEx(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            // SpanOverloader
            return thisApi.SpAddEntryPointEx(ref request.GetPinnableReference(), translationUnitIndex, name, stage, genericArgCount, in genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetGlobalGenericArgs(this Slang thisApi, Span<ICompileRequest> request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs)
        {
            // SpanOverloader
            return thisApi.SpSetGlobalGenericArgs(ref request.GetPinnableReference(), genericArgCount, genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetGlobalGenericArgs(this Slang thisApi, Span<ICompileRequest> request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs)
        {
            // SpanOverloader
            return thisApi.SpSetGlobalGenericArgs(ref request.GetPinnableReference(), genericArgCount, in genericArgs);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForGlobalExistentialTypeParam(this Slang thisApi, ICompileRequest* request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForGlobalExistentialTypeParam(request, slotIndex, in typeName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForGlobalExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForGlobalExistentialTypeParam(ref request.GetPinnableReference(), slotIndex, typeName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForGlobalExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForGlobalExistentialTypeParam(ref request.GetPinnableReference(), slotIndex, in typeName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForGlobalExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForGlobalExistentialTypeParam(ref request.GetPinnableReference(), slotIndex, typeName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForEntryPointExistentialTypeParam(this Slang thisApi, ICompileRequest* request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForEntryPointExistentialTypeParam(request, entryPointIndex, slotIndex, in typeName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForEntryPointExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForEntryPointExistentialTypeParam(ref request.GetPinnableReference(), entryPointIndex, slotIndex, typeName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForEntryPointExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForEntryPointExistentialTypeParam(ref request.GetPinnableReference(), entryPointIndex, slotIndex, in typeName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSetTypeNameForEntryPointExistentialTypeParam(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName)
        {
            // SpanOverloader
            return thisApi.SpSetTypeNameForEntryPointExistentialTypeParam(ref request.GetPinnableReference(), entryPointIndex, slotIndex, typeName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 295, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompile(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpCompile(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpGetDiagnosticOutput(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetDiagnosticOutput(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        public static unsafe int SpGetDiagnosticOutputBlob(this Slang thisApi, Span<ICompileRequest> request, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetDiagnosticOutputBlob(ref request.GetPinnableReference(), outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        public static unsafe int SpGetDiagnosticOutputBlob(this Slang thisApi, Span<ICompileRequest> request, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetDiagnosticOutputBlob(ref request.GetPinnableReference(), ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 19 in slang-deprecated.h")]
        public static unsafe int SpGetDependencyFileCount(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetDependencyFileCount(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpGetDependencyFilePath(this Slang thisApi, Span<ICompileRequest> request, int index)
        {
            // SpanOverloader
            return thisApi.SpGetDependencyFilePath(ref request.GetPinnableReference(), index);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 19 in slang-deprecated.h")]
        public static unsafe int SpGetTranslationUnitCount(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetTranslationUnitCount(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpGetEntryPointSource(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointSource(ref request.GetPinnableReference(), entryPointIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetEntryPointCode(this Slang thisApi, ICompileRequest* request, int entryPointIndex, Span<nuint> outSize)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointCode(request, entryPointIndex, ref outSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetEntryPointCode(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, nuint* outSize)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointCode(ref request.GetPinnableReference(), entryPointIndex, outSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetEntryPointCode(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, Span<nuint> outSize)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointCode(ref request.GetPinnableReference(), entryPointIndex, ref outSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetEntryPointCodeBlob(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int targetIndex, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointCodeBlob(ref request.GetPinnableReference(), entryPointIndex, targetIndex, outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetEntryPointCodeBlob(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int targetIndex, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointCodeBlob(ref request.GetPinnableReference(), entryPointIndex, targetIndex, ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetEntryPointHostCallable(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointHostCallable(ref request.GetPinnableReference(), entryPointIndex, targetIndex, outSharedLibrary);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetEntryPointHostCallable(this Slang thisApi, Span<ICompileRequest> request, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary)
        {
            // SpanOverloader
            return thisApi.SpGetEntryPointHostCallable(ref request.GetPinnableReference(), entryPointIndex, targetIndex, ref outSharedLibrary);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        public static unsafe int SpGetTargetCodeBlob(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetTargetCodeBlob(ref request.GetPinnableReference(), targetIndex, outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        public static unsafe int SpGetTargetCodeBlob(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetTargetCodeBlob(ref request.GetPinnableReference(), targetIndex, ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetTargetHostCallable(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, ISharedLibrary** outSharedLibrary)
        {
            // SpanOverloader
            return thisApi.SpGetTargetHostCallable(ref request.GetPinnableReference(), targetIndex, outSharedLibrary);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetTargetHostCallable(this Slang thisApi, Span<ICompileRequest> request, int targetIndex, ref ISharedLibrary* outSharedLibrary)
        {
            // SpanOverloader
            return thisApi.SpGetTargetHostCallable(ref request.GetPinnableReference(), targetIndex, ref outSharedLibrary);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetCompileRequestCode(this Slang thisApi, ICompileRequest* request, Span<nuint> outSize)
        {
            // SpanOverloader
            return thisApi.SpGetCompileRequestCode(request, ref outSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetCompileRequestCode(this Slang thisApi, Span<ICompileRequest> request, nuint* outSize)
        {
            // SpanOverloader
            return thisApi.SpGetCompileRequestCode(ref request.GetPinnableReference(), outSize);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        public static unsafe void* SpGetCompileRequestCode(this Slang thisApi, Span<ICompileRequest> request, Span<nuint> outSize)
        {
            // SpanOverloader
            return thisApi.SpGetCompileRequestCode(ref request.GetPinnableReference(), ref outSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetContainerCode(this Slang thisApi, Span<ICompileRequest> request, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetContainerCode(ref request.GetPinnableReference(), outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetContainerCode(this Slang thisApi, Span<ICompileRequest> request, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpGetContainerCode(ref request.GetPinnableReference(), ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro<T0>(this Slang thisApi, ICompileRequest* request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(request, fileSystem, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro(this Slang thisApi, ICompileRequest* request, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(request, ref fileSystem.GetPinnableReference(), data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro<T0>(this Slang thisApi, ICompileRequest* request, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(request, ref fileSystem.GetPinnableReference(), in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro(this Slang thisApi, Span<ICompileRequest> request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(ref request.GetPinnableReference(), fileSystem, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro<T0>(this Slang thisApi, Span<ICompileRequest> request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(ref request.GetPinnableReference(), fileSystem, in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro(this Slang thisApi, Span<ICompileRequest> request, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size)
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(ref request.GetPinnableReference(), ref fileSystem.GetPinnableReference(), data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadRepro<T0>(this Slang thisApi, Span<ICompileRequest> request, Span<IFileSystem> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadRepro(ref request.GetPinnableReference(), ref fileSystem.GetPinnableReference(), in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSaveRepro(this Slang thisApi, Span<ICompileRequest> request, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpSaveRepro(ref request.GetPinnableReference(), outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        public static unsafe int SpSaveRepro(this Slang thisApi, Span<ICompileRequest> request, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpSaveRepro(ref request.GetPinnableReference(), ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 27 in slang-deprecated.h")]
        public static unsafe int SpEnableReproCapture(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpEnableReproCapture(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetCompileTimeProfile(this Slang thisApi, Span<ICompileRequest> request, IProfiler** compileTimeProfile, bool shouldClear)
        {
            // SpanOverloader
            return thisApi.SpGetCompileTimeProfile(ref request.GetPinnableReference(), compileTimeProfile, shouldClear);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        public static unsafe int SpGetCompileTimeProfile(this Slang thisApi, Span<ICompileRequest> request, ref IProfiler* compileTimeProfile, bool shouldClear)
        {
            // SpanOverloader
            return thisApi.SpGetCompileTimeProfile(ref request.GetPinnableReference(), ref compileTimeProfile, shouldClear);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IMutableFileSystem> fileSystem)
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(session, reproData, reproDataSize, ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IMutableFileSystem* fileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(session, in reproData.GetPinnableReference(), reproDataSize, fileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IMutableFileSystem> fileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(session, in reproData.GetPinnableReference(), reproDataSize, ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IMutableFileSystem* fileSystem)
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(ref session.GetPinnableReference(), reproData, reproDataSize, fileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IMutableFileSystem> fileSystem)
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(ref session.GetPinnableReference(), reproData, reproDataSize, ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IMutableFileSystem* fileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, fileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        public static unsafe int SpExtractRepro<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IMutableFileSystem> fileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpExtractRepro(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, ref fileSystem.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, IFileSystemExt** outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, reproData, reproDataSize, ref replaceFileSystem.GetPinnableReference(), outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, ref IFileSystemExt* outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, reproData, reproDataSize, ref replaceFileSystem.GetPinnableReference(), ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, in reproData.GetPinnableReference(), reproDataSize, replaceFileSystem, outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, in reproData.GetPinnableReference(), reproDataSize, replaceFileSystem, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, in reproData.GetPinnableReference(), reproDataSize, ref replaceFileSystem.GetPinnableReference(), outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(session, in reproData.GetPinnableReference(), reproDataSize, ref replaceFileSystem.GetPinnableReference(), ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), reproData, reproDataSize, replaceFileSystem, outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), reproData, reproDataSize, replaceFileSystem, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, IFileSystemExt** outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), reproData, reproDataSize, ref replaceFileSystem.GetPinnableReference(), outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, ref IFileSystemExt* outFileSystem)
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), reproData, reproDataSize, ref replaceFileSystem.GetPinnableReference(), ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, replaceFileSystem, outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, replaceFileSystem, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, ref replaceFileSystem.GetPinnableReference(), outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public static unsafe int SpLoadReproAsFileSystem<T0>(this Slang thisApi, Span<IGlobalSession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> reproData, nuint reproDataSize, Span<IFileSystem> replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SpLoadReproAsFileSystem(ref session.GetPinnableReference(), in reproData.GetPinnableReference(), reproDataSize, ref replaceFileSystem.GetPinnableReference(), ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 20 in slang-deprecated.h")]
        public static unsafe void SpOverrideDiagnosticSeverity(this Slang thisApi, Span<ICompileRequest> request, long messageID, Severity overrideSeverity)
        {
            // SpanOverloader
            thisApi.SpOverrideDiagnosticSeverity(ref request.GetPinnableReference(), messageID, overrideSeverity);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 36 in slang-deprecated.h")]
        public static unsafe int SpGetDiagnosticFlags(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetDiagnosticFlags(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 20 in slang-deprecated.h")]
        public static unsafe void SpSetDiagnosticFlags(this Slang thisApi, Span<ICompileRequest> request, int flags)
        {
            // SpanOverloader
            thisApi.SpSetDiagnosticFlags(ref request.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 425, Column 32 in slang-deprecated.h")]
        public static unsafe ProgramLayout* SpGetReflection(this Slang thisApi, Span<ICompileRequest> request)
        {
            // SpanOverloader
            return thisApi.SpGetReflection(ref request.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 434, Column 27 in slang-deprecated.h")]
        public static unsafe int SpReflectionUserAttributeGetArgumentValueInt(this Slang thisApi, ReflectionUserAttribute* attrib, uint index, Span<int> rs)
        {
            // SpanOverloader
            return thisApi.SpReflectionUserAttributeGetArgumentValueInt(attrib, index, ref rs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 27 in slang-deprecated.h")]
        public static unsafe int SpReflectionUserAttributeGetArgumentValueFloat(this Slang thisApi, ReflectionUserAttribute* attrib, uint index, Span<float> rs)
        {
            // SpanOverloader
            return thisApi.SpReflectionUserAttributeGetArgumentValueFloat(attrib, index, ref rs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 448, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpReflectionUserAttributeGetArgumentValueString(this Slang thisApi, ReflectionUserAttribute* attrib, uint index, Span<nuint> outSize)
        {
            // SpanOverloader
            return thisApi.SpReflectionUserAttributeGetArgumentValueString(attrib, index, ref outSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionTypeFindUserAttributeByName(this Slang thisApi, ReflectionType* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeFindUserAttributeByName(type, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        public static unsafe long SpReflectionTypeLayoutFindFieldIndexByName(this Slang thisApi, ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameEnd)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeLayoutFindFieldIndexByName(typeLayout, nameBegin, in nameEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        public static unsafe long SpReflectionTypeLayoutFindFieldIndexByName(this Slang thisApi, ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameEnd)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeLayoutFindFieldIndexByName(typeLayout, in nameBegin.GetPinnableReference(), nameEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        public static unsafe long SpReflectionTypeLayoutFindFieldIndexByName(this Slang thisApi, ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameEnd)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeLayoutFindFieldIndexByName(typeLayout, in nameBegin.GetPinnableReference(), in nameEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        public static unsafe long SpReflectionTypeLayoutFindFieldIndexByName(this Slang thisApi, ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameEnd)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeLayoutFindFieldIndexByName(typeLayout, in nameBegin.GetPinnableReference(), nameEnd);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        public static unsafe long SpReflectionTypeLayoutFindFieldIndexByName(this Slang thisApi, ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> nameEnd)
        {
            // SpanOverloader
            return thisApi.SpReflectionTypeLayoutFindFieldIndexByName(typeLayout, nameBegin, in nameEnd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(this Slang thisApi, ReflectionVariable* var, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionVariableFindUserAttributeByName(var, globalSession, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(this Slang thisApi, ReflectionVariable* var, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            // SpanOverloader
            return thisApi.SpReflectionVariableFindUserAttributeByName(var, ref globalSession.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(this Slang thisApi, ReflectionVariable* var, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionVariableFindUserAttributeByName(var, ref globalSession.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(this Slang thisApi, ReflectionVariable* var, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            // SpanOverloader
            return thisApi.SpReflectionVariableFindUserAttributeByName(var, ref globalSession.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 673, Column 5 in slang-deprecated.h")]
        public static unsafe int SpReflectionVariableGetDefaultValueInt(this Slang thisApi, ReflectionVariable* inVar, Span<long> rs)
        {
            // SpanOverloader
            return thisApi.SpReflectionVariableGetDefaultValueInt(inVar, ref rs.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(this Slang thisApi, ReflectionFunction* func, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFunctionFindUserAttributeByName(func, globalSession, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(this Slang thisApi, ReflectionFunction* func, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFunctionFindUserAttributeByName(func, ref globalSession.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(this Slang thisApi, ReflectionFunction* func, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFunctionFindUserAttributeByName(func, ref globalSession.GetPinnableReference(), in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(this Slang thisApi, ReflectionFunction* func, Span<IGlobalSession> globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFunctionFindUserAttributeByName(func, ref globalSession.GetPinnableReference(), name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        public static unsafe int SpIsParameterLocationUsed(this Slang thisApi, ICompileRequest* request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, Span<bool> outUsed)
        {
            // SpanOverloader
            return thisApi.SpIsParameterLocationUsed(request, entryPointIndex, targetIndex, category, spaceIndex, registerIndex, ref outUsed.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        public static unsafe int SpIsParameterLocationUsed(this Slang thisApi, Span<ICompileRequest> request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, bool* outUsed)
        {
            // SpanOverloader
            return thisApi.SpIsParameterLocationUsed(ref request.GetPinnableReference(), entryPointIndex, targetIndex, category, spaceIndex, registerIndex, outUsed);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        public static unsafe int SpIsParameterLocationUsed(this Slang thisApi, Span<ICompileRequest> request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, Span<bool> outUsed)
        {
            // SpanOverloader
            return thisApi.SpIsParameterLocationUsed(ref request.GetPinnableReference(), entryPointIndex, targetIndex, category, spaceIndex, registerIndex, ref outUsed.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 837, Column 20 in slang-deprecated.h")]
        public static unsafe void SpReflectionEntryPointGetComputeThreadGroupSize(this Slang thisApi, EntryPointLayout* entryPoint, ulong axisCount, Span<ulong> outSizeAlongAxis)
        {
            // SpanOverloader
            thisApi.SpReflectionEntryPointGetComputeThreadGroupSize(entryPoint, axisCount, ref outSizeAlongAxis.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 20 in slang-deprecated.h")]
        public static unsafe void SpReflectionEntryPointGetComputeWaveSize(this Slang thisApi, EntryPointLayout* entryPoint, Span<ulong> outWaveSize)
        {
            // SpanOverloader
            thisApi.SpReflectionEntryPointGetComputeWaveSize(entryPoint, ref outWaveSize.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        public static unsafe int SpReflectionToJson(this Slang thisApi, ProgramLayout* reflection, Span<ICompileRequest> request, IBlob** outBlob)
        {
            // SpanOverloader
            return thisApi.SpReflectionToJson(reflection, ref request.GetPinnableReference(), outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        public static unsafe int SpReflectionToJson(this Slang thisApi, ProgramLayout* reflection, Span<ICompileRequest> request, ref IBlob* outBlob)
        {
            // SpanOverloader
            return thisApi.SpReflectionToJson(reflection, ref request.GetPinnableReference(), ref outBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 45 in slang-deprecated.h")]
        public static unsafe ReflectionTypeParameter* SpReflectionFindTypeParameter(this Slang thisApi, ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindTypeParameter(reflection, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 888, Column 36 in slang-deprecated.h")]
        public static unsafe ReflectionType* SpReflectionFindTypeByName(this Slang thisApi, ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindTypeByName(reflection, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 40 in slang-deprecated.h")]
        public static unsafe ReflectionFunction* SpReflectionFindFunctionByName(this Slang thisApi, ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindFunctionByName(reflection, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 40 in slang-deprecated.h")]
        public static unsafe ReflectionFunction* SpReflectionFindFunctionByNameInType(this Slang thisApi, ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindFunctionByNameInType(reflection, reflType, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 40 in slang-deprecated.h")]
        public static unsafe ReflectionVariable* SpReflectionFindVarByNameInType(this Slang thisApi, ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindVarByNameInType(reflection, reflType, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 42 in slang-deprecated.h")]
        public static unsafe EntryPointLayout* SpReflectionFindEntryPointByName(this Slang thisApi, ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.SpReflectionFindEntryPointByName(reflection, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArg> args, IBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, argTypes, in args.GetPinnableReference(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArg> args, ref IBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, argTypes, in args.GetPinnableReference(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArgType> argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, IBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, in argTypes.GetPinnableReference(), args, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArgType> argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, ref IBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, in argTypes.GetPinnableReference(), args, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArgType> argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArg> args, IBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, in argTypes.GetPinnableReference(), in args.GetPinnableReference(), outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        public static unsafe ReflectionGeneric* SpReflectionSpecializeGeneric(this Slang thisApi, ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArgType> argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReflectionGenericArg> args, ref IBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SpReflectionSpecializeGeneric(inProgramLayout, generic, argCount, in argTypes.GetPinnableReference(), in args.GetPinnableReference(), ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpReflectionGetHashedString(this Slang thisApi, ProgramLayout* reflection, ulong index, Span<nuint> outCount)
        {
            // SpanOverloader
            return thisApi.SpReflectionGetHashedString(reflection, index, ref outCount.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 27 in slang-deprecated.h")]
        public static unsafe uint SpComputeStringHash(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> chars, nuint count)
        {
            // SpanOverloader
            return thisApi.SpComputeStringHash(in chars.GetPinnableReference(), count);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 27 in slang-deprecated.h")]
        public static unsafe byte* SpGetTranslationUnitSource(this Slang thisApi, Span<ICompileRequest> request, int translationUnitIndex)
        {
            // SpanOverloader
            return thisApi.SpGetTranslationUnitSource(ref request.GetPinnableReference(), translationUnitIndex);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetProgram(this Slang thisApi, Span<ICompileRequest> request, IComponentType** outProgram)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetProgram(ref request.GetPinnableReference(), outProgram);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetProgram(this Slang thisApi, Span<ICompileRequest> request, ref IComponentType* outProgram)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetProgram(ref request.GetPinnableReference(), ref outProgram);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetProgramWithEntryPoints(this Slang thisApi, Span<ICompileRequest> request, IComponentType** outProgram)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetProgramWithEntryPoints(ref request.GetPinnableReference(), outProgram);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetProgramWithEntryPoints(this Slang thisApi, Span<ICompileRequest> request, ref IComponentType* outProgram)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetProgramWithEntryPoints(ref request.GetPinnableReference(), ref outProgram);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetEntryPoint(this Slang thisApi, Span<ICompileRequest> request, long entryPointIndex, IComponentType** outEntryPoint)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetEntryPoint(ref request.GetPinnableReference(), entryPointIndex, outEntryPoint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetEntryPoint(this Slang thisApi, Span<ICompileRequest> request, long entryPointIndex, ref IComponentType* outEntryPoint)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetEntryPoint(ref request.GetPinnableReference(), entryPointIndex, ref outEntryPoint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetModule(this Slang thisApi, Span<ICompileRequest> request, long translationUnitIndex, IModule** outModule)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetModule(ref request.GetPinnableReference(), translationUnitIndex, outModule);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetModule(this Slang thisApi, Span<ICompileRequest> request, long translationUnitIndex, ref IModule* outModule)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetModule(ref request.GetPinnableReference(), translationUnitIndex, ref outModule);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetSession(this Slang thisApi, Span<ICompileRequest> request, ISession** outSession)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetSession(ref request.GetPinnableReference(), outSession);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        public static unsafe int SpCompileRequestGetSession(this Slang thisApi, Span<ICompileRequest> request, ref ISession* outSession)
        {
            // SpanOverloader
            return thisApi.SpCompileRequestGetSession(ref request.GetPinnableReference(), ref outSession);
        }

    }
}

