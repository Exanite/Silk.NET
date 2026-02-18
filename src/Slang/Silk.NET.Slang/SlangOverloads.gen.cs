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
        [NativeName("Src", "Line 4719, Column 38 in slang.h")]
        public static unsafe ISlangBlob* SlangCreateBlob<T0>(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> data, nuint size) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangCreateBlob(in data.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4731, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromSource(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromSource(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(session, moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), in moduleName.GetPinnableReference(), path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, in path.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ISlangBlob** outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, ref ISlangBlob* outDiagnostics)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, source, sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ISlangBlob** outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4748, Column 42 in slang.h")]
        public static unsafe IModule* SlangLoadModuleFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string moduleName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, ref ISlangBlob* outDiagnostics) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleFromIRBlob(ref session.GetPinnableReference(), moduleName, path, in source.GetPinnableReference(), sourceSize, ref outDiagnostics);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, source, sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, source, sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, source, sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, source, sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, outModuleVersion, outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, outModuleVersion, outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, outModuleVersion, in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, outModuleVersion, in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, ISession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(session, in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, outModuleVersion, outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, outModuleVersion, outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, outModuleVersion, in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, outModuleVersion, in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName)
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), source, sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outModuleVersion, outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outModuleVersion, outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outModuleVersion, in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, long* outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, outModuleVersion, in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4765, Column 38 in slang.h")]
        public static unsafe int SlangLoadModuleInfoFromIRBlob<T0>(this Slang thisApi, Span<ISession> session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> source, nuint sourceSize, Span<long> outModuleVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleCompilerVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte* outModuleName) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.SlangLoadModuleInfoFromIRBlob(ref session.GetPinnableReference(), in source.GetPinnableReference(), sourceSize, ref outModuleVersion.GetPinnableReference(), in outModuleCompilerVersion, in outModuleName);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4787, Column 38 in slang.h")]
        public static unsafe int SlangCreateGlobalSession2(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangGlobalSessionDesc> desc, IGlobalSession** outGlobalSession)
        {
            // SpanOverloader
            return thisApi.SlangCreateGlobalSession2(in desc.GetPinnableReference(), outGlobalSession);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4787, Column 38 in slang.h")]
        public static unsafe int SlangCreateGlobalSession2(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangGlobalSessionDesc> desc, ref IGlobalSession* outGlobalSession)
        {
            // SpanOverloader
            return thisApi.SlangCreateGlobalSession2(in desc.GetPinnableReference(), ref outGlobalSession);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4933, Column 38 in slang.h")]
        public static unsafe int SlangCreateByteCodeRunner(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ByteCodeRunnerDesc> desc, IByteCodeRunner** outByteCodeRunner)
        {
            // SpanOverloader
            return thisApi.SlangCreateByteCodeRunner(in desc.GetPinnableReference(), outByteCodeRunner);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4933, Column 38 in slang.h")]
        public static unsafe int SlangCreateByteCodeRunner(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ByteCodeRunnerDesc> desc, ref IByteCodeRunner* outByteCodeRunner)
        {
            // SpanOverloader
            return thisApi.SlangCreateByteCodeRunner(in desc.GetPinnableReference(), ref outByteCodeRunner);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4939, Column 1 in slang.h")]
        public static unsafe int SlangDisassembleByteCode(this Slang thisApi, Span<ISlangBlob> moduleBlob, ISlangBlob** outDisassemblyBlob)
        {
            // SpanOverloader
            return thisApi.SlangDisassembleByteCode(ref moduleBlob.GetPinnableReference(), outDisassemblyBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4939, Column 1 in slang.h")]
        public static unsafe int SlangDisassembleByteCode(this Slang thisApi, Span<ISlangBlob> moduleBlob, ref ISlangBlob* outDisassemblyBlob)
        {
            // SpanOverloader
            return thisApi.SlangDisassembleByteCode(ref moduleBlob.GetPinnableReference(), ref outDisassemblyBlob);
        }

    }
}

