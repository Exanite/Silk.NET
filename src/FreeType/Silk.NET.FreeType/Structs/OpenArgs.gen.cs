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
    [NativeName("Name", "FT_Open_Args_")]
    public unsafe partial struct OpenArgs
    {
        public OpenArgs
        (
            uint? flags = null,
            byte* memoryBase = null,
            int? memorySize = null,
            byte* pathname = null,
            StreamRec* stream = null,
            ModuleRec* driver = null,
            int? numParams = null,
            Parameter* @params = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (memoryBase is not null)
            {
                MemoryBase = memoryBase;
            }

            if (memorySize is not null)
            {
                MemorySize = memorySize.Value;
            }

            if (pathname is not null)
            {
                Pathname = pathname;
            }

            if (stream is not null)
            {
                Stream = stream;
            }

            if (driver is not null)
            {
                Driver = driver;
            }

            if (numParams is not null)
            {
                NumParams = numParams.Value;
            }

            if (@params is not null)
            {
                Params = @params;
            }
        }


        [NativeName("Type", "FT_UInt")]
        [NativeName("Type.Name", "FT_UInt")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "const FT_Byte *")]
        [NativeName("Type.Name", "const FT_Byte *")]
        [NativeName("Name", "memory_base")]
        public byte* MemoryBase;

        [NativeName("Type", "FT_Long")]
        [NativeName("Type.Name", "FT_Long")]
        [NativeName("Name", "memory_size")]
        public int MemorySize;

        [NativeName("Type", "FT_String *")]
        [NativeName("Type.Name", "FT_String *")]
        [NativeName("Name", "pathname")]
        public byte* Pathname;

        [NativeName("Type", "FT_Stream")]
        [NativeName("Type.Name", "FT_Stream")]
        [NativeName("Name", "stream")]
        public StreamRec* Stream;

        [NativeName("Type", "FT_Module")]
        [NativeName("Type.Name", "FT_Module")]
        [NativeName("Name", "driver")]
        public ModuleRec* Driver;

        [NativeName("Type", "FT_Int")]
        [NativeName("Type.Name", "FT_Int")]
        [NativeName("Name", "num_params")]
        public int NumParams;

        [NativeName("Type", "FT_Parameter *")]
        [NativeName("Type.Name", "FT_Parameter *")]
        [NativeName("Name", "params")]
        public Parameter* Params;
    }
}
