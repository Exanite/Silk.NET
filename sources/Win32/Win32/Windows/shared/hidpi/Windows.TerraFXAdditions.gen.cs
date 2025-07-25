// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.FACILITY;
using static Silk.NET.Win32.HIDP;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int HidpErrorCodes(int sev, int code) =>
        (sev << 28) | (FACILITY_HID_ERROR_CODE << 16) | code;

    public static int HidPGetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] ushort* UsageList,
        [NativeTypeName("PULONG")] uint* UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] sbyte* Report,
        [NativeTypeName("ULONG")] uint ReportLength
    ) =>
        HidP_GetUsages(
            ReportType,
            UsagePage,
            LinkCollection,
            UsageList,
            UsageLength,
            PreparsedData,
            Report,
            ReportLength
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int HidPGetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] Ref<ushort> UsageList,
        [NativeTypeName("PULONG")] Ref<uint> UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] Ref<sbyte> Report,
        [NativeTypeName("ULONG")] uint ReportLength
    )
    {
        fixed (sbyte* __dsl_Report = Report)
        fixed (uint* __dsl_UsageLength = UsageLength)
        fixed (ushort* __dsl_UsageList = UsageList)
        {
            return (int)HidPGetButtons(
                ReportType,
                UsagePage,
                LinkCollection,
                __dsl_UsageList,
                __dsl_UsageLength,
                PreparsedData,
                __dsl_Report,
                ReportLength
            );
        }
    }

    public static int HidPGetButtonsEx(
        HIDP_REPORT_TYPE ReportType,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE_AND_PAGE")] USAGE_AND_PAGE* ButtonList,
        [NativeTypeName("ULONG *")] uint* UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] sbyte* Report,
        [NativeTypeName("ULONG")] uint ReportLength
    ) =>
        HidP_GetUsagesEx(
            ReportType,
            LinkCollection,
            ButtonList,
            UsageLength,
            PreparsedData,
            Report,
            ReportLength
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int HidPGetButtonsEx(
        HIDP_REPORT_TYPE ReportType,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE_AND_PAGE")] Ref<USAGE_AND_PAGE> ButtonList,
        [NativeTypeName("ULONG *")] Ref<uint> UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] Ref<sbyte> Report,
        [NativeTypeName("ULONG")] uint ReportLength
    )
    {
        fixed (sbyte* __dsl_Report = Report)
        fixed (uint* __dsl_UsageLength = UsageLength)
        fixed (USAGE_AND_PAGE* __dsl_ButtonList = ButtonList)
        {
            return (int)HidPGetButtonsEx(
                ReportType,
                LinkCollection,
                __dsl_ButtonList,
                __dsl_UsageLength,
                PreparsedData,
                __dsl_Report,
                ReportLength
            );
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HidP_GetVersion"]/*'/>

    [return: NativeTypeName("NTSTATUS")]
    public static int HidPGetVersion([NativeTypeName("ULONG *")] uint* Version)
    {
        int status = HIDP_STATUS_SUCCESS;
        *Version = 1;
        Hmodule module;
        fixed (char* lpLibFileName = "hid.dll")
        {
            module = LoadLibraryW(lpLibFileName);
        }
        if (module == Hmodule.NULL)
        {
            return HIDP_STATUS_INTERNAL_ERROR;
        }
        delegate* unmanaged<uint*, int> fnVersionInternal;
        fixed (byte* lpProcName = "HidP_GetVersionInternal"u8)
        {
            fnVersionInternal = (delegate* unmanaged<uint*, int>)GetProcAddress(
                module,
                (sbyte*)lpProcName
            );
        }
        if (fnVersionInternal != null)
        {
            status = fnVersionInternal(Version);
        }
        return status;
    }

    [return: NativeTypeName("NTSTATUS")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int HidPGetVersion([NativeTypeName("ULONG *")] Ref<uint> Version)
    {
        fixed (uint* __dsl_Version = Version)
        {
            return (int)HidPGetVersion(__dsl_Version);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HidPIsSameUsageAndPage(USAGE_AND_PAGE* u1, USAGE_AND_PAGE* u2) =>
        *(uint*)u1 == *(uint*)u2;

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static bool HidPIsSameUsageAndPage(Ref<USAGE_AND_PAGE> u1, Ref<USAGE_AND_PAGE> u2)
    {
        fixed (USAGE_AND_PAGE* __dsl_u2 = u2)
        fixed (USAGE_AND_PAGE* __dsl_u1 = u1)
        {
            return (bool)HidPIsSameUsageAndPage(__dsl_u1, __dsl_u2);
        }
    }

    public static int HidPSetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] ushort* UsageList,
        [NativeTypeName("PULONG")] uint* UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] sbyte* Report,
        [NativeTypeName("ULONG")] uint ReportLength
    ) =>
        HidP_SetUsages(
            ReportType,
            UsagePage,
            LinkCollection,
            UsageList,
            UsageLength,
            PreparsedData,
            Report,
            ReportLength
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int HidPSetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] Ref<ushort> UsageList,
        [NativeTypeName("PULONG")] Ref<uint> UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] Ref<sbyte> Report,
        [NativeTypeName("ULONG")] uint ReportLength
    )
    {
        fixed (sbyte* __dsl_Report = Report)
        fixed (uint* __dsl_UsageLength = UsageLength)
        fixed (ushort* __dsl_UsageList = UsageList)
        {
            return (int)HidPSetButtons(
                ReportType,
                UsagePage,
                LinkCollection,
                __dsl_UsageList,
                __dsl_UsageLength,
                PreparsedData,
                __dsl_Report,
                ReportLength
            );
        }
    }

    public static int HidPUnsetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] ushort* UsageList,
        [NativeTypeName("PULONG")] uint* UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] sbyte* Report,
        [NativeTypeName("ULONG")] uint ReportLength
    ) =>
        HidP_UnsetUsages(
            ReportType,
            UsagePage,
            LinkCollection,
            UsageList,
            UsageLength,
            PreparsedData,
            Report,
            ReportLength
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int HidPUnsetButtons(
        HIDP_REPORT_TYPE ReportType,
        [NativeTypeName("USAGE")] ushort UsagePage,
        ushort LinkCollection,
        [NativeTypeName("PUSAGE")] Ref<ushort> UsageList,
        [NativeTypeName("PULONG")] Ref<uint> UsageLength,
        PHIDP_PREPARSED_DATA PreparsedData,
        [NativeTypeName("PCHAR")] Ref<sbyte> Report,
        [NativeTypeName("ULONG")] uint ReportLength
    )
    {
        fixed (sbyte* __dsl_Report = Report)
        fixed (uint* __dsl_UsageLength = UsageLength)
        fixed (ushort* __dsl_UsageList = UsageList)
        {
            return (int)HidPUnsetButtons(
                ReportType,
                UsagePage,
                LinkCollection,
                __dsl_UsageList,
                __dsl_UsageLength,
                PreparsedData,
                __dsl_Report,
                ReportLength
            );
        }
    }
}
