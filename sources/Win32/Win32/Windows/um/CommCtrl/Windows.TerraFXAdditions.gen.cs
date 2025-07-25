// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    [NativeTypeName(
        "#define IMAGELISTDRAWPARAMS_V3_SIZE CCSIZEOF_STRUCT(IMAGELISTDRAWPARAMS, dwRop)"
    )]
    public static uint ImagelistdrawparamsV3Size
    {
        get
        {
            Unsafe.SkipInit(out IMAGELISTDRAWPARAMS value);
            return (uint)((byte*)(&value.dwRop) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define HDITEMA_V1_SIZE CCSIZEOF_STRUCT(HDITEMA, lParam)")]
    public static uint HditemaV1Size
    {
        get
        {
            Unsafe.SkipInit(out HDITEMA value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define HDITEMW_V1_SIZE CCSIZEOF_STRUCT(HDITEMW, lParam)")]
    public static uint HditemwV1Size
    {
        get
        {
            Unsafe.SkipInit(out HDITEMW value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define HDITEM_V1_SIZE HDITEMW_V1_SIZE")]
    public static uint HditemV1Size => HditemwV1Size;

    [NativeTypeName("#define REBARBANDINFOA_V3_SIZE CCSIZEOF_STRUCT(REBARBANDINFOA, wID)")]
    public static uint RebarbandinfoaV3Size
    {
        get
        {
            Unsafe.SkipInit(out REBARBANDINFOA value);
            return (uint)((byte*)(&value.wID) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define REBARBANDINFOW_V3_SIZE CCSIZEOF_STRUCT(REBARBANDINFOW, wID)")]
    public static uint RebarbandinfowV3Size
    {
        get
        {
            Unsafe.SkipInit(out REBARBANDINFOW value);
            return (uint)((byte*)(&value.wID) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define REBARBANDINFOA_V6_SIZE CCSIZEOF_STRUCT(REBARBANDINFOA, cxHeader)")]
    public static uint RebarbandinfoaV6Size
    {
        get
        {
            Unsafe.SkipInit(out REBARBANDINFOA value);
            return (uint)((byte*)(&value.cxHeader) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define REBARBANDINFOW_V6_SIZE CCSIZEOF_STRUCT(REBARBANDINFOW, cxHeader)")]
    public static uint RebarbandinfowV6Size
    {
        get
        {
            Unsafe.SkipInit(out REBARBANDINFOW value);
            return (uint)((byte*)(&value.cxHeader) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define REBARBANDINFO_V3_SIZE REBARBANDINFOW_V3_SIZE")]
    public static uint RebarbandinfoV3Size => RebarbandinfowV3Size;

    [NativeTypeName("#define REBARBANDINFO_V6_SIZE REBARBANDINFOW_V6_SIZE")]
    public static uint RebarbandinfoV6Size => RebarbandinfowV6Size;

    [NativeTypeName("#define TTTOOLINFOA_V1_SIZE CCSIZEOF_STRUCT(TTTOOLINFOA, lpszText)")]
    public static uint TttoolinfoaV1Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOA value);
            return (uint)((byte*)(&value.lpszText) - ((byte*)(&value))) + (uint)(sizeof(char*));
        }
    }

    [NativeTypeName("#define TTTOOLINFOW_V1_SIZE CCSIZEOF_STRUCT(TTTOOLINFOW, lpszText)")]
    public static uint TttoolinfowV1Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOW value);
            return (uint)((byte*)(&value.lpszText) - ((byte*)(&value))) + (uint)(sizeof(char*));
        }
    }

    [NativeTypeName("#define TTTOOLINFOA_V2_SIZE CCSIZEOF_STRUCT(TTTOOLINFOA, lParam)")]
    public static uint TttoolinfoaV2Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOA value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define TTTOOLINFOW_V2_SIZE CCSIZEOF_STRUCT(TTTOOLINFOW, lParam)")]
    public static uint TttoolinfowV2Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOW value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define TTTOOLINFOA_V3_SIZE CCSIZEOF_STRUCT(TTTOOLINFOA, lpReserved)")]
    public static uint TttoolinfoaV3Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOA value);
            return (uint)((byte*)(&value.lpReserved) - ((byte*)(&value))) + (uint)(sizeof(void*));
        }
    }

    [NativeTypeName("#define TTTOOLINFOW_V3_SIZE CCSIZEOF_STRUCT(TTTOOLINFOW, lpReserved)")]
    public static uint TttoolinfowV3Size
    {
        get
        {
            Unsafe.SkipInit(out TTTOOLINFOW value);
            return (uint)((byte*)(&value.lpReserved) - ((byte*)(&value))) + (uint)(sizeof(void*));
        }
    }

    [NativeTypeName("#define TTTOOLINFO_V1_SIZE TTTOOLINFOW_V1_SIZE")]
    public static uint TttoolinfoV1Size => TttoolinfowV1Size;

    [NativeTypeName("#define NMTTDISPINFOA_V1_SIZE CCSIZEOF_STRUCT(NMTTDISPINFOA, uFlags)")]
    public static uint NmttdispinfoaV1Size
    {
        get
        {
            Unsafe.SkipInit(out NMTTDISPINFOA value);
            return (uint)((byte*)(&value.uFlags) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define NMTTDISPINFOW_V1_SIZE CCSIZEOF_STRUCT(NMTTDISPINFOW, uFlags)")]
    public static uint NmttdispinfowV1Size
    {
        get
        {
            Unsafe.SkipInit(out NMTTDISPINFOW value);
            return (uint)((byte*)(&value.uFlags) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define NMTTDISPINFO_V1_SIZE NMTTDISPINFOW_V1_SIZE")]
    public static uint NmttdispinfoV1Size => NmttdispinfowV1Size;

    [NativeTypeName("#define LVITEMA_V1_SIZE CCSIZEOF_STRUCT(LVITEMA, lParam)")]
    public static uint LvitemaV1Size
    {
        get
        {
            Unsafe.SkipInit(out LVITEMA value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define LVITEMW_V1_SIZE CCSIZEOF_STRUCT(LVITEMW, lParam)")]
    public static uint LvitemwV1Size
    {
        get
        {
            Unsafe.SkipInit(out LVITEMW value);
            return (uint)((byte*)(&value.lParam) - ((byte*)(&value))) + (uint)(sizeof(nint));
        }
    }

    [NativeTypeName("#define LVITEMA_V5_SIZE CCSIZEOF_STRUCT(LVITEMA, puColumns)")]
    public static uint LvitemaV5Size
    {
        get
        {
            Unsafe.SkipInit(out LVITEMA value);
            return (uint)((byte*)(&value.puColumns) - ((byte*)(&value))) + (uint)(sizeof(uint*));
        }
    }

    [NativeTypeName("#define LVITEMW_V5_SIZE CCSIZEOF_STRUCT(LVITEMW, puColumns)")]
    public static uint LvitemwV5Size
    {
        get
        {
            Unsafe.SkipInit(out LVITEMW value);
            return (uint)((byte*)(&value.puColumns) - ((byte*)(&value))) + (uint)(sizeof(uint*));
        }
    }

    [NativeTypeName("#define LVITEM_V5_SIZE LVITEMW_V5_SIZE")]
    public static uint LvitemV5Size => LvitemwV5Size;

    [NativeTypeName("#define LVITEM_V1_SIZE LVITEMW_V1_SIZE")]
    public static uint LvitemV1Size => LvitemwV1Size;

    [NativeTypeName("#define LVHITTESTINFO_V1_SIZE CCSIZEOF_STRUCT(LVHITTESTINFO, iItem)")]
    public static uint LvhittestinfoV1Size
    {
        get
        {
            Unsafe.SkipInit(out LVHITTESTINFO value);
            return (uint)((byte*)(&value.iItem) - ((byte*)(&value))) + sizeof(int);
        }
    }

    [NativeTypeName("#define LVCOLUMNA_V1_SIZE CCSIZEOF_STRUCT(LVCOLUMNA, iSubItem)")]
    public static uint LvcolumnaV1Size
    {
        get
        {
            Unsafe.SkipInit(out LVCOLUMNA value);
            return (uint)((byte*)(&value.iSubItem) - ((byte*)(&value))) + sizeof(int);
        }
    }

    [NativeTypeName("#define LVCOLUMNW_V1_SIZE CCSIZEOF_STRUCT(LVCOLUMNW, iSubItem)")]
    public static uint LvcolumnwV1Size
    {
        get
        {
            Unsafe.SkipInit(out LVCOLUMNW value);
            return (uint)((byte*)(&value.iSubItem) - ((byte*)(&value))) + sizeof(int);
        }
    }

    [NativeTypeName("#define LVCOLUMN_V1_SIZE LVCOLUMNW_V1_SIZE")]
    public static uint LvcolumnV1Size => LvcolumnwV1Size;

    [NativeTypeName("#define LVGROUP_V5_SIZE CCSIZEOF_STRUCT(LVGROUP, uAlign)")]
    public static uint LvgroupV5Size
    {
        get
        {
            Unsafe.SkipInit(out LVGROUP value);
            return (uint)((byte*)(&value.uAlign) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define LVTILEINFO_V5_SIZE CCSIZEOF_STRUCT(LVTILEINFO, puColumns)")]
    public static uint LvtileinfoV5Size
    {
        get
        {
            Unsafe.SkipInit(out LVTILEINFO value);
            return (uint)((byte*)(&value.puColumns) - ((byte*)(&value))) + (uint)(sizeof(uint*));
        }
    }

    [NativeTypeName("#define NMLVCUSTOMDRAW_V3_SIZE CCSIZEOF_STRUCT(NMLVCUSTOMDRAW, clrTextBk)")]
    public static uint NmlvcustomdrawV3Size
    {
        get
        {
            Unsafe.SkipInit(out NMLVCUSTOMDRAW value);
            return (uint)((byte*)(&value.clrTextBk) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define TVINSERTSTRUCTA_V1_SIZE CCSIZEOF_STRUCT(TVINSERTSTRUCTA, item)")]
    public static uint TvinsertstructaV1Size
    {
        get
        {
            Unsafe.SkipInit(out TVINSERTSTRUCTA value);
            return (uint)((byte*)(&value.Anonymous.item) - ((byte*)(&value)))
                + (uint)(sizeof(TVITEMA));
        }
    }

    [NativeTypeName("#define TVINSERTSTRUCTW_V1_SIZE CCSIZEOF_STRUCT(TVINSERTSTRUCTW, item)")]
    public static uint TvinsertstructwV1Size
    {
        get
        {
            Unsafe.SkipInit(out TVINSERTSTRUCTW value);
            return (uint)((byte*)(&value.Anonymous.item) - ((byte*)(&value)))
                + (uint)(sizeof(TVITEMW));
        }
    }

    [NativeTypeName("#define TVINSERTSTRUCT_V1_SIZE TVINSERTSTRUCTW_V1_SIZE")]
    public static uint TvinsertstructV1Size => TvinsertstructwV1Size;

    [NativeTypeName("#define NMTVCUSTOMDRAW_V3_SIZE CCSIZEOF_STRUCT(NMTVCUSTOMDRAW, clrTextBk)")]
    public static uint NmtvcustomdrawV3Size
    {
        get
        {
            Unsafe.SkipInit(out NMTVCUSTOMDRAW value);
            return (uint)((byte*)(&value.clrTextBk) - ((byte*)(&value))) + sizeof(uint);
        }
    }

    [NativeTypeName("#define MCHITTESTINFO_V1_SIZE CCSIZEOF_STRUCT(MCHITTESTINFO, st)")]
    public static uint MchittestinfoV1Size
    {
        get
        {
            Unsafe.SkipInit(out MCHITTESTINFO value);
            return (uint)((byte*)(&value.st) - ((byte*)(&value))) + (uint)(sizeof(SYSTEMTIME));
        }
    }

    [NativeTypeName("#define HBITMAP_CALLBACK ((HBITMAP)-1)")]
    public static Hbitmap HbitmapCallback => ((Hbitmap)(-1));

    [NativeTypeName("#define HINST_COMMCTRL ((HINSTANCE)-1)")]
    public static HINSTANCE HinstCommctrl => ((HINSTANCE)(-1));

    [NativeTypeName("#define TVI_ROOT ((HTREEITEM)(ULONG_PTR)-0x10000)")]
    public static HTREEITEM TviRoot => unchecked((HTREEITEM)((nuint)(-0x10000)));

    [NativeTypeName("#define TVI_FIRST ((HTREEITEM)(ULONG_PTR)-0x0FFFF)")]
    public static HTREEITEM TviFirst => unchecked((HTREEITEM)((nuint)(-0x0FFFF)));

    [NativeTypeName("#define TVI_LAST ((HTREEITEM)(ULONG_PTR)-0x0FFFE)")]
    public static HTREEITEM TviLast => unchecked((HTREEITEM)((nuint)(-0x0FFFE)));

    [NativeTypeName("#define TVI_SORT ((HTREEITEM)(ULONG_PTR)-0x0FFFD)")]
    public static HTREEITEM TviSort => unchecked((HTREEITEM)((nuint)(-0x0FFFD)));

    [NativeTypeName("#define BCCL_NOGLYPH (HIMAGELIST)(-1)")]
    public static HIMAGELIST BcclNoglyph => (HIMAGELIST)(-1);

    public static MaybeBool<int> FlatSBGetScrollPropPtr(HWND param0, int propIndex, nint* param2)
    {
        if (sizeof(nint) == 4)
        {
            return FlatSB_GetScrollProp(param0, propIndex, (int*)param2);
        }
        else
        {
            [DllImport("comctl32", EntryPoint = "FlatSB_GetScrollPropPtr", ExactSpelling = true)]
            static extern MaybeBool<int> _FlatSB_GetScrollPropPtr(
                HWND param0,
                int propIndex,
                nint* param2
            );
            return _FlatSB_GetScrollPropPtr(param0, propIndex, param2);
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static MaybeBool<int> FlatSBGetScrollPropPtr(
        HWND param0,
        int propIndex,
        Ref<nint> param2
    )
    {
        fixed (nint* __dsl_param2 = param2)
        {
            return (MaybeBool<int>)FlatSBGetScrollPropPtr(param0, propIndex, __dsl_param2);
        }
    }
}
