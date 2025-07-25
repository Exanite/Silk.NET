// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice"]/*'/>
[Guid("54EC77FA-1377-44E6-8C32-88FD5F44C84C")]
[NativeTypeName("struct IDXGIDevice : IDXGIObject")]
[NativeInheritance("IDXGIObject")]
public unsafe partial struct IdxgiDevice : IdxgiDevice.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDevice));

    public interface Interface : IdxgiObject.Interface
    {
        [VtblIndex(8)]
        HResult CreateSurface(
            [NativeTypeName("const DXGI_SURFACE_DESC *")] DxgiSurfaceDesc* pDesc,
            uint NumSurfaces,
            [NativeTypeName("DXGI_USAGE")] uint Usage,
            [NativeTypeName("const DXGI_SHARED_RESOURCE *")] DxgiSharedResource* pSharedResource,
            IdxgiSurface* ppSurface
        );

        [VtblIndex(8)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult CreateSurface(
            [NativeTypeName("const DXGI_SURFACE_DESC *")] Ref<DxgiSurfaceDesc> pDesc,
            uint NumSurfaces,
            [NativeTypeName("DXGI_USAGE")] uint Usage,
            [NativeTypeName("const DXGI_SHARED_RESOURCE *")]
                Ref<DxgiSharedResource> pSharedResource,
            Ref<IdxgiSurface> ppSurface
        );

        [VtblIndex(7)]
        HResult GetAdapter(IdxgiAdapter* pAdapter);

        [VtblIndex(7)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetAdapter(Ref<IdxgiAdapter> pAdapter);

        [VtblIndex(11)]
        HResult GetGPUThreadPriority(int* pPriority);

        [VtblIndex(11)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetGPUThreadPriority(Ref<int> pPriority);

        [VtblIndex(9)]
        HResult QueryResourceResidency(
            [NativeTypeName("IUnknown *const *")] IUnknown* ppResources,
            DxgiResidency* pResidencyStatus,
            uint NumResources
        );

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult QueryResourceResidency(
            [NativeTypeName("IUnknown *const *")] Ref<IUnknown> ppResources,
            Ref<DxgiResidency> pResidencyStatus,
            uint NumResources
        );

        [VtblIndex(10)]
        HResult SetGPUThreadPriority(int Priority);
    }

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice"]/*'/>

    [Guid("54EC77FA-1377-44E6-8C32-88FD5F44C84C")]
    [NativeTypeName("struct IDXGIDevice : IDXGIObject")]
    [NativeInheritance("IDXGIObject")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiDevice));
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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, uint>)(lpVtbl[1]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.CreateSurface"]/*'/>

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
                    IdxgiDevice.Native*,
                    DxgiSurfaceDesc*,
                    uint,
                    uint,
                    DxgiSharedResource*,
                    IdxgiSurface.Native**,
                    HResult>)(lpVtbl[8])
            )(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
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

        /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.GetAdapter"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetAdapter(IdxgiAdapter* pAdapter)
        {
            return (
                (delegate* unmanaged<IdxgiDevice.Native*, IdxgiAdapter.Native**, HResult>)(
                    lpVtbl[7]
                )
            )((IdxgiDevice.Native*)Unsafe.AsPointer(ref this), &pAdapter->LpVtbl);
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

        /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.GetGPUThreadPriority"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetGPUThreadPriority(int* pPriority)
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, int*, HResult>)(lpVtbl[11]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
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
                (delegate* unmanaged<IdxgiDevice.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiDevice.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
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

        /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.QueryResourceResidency"]/*'/>

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
                    IdxgiDevice.Native*,
                    IUnknown.Native**,
                    DxgiResidency*,
                    uint,
                    HResult>)(lpVtbl[9])
            )(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, uint>)(lpVtbl[2]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.SetGPUThreadPriority"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult SetGPUThreadPriority(int Priority)
        {
            return ((delegate* unmanaged<IdxgiDevice.Native*, int, HResult>)(lpVtbl[10]))(
                (IdxgiDevice.Native*)Unsafe.AsPointer(ref this),
                Priority
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
                (delegate* unmanaged<IdxgiDevice.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiDevice.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiDevice.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiDevice.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDevice(Ptr3D vtbl) => LpVtbl = (IdxgiDevice.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiDevice(Ptr<IdxgiDevice.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiDevice.Native"/> to <see cref = "IdxgiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice.Native"/> instance to be converted </param>

    public static implicit operator IdxgiDevice(IdxgiDevice.Native* value) =>
        new IdxgiDevice((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDevice"/> to <see cref = "IdxgiDevice.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice"/> instance to be converted </param>

    public static implicit operator IdxgiDevice.Native*(IdxgiDevice value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiDevice(Ptr3D value) => new IdxgiDevice(value);

    /// <summary>casts <see cref = "IdxgiDevice"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiDevice value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiDevice(Ptr<IdxgiDevice.Native> value) =>
        new IdxgiDevice(value);

    /// <summary>casts <see cref = "IdxgiDevice"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiDevice.Native>(IdxgiDevice value) =>
        (Ptr<IdxgiDevice.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiDevice"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiDevice(void*** value) =>
        new IdxgiDevice((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiDevice"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice"/> instance to be converted </param>

    public static implicit operator void***(IdxgiDevice value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiDevice"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiDevice(nuint value) =>
        new IdxgiDevice((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiDevice"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiDevice"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiDevice value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.CreateSurface"]/*'/>

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

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.GetAdapter"]/*'/>

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

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.GetGPUThreadPriority"]/*'/>

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

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.QueryResourceResidency"]/*'/>

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

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();

    /// <include file='IDXGIDevice.xml' path='doc/member[@name="IDXGIDevice.SetGPUThreadPriority"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult SetGPUThreadPriority(int Priority) => LpVtbl->SetGPUThreadPriority(Priority);

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
}
