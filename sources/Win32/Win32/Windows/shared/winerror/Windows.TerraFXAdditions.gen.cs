// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Win32.FACILITY;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static partial class Windows
{
    public static bool Failed(HResult hr)
    {
        return hr < 0;
    }

    public static int HresultCode(HResult hr)
    {
        return hr & 0xFFFF;
    }

    public static int HresultFacility(HResult hr)
    {
        return (hr >> 16) & 0x1FFF;
    }

    public static HResult HresultFromNt(int x)
    {
        return ((HResult)((x) | FACILITY_NT_BIT));
    }

    public static HRESULT HresultFromWin32(int x)
    {
        return (x <= 0)
            ? x
            : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
    }

    public static int HresultSeverity(HResult hr)
    {
        return (hr >> 31) & 0x1;
    }

    public static bool IsError(HResult Status)
    {
        return ((uint)Status >> 31) == SEVERITY_ERROR;
    }

    public static HResult MakeHresult(int sev, int fac, int code)
    {
        return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
    }

    public static HResult MakeScode(int sev, int fac, int code)
    {
        return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
    }

    public static int ScodeCode(HResult sc)
    {
        return sc & 0xFFFF;
    }

    public static int ScodeFacility(HResult sc)
    {
        return (sc >> 16) & 0x1FFF;
    }

    public static int ScodeSeverity(HResult sc)
    {
        return (sc >> 31) & 0x1;
    }

    public static bool Succeeded(HRESULT hr)
    {
        return hr >= 0;
    }
}
