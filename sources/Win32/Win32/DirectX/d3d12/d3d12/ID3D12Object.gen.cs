// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object"]/*'/>
[Guid("C4FEC28F-7966-4E95-9F94-F431CB56C3B8")]
[NativeTypeName("struct ID3D12Object : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12Object : ID3D12Object.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Object));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, Ref<uint> pDataSize, Ref pData);
        [VtblIndex(6)]
        HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetName([NativeTypeName("LPCWSTR")] Ref<ushort> Name);
        [VtblIndex(4)]
        HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetPrivateData([NativeTypeName("const GUID &")] Ref<Guid> guid, uint DataSize, [NativeTypeName("const void *")] Ref pData);
        [VtblIndex(5)]
        HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Ref<Guid> guid, [NativeTypeName("const IUnknown *")] IUnknown pData);
    }

    /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object"]/*'/>
    [Guid("C4FEC28F-7966-4E95-9F94-F431CB56C3B8")]
    [NativeTypeName("struct ID3D12Object : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Object));

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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Object.Native*, uint> )(lpVtbl[1]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.GetPrivateData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Object.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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
            return ((delegate* unmanaged<ID3D12Object.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12Object.Native*, uint> )(lpVtbl[2]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Object.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this), Name);
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

        /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetPrivateData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12Object.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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

        /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetPrivateDataInterface"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown pData)
        {
            return ((delegate* unmanaged<ID3D12Object.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12Object.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Object"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Object(Ptr3D vtbl) => LpVtbl = (ID3D12Object.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Object"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Object(Ptr<ID3D12Object.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Object.Native"/> to <see cref = "ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Object.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Object(ID3D12Object.Native* value) => new ID3D12Object((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Object"/> to <see cref = "ID3D12Object.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Object"/> instance to be converted </param>
    public static implicit operator ID3D12Object.Native*(ID3D12Object value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Object(Ptr3D value) => new ID3D12Object(value);
    /// <summary>casts <see cref = "ID3D12Object"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Object"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Object value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Object(Ptr<ID3D12Object.Native> value) => new ID3D12Object(value);
    /// <summary>casts <see cref = "ID3D12Object"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Object"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Object.Native>(ID3D12Object value) => (Ptr<ID3D12Object.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Object"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Object(void*** value) => new ID3D12Object((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Object"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Object"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Object value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Object"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Object(nuint value) => new ID3D12Object((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Object"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Object"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Object value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.GetPrivateData"]/*'/>
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
    /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetName"]/*'/>
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

    /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetPrivateData"]/*'/>
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

    /// <include file='ID3D12Object.xml' path='doc/member[@name="ID3D12Object.SetPrivateDataInterface"]/*'/>
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
}