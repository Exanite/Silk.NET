// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1"]/*'/>
[Guid("4AE63092-6327-4C1B-80AE-BFE12EA32B86")]
[NativeTypeName("struct IDXGISurface1 : IDXGISurface")]
[NativeInheritance("IDXGISurface")]
public unsafe partial struct IdxgiSurface1 : IdxgiSurface1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSurface1));

    public interface Interface : IdxgiSurface.Interface
    {
        [VtblIndex(11)]
        HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, HDC* phdc);

        [VtblIndex(11)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<HDC> phdc);

        [VtblIndex(12)]
        HResult ReleaseDC(RECT* pDirtyRect);

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult ReleaseDC(Ref<RECT> pDirtyRect);
    }

    /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1"]/*'/>

    [Guid("4AE63092-6327-4C1B-80AE-BFE12EA32B86")]
    [NativeTypeName("struct IDXGISurface1 : IDXGISurface")]
    [NativeInheritance("IDXGISurface")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiSurface1));
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

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetDevice;

            [NativeTypeName("HRESULT (DXGI_SURFACE_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiSurfaceDesc*, HResult> GetDesc;

            [NativeTypeName("HRESULT (DXGI_MAPPED_RECT *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, DxgiMappedRect*, uint, HResult> Map;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> Unmap;

            [NativeTypeName("HRESULT (BOOL, HDC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, HDC*, HResult> GetDC;

            [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, RECT*, HResult> ReleaseDC;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiSurface1.Native*, uint>)(lpVtbl[1]))(
                (IdxgiSurface1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.GetDC"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, HDC* phdc)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, MaybeBool<int>, HDC*, HResult>)(
                    lpVtbl[11]
                )
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), Discard, phdc);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<HDC> phdc)
        {
            fixed (HDC* __dsl_phdc = phdc)
            {
                return (HResult)GetDC(Discard, __dsl_phdc);
            }
        }

        /// <inheritdoc cref = "IdxgiSurface.GetDesc"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult GetDesc(DxgiSurfaceDesc* pDesc)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, DxgiSurfaceDesc*, HResult>)(lpVtbl[8])
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), pDesc);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDesc(Ref<DxgiSurfaceDesc> pDesc)
        {
            fixed (DxgiSurfaceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)GetDesc(__dsl_pDesc);
            }
        }

        /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, void**, HResult>)(lpVtbl[7])
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppDevice)
        {
            fixed (void** __dsl_ppDevice = ppDevice)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetDevice(__dsl_riid, __dsl_ppDevice);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetDevice<TCom>(out TCom ppDevice)
            where TCom : unmanaged, IComVtbl
        {
            ppDevice = default;
            return GetDevice(TCom.NativeGuid, ppDevice.GetAddressOf());
        }

        /// <inheritdoc cref = "IdxgiObject.GetParent"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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

        /// <inheritdoc cref = "IdxgiSurface.Map"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult Map(DxgiMappedRect* pLockedRect, uint MapFlags)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, DxgiMappedRect*, uint, HResult>)(
                    lpVtbl[9]
                )
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), pLockedRect, MapFlags);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult Map(Ref<DxgiMappedRect> pLockedRect, uint MapFlags)
        {
            fixed (DxgiMappedRect* __dsl_pLockedRect = pLockedRect)
            {
                return (HResult)Map(__dsl_pLockedRect, MapFlags);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return (
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiSurface1.Native*, uint>)(lpVtbl[2]))(
                (IdxgiSurface1.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.ReleaseDC"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult ReleaseDC(RECT* pDirtyRect)
        {
            return ((delegate* unmanaged<IdxgiSurface1.Native*, RECT*, HResult>)(lpVtbl[12]))(
                (IdxgiSurface1.Native*)Unsafe.AsPointer(ref this),
                pDirtyRect
            );
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult ReleaseDC(Ref<RECT> pDirtyRect)
        {
            fixed (RECT* __dsl_pDirtyRect = pDirtyRect)
            {
                return (HResult)ReleaseDC(__dsl_pDirtyRect);
            }
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
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiSurface1.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiSurface1.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

        /// <inheritdoc cref = "IdxgiSurface.Unmap"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult Unmap()
        {
            return ((delegate* unmanaged<IdxgiSurface1.Native*, HResult>)(lpVtbl[10]))(
                (IdxgiSurface1.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSurface1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSurface1(Ptr3D vtbl) => LpVtbl = (IdxgiSurface1.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiSurface1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiSurface1(Ptr<IdxgiSurface1.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiSurface1.Native"/> to <see cref = "IdxgiSurface1"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1.Native"/> instance to be converted </param>

    public static implicit operator IdxgiSurface1(IdxgiSurface1.Native* value) =>
        new IdxgiSurface1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSurface1"/> to <see cref = "IdxgiSurface1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1"/> instance to be converted </param>

    public static implicit operator IdxgiSurface1.Native*(IdxgiSurface1 value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiSurface1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiSurface1(Ptr3D value) => new IdxgiSurface1(value);

    /// <summary>casts <see cref = "IdxgiSurface1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiSurface1 value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiSurface1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiSurface1(Ptr<IdxgiSurface1.Native> value) =>
        new IdxgiSurface1(value);

    /// <summary>casts <see cref = "IdxgiSurface1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiSurface1.Native>(IdxgiSurface1 value) =>
        (Ptr<IdxgiSurface1.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiSurface1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiSurface1(void*** value) =>
        new IdxgiSurface1((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiSurface1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1"/> instance to be converted </param>

    public static implicit operator void***(IdxgiSurface1 value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiSurface1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiSurface1(nuint value) =>
        new IdxgiSurface1((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiSurface1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiSurface1"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiSurface1 value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.GetDC"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, HDC* phdc) =>
        LpVtbl->GetDC(Discard, phdc);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDC([NativeTypeName("BOOL")] MaybeBool<int> Discard, Ref<HDC> phdc)
    {
        fixed (HDC* __dsl_phdc = phdc)
        {
            return (HResult)GetDC(Discard, __dsl_phdc);
        }
    }

    /// <inheritdoc cref = "IdxgiSurface.GetDesc"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult GetDesc(DxgiSurfaceDesc* pDesc) => LpVtbl->GetDesc(pDesc);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDesc(Ref<DxgiSurfaceDesc> pDesc)
    {
        fixed (DxgiSurfaceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)GetDesc(__dsl_pDesc);
        }
    }

    /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice) =>
        LpVtbl->GetDevice(riid, ppDevice);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppDevice)
    {
        fixed (void** __dsl_ppDevice = ppDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetDevice(__dsl_riid, __dsl_ppDevice);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetDevice<TCom>(out TCom ppDevice)
        where TCom : unmanaged, IComVtbl
    {
        ppDevice = default;
        return GetDevice(TCom.NativeGuid, ppDevice.GetAddressOf());
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

    /// <inheritdoc cref = "IdxgiSurface.Map"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult Map(DxgiMappedRect* pLockedRect, uint MapFlags) =>
        LpVtbl->Map(pLockedRect, MapFlags);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Map(Ref<DxgiMappedRect> pLockedRect, uint MapFlags)
    {
        fixed (DxgiMappedRect* __dsl_pLockedRect = pLockedRect)
        {
            return (HResult)Map(__dsl_pLockedRect, MapFlags);
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

    /// <include file='IDXGISurface1.xml' path='doc/member[@name="IDXGISurface1.ReleaseDC"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult ReleaseDC(RECT* pDirtyRect) => LpVtbl->ReleaseDC(pDirtyRect);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ReleaseDC(Ref<RECT> pDirtyRect)
    {
        fixed (RECT* __dsl_pDirtyRect = pDirtyRect)
        {
            return (HResult)ReleaseDC(__dsl_pDirtyRect);
        }
    }

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

    /// <inheritdoc cref = "IdxgiSurface.Unmap"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult Unmap() => LpVtbl->Unmap();
}
