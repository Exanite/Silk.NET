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
    [NativeName("Name", "FT_Data_")]
    public unsafe partial struct Data
    {
        public Data
        (
            byte* pointer = null,
            uint? length = null
        ) : this()
        {
            if (pointer is not null)
            {
                Pointer = pointer;
            }

            if (length is not null)
            {
                Length = length.Value;
            }
        }


        [NativeName("Type", "const FT_Byte *")]
        [NativeName("Type.Name", "const FT_Byte *")]
        [NativeName("Name", "pointer")]
        public byte* Pointer;

        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "length")]
        public uint Length;
    }
}
