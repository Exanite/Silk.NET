// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia"]/*'/>
[Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
[NativeTypeName("struct IDXGIFactoryMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IdxgiFactoryMedia : IdxgiFactoryMedia.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactoryMedia));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(4)]
        HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            DxgiDecodeSwapChainDesc* pDesc,
            IdxgiResource pYuvDecodeBuffers,
            IdxgiOutput pRestrictToOutput,
            IdxgiDecodeSwapChain* ppSwapChain
        );

        [VtblIndex(4)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            Ref<DxgiDecodeSwapChainDesc> pDesc,
            IdxgiResource pYuvDecodeBuffers,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiDecodeSwapChain> ppSwapChain
        );

        [VtblIndex(3)]
        HResult CreateSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
            IdxgiOutput pRestrictToOutput,
            IdxgiSwapChain1* ppSwapChain
        );

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CreateSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiSwapChain1> ppSwapChain
        );
    }

    /// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia"]/*'/>

    [Guid("41E7D1F2-A591-4F7B-A2E5-FA9C843E1C12")]
    [NativeTypeName("struct IDXGIFactoryMedia : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows6.3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiFactoryMedia));
        public void** lpVtbl;

        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;

            [NativeTypeName(
                "HRESULT (IUnknown *, HANDLE, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                Handle,
                DxgiSwapChainDesc1*,
                IdxgiOutput.Native*,
                IdxgiSwapChain1.Native**,
                HResult> CreateSwapChainForCompositionSurfaceHandle;

            [NativeTypeName(
                "HRESULT (IUnknown *, HANDLE, DXGI_DECODE_SWAP_CHAIN_DESC *, IDXGIResource *, IDXGIOutput *, IDXGIDecodeSwapChain **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native*,
                Handle,
                DxgiDecodeSwapChainDesc*,
                IdxgiResource.Native*,
                IdxgiOutput.Native*,
                IdxgiDecodeSwapChain.Native**,
                HResult> CreateDecodeSwapChainForCompositionSurfaceHandle;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiFactoryMedia.Native*, uint>)(lpVtbl[1]))(
                (IdxgiFactoryMedia.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia.CreateDecodeSwapChainForCompositionSurfaceHandle"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            DxgiDecodeSwapChainDesc* pDesc,
            IdxgiResource pYuvDecodeBuffers,
            IdxgiOutput pRestrictToOutput,
            IdxgiDecodeSwapChain* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactoryMedia.Native*,
                    IUnknown.Native*,
                    Handle,
                    DxgiDecodeSwapChainDesc*,
                    IdxgiResource.Native*,
                    IdxgiOutput.Native*,
                    IdxgiDecodeSwapChain.Native**,
                    HResult>)(lpVtbl[4])
            )(
                (IdxgiFactoryMedia.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                hSurface,
                pDesc,
                pYuvDecodeBuffers.LpVtbl,
                pRestrictToOutput.LpVtbl,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            Ref<DxgiDecodeSwapChainDesc> pDesc,
            IdxgiResource pYuvDecodeBuffers,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiDecodeSwapChain> ppSwapChain
        )
        {
            fixed (IdxgiDecodeSwapChain* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiDecodeSwapChainDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateDecodeSwapChainForCompositionSurfaceHandle(
                    pDevice,
                    hSurface,
                    __dsl_pDesc,
                    pYuvDecodeBuffers,
                    pRestrictToOutput,
                    __dsl_ppSwapChain
                );
            }
        }

        /// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia.CreateSwapChainForCompositionSurfaceHandle"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CreateSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
            IdxgiOutput pRestrictToOutput,
            IdxgiSwapChain1* ppSwapChain
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiFactoryMedia.Native*,
                    IUnknown.Native*,
                    Handle,
                    DxgiSwapChainDesc1*,
                    IdxgiOutput.Native*,
                    IdxgiSwapChain1.Native**,
                    HResult>)(lpVtbl[3])
            )(
                (IdxgiFactoryMedia.Native*)Unsafe.AsPointer(ref this),
                pDevice.lpVtbl,
                hSurface,
                pDesc,
                pRestrictToOutput.LpVtbl,
                &ppSwapChain->LpVtbl
            );
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSwapChainForCompositionSurfaceHandle(
            IUnknown pDevice,
            Handle hSurface,
            [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
            IdxgiOutput pRestrictToOutput,
            Ref<IdxgiSwapChain1> ppSwapChain
        )
        {
            fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
            fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSwapChainForCompositionSurfaceHandle(
                    pDevice,
                    hSurface,
                    __dsl_pDesc,
                    pRestrictToOutput,
                    __dsl_ppSwapChain
                );
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiFactoryMedia.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiFactoryMedia.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiFactoryMedia.Native*, uint>)(lpVtbl[2]))(
                (IdxgiFactoryMedia.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactoryMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactoryMedia(Ptr3D vtbl) => LpVtbl = (IdxgiFactoryMedia.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiFactoryMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiFactoryMedia(Ptr<IdxgiFactoryMedia.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiFactoryMedia.Native"/> to <see cref = "IdxgiFactoryMedia"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia.Native"/> instance to be converted </param>

    public static implicit operator IdxgiFactoryMedia(IdxgiFactoryMedia.Native* value) =>
        new IdxgiFactoryMedia((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactoryMedia"/> to <see cref = "IdxgiFactoryMedia.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia"/> instance to be converted </param>

    public static implicit operator IdxgiFactoryMedia.Native*(IdxgiFactoryMedia value) =>
        value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiFactoryMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiFactoryMedia(Ptr3D value) => new IdxgiFactoryMedia(value);

    /// <summary>casts <see cref = "IdxgiFactoryMedia"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiFactoryMedia value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiFactoryMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiFactoryMedia(Ptr<IdxgiFactoryMedia.Native> value) =>
        new IdxgiFactoryMedia(value);

    /// <summary>casts <see cref = "IdxgiFactoryMedia"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiFactoryMedia.Native>(IdxgiFactoryMedia value) =>
        (Ptr<IdxgiFactoryMedia.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiFactoryMedia"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiFactoryMedia(void*** value) =>
        new IdxgiFactoryMedia((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiFactoryMedia"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia"/> instance to be converted </param>

    public static implicit operator void***(IdxgiFactoryMedia value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiFactoryMedia"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiFactoryMedia(nuint value) =>
        new IdxgiFactoryMedia((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiFactoryMedia"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiFactoryMedia"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiFactoryMedia value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia.CreateDecodeSwapChainForCompositionSurfaceHandle"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        Handle hSurface,
        DxgiDecodeSwapChainDesc* pDesc,
        IdxgiResource pYuvDecodeBuffers,
        IdxgiOutput pRestrictToOutput,
        IdxgiDecodeSwapChain* ppSwapChain
    ) =>
        LpVtbl->CreateDecodeSwapChainForCompositionSurfaceHandle(
            pDevice,
            hSurface,
            pDesc,
            pYuvDecodeBuffers,
            pRestrictToOutput,
            ppSwapChain
        );

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDecodeSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        Handle hSurface,
        Ref<DxgiDecodeSwapChainDesc> pDesc,
        IdxgiResource pYuvDecodeBuffers,
        IdxgiOutput pRestrictToOutput,
        Ref<IdxgiDecodeSwapChain> ppSwapChain
    )
    {
        fixed (IdxgiDecodeSwapChain* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiDecodeSwapChainDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateDecodeSwapChainForCompositionSurfaceHandle(
                pDevice,
                hSurface,
                __dsl_pDesc,
                pYuvDecodeBuffers,
                pRestrictToOutput,
                __dsl_ppSwapChain
            );
        }
    }

    /// <include file='IDXGIFactoryMedia.xml' path='doc/member[@name="IDXGIFactoryMedia.CreateSwapChainForCompositionSurfaceHandle"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CreateSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        Handle hSurface,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DxgiSwapChainDesc1* pDesc,
        IdxgiOutput pRestrictToOutput,
        IdxgiSwapChain1* ppSwapChain
    ) =>
        LpVtbl->CreateSwapChainForCompositionSurfaceHandle(
            pDevice,
            hSurface,
            pDesc,
            pRestrictToOutput,
            ppSwapChain
        );

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSwapChainForCompositionSurfaceHandle(
        IUnknown pDevice,
        Handle hSurface,
        [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] Ref<DxgiSwapChainDesc1> pDesc,
        IdxgiOutput pRestrictToOutput,
        Ref<IdxgiSwapChain1> ppSwapChain
    )
    {
        fixed (IdxgiSwapChain1* __dsl_ppSwapChain = ppSwapChain)
        fixed (DxgiSwapChainDesc1* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSwapChainForCompositionSurfaceHandle(
                pDevice,
                hSurface,
                __dsl_pDesc,
                pRestrictToOutput,
                __dsl_ppSwapChain
            );
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
