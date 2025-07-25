// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device"]/*'/>
[Guid("189819F1-1DB6-4B57-BE54-1821339B85F7")]
[NativeTypeName("struct ID3D12Device : ID3D12Object")]
[NativeInheritance("ID3D12Object")]
public unsafe partial struct ID3D12Device : ID3D12Device.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Device));

    public interface Interface : ID3D12Object.Interface
    {
        [VtblIndex(13)]
        HResult CheckFeatureSupport(D3D12Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize);
        [VtblIndex(13)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CheckFeatureSupport(D3D12Feature Feature, Ref pFeatureSupportData, uint FeatureSupportDataSize);
        [VtblIndex(23)]
        void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType);
        [VtblIndex(23)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType);
        [VtblIndex(24)]
        void CopyDescriptorsSimple(uint NumDescriptors, D3D12CpuDescriptorHandle DestDescriptorRangeStart, D3D12CpuDescriptorHandle SrcDescriptorRangeStart, D3D12DescriptorHeapType DescriptorHeapsType);
        [VtblIndex(9)]
        HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator);
        [VtblIndex(9)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandAllocator);
        [VtblIndex(12)]
        HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList);
        [VtblIndex(12)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandList);
        [VtblIndex(8)]
        HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12CommandQueueDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] Ref<D3D12CommandQueueDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandQueue);
        [VtblIndex(41)]
        HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12CommandSignatureDesc* pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature);
        [VtblIndex(41)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] Ref<D3D12CommandSignatureDesc> pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvCommandSignature);
        [VtblIndex(27)]
        HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource);
        [VtblIndex(27)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource);
        [VtblIndex(11)]
        HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
        [VtblIndex(11)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState);
        [VtblIndex(17)]
        void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12ConstantBufferViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(17)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] Ref<D3D12ConstantBufferViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(21)]
        void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12DepthStencilViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(21)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] Ref<D3D12DepthStencilViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(14)]
        HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12DescriptorHeapDesc* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap);
        [VtblIndex(14)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] Ref<D3D12DescriptorHeapDesc> pDescriptorHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap);
        [VtblIndex(36)]
        HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence);
        [VtblIndex(36)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppFence);
        [VtblIndex(10)]
        HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState);
        [VtblIndex(10)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState);
        [VtblIndex(28)]
        HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap);
        [VtblIndex(28)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap);
        [VtblIndex(29)]
        HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource);
        [VtblIndex(29)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource);
        [VtblIndex(39)]
        HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12QueryHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap);
        [VtblIndex(39)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] Ref<D3D12QueryHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap);
        [VtblIndex(20)]
        void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12RenderTargetViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(20)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] Ref<D3D12RenderTargetViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(30)]
        HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource);
        [VtblIndex(30)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource);
        [VtblIndex(16)]
        HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature);
        [VtblIndex(16)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] Ref pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvRootSignature);
        [VtblIndex(22)]
        void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12SamplerDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(22)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] Ref<D3D12SamplerDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(18)]
        void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12ShaderResourceViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(18)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] Ref<D3D12ShaderResourceViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(31)]
        HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, Handle* pHandle);
        [VtblIndex(31)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] Ref<SECURITY_ATTRIBUTES> pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] Ref<ushort> Name, Ref<Handle> pHandle);
        [VtblIndex(19)]
        void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12UnorderedAccessViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(19)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] Ref<D3D12UnorderedAccessViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor);
        [VtblIndex(35)]
        HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects);
        [VtblIndex(35)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects);
        [VtblIndex(43)]
        LUID GetAdapterLuid();
        [VtblIndex(38)]
        void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12PlacedSubresourceFootprint* pLayouts, uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes);
        [VtblIndex(38)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, Ref<D3D12PlacedSubresourceFootprint> pLayouts, Ref<uint> pNumRows, [NativeTypeName("UINT64 *")] Ref<ulong> pRowSizeInBytes, [NativeTypeName("UINT64 *")] Ref<ulong> pTotalBytes);
        [VtblIndex(26)]
        D3D12HeapProperties GetCustomHeapProperties(uint nodeMask, D3D12HeapType heapType);
        [VtblIndex(15)]
        uint GetDescriptorHandleIncrementSize(D3D12DescriptorHeapType DescriptorHeapType);
        [VtblIndex(37)]
        HResult GetDeviceRemovedReason();
        [VtblIndex(7)]
        uint GetNodeCount();
        [VtblIndex(25)]
        D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDescs);
        [VtblIndex(25)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDescs);
        [VtblIndex(42)]
        void GetResourceTiling(ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, D3D12PackedMipInfo* pPackedMipDesc, D3D12TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, D3D12SubresourceTiling* pSubresourceTilingsForNonPackedMips);
        [VtblIndex(42)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void GetResourceTiling(ID3D12Resource pTiledResource, Ref<uint> pNumTilesForEntireResource, Ref<D3D12PackedMipInfo> pPackedMipDesc, Ref<D3D12TileShape> pStandardTileShapeForNonPackedMips, Ref<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Ref<D3D12SubresourceTiling> pSubresourceTilingsForNonPackedMips);
        [VtblIndex(34)]
        HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects);
        [VtblIndex(34)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects);
        [VtblIndex(32)]
        HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);
        [VtblIndex(32)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObj);
        [VtblIndex(33)]
        HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, Handle* pNTHandle);
        [VtblIndex(33)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] Ref<ushort> Name, [NativeTypeName("DWORD")] uint Access, Ref<Handle> pNTHandle);
        [VtblIndex(40)]
        HResult SetStablePowerState([NativeTypeName("BOOL")] MaybeBool<int> Enable);
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device"]/*'/>
    [Guid("189819F1-1DB6-4B57-BE54-1821339B85F7")]
    [NativeTypeName("struct ID3D12Device : ID3D12Object")]
    [NativeInheritance("ID3D12Object")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12Device));

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
            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> GetNodeCount;
            [NativeTypeName("HRESULT (const D3D12_COMMAND_QUEUE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CommandQueueDesc*, Guid*, void**, HResult> CreateCommandQueue;
            [NativeTypeName("HRESULT (D3D12_COMMAND_LIST_TYPE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CommandListType, Guid*, void**, HResult> CreateCommandAllocator;
            [NativeTypeName("HRESULT (const D3D12_GRAPHICS_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12GraphicsPipelineStateDesc*, Guid*, void**, HResult> CreateGraphicsPipelineState;
            [NativeTypeName("HRESULT (const D3D12_COMPUTE_PIPELINE_STATE_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ComputePipelineStateDesc*, Guid*, void**, HResult> CreateComputePipelineState;
            [NativeTypeName("HRESULT (UINT, D3D12_COMMAND_LIST_TYPE, ID3D12CommandAllocator *, ID3D12PipelineState *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12CommandListType, ID3D12CommandAllocator.Native*, ID3D12PipelineState.Native*, Guid*, void**, HResult> CreateCommandList;
            [NativeTypeName("HRESULT (D3D12_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12Feature, void*, uint, HResult> CheckFeatureSupport;
            [NativeTypeName("HRESULT (const D3D12_DESCRIPTOR_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DescriptorHeapDesc*, Guid*, void**, HResult> CreateDescriptorHeap;
            [NativeTypeName("UINT (D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12DescriptorHeapType, uint> GetDescriptorHandleIncrementSize;
            [NativeTypeName("HRESULT (UINT, const void *, SIZE_T, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void*, nuint, Guid*, void**, HResult> CreateRootSignature;
            [NativeTypeName("void (const D3D12_CONSTANT_BUFFER_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ConstantBufferViewDesc*, D3D12CpuDescriptorHandle, void> CreateConstantBufferView;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_SHADER_RESOURCE_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12ShaderResourceViewDesc*, D3D12CpuDescriptorHandle, void> CreateShaderResourceView;
            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *, const D3D12_UNORDERED_ACCESS_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, ID3D12Resource.Native*, D3D12UnorderedAccessViewDesc*, D3D12CpuDescriptorHandle, void> CreateUnorderedAccessView;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_RENDER_TARGET_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12RenderTargetViewDesc*, D3D12CpuDescriptorHandle, void> CreateRenderTargetView;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_DEPTH_STENCIL_VIEW_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12DepthStencilViewDesc*, D3D12CpuDescriptorHandle, void> CreateDepthStencilView;
            [NativeTypeName("void (const D3D12_SAMPLER_DESC *, D3D12_CPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12SamplerDesc*, D3D12CpuDescriptorHandle, void> CreateSampler;
            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, const UINT *, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12CpuDescriptorHandle*, uint*, uint, D3D12CpuDescriptorHandle*, uint*, D3D12DescriptorHeapType, void> CopyDescriptors;
            [NativeTypeName("void (UINT, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_DESCRIPTOR_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12CpuDescriptorHandle, D3D12CpuDescriptorHandle, D3D12DescriptorHeapType, void> CopyDescriptorsSimple;
            [NativeTypeName("D3D12_RESOURCE_ALLOCATION_INFO (UINT, UINT, const D3D12_RESOURCE_DESC *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ResourceAllocationInfo*, uint, uint, D3D12ResourceDesc*, D3D12ResourceAllocationInfo*> GetResourceAllocationInfo;
            [NativeTypeName("D3D12_HEAP_PROPERTIES (UINT, D3D12_HEAP_TYPE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapProperties*, uint, D3D12HeapType, D3D12HeapProperties*> GetCustomHeapProperties;
            [NativeTypeName("HRESULT (const D3D12_HEAP_PROPERTIES *, D3D12_HEAP_FLAGS, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapProperties*, D3D12HeapFlags, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> CreateCommittedResource;
            [NativeTypeName("HRESULT (const D3D12_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12HeapDesc*, Guid*, void**, HResult> CreateHeap;
            [NativeTypeName("HRESULT (ID3D12Heap *, UINT64, const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Heap.Native*, ulong, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> CreatePlacedResource;
            [NativeTypeName("HRESULT (const D3D12_RESOURCE_DESC *, D3D12_RESOURCE_STATES, const D3D12_CLEAR_VALUE *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> CreateReservedResource;
            [NativeTypeName("HRESULT (ID3D12DeviceChild *, const SECURITY_ATTRIBUTES *, DWORD, LPCWSTR, HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12DeviceChild.Native*, SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, HResult> CreateSharedHandle;
            [NativeTypeName("HRESULT (HANDLE, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Handle, Guid*, void**, HResult> OpenSharedHandle;
            [NativeTypeName("HRESULT (LPCWSTR, DWORD, HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ushort*, uint, Handle*, HResult> OpenSharedHandleByName;
            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12Pageable.Native**, HResult> MakeResident;
            [NativeTypeName("HRESULT (UINT, ID3D12Pageable *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12Pageable.Native**, HResult> Evict;
            [NativeTypeName("HRESULT (UINT64, D3D12_FENCE_FLAGS, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ulong, D3D12FenceFlags, Guid*, void**, HResult> CreateFence;
            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, HResult> GetDeviceRemovedReason;
            [NativeTypeName("void (const D3D12_RESOURCE_DESC *, UINT, UINT, UINT64, D3D12_PLACED_SUBRESOURCE_FOOTPRINT *, UINT *, UINT64 *, UINT64 *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12ResourceDesc*, uint, uint, ulong, D3D12PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void> GetCopyableFootprints;
            [NativeTypeName("HRESULT (const D3D12_QUERY_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12QueryHeapDesc*, Guid*, void**, HResult> CreateQueryHeap;
            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, MaybeBool<int>, HResult> SetStablePowerState;
            [NativeTypeName("HRESULT (const D3D12_COMMAND_SIGNATURE_DESC *, ID3D12RootSignature *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CommandSignatureDesc*, ID3D12RootSignature.Native*, Guid*, void**, HResult> CreateCommandSignature;
            [NativeTypeName("void (ID3D12Resource *, UINT *, D3D12_PACKED_MIP_INFO *, D3D12_TILE_SHAPE *, UINT *, UINT, D3D12_SUBRESOURCE_TILING *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint*, D3D12PackedMipInfo*, D3D12TileShape*, uint*, uint, D3D12SubresourceTiling*, void> GetResourceTiling;
            [NativeTypeName("LUID () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, LUID*, LUID*> GetAdapterLuid;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint> )(lpVtbl[1]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CheckFeatureSupport"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult CheckFeatureSupport(D3D12Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12Feature, void*, uint, HResult> )(lpVtbl[13]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckFeatureSupport(D3D12Feature Feature, Ref pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
            {
                return (HResult)CheckFeatureSupport(Feature, __dsl_pFeatureSupportData, FeatureSupportDataSize);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CopyDescriptors"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, uint, D3D12CpuDescriptorHandle*, uint*, uint, D3D12CpuDescriptorHandle*, uint*, D3D12DescriptorHeapType, void> )(lpVtbl[23]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }

        [VtblIndex(23)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType)
        {
            fixed (uint* __dsl_pSrcDescriptorRangeSizes = pSrcDescriptorRangeSizes)
            fixed (D3D12CpuDescriptorHandle* __dsl_pSrcDescriptorRangeStarts = pSrcDescriptorRangeStarts)
            fixed (uint* __dsl_pDestDescriptorRangeSizes = pDestDescriptorRangeSizes)
            fixed (D3D12CpuDescriptorHandle* __dsl_pDestDescriptorRangeStarts = pDestDescriptorRangeStarts)
            {
                CopyDescriptors(NumDestDescriptorRanges, __dsl_pDestDescriptorRangeStarts, __dsl_pDestDescriptorRangeSizes, NumSrcDescriptorRanges, __dsl_pSrcDescriptorRangeStarts, __dsl_pSrcDescriptorRangeSizes, DescriptorHeapsType);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CopyDescriptorsSimple"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void CopyDescriptorsSimple(uint NumDescriptors, D3D12CpuDescriptorHandle DestDescriptorRangeStart, D3D12CpuDescriptorHandle SrcDescriptorRangeStart, D3D12DescriptorHeapType DescriptorHeapsType)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, uint, D3D12CpuDescriptorHandle, D3D12CpuDescriptorHandle, D3D12DescriptorHeapType, void> )(lpVtbl[24]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandAllocator"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12CommandListType, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), type, riid, ppCommandAllocator);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandAllocator)
        {
            fixed (void** __dsl_ppCommandAllocator = ppCommandAllocator)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateCommandAllocator(type, __dsl_riid, __dsl_ppCommandAllocator);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        public HResult CreateCommandAllocator<TCom>(D3D12CommandListType type, out TCom ppCommandAllocator)
            where TCom : unmanaged, IComVtbl
        {
            ppCommandAllocator = default;
            return CreateCommandAllocator(type, TCom.NativeGuid, ppCommandAllocator.GetAddressOf());
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandList"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint, D3D12CommandListType, ID3D12CommandAllocator.Native*, ID3D12PipelineState.Native*, Guid*, void**, HResult> )(lpVtbl[12]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), nodeMask, type, pCommandAllocator.LpVtbl, pInitialState.LpVtbl, riid, ppCommandList);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandList)
        {
            fixed (void** __dsl_ppCommandList = ppCommandList)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, __dsl_riid, __dsl_ppCommandList);
            }
        }

        [VtblIndex(12)]
        [Transformed]
        public HResult CreateCommandList<TCom>(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, out TCom ppCommandList)
            where TCom : unmanaged, IComVtbl
        {
            ppCommandList = default;
            return CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, TCom.NativeGuid, ppCommandList.GetAddressOf());
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandQueue"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12CommandQueueDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12CommandQueueDesc*, Guid*, void**, HResult> )(lpVtbl[8]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppCommandQueue);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] Ref<D3D12CommandQueueDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandQueue)
        {
            fixed (void** __dsl_ppCommandQueue = ppCommandQueue)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12CommandQueueDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateCommandQueue(__dsl_pDesc, __dsl_riid, __dsl_ppCommandQueue);
            }
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandQueue<TCom>([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] Ref<D3D12CommandQueueDesc> pDesc, out TCom ppCommandQueue)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12CommandQueueDesc* __dsl_pDesc = pDesc)
            {
                ppCommandQueue = default;
                return CreateCommandQueue(__dsl_pDesc, TCom.NativeGuid, ppCommandQueue.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandSignature"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12CommandSignatureDesc* pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12CommandSignatureDesc*, ID3D12RootSignature.Native*, Guid*, void**, HResult> )(lpVtbl[41]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, pRootSignature.LpVtbl, riid, ppvCommandSignature);
        }

        [VtblIndex(41)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] Ref<D3D12CommandSignatureDesc> pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvCommandSignature)
        {
            fixed (void** __dsl_ppvCommandSignature = ppvCommandSignature)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12CommandSignatureDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateCommandSignature(__dsl_pDesc, pRootSignature, __dsl_riid, __dsl_ppvCommandSignature);
            }
        }

        [VtblIndex(41)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommandSignature<TCom>([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] Ref<D3D12CommandSignatureDesc> pDesc, ID3D12RootSignature pRootSignature, out TCom ppvCommandSignature)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12CommandSignatureDesc* __dsl_pDesc = pDesc)
            {
                ppvCommandSignature = default;
                return CreateCommandSignature(__dsl_pDesc, pRootSignature, TCom.NativeGuid, ppvCommandSignature.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommittedResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12HeapProperties*, D3D12HeapFlags, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> )(lpVtbl[27]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
        }

        [VtblIndex(27)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource)
        {
            fixed (void** __dsl_ppvResource = ppvResource)
            fixed (Guid* __dsl_riidResource = riidResource)
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
            {
                return (HResult)CreateCommittedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_riidResource, __dsl_ppvResource);
            }
        }

        [VtblIndex(27)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateCommittedResource<TCom>([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
            {
                ppvResource = default;
                return CreateCommittedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateComputePipelineState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12ComputePipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[11]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
        {
            fixed (void** __dsl_ppPipelineState = ppPipelineState)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateComputePipelineState(__dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
            }
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateComputePipelineState<TCom>([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, out TCom ppPipelineState)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
            {
                ppPipelineState = default;
                return CreateComputePipelineState(__dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateConstantBufferView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12ConstantBufferViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, D3D12ConstantBufferViewDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[17]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [VtblIndex(17)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] Ref<D3D12ConstantBufferViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12ConstantBufferViewDesc* __dsl_pDesc = pDesc)
            {
                CreateConstantBufferView(__dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateDepthStencilView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12DepthStencilViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Resource.Native*, D3D12DepthStencilViewDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[21]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pDesc, DestDescriptor);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] Ref<D3D12DepthStencilViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12DepthStencilViewDesc* __dsl_pDesc = pDesc)
            {
                CreateDepthStencilView(pResource, __dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateDescriptorHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12DescriptorHeapDesc* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12DescriptorHeapDesc*, Guid*, void**, HResult> )(lpVtbl[14]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDescriptorHeapDesc, riid, ppvHeap);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] Ref<D3D12DescriptorHeapDesc> pDescriptorHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
        {
            fixed (void** __dsl_ppvHeap = ppvHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12DescriptorHeapDesc* __dsl_pDescriptorHeapDesc = pDescriptorHeapDesc)
            {
                return (HResult)CreateDescriptorHeap(__dsl_pDescriptorHeapDesc, __dsl_riid, __dsl_ppvHeap);
            }
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateDescriptorHeap<TCom>([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] Ref<D3D12DescriptorHeapDesc> pDescriptorHeapDesc, out TCom ppvHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12DescriptorHeapDesc* __dsl_pDescriptorHeapDesc = pDescriptorHeapDesc)
            {
                ppvHeap = default;
                return CreateDescriptorHeap(__dsl_pDescriptorHeapDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateFence"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, ulong, D3D12FenceFlags, Guid*, void**, HResult> )(lpVtbl[36]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), InitialValue, Flags, riid, ppFence);
        }

        [VtblIndex(36)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppFence)
        {
            fixed (void** __dsl_ppFence = ppFence)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)CreateFence(InitialValue, Flags, __dsl_riid, __dsl_ppFence);
            }
        }

        [VtblIndex(36)]
        [Transformed]
        public HResult CreateFence<TCom>([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, out TCom ppFence)
            where TCom : unmanaged, IComVtbl
        {
            ppFence = default;
            return CreateFence(InitialValue, Flags, TCom.NativeGuid, ppFence.GetAddressOf());
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateGraphicsPipelineState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12GraphicsPipelineStateDesc*, Guid*, void**, HResult> )(lpVtbl[10]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppPipelineState);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
        {
            fixed (void** __dsl_ppPipelineState = ppPipelineState)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateGraphicsPipelineState(__dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
            }
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateGraphicsPipelineState<TCom>([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, out TCom ppPipelineState)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
            {
                ppPipelineState = default;
                return CreateGraphicsPipelineState(__dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12HeapDesc*, Guid*, void**, HResult> )(lpVtbl[28]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
        {
            fixed (void** __dsl_ppvHeap = ppvHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12HeapDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateHeap(__dsl_pDesc, __dsl_riid, __dsl_ppvHeap);
            }
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateHeap<TCom>([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pDesc, out TCom ppvHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12HeapDesc* __dsl_pDesc = pDesc)
            {
                ppvHeap = default;
                return CreateHeap(__dsl_pDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreatePlacedResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Heap.Native*, ulong, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> )(lpVtbl[29]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pHeap.LpVtbl, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [VtblIndex(29)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource)
        {
            fixed (void** __dsl_ppvResource = ppvResource)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreatePlacedResource(pHeap, HeapOffset, __dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, __dsl_riid, __dsl_ppvResource);
            }
        }

        [VtblIndex(29)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreatePlacedResource<TCom>(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            {
                ppvResource = default;
                return CreatePlacedResource(pHeap, HeapOffset, __dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateQueryHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12QueryHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12QueryHeapDesc*, Guid*, void**, HResult> )(lpVtbl[39]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppvHeap);
        }

        [VtblIndex(39)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] Ref<D3D12QueryHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
        {
            fixed (void** __dsl_ppvHeap = ppvHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12QueryHeapDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateQueryHeap(__dsl_pDesc, __dsl_riid, __dsl_ppvHeap);
            }
        }

        [VtblIndex(39)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateQueryHeap<TCom>([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] Ref<D3D12QueryHeapDesc> pDesc, out TCom ppvHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12QueryHeapDesc* __dsl_pDesc = pDesc)
            {
                ppvHeap = default;
                return CreateQueryHeap(__dsl_pDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateRenderTargetView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12RenderTargetViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Resource.Native*, D3D12RenderTargetViewDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[20]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pDesc, DestDescriptor);
        }

        [VtblIndex(20)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] Ref<D3D12RenderTargetViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12RenderTargetViewDesc* __dsl_pDesc = pDesc)
            {
                CreateRenderTargetView(pResource, __dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateReservedResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12ResourceDesc*, D3D12ResourceStates, D3D12ClearValue*, Guid*, void**, HResult> )(lpVtbl[30]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
        }

        [VtblIndex(30)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource)
        {
            fixed (void** __dsl_ppvResource = ppvResource)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateReservedResource(__dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, __dsl_riid, __dsl_ppvResource);
            }
        }

        [VtblIndex(30)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateReservedResource<TCom>([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
            fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
            {
                ppvResource = default;
                return CreateReservedResource(__dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateRootSignature"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint, void*, nuint, Guid*, void**, HResult> )(lpVtbl[16]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] Ref pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvRootSignature)
        {
            fixed (void** __dsl_ppvRootSignature = ppvRootSignature)
            fixed (Guid* __dsl_riid = riid)
            fixed (void* __dsl_pBlobWithRootSignature = pBlobWithRootSignature)
            {
                return (HResult)CreateRootSignature(nodeMask, __dsl_pBlobWithRootSignature, blobLengthInBytes, __dsl_riid, __dsl_ppvRootSignature);
            }
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateRootSignature<TCom>(uint nodeMask, [NativeTypeName("const void *")] Ref pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, out TCom ppvRootSignature)
            where TCom : unmanaged, IComVtbl
        {
            fixed (void* __dsl_pBlobWithRootSignature = pBlobWithRootSignature)
            {
                ppvRootSignature = default;
                return CreateRootSignature(nodeMask, __dsl_pBlobWithRootSignature, blobLengthInBytes, TCom.NativeGuid, ppvRootSignature.GetAddressOf());
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateSampler"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12SamplerDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, D3D12SamplerDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[22]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pDesc, DestDescriptor);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] Ref<D3D12SamplerDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12SamplerDesc* __dsl_pDesc = pDesc)
            {
                CreateSampler(__dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateShaderResourceView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12ShaderResourceViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Resource.Native*, D3D12ShaderResourceViewDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[18]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pDesc, DestDescriptor);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] Ref<D3D12ShaderResourceViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12ShaderResourceViewDesc* __dsl_pDesc = pDesc)
            {
                CreateShaderResourceView(pResource, __dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateSharedHandle"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, Handle* pHandle)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, ID3D12DeviceChild.Native*, SECURITY_ATTRIBUTES*, uint, ushort*, Handle*, HResult> )(lpVtbl[31]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pObject.LpVtbl, pAttributes, Access, Name, pHandle);
        }

        [VtblIndex(31)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] Ref<SECURITY_ATTRIBUTES> pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] Ref<ushort> Name, Ref<Handle> pHandle)
        {
            fixed (Handle* __dsl_pHandle = pHandle)
            fixed (ushort* __dsl_Name = Name)
            fixed (SECURITY_ATTRIBUTES* __dsl_pAttributes = pAttributes)
            {
                return (HResult)CreateSharedHandle(pObject, __dsl_pAttributes, Access, __dsl_Name, __dsl_pHandle);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateUnorderedAccessView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12UnorderedAccessViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Resource.Native*, ID3D12Resource.Native*, D3D12UnorderedAccessViewDesc*, D3D12CpuDescriptorHandle, void> )(lpVtbl[19]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pCounterResource.LpVtbl, pDesc, DestDescriptor);
        }

        [VtblIndex(19)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] Ref<D3D12UnorderedAccessViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
        {
            fixed (D3D12UnorderedAccessViewDesc* __dsl_pDesc = pDesc)
            {
                CreateUnorderedAccessView(pResource, pCounterResource, __dsl_pDesc, DestDescriptor);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.Evict"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint, ID3D12Pageable.Native**, HResult> )(lpVtbl[35]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), NumObjects, &ppObjects->LpVtbl);
        }

        [VtblIndex(35)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects)
        {
            fixed (ID3D12Pageable* __dsl_ppObjects = ppObjects)
            {
                return (HResult)Evict(NumObjects, __dsl_ppObjects);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetAdapterLuid"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public LUID GetAdapterLuid()
        {
            LUID result;
            return *((delegate* unmanaged<ID3D12Device.Native*, LUID*, LUID*> )(lpVtbl[43]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), &result);
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetCopyableFootprints"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12PlacedSubresourceFootprint* pLayouts, uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, D3D12ResourceDesc*, uint, uint, ulong, D3D12PlacedSubresourceFootprint*, uint*, ulong*, ulong*, void> )(lpVtbl[38]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
        }

        [VtblIndex(38)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, Ref<D3D12PlacedSubresourceFootprint> pLayouts, Ref<uint> pNumRows, [NativeTypeName("UINT64 *")] Ref<ulong> pRowSizeInBytes, [NativeTypeName("UINT64 *")] Ref<ulong> pTotalBytes)
        {
            fixed (ulong* __dsl_pTotalBytes = pTotalBytes)
            fixed (ulong* __dsl_pRowSizeInBytes = pRowSizeInBytes)
            fixed (uint* __dsl_pNumRows = pNumRows)
            fixed (D3D12PlacedSubresourceFootprint* __dsl_pLayouts = pLayouts)
            fixed (D3D12ResourceDesc* __dsl_pResourceDesc = pResourceDesc)
            {
                GetCopyableFootprints(__dsl_pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, __dsl_pLayouts, __dsl_pNumRows, __dsl_pRowSizeInBytes, __dsl_pTotalBytes);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetCustomHeapProperties"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public D3D12HeapProperties GetCustomHeapProperties(uint nodeMask, D3D12HeapType heapType)
        {
            D3D12HeapProperties result;
            return *((delegate* unmanaged<ID3D12Device.Native*, D3D12HeapProperties*, uint, D3D12HeapType, D3D12HeapProperties*> )(lpVtbl[26]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), &result, nodeMask, heapType);
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetDescriptorHandleIncrementSize"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public uint GetDescriptorHandleIncrementSize(D3D12DescriptorHeapType DescriptorHeapType)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, D3D12DescriptorHeapType, uint> )(lpVtbl[15]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), DescriptorHeapType);
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetDeviceRemovedReason"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HResult GetDeviceRemovedReason()
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, HResult> )(lpVtbl[37]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetNodeCount"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetNodeCount()
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint> )(lpVtbl[7]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.GetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetResourceAllocationInfo"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDescs)
        {
            D3D12ResourceAllocationInfo result;
            return *((delegate* unmanaged<ID3D12Device.Native*, D3D12ResourceAllocationInfo*, uint, uint, D3D12ResourceDesc*, D3D12ResourceAllocationInfo*> )(lpVtbl[25]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), &result, visibleMask, numResourceDescs, pResourceDescs);
        }

        [VtblIndex(25)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDescs)
        {
            fixed (D3D12ResourceDesc* __dsl_pResourceDescs = pResourceDescs)
            {
                return (D3D12ResourceAllocationInfo)GetResourceAllocationInfo(visibleMask, numResourceDescs, __dsl_pResourceDescs);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetResourceTiling"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void GetResourceTiling(ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, D3D12PackedMipInfo* pPackedMipDesc, D3D12TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, D3D12SubresourceTiling* pSubresourceTilingsForNonPackedMips)
        {
            ((delegate* unmanaged<ID3D12Device.Native*, ID3D12Resource.Native*, uint*, D3D12PackedMipInfo*, D3D12TileShape*, uint*, uint, D3D12SubresourceTiling*, void> )(lpVtbl[42]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), pTiledResource.LpVtbl, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
        }

        [VtblIndex(42)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void GetResourceTiling(ID3D12Resource pTiledResource, Ref<uint> pNumTilesForEntireResource, Ref<D3D12PackedMipInfo> pPackedMipDesc, Ref<D3D12TileShape> pStandardTileShapeForNonPackedMips, Ref<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Ref<D3D12SubresourceTiling> pSubresourceTilingsForNonPackedMips)
        {
            fixed (D3D12SubresourceTiling* __dsl_pSubresourceTilingsForNonPackedMips = pSubresourceTilingsForNonPackedMips)
            fixed (uint* __dsl_pNumSubresourceTilings = pNumSubresourceTilings)
            fixed (D3D12TileShape* __dsl_pStandardTileShapeForNonPackedMips = pStandardTileShapeForNonPackedMips)
            fixed (D3D12PackedMipInfo* __dsl_pPackedMipDesc = pPackedMipDesc)
            fixed (uint* __dsl_pNumTilesForEntireResource = pNumTilesForEntireResource)
            {
                GetResourceTiling(pTiledResource, __dsl_pNumTilesForEntireResource, __dsl_pPackedMipDesc, __dsl_pStandardTileShapeForNonPackedMips, __dsl_pNumSubresourceTilings, FirstSubresourceTilingToGet, __dsl_pSubresourceTilingsForNonPackedMips);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.MakeResident"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, uint, ID3D12Pageable.Native**, HResult> )(lpVtbl[34]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), NumObjects, &ppObjects->LpVtbl);
        }

        [VtblIndex(34)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects)
        {
            fixed (ID3D12Pageable* __dsl_ppObjects = ppObjects)
            {
                return (HResult)MakeResident(NumObjects, __dsl_ppObjects);
            }
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.OpenSharedHandle"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, Handle, Guid*, void**, HResult> )(lpVtbl[32]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
        }

        [VtblIndex(32)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObj)
        {
            fixed (void** __dsl_ppvObj = ppvObj)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)OpenSharedHandle(NTHandle, __dsl_riid, __dsl_ppvObj);
            }
        }

        [VtblIndex(32)]
        [Transformed]
        public HResult OpenSharedHandle<TCom>(Handle NTHandle, out TCom ppvObj)
            where TCom : unmanaged, IComVtbl
        {
            ppvObj = default;
            return OpenSharedHandle(NTHandle, TCom.NativeGuid, ppvObj.GetAddressOf());
        }

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.OpenSharedHandleByName"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, Handle* pNTHandle)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, ushort*, uint, Handle*, HResult> )(lpVtbl[33]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), Name, Access, pNTHandle);
        }

        [VtblIndex(33)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] Ref<ushort> Name, [NativeTypeName("DWORD")] uint Access, Ref<Handle> pNTHandle)
        {
            fixed (Handle* __dsl_pNTHandle = pNTHandle)
            fixed (ushort* __dsl_Name = Name)
            {
                return (HResult)OpenSharedHandleByName(__dsl_Name, Access, __dsl_pNTHandle);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12Device.Native*, uint> )(lpVtbl[2]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12Object.SetName"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult SetName([NativeTypeName("LPCWSTR")] ushort* Name)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), Name);
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
            return ((delegate* unmanaged<ID3D12Device.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12Device.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.SetStablePowerState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HResult SetStablePowerState([NativeTypeName("BOOL")] MaybeBool<int> Enable)
        {
            return ((delegate* unmanaged<ID3D12Device.Native*, MaybeBool<int>, HResult> )(lpVtbl[40]))((ID3D12Device.Native*)Unsafe.AsPointer(ref this), Enable);
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12Device"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Device(Ptr3D vtbl) => LpVtbl = (ID3D12Device.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12Device"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12Device(Ptr<ID3D12Device.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12Device.Native"/> to <see cref = "ID3D12Device"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device.Native"/> instance to be converted </param>
    public static implicit operator ID3D12Device(ID3D12Device.Native* value) => new ID3D12Device((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Device"/> to <see cref = "ID3D12Device.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device"/> instance to be converted </param>
    public static implicit operator ID3D12Device.Native*(ID3D12Device value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12Device"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12Device(Ptr3D value) => new ID3D12Device(value);
    /// <summary>casts <see cref = "ID3D12Device"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Device"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12Device value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12Device"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12Device(Ptr<ID3D12Device.Native> value) => new ID3D12Device(value);
    /// <summary>casts <see cref = "ID3D12Device"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Device"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12Device.Native>(ID3D12Device value) => (Ptr<ID3D12Device.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12Device"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12Device(void*** value) => new ID3D12Device((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12Device"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12Device"/> instance to be converted </param>
    public static implicit operator void***(ID3D12Device value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12Device"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12Device(nuint value) => new ID3D12Device((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12Device"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12Device"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12Device value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CheckFeatureSupport"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult CheckFeatureSupport(D3D12Feature Feature, void* pFeatureSupportData, uint FeatureSupportDataSize) => LpVtbl->CheckFeatureSupport(Feature, pFeatureSupportData, FeatureSupportDataSize);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckFeatureSupport(D3D12Feature Feature, Ref pFeatureSupportData, uint FeatureSupportDataSize)
    {
        fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
        {
            return (HResult)CheckFeatureSupport(Feature, __dsl_pFeatureSupportData, FeatureSupportDataSize);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CopyDescriptors"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] uint* pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType) => LpVtbl->CopyDescriptors(NumDestDescriptorRanges, pDestDescriptorRangeStarts, pDestDescriptorRangeSizes, NumSrcDescriptorRanges, pSrcDescriptorRangeStarts, pSrcDescriptorRangeSizes, DescriptorHeapsType);
    [VtblIndex(23)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CopyDescriptors(uint NumDestDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDestDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pDestDescriptorRangeSizes, uint NumSrcDescriptorRanges, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pSrcDescriptorRangeStarts, [NativeTypeName("const UINT *")] Ref<uint> pSrcDescriptorRangeSizes, D3D12DescriptorHeapType DescriptorHeapsType)
    {
        fixed (uint* __dsl_pSrcDescriptorRangeSizes = pSrcDescriptorRangeSizes)
        fixed (D3D12CpuDescriptorHandle* __dsl_pSrcDescriptorRangeStarts = pSrcDescriptorRangeStarts)
        fixed (uint* __dsl_pDestDescriptorRangeSizes = pDestDescriptorRangeSizes)
        fixed (D3D12CpuDescriptorHandle* __dsl_pDestDescriptorRangeStarts = pDestDescriptorRangeStarts)
        {
            CopyDescriptors(NumDestDescriptorRanges, __dsl_pDestDescriptorRangeStarts, __dsl_pDestDescriptorRangeSizes, NumSrcDescriptorRanges, __dsl_pSrcDescriptorRangeStarts, __dsl_pSrcDescriptorRangeSizes, DescriptorHeapsType);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CopyDescriptorsSimple"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void CopyDescriptorsSimple(uint NumDescriptors, D3D12CpuDescriptorHandle DestDescriptorRangeStart, D3D12CpuDescriptorHandle SrcDescriptorRangeStart, D3D12DescriptorHeapType DescriptorHeapsType) => LpVtbl->CopyDescriptorsSimple(NumDescriptors, DestDescriptorRangeStart, SrcDescriptorRangeStart, DescriptorHeapsType);
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandAllocator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandAllocator) => LpVtbl->CreateCommandAllocator(type, riid, ppCommandAllocator);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandAllocator(D3D12CommandListType type, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandAllocator)
    {
        fixed (void** __dsl_ppCommandAllocator = ppCommandAllocator)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateCommandAllocator(type, __dsl_riid, __dsl_ppCommandAllocator);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    public HResult CreateCommandAllocator<TCom>(D3D12CommandListType type, out TCom ppCommandAllocator)
        where TCom : unmanaged, IComVtbl
    {
        ppCommandAllocator = default;
        return CreateCommandAllocator(type, TCom.NativeGuid, ppCommandAllocator.GetAddressOf());
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandList) => LpVtbl->CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, riid, ppCommandList);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandList(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandList)
    {
        fixed (void** __dsl_ppCommandList = ppCommandList)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, __dsl_riid, __dsl_ppCommandList);
        }
    }

    [VtblIndex(12)]
    [Transformed]
    public HResult CreateCommandList<TCom>(uint nodeMask, D3D12CommandListType type, ID3D12CommandAllocator pCommandAllocator, ID3D12PipelineState pInitialState, out TCom ppCommandList)
        where TCom : unmanaged, IComVtbl
    {
        ppCommandList = default;
        return CreateCommandList(nodeMask, type, pCommandAllocator, pInitialState, TCom.NativeGuid, ppCommandList.GetAddressOf());
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandQueue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] D3D12CommandQueueDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppCommandQueue) => LpVtbl->CreateCommandQueue(pDesc, riid, ppCommandQueue);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandQueue([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] Ref<D3D12CommandQueueDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppCommandQueue)
    {
        fixed (void** __dsl_ppCommandQueue = ppCommandQueue)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12CommandQueueDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateCommandQueue(__dsl_pDesc, __dsl_riid, __dsl_ppCommandQueue);
        }
    }

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandQueue<TCom>([NativeTypeName("const D3D12_COMMAND_QUEUE_DESC *")] Ref<D3D12CommandQueueDesc> pDesc, out TCom ppCommandQueue)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12CommandQueueDesc* __dsl_pDesc = pDesc)
        {
            ppCommandQueue = default;
            return CreateCommandQueue(__dsl_pDesc, TCom.NativeGuid, ppCommandQueue.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommandSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] D3D12CommandSignatureDesc* pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Guid* riid, void** ppvCommandSignature) => LpVtbl->CreateCommandSignature(pDesc, pRootSignature, riid, ppvCommandSignature);
    [VtblIndex(41)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandSignature([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] Ref<D3D12CommandSignatureDesc> pDesc, ID3D12RootSignature pRootSignature, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvCommandSignature)
    {
        fixed (void** __dsl_ppvCommandSignature = ppvCommandSignature)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12CommandSignatureDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateCommandSignature(__dsl_pDesc, pRootSignature, __dsl_riid, __dsl_ppvCommandSignature);
        }
    }

    [VtblIndex(41)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommandSignature<TCom>([NativeTypeName("const D3D12_COMMAND_SIGNATURE_DESC *")] Ref<D3D12CommandSignatureDesc> pDesc, ID3D12RootSignature pRootSignature, out TCom ppvCommandSignature)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12CommandSignatureDesc* __dsl_pDesc = pDesc)
        {
            ppvCommandSignature = default;
            return CreateCommandSignature(__dsl_pDesc, pRootSignature, TCom.NativeGuid, ppvCommandSignature.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateCommittedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] D3D12HeapProperties* pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riidResource, void** ppvResource) => LpVtbl->CreateCommittedResource(pHeapProperties, HeapFlags, pDesc, InitialResourceState, pOptimizedClearValue, riidResource, ppvResource);
    [VtblIndex(27)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommittedResource([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riidResource, Ref2D ppvResource)
    {
        fixed (void** __dsl_ppvResource = ppvResource)
        fixed (Guid* __dsl_riidResource = riidResource)
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
        {
            return (HResult)CreateCommittedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, __dsl_riidResource, __dsl_ppvResource);
        }
    }

    [VtblIndex(27)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateCommittedResource<TCom>([NativeTypeName("const D3D12_HEAP_PROPERTIES *")] Ref<D3D12HeapProperties> pHeapProperties, D3D12HeapFlags HeapFlags, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialResourceState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        fixed (D3D12HeapProperties* __dsl_pHeapProperties = pHeapProperties)
        {
            ppvResource = default;
            return CreateCommittedResource(__dsl_pHeapProperties, HeapFlags, __dsl_pDesc, InitialResourceState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateComputePipelineState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] D3D12ComputePipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState) => LpVtbl->CreateComputePipelineState(pDesc, riid, ppPipelineState);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateComputePipelineState([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
    {
        fixed (void** __dsl_ppPipelineState = ppPipelineState)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateComputePipelineState(__dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
        }
    }

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateComputePipelineState<TCom>([NativeTypeName("const D3D12_COMPUTE_PIPELINE_STATE_DESC *")] Ref<D3D12ComputePipelineStateDesc> pDesc, out TCom ppPipelineState)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12ComputePipelineStateDesc* __dsl_pDesc = pDesc)
        {
            ppPipelineState = default;
            return CreateComputePipelineState(__dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateConstantBufferView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] D3D12ConstantBufferViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateConstantBufferView(pDesc, DestDescriptor);
    [VtblIndex(17)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateConstantBufferView([NativeTypeName("const D3D12_CONSTANT_BUFFER_VIEW_DESC *")] Ref<D3D12ConstantBufferViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12ConstantBufferViewDesc* __dsl_pDesc = pDesc)
        {
            CreateConstantBufferView(__dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateDepthStencilView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] D3D12DepthStencilViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateDepthStencilView(pResource, pDesc, DestDescriptor);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateDepthStencilView(ID3D12Resource pResource, [NativeTypeName("const D3D12_DEPTH_STENCIL_VIEW_DESC *")] Ref<D3D12DepthStencilViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12DepthStencilViewDesc* __dsl_pDesc = pDesc)
        {
            CreateDepthStencilView(pResource, __dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateDescriptorHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] D3D12DescriptorHeapDesc* pDescriptorHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap) => LpVtbl->CreateDescriptorHeap(pDescriptorHeapDesc, riid, ppvHeap);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDescriptorHeap([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] Ref<D3D12DescriptorHeapDesc> pDescriptorHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
    {
        fixed (void** __dsl_ppvHeap = ppvHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12DescriptorHeapDesc* __dsl_pDescriptorHeapDesc = pDescriptorHeapDesc)
        {
            return (HResult)CreateDescriptorHeap(__dsl_pDescriptorHeapDesc, __dsl_riid, __dsl_ppvHeap);
        }
    }

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateDescriptorHeap<TCom>([NativeTypeName("const D3D12_DESCRIPTOR_HEAP_DESC *")] Ref<D3D12DescriptorHeapDesc> pDescriptorHeapDesc, out TCom ppvHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12DescriptorHeapDesc* __dsl_pDescriptorHeapDesc = pDescriptorHeapDesc)
        {
            ppvHeap = default;
            return CreateDescriptorHeap(__dsl_pDescriptorHeapDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateFence"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Guid* riid, void** ppFence) => LpVtbl->CreateFence(InitialValue, Flags, riid, ppFence);
    [VtblIndex(36)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateFence([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppFence)
    {
        fixed (void** __dsl_ppFence = ppFence)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)CreateFence(InitialValue, Flags, __dsl_riid, __dsl_ppFence);
        }
    }

    [VtblIndex(36)]
    [Transformed]
    public HResult CreateFence<TCom>([NativeTypeName("UINT64")] ulong InitialValue, D3D12FenceFlags Flags, out TCom ppFence)
        where TCom : unmanaged, IComVtbl
    {
        ppFence = default;
        return CreateFence(InitialValue, Flags, TCom.NativeGuid, ppFence.GetAddressOf());
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateGraphicsPipelineState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] D3D12GraphicsPipelineStateDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppPipelineState) => LpVtbl->CreateGraphicsPipelineState(pDesc, riid, ppPipelineState);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateGraphicsPipelineState([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppPipelineState)
    {
        fixed (void** __dsl_ppPipelineState = ppPipelineState)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateGraphicsPipelineState(__dsl_pDesc, __dsl_riid, __dsl_ppPipelineState);
        }
    }

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateGraphicsPipelineState<TCom>([NativeTypeName("const D3D12_GRAPHICS_PIPELINE_STATE_DESC *")] Ref<D3D12GraphicsPipelineStateDesc> pDesc, out TCom ppPipelineState)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12GraphicsPipelineStateDesc* __dsl_pDesc = pDesc)
        {
            ppPipelineState = default;
            return CreateGraphicsPipelineState(__dsl_pDesc, TCom.NativeGuid, ppPipelineState.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] D3D12HeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap) => LpVtbl->CreateHeap(pDesc, riid, ppvHeap);
    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateHeap([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
    {
        fixed (void** __dsl_ppvHeap = ppvHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12HeapDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateHeap(__dsl_pDesc, __dsl_riid, __dsl_ppvHeap);
        }
    }

    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateHeap<TCom>([NativeTypeName("const D3D12_HEAP_DESC *")] Ref<D3D12HeapDesc> pDesc, out TCom ppvHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12HeapDesc* __dsl_pDesc = pDesc)
        {
            ppvHeap = default;
            return CreateHeap(__dsl_pDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreatePlacedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource) => LpVtbl->CreatePlacedResource(pHeap, HeapOffset, pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    [VtblIndex(29)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreatePlacedResource(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource)
    {
        fixed (void** __dsl_ppvResource = ppvResource)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreatePlacedResource(pHeap, HeapOffset, __dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, __dsl_riid, __dsl_ppvResource);
        }
    }

    [VtblIndex(29)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreatePlacedResource<TCom>(ID3D12Heap pHeap, [NativeTypeName("UINT64")] ulong HeapOffset, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        {
            ppvResource = default;
            return CreatePlacedResource(pHeap, HeapOffset, __dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateQueryHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] D3D12QueryHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppvHeap) => LpVtbl->CreateQueryHeap(pDesc, riid, ppvHeap);
    [VtblIndex(39)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateQueryHeap([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] Ref<D3D12QueryHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvHeap)
    {
        fixed (void** __dsl_ppvHeap = ppvHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12QueryHeapDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateQueryHeap(__dsl_pDesc, __dsl_riid, __dsl_ppvHeap);
        }
    }

    [VtblIndex(39)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateQueryHeap<TCom>([NativeTypeName("const D3D12_QUERY_HEAP_DESC *")] Ref<D3D12QueryHeapDesc> pDesc, out TCom ppvHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12QueryHeapDesc* __dsl_pDesc = pDesc)
        {
            ppvHeap = default;
            return CreateQueryHeap(__dsl_pDesc, TCom.NativeGuid, ppvHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateRenderTargetView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] D3D12RenderTargetViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateRenderTargetView(pResource, pDesc, DestDescriptor);
    [VtblIndex(20)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateRenderTargetView(ID3D12Resource pResource, [NativeTypeName("const D3D12_RENDER_TARGET_VIEW_DESC *")] Ref<D3D12RenderTargetViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12RenderTargetViewDesc* __dsl_pDesc = pDesc)
        {
            CreateRenderTargetView(pResource, __dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateReservedResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] D3D12ClearValue* pOptimizedClearValue, [NativeTypeName("const IID &")] Guid* riid, void** ppvResource) => LpVtbl->CreateReservedResource(pDesc, InitialState, pOptimizedClearValue, riid, ppvResource);
    [VtblIndex(30)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateReservedResource([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvResource)
    {
        fixed (void** __dsl_ppvResource = ppvResource)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateReservedResource(__dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, __dsl_riid, __dsl_ppvResource);
        }
    }

    [VtblIndex(30)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateReservedResource<TCom>([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pDesc, D3D12ResourceStates InitialState, [NativeTypeName("const D3D12_CLEAR_VALUE *")] Ref<D3D12ClearValue> pOptimizedClearValue, out TCom ppvResource)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12ClearValue* __dsl_pOptimizedClearValue = pOptimizedClearValue)
        fixed (D3D12ResourceDesc* __dsl_pDesc = pDesc)
        {
            ppvResource = default;
            return CreateReservedResource(__dsl_pDesc, InitialState, __dsl_pOptimizedClearValue, TCom.NativeGuid, ppvResource.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] void* pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Guid* riid, void** ppvRootSignature) => LpVtbl->CreateRootSignature(nodeMask, pBlobWithRootSignature, blobLengthInBytes, riid, ppvRootSignature);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateRootSignature(uint nodeMask, [NativeTypeName("const void *")] Ref pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvRootSignature)
    {
        fixed (void** __dsl_ppvRootSignature = ppvRootSignature)
        fixed (Guid* __dsl_riid = riid)
        fixed (void* __dsl_pBlobWithRootSignature = pBlobWithRootSignature)
        {
            return (HResult)CreateRootSignature(nodeMask, __dsl_pBlobWithRootSignature, blobLengthInBytes, __dsl_riid, __dsl_ppvRootSignature);
        }
    }

    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateRootSignature<TCom>(uint nodeMask, [NativeTypeName("const void *")] Ref pBlobWithRootSignature, [NativeTypeName("SIZE_T")] nuint blobLengthInBytes, out TCom ppvRootSignature)
        where TCom : unmanaged, IComVtbl
    {
        fixed (void* __dsl_pBlobWithRootSignature = pBlobWithRootSignature)
        {
            ppvRootSignature = default;
            return CreateRootSignature(nodeMask, __dsl_pBlobWithRootSignature, blobLengthInBytes, TCom.NativeGuid, ppvRootSignature.GetAddressOf());
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateSampler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] D3D12SamplerDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateSampler(pDesc, DestDescriptor);
    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateSampler([NativeTypeName("const D3D12_SAMPLER_DESC *")] Ref<D3D12SamplerDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12SamplerDesc* __dsl_pDesc = pDesc)
        {
            CreateSampler(__dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateShaderResourceView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] D3D12ShaderResourceViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateShaderResourceView(pResource, pDesc, DestDescriptor);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateShaderResourceView(ID3D12Resource pResource, [NativeTypeName("const D3D12_SHADER_RESOURCE_VIEW_DESC *")] Ref<D3D12ShaderResourceViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12ShaderResourceViewDesc* __dsl_pDesc = pDesc)
        {
            CreateShaderResourceView(pResource, __dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] ushort* Name, Handle* pHandle) => LpVtbl->CreateSharedHandle(pObject, pAttributes, Access, Name, pHandle);
    [VtblIndex(31)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateSharedHandle(ID3D12DeviceChild pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] Ref<SECURITY_ATTRIBUTES> pAttributes, [NativeTypeName("DWORD")] uint Access, [NativeTypeName("LPCWSTR")] Ref<ushort> Name, Ref<Handle> pHandle)
    {
        fixed (Handle* __dsl_pHandle = pHandle)
        fixed (ushort* __dsl_Name = Name)
        fixed (SECURITY_ATTRIBUTES* __dsl_pAttributes = pAttributes)
        {
            return (HResult)CreateSharedHandle(pObject, __dsl_pAttributes, Access, __dsl_Name, __dsl_pHandle);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.CreateUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] D3D12UnorderedAccessViewDesc* pDesc, D3D12CpuDescriptorHandle DestDescriptor) => LpVtbl->CreateUnorderedAccessView(pResource, pCounterResource, pDesc, DestDescriptor);
    [VtblIndex(19)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CreateUnorderedAccessView(ID3D12Resource pResource, ID3D12Resource pCounterResource, [NativeTypeName("const D3D12_UNORDERED_ACCESS_VIEW_DESC *")] Ref<D3D12UnorderedAccessViewDesc> pDesc, D3D12CpuDescriptorHandle DestDescriptor)
    {
        fixed (D3D12UnorderedAccessViewDesc* __dsl_pDesc = pDesc)
        {
            CreateUnorderedAccessView(pResource, pCounterResource, __dsl_pDesc, DestDescriptor);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.Evict"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects) => LpVtbl->Evict(NumObjects, ppObjects);
    [VtblIndex(35)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Evict(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects)
    {
        fixed (ID3D12Pageable* __dsl_ppObjects = ppObjects)
        {
            return (HResult)Evict(NumObjects, __dsl_ppObjects);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetAdapterLuid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public LUID GetAdapterLuid() => LpVtbl->GetAdapterLuid();
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetCopyableFootprints"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, D3D12PlacedSubresourceFootprint* pLayouts, uint* pNumRows, [NativeTypeName("UINT64 *")] ulong* pRowSizeInBytes, [NativeTypeName("UINT64 *")] ulong* pTotalBytes) => LpVtbl->GetCopyableFootprints(pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, pLayouts, pNumRows, pRowSizeInBytes, pTotalBytes);
    [VtblIndex(38)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GetCopyableFootprints([NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDesc, uint FirstSubresource, uint NumSubresources, [NativeTypeName("UINT64")] ulong BaseOffset, Ref<D3D12PlacedSubresourceFootprint> pLayouts, Ref<uint> pNumRows, [NativeTypeName("UINT64 *")] Ref<ulong> pRowSizeInBytes, [NativeTypeName("UINT64 *")] Ref<ulong> pTotalBytes)
    {
        fixed (ulong* __dsl_pTotalBytes = pTotalBytes)
        fixed (ulong* __dsl_pRowSizeInBytes = pRowSizeInBytes)
        fixed (uint* __dsl_pNumRows = pNumRows)
        fixed (D3D12PlacedSubresourceFootprint* __dsl_pLayouts = pLayouts)
        fixed (D3D12ResourceDesc* __dsl_pResourceDesc = pResourceDesc)
        {
            GetCopyableFootprints(__dsl_pResourceDesc, FirstSubresource, NumSubresources, BaseOffset, __dsl_pLayouts, __dsl_pNumRows, __dsl_pRowSizeInBytes, __dsl_pTotalBytes);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetCustomHeapProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public D3D12HeapProperties GetCustomHeapProperties(uint nodeMask, D3D12HeapType heapType) => LpVtbl->GetCustomHeapProperties(nodeMask, heapType);
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetDescriptorHandleIncrementSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public uint GetDescriptorHandleIncrementSize(D3D12DescriptorHeapType DescriptorHeapType) => LpVtbl->GetDescriptorHandleIncrementSize(DescriptorHeapType);
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetDeviceRemovedReason"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HResult GetDeviceRemovedReason() => LpVtbl->GetDeviceRemovedReason();
    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetNodeCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public uint GetNodeCount() => LpVtbl->GetNodeCount();
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

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetResourceAllocationInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] D3D12ResourceDesc* pResourceDescs) => LpVtbl->GetResourceAllocationInfo(visibleMask, numResourceDescs, pResourceDescs);
    [VtblIndex(25)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public D3D12ResourceAllocationInfo GetResourceAllocationInfo(uint visibleMask, uint numResourceDescs, [NativeTypeName("const D3D12_RESOURCE_DESC *")] Ref<D3D12ResourceDesc> pResourceDescs)
    {
        fixed (D3D12ResourceDesc* __dsl_pResourceDescs = pResourceDescs)
        {
            return (D3D12ResourceAllocationInfo)GetResourceAllocationInfo(visibleMask, numResourceDescs, __dsl_pResourceDescs);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.GetResourceTiling"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void GetResourceTiling(ID3D12Resource pTiledResource, uint* pNumTilesForEntireResource, D3D12PackedMipInfo* pPackedMipDesc, D3D12TileShape* pStandardTileShapeForNonPackedMips, uint* pNumSubresourceTilings, uint FirstSubresourceTilingToGet, D3D12SubresourceTiling* pSubresourceTilingsForNonPackedMips) => LpVtbl->GetResourceTiling(pTiledResource, pNumTilesForEntireResource, pPackedMipDesc, pStandardTileShapeForNonPackedMips, pNumSubresourceTilings, FirstSubresourceTilingToGet, pSubresourceTilingsForNonPackedMips);
    [VtblIndex(42)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void GetResourceTiling(ID3D12Resource pTiledResource, Ref<uint> pNumTilesForEntireResource, Ref<D3D12PackedMipInfo> pPackedMipDesc, Ref<D3D12TileShape> pStandardTileShapeForNonPackedMips, Ref<uint> pNumSubresourceTilings, uint FirstSubresourceTilingToGet, Ref<D3D12SubresourceTiling> pSubresourceTilingsForNonPackedMips)
    {
        fixed (D3D12SubresourceTiling* __dsl_pSubresourceTilingsForNonPackedMips = pSubresourceTilingsForNonPackedMips)
        fixed (uint* __dsl_pNumSubresourceTilings = pNumSubresourceTilings)
        fixed (D3D12TileShape* __dsl_pStandardTileShapeForNonPackedMips = pStandardTileShapeForNonPackedMips)
        fixed (D3D12PackedMipInfo* __dsl_pPackedMipDesc = pPackedMipDesc)
        fixed (uint* __dsl_pNumTilesForEntireResource = pNumTilesForEntireResource)
        {
            GetResourceTiling(pTiledResource, __dsl_pNumTilesForEntireResource, __dsl_pPackedMipDesc, __dsl_pStandardTileShapeForNonPackedMips, __dsl_pNumSubresourceTilings, FirstSubresourceTilingToGet, __dsl_pSubresourceTilingsForNonPackedMips);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.MakeResident"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] ID3D12Pageable* ppObjects) => LpVtbl->MakeResident(NumObjects, ppObjects);
    [VtblIndex(34)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult MakeResident(uint NumObjects, [NativeTypeName("ID3D12Pageable *const *")] Ref<ID3D12Pageable> ppObjects)
    {
        fixed (ID3D12Pageable* __dsl_ppObjects = ppObjects)
        {
            return (HResult)MakeResident(NumObjects, __dsl_ppObjects);
        }
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.OpenSharedHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj) => LpVtbl->OpenSharedHandle(NTHandle, riid, ppvObj);
    [VtblIndex(32)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult OpenSharedHandle(Handle NTHandle, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObj)
    {
        fixed (void** __dsl_ppvObj = ppvObj)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)OpenSharedHandle(NTHandle, __dsl_riid, __dsl_ppvObj);
        }
    }

    [VtblIndex(32)]
    [Transformed]
    public HResult OpenSharedHandle<TCom>(Handle NTHandle, out TCom ppvObj)
        where TCom : unmanaged, IComVtbl
    {
        ppvObj = default;
        return OpenSharedHandle(NTHandle, TCom.NativeGuid, ppvObj.GetAddressOf());
    }

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.OpenSharedHandleByName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] ushort* Name, [NativeTypeName("DWORD")] uint Access, Handle* pNTHandle) => LpVtbl->OpenSharedHandleByName(Name, Access, pNTHandle);
    [VtblIndex(33)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult OpenSharedHandleByName([NativeTypeName("LPCWSTR")] Ref<ushort> Name, [NativeTypeName("DWORD")] uint Access, Ref<Handle> pNTHandle)
    {
        fixed (Handle* __dsl_pNTHandle = pNTHandle)
        fixed (ushort* __dsl_Name = Name)
        {
            return (HResult)OpenSharedHandleByName(__dsl_Name, Access, __dsl_pNTHandle);
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

    /// <include file='ID3D12Device.xml' path='doc/member[@name="ID3D12Device.SetStablePowerState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HResult SetStablePowerState([NativeTypeName("BOOL")] MaybeBool<int> Enable) => LpVtbl->SetStablePowerState(Enable);
}