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
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        public static unsafe int SlangCreateGlobalSession2(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangGlobalSessionDesc> desc, IGlobalSession** outGlobalSession)
        {
            // SpanOverloader
            return thisApi.SlangCreateGlobalSession2(in desc.GetPinnableReference(), outGlobalSession);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        public static unsafe int SlangCreateGlobalSession2(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SlangGlobalSessionDesc> desc, ref IGlobalSession* outGlobalSession)
        {
            // SpanOverloader
            return thisApi.SlangCreateGlobalSession2(in desc.GetPinnableReference(), ref outGlobalSession);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        public static unsafe int SlangCreateByteCodeRunner(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ByteCodeRunnerDesc> desc, IByteCodeRunner** outByteCodeRunner)
        {
            // SpanOverloader
            return thisApi.SlangCreateByteCodeRunner(in desc.GetPinnableReference(), outByteCodeRunner);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        public static unsafe int SlangCreateByteCodeRunner(this Slang thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ByteCodeRunnerDesc> desc, ref IByteCodeRunner* outByteCodeRunner)
        {
            // SpanOverloader
            return thisApi.SlangCreateByteCodeRunner(in desc.GetPinnableReference(), ref outByteCodeRunner);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        public static unsafe int SlangDisassembleByteCode(this Slang thisApi, Span<IBlob> moduleBlob, IBlob** outDisassemblyBlob)
        {
            // SpanOverloader
            return thisApi.SlangDisassembleByteCode(ref moduleBlob.GetPinnableReference(), outDisassemblyBlob);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        public static unsafe int SlangDisassembleByteCode(this Slang thisApi, Span<IBlob> moduleBlob, ref IBlob* outDisassemblyBlob)
        {
            // SpanOverloader
            return thisApi.SlangDisassembleByteCode(ref moduleBlob.GetPinnableReference(), ref outDisassemblyBlob);
        }

    }
}

