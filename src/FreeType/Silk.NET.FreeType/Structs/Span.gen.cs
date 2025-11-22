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
    [NativeName("Name", "FT_Span_")]
    public unsafe partial struct Span
    {
        public Span
        (
            short? x = null,
            ushort? len = null,
            byte? coverage = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (len is not null)
            {
                Len = len.Value;
            }

            if (coverage is not null)
            {
                Coverage = coverage.Value;
            }
        }


        [NativeName("Type", "short")]
        [NativeName("Type.Name", "short")]
        [NativeName("Name", "x")]
        public short X;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "len")]
        public ushort Len;

        [NativeName("Type", "unsigned char")]
        [NativeName("Type.Name", "unsigned char")]
        [NativeName("Name", "coverage")]
        public byte Coverage;
    }
}
