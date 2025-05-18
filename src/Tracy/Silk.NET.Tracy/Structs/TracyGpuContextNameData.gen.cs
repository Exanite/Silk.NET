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
    [NativeName("Name", "___tracy_gpu_context_name_data")]
    public unsafe partial struct TracyGpuContextNameData
    {
        public TracyGpuContextNameData
        (
            byte? context = null,
            byte* name = null,
            ushort? len = null
        ) : this()
        {
            if (context is not null)
            {
                Context = context.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (len is not null)
            {
                Len = len.Value;
            }
        }


        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "context")]
        public byte Context;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "len")]
        public ushort Len;
    }
}
