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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "FT_StreamDesc_")]
    public unsafe partial struct StreamDesc
    {
        public StreamDesc
        (
            int? value = null,
            void* pointer = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }

            if (pointer is not null)
            {
                Pointer = pointer;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "long")]
        [NativeName("Type.Name", "long")]
        [NativeName("Name", "value")]
        public int Value;

        [FieldOffset(0)]
        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pointer")]
        public void* Pointer;
    }
}
