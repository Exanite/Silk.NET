// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession"]/*'/>
[Guid("28E2495D-0F64-4AE4-A6EC-129255DC49A8")]
[NativeTypeName("struct ID3D12ShaderCacheSession : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12ShaderCacheSession : ID3D12ShaderCacheSession.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderCacheSession));

    public interface Interface : ID3D12DeviceChild.Interface
    {
        [VtblIndex(8)]
        HResult FindValue([NativeTypeName("const void *")] void* pKey, uint KeySize, void* pValue, uint* pValueSize);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult FindValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, Ref pValue, Ref<uint> pValueSize);
        [VtblIndex(11)]
        D3D12ShaderCacheSessionDesc GetDesc();
        [VtblIndex(10)]
        void SetDeleteOnDestroy();
        [VtblIndex(9)]
        HResult StoreValue([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("const void *")] void* pValue, uint ValueSize);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult StoreValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, [NativeTypeName("const void *")] Ref pValue, uint ValueSize);
    }

    /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession"]/*'/>
    [Guid("28E2495D-0F64-4AE4-A6EC-129255DC49A8")]
    [NativeTypeName("struct ID3D12ShaderCacheSession : ID3D12DeviceChild")]
    [NativeInheritance("ID3D12DeviceChild")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12ShaderCacheSession));

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
            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint*, void*, HResult> GetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, uint, void*, HResult> SetPrivateData;
            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, IUnknown.Native*, HResult> SetPrivateDataInterface;
            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, HResult> SetName;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetDevice;
            [NativeTypeName("HRESULT (const void *, UINT, void *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, void*, uint*, HResult> FindValue;
            [NativeTypeName("HRESULT (const void *, UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, void*, uint, HResult> StoreValue;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> SetDeleteOnDestroy;
            [NativeTypeName("D3D12_SHADER_CACHE_SESSION_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ShaderCacheSessionDesc*, D3D12ShaderCacheSessionDesc*> GetDesc;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, uint> )(lpVtbl[1]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.FindValue"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult FindValue([NativeTypeName("const void *")] void* pKey, uint KeySize, void* pValue, uint* pValueSize)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, void*, uint, void*, uint*, HResult> )(lpVtbl[8]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, pValueSize);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult FindValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, Ref pValue, Ref<uint> pValueSize)
        {
            fixed (uint* __dsl_pValueSize = pValueSize)
            fixed (void* __dsl_pValue = pValue)
            fixed (void* __dsl_pKey = pKey)
            {
                return (HResult)FindValue(__dsl_pKey, KeySize, __dsl_pValue, __dsl_pValueSize);
            }
        }

        /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public D3D12ShaderCacheSessionDesc GetDesc()
        {
            D3D12ShaderCacheSessionDesc result;
            return *((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, D3D12ShaderCacheSessionDesc*, D3D12ShaderCacheSessionDesc*> )(lpVtbl[11]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
        {
            fixed (void** __dsl_ppvDevice = ppvDevice)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetDevice(__dsl_riid, __dsl_ppvDevice);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        public HResult GetDevice<TCom>(out TCom ppvDevice)
            where TCom : unmanaged, IComVtbl
        {
            ppvDevice = default;
            return GetDevice(TCom.NativeGuid, ppvDevice.GetAddressOf());
        }

        /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> pDataSize, Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            fixed (uint* __dsl_pDataSize = pDataSize)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)GetPrivateData(__dsl_guid, __dsl_pDataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

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
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, uint> )(lpVtbl[2]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.SetDeleteOnDestroy"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void SetDeleteOnDestroy()
        {
            ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, void> )(lpVtbl[10]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), Name);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetName([NativeTypeName("LPCWSTR")] Ref<ushort> Name)
        {
            fixed (ushort* __dsl_Name = Name)
            {
                return (HResult)SetName(__dsl_Name);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint DataSize, [NativeTypeName("const void *")] Ref pData)
        {
            fixed (void* __dsl_pData = pData)
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateData(__dsl_guid, DataSize, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
        {
            fixed (Guid* __dsl_guid = guid)
            {
                return (HResult)SetPrivateDataInterface(__dsl_guid, pData);
            }
        }

        /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.StoreValue"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult StoreValue([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("const void *")] void* pValue, uint ValueSize)
        {
            return ((delegate* unmanaged<ID3D12ShaderCacheSession.Native*, void*, uint, void*, uint, HResult> )(lpVtbl[9]))((ID3D12ShaderCacheSession.Native*)Unsafe.AsPointer(ref this), pKey, KeySize, pValue, ValueSize);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult StoreValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, [NativeTypeName("const void *")] Ref pValue, uint ValueSize)
        {
            fixed (void* __dsl_pValue = pValue)
            fixed (void* __dsl_pKey = pKey)
            {
                return (HResult)StoreValue(__dsl_pKey, KeySize, __dsl_pValue, ValueSize);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderCacheSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderCacheSession(Ptr3D vtbl) => LpVtbl = (ID3D12ShaderCacheSession.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12ShaderCacheSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12ShaderCacheSession(Ptr<ID3D12ShaderCacheSession.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession.Native"/> to <see cref = "ID3D12ShaderCacheSession"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession.Native"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderCacheSession(ID3D12ShaderCacheSession.Native* value) => new ID3D12ShaderCacheSession((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession"/> to <see cref = "ID3D12ShaderCacheSession.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession"/> instance to be converted </param>
    public static implicit operator ID3D12ShaderCacheSession.Native*(ID3D12ShaderCacheSession value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12ShaderCacheSession"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderCacheSession(Ptr3D value) => new ID3D12ShaderCacheSession(value);
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12ShaderCacheSession value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12ShaderCacheSession"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderCacheSession(Ptr<ID3D12ShaderCacheSession.Native> value) => new ID3D12ShaderCacheSession(value);
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12ShaderCacheSession.Native>(ID3D12ShaderCacheSession value) => (Ptr<ID3D12ShaderCacheSession.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12ShaderCacheSession"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12ShaderCacheSession(void*** value) => new ID3D12ShaderCacheSession((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession"/> instance to be converted </param>
    public static implicit operator void***(ID3D12ShaderCacheSession value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12ShaderCacheSession"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12ShaderCacheSession(nuint value) => new ID3D12ShaderCacheSession((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12ShaderCacheSession"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12ShaderCacheSession"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12ShaderCacheSession value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.FindValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult FindValue([NativeTypeName("const void *")] void* pKey, uint KeySize, void* pValue, uint* pValueSize) => LpVtbl->FindValue(pKey, KeySize, pValue, pValueSize);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult FindValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, Ref pValue, Ref<uint> pValueSize)
    {
        fixed (uint* __dsl_pValueSize = pValueSize)
        fixed (void* __dsl_pValue = pValue)
        fixed (void* __dsl_pKey = pKey)
        {
            return (HResult)FindValue(__dsl_pKey, KeySize, __dsl_pValue, __dsl_pValueSize);
        }
    }

    /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public D3D12ShaderCacheSessionDesc GetDesc() => LpVtbl->GetDesc();
    /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice) => LpVtbl->GetDevice(riid, ppvDevice);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDevice([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvDevice)
    {
        fixed (void** __dsl_ppvDevice = ppvDevice)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetDevice(__dsl_riid, __dsl_ppvDevice);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    public HResult GetDevice<TCom>(out TCom ppvDevice)
        where TCom : unmanaged, IComVtbl
    {
        ppvDevice = default;
        return GetDevice(TCom.NativeGuid, ppvDevice.GetAddressOf());
    }

    /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData) => LpVtbl->GetPrivateData(guid, pDataSize, pData);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> pDataSize, Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        fixed (uint* __dsl_pDataSize = pDataSize)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)GetPrivateData(__dsl_guid, __dsl_pDataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
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
    /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.SetDeleteOnDestroy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void SetDeleteOnDestroy() => LpVtbl->SetDeleteOnDestroy();
    /// <inheritdoc cref = "ID3D12Object.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name) => LpVtbl->SetName(Name);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetName([NativeTypeName("LPCWSTR")] Ref<ushort> Name)
    {
        fixed (ushort* __dsl_Name = Name)
        {
            return (HResult)SetName(__dsl_Name);
        }
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData) => LpVtbl->SetPrivateData(guid, DataSize, pData);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint DataSize, [NativeTypeName("const void *")] Ref pData)
    {
        fixed (void* __dsl_pData = pData)
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateData(__dsl_guid, DataSize, __dsl_pData);
        }
    }

    /// <inheritdoc cref = "ID3D12Object.SetPrivateDataInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData) => LpVtbl->SetPrivateDataInterface(guid, pData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
    {
        fixed (Guid* __dsl_guid = guid)
        {
            return (HResult)SetPrivateDataInterface(__dsl_guid, pData);
        }
    }

    /// <include file='ID3D12ShaderCacheSession.xml' path='doc/member[@name="ID3D12ShaderCacheSession.StoreValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult StoreValue([NativeTypeName("const void *")] void* pKey, uint KeySize, [NativeTypeName("const void *")] void* pValue, uint ValueSize) => LpVtbl->StoreValue(pKey, KeySize, pValue, ValueSize);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult StoreValue([NativeTypeName("const void *")] Ref pKey, uint KeySize, [NativeTypeName("const void *")] Ref pValue, uint ValueSize)
    {
        fixed (void* __dsl_pValue = pValue)
        fixed (void* __dsl_pKey = pKey)
        {
            return (HResult)StoreValue(__dsl_pKey, KeySize, __dsl_pValue, ValueSize);
        }
    }
}