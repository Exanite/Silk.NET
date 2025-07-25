// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DXCoreCreateAdapterFactory"]/*'/>

    [DllImport("dxcore", ExactSpelling = true, EntryPoint = "DXCoreCreateAdapterFactory")]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HResult DXCoreCreateAdapterFactory(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvFactory
    );

    [SupportedOSPlatform("windows10.0.19041.0")]
    [Transformed]
    [NativeFunction("dxcore", EntryPoint = "DXCoreCreateAdapterFactory")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult DXCoreCreateAdapterFactory(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppvFactory
    )
    {
        fixed (void** __dsl_ppvFactory = ppvFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)DXCoreCreateAdapterFactory(__dsl_riid, __dsl_ppvFactory);
        }
    }

    [SupportedOSPlatform("windows10.0.19041.0")]
    [Transformed]
    [NativeFunction("dxcore", EntryPoint = "DXCoreCreateAdapterFactory")]
    public static HResult DXCoreCreateAdapterFactory<TCom>(out TCom ppvFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppvFactory = default;
        return DXCoreCreateAdapterFactory(TCom.NativeGuid, ppvFactory.GetAddressOf());
    }
}
