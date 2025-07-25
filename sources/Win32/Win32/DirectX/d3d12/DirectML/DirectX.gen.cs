// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("const UINT")]
    public const uint DmlTensorDimensionCountMax = 5;

    [NativeTypeName("const UINT")]
    public const uint DmlTensorDimensionCountMax1 = 8;

    [NativeTypeName("const UINT")]
    public const uint DmlTemporaryBufferAlignment = 256;

    [NativeTypeName("const UINT")]
    public const uint DmlPersistentBufferAlignment = 256;

    [NativeTypeName("const UINT")]
    public const uint DmlMinimumBufferTensorAlignment = 16;

    [NativeTypeName("#define DML_TARGET_VERSION 0x5000")]
    public const int DmlTargetVersion = 0x5000;

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DMLCreateDevice"]/*'/>

    [DllImport("directml", ExactSpelling = true, EntryPoint = "_DMLCreateDevice")]
    [SupportedOSPlatform("windows10.0")]
    private static extern HResult DMLCreateDevice(
        ID3D12Device.Native* d3d12Device,
        DmlCreateDeviceFlags flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [SupportedOSPlatform("windows10.0")]
    [Transformed]
    [NativeFunction("directml", EntryPoint = "_DMLCreateDevice")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult DMLCreateDevice(
        Ref<ID3D12Device.Native> d3d12Device,
        DmlCreateDeviceFlags flags,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (ID3D12Device.Native* __dsl_d3d12Device = d3d12Device)
        {
            return (HResult)DMLCreateDevice(__dsl_d3d12Device, flags, __dsl_riid, __dsl_ppv);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DMLCreateDevice1"]/*'/>

    [DllImport("directml", ExactSpelling = true, EntryPoint = "_DMLCreateDevice1")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    private static extern HResult DMLCreateDevice1(
        ID3D12Device.Native* d3d12Device,
        DmlCreateDeviceFlags flags,
        DmlFeatureLevel minimumFeatureLevel,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [SupportedOSPlatform("windows10.0.19043.0")]
    [Transformed]
    [NativeFunction("directml", EntryPoint = "_DMLCreateDevice1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static HResult DMLCreateDevice1(
        Ref<ID3D12Device.Native> d3d12Device,
        DmlCreateDeviceFlags flags,
        DmlFeatureLevel minimumFeatureLevel,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        fixed (ID3D12Device.Native* __dsl_d3d12Device = d3d12Device)
        {
            return (HResult)DMLCreateDevice1(
                __dsl_d3d12Device,
                flags,
                minimumFeatureLevel,
                __dsl_riid,
                __dsl_ppv
            );
        }
    }

    public static HResult DMLCreateDevice(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    ) => DMLCreateDevice(d3d12Device.LpVtbl, flags, riid, ppv);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult DMLCreateDevice(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)DMLCreateDevice(d3d12Device, flags, __dsl_riid, __dsl_ppv);
        }
    }

    [Transformed]
    public static HResult DMLCreateDevice<TCom>(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        out TCom ppv
    )
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return DMLCreateDevice(d3d12Device, flags, TCom.NativeGuid, ppv.GetAddressOf());
    }

    public static HResult DMLCreateDevice1(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        DmlFeatureLevel minimumFeatureLevel,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    ) => DMLCreateDevice1(d3d12Device.LpVtbl, flags, minimumFeatureLevel, riid, ppv);

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult DMLCreateDevice1(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        DmlFeatureLevel minimumFeatureLevel,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppv
    )
    {
        fixed (void** __dsl_ppv = ppv)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)DMLCreateDevice1(
                d3d12Device,
                flags,
                minimumFeatureLevel,
                __dsl_riid,
                __dsl_ppv
            );
        }
    }

    [Transformed]
    public static HResult DMLCreateDevice1<TCom>(
        ID3D12Device d3d12Device,
        DmlCreateDeviceFlags flags,
        DmlFeatureLevel minimumFeatureLevel,
        out TCom ppv
    )
        where TCom : unmanaged, IComVtbl
    {
        ppv = default;
        return DMLCreateDevice1(
            d3d12Device,
            flags,
            minimumFeatureLevel,
            TCom.NativeGuid,
            ppv.GetAddressOf()
        );
    }
}
