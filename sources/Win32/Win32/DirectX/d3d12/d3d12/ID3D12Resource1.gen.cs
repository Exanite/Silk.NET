// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Resource1.xml' path='doc/member[@name="ID3D12Resource1"]/*'/>
[Guid("9D5E227A-4430-4161-88B3-3ECA6BB16E19")]
[NativeTypeName("struct ID3D12Resource1 : ID3D12Resource")]
[NativeInheritance("ID3D12Resource")]
public unsafe partial struct ID3D12Resource1 : ID3D12Resource1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Resource1));

    public interface Interface : ID3D12Resource.Interface
    {
        [VtblIndex(15)]
        HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession);
        [VtblIndex(15)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession);
    }

    /// <include file='ID3D12Resource1.xml' path='doc/member[@name="ID3D12Resource1"]/*'/>
    [Guid("9D5E227A-4430-4161-88B3-3ECA6BB16E19")]
    [NativeTypeName("struct ID3D12Resource1 : ID3D12Resource")]
    [NativeInheritance("ID3D12Resource")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Resource1));

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
            [NativeTypeName("HRESULT (UINT, const D3D12_RANGE *, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12Range*, void**, HResult> Map;
            [NativeTypeName("void (UINT, const D3D12_RANGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12Range*, void> Unmap;
            [NativeTypeName("D3D12_RESOURCE_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ResourceDesc*, D3D12ResourceDesc*> GetDesc;
            [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong> GetGPUVirtualAddress;
            [NativeTypeName("HRESULT (UINT, const D3D12_BOX *, const void *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12Box*, void*, uint, uint, HResult> WriteToSubresource;
            [NativeTypeName("HRESULT (void *, UINT, UINT, UINT, const D3D12_BOX *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, uint, uint, uint, D3D12Box*, HResult> ReadFromSubresource;
            [NativeTypeName("HRESULT (D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapProperties*, D3D12HeapFlags*, HResult> GetHeapProperties;
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> GetProtectedResourceSession;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, uint> )(lpVtbl[1]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Resource.GetDesc"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public D3D12ResourceDesc GetDesc()
        {
            D3D12ResourceDesc result;
            return *((delegate* unmanaged<ID3D12Resource1.Native*, D3D12ResourceDesc*, D3D12ResourceDesc*> )(lpVtbl[10]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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

        /// <inheritdoc cref = "ID3D12Resource.GetGPUVirtualAddress"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong GetGPUVirtualAddress()
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, ulong> )(lpVtbl[11]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Resource.GetHeapProperties"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult GetHeapProperties(D3D12HeapProperties* pHeapProperties, D3D12HeapFlags* pHeapFlags)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, D3D12HeapProperties*, D3D12HeapFlags*, HResult> )(lpVtbl[14]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), pHeapProperties, pHeapFlags);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetHeapProperties(Ref<D3D12HeapProperties> pHeapProperties, Ref<D3D12HeapFlags> pHeapFlags)
        {
            fixed (D3D12HeapFlags* __dsl_pHeapFlags = pHeapFlags)
            fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
            {
                return (HResult)GetHeapProperties(__dsl_pHeapProperties, __dsl_pHeapFlags);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <include file='ID3D12Resource1.xml' path='doc/member[@name="ID3D12Resource1.GetProtectedResourceSession"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, void**, HResult> )(lpVtbl[15]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), riid, ppProtectedSession);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession)
        {
            fixed (void** __dsl_ppProtectedSession = ppProtectedSession)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetProtectedResourceSession(__dsl_riid, __dsl_ppProtectedSession);
            }
        }

        [VtblIndex(15)]
        [Transformed]
        public HResult GetProtectedResourceSession<TCom>(out TCom ppProtectedSession)
            where TCom : unmanaged, IComVtbl
        {
            ppProtectedSession = default;
            return GetProtectedResourceSession(TCom.NativeGuid, ppProtectedSession.GetAddressOf());
        }

        /// <inheritdoc cref = "ID3D12Resource.Map"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult Map(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pReadRange, void** ppData)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, uint, D3D12Range*, void**, HResult> )(lpVtbl[8]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), Subresource, pReadRange, ppData);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Map(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pReadRange, Ref2D ppData)
        {
            fixed (void** __dsl_ppData = ppData)
            fixed (D3D12Range* __dsl_pReadRange = pReadRange)
            {
                return (HResult)Map(Subresource, __dsl_pReadRange, __dsl_ppData);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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

        /// <inheritdoc cref = "ID3D12Resource.ReadFromSubresource"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pSrcBox)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, void*, uint, uint, uint, D3D12Box*, HResult> )(lpVtbl[13]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ReadFromSubresource(Ref pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pSrcBox)
        {
            fixed (D3D12Box* __dsl_pSrcBox = pSrcBox)
            fixed (void* __dsl_pDstData = pDstData)
            {
                return (HResult)ReadFromSubresource(__dsl_pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, __dsl_pSrcBox);
            }
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, uint> )(lpVtbl[2]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12Resource1.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <inheritdoc cref = "ID3D12Resource.Unmap"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void Unmap(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pWrittenRange)
        {
            ((delegate* unmanaged<ID3D12Resource1.Native*, uint, D3D12Range*, void> )(lpVtbl[9]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), Subresource, pWrittenRange);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Unmap(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pWrittenRange)
        {
            fixed (D3D12Range* __dsl_pWrittenRange = pWrittenRange)
            {
                Unmap(Subresource, __dsl_pWrittenRange);
            }
        }

        /// <inheritdoc cref = "ID3D12Resource.WriteToSubresource"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult WriteToSubresource(uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            return ((delegate* unmanaged<ID3D12Resource1.Native*, uint, D3D12Box*, void*, uint, uint, HResult> )(lpVtbl[12]))((ID3D12Resource1.Native*)Unsafe.AsPointer(ref this), DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult WriteToSubresource(uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pDstBox, [NativeTypeName("const void *")] Ref pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            fixed (void* __dsl_pSrcData = pSrcData)
            fixed (D3D12Box* __dsl_pDstBox = pDstBox)
            {
                return (HResult)WriteToSubresource(DstSubresource, __dsl_pDstBox, __dsl_pSrcData, SrcRowPitch, SrcDepthPitch);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Resource1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Resource1(Ptr3D vtbl) => LpVtbl = (ID3D12Resource1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Resource1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Resource1(Ptr<ID3D12Resource1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Resource1.Native"/> to <see cref = "ID3D12Resource1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Resource1(ID3D12Resource1.Native* value) => new ID3D12Resource1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Resource1"/> to <see cref = "ID3D12Resource1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1"/> instance to be converted </param>
    public static implicit operator ID3D12Resource1.Native*(ID3D12Resource1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Resource1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Resource1(Ptr3D value) => new ID3D12Resource1(value);
    /// <summary>casts <see cref = "ID3D12Resource1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Resource1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Resource1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Resource1(Ptr<ID3D12Resource1.Native> value) => new ID3D12Resource1(value);
    /// <summary>casts <see cref = "ID3D12Resource1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Resource1.Native>(ID3D12Resource1 value) => (Ptr<ID3D12Resource1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Resource1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Resource1(void*** value) => new ID3D12Resource1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Resource1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Resource1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Resource1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Resource1(nuint value) => new ID3D12Resource1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Resource1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Resource1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Resource1 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "ID3D12Resource.GetDesc"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12ResourceDesc GetDesc() => LpVtbl->GetDesc();
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

    /// <inheritdoc cref = "ID3D12Resource.GetGPUVirtualAddress"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong GetGPUVirtualAddress() => LpVtbl->GetGPUVirtualAddress();
    /// <inheritdoc cref = "ID3D12Resource.GetHeapProperties"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult GetHeapProperties(D3D12HeapProperties* pHeapProperties, D3D12HeapFlags* pHeapFlags) => LpVtbl->GetHeapProperties(pHeapProperties, pHeapFlags);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetHeapProperties(Ref<D3D12HeapProperties> pHeapProperties, Ref<D3D12HeapFlags> pHeapFlags)
    {
        fixed (D3D12HeapFlags* __dsl_pHeapFlags = pHeapFlags)
        fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
        {
            return (HResult)GetHeapProperties(__dsl_pHeapProperties, __dsl_pHeapFlags);
        }
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

    /// <include file='ID3D12Resource1.xml' path='doc/member[@name="ID3D12Resource1.GetProtectedResourceSession"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Guid* riid, void** ppProtectedSession) => LpVtbl->GetProtectedResourceSession(riid, ppProtectedSession);
    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetProtectedResourceSession([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppProtectedSession)
    {
        fixed (void** __dsl_ppProtectedSession = ppProtectedSession)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetProtectedResourceSession(__dsl_riid, __dsl_ppProtectedSession);
        }
    }

    [VtblIndex(15)]
    [Transformed]
    public HResult GetProtectedResourceSession<TCom>(out TCom ppProtectedSession)
        where TCom : unmanaged, IComVtbl
    {
        ppProtectedSession = default;
        return GetProtectedResourceSession(TCom.NativeGuid, ppProtectedSession.GetAddressOf());
    }

    /// <inheritdoc cref = "ID3D12Resource.Map"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult Map(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pReadRange, void** ppData) => LpVtbl->Map(Subresource, pReadRange, ppData);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Map(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pReadRange, Ref2D ppData)
    {
        fixed (void** __dsl_ppData = ppData)
        fixed (D3D12Range* __dsl_pReadRange = pReadRange)
        {
            return (HResult)Map(Subresource, __dsl_pReadRange, __dsl_ppData);
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

    /// <inheritdoc cref = "ID3D12Resource.ReadFromSubresource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult ReadFromSubresource(void* pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pSrcBox) => LpVtbl->ReadFromSubresource(pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, pSrcBox);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ReadFromSubresource(Ref pDstData, uint DstRowPitch, uint DstDepthPitch, uint SrcSubresource, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pSrcBox)
    {
        fixed (D3D12Box* __dsl_pSrcBox = pSrcBox)
        fixed (void* __dsl_pDstData = pDstData)
        {
            return (HResult)ReadFromSubresource(__dsl_pDstData, DstRowPitch, DstDepthPitch, SrcSubresource, __dsl_pSrcBox);
        }
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
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

    /// <inheritdoc cref = "ID3D12Resource.Unmap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Unmap(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] D3D12Range* pWrittenRange) => LpVtbl->Unmap(Subresource, pWrittenRange);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Unmap(uint Subresource, [NativeTypeName("const D3D12_RANGE *")] Ref<D3D12Range> pWrittenRange)
    {
        fixed (D3D12Range* __dsl_pWrittenRange = pWrittenRange)
        {
            Unmap(Subresource, __dsl_pWrittenRange);
        }
    }

    /// <inheritdoc cref = "ID3D12Resource.WriteToSubresource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult WriteToSubresource(uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pDstBox, [NativeTypeName("const void *")] void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch) => LpVtbl->WriteToSubresource(DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult WriteToSubresource(uint DstSubresource, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pDstBox, [NativeTypeName("const void *")] Ref pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
    {
        fixed (void* __dsl_pSrcData = pSrcData)
        fixed (D3D12Box* __dsl_pDstBox = pDstBox)
        {
            return (HResult)WriteToSubresource(DstSubresource, __dsl_pDstBox, __dsl_pSrcData, SrcRowPitch, SrcDepthPitch);
        }
    }
}