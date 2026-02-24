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

namespace Silk.NET.Tracy
{
    public static class TracyOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 31, Column 16 in TracyC.h")]
        public static unsafe void TracySetThreadName(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracySetThreadName(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, source, sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, function, functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, in source.GetPinnableReference(), sourceSz, function, functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrcloc(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrcloc(line, source, sourceSz, in function.GetPinnableReference(), functionSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, in source.GetPinnableReference(), sourceSz, function, functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, in function.GetPinnableReference(), functionSz, name, nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        public static unsafe ulong TracyAllocSrclocName(this Tracy thisApi, uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz, uint color)
        {
            // SpanOverloader
            return thisApi.TracyAllocSrclocName(line, source, sourceSz, function, functionSz, in name.GetPinnableReference(), nameSz, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 25 in TracyC.h")]
        public static unsafe TracyCZoneContext TracyEmitZoneBegin(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc, int active)
        {
            // SpanOverloader
            return thisApi.TracyEmitZoneBegin(in srcloc.GetPinnableReference(), active);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 25 in TracyC.h")]
        public static unsafe TracyCZoneContext TracyEmitZoneBeginCallstack(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc, int depth, int active)
        {
            // SpanOverloader
            return thisApi.TracyEmitZoneBeginCallstack(in srcloc.GetPinnableReference(), depth, active);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneText(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneText(ctx, in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitZoneName(this Tracy thisApi, TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitZoneName(ctx, in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAlloc<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int secure) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAlloc(in ptr.GetPinnableReference(), size, secure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstack<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, int secure) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstack(in ptr.GetPinnableReference(), size, depth, secure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFree<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int secure) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFree(in ptr.GetPinnableReference(), secure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstack<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, int secure) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstack(in ptr.GetPinnableReference(), depth, secure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(ptr, size, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocNamed(in ptr.GetPinnableReference(), size, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(ptr, size, depth, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryAllocCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryAllocCallstackNamed(in ptr.GetPinnableReference(), size, depth, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(ptr, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeNamed(in ptr.GetPinnableReference(), secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(ptr, depth, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, secure, in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryFreeCallstackNamed<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryFreeCallstackNamed(in ptr.GetPinnableReference(), depth, secure, name);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 289, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryDiscard(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int secure)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryDiscard(in name.GetPinnableReference(), secure);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMemoryDiscardCallstack(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int secure, int depth)
        {
            // SpanOverloader
            thisApi.TracyEmitMemoryDiscardCallstack(in name.GetPinnableReference(), secure, depth);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitLogString(this Tracy thisApi, byte severity, int color, int callstack_depth, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt)
        {
            // SpanOverloader
            thisApi.TracyEmitLogString(severity, color, callstack_depth, size, in txt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 293, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitLogStringL(this Tracy thisApi, byte severity, int color, int callstack_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt)
        {
            // SpanOverloader
            thisApi.TracyEmitLogStringL(severity, color, callstack_depth, in txt.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMark(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMark(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMarkStart(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMarkStart(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameMarkEnd(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.TracyEmitFrameMarkEnd(in name.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitFrameImage<T0>(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> image, ushort w, ushort h, byte offset, int flip) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.TracyEmitFrameImage(in image.GetPinnableReference(), w, h, offset, flip);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlot(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, double val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlot(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotFloat(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, float val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotFloat(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotInt(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, long val)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotInt(in name.GetPinnableReference(), val);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitPlotConfig(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, int type, int step, int fill, uint color)
        {
            // SpanOverloader
            thisApi.TracyEmitPlotConfig(in name.GetPinnableReference(), type, step, fill, color);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 329, Column 16 in TracyC.h")]
        public static unsafe void TracyEmitMessageAppinfo(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> txt, nuint size)
        {
            // SpanOverloader
            thisApi.TracyEmitMessageAppinfo(in txt.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 49 in TracyC.h")]
        public static unsafe TracyLockableContextData* TracyAnnounceLockableCtx(this Tracy thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            return thisApi.TracyAnnounceLockableCtx(in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 367, Column 16 in TracyC.h")]
        public static unsafe void TracyMarkLockableCtx(this Tracy thisApi, TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TracySourceLocationData> srcloc)
        {
            // SpanOverloader
            thisApi.TracyMarkLockableCtx(lockdata, in srcloc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 16 in TracyC.h")]
        public static unsafe void TracyCustomNameLockableCtx(this Tracy thisApi, TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name, nuint nameSz)
        {
            // SpanOverloader
            thisApi.TracyCustomNameLockableCtx(lockdata, in name.GetPinnableReference(), nameSz);
        }

    }
}

