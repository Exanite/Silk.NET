// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList"]/*'/>
[Guid("3B60536E-AD29-4E64-A269-F853837E5E53")]
[NativeTypeName("struct ID3D12VideoDecodeCommandList : ID3D12CommandList")]
[NativeInheritance("ID3D12CommandList")]
public unsafe partial struct ID3D12VideoDecodeCommandList : ID3D12VideoDecodeCommandList.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDecodeCommandList));

    public interface Interface : ID3D12CommandList.Interface
    {
        [VtblIndex(19)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(19)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(14)]
        void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index);
        [VtblIndex(11)]
        void ClearState();
        [VtblIndex(9)]
        HResult Close();
        [VtblIndex(21)]
        void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeOutputStreamArguments* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeInputStreamArguments* pInputArguments);
        [VtblIndex(21)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeOutputStreamArguments> pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeInputStreamArguments> pInputArguments);
        [VtblIndex(13)]
        void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion);
        [VtblIndex(13)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion);
        [VtblIndex(20)]
        void EndEvent();
        [VtblIndex(15)]
        void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index);
        [VtblIndex(10)]
        HResult Reset(ID3D12CommandAllocator pAllocator);
        [VtblIndex(16)]
        void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);
        [VtblIndex(12)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers);
        [VtblIndex(18)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(18)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(17)]
        void SetPredication(ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12PredicationOp Operation);
        [VtblIndex(22)]
        void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12WritebufferimmediateParameter* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12WritebufferimmediateMode* pModes);
        [VtblIndex(22)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] Ref<D3D12WritebufferimmediateParameter> pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] Ref<D3D12WritebufferimmediateMode> pModes);
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList"]/*'/>
    [Guid("3B60536E-AD29-4E64-A269-F853837E5E53")]
    [NativeTypeName("struct ID3D12VideoDecodeCommandList : ID3D12CommandList")]
    [NativeInheritance("ID3D12CommandList")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDecodeCommandList));

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
            [NativeTypeName("D3D12_COMMAND_LIST_TYPE () __attribute__((stdcall))")]
            public new delegate* unmanaged<TSelf*, D3D12CommandListType> GetType;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> Close;
            [NativeTypeName("HRESULT (ID3D12CommandAllocator *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12CommandAllocator.Native*, HResult> Reset;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> ClearState;
            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12ResourceBarrier*, void> ResourceBarrier;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_DISCARD_REGION *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12DiscardRegion*, void> DiscardResource;
            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> BeginQuery;
            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> EndQuery;
            [NativeTypeName("void (ID3D12QueryHeap *, D3D12_QUERY_TYPE, UINT, UINT, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, uint, ID3D12Resource.Native*, ulong, void> ResolveQueryData;
            [NativeTypeName("void (ID3D12Resource *, UINT64, D3D12_PREDICATION_OP) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, ulong, D3D12PredicationOp, void> SetPredication;
            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;
            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> EndEvent;
            [NativeTypeName("void (ID3D12VideoDecoder *, const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *, const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12VideoDecoder.Native*, D3D12VideoDecodeOutputStreamArguments*, D3D12VideoDecodeInputStreamArguments*, void> DecodeFrame;
            [NativeTypeName("void (UINT, const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *, const D3D12_WRITEBUFFERIMMEDIATE_MODE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12WritebufferimmediateParameter*, D3D12WritebufferimmediateMode*, void> WriteBufferImmediate;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint> )(lpVtbl[1]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint, void*, uint, void> )(lpVtbl[19]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
        {
            fixed (void* __dsl_pData = pData)
            {
                BeginEvent(Metadata, __dsl_pData, Size);
            }
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginQuery"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> )(lpVtbl[14]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, Index);
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ClearState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void ClearState()
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, void> )(lpVtbl[11]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Close"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult Close()
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, HResult> )(lpVtbl[9]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DecodeFrame"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeOutputStreamArguments* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeInputStreamArguments* pInputArguments)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12VideoDecoder.Native*, D3D12VideoDecodeOutputStreamArguments*, D3D12VideoDecodeInputStreamArguments*, void> )(lpVtbl[21]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pDecoder.LpVtbl, pOutputArguments, pInputArguments);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeOutputStreamArguments> pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeInputStreamArguments> pInputArguments)
        {
            fixed (D3D12VideoDecodeInputStreamArguments* __dsl_pInputArguments = pInputArguments)
            fixed (D3D12VideoDecodeOutputStreamArguments* __dsl_pOutputArguments = pOutputArguments)
            {
                DecodeFrame(pDecoder, __dsl_pOutputArguments, __dsl_pInputArguments);
            }
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DiscardResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12Resource.Native*, D3D12DiscardRegion*, void> )(lpVtbl[13]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pRegion);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion)
        {
            fixed (D3D12DiscardRegion* __dsl_pRegion = pRegion)
            {
                DiscardResource(pResource, __dsl_pRegion);
            }
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void EndEvent()
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, void> )(lpVtbl[20]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndQuery"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> )(lpVtbl[15]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, Index);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <inheritdoc cref = "ID3D12CommandList.GetType"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public new D3D12CommandListType GetType()
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, D3D12CommandListType> )(lpVtbl[8]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint> )(lpVtbl[2]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Reset"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult Reset(ID3D12CommandAllocator pAllocator)
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12CommandAllocator.Native*, HResult> )(lpVtbl[10]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pAllocator.LpVtbl);
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResolveQueryData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, uint, ID3D12Resource.Native*, ulong, void> )(lpVtbl[16]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, StartIndex, NumQueries, pDestinationBuffer.LpVtbl, AlignedDestinationBufferOffset);
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResourceBarrier"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint, D3D12ResourceBarrier*, void> )(lpVtbl[12]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers)
        {
            fixed (D3D12ResourceBarrier* __dsl_pBarriers = pBarriers)
            {
                ResourceBarrier(NumBarriers, __dsl_pBarriers);
            }
        }

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetMarker"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint, void*, uint, void> )(lpVtbl[18]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetMarker(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
        {
            fixed (void* __dsl_pData = pData)
            {
                SetMarker(Metadata, __dsl_pData, Size);
            }
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), Name);
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

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetPredication"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void SetPredication(ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12PredicationOp Operation)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, ID3D12Resource.Native*, ulong, D3D12PredicationOp, void> )(lpVtbl[17]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), pBuffer.LpVtbl, AlignedBufferOffset, Operation);
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.WriteBufferImmediate"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12WritebufferimmediateParameter* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12WritebufferimmediateMode* pModes)
        {
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList.Native*, uint, D3D12WritebufferimmediateParameter*, D3D12WritebufferimmediateMode*, void> )(lpVtbl[22]))((ID3D12VideoDecodeCommandList.Native*)Unsafe.AsPointer(ref this), Count, pParams, pModes);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] Ref<D3D12WritebufferimmediateParameter> pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] Ref<D3D12WritebufferimmediateMode> pModes)
        {
            fixed (D3D12WritebufferimmediateMode* __dsl_pModes = pModes)
            fixed (D3D12WritebufferimmediateParameter* __dsl_pParams = pParams)
            {
                WriteBufferImmediate(Count, __dsl_pParams, __dsl_pModes);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDecodeCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDecodeCommandList(Ptr3D vtbl) => LpVtbl = (ID3D12VideoDecodeCommandList.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDecodeCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDecodeCommandList(Ptr<ID3D12VideoDecodeCommandList.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList.Native"/> to <see cref = "ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDecodeCommandList(ID3D12VideoDecodeCommandList.Native* value) => new ID3D12VideoDecodeCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList"/> to <see cref = "ID3D12VideoDecodeCommandList.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDecodeCommandList.Native*(ID3D12VideoDecodeCommandList value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList(Ptr3D value) => new ID3D12VideoDecodeCommandList(value);
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VideoDecodeCommandList value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList(Ptr<ID3D12VideoDecodeCommandList.Native> value) => new ID3D12VideoDecodeCommandList(value);
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VideoDecodeCommandList.Native>(ID3D12VideoDecodeCommandList value) => (Ptr<ID3D12VideoDecodeCommandList.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList(void*** value) => new ID3D12VideoDecodeCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VideoDecodeCommandList value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VideoDecodeCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDecodeCommandList(nuint value) => new ID3D12VideoDecodeCommandList((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VideoDecodeCommandList"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDecodeCommandList"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VideoDecodeCommandList value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->BeginEvent(Metadata, pData, Size);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
    {
        fixed (void* __dsl_pData = pData)
        {
            BeginEvent(Metadata, __dsl_pData, Size);
        }
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.BeginQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index) => LpVtbl->BeginQuery(pQueryHeap, Type, Index);
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ClearState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState() => LpVtbl->ClearState();
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult Close() => LpVtbl->Close();
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DecodeFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeOutputStreamArguments* pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] D3D12VideoDecodeInputStreamArguments* pInputArguments) => LpVtbl->DecodeFrame(pDecoder, pOutputArguments, pInputArguments);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DecodeFrame(ID3D12VideoDecoder pDecoder, [NativeTypeName("const D3D12_VIDEO_DECODE_OUTPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeOutputStreamArguments> pOutputArguments, [NativeTypeName("const D3D12_VIDEO_DECODE_INPUT_STREAM_ARGUMENTS *")] Ref<D3D12VideoDecodeInputStreamArguments> pInputArguments)
    {
        fixed (D3D12VideoDecodeInputStreamArguments* __dsl_pInputArguments = pInputArguments)
        fixed (D3D12VideoDecodeOutputStreamArguments* __dsl_pOutputArguments = pOutputArguments)
        {
            DecodeFrame(pDecoder, __dsl_pOutputArguments, __dsl_pInputArguments);
        }
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.DiscardResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion) => LpVtbl->DiscardResource(pResource, pRegion);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion)
    {
        fixed (D3D12DiscardRegion* __dsl_pRegion = pRegion)
        {
            DiscardResource(pResource, __dsl_pRegion);
        }
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void EndEvent() => LpVtbl->EndEvent();
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.EndQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index) => LpVtbl->EndQuery(pQueryHeap, Type, Index);
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

    /// <inheritdoc cref = "ID3D12CommandList.GetType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public new D3D12CommandListType GetType() => LpVtbl->GetType();
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
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult Reset(ID3D12CommandAllocator pAllocator) => LpVtbl->Reset(pAllocator);
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResolveQueryData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset) => LpVtbl->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.ResourceBarrier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers) => LpVtbl->ResourceBarrier(NumBarriers, pBarriers);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers)
    {
        fixed (D3D12ResourceBarrier* __dsl_pBarriers = pBarriers)
        {
            ResourceBarrier(NumBarriers, __dsl_pBarriers);
        }
    }

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetMarker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->SetMarker(Metadata, pData, Size);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
    {
        fixed (void* __dsl_pData = pData)
        {
            SetMarker(Metadata, __dsl_pData, Size);
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

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.SetPredication"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void SetPredication(ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12PredicationOp Operation) => LpVtbl->SetPredication(pBuffer, AlignedBufferOffset, Operation);
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

    /// <include file='ID3D12VideoDecodeCommandList.xml' path='doc/member[@name="ID3D12VideoDecodeCommandList.WriteBufferImmediate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] D3D12WritebufferimmediateParameter* pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] D3D12WritebufferimmediateMode* pModes) => LpVtbl->WriteBufferImmediate(Count, pParams, pModes);
    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void WriteBufferImmediate(uint Count, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_PARAMETER *")] Ref<D3D12WritebufferimmediateParameter> pParams, [NativeTypeName("const D3D12_WRITEBUFFERIMMEDIATE_MODE *")] Ref<D3D12WritebufferimmediateMode> pModes)
    {
        fixed (D3D12WritebufferimmediateMode* __dsl_pModes = pModes)
        fixed (D3D12WritebufferimmediateParameter* __dsl_pParams = pParams)
        {
            WriteBufferImmediate(Count, __dsl_pParams, __dsl_pModes);
        }
    }
}