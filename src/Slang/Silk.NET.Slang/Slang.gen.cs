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
        public const int SlangVC = unchecked((int) 0xE);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_CLANG")]
        public const int SlangClang = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_SNC")]
        public const int SlangSnc = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_GHS")]
        public const int SlangGhs = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_GCC")]
        public const int SlangGcc = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIN64")]
        public const int SlangWin64 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WINRT")]
        public const int SlangWinrt = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_XBOXONE")]
        public const int SlangXboxone = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_X360")]
        public const int SlangX360 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIN32")]
        public const int SlangWin32 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ANDROID")]
        public const int SlangAndroid = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_LINUX")]
        public const int SlangLinux = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_IOS")]
        public const int SlangIos = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_OSX")]
        public const int SlangOsx = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PS3")]
        public const int SlangPS3 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PS4")]
        public const int SlangPS4 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PSP2")]
        public const int SlangPsp2 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_WIIU")]
        public const int SlangWiiu = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXVK")]
        public const int SlangEnableDxvk = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_VKD3D")]
        public const int SlangEnableVkd3D = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DIRECTX")]
        public const int SlangEnableDirectx = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXGI_DEBUG")]
        public const int SlangEnableDxgiDebug = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_DXBC_SUPPORT")]
        public const int SlangEnableDxbcSupport = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_ENABLE_PIX")]
        public const int SlangEnablePix = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_EXCEPTIONS")]
        public const int SlangHasExceptions = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_MOVE_SEMANTICS")]
        public const int SlangHasMoveSemantics = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_HAS_ENUM_CLASS")]
        public const int SlangHasEnumClass = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_X86_64")]
        public const int SlangProcessorX8664 = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_ARM")]
        public const int SlangProcessorArm = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_ARM_64")]
        public const int SlangProcessorArm64 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_X86")]
        public const int SlangProcessorX86 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_POWER_PC")]
        public const int SlangProcessorPowerPC = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_PROCESSOR_POWER_PC_64")]
        public const int SlangProcessorPowerPC64 = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_LITTLE_ENDIAN")]
        public const int SlangLittleEndian = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_UNALIGNED_ACCESS")]
        public const int SlangUnalignedAccess = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_BIG_ENDIAN")]
        public const int SlangBigEndian = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_GENERAL")]
        public const int SlangFacilityWinGeneral = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_INTERFACE")]
        public const int SlangFacilityWinInterface = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_WIN_API")]
        public const int SlangFacilityWinApi = unchecked((int) 0x7);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_BASE")]
        public const int SlangFacilityBase = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_CORE")]
        public const int SlangFacilityCore = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_FACILITY_EXTERNAL_BASE")]
        public const int SlangFacilityExternalBase = unchecked((int) 0x210);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_OK")]
        public const int SlangOK = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "SLANG_API_VERSION")]
        public const int SlangApiVersion = unchecked((int) 0x0);

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
        public unsafe partial int SlangCreateGlobalSession(long apiVersion, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4537, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession")]
        public unsafe partial int SlangCreateGlobalSession(long apiVersion, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SlangCreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangGlobalSessionDesc* desc, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SlangCreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] SlangGlobalSessionDesc* desc, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SlangCreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangGlobalSessionDesc desc, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4545, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSession2")]
        public unsafe partial int SlangCreateGlobalSession2([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SlangGlobalSessionDesc desc, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4557, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSessionWithoutCoreModule")]
        public unsafe partial int SlangCreateGlobalSessionWithoutCoreModule(long apiVersion, IGlobalSession** outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4557, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createGlobalSessionWithoutCoreModule")]
        public unsafe partial int SlangCreateGlobalSessionWithoutCoreModule(long apiVersion, ref IGlobalSession* outGlobalSession);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4566, Column 23 in slang.h")]
        [NativeApi(EntryPoint = "slang_getEmbeddedCoreModule")]
        public unsafe partial ISlangBlob* SlangGetEmbeddedCoreModule();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4574, Column 31 in slang.h")]
        [NativeApi(EntryPoint = "slang_shutdown")]
        public partial void SlangShutdown();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4578, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_getLastInternalErrorMessage")]
        public unsafe partial byte* SlangGetLastInternalErrorMessage();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4578, Column 38 in slang.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "slang_getLastInternalErrorMessage")]
        public partial string SlangGetLastInternalErrorMessageS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SlangCreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] ByteCodeRunnerDesc* desc, IByteCodeRunner** outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SlangCreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] ByteCodeRunnerDesc* desc, ref IByteCodeRunner* outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SlangCreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ByteCodeRunnerDesc desc, IByteCodeRunner** outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4691, Column 38 in slang.h")]
        [NativeApi(EntryPoint = "slang_createByteCodeRunner")]
        public unsafe partial int SlangCreateByteCodeRunner([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ByteCodeRunnerDesc desc, ref IByteCodeRunner* outByteCodeRunner);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SlangDisassembleByteCode(ISlangBlob* moduleBlob, ISlangBlob** outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SlangDisassembleByteCode(ISlangBlob* moduleBlob, ref ISlangBlob* outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SlangDisassembleByteCode(ref ISlangBlob moduleBlob, ISlangBlob** outDisassemblyBlob);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 4697, Column 1 in slang.h")]
        [NativeApi(EntryPoint = "slang_disassembleByteCode")]
        public unsafe partial int SlangDisassembleByteCode(ref ISlangBlob moduleBlob, ref ISlangBlob* outDisassemblyBlob);


        public Slang(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

