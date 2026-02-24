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
    public unsafe partial class Tracy : NativeAPI
    {
        [NativeName("Type", "")]
        [NativeName("Name", "TracyFile")]
        public const string TracyFile = unchecked((string) "Tracy.h");
        [NativeName("Type", "int")]
        [NativeName("Name", "TracyLine")]
        public const int TracyLine = unchecked((int) 0x1C);
        [NativeName("Type", "int")]
        [NativeName("Name", "TracyCIsStarted")]
        public const int TracyCIsStarted = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "TRACY_CALLSTACK")]
        public const int TracyCallstack = unchecked((int) 0x0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 31, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_set_thread_name")]
        public unsafe partial void TracySetThreadName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 31, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_set_thread_name")]
        public partial void TracySetThreadName([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 31, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_set_thread_name")]
        public partial void TracySetThreadName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public unsafe partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public unsafe partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public unsafe partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public unsafe partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public unsafe partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 227, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc")]
        public partial ulong TracyAllocSrcloc(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public unsafe partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 228, Column 20 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_alloc_srcloc_name")]
        public partial ulong TracyAllocSrclocName(uint line, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source, nuint sourceSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string function, nuint functionSz, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin")]
        public unsafe partial TracyCZoneContext TracyEmitZoneBegin([Flow(Silk.NET.Core.Native.FlowDirection.In)] TracySourceLocationData* srcloc, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 230, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin")]
        public partial TracyCZoneContext TracyEmitZoneBegin([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TracySourceLocationData srcloc, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin_callstack")]
        public unsafe partial TracyCZoneContext TracyEmitZoneBeginCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] TracySourceLocationData* srcloc, int depth, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin_callstack")]
        public partial TracyCZoneContext TracyEmitZoneBeginCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TracySourceLocationData srcloc, int depth, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin_alloc")]
        public partial TracyCZoneContext TracyEmitZoneBeginAlloc(ulong srcloc, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 233, Column 25 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_begin_alloc_callstack")]
        public partial TracyCZoneContext TracyEmitZoneBeginAllocCallstack(ulong srcloc, int depth, int active);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_end")]
        public partial void TracyEmitZoneEnd(TracyCZoneContext ctx);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_text")]
        public unsafe partial void TracyEmitZoneText(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_text")]
        public partial void TracyEmitZoneText(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 235, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_text")]
        public partial void TracyEmitZoneText(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_name")]
        public unsafe partial void TracyEmitZoneName(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_name")]
        public partial void TracyEmitZoneName(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_name")]
        public partial void TracyEmitZoneName(TracyCZoneContext ctx, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 237, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_color")]
        public partial void TracyEmitZoneColor(TracyCZoneContext ctx, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 238, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_zone_value")]
        public partial void TracyEmitZoneValue(TracyCZoneContext ctx, ulong value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 240, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin")]
        public partial void TracyEmitGpuZoneBegin(TracyGpuZoneBeginData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 241, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_callstack")]
        public partial void TracyEmitGpuZoneBeginCallstack(TracyGpuZoneBeginCallstackData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 242, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_alloc")]
        public partial void TracyEmitGpuZoneBeginAlloc(TracyGpuZoneBeginData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 243, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_alloc_callstack")]
        public partial void TracyEmitGpuZoneBeginAllocCallstack(TracyGpuZoneBeginCallstackData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 244, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_end")]
        public partial void TracyEmitGpuZoneEnd(TracyGpuZoneEndData data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 245, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_time")]
        public partial void TracyEmitGpuTime(TracyGpuTimeData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_new_context")]
        public partial void TracyEmitGpuNewContext(TracyGpuNewContextData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_context_name")]
        public partial void TracyEmitGpuContextName(TracyGpuContextNameData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 248, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_calibration")]
        public partial void TracyEmitGpuCalibration(TracyGpuCalibrationData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 249, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_time_sync")]
        public partial void TracyEmitGpuTimeSync(TracyGpuTimeSyncData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 251, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_serial")]
        public partial void TracyEmitGpuZoneBeginSerial(TracyGpuZoneBeginData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 252, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_callstack_serial")]
        public partial void TracyEmitGpuZoneBeginCallstackSerial(TracyGpuZoneBeginCallstackData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_alloc_serial")]
        public partial void TracyEmitGpuZoneBeginAllocSerial(TracyGpuZoneBeginData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_begin_alloc_callstack_serial")]
        public partial void TracyEmitGpuZoneBeginAllocCallstackSerial(TracyGpuZoneBeginCallstackData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 255, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_zone_end_serial")]
        public partial void TracyEmitGpuZoneEndSerial(TracyGpuZoneEndData data);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_time_serial")]
        public partial void TracyEmitGpuTimeSerial(TracyGpuTimeData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_new_context_serial")]
        public partial void TracyEmitGpuNewContextSerial(TracyGpuNewContextData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_context_name_serial")]
        public partial void TracyEmitGpuContextNameSerial(TracyGpuContextNameData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 259, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_calibration_serial")]
        public partial void TracyEmitGpuCalibrationSerial(TracyGpuCalibrationData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_gpu_time_sync_serial")]
        public partial void TracyEmitGpuTimeSyncSerial(TracyGpuTimeSyncData arg0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 262, Column 19 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_connected")]
        public partial int TracyConnected();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc")]
        public unsafe partial void TracyEmitMemoryAlloc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 281, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc")]
        public partial void TracyEmitMemoryAlloc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int secure) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack")]
        public unsafe partial void TracyEmitMemoryAllocCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack")]
        public partial void TracyEmitMemoryAllocCallstack<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int depth, int secure) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free")]
        public unsafe partial void TracyEmitMemoryFree([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 283, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free")]
        public partial void TracyEmitMemoryFree<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int secure) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack")]
        public unsafe partial void TracyEmitMemoryFreeCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 284, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack")]
        public partial void TracyEmitMemoryFreeCallstack<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int depth, int secure) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public unsafe partial void TracyEmitMemoryAllocNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public unsafe partial void TracyEmitMemoryAllocNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public unsafe partial void TracyEmitMemoryAllocNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public unsafe partial void TracyEmitMemoryAllocNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public partial void TracyEmitMemoryAllocNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 285, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_named")]
        public partial void TracyEmitMemoryAllocNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public unsafe partial void TracyEmitMemoryAllocCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public unsafe partial void TracyEmitMemoryAllocCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public unsafe partial void TracyEmitMemoryAllocCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public unsafe partial void TracyEmitMemoryAllocCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public partial void TracyEmitMemoryAllocCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 286, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_alloc_callstack_named")]
        public partial void TracyEmitMemoryAllocCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, nuint size, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public unsafe partial void TracyEmitMemoryFreeNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public unsafe partial void TracyEmitMemoryFreeNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public unsafe partial void TracyEmitMemoryFreeNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public unsafe partial void TracyEmitMemoryFreeNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public partial void TracyEmitMemoryFreeNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 287, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_named")]
        public partial void TracyEmitMemoryFreeNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public unsafe partial void TracyEmitMemoryFreeCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public unsafe partial void TracyEmitMemoryFreeCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public unsafe partial void TracyEmitMemoryFreeCallstackNamed([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public unsafe partial void TracyEmitMemoryFreeCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public partial void TracyEmitMemoryFreeCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_free_callstack_named")]
        public partial void TracyEmitMemoryFreeCallstackNamed<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 ptr, int depth, int secure, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 289, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard")]
        public unsafe partial void TracyEmitMemoryDiscard([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 289, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard")]
        public partial void TracyEmitMemoryDiscard([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 289, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard")]
        public partial void TracyEmitMemoryDiscard([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int secure);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard_callstack")]
        public unsafe partial void TracyEmitMemoryDiscardCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int secure, int depth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard_callstack")]
        public partial void TracyEmitMemoryDiscardCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, int secure, int depth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 290, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_memory_discard_callstack")]
        public partial void TracyEmitMemoryDiscardCallstack([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int secure, int depth);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logString")]
        public unsafe partial void TracyEmitLogString(byte severity, int color, int callstack_depth, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logString")]
        public partial void TracyEmitLogString(byte severity, int color, int callstack_depth, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 292, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logString")]
        public partial void TracyEmitLogString(byte severity, int color, int callstack_depth, nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 293, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logStringL")]
        public unsafe partial void TracyEmitLogStringL(byte severity, int color, int callstack_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 293, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logStringL")]
        public partial void TracyEmitLogStringL(byte severity, int color, int callstack_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 293, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_logStringL")]
        public partial void TracyEmitLogStringL(byte severity, int color, int callstack_depth, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string txt);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark")]
        public unsafe partial void TracyEmitFrameMark([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark")]
        public partial void TracyEmitFrameMark([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark")]
        public partial void TracyEmitFrameMark([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_start")]
        public unsafe partial void TracyEmitFrameMarkStart([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_start")]
        public partial void TracyEmitFrameMarkStart([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 314, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_start")]
        public partial void TracyEmitFrameMarkStart([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_end")]
        public unsafe partial void TracyEmitFrameMarkEnd([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_end")]
        public partial void TracyEmitFrameMarkEnd([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_mark_end")]
        public partial void TracyEmitFrameMarkEnd([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_image")]
        public unsafe partial void TracyEmitFrameImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* image, ushort w, ushort h, byte offset, int flip);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_frame_image")]
        public partial void TracyEmitFrameImage<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 image, ushort w, ushort h, byte offset, int flip) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot")]
        public unsafe partial void TracyEmitPlot([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, double val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot")]
        public partial void TracyEmitPlot([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, double val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot")]
        public partial void TracyEmitPlot([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, double val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_float")]
        public unsafe partial void TracyEmitPlotFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, float val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_float")]
        public partial void TracyEmitPlotFloat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, float val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_float")]
        public partial void TracyEmitPlotFloat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, float val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_int")]
        public unsafe partial void TracyEmitPlotInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, long val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_int")]
        public partial void TracyEmitPlotInt([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, long val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 327, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_int")]
        public partial void TracyEmitPlotInt([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, long val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_config")]
        public unsafe partial void TracyEmitPlotConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, int type, int step, int fill, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_config")]
        public partial void TracyEmitPlotConfig([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, int type, int step, int fill, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 328, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_plot_config")]
        public partial void TracyEmitPlotConfig([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, int type, int step, int fill, uint color);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 329, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_message_appinfo")]
        public unsafe partial void TracyEmitMessageAppinfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 329, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_message_appinfo")]
        public partial void TracyEmitMessageAppinfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 329, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_emit_message_appinfo")]
        public partial void TracyEmitMessageAppinfo([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string txt, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 49 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_announce_lockable_ctx")]
        public unsafe partial TracyLockableContextData* TracyAnnounceLockableCtx([Flow(Silk.NET.Core.Native.FlowDirection.In)] TracySourceLocationData* srcloc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 49 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_announce_lockable_ctx")]
        public unsafe partial TracyLockableContextData* TracyAnnounceLockableCtx([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TracySourceLocationData srcloc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_terminate_lockable_ctx")]
        public unsafe partial void TracyTerminateLockableCtx(TracyLockableContextData* lockdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 363, Column 19 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_before_lock_lockable_ctx")]
        public unsafe partial int TracyBeforeLockLockableCtx(TracyLockableContextData* lockdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_after_lock_lockable_ctx")]
        public unsafe partial void TracyAfterLockLockableCtx(TracyLockableContextData* lockdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_after_unlock_lockable_ctx")]
        public unsafe partial void TracyAfterUnlockLockableCtx(TracyLockableContextData* lockdata);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_after_try_lock_lockable_ctx")]
        public unsafe partial void TracyAfterTryLockLockableCtx(TracyLockableContextData* lockdata, int acquired);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 367, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_mark_lockable_ctx")]
        public unsafe partial void TracyMarkLockableCtx(TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TracySourceLocationData* srcloc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 367, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_mark_lockable_ctx")]
        public unsafe partial void TracyMarkLockableCtx(TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly TracySourceLocationData srcloc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_custom_name_lockable_ctx")]
        public unsafe partial void TracyCustomNameLockableCtx(TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, nuint nameSz);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_custom_name_lockable_ctx")]
        public unsafe partial void TracyCustomNameLockableCtx(TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly byte name, nuint nameSz);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_custom_name_lockable_ctx")]
        public unsafe partial void TracyCustomNameLockableCtx(TracyLockableContextData* lockdata, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, nuint nameSz);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 15 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_begin_sampling_profiler")]
        public partial int TracyBeginSamplingProfiler();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 16 in TracyC.h")]
        [NativeApi(EntryPoint = "___tracy_end_sampling_profiler")]
        public partial void TracyEndSamplingProfiler();


        public Tracy(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

