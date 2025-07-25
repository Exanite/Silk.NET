// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
using static Silk.NET.Win32.EM;
using static Silk.NET.Win32.GWL;
using static Silk.NET.Win32.GWLP;
using static Silk.NET.Win32.SB;
using static Silk.NET.Win32.SW;
using static Silk.NET.Win32.VK;
using static Silk.NET.Win32.WM;
using static Silk.NET.Win32.WS;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    /****** Button control message APIs ******************************************/
    public static MaybeBool<int> ButtonEnable(HWND hwndCtl, MaybeBool<int> fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    public static int ButtonGetCheck(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), BM_GETCHECK, 0u, 0));

    public static int ButtonGetState(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), BM_GETSTATE, 0u, 0));

    public static int ButtonGetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ButtonGetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)ButtonGetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int ButtonGetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static void ButtonSetCheck(HWND hwndCtl, int check) =>
        SNDMSG((hwndCtl), BM_SETCHECK, (Wparam)(int)(check), 0);

    public static uint ButtonSetState(HWND hwndCtl, int state) =>
        ((uint)(uint)SNDMSG((hwndCtl), BM_SETSTATE, (Wparam)(int)(state), 0));

    public static void ButtonSetStyle(HWND hwndCtl, int style, MaybeBool<int> fRedraw) =>
        SNDMSG(
            (hwndCtl),
            BM_SETSTYLE,
            (Wparam)Loword(style),
            Makelparam(((ushort)((fRedraw) ? TRUE : FALSE)), 0)
        );

    public static MaybeBool<int> ButtonSetText(HWND hwndCtl, char* lpsz) =>
        SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ButtonSetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<int>)ButtonSetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static MaybeBool<int> CheckDefDlgRecursion(MaybeBool<int>* pfRecursion)
    {
        if (*(pfRecursion))
        {
            *(pfRecursion) = FALSE;
            return FALSE;
        }
        return TRUE;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> CheckDefDlgRecursion(Ref<MaybeBool<int>> pfRecursion)
    {
        fixed (MaybeBool<int>* __dsl_pfRecursion = pfRecursion)
        {
            return (MaybeBool<int>)CheckDefDlgRecursion(__dsl_pfRecursion);
        }
    }

    public static int ComboBoxAddItemData(HWND hwndCtl, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_ADDSTRING, 0u, (Lparam)(data)));

    public static int ComboBoxAddString(HWND hwndCtl, char* lpsz) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_ADDSTRING, 0u, (Lparam)(char*)(lpsz)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxAddString(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ComboBoxAddString(hwndCtl, __dsl_lpsz);
        }
    }

    public static int ComboBoxDeleteString(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_DELETESTRING, (Wparam)(int)(index), 0));

    public static int ComboBoxDir(HWND hwndCtl, uint attrs, char* lpszFileSpec) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_DIR,
                    (Wparam)(uint)(attrs),
                    (Lparam)(char*)(lpszFileSpec)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxDir(HWND hwndCtl, uint attrs, Ref<char> lpszFileSpec)
    {
        fixed (char* __dsl_lpszFileSpec = lpszFileSpec)
        {
            return (int)ComboBoxDir(hwndCtl, attrs, __dsl_lpszFileSpec);
        }
    }

    /****** ComboBox control message APIs ****************************************/
    public static MaybeBool<int> ComboBoxEnable(HWND hwndCtl, MaybeBool<int> fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    public static int ComboBoxFindItemData(HWND hwndCtl, int indexStart, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_FINDSTRING, (Wparam)(int)(indexStart), (Lparam)(data)));

    public static int ComboBoxFindString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_FINDSTRING,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxFindString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ComboBoxFindString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ComboBoxFindStringExact(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_FINDSTRINGEXACT,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxFindStringExact(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ComboBoxFindStringExact(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ComboBoxGetCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETCOUNT, 0u, 0));

    public static int ComboBoxGetCurSel(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETCURSEL, 0u, 0));

    public static void ComboBoxGetDroppedControlRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), CB_GETDROPPEDCONTROLRECT, 0u, (Lparam)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ComboBoxGetDroppedControlRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            ComboBoxGetDroppedControlRect(hwndCtl, __dsl_lprc);
        }
    }

    public static MaybeBool<int> ComboBoxGetDroppedState(HWND hwndCtl) =>
        ((BOOL)(uint)SNDMSG((hwndCtl), CB_GETDROPPEDSTATE, 0u, 0));

    public static uint ComboBoxGetEditSel(HWND hwndCtl) =>
        ((uint)SNDMSG((hwndCtl), CB_GETEDITSEL, 0u, 0));

    public static uint ComboBoxGetExtendedUI(HWND hwndCtl) =>
        ((uint)(uint)SNDMSG((hwndCtl), CB_GETEXTENDEDUI, 0u, 0));

    public static Lresult ComboBoxGetItemData(HWND hwndCtl, int index) =>
        ((Lresult)(nuint)SNDMSG((hwndCtl), CB_GETITEMDATA, (Wparam)(int)(index), 0));

    public static int ComboBoxGetItemHeight(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETITEMHEIGHT, 0u, 0));

    public static int ComboBoxGetLBText(HWND hwndCtl, int index, char* lpszBuffer) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_GETLBTEXT,
                    (Wparam)(int)(index),
                    (Lparam)(char*)(lpszBuffer)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxGetLBText(HWND hwndCtl, int index, Ref<char> lpszBuffer)
    {
        fixed (char* __dsl_lpszBuffer = lpszBuffer)
        {
            return (int)ComboBoxGetLBText(hwndCtl, index, __dsl_lpszBuffer);
        }
    }

    public static int ComboBoxGetLBTextLen(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_GETLBTEXTLEN, (Wparam)(int)(index), 0));

    public static int ComboBoxGetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxGetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)ComboBoxGetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int ComboBoxGetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static int ComboBoxInsertItemData(HWND hwndCtl, int index, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_INSERTSTRING, (Wparam)(int)(index), (Lparam)(data)));

    public static int ComboBoxInsertString(HWND hwndCtl, int index, char* lpsz) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_INSERTSTRING,
                    (Wparam)(int)(index),
                    (Lparam)(char*)(lpsz)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxInsertString(HWND hwndCtl, int index, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ComboBoxInsertString(hwndCtl, index, __dsl_lpsz);
        }
    }

    public static int ComboBoxLimitText(HWND hwndCtl, int cchLimit) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_LIMITTEXT, (Wparam)(int)(cchLimit), 0));

    public static int ComboBoxResetContent(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_RESETCONTENT, 0u, 0));

    public static int ComboBoxSelectItemData(HWND hwndCtl, int indexStart, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SELECTSTRING, (Wparam)(int)(indexStart), (Lparam)(data)));

    public static int ComboBoxSelectString(HWND hwndCtl, int indexStart, char* lpszSelect) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    CB_SELECTSTRING,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszSelect)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ComboBoxSelectString(HWND hwndCtl, int indexStart, Ref<char> lpszSelect)
    {
        fixed (char* __dsl_lpszSelect = lpszSelect)
        {
            return (int)ComboBoxSelectString(hwndCtl, indexStart, __dsl_lpszSelect);
        }
    }

    public static int ComboBoxSetCurSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETCURSEL, (Wparam)(int)(index), 0));

    public static int ComboBoxSetEditSel(HWND hwndCtl, ushort ichStart, ushort ichEnd) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETEDITSEL, 0u, Makelparam((ichStart), (ichEnd))));

    public static int ComboBoxSetExtendedUI(HWND hwndCtl, uint flags) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETEXTENDEDUI, (Wparam)(uint)(flags), 0));

    public static int ComboBoxSetItemData(HWND hwndCtl, int index, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETITEMDATA, (Wparam)(int)(index), (Lparam)(data)));

    public static int ComboBoxSetItemHeight(HWND hwndCtl, int index, int cyItem) =>
        ((int)(uint)SNDMSG((hwndCtl), CB_SETITEMHEIGHT, (Wparam)(int)(index), (Lparam)(int)cyItem));

    public static MaybeBool<int> ComboBoxSetText(HWND hwndCtl, char* lpsz) =>
        SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ComboBoxSetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<int>)ComboBoxSetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static MaybeBool<int> ComboBoxShowDropdown(HWND hwndCtl, MaybeBool<int> fShow) =>
        (
            (MaybeBool<int>)
                (uint)SNDMSG((hwndCtl), CB_SHOWDROPDOWN, (Wparam)(MaybeBool<int>)(fShow), 0)
        );

    public static int CopyRgn(HRGN hrgnDst, HRGN hrgnSrc) =>
        CombineRgn(hrgnDst, hrgnSrc, HRGN.NULL, RGN_COPY);

    public static Lresult DefDlgProcEx(
        HWND hwnd,
        uint msg,
        Wparam wParam,
        Lparam lParam,
        MaybeBool<int>* pfRecursion
    )
    {
        *(pfRecursion) = TRUE;
        return DefDlgProc(hwnd, msg, wParam, lParam);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Lresult DefDlgProcEx(
        HWND hwnd,
        uint msg,
        Wparam wParam,
        Lparam lParam,
        Ref<MaybeBool<int>> pfRecursion
    )
    {
        fixed (MaybeBool<int>* __dsl_pfRecursion = pfRecursion)
        {
            return (Lresult)DefDlgProcEx(hwnd, msg, wParam, lParam, __dsl_pfRecursion);
        }
    }

    public static MaybeBool<int> DeleteBitmap(Hbitmap hbm) => DeleteObject((HGDIOBJ)(Hbitmap)(hbm));

    public static MaybeBool<int> DeleteBrush(Hbrush hbr) => DeleteObject((HGDIOBJ)(Hbrush)(hbr));

    public static MaybeBool<int> DeleteFont(Hfont hfont) => DeleteObject((HGDIOBJ)(Hfont)(hfont));

    public static MaybeBool<int> DeletePalette(Hpalette hpal) =>
        DeleteObject((HGDIOBJ)(Hpalette)(hpal));

    /****** GDI Macro APIs *******************************************************/
    public static BOOL DeletePen(HPEN hpen) => DeleteObject((HGDIOBJ)(HPEN)(hpen));

    public static MaybeBool<int> DeleteRgn(HRGN hrgn) => DeleteObject((HGDIOBJ)(HRGN)(hrgn));

    public static MaybeBool<int> EditCanUndo(HWND hwndCtl) =>
        ((MaybeBool<int>)(uint)SNDMSG((hwndCtl), EM_CANUNDO, 0u, 0));

    public static void EditEmptyUndoBuffer(HWND hwndCtl) =>
        SNDMSG((hwndCtl), EM_EMPTYUNDOBUFFER, 0u, 0);

    /****** Edit control message APIs ********************************************/
    public static MaybeBool<int> EditEnable(HWND hwndCtl, MaybeBool<int> fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    public static MaybeBool<int> EditFmtLines(HWND hwndCtl, MaybeBool<int> fAddEOL) =>
        (
            (MaybeBool<int>)
                (uint)SNDMSG((hwndCtl), EM_FMTLINES, (Wparam)(MaybeBool<int>)(fAddEOL), 0)
        );

    public static int EditGetFirstVisibleLine(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_GETFIRSTVISIBLELINE, 0u, 0));

    public static HLOCAL EditGetHandle(HWND hwndCtl) =>
        ((HLOCAL)(nuint)SNDMSG((hwndCtl), EM_GETHANDLE, 0u, 0));

    public static int EditGetLine(HWND hwndCtl, int line, char* lpch, int cchMax)
    {
        *((int*)(lpch)) = (cchMax);
        return (
            (int)(uint)SNDMSG((hwndCtl), EM_GETLINE, (Wparam)(int)(line), (Lparam)(char*)(lpch))
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int EditGetLine(HWND hwndCtl, int line, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)EditGetLine(hwndCtl, line, __dsl_lpch, cchMax);
        }
    }

    public static int EditGetLineCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_GETLINECOUNT, 0u, 0));

    public static MaybeBool<int> EditGetModify(HWND hwndCtl) =>
        ((MaybeBool<int>)(uint)SNDMSG((hwndCtl), EM_GETMODIFY, 0u, 0));

    public static ushort EditGetPasswordChar(HWND hwndCtl) =>
        ((ushort)(uint)SNDMSG((hwndCtl), EM_GETPASSWORDCHAR, 0u, 0));

    public static void EditGetRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_GETRECT, 0u, (Lparam)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EditGetRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            EditGetRect(hwndCtl, __dsl_lprc);
        }
    }

    public static uint EditGetSel(HWND hwndCtl) => ((uint)SNDMSG((hwndCtl), EM_GETSEL, 0u, 0));

    public static int EditGetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int EditGetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)EditGetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int EditGetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static delegate* unmanaged<char*, int, int, int, int> EditGetWordBreakProc(
        HWND hwndCtl
    ) =>
        (
            (delegate* unmanaged<char*, int, int, int, int>)SNDMSG(
                (hwndCtl),
                EM_GETWORDBREAKPROC,
                0u,
                0
            )
        );

    public static void EditLimitText(HWND hwndCtl, int cchMax) =>
        SNDMSG((hwndCtl), EM_LIMITTEXT, (Wparam)(cchMax), 0);

    public static int EditLineFromChar(HWND hwndCtl, int ich) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINEFROMCHAR, (Wparam)(int)(ich), 0));

    public static int EditLineIndex(HWND hwndCtl, int line) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINEINDEX, (Wparam)(int)(line), 0));

    public static int EditLineLength(HWND hwndCtl, int line) =>
        ((int)(uint)SNDMSG((hwndCtl), EM_LINELENGTH, (Wparam)(int)(line), 0));

    public static void EditReplaceSel(HWND hwndCtl, char* lpszReplace) =>
        SNDMSG((hwndCtl), EM_REPLACESEL, 0u, (Lparam)(char*)(lpszReplace));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EditReplaceSel(HWND hwndCtl, Ref<char> lpszReplace)
    {
        fixed (char* __dsl_lpszReplace = lpszReplace)
        {
            EditReplaceSel(hwndCtl, __dsl_lpszReplace);
        }
    }

    public static void EditScroll(HWND hwndCtl, Wparam dv, Lparam dh) =>
        SNDMSG((hwndCtl), EM_LINESCROLL, (Wparam)(dh), (Lparam)(dv));

    public static MaybeBool<int> EditScrollCaret(HWND hwndCtl) =>
        ((MaybeBool<int>)(uint)SNDMSG((hwndCtl), EM_SCROLLCARET, 0u, 0));

    public static void EditSetHandle(HWND hwndCtl, HLOCAL h) =>
        SNDMSG((hwndCtl), EM_SETHANDLE, (Wparam)(nuint)(HLOCAL)(h), 0);

    public static void EditSetModify(HWND hwndCtl, uint fModified) =>
        SNDMSG((hwndCtl), EM_SETMODIFY, (Wparam)(uint)(fModified), 0);

    public static void EditSetPasswordChar(HWND hwndCtl, uint ch) =>
        SNDMSG((hwndCtl), EM_SETPASSWORDCHAR, (Wparam)(uint)(ch), 0);

    public static MaybeBool<int> EditSetReadOnly(HWND hwndCtl, MaybeBool<int> fReadOnly) =>
        (
            (MaybeBool<int>)
                (uint)SNDMSG((hwndCtl), EM_SETREADONLY, (Wparam)(MaybeBool<int>)(fReadOnly), 0)
        );

    public static void EditSetRect(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_SETRECT, 0u, (Lparam)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EditSetRect(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            EditSetRect(hwndCtl, __dsl_lprc);
        }
    }

    public static void EditSetRectNoPaint(HWND hwndCtl, RECT* lprc) =>
        SNDMSG((hwndCtl), EM_SETRECTNP, 0u, (Lparam)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EditSetRectNoPaint(HWND hwndCtl, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            EditSetRectNoPaint(hwndCtl, __dsl_lprc);
        }
    }

    public static void EditSetSel(HWND hwndCtl, Wparam ichStart, Lparam ichEnd) =>
        SNDMSG((hwndCtl), EM_SETSEL, (ichStart), (ichEnd));

    public static void EditSetTabStops(HWND hwndCtl, int cTabs, int* lpTabs) =>
        SNDMSG((hwndCtl), EM_SETTABSTOPS, (Wparam)(int)(cTabs), (Lparam)(int*)(lpTabs));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void EditSetTabStops(HWND hwndCtl, int cTabs, Ref<int> lpTabs)
    {
        fixed (int* __dsl_lpTabs = lpTabs)
        {
            EditSetTabStops(hwndCtl, cTabs, __dsl_lpTabs);
        }
    }

    public static MaybeBool<int> EditSetText(HWND hwndCtl, char* lpsz) =>
        SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> EditSetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<int>)EditSetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static void EditSetWordBreakProc(
        HWND hwndCtl,
        delegate* unmanaged<char*, int, int, int, int> lpfnWordBreak
    ) =>
        SNDMSG(
            (hwndCtl),
            EM_SETWORDBREAKPROC,
            0u,
            (Lparam)(delegate* unmanaged<char*, int, int, int, int>)(lpfnWordBreak)
        );

    public static MaybeBool<int> EditUndo(HWND hwndCtl) =>
        ((MaybeBool<int>)(uint)SNDMSG((hwndCtl), EM_UNDO, 0u, 0));

    public static void ForwardWmActivate(
        HWND hwnd,
        uint state,
        HWND hwndActDeact,
        MaybeBool<int> fMinimized,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_ACTIVATE,
            Makewparam((state), (nuint)(fMinimized)),
            (Lparam)(HWND)(hwndActDeact)
        );

    public static void ForwardWmActivateapp(
        HWND hwnd,
        MaybeBool<int> fActivate,
        uint dwThreadId,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_ACTIVATEAPP, (Wparam)(MaybeBool<int>)(fActivate), (Lparam)(dwThreadId));

    public static void ForwardWmAskcbformatname(
        HWND hwnd,
        int cchMax,
        char* rgchName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_ASKCBFORMATNAME, (Wparam)(int)(cchMax), (Lparam)(rgchName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmAskcbformatname(
        HWND hwnd,
        int cchMax,
        Ref<char> rgchName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (char* __dsl_rgchName = rgchName)
        {
            ForwardWmAskcbformatname(hwnd, cchMax, __dsl_rgchName, fn);
        }
    }

    public static void ForwardWmCancelmode(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CANCELMODE, 0u, 0);

    public static void ForwardWmChangecbchain(
        HWND hwnd,
        HWND hwndRemove,
        HWND hwndNext,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CHANGECBCHAIN, (Wparam)(HWND)(hwndRemove), (Lparam)(HWND)(hwndNext));

    public static void ForwardWmChar(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CHAR, (Wparam)(ushort)(ch), Makelparam((cRepeat), 0));

    public static int ForwardWmChartoitem(
        HWND hwnd,
        uint ch,
        HWND hwndListBox,
        int iCaret,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_CHARTOITEM,
                Makewparam((uint)(ch), (uint)(iCaret)),
                (Lparam)(hwndListBox)
            );

    public static void ForwardWmChildactivate(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CHILDACTIVATE, 0u, 0);

    public static void ForwardWmClear(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CLEAR, 0u, 0);

    public static void ForwardWmClose(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CLOSE, 0u, 0);

    public static void ForwardWmCommand(
        HWND hwnd,
        int id,
        HWND hwndCtl,
        uint codeNotify,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn((hwnd), WM_COMMAND, Makewparam((uint)(id), (uint)(codeNotify)), (Lparam)(HWND)(hwndCtl));

    public static void ForwardWmCommnotify(
        HWND hwnd,
        int cid,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_COMMNOTIFY, (Wparam)(cid), Makelparam((flags), 0));

    public static void ForwardWmCompacting(
        HWND hwnd,
        uint compactRatio,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_COMPACTING, (Wparam)(uint)(compactRatio), 0);

    public static int ForwardWmCompareitem(
        HWND hwnd,
        COMPAREITEMSTRUCT* lpCompareItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_COMPAREITEM,
                (Wparam)(((COMPAREITEMSTRUCT*)(lpCompareItem))->CtlID),
                (Lparam)(COMPAREITEMSTRUCT*)(lpCompareItem)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ForwardWmCompareitem(
        HWND hwnd,
        Ref<COMPAREITEMSTRUCT> lpCompareItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (COMPAREITEMSTRUCT* __dsl_lpCompareItem = lpCompareItem)
        {
            return (int)ForwardWmCompareitem(hwnd, __dsl_lpCompareItem, fn);
        }
    }

    public static void ForwardWmContextmenu(
        HWND hwnd,
        HWND hwndContext,
        uint xPos,
        uint yPos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_CONTEXTMENU,
            (Wparam)(HWND)(hwndContext),
            Makelparam((uint)(xPos), (uint)(yPos))
        );

    public static void ForwardWmCopy(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_COPY, 0u, 0);

    public static MaybeBool<int> ForwardWmCopydata(
        HWND hwnd,
        HWND hwndFrom,
        COPYDATASTRUCT* pcds,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)(uint)fn((hwnd), WM_COPYDATA, (Wparam)(hwndFrom), (Lparam)(pcds));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ForwardWmCopydata(
        HWND hwnd,
        HWND hwndFrom,
        Ref<COPYDATASTRUCT> pcds,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (COPYDATASTRUCT* __dsl_pcds = pcds)
        {
            return (MaybeBool<int>)ForwardWmCopydata(hwnd, hwndFrom, __dsl_pcds, fn);
        }
    }

    public static MaybeBool<int> ForwardWmCreate(
        HWND hwnd,
        CREATESTRUCTW* lpCreateStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_CREATE, 0u, (Lparam)(CREATESTRUCTW*)(lpCreateStruct));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ForwardWmCreate(
        HWND hwnd,
        Ref<CREATESTRUCTW> lpCreateStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (CREATESTRUCTW* __dsl_lpCreateStruct = lpCreateStruct)
        {
            return (MaybeBool<int>)ForwardWmCreate(hwnd, __dsl_lpCreateStruct, fn);
        }
    }

    public static Hbrush ForwardWmCtlcolorbtn(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (Hbrush)(nuint)fn((hwnd), WM_CTLCOLORBTN, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcolordlg(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (Hbrush)(nuint)fn((hwnd), WM_CTLCOLORDLG, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcoloredit(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (Hbrush)(nuint)fn((hwnd), WM_CTLCOLOREDIT, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcolorlistbox(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (Hbrush)
            (nuint)fn((hwnd), WM_CTLCOLORLISTBOX, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcolormsgbox(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (Hbrush)(nuint)fn((hwnd), WM_CTLCOLORMSGBOX, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcolorscrollbar(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (Hbrush)
            (nuint)fn((hwnd), WM_CTLCOLORSCROLLBAR, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static Hbrush ForwardWmCtlcolorstatic(
        HWND hwnd,
        HDC hdc,
        HWND hwndChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (Hbrush)(nuint)fn((hwnd), WM_CTLCOLORSTATIC, (Wparam)(HDC)(hdc), (Lparam)(HWND)(hwndChild));

    public static void ForwardWmCut(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_CUT, 0u, 0);

    public static void ForwardWmDeadchar(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DEADCHAR, (Wparam)(ushort)(ch), Makelparam((cRepeat), 0));

    public static void ForwardWmDeleteitem(
        HWND hwnd,
        DELETEITEMSTRUCT* lpDeleteItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_DELETEITEM,
            (Wparam)(((DELETEITEMSTRUCT*)(lpDeleteItem))->CtlID),
            (Lparam)(DELETEITEMSTRUCT*)(lpDeleteItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmDeleteitem(
        HWND hwnd,
        Ref<DELETEITEMSTRUCT> lpDeleteItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (DELETEITEMSTRUCT* __dsl_lpDeleteItem = lpDeleteItem)
        {
            ForwardWmDeleteitem(hwnd, __dsl_lpDeleteItem, fn);
        }
    }

    public static void ForwardWmDestroy(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DESTROY, 0u, 0);

    public static void ForwardWmDestroyclipboard(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DESTROYCLIPBOARD, 0u, 0);

    public static MaybeBool<int> ForwardWmDevicechange(
        HWND hwnd,
        uint uEvent,
        uint dwEventData,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (MaybeBool<int>)
            (uint)fn((hwnd), WM_DEVICECHANGE, (Wparam)(uint)(uEvent), (Lparam)(uint)(dwEventData));

    public static void ForwardWmDevmodechange(
        HWND hwnd,
        char* lpszDeviceName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DEVMODECHANGE, 0u, (Lparam)(char*)(lpszDeviceName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmDevmodechange(
        HWND hwnd,
        Ref<char> lpszDeviceName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (char* __dsl_lpszDeviceName = lpszDeviceName)
        {
            ForwardWmDevmodechange(hwnd, __dsl_lpszDeviceName, fn);
        }
    }

    public static void ForwardWmDisplaychange(
        HWND hwnd,
        uint bitsPerPixel,
        uint cxScreen,
        uint cyScreen,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_DISPLAYCHANGE,
            (Wparam)(uint)(bitsPerPixel),
            (Lparam)Makelparam((uint)(cxScreen), (uint)(cyScreen))
        );

    public static void ForwardWmDrawclipboard(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DRAWCLIPBOARD, 0u, 0);

    public static void ForwardWmDrawitem(
        HWND hwnd,
        DRAWITEMSTRUCT* lpDrawItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_DRAWITEM,
            (Wparam)(((DRAWITEMSTRUCT*)lpDrawItem)->CtlID),
            (Lparam)(DRAWITEMSTRUCT*)(lpDrawItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmDrawitem(
        HWND hwnd,
        Ref<DRAWITEMSTRUCT> lpDrawItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (DRAWITEMSTRUCT* __dsl_lpDrawItem = lpDrawItem)
        {
            ForwardWmDrawitem(hwnd, __dsl_lpDrawItem, fn);
        }
    }

    public static void ForwardWmDropfiles(
        HWND hwnd,
        HDROP hdrop,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_DROPFILES, (Wparam)(HDROP)(hdrop), 0);

    public static void ForwardWmEnable(
        HWND hwnd,
        MaybeBool<int> fEnable,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_ENABLE, (Wparam)(BOOL)(fEnable), 0);

    public static void ForwardWmEndsession(
        HWND hwnd,
        MaybeBool<int> fEnding,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_ENDSESSION, (Wparam)(MaybeBool<int>)(fEnding), 0);

    public static void ForwardWmEnteridle(
        HWND hwnd,
        uint source,
        HWND hwndSource,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_ENTERIDLE, (Wparam)(uint)(source), (Lparam)(HWND)(hwndSource));

    public static MaybeBool<int> ForwardWmErasebkgnd(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_ERASEBKGND, (Wparam)(HDC)(hdc), 0);

    public static void ForwardWmFontchange(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_FONTCHANGE, 0u, 0);

    public static uint ForwardWmGetdlgcode(
        HWND hwnd,
        MSG* lpmsg,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (uint)
            (uint)fn(
                (hwnd),
                WM_GETDLGCODE,
                ((lpmsg != null) ? lpmsg->wParam : 0u),
                (Lparam)(MSG*)(lpmsg)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint ForwardWmGetdlgcode(
        HWND hwnd,
        Ref<MSG> lpmsg,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (MSG* __dsl_lpmsg = lpmsg)
        {
            return (uint)ForwardWmGetdlgcode(hwnd, __dsl_lpmsg, fn);
        }
    }

    public static Hfont ForwardWmGetfont(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (Hfont)(nuint)fn((hwnd), WM_GETFONT, 0u, 0);

    public static void ForwardWmGetminmaxinfo(
        HWND hwnd,
        MINMAXINFO* lpMinMaxInfo,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_GETMINMAXINFO, 0u, (Lparam)(MINMAXINFO*)(lpMinMaxInfo));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmGetminmaxinfo(
        HWND hwnd,
        Ref<MINMAXINFO> lpMinMaxInfo,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (MINMAXINFO* __dsl_lpMinMaxInfo = lpMinMaxInfo)
        {
            ForwardWmGetminmaxinfo(hwnd, __dsl_lpMinMaxInfo, fn);
        }
    }

    public static int ForwardWmGettext(
        HWND hwnd,
        int cchTextMax,
        char* lpszText,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (int)(uint)fn((hwnd), WM_GETTEXT, (Wparam)(int)(cchTextMax), (Lparam)(char*)(lpszText));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ForwardWmGettext(
        HWND hwnd,
        int cchTextMax,
        Ref<char> lpszText,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (char* __dsl_lpszText = lpszText)
        {
            return (int)ForwardWmGettext(hwnd, cchTextMax, __dsl_lpszText, fn);
        }
    }

    public static int ForwardWmGettextlength(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (int)(uint)fn((hwnd), WM_GETTEXTLENGTH, 0u, 0);

    public static void ForwardWmHotkey(
        HWND hwnd,
        int idHotKey,
        uint fuModifiers,
        uint vk,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_HOTKEY, (Wparam)(idHotKey), Makelparam((fuModifiers), (vk)));

    public static void ForwardWmHscroll(
        HWND hwnd,
        HWND hwndCtl,
        uint code,
        int pos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_HSCROLL,
            Makewparam((uint)(int)(code), (uint)(int)(pos)),
            (Lparam)(HWND)(hwndCtl)
        );

    public static void ForwardWmHscrollclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        uint code,
        int pos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_HSCROLLCLIPBOARD,
            (Wparam)(HWND)(hwndCBViewer),
            Makelparam((code), (nuint)(pos))
        );

    public static MaybeBool<int> ForwardWmIconerasebkgnd(
        HWND hwnd,
        HDC hdc,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_ICONERASEBKGND, (Wparam)(HDC)(hdc), 0);

    public static MaybeBool<int> ForwardWmInitdialog(
        HWND hwnd,
        HWND hwndFocus,
        Lparam lParam,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_INITDIALOG, (Wparam)(HWND)(hwndFocus), (lParam));

    public static void ForwardWmInitmenu(
        HWND hwnd,
        HMENU hMenu,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_INITMENU, (Wparam)(HMENU)(hMenu), 0);

    public static void ForwardWmInitmenupopup(
        HWND hwnd,
        HMENU hMenu,
        uint item,
        MaybeBool<int> fSystemMenu,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_INITMENUPOPUP,
            (Wparam)(HMENU)(hMenu),
            Makelparam((item), (nuint)(fSystemMenu))
        );

    public static void ForwardWmKeydown(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_KEYDOWN, (Wparam)(uint)(vk), Makelparam((nuint)(cRepeat), (flags)));

    public static void ForwardWmKeyup(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_KEYUP, (Wparam)(uint)(vk), Makelparam((nuint)(cRepeat), (flags)));

    public static void ForwardWmKillfocus(
        HWND hwnd,
        HWND hwndNewFocus,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_KILLFOCUS, (Wparam)(HWND)(hwndNewFocus), 0);

    public static void ForwardWmLbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_LBUTTONDBLCLK : WM_LBUTTONDOWN),
            (Wparam)(uint)(keyFlags),
            Makelparam((x), (y))
        );

    public static void ForwardWmLbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_LBUTTONUP, (Wparam)(uint)(keyFlags), Makelparam((x), (y)));

    public static void ForwardWmMbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_MBUTTONDBLCLK : WM_MBUTTONDOWN),
            (Wparam)(uint)(keyFlags),
            Makelparam((x), (y))
        );

    public static void ForwardWmMbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MBUTTONUP, (Wparam)(uint)(keyFlags), Makelparam((x), (y)));

    public static void ForwardWmMdiactivate(
        HWND hwnd,
        MaybeBool<int> fActive,
        HWND hwndActivate,
        HWND hwndDeactivate,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn(hwnd, WM_MDIACTIVATE, (Wparam)(hwndDeactivate), (Lparam)(hwndActivate));

    public static MaybeBool<int> ForwardWmMdicascade(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_MDICASCADE, (Wparam)(cmd), 0);

    public static HWND ForwardWmMdicreate(
        HWND hwnd,
        MDICREATESTRUCTW* lpmcs,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (HWND)(uint)(uint)fn((hwnd), WM_MDICREATE, 0u, (Lparam)(MDICREATESTRUCTW*)(lpmcs));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HWND ForwardWmMdicreate(
        HWND hwnd,
        Ref<MDICREATESTRUCTW> lpmcs,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (MDICREATESTRUCTW* __dsl_lpmcs = lpmcs)
        {
            return (HWND)ForwardWmMdicreate(hwnd, __dsl_lpmcs, fn);
        }
    }

    public static void ForwardWmMdidestroy(
        HWND hwnd,
        HWND hwndDestroy,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MDIDESTROY, (Wparam)(hwndDestroy), 0);

    public static HWND ForwardWmMdigetactive(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (HWND)(nuint)fn((hwnd), WM_MDIGETACTIVE, 0u, 0);

    public static void ForwardWmMdiiconarrange(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MDIICONARRANGE, 0u, 0);

    public static void ForwardWmMdimaximize(
        HWND hwnd,
        HWND hwndMaximize,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MDIMAXIMIZE, (Wparam)(hwndMaximize), 0);

    public static HWND ForwardWmMdinext(
        HWND hwnd,
        HWND hwndCur,
        MaybeBool<int> fPrev,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (HWND)(nuint)fn((hwnd), WM_MDINEXT, (Wparam)(hwndCur), (Lparam)(fPrev));

    public static void ForwardWmMdirestore(
        HWND hwnd,
        HWND hwndRestore,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MDIRESTORE, (Wparam)(hwndRestore), 0);

    public static HMENU ForwardWmMdisetmenu(
        HWND hwnd,
        MaybeBool<int> fRefresh,
        HMENU hmenuFrame,
        HMENU hmenuWindow,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (HMENU)
            (nuint)fn(
                (hwnd),
                WM_MDISETMENU,
                (Wparam)((fRefresh) ? (hmenuFrame) : HMENU.NULL),
                (Lparam)(hmenuWindow)
            );

    public static MaybeBool<int> ForwardWmMditile(
        HWND hwnd,
        uint cmd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_MDITILE, (Wparam)(cmd), 0);

    public static void ForwardWmMeasureitem(
        HWND hwnd,
        MEASUREITEMSTRUCT* lpMeasureItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_MEASUREITEM,
            (Wparam)(((MEASUREITEMSTRUCT*)lpMeasureItem)->CtlID),
            (Lparam)(MEASUREITEMSTRUCT*)(lpMeasureItem)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmMeasureitem(
        HWND hwnd,
        Ref<MEASUREITEMSTRUCT> lpMeasureItem,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (MEASUREITEMSTRUCT* __dsl_lpMeasureItem = lpMeasureItem)
        {
            ForwardWmMeasureitem(hwnd, __dsl_lpMeasureItem, fn);
        }
    }

    public static uint ForwardWmMenuchar(
        HWND hwnd,
        uint ch,
        uint flags,
        HMENU hmenu,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (uint)fn((hwnd), WM_MENUCHAR, Makewparam(flags, (ushort)(ch)), (Lparam)(HMENU)(hmenu));

    public static void ForwardWmMenuselect(
        HWND hwnd,
        HMENU hmenu,
        int item,
        HMENU hmenuPopup,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_MENUSELECT,
            Makewparam((nuint)(item), (flags)),
            (Lparam)(HMENU)((hmenu != HMENU.NULL) ? (hmenu) : (hmenuPopup))
        );

    public static int ForwardWmMouseactivate(
        HWND hwnd,
        HWND hwndTopLevel,
        uint codeHitTest,
        uint msg,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_MOUSEACTIVATE,
                (Wparam)(HWND)(hwndTopLevel),
                Makelparam((codeHitTest), (msg))
            );

    public static void ForwardWmMousemove(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MOUSEMOVE, (Wparam)(uint)(keyFlags), Makelparam((x), (y)));

    public static void ForwardWmMousewheel(
        HWND hwnd,
        int xPos,
        int yPos,
        int zDelta,
        uint fwKeys,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_MOUSEWHEEL,
            Makewparam((fwKeys), (nuint)(zDelta)),
            Makelparam((xPos), (yPos))
        );

    public static void ForwardWmMove(
        HWND hwnd,
        int x,
        int y,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_MOVE, 0u, Makelparam((x), (y)));

    public static MaybeBool<int> ForwardWmNcactivate(
        HWND hwnd,
        MaybeBool<int> fActive,
        HWND hwndActDeact,
        MaybeBool<int> fMinimized,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (BOOL)(uint)fn((hwnd), WM_NCACTIVATE, (Wparam)(MaybeBool<int>)(fActive), 0);

    public static uint ForwardWmNccalcsize(
        HWND hwnd,
        MaybeBool<int> fCalcValidRects,
        NCCALCSIZE_PARAMS* lpcsp,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (uint)
            (uint)fn(
                (hwnd),
                WM_NCCALCSIZE,
                (Wparam)(fCalcValidRects),
                (Lparam)(NCCALCSIZE_PARAMS*)(lpcsp)
            );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint ForwardWmNccalcsize(
        HWND hwnd,
        MaybeBool<int> fCalcValidRects,
        Ref<NCCALCSIZE_PARAMS> lpcsp,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (NCCALCSIZE_PARAMS* __dsl_lpcsp = lpcsp)
        {
            return (uint)ForwardWmNccalcsize(hwnd, fCalcValidRects, __dsl_lpcsp, fn);
        }
    }

    public static MaybeBool<int> ForwardWmNccreate(
        HWND hwnd,
        CREATESTRUCTW* lpCreateStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (MaybeBool<int>)(uint)fn((hwnd), WM_NCCREATE, 0u, (Lparam)(CREATESTRUCTW*)(lpCreateStruct));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ForwardWmNccreate(
        HWND hwnd,
        Ref<CREATESTRUCTW> lpCreateStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (CREATESTRUCTW* __dsl_lpCreateStruct = lpCreateStruct)
        {
            return (MaybeBool<int>)ForwardWmNccreate(hwnd, __dsl_lpCreateStruct, fn);
        }
    }

    public static void ForwardWmNcdestroy(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCDESTROY, 0u, 0);

    public static uint ForwardWmNchittest(
        HWND hwnd,
        int x,
        int y,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (uint)(uint)fn((hwnd), WM_NCHITTEST, 0u, Makelparam((x), (y)));

    public static void ForwardWmNclbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCLBUTTONDBLCLK : WM_NCLBUTTONDOWN),
            (Wparam)(uint)(codeHitTest),
            Makelparam((x), (y))
        );

    public static void ForwardWmNclbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCLBUTTONUP, (Wparam)(uint)(codeHitTest), Makelparam((x), (y)));

    public static void ForwardWmNcmbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCMBUTTONDBLCLK : WM_NCMBUTTONDOWN),
            (Wparam)(uint)(codeHitTest),
            Makelparam((x), (y))
        );

    public static void ForwardWmNcmbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCMBUTTONUP, (Wparam)(uint)(codeHitTest), Makelparam((x), (y)));

    public static void ForwardWmNcmousemove(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCMOUSEMOVE, (Wparam)(uint)(codeHitTest), Makelparam((x), (y)));

    public static void ForwardWmNcpaint(
        HWND hwnd,
        HRGN hrgn,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCPAINT, (Wparam)(HRGN)(hrgn), 0);

    public static void ForwardWmNcrbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_NCRBUTTONDBLCLK : WM_NCRBUTTONDOWN),
            (Wparam)(uint)(codeHitTest),
            Makelparam((x), (y))
        );

    public static void ForwardWmNcrbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint codeHitTest,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_NCRBUTTONUP, (Wparam)(uint)(codeHitTest), Makelparam((x), (y)));

    public static HWND ForwardWmNextdlgctl(
        HWND hwnd,
        HWND hwndSetFocus,
        MaybeBool<int> fNext,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (HWND)(nuint)fn((hwnd), WM_NEXTDLGCTL, (Wparam)(HWND)(hwndSetFocus), (Lparam)(fNext));

    public static void ForwardWmPaint(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_PAINT, 0u, 0);

    public static void ForwardWmPaintclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        PAINTSTRUCT* lpPaintStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_PAINTCLIPBOARD,
            (Wparam)(HWND)(hwndCBViewer),
            (Lparam)(PAINTSTRUCT*)(lpPaintStruct)
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmPaintclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        Ref<PAINTSTRUCT> lpPaintStruct,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (PAINTSTRUCT* __dsl_lpPaintStruct = lpPaintStruct)
        {
            ForwardWmPaintclipboard(hwnd, hwndCBViewer, __dsl_lpPaintStruct, fn);
        }
    }

    public static void ForwardWmPalettechanged(
        HWND hwnd,
        HWND hwndPaletteChange,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_PALETTECHANGED, (Wparam)(HWND)(hwndPaletteChange), 0);

    public static void ForwardWmPaletteischanging(
        HWND hwnd,
        HWND hwndPaletteChange,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_PALETTEISCHANGING, (Wparam)(HWND)(hwndPaletteChange), 0);

    public static void ForwardWmParentnotify(
        HWND hwnd,
        uint msg,
        HWND hwndChild,
        int idChild,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_PARENTNOTIFY, Makewparam(msg, (nuint)(idChild)), (Lparam)(hwndChild));

    public static void ForwardWmPaste(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_PASTE, 0u, 0);

    public static void ForwardWmPower(
        HWND hwnd,
        int code,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_POWER, (Wparam)(int)(code), 0);

    public static HICON ForwardWmQuerydragicon(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (HICON)(uint)(uint)fn((hwnd), WM_QUERYDRAGICON, 0u, 0);

    public static MaybeBool<int> ForwardWmQueryendsession(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_QUERYENDSESSION, 0u, 0);

    public static MaybeBool<int> ForwardWmQuerynewpalette(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_QUERYNEWPALETTE, 0u, 0);

    public static MaybeBool<int> ForwardWmQueryopen(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (BOOL)(uint)fn((hwnd), WM_QUERYOPEN, 0u, 0);

    public static void ForwardWmQueuesync(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_QUEUESYNC, 0u, 0);

    public static void ForwardWmQuit(
        HWND hwnd,
        int exitCode,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_QUIT, (Wparam)(exitCode), 0);

    public static void ForwardWmRbuttondown(
        HWND hwnd,
        MaybeBool<int> fDoubleClick,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            (uint)((fDoubleClick) ? WM_RBUTTONDBLCLK : WM_RBUTTONDOWN),
            (Wparam)(uint)(keyFlags),
            Makelparam((x), (y))
        );

    public static void ForwardWmRbuttonup(
        HWND hwnd,
        int x,
        int y,
        uint keyFlags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_RBUTTONUP, (Wparam)(uint)(keyFlags), Makelparam((x), (y)));

    public static void ForwardWmRenderallformats(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_RENDERALLFORMATS, 0u, 0);

    public static Handle ForwardWmRenderformat(
        HWND hwnd,
        uint fmt,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (Handle)(nuint)fn((hwnd), WM_RENDERFORMAT, (Wparam)(uint)(fmt), 0);

    public static MaybeBool<int> ForwardWmSetcursor(
        HWND hwnd,
        HWND hwndCursor,
        uint codeHitTest,
        uint msg,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (MaybeBool<int>)
            (uint)fn(
                (hwnd),
                WM_SETCURSOR,
                (Wparam)(HWND)(hwndCursor),
                Makelparam((codeHitTest), (msg))
            );

    public static void ForwardWmSetfocus(
        HWND hwnd,
        HWND hwndOldFocus,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SETFOCUS, (Wparam)(HWND)(hwndOldFocus), 0);

    public static void ForwardWmSetfont(
        HWND hwnd,
        Hfont hfont,
        MaybeBool<int> fRedraw,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SETFONT, (Wparam)(Hfont)(hfont), (Lparam)(MaybeBool<int>)(fRedraw));

    public static void ForwardWmSetredraw(
        HWND hwnd,
        MaybeBool<int> fRedraw,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SETREDRAW, (Wparam)(BOOL)(fRedraw), 0);

    public static void ForwardWmSettext(
        HWND hwnd,
        char* lpszText,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SETTEXT, 0u, (Lparam)(char*)(lpszText));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmSettext(
        HWND hwnd,
        Ref<char> lpszText,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (char* __dsl_lpszText = lpszText)
        {
            ForwardWmSettext(hwnd, __dsl_lpszText, fn);
        }
    }

    public static void ForwardWmShowwindow(
        HWND hwnd,
        MaybeBool<int> fShow,
        uint status,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SHOWWINDOW, (Wparam)(MaybeBool<int>)(fShow), (Lparam)(uint)(status));

    public static void ForwardWmSize(
        HWND hwnd,
        uint state,
        int cx,
        int cy,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SIZE, (Wparam)(uint)(state), Makelparam((cx), (cy)));

    public static void ForwardWmSizeclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        RECT* lprc,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SIZECLIPBOARD, (Wparam)(HWND)(hwndCBViewer), (Lparam)(RECT*)(lprc));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmSizeclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        Ref<RECT> lprc,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            ForwardWmSizeclipboard(hwnd, hwndCBViewer, __dsl_lprc, fn);
        }
    }

    public static void ForwardWmSpoolerstatus(
        HWND hwnd,
        uint status,
        ushort cJobInQueue,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SPOOLERSTATUS, (Wparam)(status), Makelparam((cJobInQueue), 0));

    public static void ForwardWmSyschar(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSCHAR, (Wparam)(ushort)(ch), Makelparam((cRepeat), 0));

    public static void ForwardWmSyscolorchange(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSCOLORCHANGE, 0u, 0);

    public static void ForwardWmSyscommand(
        HWND hwnd,
        uint cmd,
        int x,
        int y,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSCOMMAND, (Wparam)(uint)(cmd), Makelparam((x), (y)));

    public static void ForwardWmSysdeadchar(
        HWND hwnd,
        ushort ch,
        int cRepeat,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSDEADCHAR, (Wparam)(ushort)(ch), Makelparam((cRepeat), 0));

    public static void ForwardWmSyskeydown(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSKEYDOWN, (Wparam)(uint)(vk), Makelparam((nuint)(cRepeat), (flags)));

    public static void ForwardWmSyskeyup(
        HWND hwnd,
        uint vk,
        int cRepeat,
        uint flags,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_SYSKEYUP, (Wparam)(uint)(vk), Makelparam((nuint)(cRepeat), (flags)));

    public static void ForwardWmSystemerror(
        HWND hwnd,
        int errCode,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) { }

    public static void ForwardWmTimechange(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_TIMECHANGE, 0u, 0);

    public static void ForwardWmTimer(
        HWND hwnd,
        uint id,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_TIMER, (Wparam)(uint)(id), 0);

    public static void ForwardWmUndo(
        HWND hwnd,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_UNDO, 0u, 0);

    public static int ForwardWmVkeytoitem(
        HWND hwnd,
        uint vk,
        HWND hwndListBox,
        int iCaret,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        (int)
            (uint)fn(
                (hwnd),
                WM_VKEYTOITEM,
                Makewparam((vk), (nuint)(iCaret)),
                (Lparam)(hwndListBox)
            );

    public static void ForwardWmVscroll(
        HWND hwnd,
        HWND hwndCtl,
        uint code,
        int pos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_VSCROLL,
            Makewparam((uint)(int)(code), (uint)(int)(pos)),
            (Lparam)(HWND)(hwndCtl)
        );

    public static void ForwardWmVscrollclipboard(
        HWND hwnd,
        HWND hwndCBViewer,
        uint code,
        int pos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) =>
        fn(
            (hwnd),
            WM_VSCROLLCLIPBOARD,
            (Wparam)(HWND)(hwndCBViewer),
            Makelparam((code), (nuint)(pos))
        );

    public static void ForwardWmWindowposchanged(
        HWND hwnd,
        WINDOWPOS* lpwpos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_WINDOWPOSCHANGED, 0u, (Lparam)(WINDOWPOS*)(lpwpos));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmWindowposchanged(
        HWND hwnd,
        Ref<WINDOWPOS> lpwpos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (WINDOWPOS* __dsl_lpwpos = lpwpos)
        {
            ForwardWmWindowposchanged(hwnd, __dsl_lpwpos, fn);
        }
    }

    public static MaybeBool<int> ForwardWmWindowposchanging(
        HWND hwnd,
        WINDOWPOS* lpwpos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => (MaybeBool<int>)(uint)fn((hwnd), WM_WINDOWPOSCHANGING, 0u, (Lparam)(WINDOWPOS*)(lpwpos));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ForwardWmWindowposchanging(
        HWND hwnd,
        Ref<WINDOWPOS> lpwpos,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (WINDOWPOS* __dsl_lpwpos = lpwpos)
        {
            return (MaybeBool<int>)ForwardWmWindowposchanging(hwnd, __dsl_lpwpos, fn);
        }
    }

    public static void ForwardWmWininichange(
        HWND hwnd,
        char* lpszSectionName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    ) => fn((hwnd), WM_WININICHANGE, 0u, (Lparam)(char*)(lpszSectionName));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ForwardWmWininichange(
        HWND hwnd,
        Ref<char> lpszSectionName,
        delegate* <HWND, uint, Wparam, Lparam, Lresult> fn
    )
    {
        fixed (char* __dsl_lpszSectionName = lpszSectionName)
        {
            ForwardWmWininichange(hwnd, __dsl_lpszSectionName, fn);
        }
    }

    public static (Wparam wp, Lparam lp) GetEmLinescrollMps(Wparam vert, Lparam horz) =>
        ((Wparam)horz, (Lparam)vert);

    public static Lparam GetEmSetselEnd(Wparam wp, Lparam lp) => (lp);

    public static (Wparam wp, Lparam lp) GetEmSetselMps(int iStart, Lparam iEnd) =>
        ((Wparam)(iStart), (Lparam)(iEnd));

    public static int GetEmSetselStart(Wparam wp, Lparam lp) => (int)(wp);

    public static Lparam GetLparam(Wparam wp, Lparam lp) => (lp);

    public static BOOL GetWmActivateFminimized(Wparam wp, Lparam lp) => (MaybeBool<int>)Hiword(wp);

    public static HWND GetWmActivateHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static (Wparam wp, Lparam lp) GetWmActivateMps(
        ushort s,
        MaybeBool<int> fmin,
        HWND hwnd
    ) => ((Wparam)Makelong((s), (fmin)), (Lparam)(hwnd));

    public static ushort GetWmActivateState(Wparam wp, Lparam lp) => Loword(wp);

    public static HWND GetWmChangecbchainHwndnext(Wparam wp, Lparam lp) => (HWND)(lp);

    public static ushort GetWmChartoitemChar(Wparam wp, Lparam lp) => (ushort)Loword(wp);

    public static HWND GetWmChartoitemHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static (Wparam wp, Lparam lp) GetWmChartoitemMps(ushort ch, ushort pos, HWND hwnd) =>
        ((Wparam)Makelong((pos), (ch)), (Lparam)(hwnd));

    public static ushort GetWmChartoitemPos(Wparam wp, Lparam lp) => Hiword(wp);

    public static ushort GetWmCommandCmd(Wparam wp, Lparam lp) => Hiword(wp);

    public static HWND GetWmCommandHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static ushort GetWmCommandId(Wparam wp, Lparam lp) => Loword(wp);

    public static (Wparam wp, Lparam lp) GetWmCommandMps(ushort id, HWND hwnd, ushort cmd) =>
        ((Wparam)Makelong(id, cmd), (Lparam)(hwnd));

    public static HDC GetWmCtlcolorHdc(Wparam wp, Lparam lp, uint msg) => (HDC)(wp);

    public static HWND GetWmCtlcolorHwnd(Wparam wp, Lparam lp, uint msg) => (HWND)(lp);

    public static (Wparam wp, Lparam lp) GetWmCtlcolorMps(HDC hdc, HWND hwnd, ushort type) =>
        ((Wparam)(hdc), (Lparam)(hwnd));

    public static ushort GetWmCtlcolorMsg(ushort type) => (ushort)(WM_CTLCOLORMSGBOX + (type));

    public static ushort GetWmCtlcolorType(Wparam wp, Lparam lp, uint msg) =>
        (ushort)(msg - WM_CTLCOLORMSGBOX);

    public static ushort GetWmHscrollCode(Wparam wp, Lparam lp) => Loword(wp);

    public static HWND GetWmHscrollHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static (Wparam wp, Lparam lp) GetWmHscrollMps(ushort code, ushort pos, HWND hwnd) =>
        ((Wparam)Makelong(code, pos), (Lparam)(hwnd));

    public static ushort GetWmHscrollPos(Wparam wp, Lparam lp) => Hiword(wp);

    /* Note: the following are for interpreting MDIclient to MDI child messages. */
    public static MaybeBool<int> GetWmMdiactivateFactivate(HWND hwnd, Wparam wp, Lparam lp) =>
        (lp == (Lparam)hwnd);

    public static HWND GetWmMdiactivateHwndactivate(Wparam wp, Lparam lp) => (HWND)(lp);

    public static HWND GetWmMdiactivateHwnddeact(Wparam wp, Lparam lp) => (HWND)(wp);

    /* Note: the following is for sending to the MDI client window. */
    public static (Wparam wp, Lparam lp) GetWmMdiactivateMps(BOOL f, HWND hwndD, HWND hwndA) =>
        ((Wparam)(hwndA), 0);

    public static (Wparam wp, Lparam lp) GetWmMdisetmenuMps(HMENU hmenuF, HMENU hmenuW) =>
        ((Wparam)hmenuF, (Lparam)hmenuW);

    public static ushort GetWmMenucharChar(Wparam wp, Lparam lp) => (ushort)Loword(wp);

    public static BOOL GetWmMenucharFmenu(Wparam wp, Lparam lp) => (MaybeBool<int>)Hiword(wp);

    public static HMENU GetWmMenucharHmenu(Wparam wp, Lparam lp) => (HMENU)(lp);

    public static (Wparam wp, Lparam lp) GetWmMenucharMps(
        ushort ch,
        HMENU hmenu,
        MaybeBool<int> f
    ) => ((Wparam)Makelong(ch, f), (Lparam)(hmenu));

    public static ushort GetWmMenuselectCmd(Wparam wp, Lparam lp) => Loword(wp);

    public static uint GetWmMenuselectFlags(Wparam wp, Lparam lp) => (uint)(int)(short)Hiword(wp);

    public static HMENU GetWmMenuselectHmenu(Wparam wp, Lparam lp) => (HMENU)(lp);

    public static (Wparam wp, Lparam lp) GetWmMenuselectMps(ushort cmd, uint f, HMENU hmenu) =>
        ((Wparam)Makelong(cmd, f), (Lparam)(hmenu));

    public static HWND GetWmParentnotifyHwndchild(Wparam wp, Lparam lp) => (HWND)(lp);

    public static ushort GetWmParentnotifyId(Wparam wp, Lparam lp) => Hiword(wp);

    public static (Wparam wp, Lparam lp) GetWmParentnotifyMps(ushort msg, ushort id, HWND hwnd) =>
        ((Wparam)Makelong(id, msg), (Lparam)(hwnd));

    public static ushort GetWmParentnotifyMsg(Wparam wp, Lparam lp) => Loword(wp);

    public static int GetWmParentnotifyX(Wparam wp, Lparam lp) => (int)(short)Loword(lp);

    public static int GetWmParentnotifyY(Wparam wp, Lparam lp) => (int)(short)Hiword(lp);

    public static (Wparam wp, Lparam lp) GetWmParentnotify2Mps(ushort msg, int x, int y) =>
        ((Wparam)Makelong(0, msg), Makelong(x, y));

    public static int GetWmVkeytoitemCode(Wparam wp, Lparam lp) => (int)(short)Loword(wp);

    public static HWND GetWmVkeytoitemHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static ushort GetWmVkeytoitemItem(Wparam wp, Lparam lp) => Hiword(wp);

    public static (Wparam wp, Lparam lp) GetWmVkeytoitemMps(int code, ushort item, HWND hwnd) =>
        ((Wparam)Makelong(item, code), (Lparam)(hwnd));

    public static ushort GetWmVscrollCode(Wparam wp, Lparam lp) => Loword(wp);

    public static HWND GetWmVscrollHwnd(Wparam wp, Lparam lp) => (HWND)(lp);

    public static (Wparam wp, Lparam lp) GetWmVscrollMps(ushort code, ushort pos, HWND hwnd) =>
        ((Wparam)Makelong(code, pos), (Lparam)(hwnd));

    public static ushort GetWmVscrollPos(Wparam wp, Lparam lp) => Hiword(wp);

    /****** Alternate porting layer macros ****************************************/
    /* USER MESSAGES: */
    public static Wparam GetWparam(Wparam wp, Lparam lp) => (wp);

    public static int GetXLparam(Lparam lp) => ((int)(short)Loword(lp));

    public static int GetYLparam(Lparam lp) => ((int)(short)Hiword(lp));

    public static HWND GetFirstChild(HWND hwnd) => GetTopWindow(hwnd);

    public static HWND GetFirstSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDFIRST);

    /****** KERNEL Macro APIs ****************************************************/
    public static Hmodule GetInstanceModule(HINSTANCE hInstance) => (Hmodule)(hInstance);

    public static HWND GetLastSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDLAST);

    public static HWND GetNextSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDNEXT);

    public static HWND GetPrevSibling(HWND hwnd) => GetWindow(hwnd, GW_HWNDPREV);

    public static Hbrush GetStockBrush(int i) => ((Hbrush)GetStockObject(i));

    public static Hfont GetStockFont(int i) => ((Hfont)GetStockObject(i));

    public static HPEN GetStockPen(int i) => ((HPEN)GetStockObject(i));

    public static uint GetWindowExStyle(HWND hwnd) => ((uint)GetWindowLong(hwnd, GWL_EXSTYLE));

    public static Hfont GetWindowFont(HWND hwnd) => ForwardWmGetfont((hwnd), SNDMSG);

    public static int GetWindowID(HWND hwnd) => GetDlgCtrlID(hwnd);

    /****** USER Macro APIs ******************************************************/
    public static Hmodule GetWindowInstance(HWND hwnd) =>
        ((Hmodule)GetWindowLongPtr(hwnd, GWLP_HINSTANCE));

    public static HWND GetWindowOwner(HWND hwnd) => GetWindow(hwnd, GW_OWNER);

    public static uint GetWindowStyle(HWND hwnd) => ((uint)GetWindowLong(hwnd, GWL_STYLE));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr GlobalAllocPtr(uint flags, nuint cb) => (void*)GlobalAllocPtrRaw(flags, cb);

    public static void* GlobalAllocPtrRaw(uint flags, nuint cb) =>
        (GlobalLock(GlobalAlloc((flags), (cb))));

    public static BOOL GlobalFreePtr(void* lp)
    {
        _ = GlobalUnlockPtr(lp);
        return (MaybeBool<int>)(nuint)GlobalFree(GlobalPtrHandle(lp));
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static BOOL GlobalFreePtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (BOOL)GlobalFreePtr(__dsl_lp);
        }
    }

    public static MaybeBool<int> GlobalLockPtr(void* lp) =>
        (MaybeBool<int>)(nuint)GlobalLock(GlobalPtrHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> GlobalLockPtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<int>)GlobalLockPtr(__dsl_lp);
        }
    }

    public static HGLOBAL GlobalPtrHandle(void* lp) => ((HGLOBAL)GlobalHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HGLOBAL GlobalPtrHandle(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (HGLOBAL)GlobalPtrHandle(__dsl_lp);
        }
    }

    public static MaybeBool<int> GlobalReAllocPtr(void* lp, nuint cbNew, uint flags)
    {
        _ = GlobalUnlockPtr(lp);
        return (MaybeBool<int>)
            (nuint)GlobalLock(GlobalReAlloc(GlobalPtrHandle(lp), (cbNew), (flags)));
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> GlobalReAllocPtr(Ref lp, nuint cbNew, uint flags)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<int>)GlobalReAllocPtr(__dsl_lp, cbNew, flags);
        }
    }

    public static MaybeBool<int> GlobalUnlockPtr(void* lp) => GlobalUnlock(GlobalPtrHandle(lp));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> GlobalUnlockPtr(Ref lp)
    {
        fixed (void* __dsl_lp = lp)
        {
            return (MaybeBool<int>)GlobalUnlockPtr(__dsl_lp);
        }
    }

    /* void Cls_OnActivate(HWND hwnd, UINT state, HWND hwndActDeact, BOOL fMinimized) */
    public static Lresult HandleWmActivate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, HWND, MaybeBool<int>, void> fn
    )
    {
        fn((hwnd), (uint)Loword(wParam), (HWND)(lParam), (BOOL)Hiword(wParam));
        return 0;
    }

    /* void Cls_OnActivateApp(HWND hwnd, BOOL fActivate, DWORD dwThreadId) */
    public static Lresult HandleWmActivateapp(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, uint, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(wParam), (uint)(lParam));
        return 0;
    }

    /* void Cls_OnAskCBFormatName(HWND hwnd, int cchMax, LPTSTR rgchName) */
    public static Lresult HandleWmAskcbformatname(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, char*, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnCancelMode(HWND hwnd) */
    public static Lresult HandleWmCancelmode(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnChangeCBChain(HWND hwnd, HWND hwndRemove, HWND hwndNext) */
    public static Lresult HandleWmChangecbchain(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (HWND)(lParam));
        return 0;
    }

    /* void Cls_OnChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static Lresult HandleWmChar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)Loword(lParam));
        return 0;
    }

    /* int Cls_OnCharToItem(HWND hwnd, UINT ch, HWND hwndListbox, int iCaret) */
    public static Lresult HandleWmChartoitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, HWND, int, int> fn
    ) =>
        (Lresult)
            (uint)(int)fn((hwnd), (uint)Loword(wParam), (HWND)(lParam), (int)(short)Hiword(wParam));

    /* void Cls_OnChildActivate(HWND hwnd) */
    public static Lresult HandleWmChildactivate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnClear(HWND hwnd) */
    public static Lresult HandleWmClear(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnClose(HWND hwnd) */
    public static Lresult HandleWmClose(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnCommand(HWND hwnd, int id, HWND hwndCtl, UINT codeNotify) */
    public static Lresult HandleWmCommand(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, HWND, uint, void> fn
    )
    {
        fn((hwnd), (int)(Loword(wParam)), (HWND)(lParam), (uint)Hiword(wParam));
        return 0;
    }

    /* void Cls_OnCommNotify(HWND hwnd, int cid, UINT flags) */
    public static Lresult HandleWmCommnotify(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (uint)Loword(lParam));
        return 0;
    }

    /****** Message crackers ****************************************************/
    /* void Cls_OnCompacting(HWND hwnd, UINT compactRatio) */
    public static Lresult HandleWmCompacting(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam));
        return 0;
    }

    /* int Cls_OnCompareItem(HWND hwnd, const COMPAREITEMSTRUCT * lpCompareItem) */
    public static Lresult HandleWmCompareitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, COMPAREITEMSTRUCT*, int> fn
    ) => (Lresult)(uint)(int)fn((hwnd), (COMPAREITEMSTRUCT*)(lParam));

    /* void Cls_OnContextMenu(HWND hwnd, HWND hwndContext, UINT xPos, UINT yPos) */
    public static Lresult HandleWmContextmenu(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (HWND)(wParam),
            (uint)(int)(short)Loword(lParam),
            (uint)(int)(short)Hiword(lParam)
        );
        return 0;
    }

    /* void Cls_OnCopy(HWND hwnd) */
    public static Lresult HandleWmCopy(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    public static Lresult HandleWmCopydata(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, COPYDATASTRUCT*, MaybeBool<int>> fn
    )
    {
        _ = fn((hwnd), (HWND)(wParam), (COPYDATASTRUCT*)lParam);
        return 0;
    }

    /* BOOL Cls_OnCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct) */
    public static Lresult HandleWmCreate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, CREATESTRUCTW*, MaybeBool<int>> fn
    ) => fn((hwnd), (CREATESTRUCTW*)(lParam)) ? 0 : (Lresult)(-1);

    public static Lresult HandleWmCtlcolorbtn(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_BTN);

    public static Lresult HandleWmCtlcolordlg(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_DLG);

    public static Lresult HandleWmCtlcoloredit(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_EDIT);

    public static Lresult HandleWmCtlcolorlistbox(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_LISTBOX);

    /* HBRUSH Cls_OnCtlColor(HWND hwnd, HDC hdc, HWND hwndChild, int type) */
    public static Lresult HandleWmCtlcolormsgbox(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_MSGBOX);

    public static Lresult HandleWmCtlcolorscrollbar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_SCROLLBAR);

    public static Lresult HandleWmCtlcolorstatic(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, HWND, int, Hbrush> fn
    ) => (Lresult)(nuint)(Hbrush)fn((hwnd), (HDC)(wParam), (HWND)(lParam), CTLCOLOR_STATIC);

    /* void Cls_OnCut(HWND hwnd) */
    public static Lresult HandleWmCut(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDeadChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static Lresult HandleWmDeadchar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)Loword(lParam));
        return 0;
    }

    /* void Cls_OnDeleteItem(HWND hwnd, const DELETEITEMSTRUCT * lpDeleteItem) */
    public static Lresult HandleWmDeleteitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, DELETEITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (DELETEITEMSTRUCT*)(lParam));
        return 0;
    }

    /* void Cls_OnDestroy(HWND hwnd) */
    public static Lresult HandleWmDestroy(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDestroyClipboard(HWND hwnd) */
    public static Lresult HandleWmDestroyclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* BOOL Cls_OnDeviceChange(HWND hwnd, UINT uEvent, DWORD dwEventData) */
    public static Lresult HandleWmDevicechange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, uint, MaybeBool<int>> fn
    ) => (Lresult)(uint)(MaybeBool<int>)fn((hwnd), (uint)(wParam), (uint)(lParam));

    /* void Cls_OnDevModeChange(HWND hwnd, LPCTSTR lpszDeviceName) */
    public static Lresult HandleWmDevmodechange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnDisplayChange(HWND hwnd, UINT bitsPerPixel, UINT cxScreen, UINT cyScreen) */
    public static Lresult HandleWmDisplaychange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, uint, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (uint)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnDrawClipboard(HWND hwnd) */
    public static Lresult HandleWmDrawclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnDrawItem(HWND hwnd, const DRAWITEMSTRUCT * lpDrawItem) */
    public static Lresult HandleWmDrawitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, DRAWITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (DRAWITEMSTRUCT*)(lParam));
        return 0;
    }

    /* void Cls_OnDropFiles(HWND hwnd, HDROP hdrop) */
    public static Lresult HandleWmDropfiles(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDROP, void> fn
    )
    {
        fn((hwnd), (HDROP)(wParam));
        return 0;
    }

    /* void Cls_OnEnable(HWND hwnd, BOOL fEnable) */
    public static Lresult HandleWmEnable(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(wParam));
        return 0;
    }

    /* void Cls_OnEndSession(HWND hwnd, BOOL fEnding) */
    public static Lresult HandleWmEndsession(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(wParam));
        return 0;
    }

    /* void Cls_OnEnterIdle(HWND hwnd, UINT source, HWND hwndSource) */
    public static Lresult HandleWmEnteridle(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, HWND, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (HWND)(lParam));
        return 0;
    }

    /* BOOL Cls_OnEraseBkgnd(HWND hwnd, HDC hdc) */
    public static Lresult HandleWmErasebkgnd(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, MaybeBool<int>> fn
    ) => (Lresult)(uint)(BOOL)fn((hwnd), (HDC)(wParam));

    /* void Cls_OnFontChange(HWND hwnd) */
    public static Lresult HandleWmFontchange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* UINT Cls_OnGetDlgCode(HWND hwnd, LPMSG lpmsg) */
    public static Lresult HandleWmGetdlgcode(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MSG*, uint> fn
    ) => (Lresult)(uint)(uint)fn(hwnd, (MSG*)(lParam));

    /* HFONT Cls_OnGetFont(HWND hwnd) */
    public static Lresult HandleWmGetfont(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, Hfont> fn
    ) => (Lresult)(nuint)(Hfont)fn(hwnd);

    /* void Cls_OnGetMinMaxInfo(HWND hwnd, LPMINMAXINFO lpMinMaxInfo) */
    public static Lresult HandleWmGetminmaxinfo(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MINMAXINFO*, void> fn
    )
    {
        fn((hwnd), (MINMAXINFO*)(lParam));
        return 0;
    }

    /* INT Cls_OnGetText(HWND hwnd, int cchTextMax, LPTSTR lpszText) */
    public static Lresult HandleWmGettext(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, char*, int> fn
    ) => (Lresult)(uint)(int)fn((hwnd), (int)(wParam), (char*)(lParam));

    /* INT Cls_OnGetTextLength(HWND hwnd) */
    public static Lresult HandleWmGettextlength(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int> fn
    ) => (Lresult)(uint)(int)fn(hwnd);

    /* void Cls_OnHotKey(HWND hwnd, int idHotKey, UINT fuModifiers, UINT vk) */
    public static Lresult HandleWmHotkey(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, uint, uint, void> fn
    )
    {
        fn((hwnd), (int)(wParam), (uint)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnHScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos) */
    public static Lresult HandleWmHscroll(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(lParam), (uint)(Loword(wParam)), (int)(short)Hiword(wParam));
        return 0;
    }

    /* void Cls_OnHScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos) */
    public static Lresult HandleWmHscrollclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (uint)Loword(lParam), (int)(short)Hiword(lParam));
        return 0;
    }

    /* BOOL Cls_OnIconEraseBkgnd(HWND hwnd, HDC hdc) */
    public static Lresult HandleWmIconerasebkgnd(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HDC, BOOL> fn
    ) => (Lresult)(uint)(MaybeBool<int>)fn((hwnd), (HDC)(wParam));

    /* BOOL Cls_OnInitDialog(HWND hwnd, HWND hwndFocus, LPARAM lParam) */
    public static Lresult HandleWmInitdialog(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, Lparam, MaybeBool<int>> fn
    ) => (Lresult)(uint)(uint)(MaybeBool<int>)fn((hwnd), (HWND)(wParam), lParam);

    /* void Cls_OnInitMenu(HWND hwnd, HMENU hMenu) */
    public static Lresult HandleWmInitmenu(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HMENU, void> fn
    )
    {
        fn((hwnd), (HMENU)(wParam));
        return 0;
    }

    /* void Cls_OnInitMenuPopup(HWND hwnd, HMENU hMenu, UINT item, BOOL fSystemMenu) */
    public static Lresult HandleWmInitmenupopup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HMENU, uint, MaybeBool<int>, void> fn
    )
    {
        fn((hwnd), (HMENU)(wParam), (uint)Loword(lParam), (MaybeBool<int>)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static Lresult HandleWmKeydown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, MaybeBool<int>, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), TRUE, (int)(short)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static Lresult HandleWmKeyup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, BOOL, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), FALSE, (int)(short)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnKillFocus(HWND hwnd, HWND hwndNewFocus) */
    public static Lresult HandleWmKillfocus(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmLbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmLbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnLButtonUp(HWND hwnd, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmLbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmMbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmMbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMButtonUp(HWND hwnd, int x, int y, UINT flags) */
    public static Lresult HandleWmMbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* NOTE: Usable only by MDI client windows */
    /* void Cls_MDIActivate(HWND hwnd, BOOL fActive, HWND hwndActivate, HWND hwndDeactivate) */
    public static Lresult HandleWmMdiactivate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, BOOL, HWND, HWND, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(lParam == (Lparam)hwnd), (HWND)(lParam), (HWND)(wParam));
        return 0;
    }

    /* BOOL Cls_MDICascade(HWND hwnd, UINT cmd) */
    public static Lresult HandleWmMdicascade(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, MaybeBool<int>> fn
    ) => (Lresult)(uint)fn((hwnd), (uint)(wParam));

    /* HWND Cls_MDICreate(HWND hwnd, const LPMDICREATESTRUCT lpmcs) */
    public static Lresult HandleWmMdicreate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MDICREATESTRUCTW*, HWND> fn
    ) => (Lresult)(uint)(uint)fn((hwnd), (MDICREATESTRUCTW*)(lParam));

    /* void Cls_MDIDestroy(HWND hwnd, HWND hwndDestroy) */
    public static Lresult HandleWmMdidestroy(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HWND Cls_MDIGetActive(HWND hwnd) */
    public static Lresult HandleWmMdigetactive(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND> fn
    ) => (Lresult)(nuint)fn(hwnd);

    /* void Cls_MDIIconArrange(HWND hwnd) */
    public static Lresult HandleWmMdiiconarrange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_MDIMaximize(HWND hwnd, HWND hwndMaximize) */
    public static Lresult HandleWmMdimaximize(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HWND Cls_MDINext(HWND hwnd, HWND hwndCur, BOOL fPrev) */
    public static Lresult HandleWmMdinext(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, MaybeBool<int>, HWND> fn
    ) => (Lresult)(HWND)fn((hwnd), (HWND)(wParam), (MaybeBool<int>)lParam);

    /* void Cls_MDIRestore(HWND hwnd, HWND hwndRestore) */
    public static Lresult HandleWmMdirestore(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* HMENU Cls_MDISetMenu(HWND hwnd, BOOL fRefresh, HMENU hmenuFrame, HMENU hmenuWindow) */
    public static Lresult HandleWmMdisetmenu(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, HMENU, HMENU, HMENU> fn
    ) => (Lresult)(nuint)fn((hwnd), (MaybeBool<int>)(wParam), (HMENU)(wParam), (HMENU)(lParam));

    /* BOOL Cls_MDITile(HWND hwnd, UINT cmd) */
    public static Lresult HandleWmMditile(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, BOOL> fn
    ) => (Lresult)(uint)fn((hwnd), (uint)(wParam));

    /* void Cls_OnMeasureItem(HWND hwnd, MEASUREITEMSTRUCT * lpMeasureItem) */
    public static Lresult HandleWmMeasureitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MEASUREITEMSTRUCT*, void> fn
    )
    {
        fn((hwnd), (MEASUREITEMSTRUCT*)(lParam));
        return 0;
    }

    /* DWORD Cls_OnMenuChar(HWND hwnd, UINT ch, UINT flags, HMENU hmenu) */
    public static Lresult HandleWmMenuchar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, uint, HMENU, uint> fn
    ) => (Lresult)(uint)fn((hwnd), (uint)(Loword(wParam)), (uint)Hiword(wParam), (HMENU)(lParam));

    /* void Cls_OnMenuSelect(HWND hwnd, HMENU hmenu, int item, HMENU hmenuPopup, UINT flags) */
    public static Lresult HandleWmMenuselect(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HMENU, int, HMENU, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (HMENU)(lParam),
            ((Hiword(wParam) & MF_POPUP) != 0) ? 0 : (int)(Loword(wParam)),
            ((Hiword(wParam) & MF_POPUP) != 0)
                ? GetSubMenu((HMENU)lParam, Loword(wParam))
                : HMENU.NULL,
            (uint)(((short)Hiword(wParam) == -1) ? 0xFFFFFFFF : Hiword(wParam))
        );
        return 0;
    }

    /* int Cls_OnMouseActivate(HWND hwnd, HWND hwndTopLevel, UINT codeHitTest, UINT msg) */
    public static Lresult HandleWmMouseactivate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, uint, int> fn
    ) => (Lresult)(uint)(int)fn((hwnd), (HWND)(wParam), (uint)Loword(lParam), (uint)Hiword(lParam));

    /* void Cls_OnMouseMove(HWND hwnd, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmMousemove(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnMouseWheel(HWND hwnd, int xPos, int yPos, int zDelta, UINT fwKeys) */
    public static Lresult HandleWmMousewheel(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, int, uint, void> fn
    )
    {
        fn(
            (hwnd),
            (int)(short)Loword(lParam),
            (int)(short)Hiword(lParam),
            (int)(short)Hiword(wParam),
            (uint)(short)Loword(wParam)
        );
        return 0;
    }

    /* void Cls_OnMove(HWND hwnd, int x, int y) */
    public static Lresult HandleWmMove(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam));
        return 0;
    }

    /* BOOL Cls_OnNCActivate(HWND hwnd, BOOL fActive, HWND hwndActDeact, BOOL fMinimized) */
    public static Lresult HandleWmNcactivate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, HWND, MaybeBool<int>, MaybeBool<int>> fn
    ) => (Lresult)(uint)(MaybeBool<int>)fn((hwnd), (MaybeBool<int>)(wParam), HWND.NULL, 0);

    /* UINT Cls_OnNCCalcSize(HWND hwnd, BOOL fCalcValidRects, NCCALCSIZE_PARAMS * lpcsp) */
    public static Lresult HandleWmNccalcsize(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, NCCALCSIZE_PARAMS*, uint> fn
    ) => (Lresult)(uint)(uint)fn((hwnd), (MaybeBool<int>)(wParam), (NCCALCSIZE_PARAMS*)(lParam));

    /* BOOL Cls_OnNCCreate(HWND hwnd, LPCREATESTRUCT lpCreateStruct) */
    public static Lresult HandleWmNccreate(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, CREATESTRUCTW*, BOOL> fn
    ) => (Lresult)(uint)(MaybeBool<int>)fn((hwnd), (CREATESTRUCTW*)(lParam));

    /* void Cls_OnNCDestroy(HWND hwnd) */
    public static Lresult HandleWmNcdestroy(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* UINT Cls_OnNCHitTest(HWND hwnd, int x, int y) */
    public static Lresult HandleWmNchittest(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint> fn
    ) => (Lresult)(uint)(uint)fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam));

    /* void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNclbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCLButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNclbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCLButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNclbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcmbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcmbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcmbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCMouseMove(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcmousemove(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCPaint(HWND hwnd, HRGN hrgn) */
    public static Lresult HandleWmNcpaint(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HRGN, void> fn
    )
    {
        fn((hwnd), (HRGN)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcrbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcrbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnNCRButtonUp(HWND hwnd, int x, int y, UINT codeHitTest) */
    public static Lresult HandleWmNcrbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* HWND Cls_OnNextDlgCtl(HWND hwnd, HWND hwndSetFocus, BOOL fNext) */
    public static Lresult HandleWmNextdlgctl(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, MaybeBool<int>, HWND> fn
    ) => (Lresult)(nuint)(HWND)fn((hwnd), (HWND)(wParam), (MaybeBool<int>)(lParam));

    /* void Cls_OnPaint(HWND hwnd) */
    public static Lresult HandleWmPaint(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnPaintClipboard(HWND hwnd, HWND hwndCBViewer, const LPPAINTSTRUCT lpPaintStruct) */
    public static Lresult HandleWmPaintclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, PAINTSTRUCT*, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (PAINTSTRUCT*)GlobalLock((HGLOBAL)(lParam)));
        _ = GlobalUnlock((HGLOBAL)(lParam));
        return 0;
    }

    /* void Cls_OnPaletteChanged(HWND hwnd, HWND hwndPaletteChange) */
    public static Lresult HandleWmPalettechanged(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnPaletteIsChanging(HWND hwnd, HWND hwndPaletteChange) */
    public static Lresult HandleWmPaletteischanging(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnParentNotify(HWND hwnd, UINT msg, HWND hwndChild, int idChild) */
    public static Lresult HandleWmParentnotify(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, HWND, int, void> fn
    )
    {
        fn((hwnd), (uint)Loword(wParam), (HWND)(lParam), (int)(uint)Hiword(wParam));
        return 0;
    }

    /* void Cls_OnPaste(HWND hwnd) */
    public static Lresult HandleWmPaste(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnPower(HWND hwnd, int code) */
    public static Lresult HandleWmPower(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, void> fn
    )
    {
        fn((hwnd), (int)(wParam));
        return 0;
    }

    /* HICON Cls_OnQueryDragIcon(HWND hwnd) */
    public static Lresult HandleWmQuerydragicon(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HICON> fn
    ) => (Lresult)(uint)(uint)fn(hwnd);

    /* BOOL Cls_OnQueryEndSession(HWND hwnd) */
    public static Lresult HandleWmQueryendsession(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>> fn
    ) => Makelresult((ushort)(MaybeBool<int>)fn(hwnd), 0);

    /* BOOL Cls_OnQueryNewPalette(HWND hwnd) */
    public static Lresult HandleWmQuerynewpalette(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>> fn
    ) => Makelresult((ushort)(MaybeBool<int>)fn(hwnd), 0);

    /* BOOL Cls_OnQueryOpen(HWND hwnd) */
    public static Lresult HandleWmQueryopen(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>> fn
    ) => Makelresult((MaybeBool<int>)fn(hwnd), 0);

    /* void Cls_OnQueueSync(HWND hwnd) */
    public static Lresult HandleWmQueuesync(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnQuit(HWND hwnd, int exitCode) */
    public static Lresult HandleWmQuit(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, void> fn
    )
    {
        fn((hwnd), (int)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmRbuttondblclk(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), TRUE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonDown(HWND hwnd, BOOL fDoubleClick, int x, int y, UINT keyFlags) */
    public static Lresult HandleWmRbuttondown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, int, int, uint, void> fn
    )
    {
        fn((hwnd), FALSE, (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRButtonUp(HWND hwnd, int x, int y, UINT flags) */
    public static Lresult HandleWmRbuttonup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, int, uint, void> fn
    )
    {
        fn((hwnd), (int)(short)Loword(lParam), (int)(short)Hiword(lParam), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnRenderAllFormats(HWND hwnd) */
    public static Lresult HandleWmRenderallformats(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* HANDLE Cls_OnRenderFormat(HWND hwnd, UINT fmt) */
    public static Lresult HandleWmRenderformat(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, Handle> fn
    ) => (Lresult)(nuint)(Handle)fn((hwnd), (uint)(wParam));

    /* BOOL Cls_OnSetCursor(HWND hwnd, HWND hwndCursor, UINT codeHitTest, UINT msg) */
    public static Lresult HandleWmSetcursor(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, uint, MaybeBool<int>> fn
    ) =>
        (Lresult)
            (uint)
                (MaybeBool<int>)
                    fn((hwnd), (HWND)(wParam), (uint)Loword(lParam), (uint)Hiword(lParam));

    /* void Cls_OnSetFocus(HWND hwnd, HWND hwndOldFocus) */
    public static Lresult HandleWmSetfocus(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam));
        return 0;
    }

    /* void Cls_OnSetFont(HWND hwndCtl, HFONT hfont, BOOL fRedraw) */
    public static Lresult HandleWmSetfont(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, Hfont, MaybeBool<int>, void> fn
    )
    {
        fn((hwnd), (Hfont)(wParam), (MaybeBool<int>)(lParam));
        return 0;
    }

    /* void Cls_OnSetRedraw(HWND hwnd, BOOL fRedraw) */
    public static Lresult HandleWmSetredraw(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, BOOL, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(wParam));
        return 0;
    }

    /* void Cls_OnSetText(HWND hwnd, LPCTSTR lpszText) */
    public static Lresult HandleWmSettext(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    /* void Cls_OnShowWindow(HWND hwnd, BOOL fShow, UINT status) */
    public static Lresult HandleWmShowwindow(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, MaybeBool<int>, uint, void> fn
    )
    {
        fn((hwnd), (MaybeBool<int>)(wParam), (uint)(lParam));
        return 0;
    }

    /* void Cls_OnSize(HWND hwnd, UINT state, int cx, int cy) */
    public static Lresult HandleWmSize(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, int, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)Loword(lParam), (int)(short)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnSizeClipboard(HWND hwnd, HWND hwndCBViewer, const LPRECT lprc) */
    public static Lresult HandleWmSizeclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, RECT*, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (RECT*)GlobalLock((HGLOBAL)(lParam)));
        _ = GlobalUnlock((HGLOBAL)(lParam));
        return 0;
    }

    /* void Cls_OnSpoolerStatus(HWND hwnd, UINT status, int cJobInQueue) */
    public static Lresult HandleWmSpoolerstatus(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)Loword(lParam));
        return 0;
    }

    /* void Cls_OnSysChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static Lresult HandleWmSyschar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)Loword(lParam));
        return 0;
    }

    /* void Cls_OnSysColorChange(HWND hwnd) */
    public static Lresult HandleWmSyscolorchange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnSysCommand(HWND hwnd, UINT cmd, int x, int y) */
    public static Lresult HandleWmSyscommand(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, int, int, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), (int)(short)Loword(lParam), (int)(short)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnSysDeadChar(HWND hwnd, TCHAR ch, int cRepeat) */
    public static Lresult HandleWmSysdeadchar(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, ushort, int, void> fn
    )
    {
        fn((hwnd), (ushort)(wParam), (int)(short)Loword(lParam));
        return 0;
    }

    /* void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static Lresult HandleWmSyskeydown(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, MaybeBool<int>, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), TRUE, (int)(short)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnSysKey(HWND hwnd, UINT vk, BOOL fDown, int cRepeat, UINT flags) */
    public static Lresult HandleWmSyskeyup(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, MaybeBool<int>, int, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam), FALSE, (int)(short)Loword(lParam), (uint)Hiword(lParam));
        return 0;
    }

    /* This message is in Windows 3.1 only */
    /* void Cls_OnSystemError(HWND hwnd, int errCode) */
    public static Lresult HandleWmSystemerror(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, int, void> fn
    ) => 0;

    /* void Cls_OnTimeChange(HWND hwnd) */
    public static Lresult HandleWmTimechange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* void Cls_OnTimer(HWND hwnd, UINT id) */
    public static Lresult HandleWmTimer(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, void> fn
    )
    {
        fn((hwnd), (uint)(wParam));
        return 0;
    }

    /* void Cls_OnUndo(HWND hwnd) */
    public static Lresult HandleWmUndo(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, void> fn
    )
    {
        fn(hwnd);
        return 0;
    }

    /* int Cls_OnVkeyToItem(HWND hwnd, UINT vk, HWND hwndListbox, int iCaret) */
    public static Lresult HandleWmVkeytoitem(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, uint, HWND, int, int> fn
    ) =>
        (Lresult)
            (uint)(int)fn((hwnd), (uint)Loword(wParam), (HWND)(lParam), (int)(short)Hiword(wParam));

    /* void Cls_OnVScroll(HWND hwnd, HWND hwndCtl, UINT code, int pos) */
    public static Lresult HandleWmVscroll(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(lParam), (uint)(Loword(wParam)), (int)(short)Hiword(wParam));
        return 0;
    }

    /* void Cls_OnVScrollClipboard(HWND hwnd, HWND hwndCBViewer, UINT code, int pos) */
    public static Lresult HandleWmVscrollclipboard(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, HWND, uint, int, void> fn
    )
    {
        fn((hwnd), (HWND)(wParam), (uint)Loword(lParam), (int)(short)Hiword(lParam));
        return 0;
    }

    /* void Cls_OnWindowPosChanged(HWND hwnd, const LPWINDOWPOS lpwpos) */
    public static Lresult HandleWmWindowposchanged(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, WINDOWPOS*, void> fn
    )
    {
        fn((hwnd), (WINDOWPOS*)(lParam));
        return 0;
    }

    /* BOOL Cls_OnWindowPosChanging(HWND hwnd, LPWINDOWPOS lpwpos) */
    public static Lresult HandleWmWindowposchanging(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, WINDOWPOS*, MaybeBool<int>> fn
    ) => (Lresult)(uint)(MaybeBool<int>)fn((hwnd), (WINDOWPOS*)(lParam));

    /* void Cls_OnWinIniChange(HWND hwnd, LPCTSTR lpszSectionName) */
    public static Lresult HandleWmWininichange(
        HWND hwnd,
        Wparam wParam,
        Lparam lParam,
        delegate* <HWND, char*, void> fn
    )
    {
        fn((hwnd), (char*)(lParam));
        return 0;
    }

    public static MaybeBool<int> InsetRect(RECT* lprc, int dx, int dy) =>
        InflateRect((lprc), -(dx), -(dy));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> InsetRect(Ref<RECT> lprc, int dx, int dy)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            return (MaybeBool<int>)InsetRect(__dsl_lprc, dx, dy);
        }
    }

    public static int IntersectRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_AND);

    public static BOOL IsLButtonDown() => (GetKeyState(VK_LBUTTON) < 0);

    public static MaybeBool<int> IsMaximized(HWND hwnd) => IsZoomed(hwnd);

    public static MaybeBool<int> IsMButtonDown() => (GetKeyState(VK_MBUTTON) < 0);

    public static MaybeBool<int> IsMinimized(HWND hwnd) => IsIconic(hwnd);

    public static MaybeBool<int> IsRButtonDown() => (GetKeyState(VK_RBUTTON) < 0);

    public static MaybeBool<int> IsRestored(HWND hwnd) =>
        ((GetWindowStyle(hwnd) & (WS_MINIMIZE | WS_MAXIMIZE)) == 0);

    public static int ListBoxAddItemData(HWND hwndCtl, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_ADDSTRING, 0u, (Lparam)(data)));

    public static int ListBoxAddString(HWND hwndCtl, char* lpsz) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_ADDSTRING, 0u, (Lparam)(char*)(lpsz)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxAddString(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ListBoxAddString(hwndCtl, __dsl_lpsz);
        }
    }

    public static int ListBoxDeleteString(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_DELETESTRING, (Wparam)(int)(index), 0));

    public static int ListBoxDir(HWND hwndCtl, uint attrs, char* lpszFileSpec) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_DIR,
                    (Wparam)(uint)(attrs),
                    (Lparam)(char*)(lpszFileSpec)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxDir(HWND hwndCtl, uint attrs, Ref<char> lpszFileSpec)
    {
        fixed (char* __dsl_lpszFileSpec = lpszFileSpec)
        {
            return (int)ListBoxDir(hwndCtl, attrs, __dsl_lpszFileSpec);
        }
    }

    /****** ListBox control message APIs *****************************************/
    public static MaybeBool<int> ListBoxEnable(HWND hwndCtl, MaybeBool<int> fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    public static int ListBoxFindItemData(HWND hwndCtl, int indexStart, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_FINDSTRING, (Wparam)(int)(indexStart), (Lparam)(data)));

    public static int ListBoxFindString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_FINDSTRING,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxFindString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBoxFindString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBoxFindStringExact(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_FINDSTRINGEXACT,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxFindStringExact(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBoxFindStringExact(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBoxGetCaretIndex(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCARETINDEX, 0u, 0));

    public static int ListBoxGetCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCOUNT, 0u, 0));

    public static int ListBoxGetCurSel(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETCURSEL, 0u, 0));

    public static int ListBoxGetHorizontalExtent(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETHORIZONTALEXTENT, 0u, 0));

    public static Lresult ListBoxGetItemData(HWND hwndCtl, int index) =>
        ((Lresult)(nuint)SNDMSG((hwndCtl), LB_GETITEMDATA, (Wparam)(int)(index), 0));

    public static int ListBoxGetItemHeight(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETITEMHEIGHT, (Wparam)(int)(index), 0));

    public static int ListBoxGetItemRect(HWND hwndCtl, int index, RECT* lprc) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETITEMRECT, (Wparam)(int)(index), (Lparam)(RECT*)(lprc)));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxGetItemRect(HWND hwndCtl, int index, Ref<RECT> lprc)
    {
        fixed (RECT* __dsl_lprc = lprc)
        {
            return (int)ListBoxGetItemRect(hwndCtl, index, __dsl_lprc);
        }
    }

    public static int ListBoxGetSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETSEL, (Wparam)(int)(index), 0));

    public static int ListBoxGetSelCount(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETSELCOUNT, 0u, 0));

    public static int ListBoxGetSelItems(HWND hwndCtl, int cItems, int* lpItems) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_GETSELITEMS,
                    (Wparam)(int)(cItems),
                    (Lparam)(int*)(lpItems)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxGetSelItems(HWND hwndCtl, int cItems, Ref<int> lpItems)
    {
        fixed (int* __dsl_lpItems = lpItems)
        {
            return (int)ListBoxGetSelItems(hwndCtl, cItems, __dsl_lpItems);
        }
    }

    public static int ListBoxGetText(HWND hwndCtl, int index, char* lpszBuffer) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_GETTEXT,
                    (Wparam)(int)(index),
                    (Lparam)(char*)(lpszBuffer)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxGetText(HWND hwndCtl, int index, Ref<char> lpszBuffer)
    {
        fixed (char* __dsl_lpszBuffer = lpszBuffer)
        {
            return (int)ListBoxGetText(hwndCtl, index, __dsl_lpszBuffer);
        }
    }

    public static int ListBoxGetTextLen(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETTEXTLEN, (Wparam)(int)(index), 0));

    public static int ListBoxGetTopIndex(HWND hwndCtl) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_GETTOPINDEX, 0u, 0));

    public static int ListBoxInsertItemData(HWND hwndCtl, int index, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_INSERTSTRING, (Wparam)(int)(index), (Lparam)(data)));

    public static int ListBoxInsertString(HWND hwndCtl, int index, char* lpsz) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_INSERTSTRING,
                    (Wparam)(int)(index),
                    (Lparam)(char*)(lpsz)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxInsertString(HWND hwndCtl, int index, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (int)ListBoxInsertString(hwndCtl, index, __dsl_lpsz);
        }
    }

    public static MaybeBool<int> ListBoxResetContent(HWND hwndCtl) =>
        ((MaybeBool<int>)(uint)SNDMSG((hwndCtl), LB_RESETCONTENT, 0u, 0));

    public static int ListBoxSelectItemData(HWND hwndCtl, int indexStart, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SELECTSTRING, (Wparam)(int)(indexStart), (Lparam)(data)));

    public static int ListBoxSelectString(HWND hwndCtl, int indexStart, char* lpszFind) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SELECTSTRING,
                    (Wparam)(int)(indexStart),
                    (Lparam)(char*)(lpszFind)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ListBoxSelectString(HWND hwndCtl, int indexStart, Ref<char> lpszFind)
    {
        fixed (char* __dsl_lpszFind = lpszFind)
        {
            return (int)ListBoxSelectString(hwndCtl, indexStart, __dsl_lpszFind);
        }
    }

    public static int ListBoxSelItemRange(
        HWND hwndCtl,
        MaybeBool<int> fSelect,
        ushort first,
        ushort last
    ) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SELITEMRANGE,
                    (Wparam)(MaybeBool<int>)(fSelect),
                    Makelparam((first), (last))
                )
        );

    public static int ListBoxSetCaretIndex(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETCARETINDEX, (Wparam)(int)(index), 0));

    public static void ListBoxSetColumnWidth(HWND hwndCtl, int cxColumn) =>
        SNDMSG((hwndCtl), LB_SETCOLUMNWIDTH, (Wparam)(int)(cxColumn), 0);

    public static int ListBoxSetCurSel(HWND hwndCtl, int index) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETCURSEL, (Wparam)(int)(index), 0));

    public static void ListBoxSetHorizontalExtent(HWND hwndCtl, int cxExtent) =>
        SNDMSG((hwndCtl), LB_SETHORIZONTALEXTENT, (Wparam)(int)(cxExtent), 0);

    public static int ListBoxSetItemData(HWND hwndCtl, int index, Lparam data) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETITEMDATA, (Wparam)(int)(index), (Lparam)(data)));

    public static int ListBoxSetItemHeight(HWND hwndCtl, int index, ushort cy) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETITEMHEIGHT, (Wparam)(int)(index), Makelparam((cy), 0)));

    public static int ListBoxSetSel(HWND hwndCtl, MaybeBool<int> fSelect, Lparam index) =>
        (
            (int)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SETSEL,
                    (Wparam)(MaybeBool<int>)(fSelect),
                    (Lparam)(index)
                )
        );

    public static MaybeBool<int> ListBoxSetTabStops(HWND hwndCtl, int cTabs, int* lpTabs) =>
        (
            (MaybeBool<int>)
                (uint)SNDMSG(
                    (hwndCtl),
                    LB_SETTABSTOPS,
                    (Wparam)(int)(cTabs),
                    (Lparam)(int*)(lpTabs)
                )
        );

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ListBoxSetTabStops(HWND hwndCtl, int cTabs, Ref<int> lpTabs)
    {
        fixed (int* __dsl_lpTabs = lpTabs)
        {
            return (MaybeBool<int>)ListBoxSetTabStops(hwndCtl, cTabs, __dsl_lpTabs);
        }
    }

    public static int ListBoxSetTopIndex(HWND hwndCtl, int indexTop) =>
        ((int)(uint)SNDMSG((hwndCtl), LB_SETTOPINDEX, (Wparam)(int)(indexTop), 0));

    public static int MapWindowRect(HWND hwndFrom, HWND hwndTo, Point* lprc) =>
        MapWindowPoints((hwndFrom), (hwndTo), (Point*)(lprc), 2);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int MapWindowRect(HWND hwndFrom, HWND hwndTo, Ref<Point> lprc)
    {
        fixed (Point* __dsl_lprc = lprc)
        {
            return (int)MapWindowRect(hwndFrom, hwndTo, __dsl_lprc);
        }
    }

    /****** ScrollBar control message APIs ***************************************/
    /* NOTE: flags parameter is a collection of ESB_* values, NOT a boolean! */
    public static MaybeBool<int> ScrollBarEnable(HWND hwndCtl, uint flags) =>
        EnableScrollBar((hwndCtl), SB_CTL, (flags));

    public static int ScrollBarGetPos(HWND hwndCtl) => GetScrollPos((hwndCtl), SB_CTL);

    public static MaybeBool<int> ScrollBarGetRange(HWND hwndCtl, int* lpposMin, int* lpposMax) =>
        GetScrollRange((hwndCtl), SB_CTL, (lpposMin), (lpposMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> ScrollBarGetRange(
        HWND hwndCtl,
        Ref<int> lpposMin,
        Ref<int> lpposMax
    )
    {
        fixed (int* __dsl_lpposMax = lpposMax)
        fixed (int* __dsl_lpposMin = lpposMin)
        {
            return (MaybeBool<int>)ScrollBarGetRange(hwndCtl, __dsl_lpposMin, __dsl_lpposMax);
        }
    }

    public static int ScrollBarSetPos(HWND hwndCtl, int pos, BOOL fRedraw) =>
        SetScrollPos((hwndCtl), SB_CTL, (pos), (fRedraw));

    public static MaybeBool<int> ScrollBarSetRange(
        HWND hwndCtl,
        int posMin,
        int posMax,
        MaybeBool<int> fRedraw
    ) => SetScrollRange((hwndCtl), SB_CTL, (posMin), (posMax), (fRedraw));

    public static MaybeBool<int> ScrollBarShow(HWND hwndCtl, MaybeBool<int> fShow) =>
        ShowWindow((hwndCtl), (fShow) ? SW_SHOWNORMAL : SW_HIDE);

    public static Hbitmap SelectBitmap(HDC hdc, Hbitmap hbm) =>
        ((Hbitmap)SelectObject((hdc), (HGDIOBJ)(Hbitmap)(hbm)));

    public static Hbrush SelectBrush(HDC hdc, Hbrush hbr) =>
        ((Hbrush)SelectObject((hdc), (HGDIOBJ)(Hbrush)(hbr)));

    public static Hfont SelectFont(HDC hdc, Hfont hfont) =>
        ((Hfont)SelectObject((hdc), (HGDIOBJ)(Hfont)(hfont)));

    public static HPEN SelectPen(HDC hdc, HPEN hpen) =>
        ((HPEN)SelectObject((hdc), (HGDIOBJ)(HPEN)(hpen)));

    public static BOOL SetDlgMsgResult(HWND hwnd, uint msg, BOOL result)
    {
        if (
            (msg) == WM_CTLCOLORMSGBOX
            || (msg) == WM_CTLCOLOREDIT
            || (msg) == WM_CTLCOLORLISTBOX
            || (msg) == WM_CTLCOLORBTN
            || (msg) == WM_CTLCOLORDLG
            || (msg) == WM_CTLCOLORSCROLLBAR
            || (msg) == WM_CTLCOLORSTATIC
            || (msg) == WM_COMPAREITEM
            || (msg) == WM_VKEYTOITEM
            || (msg) == WM_CHARTOITEM
            || (msg) == WM_QUERYDRAGICON
            || (msg) == WM_INITDIALOG
        )
        {
            return (MaybeBool<int>)(result);
        }
        else
        {
            _ = SetWindowLongPtr((hwnd), DWLP_MSGRESULT, (Lparam)(Lresult)(result));
            return TRUE;
        }
    }

    public static void SetWindowFont(HWND hwnd, Hfont hfont, MaybeBool<int> fRedraw) =>
        ForwardWmSetfont((hwnd), (hfont), (fRedraw), SNDMSG);

    public static Lresult SetWindowRedraw(HWND hwnd, MaybeBool<int> fRedraw) =>
        SNDMSG(hwnd, WM_SETREDRAW, (Wparam)(MaybeBool<int>)(fRedraw), 0);

    /****** Static control message APIs ******************************************/
    public static MaybeBool<int> StaticEnable(HWND hwndCtl, MaybeBool<int> fEnable) =>
        EnableWindow((hwndCtl), (fEnable));

    public static HICON StaticGetIcon(HWND hwndCtl, HICON hIcon) =>
        ((HICON)(nuint)SNDMSG((hwndCtl), STM_GETICON, 0u, 0));

    public static int StaticGetText(HWND hwndCtl, char* lpch, int cchMax) =>
        GetWindowText((hwndCtl), (lpch), (cchMax));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int StaticGetText(HWND hwndCtl, Ref<char> lpch, int cchMax)
    {
        fixed (char* __dsl_lpch = lpch)
        {
            return (int)StaticGetText(hwndCtl, __dsl_lpch, cchMax);
        }
    }

    public static int StaticGetTextLength(HWND hwndCtl) => GetWindowTextLength(hwndCtl);

    public static HICON StaticSetIcon(HWND hwndCtl, HICON hIcon) =>
        ((HICON)(nuint)SNDMSG((hwndCtl), STM_SETICON, (Wparam)(HICON)(hIcon), 0));

    public static MaybeBool<int> StaticSetText(HWND hwndCtl, char* lpsz) =>
        SetWindowText((hwndCtl), (lpsz));

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> StaticSetText(HWND hwndCtl, Ref<char> lpsz)
    {
        fixed (char* __dsl_lpsz = lpsz)
        {
            return (MaybeBool<int>)StaticSetText(hwndCtl, __dsl_lpsz);
        }
    }

    public static nint SubclassDialog(
        HWND hwndDlg,
        delegate* unmanaged<HWND, uint, Wparam, Lparam, nint> lpfn
    ) => (SetWindowLongPtr(hwndDlg, (int)(DWLP_DLGPROC), (Lparam)(lpfn)));

    public static delegate* unmanaged<HWND, uint, Wparam, Lparam, Lresult> SubclassWindow(
        HWND hwnd,
        delegate* unmanaged<HWND, uint, Wparam, Lparam, Lresult> lpfn
    ) =>
        (
            (delegate* unmanaged<HWND, uint, Wparam, Lparam, Lresult>)SetWindowLongPtr(
                (hwnd),
                GWLP_WNDPROC,
                (Lparam)(delegate* unmanaged<HWND, uint, Wparam, Lparam, Lresult>)(lpfn)
            )
        );

    public static int SubtractRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_DIFF);

    public static int UnionRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_OR);

    public static int XorRgn(HRGN hrgnResult, HRGN hrgnA, HRGN hrgnB) =>
        CombineRgn(hrgnResult, hrgnA, hrgnB, RGN_XOR);
}
