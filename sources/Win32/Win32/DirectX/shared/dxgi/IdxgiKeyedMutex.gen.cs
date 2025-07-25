// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex"]/*'/>
[Guid("9D8E1289-D7B3-465F-8126-250E349AF85D")]
[NativeTypeName("struct IDXGIKeyedMutex : IDXGIDeviceSubObject")]
[NativeInheritance("IDXGIDeviceSubObject")]
public unsafe partial struct IdxgiKeyedMutex : IdxgiKeyedMutex.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiKeyedMutex));

    public interface Interface : IdxgiDeviceSubObject.Interface
    {
        [VtblIndex(8)]
        HResult AcquireSync(
            [NativeTypeName("UINT64")] ulong Key,
            [NativeTypeName("DWORD")] uint dwMilliseconds
        );

        [VtblIndex(9)]
        HResult ReleaseSync([NativeTypeName("UINT64")] ulong Key);
    }

    /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex"]/*'/>

    [Guid("9D8E1289-D7B3-465F-8126-250E349AF85D")]
    [NativeTypeName("struct IDXGIKeyedMutex : IDXGIDeviceSubObject")]
    [NativeInheritance("IDXGIDeviceSubObject")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IdxgiKeyedMutex));
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

            [NativeTypeName("HRESULT (UINT64, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, uint, HResult> AcquireSync;

            [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, HResult> ReleaseSync;
        }

        /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.AcquireSync"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult AcquireSync(
            [NativeTypeName("UINT64")] ulong Key,
            [NativeTypeName("DWORD")] uint dwMilliseconds
        )
        {
            return (
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, ulong, uint, HResult>)(lpVtbl[8])
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), Key, dwMilliseconds);
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IdxgiKeyedMutex.Native*, uint>)(lpVtbl[1]))(
                (IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <inheritdoc cref = "IdxgiDeviceSubObject.GetDevice"/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return (
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, void**, HResult>)(lpVtbl[7])
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), riid, ppDevice);
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
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, void**, HResult>)(lpVtbl[6])
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), riid, ppParent);
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
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, uint*, void*, HResult>)(
                    lpVtbl[5]
                )
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
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
            return (
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, void**, HResult>)(lpVtbl[0])
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<IdxgiKeyedMutex.Native*, uint>)(lpVtbl[2]))(
                (IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this)
            );
        }

        /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.ReleaseSync"]/*'/>

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult ReleaseSync([NativeTypeName("UINT64")] ulong Key)
        {
            return ((delegate* unmanaged<IdxgiKeyedMutex.Native*, ulong, HResult>)(lpVtbl[9]))(
                (IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this),
                Key
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
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, uint, void*, HResult>)(
                    lpVtbl[3]
                )
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
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
                (delegate* unmanaged<IdxgiKeyedMutex.Native*, Guid*, IUnknown.Native*, HResult>)(
                    lpVtbl[4]
                )
            )((IdxgiKeyedMutex.Native*)Unsafe.AsPointer(ref this), Name, pUnknown.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "IdxgiKeyedMutex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiKeyedMutex(Ptr3D vtbl) => LpVtbl = (IdxgiKeyedMutex.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IdxgiKeyedMutex"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IdxgiKeyedMutex(Ptr<IdxgiKeyedMutex.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IdxgiKeyedMutex.Native"/> to <see cref = "IdxgiKeyedMutex"/>.</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex.Native"/> instance to be converted </param>

    public static implicit operator IdxgiKeyedMutex(IdxgiKeyedMutex.Native* value) =>
        new IdxgiKeyedMutex((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiKeyedMutex"/> to <see cref = "IdxgiKeyedMutex.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex"/> instance to be converted </param>

    public static implicit operator IdxgiKeyedMutex.Native*(IdxgiKeyedMutex value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IdxgiKeyedMutex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IdxgiKeyedMutex(Ptr3D value) => new IdxgiKeyedMutex(value);

    /// <summary>casts <see cref = "IdxgiKeyedMutex"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex"/> instance to be converted </param>

    public static implicit operator Ptr3D(IdxgiKeyedMutex value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IdxgiKeyedMutex"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IdxgiKeyedMutex(Ptr<IdxgiKeyedMutex.Native> value) =>
        new IdxgiKeyedMutex(value);

    /// <summary>casts <see cref = "IdxgiKeyedMutex"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex"/> instance to be converted </param>

    public static implicit operator Ptr<IdxgiKeyedMutex.Native>(IdxgiKeyedMutex value) =>
        (Ptr<IdxgiKeyedMutex.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IdxgiKeyedMutex"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IdxgiKeyedMutex(void*** value) =>
        new IdxgiKeyedMutex((Ptr<Native>)value);

    /// <summary>casts <see cref = "IdxgiKeyedMutex"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex"/> instance to be converted </param>

    public static implicit operator void***(IdxgiKeyedMutex value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IdxgiKeyedMutex"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IdxgiKeyedMutex(nuint value) =>
        new IdxgiKeyedMutex((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IdxgiKeyedMutex"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IdxgiKeyedMutex"/> instance to be converted </param>

    public static implicit operator nuint(IdxgiKeyedMutex value) => (nuint)value.LpVtbl;

    /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.AcquireSync"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult AcquireSync(
        [NativeTypeName("UINT64")] ulong Key,
        [NativeTypeName("DWORD")] uint dwMilliseconds
    ) => LpVtbl->AcquireSync(Key, dwMilliseconds);

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

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

    /// <include file='IDXGIKeyedMutex.xml' path='doc/member[@name="IDXGIKeyedMutex.ReleaseSync"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult ReleaseSync([NativeTypeName("UINT64")] ulong Key) => LpVtbl->ReleaseSync(Key);

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
