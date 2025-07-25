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

/// <include file='IDXGIDevice3.xml' path='doc/member[@name="IDXGIDevice3"]/*'/>
[Guid("6007896C-3244-4AFD-BF18-A6D3BEDA5023")]
[NativeTypeName("struct IDXGIDevice3 : IDXGIDevice2")]
[NativeInheritance("IDXGIDevice2")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IdxgiDevice3 : IdxgiDevice3.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDevice3));

    public interface Interface : IdxgiDevice2.Interface
    {
        [VtblIndex(17)]
        void Trim();
    }

    /// <include file='IDXGIDevice3.xml' path='doc/member[@name="IDXGIDevice3"]/*'/>

    [Guid("6007896C-3244-4AFD-BF18-A6D3BEDA5023")]
    [NativeTypeName("struct IDXGIDevice3 : IDXGIDevice2")]
    [NativeInheritance("IDXGIDevice2")]
    [SupportedOSPlatform("windows6.3")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDevice3));
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

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                TSelf*,
                Guid*,
                IUnknown.Native*,
                HResult> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetParent;

            [NativeTypeName("HRESULT (IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, IdxgiAdapter.Native**, HResult> GetAdapter;

            [NativeTypeName(
                "HRESULT (const DXGI_SURFACE_DESC *, UINT, DXGI_USAGE, const DXGI_SHARED_RESOURCE *, IDXGISurface **) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                DxgiSurfaceDesc*,
                uint,
                uint,
                DxgiSharedResource*,
                IdxgiSurface.Native**,
                HResult> CreateSurface;

            [NativeTypeName(
                "HRESULT (IUnknown *const *, DXGI_RESIDENCY *, UINT) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                IUnknown.Native**,
                DxgiResidency*,
                uint,
                HResult> QueryResourceResidency;

            [NativeTypeName("HRESULT (INT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int, HResult> SetGPUThreadPriority;

            [NativeTypeName("HRESULT (INT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, int*, HResult> GetGPUThreadPriority;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, HResult> SetMaximumFrameLatency;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint*, HResult> GetMaximumFrameLatency;

            [NativeTypeName(
                "HRESULT (UINT, IDXGIResource *const *, DXGI_OFFER_RESOURCE_PRIORITY) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                IdxgiResource.Native**,
                DxgiOfferResourcePriority,
                HResult> OfferResources;

            [NativeTypeName(
                "HRESULT (UINT, IDXGIResource *const *, BOOL *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                TSelf*,
                uint,
                IdxgiResource.Native**,
                MaybeBool<int>*,
                HResult> ReclaimResources;

            [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle, HResult> EnqueueSetEvent;

            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> Trim;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, uint>)(lpVtbl[1]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiDevice.CreateSurface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult CreateSurface(
            [NativeTypeName("const DXGI_SURFACE_DESC *")] DxgiSurfaceDesc* pDesc,
            uint NumSurfaces,
            [NativeTypeName("DXGI_USAGE")] uint Usage,
            [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DxgiSharedResource* pSharedResource,
            IdxgiSurface* ppSurface
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiDevice3.Native*,
                    DxgiSurfaceDesc*,
                    uint,
                    uint,
                    DxgiSharedResource*,
                    IdxgiSurface.Native**,
                    HResult>)(lpVtbl[8])
            )(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                pDesc,
                NumSurfaces,
                Usage,
                pSharedResource,
                &ppSurface->LpVtbl
            );
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult CreateSurface(
            [NativeTypeName("const DXGI_SURFACE_DESC *")] Ref<DxgiSurfaceDesc> pDesc,
            uint NumSurfaces,
            [NativeTypeName("DXGI_USAGE")] uint Usage,
            [NativeTypeName("const DXGI_SHARED_RESOURCE *")]
                Ref<DxgiSharedResource> pSharedResource,
            Ref<IdxgiSurface> ppSurface
        )
        {
            fixed (IdxgiSurface* __dsl_ppSurface = ppSurface)
            fixed (DxgiSharedResource* __dsl_pSharedResource = pSharedResource)
            fixed (DxgiSurfaceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateSurface(
                    __dsl_pDesc,
                    NumSurfaces,
                    Usage,
                    __dsl_pSharedResource,
                    __dsl_ppSurface
                );
            }
        }

        /// <inheritdoc cref = "IdxgiDevice2.EnqueueSetEvent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult EnqueueSetEvent(Handle hEvent)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, Handle, HResult>)(lpVtbl[16]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                hEvent
            );
        }

        /// <inheritdoc cref = "IdxgiDevice.GetAdapter"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetAdapter(IdxgiAdapter* pAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiDevice3.Native*, IdxgiAdapter.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiDevice3.Native*)Unsafe.AsPointer(ref this), &pAdapter->LpVtbl);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetAdapter(Ref<IdxgiAdapter> pAdapter)
        {
            fixed (IdxgiAdapter* __dsl_pAdapter = pAdapter)
            {
                return (HResult)GetAdapter(__dsl_pAdapter);
            }
        }

        /// <inheritdoc cref = "IdxgiDevice.GetGPUThreadPriority"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetGPUThreadPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, int*, HResult>)(lpVtbl[11]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                pPriority
            );
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetGPUThreadPriority(Ref<int> pPriority)
        {
            fixed (int* __dsl_pPriority = pPriority)
            {
                return (HResult)GetGPUThreadPriority(__dsl_pPriority);
            }
        }

        /// <inheritdoc cref = "IdxgiDevice1.GetMaximumFrameLatency"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult GetMaximumFrameLatency(uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, uint*, HResult>)(lpVtbl[13]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                pMaxLatency
            );
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
        {
            fixed (uint* __dsl_pMaxLatency = pMaxLatency)
            {
                return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppParent
            );
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
        {
            fixed (void** __dsl_ppParent = ppParent)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        public HResult GetParent<TCom>(out TCom ppParent)
            where TCom : unmanaged, IComVtbl
        {
            ppParent = default;
            return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint* pDataSize,
            void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiDevice3.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiDevice3.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            Ref<uint> pDataSize,
            Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (uint* __dsl_pDataSize = pDataSize)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IdxgiDevice2.OfferResources"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult OfferResources(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] IdxgiResource* ppResources,
            DxgiOfferResourcePriority Priority
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiDevice3.Native*,
                    uint,
                    IdxgiResource.Native**,
                    DxgiOfferResourcePriority,
                    HResult>)(lpVtbl[14])
            )(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                NumResources,
                &ppResources->LpVtbl,
                Priority
            );
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult OfferResources(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] Ref<IdxgiResource> ppResources,
            DxgiOfferResourcePriority Priority
        )
        {
            fixed (IdxgiResource* __dsl_ppResources = ppResources)
            {
                return (HResult)OfferResources(NumResources, __dsl_ppResources, Priority);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
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

        /// <inheritdoc cref = "IdxgiDevice.QueryResourceResidency"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult QueryResourceResidency(
            [NativeTypeName("IUnknown *const *")] IUnknown* ppResources,
            DxgiResidency* pResidencyStatus,
            uint NumResources
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiDevice3.Native*,
                    IUnknown.Native**,
                    DxgiResidency*,
                    uint,
                    HResult>)(lpVtbl[9])
            )(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                &ppResources->lpVtbl,
                pResidencyStatus,
                NumResources
            );
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryResourceResidency(
            [NativeTypeName("IUnknown *const *")] Ref<IUnknown> ppResources,
            Ref<DxgiResidency> pResidencyStatus,
            uint NumResources
        )
        {
            fixed (DxgiResidency* __dsl_pResidencyStatus = pResidencyStatus)
            fixed (IUnknown* __dsl_ppResources = ppResources)
            {
                return (HResult)QueryResourceResidency(
                    __dsl_ppResources,
                    __dsl_pResidencyStatus,
                    NumResources
                );
            }
        }

        /// <inheritdoc cref = "IdxgiDevice2.ReclaimResources"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult ReclaimResources(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] IdxgiResource* ppResources,
            [NativeTypeName("BOOL *")] MaybeBool<int>* pDiscarded
        )
        {
            return (
                (delegate* unmanaged<
                    IdxgiDevice3.Native*,
                    uint,
                    IdxgiResource.Native**,
                    MaybeBool<int>*,
                    HResult>)(lpVtbl[15])
            )(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                NumResources,
                &ppResources->LpVtbl,
                pDiscarded
            );
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult ReclaimResources(
            uint NumResources,
            [NativeTypeName("IDXGIResource *const *")] Ref<IdxgiResource> ppResources,
            [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pDiscarded
        )
        {
            fixed (MaybeBool<int>* __dsl_pDiscarded = pDiscarded)
            fixed (IdxgiResource* __dsl_ppResources = ppResources)
            {
                return (HResult)ReclaimResources(NumResources, __dsl_ppResources, __dsl_pDiscarded);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, uint>)(lpVtbl[2]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiDevice.SetGPUThreadPriority"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetGPUThreadPriority(int Priority)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, int, HResult>)(lpVtbl[10]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                Priority
            );
        }

        /// <inheritdoc cref = "IdxgiDevice1.SetMaximumFrameLatency"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult SetMaximumFrameLatency(uint MaxLatency)
        {
            return ((delegate* unmanaged<IdxgiDevice3.Native*, uint, HResult>)(lpVtbl[12]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this),
                MaxLatency
            );
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint DataSize,
            [NativeTypeName("const void *")] void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiDevice3.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiDevice3.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            uint DataSize,
            [NativeTypeName("const void *")] Ref pData
        )
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Guid* Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            return (
                (delegate* unmanaged<IdxgiDevice3.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiDevice3.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            fixed (Guid* __dsl_Name = Name)
            {
                return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
            }
        }

        /// <include file='IDXGIDevice3.xml' path='doc/member[@name="IDXGIDevice3.Trim"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void Trim()
        {
            ((delegate* unmanaged<IdxgiDevice3.Native*, void>)(lpVtbl[17]))(
                (IdxgiDevice3.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDevice3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDevice3(Ptr3D vtbl) => LpVtbl = (IdxgiDevice3.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDevice3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDevice3(Ptr<IdxgiDevice3.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiDevice3.Native"/> to <see cref = "IdxgiDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3.Native"/> instance to be converted </param>

    public static implicit operator IdxgiDevice3(IdxgiDevice3.Native* value) =>
        new IdxgiDevice3((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDevice3"/> to <see cref = "IdxgiDevice3.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3"/> instance to be converted </param>

    public static implicit operator IdxgiDevice3.Native*(IdxgiDevice3 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiDevice3(Ptr3D value) => new IdxgiDevice3(value);

    /// <summary>casts <see cref = "IdxgiDevice3"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiDevice3 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiDevice3(Ptr<IdxgiDevice3.Native> value) =>
        new IdxgiDevice3(value);

    /// <summary>casts <see cref = "IdxgiDevice3"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiDevice3.Native>(IdxgiDevice3 value) =>
        (Ptr<IdxgiDevice3.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiDevice3"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiDevice3(void*** value) =>
        new IdxgiDevice3((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDevice3"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3"/> instance to be converted </param>

    public static implicit operator void***(IdxgiDevice3 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiDevice3(nuint value) =>
        new IdxgiDevice3((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiDevice3"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice3"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiDevice3 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <inheritdoc cref = "IdxgiDevice.CreateSurface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult CreateSurface(
        [NativeTypeName("const DXGI_SURFACE_DESC *")] DxgiSurfaceDesc* pDesc,
        uint NumSurfaces,
        [NativeTypeName("DXGI_USAGE")] uint Usage,
        [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DxgiSharedResource* pSharedResource,
        IdxgiSurface* ppSurface
    ) => LpVtbl->CreateSurface(pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSurface(
        [NativeTypeName("const DXGI_SURFACE_DESC *")] Ref<DxgiSurfaceDesc> pDesc,
        uint NumSurfaces,
        [NativeTypeName("DXGI_USAGE")] uint Usage,
        [NativeTypeName("const DXGI_SHARED_RESOURCE *")] Ref<DxgiSharedResource> pSharedResource,
        Ref<IdxgiSurface> ppSurface
    )
    {
        fixed (IdxgiSurface* __dsl_ppSurface = ppSurface)
        fixed (DxgiSharedResource* __dsl_pSharedResource = pSharedResource)
        fixed (DxgiSurfaceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateSurface(
                __dsl_pDesc,
                NumSurfaces,
                Usage,
                __dsl_pSharedResource,
                __dsl_ppSurface
            );
        }
    }

    /// <inheritdoc cref = "IdxgiDevice2.EnqueueSetEvent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult EnqueueSetEvent(Handle hEvent) => LpVtbl->EnqueueSetEvent(hEvent);

    /// <inheritdoc cref = "IdxgiDevice.GetAdapter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetAdapter(IdxgiAdapter* pAdapter) => LpVtbl->GetAdapter(pAdapter);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetAdapter(Ref<IdxgiAdapter> pAdapter)
    {
        fixed (IdxgiAdapter* __dsl_pAdapter = pAdapter)
        {
            return (HResult)GetAdapter(__dsl_pAdapter);
        }
    }

    /// <inheritdoc cref = "IdxgiDevice.GetGPUThreadPriority"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetGPUThreadPriority(int* pPriority) => LpVtbl->GetGPUThreadPriority(pPriority);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGPUThreadPriority(Ref<int> pPriority)
    {
        fixed (int* __dsl_pPriority = pPriority)
        {
            return (HResult)GetGPUThreadPriority(__dsl_pPriority);
        }
    }

    /// <inheritdoc cref = "IdxgiDevice1.GetMaximumFrameLatency"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult GetMaximumFrameLatency(uint* pMaxLatency) =>
        LpVtbl->GetMaximumFrameLatency(pMaxLatency);

    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMaximumFrameLatency(Ref<uint> pMaxLatency)
    {
        fixed (uint* __dsl_pMaxLatency = pMaxLatency)
        {
            return (HResult)GetMaximumFrameLatency(__dsl_pMaxLatency);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.GetParent"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent) =>
        LpVtbl->GetParent(riid, ppParent);

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent)
    {
        fixed (void** __dsl_ppParent = ppParent)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetParent(__dsl_riid, __dsl_ppParent);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    public HResult GetParent<TCom>(out TCom ppParent)
        where TCom : unmanaged, IComVtbl
    {
        ppParent = default;
        return GetParent(TCom.NativeGuid, ppParent.GetAddressOf());
    }

    /// <inheritdoc cref = "IdxgiObject.GetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint* pDataSize,
        void* pData
    ) => LpVtbl->GetPrivateData(Name, pDataSize, pData);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        Ref<uint> pDataSize,
        Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (uint* __dsl_pDataSize = pDataSize)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)GetPrivateData(__dsl_Name, __dsl_pDataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IdxgiDevice2.OfferResources"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult OfferResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IdxgiResource* ppResources,
        DxgiOfferResourcePriority Priority
    ) => LpVtbl->OfferResources(NumResources, ppResources, Priority);

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult OfferResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] Ref<IdxgiResource> ppResources,
        DxgiOfferResourcePriority Priority
    )
    {
        fixed (IdxgiResource* __dsl_ppResources = ppResources)
        {
            return (HResult)OfferResources(NumResources, __dsl_ppResources, Priority);
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

    /// <inheritdoc cref = "IdxgiDevice.QueryResourceResidency"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult QueryResourceResidency(
        [NativeTypeName("IUnknown *const *")] IUnknown* ppResources,
        DxgiResidency* pResidencyStatus,
        uint NumResources
    ) => LpVtbl->QueryResourceResidency(ppResources, pResidencyStatus, NumResources);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryResourceResidency(
        [NativeTypeName("IUnknown *const *")] Ref<IUnknown> ppResources,
        Ref<DxgiResidency> pResidencyStatus,
        uint NumResources
    )
    {
        fixed (DxgiResidency* __dsl_pResidencyStatus = pResidencyStatus)
        fixed (IUnknown* __dsl_ppResources = ppResources)
        {
            return (HResult)QueryResourceResidency(
                __dsl_ppResources,
                __dsl_pResidencyStatus,
                NumResources
            );
        }
    }

    /// <inheritdoc cref = "IdxgiDevice2.ReclaimResources"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult ReclaimResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] IdxgiResource* ppResources,
        [NativeTypeName("BOOL *")] MaybeBool<int>* pDiscarded
    ) => LpVtbl->ReclaimResources(NumResources, ppResources, pDiscarded);

    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ReclaimResources(
        uint NumResources,
        [NativeTypeName("IDXGIResource *const *")] Ref<IdxgiResource> ppResources,
        [NativeTypeName("BOOL *")] Ref<MaybeBool<int>> pDiscarded
    )
    {
        fixed (MaybeBool<int>* __dsl_pDiscarded = pDiscarded)
        fixed (IdxgiResource* __dsl_ppResources = ppResources)
        {
            return (HResult)ReclaimResources(NumResources, __dsl_ppResources, __dsl_pDiscarded);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();

    /// <inheritdoc cref = "IdxgiDevice.SetGPUThreadPriority"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult SetGPUThreadPriority(int Priority) => LpVtbl->SetGPUThreadPriority(Priority);

    /// <inheritdoc cref = "IdxgiDevice1.SetMaximumFrameLatency"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult SetMaximumFrameLatency(uint MaxLatency) =>
        LpVtbl->SetMaximumFrameLatency(MaxLatency);

    /// <inheritdoc cref = "IdxgiObject.SetPrivateData"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Guid* Name,
        uint DataSize,
        [NativeTypeName("const void *")] void* pData
    ) => LpVtbl->SetPrivateData(Name, DataSize, pData);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        uint DataSize,
        [NativeTypeName("const void *")] Ref pData
    )
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateData(__dsl_Name, DataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IdxgiObject.SetPrivateDataInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Guid* Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    ) => LpVtbl->SetPrivateDataInterface(Name, pUnknown);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface(
        [NativeTypeName("const GUID &")] Ref<Guid> Name,
        [NativeTypeName("const IUnknown *")] IUnknown pUnknown
    )
    {
        fixed (Guid* __dsl_Name = Name)
        {
            return (HResult)SetPrivateDataInterface(__dsl_Name, pUnknown);
        }
    }

    /// <include file='IDXGIDevice3.xml' path='doc/member[@name="IDXGIDevice3.Trim"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void Trim() => LpVtbl->Trim();
}
