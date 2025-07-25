// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class E
{
    public const int PdbOk = unchecked((int)((1u << 31) | (0x6Du << 16) | 1));
    public const int PdbUsage = PdbOk + 1;
    public const int PdbOutOfMemory = PdbUsage + 1;
    public const int PdbFileSystem = PdbOutOfMemory + 1;
    public const int PdbNotFound = PdbFileSystem + 1;
    public const int PdbInvalidSig = PdbNotFound + 1;
    public const int PdbInvalidAge = PdbInvalidSig + 1;
    public const int PdbPrecompRequired = PdbInvalidAge + 1;
    public const int PdbOutOfTi = PdbPrecompRequired + 1;
    public const int PdbNotImplemented = PdbOutOfTi + 1;
    public const int PdbV1Pdb = PdbNotImplemented + 1;
    public const int PdbFormat = PdbV1Pdb + 1;
    public const int PdbLimit = PdbFormat + 1;
    public const int PdbCorrupt = PdbLimit + 1;
    public const int PdbTi16 = PdbCorrupt + 1;
    public const int PdbAccessDenied = PdbTi16 + 1;
    public const int PdbIllegalTypeEdit = PdbAccessDenied + 1;
    public const int PdbInvalidExecutable = PdbIllegalTypeEdit + 1;
    public const int PdbDbgNotFound = PdbInvalidExecutable + 1;
    public const int PdbNoDebugInfo = PdbDbgNotFound + 1;
    public const int PdbInvalidExeTimestamp = PdbNoDebugInfo + 1;
    public const int PdbReserved = PdbInvalidExeTimestamp + 1;
    public const int PdbDebugInfoNotInPdb = PdbReserved + 1;
    public const int PdbSymsrvBadCachePath = PdbDebugInfoNotInPdb + 1;
    public const int PdbSymsrvCacheFull = PdbSymsrvBadCachePath + 1;
    public const int PdbObjectDisposed = PdbSymsrvCacheFull + 1;
    public const int PdbMax = PdbObjectDisposed + 1;
    public const int DiaInprolog = unchecked((int)((1u << 31) | (0x6Du << 16) | 100));
    public const int DiaSyntax = DiaInprolog + 1;
    public const int DiaFrameAccess = DiaSyntax + 1;
    public const int DiaValue = DiaFrameAccess + 1;
}
