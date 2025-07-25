// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1"]/*'/>
[Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
[NativeTypeName("struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary")]
[NativeInheritance("ID3D12PipelineLibrary")]
public unsafe partial struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12PipelineLibrary1));

    public interface Interface : ID3D12PipelineLibrary.Interface
    {
        [VtblIndex(13)]
        HResult LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12PipelineStateStreamDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
        [VtblIndex(13)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult LoadPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] Ref<D3D12PipelineStateStreamDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState);
    }

    /// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1"]/*'/>
    [Guid("80EABF42-2568-4E5E-BD82-C37F86961DC3")]
    [NativeTypeName("struct ID3D12PipelineLibrary1 : ID3D12PipelineLibrary")]
    [NativeInheritance("ID3D12PipelineLibrary")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12PipelineLibrary1));

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
            [NativeTypeName("HRESULT (LPCWSTR, const D3D12_PIPELINE_STATE_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, D3D12PipelineStateStreamDesc*, Guid*, void**, HResult> LoadPipeline;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, uint> )(lpVtbl[1]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <inheritdoc cref = "ID3D12PipelineLibrary.GetSerializedSize"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("SIZE_T")]
        public nuint GetSerializedSize()
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, nuint> )(lpVtbl[11]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadComputePipeline"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult LoadComputePipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, ushort*, D3D12ComputePipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[10]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
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

        /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadGraphicsPipeline"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult LoadGraphicsPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, ushort*, D3D12GraphicsPipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
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

        /// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1.LoadPipeline"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12PipelineStateStreamDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, ushort*, D3D12PipelineStateStreamDesc*, Guid*, void**, HResult> )(lpVtbl[13]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), pName, pDesc, riid, ppPipelineState);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] Ref<D3D12PipelineStateStreamDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
        {
            fixed (void** __dsl_ppPipelineState = ppPipelineState)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12PipelineStateStreamDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                return (HResult)LoadPipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
            }
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult LoadPipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] Ref<D3D12PipelineStateStreamDesc> pDesc, out TCom ppPipelineState)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12PipelineStateStreamDesc* __dsl_pDesc = pDesc)
            fixed (ushort* __dsl_pName = pName)
            {
                ppPipelineState = default;
                return LoadPipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, uint> )(lpVtbl[2]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12PipelineLibrary.Serialize"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult Serialize(void* pData, [NativeTypeName("SIZE_T")] nuint DataSizeInBytes)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, void*, nuint, HResult> )(lpVtbl[12]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), pData, DataSizeInBytes);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <inheritdoc cref = "ID3D12PipelineLibrary.StorePipeline"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult StorePipeline([NativeTypeName("LPCWSTR")] ushort* pName, ID3D12PipelineState pPipeline)
        {
            return ((delegate* unmanaged<ID3D12PipelineLibrary1.Native*, ushort*, ID3D12PipelineState.Native*, HResult> )(lpVtbl[8]))((ID3D12PipelineLibrary1.Native*)Unsafe.AsPointer(ref this), pName, pPipeline.LpVtbl);
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

    /// <summary>Initializes a new instance of the <see cref = "ID3D12PipelineLibrary1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12PipelineLibrary1(Ptr3D vtbl) => LpVtbl = (ID3D12PipelineLibrary1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12PipelineLibrary1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12PipelineLibrary1(Ptr<ID3D12PipelineLibrary1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1.Native"/> to <see cref = "ID3D12PipelineLibrary1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12PipelineLibrary1(ID3D12PipelineLibrary1.Native* value) => new ID3D12PipelineLibrary1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1"/> to <see cref = "ID3D12PipelineLibrary1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1"/> instance to be converted </param>
    public static implicit operator ID3D12PipelineLibrary1.Native*(ID3D12PipelineLibrary1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12PipelineLibrary1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary1(Ptr3D value) => new ID3D12PipelineLibrary1(value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12PipelineLibrary1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12PipelineLibrary1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary1(Ptr<ID3D12PipelineLibrary1.Native> value) => new ID3D12PipelineLibrary1(value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12PipelineLibrary1.Native>(ID3D12PipelineLibrary1 value) => (Ptr<ID3D12PipelineLibrary1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12PipelineLibrary1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary1(void*** value) => new ID3D12PipelineLibrary1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12PipelineLibrary1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12PipelineLibrary1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12PipelineLibrary1(nuint value) => new ID3D12PipelineLibrary1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12PipelineLibrary1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12PipelineLibrary1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12PipelineLibrary1 value) => (nuint)value.LpVtbl;
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

    /// <inheritdoc cref = "ID3D12PipelineLibrary.GetSerializedSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("SIZE_T")]
    public nuint GetSerializedSize() => LpVtbl->GetSerializedSize();
    /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadComputePipeline"/>
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

    /// <inheritdoc cref = "ID3D12PipelineLibrary.LoadGraphicsPipeline"/>
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

    /// <include file='ID3D12PipelineLibrary1.xml' path='doc/member[@name="ID3D12PipelineLibrary1.LoadPipeline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult LoadPipeline([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] D3D12PipelineStateStreamDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState) => LpVtbl->LoadPipeline(pName, pDesc, riid, ppPipelineState);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadPipeline([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] Ref<D3D12PipelineStateStreamDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
    {
        fixed (void** __dsl_ppPipelineState = ppPipelineState)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12PipelineStateStreamDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            return (HResult)LoadPipeline(__dsl_pName, __dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
        }
    }

    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult LoadPipeline<TCom>([NativeTypeName("LPCWSTR")] Ref<ushort> pName, [NativeTypeName("const D3D12_PIPELINE_STATE_STREAM_DESC *")] Ref<D3D12PipelineStateStreamDesc> pDesc, out TCom ppPipelineState)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12PipelineStateStreamDesc* __dsl_pDesc = pDesc)
        fixed (ushort* __dsl_pName = pName)
        {
            ppPipelineState = default;
            return LoadPipeline(__dsl_pName, __dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
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
    /// <inheritdoc cref = "ID3D12PipelineLibrary.Serialize"/>
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

    /// <inheritdoc cref = "ID3D12PipelineLibrary.StorePipeline"/>
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