// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap"]/*'/>
[Guid("8EFB471D-616C-4F49-90F7-127BB763FA51")]
[NativeTypeName("struct ID3D12DescriptorHeap : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12DescriptorHeap : ID3D12DescriptorHeap.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DescriptorHeap));

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(9)]
        D3D12CpuDescriptorHandle GetCPUDescriptorHandleForHeapStart();
        [VtblIndex(8)]
        D3D12DescriptorHeapDesc GetDesc();
        [VtblIndex(10)]
        D3D12GpuDescriptorHandle GetGPUDescriptorHandleForHeapStart();
    }

    /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap"]/*'/>
    [Guid("8EFB471D-616C-4F49-90F7-127BB763FA51")]
    [NativeTypeName("struct ID3D12DescriptorHeap : ID3D12Pageable")]
    [NativeInheritance("ID3D12Pageable")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12DescriptorHeap));

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
            [NativeTypeName("D3D12_DESCRIPTOR_HEAP_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DescriptorHeapDesc*, D3D12DescriptorHeapDesc*> GetDesc;
            [NativeTypeName("D3D12_CPU_DESCRIPTOR_HANDLE () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CpuDescriptorHandle*, D3D12CpuDescriptorHandle*> GetCPUDescriptorHandleForHeapStart;
            [NativeTypeName("D3D12_GPU_DESCRIPTOR_HANDLE () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12GpuDescriptorHandle*, D3D12GpuDescriptorHandle*> GetGPUDescriptorHandleForHeapStart;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, uint> )(lpVtbl[1]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetCPUDescriptorHandleForHeapStart"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public D3D12CpuDescriptorHandle GetCPUDescriptorHandleForHeapStart()
        {
            D3D12CpuDescriptorHandle result;
            return *((delegate* unmanaged<ID3D12DescriptorHeap.Native*, D3D12CpuDescriptorHandle*, D3D12CpuDescriptorHandle*> )(lpVtbl[9]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public D3D12DescriptorHeapDesc GetDesc()
        {
            D3D12DescriptorHeapDesc result;
            return *((delegate* unmanaged<ID3D12DescriptorHeap.Native*, D3D12DescriptorHeapDesc*, D3D12DescriptorHeapDesc*> )(lpVtbl[8]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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

        /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetGPUDescriptorHandleForHeapStart"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public D3D12GpuDescriptorHandle GetGPUDescriptorHandleForHeapStart()
        {
            D3D12GpuDescriptorHandle result;
            return *((delegate* unmanaged<ID3D12DescriptorHeap.Native*, D3D12GpuDescriptorHandle*, D3D12GpuDescriptorHandle*> )(lpVtbl[10]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, uint> )(lpVtbl[2]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12DescriptorHeap.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12DescriptorHeap.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "ID3D12DescriptorHeap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DescriptorHeap(Ptr3D vtbl) => LpVtbl = (ID3D12DescriptorHeap.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12DescriptorHeap"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12DescriptorHeap(Ptr<ID3D12DescriptorHeap.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12DescriptorHeap.Native"/> to <see cref = "ID3D12DescriptorHeap"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap.Native"/> instance to be converted </param>
    public static implicit operator ID3D12DescriptorHeap(ID3D12DescriptorHeap.Native* value) => new ID3D12DescriptorHeap((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DescriptorHeap"/> to <see cref = "ID3D12DescriptorHeap.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap"/> instance to be converted </param>
    public static implicit operator ID3D12DescriptorHeap.Native*(ID3D12DescriptorHeap value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12DescriptorHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12DescriptorHeap(Ptr3D value) => new ID3D12DescriptorHeap(value);
    /// <summary>casts <see cref = "ID3D12DescriptorHeap"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12DescriptorHeap value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12DescriptorHeap"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12DescriptorHeap(Ptr<ID3D12DescriptorHeap.Native> value) => new ID3D12DescriptorHeap(value);
    /// <summary>casts <see cref = "ID3D12DescriptorHeap"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12DescriptorHeap.Native>(ID3D12DescriptorHeap value) => (Ptr<ID3D12DescriptorHeap.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12DescriptorHeap"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12DescriptorHeap(void*** value) => new ID3D12DescriptorHeap((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12DescriptorHeap"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap"/> instance to be converted </param>
    public static implicit operator void***(ID3D12DescriptorHeap value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12DescriptorHeap"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12DescriptorHeap(nuint value) => new ID3D12DescriptorHeap((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12DescriptorHeap"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12DescriptorHeap"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12DescriptorHeap value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetCPUDescriptorHandleForHeapStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public D3D12CpuDescriptorHandle GetCPUDescriptorHandleForHeapStart() => LpVtbl->GetCPUDescriptorHandleForHeapStart();
    /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public D3D12DescriptorHeapDesc GetDesc() => LpVtbl->GetDesc();
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

    /// <include file='ID3D12DescriptorHeap.xml' path='doc/member[@name="ID3D12DescriptorHeap.GetGPUDescriptorHandleForHeapStart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public D3D12GpuDescriptorHandle GetGPUDescriptorHandleForHeapStart() => LpVtbl->GetGPUDescriptorHandleForHeapStart();
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
}