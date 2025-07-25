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

/// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia"]/*'/>
[Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
[NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IdxgiSwapChainMedia : IdxgiSwapChainMedia.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChainMedia));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(5)]
        HResult CheckPresentDurationSupport(
            uint DesiredPresentDuration,
            uint* pClosestSmallerPresentDuration,
            uint* pClosestLargerPresentDuration
        );

        [VtblIndex(5)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CheckPresentDurationSupport(
            uint DesiredPresentDuration,
            Ref<uint> pClosestSmallerPresentDuration,
            Ref<uint> pClosestLargerPresentDuration
        );

        [VtblIndex(3)]
        HResult GetFrameStatisticsMedia(DxgiFrameStatisticsMedia* pStats);

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetFrameStatisticsMedia(Ref<DxgiFrameStatisticsMedia> pStats);

        [VtblIndex(4)]
        HResult SetPresentDuration(uint Duration);
    }

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia"]/*'/>

    [Guid("DD95B90B-F05F-4F6A-BD65-25BFB264BD84")]
    [NativeTypeName("struct IDXGISwapChainMedia : IUnknown")]
    [NativeInheritance("IUnknown")]
    [SupportedOSPlatform("windows6.3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSwapChainMedia));
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

            [NativeTypeName("HRESULT (DXGI_FRAME_STATISTICS_MEDIA *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                DxgiFrameStatisticsMedia*,
                HResult> GetFrameStatisticsMedia;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetPresentDuration;

            [NativeTypeName("HRESULT (UINT, UINT *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                uint,
                uint*,
                uint*,
                HResult> CheckPresentDurationSupport;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiSwapChainMedia.Native*, uint>)(lpVtbl[1]))(
                (IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.CheckPresentDurationSupport"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult CheckPresentDurationSupport(
            uint DesiredPresentDuration,
            uint* pClosestSmallerPresentDuration,
            uint* pClosestLargerPresentDuration
        )
        {
            return (
                (delegate* unmanaged<IdxgiSwapChainMedia.Native*, uint, uint*, uint*, HResult>)(
                    lpVtbl[5]
                )
            )(
                (IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this),
                DesiredPresentDuration,
                pClosestSmallerPresentDuration,
                pClosestLargerPresentDuration
            );
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CheckPresentDurationSupport(
            uint DesiredPresentDuration,
            Ref<uint> pClosestSmallerPresentDuration,
            Ref<uint> pClosestLargerPresentDuration
        )
        {
            fixed (uint* __dsl_pClosestLargerPresentDuration = pClosestLargerPresentDuration)
            fixed (uint* __dsl_pClosestSmallerPresentDuration = pClosestSmallerPresentDuration)
            {
                return (HResult)CheckPresentDurationSupport(
                    DesiredPresentDuration,
                    __dsl_pClosestSmallerPresentDuration,
                    __dsl_pClosestLargerPresentDuration
                );
            }
        }

        /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.GetFrameStatisticsMedia"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetFrameStatisticsMedia(DxgiFrameStatisticsMedia* pStats)
        {
            return (
                (delegate* unmanaged<
                    IdxgiSwapChainMedia.Native*,
                    DxgiFrameStatisticsMedia*,
                    HResult>)(lpVtbl[3])
            )((IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this), pStats);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetFrameStatisticsMedia(Ref<DxgiFrameStatisticsMedia> pStats)
        {
            fixed (DxgiFrameStatisticsMedia* __dsl_pStats = pStats)
            {
                return (HResult)GetFrameStatisticsMedia(__dsl_pStats);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiSwapChainMedia.Native*, Guid*, void**, HResult>)(
                    lpVtbl[0]
                )
            )((IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiSwapChainMedia.Native*, uint>)(lpVtbl[2]))(
                (IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.SetPresentDuration"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPresentDuration(uint Duration)
        {
            return ((delegate* unmanaged<IdxgiSwapChainMedia.Native*, uint, HResult>)(lpVtbl[4]))(
                (IdxgiSwapChainMedia.Native*)Unsafe.AsPointer(ref this),
                Duration
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChainMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChainMedia(Ptr3D vtbl) => LpVtbl = (IdxgiSwapChainMedia.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSwapChainMedia"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSwapChainMedia(Ptr<IdxgiSwapChainMedia.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiSwapChainMedia.Native"/> to <see cref = "IdxgiSwapChainMedia"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia.Native"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChainMedia(IdxgiSwapChainMedia.Native* value) =>
        new IdxgiSwapChainMedia((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChainMedia"/> to <see cref = "IdxgiSwapChainMedia.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia"/> instance to be converted </param>

    public static implicit operator IdxgiSwapChainMedia.Native*(IdxgiSwapChainMedia value) =>
        value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiSwapChainMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChainMedia(Ptr3D value) =>
        new IdxgiSwapChainMedia(value);

    /// <summary>casts <see cref = "IdxgiSwapChainMedia"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiSwapChainMedia value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiSwapChainMedia"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChainMedia(Ptr<IdxgiSwapChainMedia.Native> value) =>
        new IdxgiSwapChainMedia(value);

    /// <summary>casts <see cref = "IdxgiSwapChainMedia"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiSwapChainMedia.Native>(IdxgiSwapChainMedia value) =>
        (Ptr<IdxgiSwapChainMedia.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiSwapChainMedia"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiSwapChainMedia(void*** value) =>
        new IdxgiSwapChainMedia((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSwapChainMedia"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia"/> instance to be converted </param>

    public static implicit operator void***(IdxgiSwapChainMedia value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiSwapChainMedia"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiSwapChainMedia(nuint value) =>
        new IdxgiSwapChainMedia((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiSwapChainMedia"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSwapChainMedia"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiSwapChainMedia value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.CheckPresentDurationSupport"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult CheckPresentDurationSupport(
        uint DesiredPresentDuration,
        uint* pClosestSmallerPresentDuration,
        uint* pClosestLargerPresentDuration
    ) =>
        LpVtbl->CheckPresentDurationSupport(
            DesiredPresentDuration,
            pClosestSmallerPresentDuration,
            pClosestLargerPresentDuration
        );

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckPresentDurationSupport(
        uint DesiredPresentDuration,
        Ref<uint> pClosestSmallerPresentDuration,
        Ref<uint> pClosestLargerPresentDuration
    )
    {
        fixed (uint* __dsl_pClosestLargerPresentDuration = pClosestLargerPresentDuration)
        fixed (uint* __dsl_pClosestSmallerPresentDuration = pClosestSmallerPresentDuration)
        {
            return (HResult)CheckPresentDurationSupport(
                DesiredPresentDuration,
                __dsl_pClosestSmallerPresentDuration,
                __dsl_pClosestLargerPresentDuration
            );
        }
    }

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.GetFrameStatisticsMedia"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetFrameStatisticsMedia(DxgiFrameStatisticsMedia* pStats) =>
        LpVtbl->GetFrameStatisticsMedia(pStats);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetFrameStatisticsMedia(Ref<DxgiFrameStatisticsMedia> pStats)
    {
        fixed (DxgiFrameStatisticsMedia* __dsl_pStats = pStats)
        {
            return (HResult)GetFrameStatisticsMedia(__dsl_pStats);
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

    /// <include file='IDXGISwapChainMedia.xml' path='doc/member[@name="IDXGISwapChainMedia.SetPresentDuration"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPresentDuration(uint Duration) => LpVtbl->SetPresentDuration(Duration);
}
