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
        [NativeName("Src", "Line 1777, Column 27 in slang.h")]
        [NativeApi(EntryPoint = "spGetBuildTagString")]
        public unsafe partial byte* SpGetBuildTagString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1777, Column 27 in slang.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "spGetBuildTagString")]
        public partial string SpGetBuildTagStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4537, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession")]
        public unsafe partial int SLANGcreateGlobalSession(long apiVersion, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4537, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession")]
        public unsafe partial int SLANGcreateGlobalSession(long apiVersion, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SLANGcreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlobalSessionDesc* desc, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SLANGcreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlobalSessionDesc* desc, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SLANGcreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlobalSessionDesc desc, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SLANGcreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlobalSessionDesc desc, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4557, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSessionWithoutCoreModule")]
        public unsafe partial int SLANGcreateGlobalSessionWithoutCoreModule(long apiVersion, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4557, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSessionWithoutCoreModule")]
        public unsafe partial int SLANGcreateGlobalSessionWithoutCoreModule(long apiVersion, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4566, Column 23 in slang.h")]
        [NativeApi(EntryPoint = "slang_getEmbeddedCoreModule")]
        public unsafe partial ISlangBlob* SLANGgetEmbeddedCoreModule();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4574, Column 31 in slang.h")]
        [NativeApi(EntryPoint = "slang_shutdown")]
        public partial void SLANGshutdown();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4578, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_getLastInternalErrorMessage")]
        public unsafe partial byte* SLANGgetLastInternalErrorMessage();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4578, Column 38 in slang.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "slang_getLastInternalErrorMessage")]
        public partial string SLANGgetLastInternalErrorMessageS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SLANGcreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] ByteCodeRunnerDesc* desc, IByteCodeRunner** outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SLANGcreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] ByteCodeRunnerDesc* desc, ref IByteCodeRunner* outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SLANGcreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ByteCodeRunnerDesc desc, IByteCodeRunner** outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SLANGcreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ByteCodeRunnerDesc desc, ref IByteCodeRunner* outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SLANGdisassembleByteCode(ISlangBlob* moduleBlob, ISlangBlob** outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SLANGdisassembleByteCode(ISlangBlob* moduleBlob, ref ISlangBlob* outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SLANGdisassembleByteCode(ref ISlangBlob moduleBlob, ISlangBlob** outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SLANGdisassembleByteCode(ref ISlangBlob moduleBlob, ref ISlangBlob* outDisassemblyBlob);


        public Slang(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

