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
    [NativeName("Name", "CompilerOptionValue")]
    public unsafe partial struct CompilerOptionValue
    {
        public CompilerOptionValue
        (
            CompilerOptionValueKind? kind = null,
            int? intValue0 = null,
            int? intValue1 = null,
            byte* stringValue0 = null,
            byte* stringValue1 = null
        ) : this()
        {
            if (kind is not null)
            {
                Kind = kind.Value;
            }

            if (intValue0 is not null)
            {
                IntValue0 = intValue0.Value;
            }

            if (intValue1 is not null)
            {
                IntValue1 = intValue1.Value;
            }

            if (stringValue0 is not null)
            {
                StringValue0 = stringValue0;
            }

            if (stringValue1 is not null)
            {
                StringValue1 = stringValue1;
            }
        }


        [NativeName("Type", "slang::CompilerOptionValueKind")]
        [NativeName("Type.Name", "slang::CompilerOptionValueKind")]
        [NativeName("Name", "kind")]
        public CompilerOptionValueKind Kind;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "intValue0")]
        public int IntValue0;

        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "intValue1")]
        public int IntValue1;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "stringValue0")]
        public byte* StringValue0;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "stringValue1")]
        public byte* StringValue1;
    }
}
