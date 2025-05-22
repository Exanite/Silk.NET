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
    [NativeName("Name", "SessionDesc")]
    public unsafe partial struct SessionDesc
    {
        public SessionDesc
        (
            nuint? structureSize = null,
            TargetDesc* targets = null,
            long? targetCount = null,
            uint? flags = null,
            MatrixLayoutMode? defaultMatrixLayoutMode = null,
            byte** searchPaths = null,
            long? searchPathCount = null,
            PreprocessorMacroDesc* preprocessorMacros = null,
            long? preprocessorMacroCount = null,
            IFileSystem* fileSystem = null,
            bool? enableEffectAnnotations = null,
            bool? allowGLSLSyntax = null,
            CompilerOptionEntry* compilerOptionEntries = null,
            uint? compilerOptionEntryCount = null,
            bool? skipSPIRVValidation = null
        ) : this()
        {
            if (structureSize is not null)
            {
                StructureSize = structureSize.Value;
            }

            if (targets is not null)
            {
                Targets = targets;
            }

            if (targetCount is not null)
            {
                TargetCount = targetCount.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (defaultMatrixLayoutMode is not null)
            {
                DefaultMatrixLayoutMode = defaultMatrixLayoutMode.Value;
            }

            if (searchPaths is not null)
            {
                SearchPaths = searchPaths;
            }

            if (searchPathCount is not null)
            {
                SearchPathCount = searchPathCount.Value;
            }

            if (preprocessorMacros is not null)
            {
                PreprocessorMacros = preprocessorMacros;
            }

            if (preprocessorMacroCount is not null)
            {
                PreprocessorMacroCount = preprocessorMacroCount.Value;
            }

            if (fileSystem is not null)
            {
                FileSystem = fileSystem;
            }

            if (enableEffectAnnotations is not null)
            {
                EnableEffectAnnotations = enableEffectAnnotations.Value;
            }

            if (allowGLSLSyntax is not null)
            {
                AllowGLSLSyntax = allowGLSLSyntax.Value;
            }

            if (compilerOptionEntries is not null)
            {
                CompilerOptionEntries = compilerOptionEntries;
            }

            if (compilerOptionEntryCount is not null)
            {
                CompilerOptionEntryCount = compilerOptionEntryCount.Value;
            }

            if (skipSPIRVValidation is not null)
            {
                SkipSPIRVValidation = skipSPIRVValidation.Value;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "structureSize")]
        public nuint StructureSize;

        [NativeName("Type", "const slang::TargetDesc *")]
        [NativeName("Type.Name", "const slang::TargetDesc *")]
        [NativeName("Name", "targets")]
        public TargetDesc* Targets;

        [NativeName("Type", "SlangInt")]
        [NativeName("Type.Name", "SlangInt")]
        [NativeName("Name", "targetCount")]
        public long TargetCount;

        [NativeName("Type", "slang::SessionFlags")]
        [NativeName("Type.Name", "slang::SessionFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;

        [NativeName("Type", "SlangMatrixLayoutMode")]
        [NativeName("Type.Name", "SlangMatrixLayoutMode")]
        [NativeName("Name", "defaultMatrixLayoutMode")]
        public MatrixLayoutMode DefaultMatrixLayoutMode;

        [NativeName("Type", "const char *const *")]
        [NativeName("Type.Name", "const char *const *")]
        [NativeName("Name", "searchPaths")]
        public byte** SearchPaths;

        [NativeName("Type", "SlangInt")]
        [NativeName("Type.Name", "SlangInt")]
        [NativeName("Name", "searchPathCount")]
        public long SearchPathCount;

        [NativeName("Type", "const slang::PreprocessorMacroDesc *")]
        [NativeName("Type.Name", "const slang::PreprocessorMacroDesc *")]
        [NativeName("Name", "preprocessorMacros")]
        public PreprocessorMacroDesc* PreprocessorMacros;

        [NativeName("Type", "SlangInt")]
        [NativeName("Type.Name", "SlangInt")]
        [NativeName("Name", "preprocessorMacroCount")]
        public long PreprocessorMacroCount;

        [NativeName("Type", "ISlangFileSystem *")]
        [NativeName("Type.Name", "ISlangFileSystem *")]
        [NativeName("Name", "fileSystem")]
        public IFileSystem* FileSystem;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "enableEffectAnnotations")]
        public bool EnableEffectAnnotations;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "allowGLSLSyntax")]
        public bool AllowGLSLSyntax;

        [NativeName("Type", "slang::CompilerOptionEntry *")]
        [NativeName("Type.Name", "slang::CompilerOptionEntry *")]
        [NativeName("Name", "compilerOptionEntries")]
        public CompilerOptionEntry* CompilerOptionEntries;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "compilerOptionEntryCount")]
        public uint CompilerOptionEntryCount;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "skipSPIRVValidation")]
        public bool SkipSPIRVValidation;
    }
}
