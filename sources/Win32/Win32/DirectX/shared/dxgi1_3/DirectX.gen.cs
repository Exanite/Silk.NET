// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateDXGIFactory2"]/*'/>

    [DllImport("dxgi", ExactSpelling = true, EntryPoint = "CreateDXGIFactory2")]
    [SupportedOSPlatform("windows6.3")]
    public static extern HResult CreateDXGIFactory2(
        uint Flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );

    [SupportedOSPlatform("windows6.3")]
    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory2")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult CreateDXGIFactory2(
        uint Flags,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppFactory
    )
    {
        fixed (void** __dsl_ppFactory = ppFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateDXGIFactory2(Flags, __dsl_riid, __dsl_ppFactory);
        }
    }

    [SupportedOSPlatform("windows6.3")]
    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory2")]
    public static HResult CreateDXGIFactory2<TCom>(uint Flags, out TCom ppFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppFactory = default;
        return CreateDXGIFactory2(Flags, TCom.NativeGuid, ppFactory.GetAddressOf());
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DXGIGetDebugInterface1"]/*'/>

    [DllImport("dxgi", ExactSpelling = true, EntryPoint = "DXGIGetDebugInterface1")]
    [SupportedOSPlatform("windows6.3")]
    public static extern HResult DXGIGetDebugInterface1(
        uint Flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** pDebug
    );

    [SupportedOSPlatform("windows6.3")]
    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "DXGIGetDebugInterface1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult DXGIGetDebugInterface1(
        uint Flags,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D pDebug
    )
    {
        fixed (void** __dsl_pDebug = pDebug)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)DXGIGetDebugInterface1(Flags, __dsl_riid, __dsl_pDebug);
        }
    }

    [SupportedOSPlatform("windows6.3")]
    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "DXGIGetDebugInterface1")]
    public static HResult DXGIGetDebugInterface1<TCom>(uint Flags, out TCom pDebug)
        where TCom : unmanaged, IComVtbl
    {
        pDebug = default;
        return DXGIGetDebugInterface1(Flags, TCom.NativeGuid, pDebug.GetAddressOf());
    }
}
