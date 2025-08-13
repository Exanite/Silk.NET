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
    public unsafe partial class Slang : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_VC")]
        public const int VC = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_CLANG")]
        public const int Clang = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_SNC")]
        public const int Snc = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_GHS")]
        public const int Ghs = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_GCC")]
        public const int Gcc = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIN64")]
        public const int Win64 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WINRT")]
        public const int Winrt = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_XBOXONE")]
        public const int Xboxone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_X360")]
        public const int X360 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIN32")]
        public const int Win32 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ANDROID")]
        public const int Android = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_LINUX")]
        public const int Linux = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_IOS")]
        public const int Ios = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_OSX")]
        public const int Osx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PS3")]
        public const int PS3 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PS4")]
        public const int PS4 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PSP2")]
        public const int Psp2 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIIU")]
        public const int Wiiu = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXVK")]
        public const int EnableDxvk = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_VKD3D")]
        public const int EnableVkd3D = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DIRECTX")]
        public const int EnableDirectx = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXGI_DEBUG")]
        public const int EnableDxgiDebug = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXBC_SUPPORT")]
        public const int EnableDxbcSupport = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_PIX")]
        public const int EnablePix = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_EXCEPTIONS")]
        public const int HasExceptions = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_MOVE_SEMANTICS")]
        public const int HasMoveSemantics = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_ENUM_CLASS")]
        public const int HasEnumClass = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_X86_64")]
        public const int ProcessorX8664 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_ARM")]
        public const int ProcessorArm = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_ARM_64")]
        public const int ProcessorArm64 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_X86")]
        public const int ProcessorX86 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_POWER_PC")]
        public const int ProcessorPowerPC = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_POWER_PC_64")]
        public const int ProcessorPowerPC64 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_LITTLE_ENDIAN")]
        public const int LittleEndian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_UNALIGNED_ACCESS")]
        public const int UnalignedAccess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_BIG_ENDIAN")]
        public const int BigEndian = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_GENERAL")]
        public const int FacilityWinGeneral = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_INTERFACE")]
        public const int FacilityWinInterface = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_API")]
        public const int FacilityWinApi = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_BASE")]
        public const int FacilityBase = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_CORE")]
        public const int FacilityCore = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_EXTERNAL_BASE")]
        public const int FacilityExternalBase = unchecked((int) 0x210);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_OK")]
        public const int OK = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_API_VERSION")]
        public const int ApiVersion = unchecked((int) 0x0);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 27 in slang.h")]
        [NativeApi(EntryPoint = "spGetBuildTagString")]
        public unsafe partial byte* SpGetBuildTagString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1809, Column 27 in slang.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetBuildTagString")]
        public partial string SpGetBuildTagStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 21, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCreateSession")]
        public unsafe partial IGlobalSession* SpCreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* deprecated);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 21, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCreateSession")]
        public unsafe partial IGlobalSession* SpCreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte deprecated);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 21, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCreateSession")]
        public unsafe partial IGlobalSession* SpCreateSession([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string deprecated);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 26, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spDestroySession")]
        public unsafe partial void SpDestroySession(IGlobalSession* session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 26, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spDestroySession")]
        public partial void SpDestroySession(ref IGlobalSession session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionSetSharedLibraryLoader")]
        public unsafe partial void SpSessionSetSharedLibraryLoader(IGlobalSession* session, ISharedLibraryLoader* loader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionSetSharedLibraryLoader")]
        public unsafe partial void SpSessionSetSharedLibraryLoader(IGlobalSession* session, ref ISharedLibraryLoader loader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionSetSharedLibraryLoader")]
        public unsafe partial void SpSessionSetSharedLibraryLoader(ref IGlobalSession session, ISharedLibraryLoader* loader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 30, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionSetSharedLibraryLoader")]
        public partial void SpSessionSetSharedLibraryLoader(ref IGlobalSession session, ref ISharedLibraryLoader loader);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 36, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionGetSharedLibraryLoader")]
        public unsafe partial ISharedLibraryLoader* SpSessionGetSharedLibraryLoader(IGlobalSession* session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 36, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionGetSharedLibraryLoader")]
        public unsafe partial ISharedLibraryLoader* SpSessionGetSharedLibraryLoader(ref IGlobalSession session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionCheckCompileTargetSupport")]
        public unsafe partial int SpSessionCheckCompileTargetSupport(IGlobalSession* session, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 41, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionCheckCompileTargetSupport")]
        public partial int SpSessionCheckCompileTargetSupport(ref IGlobalSession session, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionCheckPassThroughSupport")]
        public unsafe partial int SpSessionCheckPassThroughSupport(IGlobalSession* session, PassThrough passThrough);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 46, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSessionCheckPassThroughSupport")]
        public partial int SpSessionCheckPassThroughSupport(ref IGlobalSession session, PassThrough passThrough);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public unsafe partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 50, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddBuiltins")]
        public partial void SpAddBuiltins(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourcePath, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceString);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 57, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCreateCompileRequest")]
        public unsafe partial ICompileRequest* SpCreateCompileRequest(IGlobalSession* session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 57, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCreateCompileRequest")]
        public unsafe partial ICompileRequest* SpCreateCompileRequest(ref IGlobalSession session);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spDestroyCompileRequest")]
        public unsafe partial void SpDestroyCompileRequest(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spDestroyCompileRequest")]
        public partial void SpDestroyCompileRequest(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetFileSystem")]
        public unsafe partial void SpSetFileSystem(ICompileRequest* request, IFileSystem* fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetFileSystem")]
        public unsafe partial void SpSetFileSystem(ICompileRequest* request, ref IFileSystem fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetFileSystem")]
        public unsafe partial void SpSetFileSystem(ref ICompileRequest request, IFileSystem* fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetFileSystem")]
        public partial void SpSetFileSystem(ref ICompileRequest request, ref IFileSystem fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetCompileFlags")]
        public unsafe partial void SpSetCompileFlags(ICompileRequest* request, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 69, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetCompileFlags")]
        public partial void SpSetCompileFlags(ref ICompileRequest request, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileFlags")]
        public unsafe partial uint SpGetCompileFlags(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 72, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileFlags")]
        public partial uint SpGetCompileFlags(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediates")]
        public unsafe partial void SpSetDumpIntermediates(ICompileRequest* request, int enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediates")]
        public partial void SpSetDumpIntermediates(ref ICompileRequest request, int enable);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public unsafe partial void SpSetDumpIntermediatePrefix(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public unsafe partial void SpSetDumpIntermediatePrefix(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public unsafe partial void SpSetDumpIntermediatePrefix(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public unsafe partial void SpSetDumpIntermediatePrefix(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public partial void SpSetDumpIntermediatePrefix(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 78, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDumpIntermediatePrefix")]
        public partial void SpSetDumpIntermediatePrefix(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string prefix);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetLineDirectiveMode")]
        public unsafe partial void SpSetLineDirectiveMode(ICompileRequest* request, LineDirectiveMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetLineDirectiveMode")]
        public partial void SpSetLineDirectiveMode(ref ICompileRequest request, LineDirectiveMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetLineDirectiveMode")]
        public unsafe partial void SpSetTargetLineDirectiveMode(ICompileRequest* request, int targetIndex, LineDirectiveMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 87, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetLineDirectiveMode")]
        public partial void SpSetTargetLineDirectiveMode(ref ICompileRequest request, int targetIndex, LineDirectiveMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetForceGLSLScalarBufferLayout")]
        public unsafe partial void SpSetTargetForceGLSLScalarBufferLayout(ICompileRequest* request, int targetIndex, bool forceScalarLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 93, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetForceGLSLScalarBufferLayout")]
        public partial void SpSetTargetForceGLSLScalarBufferLayout(ref ICompileRequest request, int targetIndex, bool forceScalarLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetUseMinimumSlangOptimization")]
        public unsafe partial void SpSetTargetUseMinimumSlangOptimization(ICompileRequest* request, int targetIndex, bool val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 99, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetUseMinimumSlangOptimization")]
        public partial void SpSetTargetUseMinimumSlangOptimization(ref ICompileRequest request, int targetIndex, bool val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetIgnoreCapabilityCheck")]
        public unsafe partial void SpSetIgnoreCapabilityCheck(ICompileRequest* request, bool val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 105, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetIgnoreCapabilityCheck")]
        public partial void SpSetIgnoreCapabilityCheck(ref ICompileRequest request, bool val);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetCodeGenTarget")]
        public unsafe partial void SpSetCodeGenTarget(ICompileRequest* request, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetCodeGenTarget")]
        public partial void SpSetCodeGenTarget(ref ICompileRequest request, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddCodeGenTarget")]
        public unsafe partial int SpAddCodeGenTarget(ICompileRequest* request, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 111, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddCodeGenTarget")]
        public partial int SpAddCodeGenTarget(ref ICompileRequest request, CompileTarget target);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetProfile")]
        public unsafe partial void SpSetTargetProfile(ICompileRequest* request, int targetIndex, ProfileID profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetProfile")]
        public partial void SpSetTargetProfile(ref ICompileRequest request, int targetIndex, ProfileID profile);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetFlags")]
        public unsafe partial void SpSetTargetFlags(ICompileRequest* request, int targetIndex, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetFlags")]
        public partial void SpSetTargetFlags(ref ICompileRequest request, int targetIndex, uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetFloatingPointMode")]
        public unsafe partial void SpSetTargetFloatingPointMode(ICompileRequest* request, int targetIndex, FloatingPointMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 127, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetFloatingPointMode")]
        public partial void SpSetTargetFloatingPointMode(ref ICompileRequest request, int targetIndex, FloatingPointMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTargetCapability")]
        public unsafe partial void SpAddTargetCapability(ICompileRequest* request, int targetIndex, CapabilityID capability);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 133, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTargetCapability")]
        public partial void SpAddTargetCapability(ref ICompileRequest request, int targetIndex, CapabilityID capability);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetMatrixLayoutMode")]
        public unsafe partial void SpSetTargetMatrixLayoutMode(ICompileRequest* request, int targetIndex, MatrixLayoutMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTargetMatrixLayoutMode")]
        public partial void SpSetTargetMatrixLayoutMode(ref ICompileRequest request, int targetIndex, MatrixLayoutMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetMatrixLayoutMode")]
        public unsafe partial void SpSetMatrixLayoutMode(ICompileRequest* request, MatrixLayoutMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 145, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetMatrixLayoutMode")]
        public partial void SpSetMatrixLayoutMode(ref ICompileRequest request, MatrixLayoutMode mode);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDebugInfoLevel")]
        public unsafe partial void SpSetDebugInfoLevel(ICompileRequest* request, DebugInfoLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDebugInfoLevel")]
        public partial void SpSetDebugInfoLevel(ref ICompileRequest request, DebugInfoLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDebugInfoFormat")]
        public unsafe partial void SpSetDebugInfoFormat(ICompileRequest* request, DebugInfoFormat format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 151, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDebugInfoFormat")]
        public partial void SpSetDebugInfoFormat(ref ICompileRequest request, DebugInfoFormat format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetOptimizationLevel")]
        public unsafe partial void SpSetOptimizationLevel(ICompileRequest* request, OptimizationLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 154, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetOptimizationLevel")]
        public partial void SpSetOptimizationLevel(ref ICompileRequest request, OptimizationLevel level);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetOutputContainerFormat")]
        public unsafe partial void SpSetOutputContainerFormat(ICompileRequest* request, ContainerFormat format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetOutputContainerFormat")]
        public partial void SpSetOutputContainerFormat(ref ICompileRequest request, ContainerFormat format);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetPassThrough")]
        public unsafe partial void SpSetPassThrough(ICompileRequest* request, PassThrough passThrough);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 165, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetPassThrough")]
        public partial void SpSetPassThrough(ref ICompileRequest request, PassThrough passThrough);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticCallback")]
        public unsafe partial void SpSetDiagnosticCallback(ICompileRequest* request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticCallback")]
        public unsafe partial void SpSetDiagnosticCallback<T0>(ICompileRequest* request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 userData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticCallback")]
        public unsafe partial void SpSetDiagnosticCallback(ref ICompileRequest request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* userData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 168, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticCallback")]
        public partial void SpSetDiagnosticCallback<T0>(ref ICompileRequest request, PfnDiagnosticCallback callback, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 userData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetWriter")]
        public unsafe partial void SpSetWriter(ICompileRequest* request, WriterChannel channel, IWriter* writer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetWriter")]
        public unsafe partial void SpSetWriter(ICompileRequest* request, WriterChannel channel, ref IWriter writer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetWriter")]
        public unsafe partial void SpSetWriter(ref ICompileRequest request, WriterChannel channel, IWriter* writer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 174, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetWriter")]
        public partial void SpSetWriter(ref ICompileRequest request, WriterChannel channel, ref IWriter writer);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetWriter")]
        public unsafe partial IWriter* SpGetWriter(ICompileRequest* request, WriterChannel channel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 180, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetWriter")]
        public unsafe partial IWriter* SpGetWriter(ref ICompileRequest request, WriterChannel channel);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public unsafe partial void SpAddSearchPath(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public unsafe partial void SpAddSearchPath(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public unsafe partial void SpAddSearchPath(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public unsafe partial void SpAddSearchPath(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public partial void SpAddSearchPath(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 183, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddSearchPath")]
        public partial void SpAddSearchPath(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string searchDir);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public unsafe partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 186, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddPreprocessorDefine")]
        public partial void SpAddPreprocessorDefine(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spProcessCommandLineArguments")]
        public unsafe partial int SpProcessCommandLineArguments(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** args, int argCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spProcessCommandLineArguments")]
        public unsafe partial int SpProcessCommandLineArguments(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* args, int argCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spProcessCommandLineArguments")]
        public unsafe partial int SpProcessCommandLineArguments(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** args, int argCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spProcessCommandLineArguments")]
        public unsafe partial int SpProcessCommandLineArguments(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* args, int argCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public unsafe partial int SpAddTranslationUnit(ICompileRequest* request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public unsafe partial int SpAddTranslationUnit(ICompileRequest* request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public unsafe partial int SpAddTranslationUnit(ICompileRequest* request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public unsafe partial int SpAddTranslationUnit(ref ICompileRequest request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public partial int SpAddTranslationUnit(ref ICompileRequest request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 198, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnit")]
        public partial int SpAddTranslationUnit(ref ICompileRequest request, SourceLanguage language, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public unsafe partial void SpSetDefaultModuleName(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public unsafe partial void SpSetDefaultModuleName(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public unsafe partial void SpSetDefaultModuleName(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public unsafe partial void SpSetDefaultModuleName(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public partial void SpSetDefaultModuleName(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 205, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDefaultModuleName")]
        public partial void SpSetDefaultModuleName(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string defaultModuleName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public unsafe partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 210, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spTranslationUnit_addPreprocessorDefine")]
        public partial void SpTranslationUnitAddPreprocessorDefine(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string key, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public unsafe partial void SpAddTranslationUnitSourceFile(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public unsafe partial void SpAddTranslationUnitSourceFile(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public unsafe partial void SpAddTranslationUnitSourceFile(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public unsafe partial void SpAddTranslationUnitSourceFile(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public partial void SpAddTranslationUnitSourceFile(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 218, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceFile")]
        public partial void SpAddTranslationUnitSourceFile(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public unsafe partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 224, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceString")]
        public partial void SpAddTranslationUnitSourceString(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string source);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference<T0>(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference<T0>(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference<T0>(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference<T0>(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public partial int SpAddLibraryReference<T0>(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public unsafe partial int SpAddLibraryReference(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* libData, nuint libDataSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 232, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddLibraryReference")]
        public partial int SpAddLibraryReference<T0>(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string basePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 libData, nuint libDataSize) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public unsafe partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 239, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceStringSpan")]
        public partial void SpAddTranslationUnitSourceStringSpan(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string sourceEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public unsafe partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, IBlob* sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 247, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddTranslationUnitSourceBlob")]
        public partial void SpAddTranslationUnitSourceBlob(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref IBlob sourceBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public unsafe partial ProfileID SpFindProfile(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public unsafe partial ProfileID SpFindProfile(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public unsafe partial ProfileID SpFindProfile(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public unsafe partial ProfileID SpFindProfile(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public partial ProfileID SpFindProfile(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 30 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindProfile")]
        public partial ProfileID SpFindProfile(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public unsafe partial CapabilityID SpFindCapability(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public unsafe partial CapabilityID SpFindCapability(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public unsafe partial CapabilityID SpFindCapability(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public unsafe partial CapabilityID SpFindCapability(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public partial CapabilityID SpFindCapability(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 257, Column 33 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spFindCapability")]
        public partial CapabilityID SpFindCapability(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public unsafe partial int SpAddEntryPoint(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public unsafe partial int SpAddEntryPoint(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public unsafe partial int SpAddEntryPoint(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public unsafe partial int SpAddEntryPoint(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public partial int SpAddEntryPoint(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 260, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPoint")]
        public partial int SpAddEntryPoint(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spAddEntryPointEx")]
        public unsafe partial int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetGlobalGenericArgs")]
        public unsafe partial int SpSetGlobalGenericArgs(ICompileRequest* request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetGlobalGenericArgs")]
        public unsafe partial int SpSetGlobalGenericArgs(ICompileRequest* request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetGlobalGenericArgs")]
        public unsafe partial int SpSetGlobalGenericArgs(ref ICompileRequest request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetGlobalGenericArgs")]
        public unsafe partial int SpSetGlobalGenericArgs(ref ICompileRequest request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte* genericArgs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForGlobalExistentialTypeParam(ICompileRequest* request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForGlobalExistentialTypeParam(ICompileRequest* request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForGlobalExistentialTypeParam(ICompileRequest* request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForGlobalExistentialTypeParam(ref ICompileRequest request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public partial int SpSetTypeNameForGlobalExistentialTypeParam(ref ICompileRequest request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForGlobalExistentialTypeParam")]
        public partial int SpSetTypeNameForGlobalExistentialTypeParam(ref ICompileRequest request, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForEntryPointExistentialTypeParam(ICompileRequest* request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForEntryPointExistentialTypeParam(ICompileRequest* request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForEntryPointExistentialTypeParam(ICompileRequest* request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public unsafe partial int SpSetTypeNameForEntryPointExistentialTypeParam(ref ICompileRequest request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public partial int SpSetTypeNameForEntryPointExistentialTypeParam(ref ICompileRequest request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 288, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetTypeNameForEntryPointExistentialTypeParam")]
        public partial int SpSetTypeNameForEntryPointExistentialTypeParam(ref ICompileRequest request, int entryPointIndex, int slotIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string typeName);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 295, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompile")]
        public unsafe partial int SpCompile(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 295, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompile")]
        public partial int SpCompile(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutput")]
        public unsafe partial byte* SpGetDiagnosticOutput(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetDiagnosticOutput")]
        public unsafe partial string SpGetDiagnosticOutputS(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutput")]
        public unsafe partial byte* SpGetDiagnosticOutput(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 299, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetDiagnosticOutput")]
        public partial string SpGetDiagnosticOutputS(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutputBlob")]
        public unsafe partial int SpGetDiagnosticOutputBlob(ICompileRequest* request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutputBlob")]
        public unsafe partial int SpGetDiagnosticOutputBlob(ICompileRequest* request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutputBlob")]
        public unsafe partial int SpGetDiagnosticOutputBlob(ref ICompileRequest request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 303, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticOutputBlob")]
        public unsafe partial int SpGetDiagnosticOutputBlob(ref ICompileRequest request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDependencyFileCount")]
        public unsafe partial int SpGetDependencyFileCount(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 307, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDependencyFileCount")]
        public partial int SpGetDependencyFileCount(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDependencyFilePath")]
        public unsafe partial byte* SpGetDependencyFilePath(ICompileRequest* request, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetDependencyFilePath")]
        public unsafe partial string SpGetDependencyFilePathS(ICompileRequest* request, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDependencyFilePath")]
        public unsafe partial byte* SpGetDependencyFilePath(ref ICompileRequest request, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 310, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetDependencyFilePath")]
        public partial string SpGetDependencyFilePathS(ref ICompileRequest request, int index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTranslationUnitCount")]
        public unsafe partial int SpGetTranslationUnitCount(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 313, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTranslationUnitCount")]
        public partial int SpGetTranslationUnitCount(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointSource")]
        public unsafe partial byte* SpGetEntryPointSource(ICompileRequest* request, int entryPointIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetEntryPointSource")]
        public unsafe partial string SpGetEntryPointSourceS(ICompileRequest* request, int entryPointIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointSource")]
        public unsafe partial byte* SpGetEntryPointSource(ref ICompileRequest request, int entryPointIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 316, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetEntryPointSource")]
        public partial string SpGetEntryPointSourceS(ref ICompileRequest request, int entryPointIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCode")]
        public unsafe partial void* SpGetEntryPointCode(ICompileRequest* request, int entryPointIndex, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCode")]
        public unsafe partial void* SpGetEntryPointCode(ICompileRequest* request, int entryPointIndex, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCode")]
        public unsafe partial void* SpGetEntryPointCode(ref ICompileRequest request, int entryPointIndex, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 319, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCode")]
        public unsafe partial void* SpGetEntryPointCode(ref ICompileRequest request, int entryPointIndex, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCodeBlob")]
        public unsafe partial int SpGetEntryPointCodeBlob(ICompileRequest* request, int entryPointIndex, int targetIndex, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCodeBlob")]
        public unsafe partial int SpGetEntryPointCodeBlob(ICompileRequest* request, int entryPointIndex, int targetIndex, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCodeBlob")]
        public unsafe partial int SpGetEntryPointCodeBlob(ref ICompileRequest request, int entryPointIndex, int targetIndex, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 325, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointCodeBlob")]
        public unsafe partial int SpGetEntryPointCodeBlob(ref ICompileRequest request, int entryPointIndex, int targetIndex, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointHostCallable")]
        public unsafe partial int SpGetEntryPointHostCallable(ICompileRequest* request, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointHostCallable")]
        public unsafe partial int SpGetEntryPointHostCallable(ICompileRequest* request, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointHostCallable")]
        public unsafe partial int SpGetEntryPointHostCallable(ref ICompileRequest request, int entryPointIndex, int targetIndex, ISharedLibrary** outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 332, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetEntryPointHostCallable")]
        public unsafe partial int SpGetEntryPointHostCallable(ref ICompileRequest request, int entryPointIndex, int targetIndex, ref ISharedLibrary* outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetCodeBlob")]
        public unsafe partial int SpGetTargetCodeBlob(ICompileRequest* request, int targetIndex, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetCodeBlob")]
        public unsafe partial int SpGetTargetCodeBlob(ICompileRequest* request, int targetIndex, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetCodeBlob")]
        public unsafe partial int SpGetTargetCodeBlob(ref ICompileRequest request, int targetIndex, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 340, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetCodeBlob")]
        public unsafe partial int SpGetTargetCodeBlob(ref ICompileRequest request, int targetIndex, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetHostCallable")]
        public unsafe partial int SpGetTargetHostCallable(ICompileRequest* request, int targetIndex, ISharedLibrary** outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetHostCallable")]
        public unsafe partial int SpGetTargetHostCallable(ICompileRequest* request, int targetIndex, ref ISharedLibrary* outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetHostCallable")]
        public unsafe partial int SpGetTargetHostCallable(ref ICompileRequest request, int targetIndex, ISharedLibrary** outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 343, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTargetHostCallable")]
        public unsafe partial int SpGetTargetHostCallable(ref ICompileRequest request, int targetIndex, ref ISharedLibrary* outSharedLibrary);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileRequestCode")]
        public unsafe partial void* SpGetCompileRequestCode(ICompileRequest* request, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileRequestCode")]
        public unsafe partial void* SpGetCompileRequestCode(ICompileRequest* request, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileRequestCode")]
        public unsafe partial void* SpGetCompileRequestCode(ref ICompileRequest request, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 349, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileRequestCode")]
        public unsafe partial void* SpGetCompileRequestCode(ref ICompileRequest request, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetContainerCode")]
        public unsafe partial int SpGetContainerCode(ICompileRequest* request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetContainerCode")]
        public unsafe partial int SpGetContainerCode(ICompileRequest* request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetContainerCode")]
        public unsafe partial int SpGetContainerCode(ref ICompileRequest request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 352, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetContainerCode")]
        public unsafe partial int SpGetContainerCode(ref ICompileRequest request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro(ICompileRequest* request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro<T0>(ICompileRequest* request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro(ICompileRequest* request, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro<T0>(ICompileRequest* request, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro(ref ICompileRequest request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro<T0>(ref ICompileRequest request, IFileSystem* fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public unsafe partial int SpLoadRepro(ref ICompileRequest request, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadRepro")]
        public partial int SpLoadRepro<T0>(ref ICompileRequest request, ref IFileSystem fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSaveRepro")]
        public unsafe partial int SpSaveRepro(ICompileRequest* request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSaveRepro")]
        public unsafe partial int SpSaveRepro(ICompileRequest* request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSaveRepro")]
        public unsafe partial int SpSaveRepro(ref ICompileRequest request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 362, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSaveRepro")]
        public unsafe partial int SpSaveRepro(ref ICompileRequest request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spEnableReproCapture")]
        public unsafe partial int SpEnableReproCapture(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 365, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spEnableReproCapture")]
        public partial int SpEnableReproCapture(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileTimeProfile")]
        public unsafe partial int SpGetCompileTimeProfile(ICompileRequest* request, IProfiler** compileTimeProfile, bool shouldClear);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileTimeProfile")]
        public unsafe partial int SpGetCompileTimeProfile(ICompileRequest* request, ref IProfiler* compileTimeProfile, bool shouldClear);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileTimeProfile")]
        public unsafe partial int SpGetCompileTimeProfile(ref ICompileRequest request, IProfiler** compileTimeProfile, bool shouldClear);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 368, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetCompileTimeProfile")]
        public unsafe partial int SpGetCompileTimeProfile(ref ICompileRequest request, ref IProfiler* compileTimeProfile, bool shouldClear);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IMutableFileSystem* fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IMutableFileSystem fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IMutableFileSystem* fileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IMutableFileSystem fileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IMutableFileSystem* fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IMutableFileSystem fileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public unsafe partial int SpExtractRepro<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IMutableFileSystem* fileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 385, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spExtractRepro")]
        public partial int SpExtractRepro<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IMutableFileSystem fileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, IFileSystemExt** outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref IFileSystemExt* outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, IFileSystemExt** outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref IFileSystemExt* outFileSystem);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, IFileSystem* replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, IFileSystemExt** outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spLoadReproAsFileSystem")]
        public unsafe partial int SpLoadReproAsFileSystem<T0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spOverrideDiagnosticSeverity")]
        public unsafe partial void SpOverrideDiagnosticSeverity(ICompileRequest* request, long messageID, Severity overrideSeverity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 412, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spOverrideDiagnosticSeverity")]
        public partial void SpOverrideDiagnosticSeverity(ref ICompileRequest request, long messageID, Severity overrideSeverity);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticFlags")]
        public unsafe partial int SpGetDiagnosticFlags(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetDiagnosticFlags")]
        public partial int SpGetDiagnosticFlags(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticFlags")]
        public unsafe partial void SpSetDiagnosticFlags(ICompileRequest* request, int flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 421, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spSetDiagnosticFlags")]
        public partial void SpSetDiagnosticFlags(ref ICompileRequest request, int flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 425, Column 32 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetReflection")]
        public unsafe partial ProgramLayout* SpGetReflection(ICompileRequest* request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 425, Column 32 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetReflection")]
        public unsafe partial ProgramLayout* SpGetReflection(ref ICompileRequest request);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetName")]
        public unsafe partial byte* SpReflectionUserAttributeGetName(ReflectionUserAttribute* attrib);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetName")]
        public unsafe partial string SpReflectionUserAttributeGetNameS(ReflectionUserAttribute* attrib);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 429, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentCount")]
        public unsafe partial uint SpReflectionUserAttributeGetArgumentCount(ReflectionUserAttribute* attrib);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 431, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentType")]
        public unsafe partial ReflectionType* SpReflectionUserAttributeGetArgumentType(ReflectionUserAttribute* attrib, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 434, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueInt")]
        public unsafe partial int SpReflectionUserAttributeGetArgumentValueInt(ReflectionUserAttribute* attrib, uint index, int* rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 434, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueInt")]
        public unsafe partial int SpReflectionUserAttributeGetArgumentValueInt(ReflectionUserAttribute* attrib, uint index, ref int rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueFloat")]
        public unsafe partial int SpReflectionUserAttributeGetArgumentValueFloat(ReflectionUserAttribute* attrib, uint index, float* rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 438, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueFloat")]
        public unsafe partial int SpReflectionUserAttributeGetArgumentValueFloat(ReflectionUserAttribute* attrib, uint index, ref float rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 448, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueString")]
        public unsafe partial byte* SpReflectionUserAttributeGetArgumentValueString(ReflectionUserAttribute* attrib, uint index, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 448, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueString")]
        public unsafe partial string SpReflectionUserAttributeGetArgumentValueStringS(ReflectionUserAttribute* attrib, uint index, nuint* outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 448, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueString")]
        public unsafe partial byte* SpReflectionUserAttributeGetArgumentValueString(ReflectionUserAttribute* attrib, uint index, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 448, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionUserAttribute_GetArgumentValueString")]
        public unsafe partial string SpReflectionUserAttributeGetArgumentValueStringS(ReflectionUserAttribute* attrib, uint index, ref nuint outSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 455, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetKind")]
        public unsafe partial TypeKind SpReflectionTypeGetKind(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 456, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetUserAttributeCount")]
        public unsafe partial uint SpReflectionTypeGetUserAttributeCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 457, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetUserAttribute")]
        public unsafe partial ReflectionUserAttribute* SpReflectionTypeGetUserAttribute(ReflectionType* type, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionTypeFindUserAttributeByName(ReflectionType* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionTypeFindUserAttributeByName(ReflectionType* type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 460, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionTypeFindUserAttributeByName(ReflectionType* type, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_applySpecializations")]
        public unsafe partial ReflectionType* SpReflectionTypeApplySpecializations(ReflectionType* type, ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 467, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetFieldCount")]
        public unsafe partial uint SpReflectionTypeGetFieldCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 468, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetFieldByIndex")]
        public unsafe partial ReflectionVariable* SpReflectionTypeGetFieldByIndex(ReflectionType* type, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 485, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetElementCount")]
        public unsafe partial nuint SpReflectionTypeGetElementCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 490, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetSpecializedElementCount")]
        public unsafe partial nuint SpReflectionTypeGetSpecializedElementCount(ReflectionType* type, ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetElementType")]
        public unsafe partial ReflectionType* SpReflectionTypeGetElementType(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 496, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetRowCount")]
        public unsafe partial uint SpReflectionTypeGetRowCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetColumnCount")]
        public unsafe partial uint SpReflectionTypeGetColumnCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 498, Column 31 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetScalarType")]
        public unsafe partial ScalarType SpReflectionTypeGetScalarType(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 500, Column 34 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetResourceShape")]
        public unsafe partial ResourceShape SpReflectionTypeGetResourceShape(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 501, Column 35 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetResourceAccess")]
        public unsafe partial ResourceAccess SpReflectionTypeGetResourceAccess(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetResourceResultType")]
        public unsafe partial ReflectionType* SpReflectionTypeGetResourceResultType(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 505, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetName")]
        public unsafe partial byte* SpReflectionTypeGetName(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 505, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionType_GetName")]
        public unsafe partial string SpReflectionTypeGetNameS(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetFullName")]
        public unsafe partial int SpReflectionTypeGetFullName(ReflectionType* type, IBlob** outNameBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 507, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetFullName")]
        public unsafe partial int SpReflectionTypeGetFullName(ReflectionType* type, ref IBlob* outNameBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 508, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_GetGenericContainer")]
        public unsafe partial ReflectionGeneric* SpReflectionTypeGetGenericContainer(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 513, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetType")]
        public unsafe partial ReflectionType* SpReflectionTypeLayoutGetType(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 514, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getKind")]
        public unsafe partial TypeKind SpReflectionTypeLayoutGetKind(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 515, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetSize")]
        public unsafe partial nuint SpReflectionTypeLayoutGetSize(ReflectionTypeLayout* type, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 518, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetStride")]
        public unsafe partial nuint SpReflectionTypeLayoutGetStride(ReflectionTypeLayout* type, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 23 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getAlignment")]
        public unsafe partial int SpReflectionTypeLayoutGetAlignment(ReflectionTypeLayout* type, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 525, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetFieldCount")]
        public unsafe partial uint SpReflectionTypeLayoutGetFieldCount(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 526, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetFieldByIndex")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetFieldByIndex(ReflectionTypeLayout* type, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_findFieldIndexByName")]
        public unsafe partial long SpReflectionTypeLayoutFindFieldIndexByName(ReflectionTypeLayout* typeLayout, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameBegin, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string nameEnd);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 535, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetExplicitCounter")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetExplicitCounter(ReflectionTypeLayout* typeLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetElementStride")]
        public unsafe partial nuint SpReflectionTypeLayoutGetElementStride(ReflectionTypeLayout* type, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 541, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetElementTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionTypeLayoutGetElementTypeLayout(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 543, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetElementVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetElementVarLayout(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getContainerVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetContainerVarLayout(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 549, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetParameterCategory")]
        public unsafe partial ParameterCategory SpReflectionTypeLayoutGetParameterCategory(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetCategoryCount")]
        public unsafe partial uint SpReflectionTypeLayoutGetCategoryCount(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 553, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetCategoryByIndex")]
        public unsafe partial ParameterCategory SpReflectionTypeLayoutGetCategoryByIndex(ReflectionTypeLayout* type, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 556, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_GetMatrixLayoutMode")]
        public unsafe partial MatrixLayoutMode SpReflectionTypeLayoutGetMatrixLayoutMode(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 558, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getGenericParamIndex")]
        public unsafe partial int SpReflectionTypeLayoutGetGenericParamIndex(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getPendingDataTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionTypeLayoutGetPendingDataTypeLayout(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 564, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getSpecializedTypePendingDataVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetSpecializedTypePendingDataVarLayout(ReflectionTypeLayout* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 565, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_getSpecializedTypeArgCount")]
        public unsafe partial long SpReflectionTypeGetSpecializedTypeArgCount(ReflectionType* type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 566, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionType_getSpecializedTypeArgType")]
        public unsafe partial ReflectionType* SpReflectionTypeGetSpecializedTypeArgType(ReflectionType* type, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 571, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeCount")]
        public unsafe partial long SpReflectionTypeLayoutGetBindingRangeCount(ReflectionTypeLayout* typeLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 572, Column 32 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeType")]
        public unsafe partial BindingType SpReflectionTypeLayoutGetBindingRangeType(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 575, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_isBindingRangeSpecializable")]
        public unsafe partial long SpReflectionTypeLayoutIsBindingRangeSpecializable(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 578, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeBindingCount")]
        public unsafe partial long SpReflectionTypeLayoutGetBindingRangeBindingCount(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 581, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeLeafTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionTypeLayoutGetBindingRangeLeafTypeLayout(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 584, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeLeafVariable")]
        public unsafe partial ReflectionVariable* SpReflectionTypeLayoutGetBindingRangeLeafVariable(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 587, Column 32 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeImageFormat")]
        public unsafe partial ImageFormat SpReflectionTypeLayoutGetBindingRangeImageFormat(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 590, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getFieldBindingRangeOffset")]
        public unsafe partial long SpReflectionTypeLayoutGetFieldBindingRangeOffset(ReflectionTypeLayout* typeLayout, long fieldIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 593, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getExplicitCounterBindingRangeOffset")]
        public unsafe partial long SpReflectionTypeLayoutGetExplicitCounterBindingRangeOffset(ReflectionTypeLayout* inTypeLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 596, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeDescriptorSetIndex")]
        public unsafe partial long SpReflectionTypeLayoutGetBindingRangeDescriptorSetIndex(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 599, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeFirstDescriptorRangeIndex")]
        public unsafe partial long SpReflectionTypeLayoutGetBindingRangeFirstDescriptorRangeIndex(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 602, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getBindingRangeDescriptorRangeCount")]
        public unsafe partial long SpReflectionTypeLayoutGetBindingRangeDescriptorRangeCount(ReflectionTypeLayout* typeLayout, long index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 607, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetCount")]
        public unsafe partial long SpReflectionTypeLayoutGetDescriptorSetCount(ReflectionTypeLayout* typeLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 608, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetSpaceOffset")]
        public unsafe partial long SpReflectionTypeLayoutGetDescriptorSetSpaceOffset(ReflectionTypeLayout* typeLayout, long setIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 611, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeCount")]
        public unsafe partial long SpReflectionTypeLayoutGetDescriptorSetDescriptorRangeCount(ReflectionTypeLayout* typeLayout, long setIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 614, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeIndexOffset")]
        public unsafe partial long SpReflectionTypeLayoutGetDescriptorSetDescriptorRangeIndexOffset(ReflectionTypeLayout* typeLayout, long setIndex, long rangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 618, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeDescriptorCount")]
        public unsafe partial long SpReflectionTypeLayoutGetDescriptorSetDescriptorRangeDescriptorCount(ReflectionTypeLayout* typeLayout, long setIndex, long rangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 622, Column 32 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeType")]
        public unsafe partial BindingType SpReflectionTypeLayoutGetDescriptorSetDescriptorRangeType(ReflectionTypeLayout* typeLayout, long setIndex, long rangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 626, Column 38 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getDescriptorSetDescriptorRangeCategory")]
        public unsafe partial ParameterCategory SpReflectionTypeLayoutGetDescriptorSetDescriptorRangeCategory(ReflectionTypeLayout* typeLayout, long setIndex, long rangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 632, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getSubObjectRangeCount")]
        public unsafe partial long SpReflectionTypeLayoutGetSubObjectRangeCount(ReflectionTypeLayout* typeLayout);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 633, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getSubObjectRangeBindingRangeIndex")]
        public unsafe partial long SpReflectionTypeLayoutGetSubObjectRangeBindingRangeIndex(ReflectionTypeLayout* typeLayout, long subObjectRangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 636, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getSubObjectRangeSpaceOffset")]
        public unsafe partial long SpReflectionTypeLayoutGetSubObjectRangeSpaceOffset(ReflectionTypeLayout* typeLayout, long subObjectRangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeLayout_getSubObjectRangeOffset")]
        public unsafe partial ReflectionVariableLayout* SpReflectionTypeLayoutGetSubObjectRangeOffset(ReflectionTypeLayout* typeLayout, long subObjectRangeIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetName")]
        public unsafe partial byte* SpReflectionVariableGetName(ReflectionVariable* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 658, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionVariable_GetName")]
        public unsafe partial string SpReflectionVariableGetNameS(ReflectionVariable* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 659, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetType")]
        public unsafe partial ReflectionType* SpReflectionVariableGetType(ReflectionVariable* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 660, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindModifier")]
        public unsafe partial ReflectionModifier* SpReflectionVariableFindModifier(ReflectionVariable* var, ModifierID modifierID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 663, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetUserAttributeCount")]
        public unsafe partial uint SpReflectionVariableGetUserAttributeCount(ReflectionVariable* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 664, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetUserAttribute")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableGetUserAttribute(ReflectionVariable* var, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 667, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionVariableFindUserAttributeByName(ReflectionVariable* var, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 671, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_HasDefaultValue")]
        public unsafe partial bool SpReflectionVariableHasDefaultValue(ReflectionVariable* inVar);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 673, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetDefaultValueInt")]
        public unsafe partial int SpReflectionVariableGetDefaultValueInt(ReflectionVariable* inVar, long* rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 673, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetDefaultValueInt")]
        public unsafe partial int SpReflectionVariableGetDefaultValueInt(ReflectionVariable* inVar, ref long rs);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 674, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_GetGenericContainer")]
        public unsafe partial ReflectionGeneric* SpReflectionVariableGetGenericContainer(ReflectionVariable* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 676, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariable_applySpecializations")]
        public unsafe partial ReflectionVariable* SpReflectionVariableApplySpecializations(ReflectionVariable* var, ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 682, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetVariable")]
        public unsafe partial ReflectionVariable* SpReflectionVariableLayoutGetVariable(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 685, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionVariableLayoutGetTypeLayout(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetOffset")]
        public unsafe partial nuint SpReflectionVariableLayoutGetOffset(ReflectionVariableLayout* var, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 691, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetSpace")]
        public unsafe partial nuint SpReflectionVariableLayoutGetSpace(ReflectionVariableLayout* var, ParameterCategory category);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 695, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetImageFormat")]
        public unsafe partial ImageFormat SpReflectionVariableLayoutGetImageFormat(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetSemanticName")]
        public unsafe partial byte* SpReflectionVariableLayoutGetSemanticName(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetSemanticName")]
        public unsafe partial string SpReflectionVariableLayoutGetSemanticNameS(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_GetSemanticIndex")]
        public unsafe partial nuint SpReflectionVariableLayoutGetSemanticIndex(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 705, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_asDecl")]
        public unsafe partial ReflectionDecl* SpReflectionFunctionAsDecl(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 706, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetName")]
        public unsafe partial byte* SpReflectionFunctionGetName(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 706, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionFunction_GetName")]
        public unsafe partial string SpReflectionFunctionGetNameS(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 707, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindModifier")]
        public unsafe partial ReflectionModifier* SpReflectionFunctionFindModifier(ReflectionFunction* var, ModifierID modifierID);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 710, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetUserAttributeCount")]
        public unsafe partial uint SpReflectionFunctionGetUserAttributeCount(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 712, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetUserAttribute")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionGetUserAttribute(ReflectionFunction* func, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, IGlobalSession* globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 715, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_FindUserAttributeByName")]
        public unsafe partial ReflectionUserAttribute* SpReflectionFunctionFindUserAttributeByName(ReflectionFunction* func, ref IGlobalSession globalSession, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 719, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetParameterCount")]
        public unsafe partial uint SpReflectionFunctionGetParameterCount(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 720, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetParameter")]
        public unsafe partial ReflectionVariable* SpReflectionFunctionGetParameter(ReflectionFunction* func, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 723, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetResultType")]
        public unsafe partial ReflectionType* SpReflectionFunctionGetResultType(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 725, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_GetGenericContainer")]
        public unsafe partial ReflectionGeneric* SpReflectionFunctionGetGenericContainer(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 727, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_applySpecializations")]
        public unsafe partial ReflectionFunction* SpReflectionFunctionApplySpecializations(ReflectionFunction* func, ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 730, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_specializeWithArgTypes")]
        public unsafe partial ReflectionFunction* SpReflectionFunctionSpecializeWithArgTypes(ReflectionFunction* func, long argTypeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionType** argTypes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 730, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_specializeWithArgTypes")]
        public unsafe partial ReflectionFunction* SpReflectionFunctionSpecializeWithArgTypes(ReflectionFunction* func, long argTypeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionType* argTypes);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 734, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_isOverloaded")]
        public unsafe partial bool SpReflectionFunctionIsOverloaded(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 735, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_getOverloadCount")]
        public unsafe partial uint SpReflectionFunctionGetOverloadCount(ReflectionFunction* func);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 736, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionFunction_getOverload")]
        public unsafe partial ReflectionFunction* SpReflectionFunctionGetOverload(ReflectionFunction* func, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 742, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_getChildrenCount")]
        public unsafe partial uint SpReflectionDeclGetChildrenCount(ReflectionDecl* parentDecl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 743, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_getChild")]
        public unsafe partial ReflectionDecl* SpReflectionDeclGetChild(ReflectionDecl* parentDecl, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 746, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_getName")]
        public unsafe partial byte* SpReflectionDeclGetName(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 746, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionDecl_getName")]
        public unsafe partial string SpReflectionDeclGetNameS(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 747, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_getKind")]
        public unsafe partial DeclKind SpReflectionDeclGetKind(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 748, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_castToFunction")]
        public unsafe partial ReflectionFunction* SpReflectionDeclCastToFunction(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_castToVariable")]
        public unsafe partial ReflectionVariable* SpReflectionDeclCastToVariable(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_castToGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionDeclCastToGeneric(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 751, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getTypeFromDecl")]
        public unsafe partial ReflectionType* SpReflectionGetTypeFromDecl(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 752, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionDecl_getParent")]
        public unsafe partial ReflectionDecl* SpReflectionDeclGetParent(ReflectionDecl* decl);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 756, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_asDecl")]
        public unsafe partial ReflectionDecl* SpReflectionGenericAsDecl(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 757, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetName")]
        public unsafe partial byte* SpReflectionGenericGetName(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 757, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetName")]
        public unsafe partial string SpReflectionGenericGetNameS(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 758, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetTypeParameterCount")]
        public unsafe partial uint SpReflectionGenericGetTypeParameterCount(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 760, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetTypeParameter")]
        public unsafe partial ReflectionVariable* SpReflectionGenericGetTypeParameter(ReflectionGeneric* generic, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 763, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetValueParameterCount")]
        public unsafe partial uint SpReflectionGenericGetValueParameterCount(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 765, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetValueParameter")]
        public unsafe partial ReflectionVariable* SpReflectionGenericGetValueParameter(ReflectionGeneric* generic, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 768, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetTypeParameterConstraintCount")]
        public unsafe partial uint SpReflectionGenericGetTypeParameterConstraintCount(ReflectionGeneric* generic, ReflectionVariable* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 771, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetTypeParameterConstraintType")]
        public unsafe partial ReflectionType* SpReflectionGenericGetTypeParameterConstraintType(ReflectionGeneric* generic, ReflectionVariable* typeParam, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 775, Column 29 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetInnerKind")]
        public unsafe partial DeclKind SpReflectionGenericGetInnerKind(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 776, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetInnerDecl")]
        public unsafe partial ReflectionDecl* SpReflectionGenericGetInnerDecl(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetOuterGenericContainer")]
        public unsafe partial ReflectionGeneric* SpReflectionGenericGetOuterGenericContainer(ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 780, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetConcreteType")]
        public unsafe partial ReflectionType* SpReflectionGenericGetConcreteType(ReflectionGeneric* generic, ReflectionVariable* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 783, Column 23 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_GetConcreteIntVal")]
        public unsafe partial long SpReflectionGenericGetConcreteIntVal(ReflectionGeneric* generic, ReflectionVariable* valueParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 786, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionGeneric_applySpecializations")]
        public unsafe partial ReflectionGeneric* SpReflectionGenericApplySpecializations(ReflectionGeneric* currGeneric, ReflectionGeneric* generic);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 798, Column 26 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_getStage")]
        public unsafe partial Stage SpReflectionVariableLayoutGetStage(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 801, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionVariableLayout_getPendingDataLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionVariableLayoutGetPendingDataLayout(ReflectionVariableLayout* var);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 806, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionParameter_GetBindingIndex")]
        public unsafe partial uint SpReflectionParameterGetBindingIndex(ReflectionVariableLayout* parameter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 807, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionParameter_GetBindingSpace")]
        public unsafe partial uint SpReflectionParameterGetBindingSpace(ReflectionVariableLayout* parameter);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spIsParameterLocationUsed")]
        public unsafe partial int SpIsParameterLocationUsed(ICompileRequest* request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, bool* outUsed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spIsParameterLocationUsed")]
        public unsafe partial int SpIsParameterLocationUsed(ICompileRequest* request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, ref bool outUsed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spIsParameterLocationUsed")]
        public unsafe partial int SpIsParameterLocationUsed(ref ICompileRequest request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, bool* outUsed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spIsParameterLocationUsed")]
        public partial int SpIsParameterLocationUsed(ref ICompileRequest request, long entryPointIndex, long targetIndex, ParameterCategory category, ulong spaceIndex, ulong registerIndex, ref bool outUsed);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getName")]
        public unsafe partial byte* SpReflectionEntryPointGetName(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getName")]
        public unsafe partial string SpReflectionEntryPointGetNameS(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 822, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getNameOverride")]
        public unsafe partial byte* SpReflectionEntryPointGetNameOverride(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 822, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getNameOverride")]
        public unsafe partial string SpReflectionEntryPointGetNameOverrideS(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 825, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getFunction")]
        public unsafe partial ReflectionFunction* SpReflectionEntryPointGetFunction(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 828, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getParameterCount")]
        public unsafe partial uint SpReflectionEntryPointGetParameterCount(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 831, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getParameterByIndex")]
        public unsafe partial ReflectionVariableLayout* SpReflectionEntryPointGetParameterByIndex(EntryPointLayout* entryPoint, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 26 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getStage")]
        public unsafe partial Stage SpReflectionEntryPointGetStage(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 837, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getComputeThreadGroupSize")]
        public unsafe partial void SpReflectionEntryPointGetComputeThreadGroupSize(EntryPointLayout* entryPoint, ulong axisCount, ulong* outSizeAlongAxis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 837, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getComputeThreadGroupSize")]
        public unsafe partial void SpReflectionEntryPointGetComputeThreadGroupSize(EntryPointLayout* entryPoint, ulong axisCount, ref ulong outSizeAlongAxis);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getComputeWaveSize")]
        public unsafe partial void SpReflectionEntryPointGetComputeWaveSize(EntryPointLayout* entryPoint, ulong* outWaveSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 842, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getComputeWaveSize")]
        public unsafe partial void SpReflectionEntryPointGetComputeWaveSize(EntryPointLayout* entryPoint, ref ulong outWaveSize);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 846, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_usesAnySampleRateInput")]
        public unsafe partial int SpReflectionEntryPointUsesAnySampleRateInput(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionEntryPointGetVarLayout(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 852, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_getResultVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionEntryPointGetResultVarLayout(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 855, Column 19 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionEntryPoint_hasDefaultConstantBuffer")]
        public unsafe partial int SpReflectionEntryPointHasDefaultConstantBuffer(EntryPointLayout* entryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 859, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeParameter_GetName")]
        public unsafe partial byte* SpReflectionTypeParameterGetName(ReflectionTypeParameter* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 859, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflectionTypeParameter_GetName")]
        public unsafe partial string SpReflectionTypeParameterGetNameS(ReflectionTypeParameter* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 861, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeParameter_GetIndex")]
        public unsafe partial uint SpReflectionTypeParameterGetIndex(ReflectionTypeParameter* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeParameter_GetConstraintCount")]
        public unsafe partial uint SpReflectionTypeParameterGetConstraintCount(ReflectionTypeParameter* typeParam);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflectionTypeParameter_GetConstraintByIndex")]
        public unsafe partial ReflectionType* SpReflectionTypeParameterGetConstraintByIndex(ReflectionTypeParameter* typeParam, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_ToJson")]
        public unsafe partial int SpReflectionToJson(ProgramLayout* reflection, ICompileRequest* request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_ToJson")]
        public unsafe partial int SpReflectionToJson(ProgramLayout* reflection, ICompileRequest* request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_ToJson")]
        public unsafe partial int SpReflectionToJson(ProgramLayout* reflection, ref ICompileRequest request, IBlob** outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 870, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_ToJson")]
        public unsafe partial int SpReflectionToJson(ProgramLayout* reflection, ref ICompileRequest request, ref IBlob* outBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 875, Column 24 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetParameterCount")]
        public unsafe partial uint SpReflectionGetParameterCount(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 41 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetParameterByIndex")]
        public unsafe partial ReflectionVariableLayout* SpReflectionGetParameterByIndex(ProgramLayout* reflection, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 880, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetTypeParameterCount")]
        public unsafe partial uint SpReflectionGetTypeParameterCount(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 881, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetTypeParameterByIndex")]
        public unsafe partial ReflectionTypeParameter* SpReflectionGetTypeParameterByIndex(ProgramLayout* reflection, uint index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeParameter")]
        public unsafe partial ReflectionTypeParameter* SpReflectionFindTypeParameter(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeParameter")]
        public unsafe partial ReflectionTypeParameter* SpReflectionFindTypeParameter(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 884, Column 45 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeParameter")]
        public unsafe partial ReflectionTypeParameter* SpReflectionFindTypeParameter(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 888, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeByName")]
        public unsafe partial ReflectionType* SpReflectionFindTypeByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 888, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeByName")]
        public unsafe partial ReflectionType* SpReflectionFindTypeByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 888, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindTypeByName")]
        public unsafe partial ReflectionType* SpReflectionFindTypeByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 891, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionGetTypeLayout(ProgramLayout* reflection, ReflectionType* reflectionType, LayoutRules rules);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByName")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByName")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 896, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByName")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByNameInType")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByNameInType")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 899, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindFunctionByNameInType")]
        public unsafe partial ReflectionFunction* SpReflectionFindFunctionByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindVarByNameInType")]
        public unsafe partial ReflectionVariable* SpReflectionFindVarByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindVarByNameInType")]
        public unsafe partial ReflectionVariable* SpReflectionFindVarByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 903, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_FindVarByNameInType")]
        public unsafe partial ReflectionVariable* SpReflectionFindVarByNameInType(ProgramLayout* reflection, ReflectionType* reflType, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_TryResolveOverloadedFunction")]
        public unsafe partial ReflectionFunction* SpReflectionTryResolveOverloadedFunction(ProgramLayout* reflection, uint candidateCount, ReflectionFunction** candidates);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 907, Column 40 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_TryResolveOverloadedFunction")]
        public unsafe partial ReflectionFunction* SpReflectionTryResolveOverloadedFunction(ProgramLayout* reflection, uint candidateCount, ref ReflectionFunction* candidates);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 912, Column 25 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getEntryPointCount")]
        public unsafe partial ulong SpReflectionGetEntryPointCount(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 913, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getEntryPointByIndex")]
        public unsafe partial EntryPointLayout* SpReflectionGetEntryPointByIndex(ProgramLayout* reflection, ulong index);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_findEntryPointByName")]
        public unsafe partial EntryPointLayout* SpReflectionFindEntryPointByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_findEntryPointByName")]
        public unsafe partial EntryPointLayout* SpReflectionFindEntryPointByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 916, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_findEntryPointByName")]
        public unsafe partial EntryPointLayout* SpReflectionFindEntryPointByName(ProgramLayout* reflection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 25 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getGlobalConstantBufferBinding")]
        public unsafe partial ulong SpReflectionGetGlobalConstantBufferBinding(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 921, Column 22 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getGlobalConstantBufferSize")]
        public unsafe partial nuint SpReflectionGetGlobalConstantBufferSize(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeType")]
        public unsafe partial ReflectionType* SpReflectionSpecializeType(ProgramLayout* reflection, ReflectionType* type, long specializationArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionType** specializationArgs, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeType")]
        public unsafe partial ReflectionType* SpReflectionSpecializeType(ProgramLayout* reflection, ReflectionType* type, long specializationArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionType** specializationArgs, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeType")]
        public unsafe partial ReflectionType* SpReflectionSpecializeType(ProgramLayout* reflection, ReflectionType* type, long specializationArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionType* specializationArgs, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 923, Column 36 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeType")]
        public unsafe partial ReflectionType* SpReflectionSpecializeType(ProgramLayout* reflection, ReflectionType* type, long specializationArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionType* specializationArgs, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArg args, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArgType* argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArg args, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArgType argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArgType argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReflectionGenericArg* args, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArgType argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArg args, IBlob** outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 39 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_specializeGeneric")]
        public unsafe partial ReflectionGeneric* SpReflectionSpecializeGeneric(ProgramLayout* inProgramLayout, ReflectionGeneric* generic, long argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArgType argTypes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ReflectionGenericArg args, ref IBlob* outDiagnostics);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 938, Column 20 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_isSubType")]
        public unsafe partial bool SpReflectionIsSubType(ProgramLayout* reflection, ReflectionType* subType, ReflectionType* superType);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 944, Column 25 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getHashedStringCount")]
        public unsafe partial ulong SpReflectionGetHashedStringCount(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getHashedString")]
        public unsafe partial byte* SpReflectionGetHashedString(ProgramLayout* reflection, ulong index, nuint* outCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflection_getHashedString")]
        public unsafe partial string SpReflectionGetHashedStringS(ProgramLayout* reflection, ulong index, nuint* outCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getHashedString")]
        public unsafe partial byte* SpReflectionGetHashedString(ProgramLayout* reflection, ulong index, ref nuint outCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 948, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spReflection_getHashedString")]
        public unsafe partial string SpReflectionGetHashedStringS(ProgramLayout* reflection, ulong index, ref nuint outCount);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spComputeStringHash")]
        public unsafe partial uint SpComputeStringHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* chars, nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spComputeStringHash")]
        public partial uint SpComputeStringHash([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte chars, nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 955, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spComputeStringHash")]
        public partial uint SpComputeStringHash([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string chars, nuint count);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 958, Column 42 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getGlobalParamsTypeLayout")]
        public unsafe partial ReflectionTypeLayout* SpReflectionGetGlobalParamsTypeLayout(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 46 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_getGlobalParamsVarLayout")]
        public unsafe partial ReflectionVariableLayout* SpReflectionGetGlobalParamsVarLayout(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTranslationUnitSource")]
        public unsafe partial byte* SpGetTranslationUnitSource(ICompileRequest* request, int translationUnitIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetTranslationUnitSource")]
        public unsafe partial string SpGetTranslationUnitSourceS(ICompileRequest* request, int translationUnitIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spGetTranslationUnitSource")]
        public unsafe partial byte* SpGetTranslationUnitSource(ref ICompileRequest request, int translationUnitIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 965, Column 27 in slang-deprecated.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetTranslationUnitSource")]
        public partial string SpGetTranslationUnitSourceS(ref ICompileRequest request, int translationUnitIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 28 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spReflection_GetSession")]
        public unsafe partial ISession* SpReflectionGetSession(ProgramLayout* reflection);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgram")]
        public unsafe partial int SpCompileRequestGetProgram(ICompileRequest* request, IComponentType** outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgram")]
        public unsafe partial int SpCompileRequestGetProgram(ICompileRequest* request, ref IComponentType* outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgram")]
        public unsafe partial int SpCompileRequestGetProgram(ref ICompileRequest request, IComponentType** outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgram")]
        public unsafe partial int SpCompileRequestGetProgram(ref ICompileRequest request, ref IComponentType* outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgramWithEntryPoints")]
        public unsafe partial int SpCompileRequestGetProgramWithEntryPoints(ICompileRequest* request, IComponentType** outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgramWithEntryPoints")]
        public unsafe partial int SpCompileRequestGetProgramWithEntryPoints(ICompileRequest* request, ref IComponentType* outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgramWithEntryPoints")]
        public unsafe partial int SpCompileRequestGetProgramWithEntryPoints(ref ICompileRequest request, IComponentType** outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getProgramWithEntryPoints")]
        public unsafe partial int SpCompileRequestGetProgramWithEntryPoints(ref ICompileRequest request, ref IComponentType* outProgram);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getEntryPoint")]
        public unsafe partial int SpCompileRequestGetEntryPoint(ICompileRequest* request, long entryPointIndex, IComponentType** outEntryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getEntryPoint")]
        public unsafe partial int SpCompileRequestGetEntryPoint(ICompileRequest* request, long entryPointIndex, ref IComponentType* outEntryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getEntryPoint")]
        public unsafe partial int SpCompileRequestGetEntryPoint(ref ICompileRequest request, long entryPointIndex, IComponentType** outEntryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getEntryPoint")]
        public unsafe partial int SpCompileRequestGetEntryPoint(ref ICompileRequest request, long entryPointIndex, ref IComponentType* outEntryPoint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getModule")]
        public unsafe partial int SpCompileRequestGetModule(ICompileRequest* request, long translationUnitIndex, IModule** outModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getModule")]
        public unsafe partial int SpCompileRequestGetModule(ICompileRequest* request, long translationUnitIndex, ref IModule* outModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getModule")]
        public unsafe partial int SpCompileRequestGetModule(ref ICompileRequest request, long translationUnitIndex, IModule** outModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 27 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getModule")]
        public unsafe partial int SpCompileRequestGetModule(ref ICompileRequest request, long translationUnitIndex, ref IModule* outModule);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getSession")]
        public unsafe partial int SpCompileRequestGetSession(ICompileRequest* request, ISession** outSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getSession")]
        public unsafe partial int SpCompileRequestGetSession(ICompileRequest* request, ref ISession* outSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getSession")]
        public unsafe partial int SpCompileRequestGetSession(ref ICompileRequest request, ISession** outSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 5 in slang-deprecated.h")]
        [NativeApi(EntryPoint = "spCompileRequest_getSession")]
        public unsafe partial int SpCompileRequestGetSession(ref ICompileRequest request, ref ISession* outSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4714, Column 23 in slang.h")]
        [NativeApi(EntryPoint = "slang_getEmbeddedCoreModule")]
        public unsafe partial IBlob* SLANGgetEmbeddedCoreModule();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        public unsafe void SpSetFileSystem<TI0>(ICompileRequest* request, ComPtr<TI0> fileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            SpSetFileSystem(request, (IFileSystem*) fileSystem.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 66, Column 20 in slang-deprecated.h")]
        public unsafe void SpSetFileSystem<TI0>(ref ICompileRequest request, ComPtr<TI0> fileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            SpSetFileSystem(ref request, (IFileSystem*) fileSystem.Handle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        public unsafe int SpProcessCommandLineArguments(ICompileRequest* request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argsSa, int argCount)
        {
            // StringArrayOverloader
            var args = (byte**) SilkMarshal.StringArrayToPtr(argsSa);
            var ret = SpProcessCommandLineArguments(request, args, argCount);
            SilkMarshal.CopyPtrToStringArray((nint) args, argsSa);
            SilkMarshal.Free((nint) args);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 192, Column 27 in slang-deprecated.h")]
        public unsafe int SpProcessCommandLineArguments(ref ICompileRequest request, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] argsSa, int argCount)
        {
            // StringArrayOverloader
            var args = (byte**) SilkMarshal.StringArrayToPtr(argsSa);
            var ret = SpProcessCommandLineArguments(ref request, args, argCount);
            SilkMarshal.CopyPtrToStringArray((nint) args, argsSa);
            SilkMarshal.Free((nint) args);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(request, translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(request, translationUnitIndex, in name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ICompileRequest* request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(request, translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(ref request, translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(ref request, translationUnitIndex, in name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 267, Column 19 in slang-deprecated.h")]
        public unsafe int SpAddEntryPointEx(ref ICompileRequest request, int translationUnitIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Stage stage, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpAddEntryPointEx(ref request, translationUnitIndex, name, stage, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        public unsafe int SpSetGlobalGenericArgs(ICompileRequest* request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpSetGlobalGenericArgs(request, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 276, Column 27 in slang-deprecated.h")]
        public unsafe int SpSetGlobalGenericArgs(ref ICompileRequest request, int genericArgCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] genericArgsSa)
        {
            // StringArrayOverloader
            var genericArgs = (byte**) SilkMarshal.StringArrayToPtr(genericArgsSa);
            var ret = SpSetGlobalGenericArgs(ref request, genericArgCount, genericArgs);
            SilkMarshal.CopyPtrToStringArray((nint) genericArgs, genericArgsSa);
            SilkMarshal.Free((nint) genericArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadRepro<TI0>(ICompileRequest* request, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadRepro(request, (IFileSystem*) fileSystem.Handle, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadRepro<T0, TI0>(ICompileRequest* request, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadRepro(request, (IFileSystem*) fileSystem.Handle, in data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadRepro<TI0>(ref ICompileRequest request, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data, nuint size) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadRepro(ref request, (IFileSystem*) fileSystem.Handle, data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadRepro<T0, TI0>(ref ICompileRequest request, ComPtr<TI0> fileSystem, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data, nuint size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadRepro(ref request, (IFileSystem*) fileSystem.Handle, in data, size);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0, TI1>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref ComPtr<TI1> outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref IFileSystemExt* outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref ComPtr<TI0> outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, reproData, reproDataSize, ref replaceFileSystem, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0, TI1>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref ComPtr<TI1> outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, in reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, in reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0>(IGlobalSession* session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref ComPtr<TI0> outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(session, in reproData, reproDataSize, ref replaceFileSystem, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0, TI1>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref ComPtr<TI1> outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref IFileSystemExt* outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<TI0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref ComPtr<TI0> outFileSystem) where TI0 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, reproData, reproDataSize, ref replaceFileSystem, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0, TI1>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref ComPtr<TI1> outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI1>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, in reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ComPtr<TI0> replaceFileSystem, ref IFileSystemExt* outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystem>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, in reproData, reproDataSize, (IFileSystem*) replaceFileSystem.Handle, ref outFileSystem);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 404, Column 27 in slang-deprecated.h")]
        public unsafe int SpLoadReproAsFileSystem<T0, TI0>(ref IGlobalSession session, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 reproData, nuint reproDataSize, ref IFileSystem replaceFileSystem, ref ComPtr<TI0> outFileSystem) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IFileSystemExt>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpLoadReproAsFileSystem(ref session, in reproData, reproDataSize, ref replaceFileSystem, (IFileSystemExt**) outFileSystem.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetProgram<TI0>(ICompileRequest* request, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetProgram(request, (IComponentType**) outProgram.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 986, Column 5 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetProgram<TI0>(ref ICompileRequest request, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetProgram(ref request, (IComponentType**) outProgram.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetProgramWithEntryPoints<TI0>(ICompileRequest* request, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetProgramWithEntryPoints(request, (IComponentType**) outProgram.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 990, Column 27 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetProgramWithEntryPoints<TI0>(ref ICompileRequest request, ref ComPtr<TI0> outProgram) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetProgramWithEntryPoints(ref request, (IComponentType**) outProgram.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetEntryPoint<TI0>(ICompileRequest* request, long entryPointIndex, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetEntryPoint(request, entryPointIndex, (IComponentType**) outEntryPoint.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 996, Column 27 in slang-deprecated.h")]
        public unsafe int SpCompileRequestGetEntryPoint<TI0>(ref ICompileRequest request, long entryPointIndex, ref ComPtr<TI0> outEntryPoint) where TI0 : unmanaged, IComVtbl<IComponentType>, IComVtbl<TI0>
        {
            // ComPtrOverloader
            return SpCompileRequestGetEntryPoint(ref request, entryPointIndex, (IComponentType**) outEntryPoint.GetAddressOf());
        }


        public Slang(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

