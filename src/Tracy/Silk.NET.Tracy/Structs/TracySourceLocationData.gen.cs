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
    [NativeName("Name", "___tracy_source_location_data")]
    public unsafe partial struct TracySourceLocationData
    {
        public TracySourceLocationData
        (
            byte* name = null,
            byte* function = null,
            byte* file = null,
            uint? line = null,
            uint? color = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (function is not null)
            {
                Function = function;
            }

            if (file is not null)
            {
                File = file;
            }

            if (line is not null)
            {
                Line = line.Value;
            }

            if (color is not null)
            {
                Color = color.Value;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "function")]
        public byte* Function;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "file")]
        public byte* File;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "line")]
        public uint Line;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "color")]
        public uint Color;
    }
}
