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
    [NativeName("Name", "SpecializationArg")]
    public unsafe partial struct SpecializationArg
    {
        public SpecializationArg
        (
            Kind? kind = null,
            SpecializationArgUnion? anonymous = null,
            TypeReflection* type = null,
            byte* expr = null
        ) : this()
        {
            if (kind is not null)
            {
                Kind = kind.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (type is not null)
            {
                Type = type;
            }

            if (expr is not null)
            {
                Expr = expr;
            }
        }


        [NativeName("Type", "slang::SpecializationArg::Kind")]
        [NativeName("Type.Name", "slang::SpecializationArg::Kind")]
        [NativeName("Name", "kind")]
        public Kind Kind;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_slang_L4652_C5")]
        [NativeName("Name", "anonymous1")]
        public SpecializationArgUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TypeReflection* Type
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Type;
        }
#else
        public TypeReflection* Type
        {
            get => Anonymous.Type;
            set => Anonymous.Type = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte* Expr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Expr;
        }
#else
        public byte* Expr
        {
            get => Anonymous.Expr;
            set => Anonymous.Expr = value;
        }
#endif

    }
}
