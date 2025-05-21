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
    [NativeName("Name", "SlangUUID")]
    public unsafe partial struct SlangUUID
    {
        public SlangUUID
        (
            uint? data1 = null,
            ushort? data2 = null,
            ushort? data3 = null
        ) : this()
        {
            if (data1 is not null)
            {
                Data1 = data1.Value;
            }

            if (data2 is not null)
            {
                Data2 = data2.Value;
            }

            if (data3 is not null)
            {
                Data3 = data3.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "data1")]
        public uint Data1;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "data2")]
        public ushort Data2;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "data3")]
        public ushort Data3;
        [NativeName("Type", "uint8_t[8]")]
        [NativeName("Type.Name", "uint8_t[8]")]
        [NativeName("Name", "data4")]
        public fixed byte Data4[8];
    }
}
