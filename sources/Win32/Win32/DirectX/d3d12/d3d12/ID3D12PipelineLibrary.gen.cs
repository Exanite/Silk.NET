// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary"]/*'/>
[Guid("C64226A8-9201-46AF-B4CC-53FB9FF7414F")]
[NativeTypeName("struct ID3D12PipelineLibrary : ID3D12DeviceChild")]
[NativeInheritance("ID3D12DeviceChild")]
public unsafe partial struct ID3D12PipelineLibrary : ID3D12PipelineLibrary.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12PipelineLibrary));

    public interface Interface : ID3D12DeviceChild.Interface
    {
        [VtblIndex(11)]
        [return: NativeTypeName("SIZE_T")]
        nuint GetSerializedSize();
        [VtblIndex(10)]
        HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
        [VtblIndex(10)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState);
        [VtblIndex(9)]
        HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState);
        [VtblIndex(12)]
        HResult Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Serialize(Ref pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes);
        [VtblIndex(8)]
        HResult StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState pPipeline);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult StorePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, ID3D12PipelineState pPipeline);
    }

    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary"]/*'/>
    [Guid("C64226A8-9201-46AF-B4CC-53FB9FF7414F")]
    [NativeTypeName("struct ID3D12PipelineLibrary : ID3D12DeviceChild")]
    [NativeInheritance("ID3D12DeviceChild")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12PipelineLibrary));

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
            [NativeTypeName("HRESULT (LPCWSTR, ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, ID3D12PipelineState.Native*, HResult> StorePipeline;
            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, D3D12GraphicsPipelineStateDesc*, Guid*, void**, HResult> LoadGraphicsPipeline;
            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, D3D12ComputePipelineStateDesc*, Guid*, void**, HResult> LoadComputePipeline;
            [NativeTypeName("SIZE_T () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, nuint> GetSerializedSize;
            [NativeTypeName("HRESULT (void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void*, nuint, HResult> Serialize;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, uint> )(lpVtbl[1]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.GetSerializedSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetSerializedSize()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, nuint> )(lpVtbl[11]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.LoadComputePipeline"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, ushort*, D3D12ComputePipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[10]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
        {
            fixed (void** __dsl_ppPipelineState = ppPipelineState)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                return (HResult)LoadComputePipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
            }
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadComputePipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, out TCom ppPipelineState)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                ppPipelineState = default;
                return LoadComputePipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
            }
        }

        /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.LoadGraphicsPipeline"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, ushort*, D3D12GraphicsPipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
        {
            fixed (void** __dsl_ppPipelineState = ppPipelineState)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                return (HResult)LoadGraphicsPipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadGraphicsPipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, out TCom ppPipelineState)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                ppPipelineState = default;
                return LoadGraphicsPipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, uint> )(lpVtbl[2]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.Serialize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, void*, nuint, HResult> )(lpVtbl[12]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Serialize(Ref pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
        {
            fixed (void* __dsl_pData = pData)
            {
                return (HResult)Serialize(__dsl_pData, DataSizeInBytes);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.StorePipeline"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState pPipeline)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary.Native*, ushort*, ID3D12PipelineState.Native*, HResult> )(lpVtbl[8]))((ID3D12PipelineLibrary.Native*)Unsafe.AsPointer(ref this), pName, pPipeline.LpVtbl);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult StorePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, ID3D12PipelineState pPipeline)
        {
            fixed (ushort* __dsl_pName = pName)
            {
                return (HResult)StorePipeline(__dsl_pName, pPipeline);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12PipelineLibrary"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12PipelineLibrary(Ptr3D vtbl) => LpVtbl = (ID3D12PipelineLibrary.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12PipelineLibrary"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12PipelineLibrary(Ptr<ID3D12PipelineLibrary.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12PipelineLibrary.Native"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary.Native"/> instance to be converted </param>
    public static implicit operator ID3D12PipelineLibrary(ID3D12PipelineLibrary.Native* value) => new ID3D12PipelineLibrary((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "ID3D12PipelineLibrary.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator ID3D12PipelineLibrary.Native*(ID3D12PipelineLibrary value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(Ptr3D value) => new ID3D12PipelineLibrary(value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12PipelineLibrary value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(Ptr<ID3D12PipelineLibrary.Native> value) => new ID3D12PipelineLibrary(value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12PipelineLibrary.Native>(ID3D12PipelineLibrary value) => (Ptr<ID3D12PipelineLibrary.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(void*** value) => new ID3D12PipelineLibrary((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator void***(ID3D12PipelineLibrary value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12PipelineLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary(nuint value) => new ID3D12PipelineLibrary((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12PipelineLibrary"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12PipelineLibrary value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
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

    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.GetSerializedSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSerializedSize() => LpVtbl->GetSerializedSize();
    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.LoadComputePipeline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState) => LpVtbl->LoadComputePipeline(pName, pDesc, riid, ppPipelineState);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
    {
        fixed (void** __dsl_ppPipelineState = ppPipelineState)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            return (HResult)LoadComputePipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
        }
    }

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadComputePipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, out TCom ppPipelineState)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            ppPipelineState = default;
            return LoadComputePipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
        }
    }

    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.LoadGraphicsPipeline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState) => LpVtbl->LoadGraphicsPipeline(pName, pDesc, riid, ppPipelineState);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
    {
        fixed (void** __dsl_ppPipelineState = ppPipelineState)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            return (HResult)LoadGraphicsPipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadGraphicsPipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, out TCom ppPipelineState)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            ppPipelineState = default;
            return LoadGraphicsPipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
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
    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.Serialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes) => LpVtbl->Serialize(pData, DataSizeInBytes);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Serialize(Ref pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
    {
        fixed (void* __dsl_pData = pData)
        {
            return (HResult)Serialize(__dsl_pData, DataSizeInBytes);
        }
    }

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

    /// <include file='ID3D12PipelineLibrary.xml' path='doc/member[@name="ID3D12PipelineLibrary.StorePipeline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState pPipeline) => LpVtbl->StorePipeline(pName, pPipeline);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult StorePipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, ID3D12PipelineState pPipeline)
    {
        fixed (ushort* __dsl_pName = pName)
        {
            return (HResult)StorePipeline(__dsl_pName, pPipeline);
        }
    }
}