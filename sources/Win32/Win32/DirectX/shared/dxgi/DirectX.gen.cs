// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateDXGIFactory"]/*'/>

    [DllImport("dxgi", ExactSpelling = true, EntryPoint = "CreateDXGIFactory")]
    public static extern HResult CreateDXGIFactory(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );

    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult CreateDXGIFactory(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppFactory
    )
    {
        fixed (void** __dsl_ppFactory = ppFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateDXGIFactory(__dsl_riid, __dsl_ppFactory);
        }
    }

    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory")]
    public static HResult CreateDXGIFactory<TCom>(out TCom ppFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppFactory = default;
        return CreateDXGIFactory(TCom.NativeGuid, ppFactory.GetAddressOf());
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.CreateDXGIFactory1"]/*'/>

    [DllImport("dxgi", ExactSpelling = true, EntryPoint = "CreateDXGIFactory1")]
    public static extern HResult CreateDXGIFactory1(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppFactory
    );

    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory1")]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult CreateDXGIFactory1(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        Ref2D ppFactory
    )
    {
        fixed (void** __dsl_ppFactory = ppFactory)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateDXGIFactory1(__dsl_riid, __dsl_ppFactory);
        }
    }

    [Transformed]
    [NativeFunction("dxgi", EntryPoint = "CreateDXGIFactory1")]
    public static HResult CreateDXGIFactory1<TCom>(out TCom ppFactory)
        where TCom : unmanaged, IComVtbl
    {
        ppFactory = default;
        return CreateDXGIFactory1(TCom.NativeGuid, ppFactory.GetAddressOf());
    }
}
