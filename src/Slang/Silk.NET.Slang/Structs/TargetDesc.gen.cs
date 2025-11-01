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
    [NativeName("Name", "TargetDesc")]
    public unsafe partial struct TargetDesc
    {
        public TargetDesc
        (
            nuint? structureSize = null,
            SlangCompileTarget? format = null,
            SlangProfileID? profile = null,
            uint? flags = null,
            SlangFloatingPointMode? floatingPointMode = null,
            SlangLineDirectiveMode? lineDirectiveMode = null,
            bool? forceGLSLScalarBufferLayout = null,
            CompilerOptionEntry* compilerOptionEntries = null,
            uint? compilerOptionEntryCount = null
        ) : this()
        {
            if (structureSize is not null)
            {
                StructureSize = structureSize.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (profile is not null)
            {
                Profile = profile.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (floatingPointMode is not null)
            {
                FloatingPointMode = floatingPointMode.Value;
            }

            if (lineDirectiveMode is not null)
            {
                LineDirectiveMode = lineDirectiveMode.Value;
            }

            if (forceGLSLScalarBufferLayout is not null)
            {
                ForceGLSLScalarBufferLayout = forceGLSLScalarBufferLayout.Value;
            }

            if (compilerOptionEntries is not null)
            {
                CompilerOptionEntries = compilerOptionEntries;
            }

            if (compilerOptionEntryCount is not null)
            {
                CompilerOptionEntryCount = compilerOptionEntryCount.Value;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "structureSize")]
        public nuint StructureSize;

        [NativeName("Type", "SlangCompileTarget")]
        [NativeName("Type.Name", "SlangCompileTarget")]
        [NativeName("Name", "format")]
        public SlangCompileTarget Format;

        [NativeName("Type", "SlangProfileID")]
        [NativeName("Type.Name", "SlangProfileID")]
        [NativeName("Name", "profile")]
        public SlangProfileID Profile;

        [NativeName("Type", "SlangTargetFlags")]
        [NativeName("Type.Name", "SlangTargetFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "SlangFloatingPointMode")]
        [NativeName("Type.Name", "SlangFloatingPointMode")]
        [NativeName("Name", "floatingPointMode")]
        public SlangFloatingPointMode FloatingPointMode;

        [NativeName("Type", "SlangLineDirectiveMode")]
        [NativeName("Type.Name", "SlangLineDirectiveMode")]
        [NativeName("Name", "lineDirectiveMode")]
        public SlangLineDirectiveMode LineDirectiveMode;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "forceGLSLScalarBufferLayout")]
        public bool ForceGLSLScalarBufferLayout;

        [NativeName("Type", "const slang::CompilerOptionEntry *")]
        [NativeName("Type.Name", "const slang::CompilerOptionEntry *")]
        [NativeName("Name", "compilerOptionEntries")]
        public CompilerOptionEntry* CompilerOptionEntries;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "compilerOptionEntryCount")]
        public uint CompilerOptionEntryCount;
    }
}
