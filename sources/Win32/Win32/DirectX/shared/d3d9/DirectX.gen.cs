// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("#define DIRECT3D_VERSION 0x0900")]
    public const int Direct3DVersion = 0x0900;

    [NativeTypeName("#define D3D9b_SDK_VERSION 31")]
    public const int D3D9BSDKVersion = 31;

    [NativeTypeName("#define D3DSPD_IUNKNOWN 0x00000001L")]
    public const int D3DspdIunknown = 0x00000001;

    [NativeTypeName("#define D3DADAPTER_DEFAULT 0")]
    public const int D3DadapterDefault = 0;

    [NativeTypeName("#define _FACD3D 0x876")]
    public const int Facd3D = 0x876;

    [Transformed]
    [NativeFunction("d3d9", EntryPoint = "_Direct3DCreate9")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Ptr<IDirect3D9.Native.Native> Direct3DCreate9(uint SDKVersion) =>
        (IDirect3D9.Native.Native*)Direct3DCreate9Raw(SDKVersion);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Direct3DCreate9Ex"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "_Direct3DCreate9Ex")]
    private static extern HResult Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex.Native** param1);

    [Transformed]
    [NativeFunction("d3d9", EntryPoint = "_Direct3DCreate9Ex")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult Direct3DCreate9Ex(uint SDKVersion, Ref2D<IDirect3D9Ex.Native> param1)
    {
        fixed (IDirect3D9Ex.Native** __dsl_param1 = param1)
        {
            return (HResult)Direct3DCreate9Ex(SDKVersion, __dsl_param1);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.Direct3DCreate9"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "_Direct3DCreate9")]
    private static extern IDirect3D9.Native.Native* Direct3DCreate9Raw(uint SDKVersion);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_BeginEvent"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_BeginEvent")]
    public static extern int D3DperfBeginEvent(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [Transformed]
    [NativeFunction("d3d9", EntryPoint = "D3DPERF_BeginEvent")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int D3DperfBeginEvent(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] Ref<ushort> wszName
    )
    {
        fixed (ushort* __dsl_wszName = wszName)
        {
            return (int)D3DperfBeginEvent(col, __dsl_wszName);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_EndEvent"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_EndEvent")]
    public static extern int D3DperfEndEvent();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_GetStatus"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_GetStatus")]
    [return: NativeTypeName("DWORD")]
    public static extern uint D3DperfGetStatus();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_QueryRepeatFrame"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_QueryRepeatFrame")]
    [return: NativeTypeName("BOOL")]
    public static extern MaybeBool<int> D3DperfQueryRepeatFrame();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetMarker"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_SetMarker")]
    public static extern void D3DperfSetMarker(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [Transformed]
    [NativeFunction("d3d9", EntryPoint = "D3DPERF_SetMarker")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void D3DperfSetMarker(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] Ref<ushort> wszName
    )
    {
        fixed (ushort* __dsl_wszName = wszName)
        {
            D3DperfSetMarker(col, __dsl_wszName);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetOptions"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_SetOptions")]
    public static extern void D3DperfSetOptions([NativeTypeName("DWORD")] uint dwOptions);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3DPERF_SetRegion"]/*'/>

    [DllImport("d3d9", ExactSpelling = true, EntryPoint = "D3DPERF_SetRegion")]
    public static extern void D3DperfSetRegion(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] ushort* wszName
    );

    [Transformed]
    [NativeFunction("d3d9", EntryPoint = "D3DPERF_SetRegion")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void D3DperfSetRegion(
        [NativeTypeName("D3DCOLOR")] uint col,
        [NativeTypeName("LPCWSTR")] Ref<ushort> wszName
    )
    {
        fixed (ushort* __dsl_wszName = wszName)
        {
            D3DperfSetRegion(col, __dsl_wszName);
        }
    }

    public static IDirect3D9 Direct3DCreate9(uint SDKVersion) =>
        (IDirect3D9)Direct3DCreate9Raw(SDKVersion);

    public static HResult Direct3DCreate9Ex(uint SDKVersion, IDirect3D9Ex* param1) =>
        Direct3DCreate9Ex(SDKVersion, &param1->LpVtbl);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult Direct3DCreate9Ex(uint SDKVersion, Ref<IDirect3D9Ex> param1)
    {
        fixed (IDirect3D9Ex* __dsl_param1 = param1)
        {
            return (HResult)Direct3DCreate9Ex(SDKVersion, __dsl_param1);
        }
    }
}
