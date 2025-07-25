// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.EWX;
using static Silk.NET.Win32.POINTER;
using static Silk.NET.Win32.RIDEV;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static int Gui16Bittask
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return 0x00000020;
            }
            else
            {
                return 0x00000000;
            }
        }
    }

    [NativeTypeName("#define GetWindowLongPtr GetWindowLongPtrW")]
    public static delegate* <HWND, int, nint> GetWindowLongPtr => &GetWindowLongPtrW;

    [NativeTypeName("#define SetWindowLongPtr SetWindowLongPtrW")]
    public static delegate* <HWND, int, nint, nint> SetWindowLongPtr => &SetWindowLongPtrW;

    [NativeTypeName("#define GetClassLongPtr GetClassLongPtrW")]
    public static delegate* <HWND, int, nuint> GetClassLongPtr => &GetClassLongPtrW;

    [NativeTypeName("#define SetClassLongPtr SetClassLongPtrW")]
    public static delegate* <HWND, int, nint, nuint> SetClassLongPtr => &SetClassLongPtrW;

    [NativeTypeName("#define GR_GLOBAL ((HANDLE)-2)")]
    public static Handle GrGlobal => ((Handle)(-2));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCSTR")] sbyte* lpName,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => CreateDialogParamA(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateDialogA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCSTR")] Ref<sbyte> lpName,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (sbyte* __dsl_lpName = lpName)
        {
            return (HWND)CreateDialogA(hInstance, __dsl_lpName, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogIndirectA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) =>
        CreateDialogIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateDialogIndirectA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] Ref<DLGTEMPLATE> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (DLGTEMPLATE* __dsl_lpTemplate = lpTemplate)
        {
            return (HWND)CreateDialogIndirectA(
                hInstance,
                __dsl_lpTemplate,
                hWndParent,
                lpDialogFunc
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogIndirectW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) =>
        CreateDialogIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateDialogIndirectW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] Ref<DLGTEMPLATE> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (DLGTEMPLATE* __dsl_lpTemplate = lpTemplate)
        {
            return (HWND)CreateDialogIndirectW(
                hInstance,
                __dsl_lpTemplate,
                hWndParent,
                lpDialogFunc
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateDialogW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCWSTR")] char* lpName,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => CreateDialogParamW(hInstance, lpName, hWndParent, lpDialogFunc, dwInitParam: 0);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateDialogW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCWSTR")] Ref<char> lpName,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (char* __dsl_lpName = lpName)
        {
            return (HWND)CreateDialogW(hInstance, __dsl_lpName, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateWindowA(
        [NativeTypeName("LPCSTR")] sbyte* lpClassName,
        [NativeTypeName("LPCSTR")] sbyte* lpWindowName,
        [NativeTypeName("DWORD")] uint dwStyle,
        int x,
        int y,
        int nWidth,
        int nHeight,
        HWND hWndParent,
        HMENU hMenu,
        HINSTANCE hInstance,
        [NativeTypeName("LPVOID")] void* lpParam
    ) =>
        CreateWindowExA(
            0,
            lpClassName,
            lpWindowName,
            dwStyle,
            x,
            y,
            nWidth,
            nHeight,
            hWndParent,
            hMenu,
            hInstance,
            lpParam
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateWindowA(
        [NativeTypeName("LPCSTR")] Ref<sbyte> lpClassName,
        [NativeTypeName("LPCSTR")] Ref<sbyte> lpWindowName,
        [NativeTypeName("DWORD")] uint dwStyle,
        int x,
        int y,
        int nWidth,
        int nHeight,
        HWND hWndParent,
        HMENU hMenu,
        HINSTANCE hInstance,
        [NativeTypeName("LPVOID")] Ref lpParam
    )
    {
        fixed (void* __dsl_lpParam = lpParam)
        fixed (sbyte* __dsl_lpWindowName = lpWindowName)
        fixed (sbyte* __dsl_lpClassName = lpClassName)
        {
            return (HWND)CreateWindowA(
                __dsl_lpClassName,
                __dsl_lpWindowName,
                dwStyle,
                x,
                y,
                nWidth,
                nHeight,
                hWndParent,
                hMenu,
                hInstance,
                __dsl_lpParam
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND CreateWindowW(
        [NativeTypeName("LPCWSTR")] char* lpClassName,
        [NativeTypeName("LPCWSTR")] char* lpWindowName,
        [NativeTypeName("DWORD")] uint dwStyle,
        int x,
        int y,
        int nWidth,
        int nHeight,
        HWND hWndParent,
        HMENU hMenu,
        HINSTANCE hInstance,
        [NativeTypeName("LPVOID")] void* lpParam
    ) =>
        CreateWindowExW(
            0,
            lpClassName,
            lpWindowName,
            dwStyle,
            x,
            y,
            nWidth,
            nHeight,
            hWndParent,
            hMenu,
            hInstance,
            lpParam
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND CreateWindowW(
        [NativeTypeName("LPCWSTR")] Ref<char> lpClassName,
        [NativeTypeName("LPCWSTR")] Ref<char> lpWindowName,
        [NativeTypeName("DWORD")] uint dwStyle,
        int x,
        int y,
        int nWidth,
        int nHeight,
        HWND hWndParent,
        HMENU hMenu,
        HINSTANCE hInstance,
        [NativeTypeName("LPVOID")] Ref lpParam
    )
    {
        fixed (void* __dsl_lpParam = lpParam)
        fixed (char* __dsl_lpWindowName = lpWindowName)
        fixed (char* __dsl_lpClassName = lpClassName)
        {
            return (HWND)CreateWindowW(
                __dsl_lpClassName,
                __dsl_lpWindowName,
                dwStyle,
                x,
                y,
                nWidth,
                nHeight,
                hWndParent,
                hMenu,
                hInstance,
                __dsl_lpParam
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Lresult DefHookProc(int nCode, Wparam wParam, Lparam lParam, HHOOK phhk) =>
        CallNextHookEx(phhk, nCode, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static nint DialogBoxA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCSTR")] sbyte* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => DialogBoxParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [return: NativeTypeName("INT_PTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint DialogBoxA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCSTR")] Ref<sbyte> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (sbyte* __dsl_lpTemplate = lpTemplate)
        {
            return (nint)DialogBoxA(hInstance, __dsl_lpTemplate, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static nint DialogBoxIndirectA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEA")] DLGTEMPLATE* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => DialogBoxIndirectParamA(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [return: NativeTypeName("INT_PTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint DialogBoxIndirectA(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEA")] Ref<DLGTEMPLATE> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (DLGTEMPLATE* __dsl_lpTemplate = lpTemplate)
        {
            return (nint)DialogBoxIndirectA(hInstance, __dsl_lpTemplate, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static nint DialogBoxIndirectW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] DLGTEMPLATE* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => DialogBoxIndirectParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [return: NativeTypeName("INT_PTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint DialogBoxIndirectW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCDLGTEMPLATEW")] Ref<DLGTEMPLATE> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (DLGTEMPLATE* __dsl_lpTemplate = lpTemplate)
        {
            return (nint)DialogBoxIndirectW(hInstance, __dsl_lpTemplate, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("INT_PTR")]
    public static nint DialogBoxW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCWSTR")] char* lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    ) => DialogBoxParamW(hInstance, lpTemplate, hWndParent, lpDialogFunc, dwInitParam: 0);

    [return: NativeTypeName("INT_PTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static nint DialogBoxW(
        HINSTANCE hInstance,
        [NativeTypeName("LPCWSTR")] Ref<char> lpTemplate,
        HWND hWndParent,
        [NativeTypeName("DLGPROC")]
            delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpDialogFunc
    )
    {
        fixed (char* __dsl_lpTemplate = lpTemplate)
        {
            return (nint)DialogBoxW(hInstance, __dsl_lpTemplate, hWndParent, lpDialogFunc);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MaybeBool<int> EnumTaskWindows(
        HTASK hTask,
        [NativeTypeName("WNDENUMPROC")] delegate* unmanaged<HWND, Lparam, MaybeBool<int>> lpfn,
        Lparam lParam
    ) => EnumThreadWindows((uint)hTask, lpfn, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MaybeBool<int> ExitWindows(uint dwReserved, int Code) =>
        ExitWindowsEx(EWX_LOGOFF, 0xFFFFFFFF);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GetAppcommandLparam(Lparam lParam) =>
        unchecked((short)(Hiword((uint)lParam) & ~FAPPCOMMAND_MASK));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetDeviceChangeLparam(Lparam lParam) => Loword(unchecked((uint)lParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetDeviceChangeWparam(Wparam wParam) => Loword(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetDeviceLparam(Lparam lParam) =>
        unchecked((ushort)(Hiword((uint)lParam) & FAPPCOMMAND_MASK));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetFlagsLparam(Lparam lParam) => Loword(unchecked((uint)lParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetKeystateLparam(Lparam lParam) => GetFlagsLparam(lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetKeystateWparam(Wparam wParam) => Loword(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetMouseorkeyLparam(Lparam lParam) => GetDeviceLparam(lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GetNchittestWparam(Wparam wParam) => unchecked((short)Loword((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetPointeridWparam(Wparam wParam) => Loword(unchecked((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static nuint GetRawinputCodeWparam(Wparam wParam) => wParam & (nuint)(0xFFu);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int GetScWparam(Wparam wParam) => unchecked((int)(wParam & 0xFFF0));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static short GetWheelDeltaWparam(Wparam wParam) =>
        unchecked((short)Hiword((uint)wParam));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GetXbuttonWparam(Wparam wParam) => Hiword(unchecked((uint)wParam));

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint GetClassLongPtrA(HWND hWnd, int nIndex)
    {
        if (sizeof(nuint) == 4)
        {
            return GetClassLongA(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetClassLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _GetClassLongPtrA(HWND hWnd, int nIndex);
            return _GetClassLongPtrA(hWnd, nIndex);
        }
    }

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint GetClassLongPtrW(HWND hWnd, int nIndex)
    {
        if (sizeof(nuint) == 4)
        {
            return GetClassLongW(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetClassLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _GetClassLongPtrW(HWND hWnd, int nIndex);
            return _GetClassLongPtrW(hWnd, nIndex);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND GetNextWindow(HWND hWnd, ushort wCmd) => GetWindow(hWnd, wCmd);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND GetSysModalWindow() => (HWND)(Null);

    [return: NativeTypeName("LONG_PTR")]
    public static nint GetWindowLongPtrA(HWND hWnd, int nIndex)
    {
        if (sizeof(nint) == 4)
        {
            return GetWindowLongA(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetWindowLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _GetWindowLongPtrA(HWND hWnd, int nIndex);
            return _GetWindowLongPtrA(hWnd, nIndex);
        }
    }

    [return: NativeTypeName("LONG_PTR")]
    public static nint GetWindowLongPtrW(HWND hWnd, int nIndex)
    {
        if (sizeof(nint) == 4)
        {
            return GetWindowLongW(hWnd, nIndex);
        }
        else
        {
            [DllImport("user32", EntryPoint = "GetWindowLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _GetWindowLongPtrW(HWND hWnd, int nIndex);
            return _GetWindowLongPtrW(hWnd, nIndex);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Handle GetWindowTask(HWND hWnd) => (Handle)GetWindowThreadProcessId(hWnd, null);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static double GidRotateAngleFromArgument(double _arg_) =>
        (_arg_ / 65535.0 * 4.0 * 3.14159265) - (2.0 * 3.14159265);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort GidRotateAngleToArgument(ushort _arg_) =>
        (ushort)((_arg_ + (2.0 * 3.14159265)) / (4.0 * 3.14159265) * 65535.0);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool HasPointerConfidenceWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_CONFIDENCE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsIntresource([NativeTypeName("ULONG_PTR")] nuint _r)
    {
        return (_r >> 16) == 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerCanceledWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_CANCELED);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerFifthbuttonWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_FIFTHBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerFirstbuttonWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_FIRSTBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerFlagSetWparam(Wparam wParam, uint flag) =>
        (Hiword(unchecked((uint)wParam)) & flag) == flag;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerFourthbuttonWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_FOURTHBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerIncontactWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_INCONTACT);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerInrangeWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_INRANGE);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerNewWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_NEW);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerPrimaryWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_PRIMARY);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerSecondbuttonWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_SECONDBUTTON);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsPointerThirdbuttonWparam(Wparam wParam) =>
        IsPointerFlagSetWparam(wParam, POINTER_MESSAGE_FLAG_THIRDBUTTON);

    [return: NativeTypeName("LPWSTR")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<char> Makeintresource(ushort i) => (char*)MakeintresourceRaw(i);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [return: NativeTypeName("LPWSTR")]
    public static char* MakeintresourceRaw(ushort i) => (char*)(nuint)i;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Lparam Makelparam(
        [NativeTypeName("DWORD_PTR")] nuint l,
        [NativeTypeName("DWORD_PTR")] nuint h
    ) => unchecked((Lparam)(uint)Makelong(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Lparam Makelparam(nint l, nint h) =>
        unchecked(Makelparam((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Lresult Makelresult(
        [NativeTypeName("DWORD_PTR")] nuint l,
        [NativeTypeName("DWORD_PTR")] nuint h
    ) => unchecked((Lresult)(uint)Makelong(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Lresult Makelresult(nint l, nint h) =>
        unchecked(Makelresult((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Wparam Makewparam(
        [NativeTypeName("DWORD_PTR")] nuint l,
        [NativeTypeName("DWORD_PTR")] nuint h
    ) => unchecked((Wparam)(uint)Makelong(l, h));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Wparam Makewparam(nint l, nint h) =>
        unchecked(Makewparam((nuint)(l), (nuint)(h)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static RAWINPUT* Nextrawinputblock(RAWINPUT* ptr) =>
        (RAWINPUT*)(RawinputAlign((nint)ptr) + ptr->header.dwSize);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<RAWINPUT> Nextrawinputblock(Ref<RAWINPUT> ptr)
    {
        fixed (RAWINPUT* __dsl_ptr = ptr)
        {
            return (RAWINPUT*)Nextrawinputblock(__dsl_ptr);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Point Pointstopoint(POINTS pts)
    {
        return new Point
        {
            x = unchecked((int)(short)Loword(*(int*)&pts)),
            y = unchecked((int)(short)Hiword(*(int*)&pts)),
        };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int Pointtopoints(POINTS pt) =>
        unchecked(Makelong((nuint)(short)pt.x, (nuint)(short)pt.y));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MaybeBool<int> PostAppMessageA(
        [NativeTypeName("DWORD")] uint idThread,
        uint wMsg,
        Wparam wParam,
        Lparam lParam
    ) => PostThreadMessageA(idThread, wMsg, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MaybeBool<int> PostAppMessageW(
        [NativeTypeName("DWORD")] uint idThread,
        uint wMsg,
        Wparam wParam,
        Lparam lParam
    ) => PostThreadMessageW(idThread, wMsg, wParam, lParam);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static nint RawinputAlign(nint x) => (x + sizeof(nint) - 1) & ~(sizeof(nint) - 1);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int RidevExmode(int mode) => mode & RIDEV_EXMODEMASK;

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint SetClassLongPtrA(
        HWND hWnd,
        int nIndex,
        [NativeTypeName("LONG_PTR")] nint dwNewLong
    )
    {
        if (sizeof(nuint) == 4)
        {
            return SetClassLongA(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetClassLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _SetClassLongPtrA(
                HWND hWnd,
                int nIndex,
                [NativeTypeName("LONG_PTR")] nint dwNewLong
            );
            return _SetClassLongPtrA(hWnd, nIndex, dwNewLong);
        }
    }

    [return: NativeTypeName("ULONG_PTR")]
    public static nuint SetClassLongPtrW(
        HWND hWnd,
        int nIndex,
        [NativeTypeName("LONG_PTR")] nint dwNewLong
    )
    {
        if (sizeof(nuint) == 4)
        {
            return SetClassLongW(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetClassLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("ULONG_PTR")]
            static extern nuint _SetClassLongPtrW(
                HWND hWnd,
                int nIndex,
                [NativeTypeName("LONG_PTR")] nint dwNewLong
            );
            return _SetClassLongPtrW(hWnd, nIndex, dwNewLong);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static HWND SetSysModalWindow(HWND hWnd) => (HWND)(Null);

    [return: NativeTypeName("LONG_PTR")]
    public static nint SetWindowLongPtrA(
        HWND hWnd,
        int nIndex,
        [NativeTypeName("LONG_PTR")] nint dwNewLong
    )
    {
        if (sizeof(nint) == 4)
        {
            return SetWindowLongA(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetWindowLongPtrA", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _SetWindowLongPtrA(
                HWND hWnd,
                int nIndex,
                [NativeTypeName("LONG_PTR")] nint dwNewLong
            );
            return _SetWindowLongPtrA(hWnd, nIndex, dwNewLong);
        }
    }

    [return: NativeTypeName("LONG_PTR")]
    public static nint SetWindowLongPtrW(
        HWND hWnd,
        int nIndex,
        [NativeTypeName("LONG_PTR")] nint dwNewLong
    )
    {
        if (sizeof(nint) == 4)
        {
            return SetWindowLongW(hWnd, nIndex, (int)dwNewLong);
        }
        else
        {
            [DllImport("user32", EntryPoint = "SetWindowLongPtrW", ExactSpelling = true)]
            [return: NativeTypeName("LONG_PTR")]
            static extern nint _SetWindowLongPtrW(
                HWND hWnd,
                int nIndex,
                [NativeTypeName("LONG_PTR")] nint dwNewLong
            );
            return _SetWindowLongPtrW(hWnd, nIndex, dwNewLong);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int TouchCoordToPixel(int l) => l / 100;
}
