// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject"]/*'/>
[Guid("AEC22FB8-76F3-4639-9BE0-28EB43A67A2E")]
[NativeTypeName("struct IDXGIObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IdxgiObject : IdxgiObject.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiObject));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(6)]
        HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent);

        [VtblIndex(6)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetParent([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppParent);

        [VtblIndex(5)]
        HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint* pDataSize,
            void* pData
        );

        [VtblIndex(5)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            Ref<uint> pDataSize,
            Ref pData
        );

        [VtblIndex(3)]
        HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint DataSize,
            [NativeTypeName("const void *")] void* pData
        );

        [VtblIndex(3)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            uint DataSize,
            [NativeTypeName("const void *")] Ref pData
        );

        [VtblIndex(4)]
        HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Guid* Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        );

        [VtblIndex(4)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Ref<Guid> Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        );
    }

    /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject"]/*'/>

    [Guid("AEC22FB8-76F3-4639-9BE0-28EB43A67A2E")]
    [NativeTypeName("struct IDXGIObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiObject));
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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiObject.Native*, uint>)(lpVtbl[1]))(
                (IdxgiObject.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.GetParent"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IdxgiObject.Native*, Guid*, void**, HResult>)(lpVtbl[6]))(
                (IdxgiObject.Native*)Unsafe.AsPointer(ref this),
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

        /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.GetPrivateData"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint* pDataSize,
            void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiObject.Native*, Guid*, uint*, void*, HResult>)(lpVtbl[5])
            )((IdxgiObject.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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
            return ((delegate* unmanaged<IdxgiObject.Native*, Guid*, void**, HResult>)(lpVtbl[0]))(
                (IdxgiObject.Native*)Unsafe.AsPointer(ref this),
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

        /// <inheritdoc cref = "IUnknown.Release"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IdxgiObject.Native*, uint>)(lpVtbl[2]))(
                (IdxgiObject.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.SetPrivateData"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult SetPrivateData(
            [NativeTypeName("const GUID &")] Guid* Name,
            uint DataSize,
            [NativeTypeName("const void *")] void* pData
        )
        {
            return (
                (delegate* unmanaged<IdxgiObject.Native*, Guid*, uint, void*, HResult>)(lpVtbl[3])
            )((IdxgiObject.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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

        /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.SetPrivateDataInterface"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateDataInterface(
            [NativeTypeName("const GUID &")] Guid* Name,
            [NativeTypeName("const IUnknown *")] IUnknown pUnknown
        )
        {
            return (
                (delegate* unmanaged<IdxgiObject.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiObject.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "IdxgiObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiObject(Ptr3D vtbl) => LpVtbl = (IdxgiObject.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiObject(Ptr<IdxgiObject.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiObject.Native"/> to <see cref = "IdxgiObject"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiObject.Native"/> instance to be converted </param>

    public static implicit operator IdxgiObject(IdxgiObject.Native* value) =>
        new IdxgiObject((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiObject"/> to <see cref = "IdxgiObject.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiObject"/> instance to be converted </param>

    public static implicit operator IdxgiObject.Native*(IdxgiObject value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiObject"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiObject(Ptr3D value) => new IdxgiObject(value);

    /// <summary>casts <see cref = "IdxgiObject"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiObject"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiObject value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiObject"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiObject(Ptr<IdxgiObject.Native> value) =>
        new IdxgiObject(value);

    /// <summary>casts <see cref = "IdxgiObject"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiObject"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiObject.Native>(IdxgiObject value) =>
        (Ptr<IdxgiObject.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiObject"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiObject(void*** value) =>
        new IdxgiObject((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiObject"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiObject"/> instance to be converted </param>

    public static implicit operator void***(IdxgiObject value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiObject"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiObject(nuint value) =>
        new IdxgiObject((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiObject"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiObject"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiObject value) => (nuint)value.LpVtbl;

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.GetParent"]/*'/>

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

    /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.GetPrivateData"]/*'/>

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

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();

    /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.SetPrivateData"]/*'/>

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

    /// <include file='IDXGIObject.xml' path='doc/member[@name="IDXGIObject.SetPrivateDataInterface"]/*'/>

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
