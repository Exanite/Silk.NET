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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_slang_L4864_C5")]
    public unsafe partial struct SpecializationArgUnion
    {
        public SpecializationArgUnion
        (
            TypeReflection* type = null,
            byte* expr = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type;
            }

            if (expr is not null)
            {
                Expr = expr;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "slang::TypeReflection *")]
        [NativeName("Type.Name", "slang::TypeReflection *")]
        [NativeName("Name", "type")]
        public TypeReflection* Type;

        [FieldOffset(0)]
        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "expr")]
        public byte* Expr;
    }
}
