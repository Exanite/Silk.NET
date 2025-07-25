// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics"]/*'/>
[Guid("597985AB-9B75-4DBB-BE23-0761195BEBEE")]
[NativeTypeName("struct ID3D12GBVDiagnostics : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12GBVDiagnostics : ID3D12GBVDiagnostics.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12GBVDiagnostics));

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(7)]
        void GBVReserved0();
        [VtblIndex(8)]
        void GBVReserved1();
        [VtblIndex(3)]
        HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, int* pData, uint DataSize);
        [VtblIndex(3)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, Ref<int> pData, uint DataSize);
        [VtblIndex(6)]
        HResult GetGBVResourceInfo(ID3D12Resource pResource, D3D12ResourceDesc* pResourceDesc, [NativeTypeName("UINT32 *")] uint* pResourceHash, [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset);
        [VtblIndex(6)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetGBVResourceInfo(ID3D12Resource pResource, Ref<D3D12ResourceDesc> pResourceDesc, [NativeTypeName("UINT32 *")] Ref<uint> pResourceHash, [NativeTypeName("UINT32 *")] Ref<uint> pSubresourceStatesByteOffset);
        [VtblIndex(5)]
        HResult GetGBVResourceUniformState(ID3D12Resource pResource, int* pData);
        [VtblIndex(5)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetGBVResourceUniformState(ID3D12Resource pResource, Ref<int> pData);
        [VtblIndex(4)]
        HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, int* pData);
        [VtblIndex(4)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, Ref<int> pData);
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics"]/*'/>
    [Guid("597985AB-9B75-4DBB-BE23-0761195BEBEE")]
    [NativeTypeName("struct ID3D12GBVDiagnostics : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12GBVDiagnostics));

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
            [NativeTypeName("HRESULT (ID3D12Resource *, int *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, int*, uint, HResult> GetGBVEntireSubresourceStatesData;
            [NativeTypeName("HRESULT (ID3D12Resource *, UINT, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, int*, HResult> GetGBVSubresourceState;
            [NativeTypeName("HRESULT (ID3D12Resource *, int *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, int*, HResult> GetGBVResourceUniformState;
            [NativeTypeName("HRESULT (ID3D12Resource *, D3D12_RESOURCE_DESC *, UINT32 *, UINT32 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12ResourceDesc*, uint*, uint*, HResult> GetGBVResourceInfo;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> GBVReserved0;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> GBVReserved1;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, uint> )(lpVtbl[1]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved0"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GBVReserved0()
        {
            ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, void> )(lpVtbl[7]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved1"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void GBVReserved1()
        {
            ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, void> )(lpVtbl[8]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVEntireSubresourceStatesData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, int* pData, uint DataSize)
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, ID3D12Resource.Native*, int*, uint, HResult> )(lpVtbl[3]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pData, DataSize);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, Ref<int> pData, uint DataSize)
        {
            fixed (int* __dsl_pData = pData)
            {
                return (HResult)GetGBVEntireSubresourceStatesData(pResource, __dsl_pData, DataSize);
            }
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceInfo"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult GetGBVResourceInfo(ID3D12Resource pResource, D3D12ResourceDesc* pResourceDesc, [NativeTypeName("UINT32 *")] uint* pResourceHash, [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset)
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, ID3D12Resource.Native*, D3D12ResourceDesc*, uint*, uint*, HResult> )(lpVtbl[6]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetGBVResourceInfo(ID3D12Resource pResource, Ref<D3D12ResourceDesc> pResourceDesc, [NativeTypeName("UINT32 *")] Ref<uint> pResourceHash, [NativeTypeName("UINT32 *")] Ref<uint> pSubresourceStatesByteOffset)
        {
            fixed (uint* __dsl_pSubresourceStatesByteOffset = pSubresourceStatesByteOffset)
            fixed (uint* __dsl_pResourceHash = pResourceHash)
            fixed (D3D12ResourceDesc* __dsl_pResourceDesc = pResourceDesc)
            {
                return (HResult)GetGBVResourceInfo(pResource, __dsl_pResourceDesc, __dsl_pResourceHash, __dsl_pSubresourceStatesByteOffset);
            }
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceUniformState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetGBVResourceUniformState(ID3D12Resource pResource, int* pData)
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, ID3D12Resource.Native*, int*, HResult> )(lpVtbl[5]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pData);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetGBVResourceUniformState(ID3D12Resource pResource, Ref<int> pData)
        {
            fixed (int* __dsl_pData = pData)
            {
                return (HResult)GetGBVResourceUniformState(pResource, __dsl_pData);
            }
        }

        /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVSubresourceState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, int* pData)
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, ID3D12Resource.Native*, uint, int*, HResult> )(lpVtbl[4]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, Subresource, pData);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, Ref<int> pData)
        {
            fixed (int* __dsl_pData = pData)
            {
                return (HResult)GetGBVSubresourceState(pResource, Subresource, __dsl_pData);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12GBVDiagnostics.Native*, uint> )(lpVtbl[2]))((ID3D12GBVDiagnostics.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12GBVDiagnostics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GBVDiagnostics(Ptr3D vtbl) => LpVtbl = (ID3D12GBVDiagnostics.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12GBVDiagnostics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GBVDiagnostics(Ptr<ID3D12GBVDiagnostics.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics.Native"/> to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics.Native"/> instance to be converted </param>
    public static implicit operator ID3D12GBVDiagnostics(ID3D12GBVDiagnostics.Native* value) => new ID3D12GBVDiagnostics((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics"/> to <see cref = "ID3D12GBVDiagnostics.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator ID3D12GBVDiagnostics.Native*(ID3D12GBVDiagnostics value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12GBVDiagnostics(Ptr3D value) => new ID3D12GBVDiagnostics(value);
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12GBVDiagnostics value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12GBVDiagnostics(Ptr<ID3D12GBVDiagnostics.Native> value) => new ID3D12GBVDiagnostics(value);
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12GBVDiagnostics.Native>(ID3D12GBVDiagnostics value) => (Ptr<ID3D12GBVDiagnostics.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12GBVDiagnostics(void*** value) => new ID3D12GBVDiagnostics((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator void***(ID3D12GBVDiagnostics value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12GBVDiagnostics"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12GBVDiagnostics(nuint value) => new ID3D12GBVDiagnostics((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12GBVDiagnostics"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GBVDiagnostics"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12GBVDiagnostics value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved0"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GBVReserved0() => LpVtbl->GBVReserved0();
    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GBVReserved1"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GBVReserved1() => LpVtbl->GBVReserved1();
    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVEntireSubresourceStatesData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, int* pData, uint DataSize) => LpVtbl->GetGBVEntireSubresourceStatesData(pResource, pData, DataSize);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, Ref<int> pData, uint DataSize)
    {
        fixed (int* __dsl_pData = pData)
        {
            return (HResult)GetGBVEntireSubresourceStatesData(pResource, __dsl_pData, DataSize);
        }
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult GetGBVResourceInfo(ID3D12Resource pResource, D3D12ResourceDesc* pResourceDesc, [NativeTypeName("UINT32 *")] uint* pResourceHash, [NativeTypeName("UINT32 *")] uint* pSubresourceStatesByteOffset) => LpVtbl->GetGBVResourceInfo(pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGBVResourceInfo(ID3D12Resource pResource, Ref<D3D12ResourceDesc> pResourceDesc, [NativeTypeName("UINT32 *")] Ref<uint> pResourceHash, [NativeTypeName("UINT32 *")] Ref<uint> pSubresourceStatesByteOffset)
    {
        fixed (uint* __dsl_pSubresourceStatesByteOffset = pSubresourceStatesByteOffset)
        fixed (uint* __dsl_pResourceHash = pResourceHash)
        fixed (D3D12ResourceDesc* __dsl_pResourceDesc = pResourceDesc)
        {
            return (HResult)GetGBVResourceInfo(pResource, __dsl_pResourceDesc, __dsl_pResourceHash, __dsl_pSubresourceStatesByteOffset);
        }
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVResourceUniformState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetGBVResourceUniformState(ID3D12Resource pResource, int* pData) => LpVtbl->GetGBVResourceUniformState(pResource, pData);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGBVResourceUniformState(ID3D12Resource pResource, Ref<int> pData)
    {
        fixed (int* __dsl_pData = pData)
        {
            return (HResult)GetGBVResourceUniformState(pResource, __dsl_pData);
        }
    }

    /// <include file='ID3D12GBVDiagnostics.xml' path='doc/member[@name="ID3D12GBVDiagnostics.GetGBVSubresourceState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, int* pData) => LpVtbl->GetGBVSubresourceState(pResource, Subresource, pData);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, Ref<int> pData)
    {
        fixed (int* __dsl_pData = pData)
        {
            return (HResult)GetGBVSubresourceState(pResource, Subresource, __dsl_pData);
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
}