// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue"]/*'/>
[Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
[NativeTypeName("struct ID3D12CommandQueue : ID3D12Pageable")]
[NativeInheritance("ID3D12Pageable")]
public unsafe partial struct ID3D12CommandQueue : ID3D12CommandQueue.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12CommandQueue));

    public interface Interface : ID3D12Pageable.Interface
    {
        [VtblIndex(12)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(9)]
        void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pRegionSize, D3D12TileMappingFlags Flags);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pRegionSize, D3D12TileMappingFlags Flags);
        [VtblIndex(13)]
        void EndEvent();
        [VtblIndex(10)]
        void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList* ppCommandLists);
        [VtblIndex(10)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] Ref<ID3D12CommandList> ppCommandLists);
        [VtblIndex(17)]
        HResult GetClockCalibration([NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp);
        [VtblIndex(17)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetClockCalibration([NativeTypeName("UINT64 *")] Ref<ulong> pGpuTimestamp, [NativeTypeName("UINT64 *")] Ref<ulong> pCpuTimestamp);
        [VtblIndex(18)]
        D3D12CommandQueueDesc GetDesc();
        [VtblIndex(16)]
        HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency);
        [VtblIndex(16)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] Ref<ulong> pFrequency);
        [VtblIndex(11)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(14)]
        HResult Signal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value);
        [VtblIndex(8)]
        void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12TileRangeFlags* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12TileMappingFlags Flags);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] Ref<D3D12TileRangeFlags> pRangeFlags, [NativeTypeName("const UINT *")] Ref<uint> pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] Ref<uint> pRangeTileCounts, D3D12TileMappingFlags Flags);
        [VtblIndex(15)]
        HResult Wait(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value);
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue"]/*'/>
    [Guid("0EC870A6-5D7E-4C22-8CFC-5BAAE07616ED")]
    [NativeTypeName("struct ID3D12CommandQueue : ID3D12Pageable")]
    [NativeInheritance("ID3D12Pageable")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12CommandQueue));

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
            [NativeTypeName("void (ID3D12Resource *, UINT, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Heap *, UINT, const D3D12_TILE_RANGE_FLAGS *, const UINT *, const UINT *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, ID3D12Heap.Native*, uint, D3D12TileRangeFlags*, uint*, uint*, D3D12TileMappingFlags, void> UpdateTileMappings;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, D3D12_TILE_MAPPING_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, D3D12TileMappingFlags, void> CopyTileMappings;
            [NativeTypeName("void (UINT, ID3D12CommandList *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12CommandList.Native**, void> ExecuteCommandLists;
            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, uint, void> SetMarker;
            [NativeTypeName("void (UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, uint, void> BeginEvent;
            [NativeTypeName("void () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, void> EndEvent;
            [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Fence.Native*, ulong, HResult> Signal;
            [NativeTypeName("HRESULT (ID3D12Fence *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Fence.Native*, ulong, HResult> Wait;
            [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong*, HResult> GetTimestampFrequency;
            [NativeTypeName("HRESULT (UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong*, ulong*, HResult> GetClockCalibration;
            [NativeTypeName("D3D12_COMMAND_QUEUE_DESC () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CommandQueueDesc*, D3D12CommandQueueDesc*> GetDesc;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, uint> )(lpVtbl[1]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.BeginEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, uint, void*, uint, void> )(lpVtbl[12]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
        {
            fixed (void* __dsl_pData = pData)
            {
                BeginEvent(Metadata, __dsl_pData, Size);
            }
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.CopyTileMappings"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pRegionSize, D3D12TileMappingFlags Flags)
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, D3D12TileMappingFlags, void> )(lpVtbl[9]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pDstResource.LpVtbl, pDstRegionStartCoordinate, pSrcResource.LpVtbl, pSrcRegionStartCoordinate, pRegionSize, Flags);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pRegionSize, D3D12TileMappingFlags Flags)
        {
            fixed (D3D12TileRegionSize* __dsl_pRegionSize = pRegionSize)
            fixed (D3D12TiledResourceCoordinate* __dsl_pSrcRegionStartCoordinate = pSrcRegionStartCoordinate)
            fixed (D3D12TiledResourceCoordinate* __dsl_pDstRegionStartCoordinate = pDstRegionStartCoordinate)
            {
                CopyTileMappings(pDstResource, __dsl_pDstRegionStartCoordinate, pSrcResource, __dsl_pSrcRegionStartCoordinate, __dsl_pRegionSize, Flags);
            }
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.EndEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void EndEvent()
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, void> )(lpVtbl[13]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.ExecuteCommandLists"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList* ppCommandLists)
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, uint, ID3D12CommandList.Native**, void> )(lpVtbl[10]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), NumCommandLists, &ppCommandLists->LpVtbl);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] Ref<ID3D12CommandList> ppCommandLists)
        {
            fixed (ID3D12CommandList* __dsl_ppCommandLists = ppCommandLists)
            {
                ExecuteCommandLists(NumCommandLists, __dsl_ppCommandLists);
            }
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetClockCalibration"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HResult GetClockCalibration([NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, ulong*, ulong*, HResult> )(lpVtbl[17]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pGpuTimestamp, pCpuTimestamp);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetClockCalibration([NativeTypeName("UINT64 *")] Ref<ulong> pGpuTimestamp, [NativeTypeName("UINT64 *")] Ref<ulong> pCpuTimestamp)
        {
            fixed (ulong* __dsl_pCpuTimestamp = pCpuTimestamp)
            fixed (ulong* __dsl_pGpuTimestamp = pGpuTimestamp)
            {
                return (HResult)GetClockCalibration(__dsl_pGpuTimestamp, __dsl_pCpuTimestamp);
            }
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetDesc"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public D3D12CommandQueueDesc GetDesc()
        {
            D3D12CommandQueueDesc result;
            return *((delegate* unmanaged<ID3D12CommandQueue.Native*, D3D12CommandQueueDesc*, D3D12CommandQueueDesc*> )(lpVtbl[18]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetTimestampFrequency"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, ulong*, HResult> )(lpVtbl[16]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pFrequency);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] Ref<ulong> pFrequency)
        {
            fixed (ulong* __dsl_pFrequency = pFrequency)
            {
                return (HResult)GetTimestampFrequency(__dsl_pFrequency);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, uint> )(lpVtbl[2]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.SetMarker"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, uint, void*, uint, void> )(lpVtbl[11]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(11)]
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
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.Signal"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult Signal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, ID3D12Fence.Native*, ulong, HResult> )(lpVtbl[14]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pFence.LpVtbl, Value);
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.UpdateTileMappings"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12TileRangeFlags* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12TileMappingFlags Flags)
        {
            ((delegate* unmanaged<ID3D12CommandQueue.Native*, ID3D12Resource.Native*, uint, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, ID3D12Heap.Native*, uint, D3D12TileRangeFlags*, uint*, uint*, D3D12TileMappingFlags, void> )(lpVtbl[8]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap.LpVtbl, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] Ref<D3D12TileRangeFlags> pRangeFlags, [NativeTypeName("const UINT *")] Ref<uint> pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] Ref<uint> pRangeTileCounts, D3D12TileMappingFlags Flags)
        {
            fixed (uint* __dsl_pRangeTileCounts = pRangeTileCounts)
            fixed (uint* __dsl_pHeapRangeStartOffsets = pHeapRangeStartOffsets)
            fixed (D3D12TileRangeFlags* __dsl_pRangeFlags = pRangeFlags)
            fixed (D3D12TileRegionSize* __dsl_pResourceRegionSizes = pResourceRegionSizes)
            fixed (D3D12TiledResourceCoordinate* __dsl_pResourceRegionStartCoordinates = pResourceRegionStartCoordinates)
            {
                UpdateTileMappings(pResource, NumResourceRegions, __dsl_pResourceRegionStartCoordinates, __dsl_pResourceRegionSizes, pHeap, NumRanges, __dsl_pRangeFlags, __dsl_pHeapRangeStartOffsets, __dsl_pRangeTileCounts, Flags);
            }
        }

        /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.Wait"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult Wait(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value)
        {
            return ((delegate* unmanaged<ID3D12CommandQueue.Native*, ID3D12Fence.Native*, ulong, HResult> )(lpVtbl[15]))((ID3D12CommandQueue.Native*)Unsafe.AsPointer(ref this), pFence.LpVtbl, Value);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12CommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CommandQueue(Ptr3D vtbl) => LpVtbl = (ID3D12CommandQueue.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12CommandQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12CommandQueue(Ptr<ID3D12CommandQueue.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12CommandQueue.Native"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue.Native"/> instance to be converted </param>
    public static implicit operator ID3D12CommandQueue(ID3D12CommandQueue.Native* value) => new ID3D12CommandQueue((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12CommandQueue"/> to <see cref = "ID3D12CommandQueue.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator ID3D12CommandQueue.Native*(ID3D12CommandQueue value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Ptr3D value) => new ID3D12CommandQueue(value);
    /// <summary>casts <see cref = "ID3D12CommandQueue"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12CommandQueue value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(Ptr<ID3D12CommandQueue.Native> value) => new ID3D12CommandQueue(value);
    /// <summary>casts <see cref = "ID3D12CommandQueue"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12CommandQueue.Native>(ID3D12CommandQueue value) => (Ptr<ID3D12CommandQueue.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(void*** value) => new ID3D12CommandQueue((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12CommandQueue"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator void***(ID3D12CommandQueue value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12CommandQueue"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12CommandQueue(nuint value) => new ID3D12CommandQueue((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12CommandQueue"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12CommandQueue"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12CommandQueue value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.BeginEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->BeginEvent(Metadata, pData, Size);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
    {
        fixed (void* __dsl_pData = pData)
        {
            BeginEvent(Metadata, __dsl_pData, Size);
        }
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.CopyTileMappings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pRegionSize, D3D12TileMappingFlags Flags) => LpVtbl->CopyTileMappings(pDstResource, pDstRegionStartCoordinate, pSrcResource, pSrcRegionStartCoordinate, pRegionSize, Flags);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CopyTileMappings(ID3D12Resource pDstResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pDstRegionStartCoordinate, ID3D12Resource pSrcResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pSrcRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pRegionSize, D3D12TileMappingFlags Flags)
    {
        fixed (D3D12TileRegionSize* __dsl_pRegionSize = pRegionSize)
        fixed (D3D12TiledResourceCoordinate* __dsl_pSrcRegionStartCoordinate = pSrcRegionStartCoordinate)
        fixed (D3D12TiledResourceCoordinate* __dsl_pDstRegionStartCoordinate = pDstRegionStartCoordinate)
        {
            CopyTileMappings(pDstResource, __dsl_pDstRegionStartCoordinate, pSrcResource, __dsl_pSrcRegionStartCoordinate, __dsl_pRegionSize, Flags);
        }
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.EndEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void EndEvent() => LpVtbl->EndEvent();
    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.ExecuteCommandLists"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] ID3D12CommandList* ppCommandLists) => LpVtbl->ExecuteCommandLists(NumCommandLists, ppCommandLists);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ExecuteCommandLists(uint NumCommandLists, [NativeTypeName("ID3D12CommandList *const *")] Ref<ID3D12CommandList> ppCommandLists)
    {
        fixed (ID3D12CommandList* __dsl_ppCommandLists = ppCommandLists)
        {
            ExecuteCommandLists(NumCommandLists, __dsl_ppCommandLists);
        }
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetClockCalibration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HResult GetClockCalibration([NativeTypeName("UINT64 *")] ulong* pGpuTimestamp, [NativeTypeName("UINT64 *")] ulong* pCpuTimestamp) => LpVtbl->GetClockCalibration(pGpuTimestamp, pCpuTimestamp);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetClockCalibration([NativeTypeName("UINT64 *")] Ref<ulong> pGpuTimestamp, [NativeTypeName("UINT64 *")] Ref<ulong> pCpuTimestamp)
    {
        fixed (ulong* __dsl_pCpuTimestamp = pCpuTimestamp)
        fixed (ulong* __dsl_pGpuTimestamp = pGpuTimestamp)
        {
            return (HResult)GetClockCalibration(__dsl_pGpuTimestamp, __dsl_pCpuTimestamp);
        }
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetDesc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public D3D12CommandQueueDesc GetDesc() => LpVtbl->GetDesc();
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

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.GetTimestampFrequency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] ulong* pFrequency) => LpVtbl->GetTimestampFrequency(pFrequency);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTimestampFrequency([NativeTypeName("UINT64 *")] Ref<ulong> pFrequency)
    {
        fixed (ulong* __dsl_pFrequency = pFrequency)
        {
            return (HResult)GetTimestampFrequency(__dsl_pFrequency);
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
    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.SetMarker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->SetMarker(Metadata, pData, Size);
    [VtblIndex(11)]
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

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.Signal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult Signal(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value) => LpVtbl->Signal(pFence, Value);
    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.UpdateTileMappings"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] D3D12TileRangeFlags* pRangeFlags, [NativeTypeName("const UINT *")] uint* pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] uint* pRangeTileCounts, D3D12TileMappingFlags Flags) => LpVtbl->UpdateTileMappings(pResource, NumResourceRegions, pResourceRegionStartCoordinates, pResourceRegionSizes, pHeap, NumRanges, pRangeFlags, pHeapRangeStartOffsets, pRangeTileCounts, Flags);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void UpdateTileMappings(ID3D12Resource pResource, uint NumResourceRegions, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pResourceRegionStartCoordinates, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pResourceRegionSizes, ID3D12Heap pHeap, uint NumRanges, [NativeTypeName("const D3D12_TILE_RANGE_FLAGS *")] Ref<D3D12TileRangeFlags> pRangeFlags, [NativeTypeName("const UINT *")] Ref<uint> pHeapRangeStartOffsets, [NativeTypeName("const UINT *")] Ref<uint> pRangeTileCounts, D3D12TileMappingFlags Flags)
    {
        fixed (uint* __dsl_pRangeTileCounts = pRangeTileCounts)
        fixed (uint* __dsl_pHeapRangeStartOffsets = pHeapRangeStartOffsets)
        fixed (D3D12TileRangeFlags* __dsl_pRangeFlags = pRangeFlags)
        fixed (D3D12TileRegionSize* __dsl_pResourceRegionSizes = pResourceRegionSizes)
        fixed (D3D12TiledResourceCoordinate* __dsl_pResourceRegionStartCoordinates = pResourceRegionStartCoordinates)
        {
            UpdateTileMappings(pResource, NumResourceRegions, __dsl_pResourceRegionStartCoordinates, __dsl_pResourceRegionSizes, pHeap, NumRanges, __dsl_pRangeFlags, __dsl_pHeapRangeStartOffsets, __dsl_pRangeTileCounts, Flags);
        }
    }

    /// <include file='ID3D12CommandQueue.xml' path='doc/member[@name="ID3D12CommandQueue.Wait"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult Wait(ID3D12Fence pFence, [NativeTypeName("UINT64")] ulong Value) => LpVtbl->Wait(pFence, Value);
}