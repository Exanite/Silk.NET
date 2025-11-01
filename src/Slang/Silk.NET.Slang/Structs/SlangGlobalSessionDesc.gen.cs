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
    [NativeName("Name", "SlangGlobalSessionDesc")]
    public unsafe partial struct SlangGlobalSessionDesc
    {
        public SlangGlobalSessionDesc
        (
            uint? structureSize = null,
            uint? apiVersion = null,
            uint? minLanguageVersion = null,
            bool? enableGLSL = null
        ) : this()
        {
            if (structureSize is not null)
            {
                StructureSize = structureSize.Value;
            }

            if (apiVersion is not null)
            {
                ApiVersion = apiVersion.Value;
            }

            if (minLanguageVersion is not null)
            {
                MinLanguageVersion = minLanguageVersion.Value;
            }

            if (enableGLSL is not null)
            {
                EnableGLSL = enableGLSL.Value;
            }
        }


        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "structureSize")]
        public uint StructureSize;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "apiVersion")]
        public uint ApiVersion;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minLanguageVersion")]
        public uint MinLanguageVersion;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "enableGLSL")]
        public bool EnableGLSL;
        [NativeName("Type", "uint32_t[16]")]
        [NativeName("Type.Name", "uint32_t[16]")]
        [NativeName("Name", "reserved")]
        public fixed uint Reserved[16];
    }
}
