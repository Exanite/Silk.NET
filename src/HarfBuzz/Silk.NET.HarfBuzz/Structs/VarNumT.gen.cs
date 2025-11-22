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

namespace Silk.NET.HarfBuzz
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "_hb_var_num_t")]
    public unsafe partial struct VarNumT
    {
        public VarNumT
        (
            float? f = null,
            uint? u32 = null,
            int? i32 = null
        ) : this()
        {
            if (f is not null)
            {
                F = f.Value;
            }

            if (u32 is not null)
            {
                U32 = u32.Value;
            }

            if (i32 is not null)
            {
                I32 = i32.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "f")]
        public float F;

        [FieldOffset(0)]
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "u32")]
        public uint U32;

        [FieldOffset(0)]
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "i32")]
        public int I32;
        [FieldOffset(0)]
        [NativeName("Type", "uint16_t[2]")]
        [NativeName("Type.Name", "uint16_t[2]")]
        [NativeName("Name", "u16")]
        public fixed ushort U16[2];
        [FieldOffset(0)]
        [NativeName("Type", "int16_t[2]")]
        [NativeName("Type.Name", "int16_t[2]")]
        [NativeName("Name", "i16")]
        public fixed short I16[2];
        [FieldOffset(0)]
        [NativeName("Type", "uint8_t[4]")]
        [NativeName("Type.Name", "uint8_t[4]")]
        [NativeName("Name", "u8")]
        public fixed byte U8[4];
        [FieldOffset(0)]
        [NativeName("Type", "int8_t[4]")]
        [NativeName("Type.Name", "int8_t[4]")]
        [NativeName("Name", "i8")]
        public fixed byte I8[4];
    }
}
