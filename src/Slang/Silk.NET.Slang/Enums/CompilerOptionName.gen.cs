// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "CompilerOptionName")]
    public enum CompilerOptionName : int
    {
        [NativeName("Name", "MacroDefine")]
        MacroDefine = 0x0,
        [NativeName("Name", "DepFile")]
        DepFile = 0x1,
        [NativeName("Name", "EntryPointName")]
        EntryPointName = 0x2,
        [NativeName("Name", "Specialize")]
        Specialize = 0x3,
        [NativeName("Name", "Help")]
        Help = 0x4,
        [NativeName("Name", "HelpStyle")]
        HelpStyle = 0x5,
        [NativeName("Name", "Include")]
        Include = 0x6,
        [NativeName("Name", "Language")]
        Language = 0x7,
        [NativeName("Name", "MatrixLayoutColumn")]
        MatrixLayoutColumn = 0x8,
        [NativeName("Name", "MatrixLayoutRow")]
        MatrixLayoutRow = 0x9,
        [NativeName("Name", "ZeroInitialize")]
        ZeroInitialize = 0xA,
        [NativeName("Name", "IgnoreCapabilities")]
        IgnoreCapabilities = 0xB,
        [NativeName("Name", "RestrictiveCapabilityCheck")]
        RestrictiveCapabilityCheck = 0xC,
        [NativeName("Name", "ModuleName")]
        ModuleName = 0xD,
        [NativeName("Name", "Output")]
        Output = 0xE,
        [NativeName("Name", "Profile")]
        Profile = 0xF,
        [NativeName("Name", "Stage")]
        Stage = 0x10,
        [NativeName("Name", "Target")]
        Target = 0x11,
        [NativeName("Name", "Version")]
        Version = 0x12,
        [NativeName("Name", "WarningsAsErrors")]
        WarningsAsErrors = 0x13,
        [NativeName("Name", "DisableWarnings")]
        DisableWarnings = 0x14,
        [NativeName("Name", "EnableWarning")]
        EnableWarning = 0x15,
        [NativeName("Name", "DisableWarning")]
        DisableWarning = 0x16,
        [NativeName("Name", "DumpWarningDiagnostics")]
        DumpWarningDiagnostics = 0x17,
        [NativeName("Name", "InputFilesRemain")]
        InputFilesRemain = 0x18,
        [NativeName("Name", "EmitIr")]
        EmitIr = 0x19,
        [NativeName("Name", "ReportDownstreamTime")]
        ReportDownstreamTime = 0x1A,
        [NativeName("Name", "ReportPerfBenchmark")]
        ReportPerfBenchmark = 0x1B,
        [NativeName("Name", "ReportCheckpointIntermediates")]
        ReportCheckpointIntermediates = 0x1C,
        [NativeName("Name", "SkipSPIRVValidation")]
        SkipSpirvvalidation = 0x1D,
        [NativeName("Name", "SourceEmbedStyle")]
        SourceEmbedStyle = 0x1E,
        [NativeName("Name", "SourceEmbedName")]
        SourceEmbedName = 0x1F,
        [NativeName("Name", "SourceEmbedLanguage")]
        SourceEmbedLanguage = 0x20,
        [NativeName("Name", "DisableShortCircuit")]
        DisableShortCircuit = 0x21,
        [NativeName("Name", "MinimumSlangOptimization")]
        MinimumSlangOptimization = 0x22,
        [NativeName("Name", "DisableNonEssentialValidations")]
        DisableNonEssentialValidations = 0x23,
        [NativeName("Name", "DisableSourceMap")]
        DisableSourceMap = 0x24,
        [NativeName("Name", "UnscopedEnum")]
        UnscopedEnum = 0x25,
        [NativeName("Name", "PreserveParameters")]
        PreserveParameters = 0x26,
        [NativeName("Name", "Capability")]
        Capability = 0x27,
        [NativeName("Name", "DefaultImageFormatUnknown")]
        DefaultImageFormatUnknown = 0x28,
        [NativeName("Name", "DisableDynamicDispatch")]
        DisableDynamicDispatch = 0x29,
        [NativeName("Name", "DisableSpecialization")]
        DisableSpecialization = 0x2A,
        [NativeName("Name", "FloatingPointMode")]
        FloatingPointMode = 0x2B,
        [NativeName("Name", "DebugInformation")]
        DebugInformation = 0x2C,
        [NativeName("Name", "LineDirectiveMode")]
        LineDirectiveMode = 0x2D,
        [NativeName("Name", "Optimization")]
        Optimization = 0x2E,
        [NativeName("Name", "Obfuscate")]
        Obfuscate = 0x2F,
        [NativeName("Name", "VulkanBindShift")]
        VulkanBindShift = 0x30,
        [NativeName("Name", "VulkanBindGlobals")]
        VulkanBindGlobals = 0x31,
        [NativeName("Name", "VulkanInvertY")]
        VulkanInvertY = 0x32,
        [NativeName("Name", "VulkanUseDxPositionW")]
        VulkanUseDxPositionW = 0x33,
        [NativeName("Name", "VulkanUseEntryPointName")]
        VulkanUseEntryPointName = 0x34,
        [NativeName("Name", "VulkanUseGLLayout")]
        VulkanUseGllayout = 0x35,
        [NativeName("Name", "VulkanEmitReflection")]
        VulkanEmitReflection = 0x36,
        [NativeName("Name", "GLSLForceScalarLayout")]
        GlslforceScalarLayout = 0x37,
        [NativeName("Name", "EnableEffectAnnotations")]
        EnableEffectAnnotations = 0x38,
        [NativeName("Name", "EmitSpirvViaGLSL")]
        EmitSpirvViaGlsl = 0x39,
        [NativeName("Name", "EmitSpirvDirectly")]
        EmitSpirvDirectly = 0x3A,
        [NativeName("Name", "SPIRVCoreGrammarJSON")]
        SpirvcoreGrammarJson = 0x3B,
        [NativeName("Name", "IncompleteLibrary")]
        IncompleteLibrary = 0x3C,
        [NativeName("Name", "CompilerPath")]
        CompilerPath = 0x3D,
        [NativeName("Name", "DefaultDownstreamCompiler")]
        DefaultDownstreamCompiler = 0x3E,
        [NativeName("Name", "DownstreamArgs")]
        DownstreamArgs = 0x3F,
        [NativeName("Name", "PassThrough")]
        PassThrough = 0x40,
        [NativeName("Name", "DumpRepro")]
        DumpRepro = 0x41,
        [NativeName("Name", "DumpReproOnError")]
        DumpReproOnError = 0x42,
        [NativeName("Name", "ExtractRepro")]
        ExtractRepro = 0x43,
        [NativeName("Name", "LoadRepro")]
        LoadRepro = 0x44,
        [NativeName("Name", "LoadReproDirectory")]
        LoadReproDirectory = 0x45,
        [NativeName("Name", "ReproFallbackDirectory")]
        ReproFallbackDirectory = 0x46,
        [NativeName("Name", "DumpAst")]
        DumpAst = 0x47,
        [NativeName("Name", "DumpIntermediatePrefix")]
        DumpIntermediatePrefix = 0x48,
        [NativeName("Name", "DumpIntermediates")]
        DumpIntermediates = 0x49,
        [NativeName("Name", "DumpIr")]
        DumpIr = 0x4A,
        [NativeName("Name", "DumpIrIds")]
        DumpIrIds = 0x4B,
        [NativeName("Name", "PreprocessorOutput")]
        PreprocessorOutput = 0x4C,
        [NativeName("Name", "OutputIncludes")]
        OutputIncludes = 0x4D,
        [NativeName("Name", "ReproFileSystem")]
        ReproFileSystem = 0x4E,
        [NativeName("Name", "REMOVED_SerialIR")]
        RemovedSerialIR = 0x4F,
        [NativeName("Name", "SkipCodeGen")]
        SkipCodeGen = 0x50,
        [NativeName("Name", "ValidateIr")]
        ValidateIr = 0x51,
        [NativeName("Name", "VerbosePaths")]
        VerbosePaths = 0x52,
        [NativeName("Name", "VerifyDebugSerialIr")]
        VerifyDebugSerialIr = 0x53,
        [NativeName("Name", "NoCodeGen")]
        NoCodeGen = 0x54,
        [NativeName("Name", "FileSystem")]
        FileSystem = 0x55,
        [NativeName("Name", "Heterogeneous")]
        Heterogeneous = 0x56,
        [NativeName("Name", "NoMangle")]
        NoMangle = 0x57,
        [NativeName("Name", "NoHLSLBinding")]
        NoHlslbinding = 0x58,
        [NativeName("Name", "NoHLSLPackConstantBufferElements")]
        NoHlslpackConstantBufferElements = 0x59,
        [NativeName("Name", "ValidateUniformity")]
        ValidateUniformity = 0x5A,
        [NativeName("Name", "AllowGLSL")]
        AllowGlsl = 0x5B,
        [NativeName("Name", "EnableExperimentalPasses")]
        EnableExperimentalPasses = 0x5C,
        [NativeName("Name", "BindlessSpaceIndex")]
        BindlessSpaceIndex = 0x5D,
        [NativeName("Name", "ArchiveType")]
        ArchiveType = 0x5E,
        [NativeName("Name", "CompileCoreModule")]
        CompileCoreModule = 0x5F,
        [NativeName("Name", "Doc")]
        Doc = 0x60,
        [NativeName("Name", "IrCompression")]
        IrCompression = 0x61,
        [NativeName("Name", "LoadCoreModule")]
        LoadCoreModule = 0x62,
        [NativeName("Name", "ReferenceModule")]
        ReferenceModule = 0x63,
        [NativeName("Name", "SaveCoreModule")]
        SaveCoreModule = 0x64,
        [NativeName("Name", "SaveCoreModuleBinSource")]
        SaveCoreModuleBinSource = 0x65,
        [NativeName("Name", "TrackLiveness")]
        TrackLiveness = 0x66,
        [NativeName("Name", "LoopInversion")]
        LoopInversion = 0x67,
        [NativeName("Name", "ParameterBlocksUseRegisterSpaces")]
        ParameterBlocksUseRegisterSpaces = 0x68,
        [NativeName("Name", "LanguageVersion")]
        LanguageVersion = 0x69,
        [NativeName("Name", "TypeConformance")]
        TypeConformance = 0x6A,
        [NativeName("Name", "EnableExperimentalDynamicDispatch")]
        EnableExperimentalDynamicDispatch = 0x6B,
        [NativeName("Name", "EmitReflectionJSON")]
        EmitReflectionJson = 0x6C,
        [NativeName("Name", "CountOfParsableOptions")]
        CountOfParsableOptions = 0x6D,
        [NativeName("Name", "DebugInformationFormat")]
        DebugInformationFormat = 0x6E,
        [NativeName("Name", "VulkanBindShiftAll")]
        VulkanBindShiftAll = 0x6F,
        [NativeName("Name", "GenerateWholeProgram")]
        GenerateWholeProgram = 0x70,
        [NativeName("Name", "UseUpToDateBinaryModule")]
        UseUpToDateBinaryModule = 0x71,
        [NativeName("Name", "EmbedDownstreamIR")]
        EmbedDownstreamIR = 0x72,
        [NativeName("Name", "ForceDXLayout")]
        ForceDxlayout = 0x73,
        [NativeName("Name", "EmitSpirvMethod")]
        EmitSpirvMethod = 0x74,
        [NativeName("Name", "SaveGLSLModuleBinSource")]
        SaveGlslmoduleBinSource = 0x75,
        [NativeName("Name", "SkipDownstreamLinking")]
        SkipDownstreamLinking = 0x76,
        [NativeName("Name", "DumpModule")]
        DumpModule = 0x77,
        [NativeName("Name", "GetModuleInfo")]
        GetModuleInfo = 0x78,
        [NativeName("Name", "GetSupportedModuleVersions")]
        GetSupportedModuleVersions = 0x79,
        [NativeName("Name", "EmitSeparateDebug")]
        EmitSeparateDebug = 0x7A,
        [NativeName("Name", "DenormalModeFp16")]
        DenormalModeFp16 = 0x7B,
        [NativeName("Name", "DenormalModeFp32")]
        DenormalModeFp32 = 0x7C,
        [NativeName("Name", "DenormalModeFp64")]
        DenormalModeFp64 = 0x7D,
        [NativeName("Name", "UseMSVCStyleBitfieldPacking")]
        UseMsvcstyleBitfieldPacking = 0x7E,
        [NativeName("Name", "CountOf")]
        CountOf = 0x7F,
    }
}
