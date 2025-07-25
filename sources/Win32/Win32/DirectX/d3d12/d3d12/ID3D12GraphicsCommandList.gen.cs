// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList"]/*'/>
[Guid("5B160D0F-AC1B-4185-8BA8-B3AE42A5A455")]
[NativeTypeName("struct ID3D12GraphicsCommandList : ID3D12CommandList")]
[NativeInheritance("ID3D12CommandList")]
public unsafe partial struct ID3D12GraphicsCommandList : ID3D12GraphicsCommandList.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12GraphicsCommandList));

    public interface Interface : ID3D12CommandList.Interface
    {
        [VtblIndex(57)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(57)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(52)]
        void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index);
        [VtblIndex(47)]
        void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(47)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects);
        [VtblIndex(48)]
        void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(48)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] Ref<float> ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects);
        [VtblIndex(11)]
        void ClearState(ID3D12PipelineState pPipelineState);
        [VtblIndex(50)]
        void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] float* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(50)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] Ref<float> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects);
        [VtblIndex(49)]
        void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] uint* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(49)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] Ref<uint> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects);
        [VtblIndex(9)]
        HResult Close();
        [VtblIndex(15)]
        void CopyBufferRegion(ID3D12Resource pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes);
        [VtblIndex(17)]
        void CopyResource(ID3D12Resource pDstResource, ID3D12Resource pSrcResource);
        [VtblIndex(16)]
        void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pSrcBox);
        [VtblIndex(16)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pSrc, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pSrcBox);
        [VtblIndex(18)]
        void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags);
        [VtblIndex(18)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags);
        [VtblIndex(51)]
        void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion);
        [VtblIndex(51)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion);
        [VtblIndex(14)]
        void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ);
        [VtblIndex(13)]
        void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation);
        [VtblIndex(12)]
        void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation);
        [VtblIndex(58)]
        void EndEvent();
        [VtblIndex(53)]
        void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index);
        [VtblIndex(27)]
        void ExecuteBundle(ID3D12GraphicsCommandList pCommandList);
        [VtblIndex(59)]
        void ExecuteIndirect(ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, ID3D12Resource pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset);
        [VtblIndex(43)]
        void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12IndexBufferView* pView);
        [VtblIndex(43)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] Ref<D3D12IndexBufferView> pView);
        [VtblIndex(20)]
        void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3DPrimitiveTopology PrimitiveTopology);
        [VtblIndex(44)]
        void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12VertexBufferView* pViews);
        [VtblIndex(44)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] Ref<D3D12VertexBufferView> pViews);
        [VtblIndex(23)]
        void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor);
        [VtblIndex(23)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] Ref<float> BlendFactor);
        [VtblIndex(46)]
        void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDepthStencilDescriptor);
        [VtblIndex(46)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDepthStencilDescriptor);
        [VtblIndex(24)]
        void OMSetStencilRef(uint StencilRef);
        [VtblIndex(10)]
        HResult Reset(ID3D12CommandAllocator pAllocator, ID3D12PipelineState pInitialState);
        [VtblIndex(54)]
        void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset);
        [VtblIndex(19)]
        void ResolveSubresource(ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource pSrcResource, uint SrcSubresource, DxgiFormat Format);
        [VtblIndex(26)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers);
        [VtblIndex(26)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers);
        [VtblIndex(22)]
        void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects);
        [VtblIndex(22)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects);
        [VtblIndex(21)]
        void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12Viewport* pViewports);
        [VtblIndex(21)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] Ref<D3D12Viewport> pViewports);
        [VtblIndex(33)]
        void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(35)]
        void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(35)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(37)]
        void SetComputeRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(31)]
        void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor);
        [VtblIndex(39)]
        void SetComputeRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(29)]
        void SetComputeRootSignature(ID3D12RootSignature pRootSignature);
        [VtblIndex(41)]
        void SetComputeRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(28)]
        void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap* ppDescriptorHeaps);
        [VtblIndex(28)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] Ref<ID3D12DescriptorHeap> ppDescriptorHeaps);
        [VtblIndex(34)]
        void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(36)]
        void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(36)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues);
        [VtblIndex(38)]
        void SetGraphicsRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(32)]
        void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor);
        [VtblIndex(40)]
        void SetGraphicsRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(30)]
        void SetGraphicsRootSignature(ID3D12RootSignature pRootSignature);
        [VtblIndex(42)]
        void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation);
        [VtblIndex(56)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size);
        [VtblIndex(56)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SetMarker(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size);
        [VtblIndex(25)]
        void SetPipelineState(ID3D12PipelineState pPipelineState);
        [VtblIndex(55)]
        void SetPredication(ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12PredicationOp Operation);
        [VtblIndex(45)]
        void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12StreamOutputBufferView* pViews);
        [VtblIndex(45)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] Ref<D3D12StreamOutputBufferView> pViews);
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList"]/*'/>
    [Guid("5B160D0F-AC1B-4185-8BA8-B3AE42A5A455")]
    [NativeTypeName("struct ID3D12GraphicsCommandList : ID3D12CommandList")]
    [NativeInheritance("ID3D12CommandList")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12GraphicsCommandList));

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
            [NativeTypeName("HRESULT (ID3D12CommandAllocator *, ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12CommandAllocator.Native*, ID3D12PipelineState.Native*, HResult> Reset;
            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12PipelineState.Native*, void> ClearState;
            [NativeTypeName("void (UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, uint, void> DrawInstanced;
            [NativeTypeName("void (UINT, UINT, UINT, INT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, int, uint, void> DrawIndexedInstanced;
            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, void> Dispatch;
            [NativeTypeName("void (ID3D12Resource *, UINT64, ID3D12Resource *, UINT64, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, ulong, ID3D12Resource.Native*, ulong, ulong, void> CopyBufferRegion;
            [NativeTypeName("void (const D3D12_TEXTURE_COPY_LOCATION *, UINT, UINT, UINT, const D3D12_TEXTURE_COPY_LOCATION *, const D3D12_BOX *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12TextureCopyLocation*, uint, uint, uint, D3D12TextureCopyLocation*, D3D12Box*, void> CopyTextureRegion;
            [NativeTypeName("void (ID3D12Resource *, ID3D12Resource *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, ID3D12Resource.Native*, void> CopyResource;
            [NativeTypeName("void (ID3D12Resource *, const D3D12_TILED_RESOURCE_COORDINATE *, const D3D12_TILE_REGION_SIZE *, ID3D12Resource *, UINT64, D3D12_TILE_COPY_FLAGS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, ID3D12Resource.Native*, ulong, D3D12TileCopyFlags, void> CopyTiles;
            [NativeTypeName("void (ID3D12Resource *, UINT, ID3D12Resource *, UINT, DXGI_FORMAT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12Resource.Native*, uint, ID3D12Resource.Native*, uint, DxgiFormat, void> ResolveSubresource;
            [NativeTypeName("void (D3D12_PRIMITIVE_TOPOLOGY) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3DPrimitiveTopology, void> IASetPrimitiveTopology;
            [NativeTypeName("void (UINT, const D3D12_VIEWPORT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12Viewport*, void> RSSetViewports;
            [NativeTypeName("void (UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, RECT*, void> RSSetScissorRects;
            [NativeTypeName("void (const FLOAT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, float*, void> OMSetBlendFactor;
            [NativeTypeName("void (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, void> OMSetStencilRef;
            [NativeTypeName("void (ID3D12PipelineState *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12PipelineState.Native*, void> SetPipelineState;
            [NativeTypeName("void (UINT, const D3D12_RESOURCE_BARRIER *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12ResourceBarrier*, void> ResourceBarrier;
            [NativeTypeName("void (ID3D12GraphicsCommandList *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12GraphicsCommandList.Native*, void> ExecuteBundle;
            [NativeTypeName("void (UINT, ID3D12DescriptorHeap *const *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ID3D12DescriptorHeap.Native**, void> SetDescriptorHeaps;
            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12RootSignature.Native*, void> SetComputeRootSignature;
            [NativeTypeName("void (ID3D12RootSignature *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12RootSignature.Native*, void> SetGraphicsRootSignature;
            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12GpuDescriptorHandle, void> SetComputeRootDescriptorTable;
            [NativeTypeName("void (UINT, D3D12_GPU_DESCRIPTOR_HANDLE) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12GpuDescriptorHandle, void> SetGraphicsRootDescriptorTable;
            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetComputeRoot32BitConstant;
            [NativeTypeName("void (UINT, UINT, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, uint, void> SetGraphicsRoot32BitConstant;
            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, void*, uint, void> SetComputeRoot32BitConstants;
            [NativeTypeName("void (UINT, UINT, const void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, void*, uint, void> SetGraphicsRoot32BitConstants;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootConstantBufferView;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootConstantBufferView;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootShaderResourceView;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootShaderResourceView;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetComputeRootUnorderedAccessView;
            [NativeTypeName("void (UINT, D3D12_GPU_VIRTUAL_ADDRESS) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, ulong, void> SetGraphicsRootUnorderedAccessView;
            [NativeTypeName("void (const D3D12_INDEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12IndexBufferView*, void> IASetIndexBuffer;
            [NativeTypeName("void (UINT, UINT, const D3D12_VERTEX_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3D12VertexBufferView*, void> IASetVertexBuffers;
            [NativeTypeName("void (UINT, UINT, const D3D12_STREAM_OUTPUT_BUFFER_VIEW *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, uint, D3D12StreamOutputBufferView*, void> SOSetTargets;
            [NativeTypeName("void (UINT, const D3D12_CPU_DESCRIPTOR_HANDLE *, BOOL, const D3D12_CPU_DESCRIPTOR_HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12CpuDescriptorHandle*, MaybeBool<int>, D3D12CpuDescriptorHandle*, void> OMSetRenderTargets;
            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, D3D12_CLEAR_FLAGS, FLOAT, UINT8, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CpuDescriptorHandle, D3D12ClearFlags, float, byte, uint, RECT*, void> ClearDepthStencilView;
            [NativeTypeName("void (D3D12_CPU_DESCRIPTOR_HANDLE, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12CpuDescriptorHandle, float*, uint, RECT*, void> ClearRenderTargetView;
            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const UINT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12GpuDescriptorHandle, D3D12CpuDescriptorHandle, ID3D12Resource.Native*, uint*, uint, RECT*, void> ClearUnorderedAccessViewUint;
            [NativeTypeName("void (D3D12_GPU_DESCRIPTOR_HANDLE, D3D12_CPU_DESCRIPTOR_HANDLE, ID3D12Resource *, const FLOAT *, UINT, const D3D12_RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12GpuDescriptorHandle, D3D12CpuDescriptorHandle, ID3D12Resource.Native*, float*, uint, RECT*, void> ClearUnorderedAccessViewFloat;
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
            [NativeTypeName("void (ID3D12CommandSignature *, UINT, ID3D12Resource *, UINT64, ID3D12Resource *, UINT64) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12CommandSignature.Native*, uint, ID3D12Resource.Native*, ulong, ID3D12Resource.Native*, ulong, void> ExecuteIndirect;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint> )(lpVtbl[1]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, void*, uint, void> )(lpVtbl[57]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(57)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
        {
            fixed (void* __dsl_pData = pData)
            {
                BeginEvent(Metadata, __dsl_pData, Size);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginQuery"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> )(lpVtbl[52]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, Index);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearDepthStencilView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12CpuDescriptorHandle, D3D12ClearFlags, float, byte, uint, RECT*, void> )(lpVtbl[47]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
        }

        [VtblIndex(47)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
        {
            fixed (RECT* __dsl_pRects = pRects)
            {
                ClearDepthStencilView(DepthStencilView, ClearFlags, Depth, Stencil, NumRects, __dsl_pRects);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearRenderTargetView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12CpuDescriptorHandle, float*, uint, RECT*, void> )(lpVtbl[48]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RenderTargetView, ColorRGBA, NumRects, pRects);
        }

        [VtblIndex(48)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] Ref<float> ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
        {
            fixed (RECT* __dsl_pRects = pRects)
            fixed (float* __dsl_ColorRGBA = ColorRGBA)
            {
                ClearRenderTargetView(RenderTargetView, __dsl_ColorRGBA, NumRects, __dsl_pRects);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void ClearState(ID3D12PipelineState pPipelineState)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12PipelineState.Native*, void> )(lpVtbl[11]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pPipelineState.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewFloat"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] float* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12GpuDescriptorHandle, D3D12CpuDescriptorHandle, ID3D12Resource.Native*, float*, uint, RECT*, void> )(lpVtbl[50]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource.LpVtbl, Values, NumRects, pRects);
        }

        [VtblIndex(50)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] Ref<float> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
        {
            fixed (RECT* __dsl_pRects = pRects)
            fixed (float* __dsl_Values = Values)
            {
                ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, __dsl_Values, NumRects, __dsl_pRects);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewUint"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] uint* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12GpuDescriptorHandle, D3D12CpuDescriptorHandle, ID3D12Resource.Native*, uint*, uint, RECT*, void> )(lpVtbl[49]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource.LpVtbl, Values, NumRects, pRects);
        }

        [VtblIndex(49)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] Ref<uint> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
        {
            fixed (RECT* __dsl_pRects = pRects)
            fixed (uint* __dsl_Values = Values)
            {
                ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, __dsl_Values, NumRects, __dsl_pRects);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Close"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult Close()
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, HResult> )(lpVtbl[9]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyBufferRegion"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void CopyBufferRegion(ID3D12Resource pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, ulong, ID3D12Resource.Native*, ulong, ulong, void> )(lpVtbl[15]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pDstBuffer.LpVtbl, DstOffset, pSrcBuffer.LpVtbl, SrcOffset, NumBytes);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void CopyResource(ID3D12Resource pDstResource, ID3D12Resource pSrcResource)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, ID3D12Resource.Native*, void> )(lpVtbl[17]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pDstResource.LpVtbl, pSrcResource.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTextureRegion"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pSrcBox)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12TextureCopyLocation*, uint, uint, uint, D3D12TextureCopyLocation*, D3D12Box*, void> )(lpVtbl[16]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
        }

        [VtblIndex(16)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pSrc, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pSrcBox)
        {
            fixed (D3D12Box* __dsl_pSrcBox = pSrcBox)
            fixed (D3D12TextureCopyLocation* __dsl_pSrc = pSrc)
            fixed (D3D12TextureCopyLocation* __dsl_pDst = pDst)
            {
                CopyTextureRegion(__dsl_pDst, DstX, DstY, DstZ, __dsl_pSrc, __dsl_pSrcBox);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTiles"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, D3D12TiledResourceCoordinate*, D3D12TileRegionSize*, ID3D12Resource.Native*, ulong, D3D12TileCopyFlags, void> )(lpVtbl[18]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pTiledResource.LpVtbl, pTileRegionStartCoordinate, pTileRegionSize, pBuffer.LpVtbl, BufferStartOffsetInBytes, Flags);
        }

        [VtblIndex(18)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags)
        {
            fixed (D3D12TileRegionSize* __dsl_pTileRegionSize = pTileRegionSize)
            fixed (D3D12TiledResourceCoordinate* __dsl_pTileRegionStartCoordinate = pTileRegionStartCoordinate)
            {
                CopyTiles(pTiledResource, __dsl_pTileRegionStartCoordinate, __dsl_pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DiscardResource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, D3D12DiscardRegion*, void> )(lpVtbl[51]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pResource.LpVtbl, pRegion);
        }

        [VtblIndex(51)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion)
        {
            fixed (D3D12DiscardRegion* __dsl_pRegion = pRegion)
            {
                DiscardResource(pResource, __dsl_pRegion);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Dispatch"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, uint, void> )(lpVtbl[14]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawIndexedInstanced"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, uint, int, uint, void> )(lpVtbl[13]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawInstanced"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, uint, uint, void> )(lpVtbl[12]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndEvent"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public void EndEvent()
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, void> )(lpVtbl[58]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndQuery"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, void> )(lpVtbl[53]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, Index);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteBundle"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void ExecuteBundle(ID3D12GraphicsCommandList pCommandList)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12GraphicsCommandList.Native*, void> )(lpVtbl[27]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pCommandList.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteIndirect"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public void ExecuteIndirect(ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, ID3D12Resource pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12CommandSignature.Native*, uint, ID3D12Resource.Native*, ulong, ID3D12Resource.Native*, ulong, void> )(lpVtbl[59]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pCommandSignature.LpVtbl, MaxCommandCount, pArgumentBuffer.LpVtbl, ArgumentBufferOffset, pCountBuffer.LpVtbl, CountBufferOffset);
        }

        /// <inheritdoc cref = "ID3D12DeviceChild.GetDevice"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppvDevice)
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), riid, ppvDevice);
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
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, Guid*, uint*, void*, HResult> )(lpVtbl[3]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
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
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12CommandListType> )(lpVtbl[8]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetIndexBuffer"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12IndexBufferView* pView)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3D12IndexBufferView*, void> )(lpVtbl[43]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pView);
        }

        [VtblIndex(43)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] Ref<D3D12IndexBufferView> pView)
        {
            fixed (D3D12IndexBufferView* __dsl_pView = pView)
            {
                IASetIndexBuffer(__dsl_pView);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetPrimitiveTopology"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3DPrimitiveTopology PrimitiveTopology)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, D3DPrimitiveTopology, void> )(lpVtbl[20]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), PrimitiveTopology);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetVertexBuffers"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12VertexBufferView* pViews)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, D3D12VertexBufferView*, void> )(lpVtbl[44]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        [VtblIndex(44)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] Ref<D3D12VertexBufferView> pViews)
        {
            fixed (D3D12VertexBufferView* __dsl_pViews = pViews)
            {
                IASetVertexBuffers(StartSlot, NumViews, __dsl_pViews);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetBlendFactor"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, float*, void> )(lpVtbl[23]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), BlendFactor);
        }

        [VtblIndex(23)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] Ref<float> BlendFactor)
        {
            fixed (float* __dsl_BlendFactor = BlendFactor)
            {
                OMSetBlendFactor(__dsl_BlendFactor);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetRenderTargets"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, D3D12CpuDescriptorHandle*, MaybeBool<int>, D3D12CpuDescriptorHandle*, void> )(lpVtbl[46]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
        }

        [VtblIndex(46)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDepthStencilDescriptor)
        {
            fixed (D3D12CpuDescriptorHandle* __dsl_pDepthStencilDescriptor = pDepthStencilDescriptor)
            fixed (D3D12CpuDescriptorHandle* __dsl_pRenderTargetDescriptors = pRenderTargetDescriptors)
            {
                OMSetRenderTargets(NumRenderTargetDescriptors, __dsl_pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, __dsl_pDepthStencilDescriptor);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetStencilRef"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void OMSetStencilRef(uint StencilRef)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, void> )(lpVtbl[24]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), StencilRef);
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint> )(lpVtbl[2]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this));
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Reset"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult Reset(ID3D12CommandAllocator pAllocator, ID3D12PipelineState pInitialState)
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12CommandAllocator.Native*, ID3D12PipelineState.Native*, HResult> )(lpVtbl[10]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pAllocator.LpVtbl, pInitialState.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveQueryData"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12QueryHeap.Native*, D3D12QueryType, uint, uint, ID3D12Resource.Native*, ulong, void> )(lpVtbl[54]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pQueryHeap.LpVtbl, Type, StartIndex, NumQueries, pDestinationBuffer.LpVtbl, AlignedDestinationBufferOffset);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveSubresource"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void ResolveSubresource(ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource pSrcResource, uint SrcSubresource, DxgiFormat Format)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, uint, ID3D12Resource.Native*, uint, DxgiFormat, void> )(lpVtbl[19]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pDstResource.LpVtbl, DstSubresource, pSrcResource.LpVtbl, SrcSubresource, Format);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResourceBarrier"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, D3D12ResourceBarrier*, void> )(lpVtbl[26]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), NumBarriers, pBarriers);
        }

        [VtblIndex(26)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers)
        {
            fixed (D3D12ResourceBarrier* __dsl_pBarriers = pBarriers)
            {
                ResourceBarrier(NumBarriers, __dsl_pBarriers);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetScissorRects"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, RECT*, void> )(lpVtbl[22]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), NumRects, pRects);
        }

        [VtblIndex(22)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
        {
            fixed (RECT* __dsl_pRects = pRects)
            {
                RSSetScissorRects(NumRects, __dsl_pRects);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetViewports"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12Viewport* pViewports)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, D3D12Viewport*, void> )(lpVtbl[21]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), NumViewports, pViewports);
        }

        [VtblIndex(21)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] Ref<D3D12Viewport> pViewports)
        {
            fixed (D3D12Viewport* __dsl_pViewports = pViewports)
            {
                RSSetViewports(NumViewports, __dsl_pViewports);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstant"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, uint, void> )(lpVtbl[33]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstants"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, void*, uint, void> )(lpVtbl[35]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        [VtblIndex(35)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues)
        {
            fixed (void* __dsl_pSrcData = pSrcData)
            {
                SetComputeRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, __dsl_pSrcData, DestOffsetIn32BitValues);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootConstantBufferView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void SetComputeRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[37]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootDescriptorTable"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, D3D12GpuDescriptorHandle, void> )(lpVtbl[31]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootShaderResourceView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void SetComputeRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[39]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootSignature"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void SetComputeRootSignature(ID3D12RootSignature pRootSignature)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12RootSignature.Native*, void> )(lpVtbl[29]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pRootSignature.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootUnorderedAccessView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[41]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetDescriptorHeaps"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap* ppDescriptorHeaps)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ID3D12DescriptorHeap.Native**, void> )(lpVtbl[28]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), NumDescriptorHeaps, &ppDescriptorHeaps->LpVtbl);
        }

        [VtblIndex(28)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] Ref<ID3D12DescriptorHeap> ppDescriptorHeaps)
        {
            fixed (ID3D12DescriptorHeap* __dsl_ppDescriptorHeaps = ppDescriptorHeaps)
            {
                SetDescriptorHeaps(NumDescriptorHeaps, __dsl_ppDescriptorHeaps);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstant"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, uint, void> )(lpVtbl[34]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, SrcData, DestOffsetIn32BitValues);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstants"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, void*, uint, void> )(lpVtbl[36]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
        }

        [VtblIndex(36)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues)
        {
            fixed (void* __dsl_pSrcData = pSrcData)
            {
                SetGraphicsRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, __dsl_pSrcData, DestOffsetIn32BitValues);
            }
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootConstantBufferView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[38]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootDescriptorTable"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, D3D12GpuDescriptorHandle, void> )(lpVtbl[32]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BaseDescriptor);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootShaderResourceView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[40]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootSignature"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void SetGraphicsRootSignature(ID3D12RootSignature pRootSignature)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12RootSignature.Native*, void> )(lpVtbl[30]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pRootSignature.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootUnorderedAccessView"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, ulong, void> )(lpVtbl[42]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), RootParameterIndex, BufferLocation);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetMarker"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, void*, uint, void> )(lpVtbl[56]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), Metadata, pData, Size);
        }

        [VtblIndex(56)]
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
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ushort*, HResult> )(lpVtbl[6]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), Name);
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

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPipelineState"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void SetPipelineState(ID3D12PipelineState pPipelineState)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12PipelineState.Native*, void> )(lpVtbl[25]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pPipelineState.LpVtbl);
        }

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPredication"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public void SetPredication(ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong AlignedBufferOffset, D3D12PredicationOp Operation)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, ID3D12Resource.Native*, ulong, D3D12PredicationOp, void> )(lpVtbl[55]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), pBuffer.LpVtbl, AlignedBufferOffset, Operation);
        }

        /// <inheritdoc cref = "ID3D12Object.SetPrivateData"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, Guid*, uint, void*, HResult> )(lpVtbl[4]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
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
            return ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, Guid*, IUnknown.Native*, HResult> )(lpVtbl[5]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), guid, pData.lpVtbl);
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

        /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SOSetTargets"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12StreamOutputBufferView* pViews)
        {
            ((delegate* unmanaged<ID3D12GraphicsCommandList.Native*, uint, uint, D3D12StreamOutputBufferView*, void> )(lpVtbl[45]))((ID3D12GraphicsCommandList.Native*)Unsafe.AsPointer(ref this), StartSlot, NumViews, pViews);
        }

        [VtblIndex(45)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] Ref<D3D12StreamOutputBufferView> pViews)
        {
            fixed (D3D12StreamOutputBufferView* __dsl_pViews = pViews)
            {
                SOSetTargets(StartSlot, NumViews, __dsl_pViews);
            }
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12GraphicsCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GraphicsCommandList(Ptr3D vtbl) => LpVtbl = (ID3D12GraphicsCommandList.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12GraphicsCommandList"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12GraphicsCommandList(Ptr<ID3D12GraphicsCommandList.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList.Native"/> to <see cref = "ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList.Native"/> instance to be converted </param>
    public static implicit operator ID3D12GraphicsCommandList(ID3D12GraphicsCommandList.Native* value) => new ID3D12GraphicsCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList"/> to <see cref = "ID3D12GraphicsCommandList.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static implicit operator ID3D12GraphicsCommandList.Native*(ID3D12GraphicsCommandList value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList(Ptr3D value) => new ID3D12GraphicsCommandList(value);
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12GraphicsCommandList value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList(Ptr<ID3D12GraphicsCommandList.Native> value) => new ID3D12GraphicsCommandList(value);
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12GraphicsCommandList.Native>(ID3D12GraphicsCommandList value) => (Ptr<ID3D12GraphicsCommandList.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList(void*** value) => new ID3D12GraphicsCommandList((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static implicit operator void***(ID3D12GraphicsCommandList value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12GraphicsCommandList"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12GraphicsCommandList(nuint value) => new ID3D12GraphicsCommandList((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12GraphicsCommandList"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12GraphicsCommandList"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12GraphicsCommandList value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->BeginEvent(Metadata, pData, Size);
    [VtblIndex(57)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void BeginEvent(uint Metadata, [NativeTypeName("const void *")] Ref pData, uint Size)
    {
        fixed (void* __dsl_pData = pData)
        {
            BeginEvent(Metadata, __dsl_pData, Size);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.BeginQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public void BeginQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index) => LpVtbl->BeginQuery(pQueryHeap, Type, Index);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearDepthStencilView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects) => LpVtbl->ClearDepthStencilView(DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
    [VtblIndex(47)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ClearDepthStencilView(D3D12CpuDescriptorHandle DepthStencilView, D3D12ClearFlags ClearFlags, float Depth, [NativeTypeName("UINT8")] byte Stencil, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
    {
        fixed (RECT* __dsl_pRects = pRects)
        {
            ClearDepthStencilView(DepthStencilView, ClearFlags, Depth, Stencil, NumRects, __dsl_pRects);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearRenderTargetView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] float* ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects) => LpVtbl->ClearRenderTargetView(RenderTargetView, ColorRGBA, NumRects, pRects);
    [VtblIndex(48)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ClearRenderTargetView(D3D12CpuDescriptorHandle RenderTargetView, [NativeTypeName("const FLOAT[4]")] Ref<float> ColorRGBA, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
    {
        fixed (RECT* __dsl_pRects = pRects)
        fixed (float* __dsl_ColorRGBA = ColorRGBA)
        {
            ClearRenderTargetView(RenderTargetView, __dsl_ColorRGBA, NumRects, __dsl_pRects);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void ClearState(ID3D12PipelineState pPipelineState) => LpVtbl->ClearState(pPipelineState);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewFloat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] float* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects) => LpVtbl->ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    [VtblIndex(50)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ClearUnorderedAccessViewFloat(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const FLOAT[4]")] Ref<float> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
    {
        fixed (RECT* __dsl_pRects = pRects)
        fixed (float* __dsl_Values = Values)
        {
            ClearUnorderedAccessViewFloat(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, __dsl_Values, NumRects, __dsl_pRects);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ClearUnorderedAccessViewUint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] uint* Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects) => LpVtbl->ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
    [VtblIndex(49)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ClearUnorderedAccessViewUint(D3D12GpuDescriptorHandle ViewGPUHandleInCurrentHeap, D3D12CpuDescriptorHandle ViewCPUHandle, ID3D12Resource pResource, [NativeTypeName("const UINT[4]")] Ref<uint> Values, uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
    {
        fixed (RECT* __dsl_pRects = pRects)
        fixed (uint* __dsl_Values = Values)
        {
            ClearUnorderedAccessViewUint(ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, __dsl_Values, NumRects, __dsl_pRects);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult Close() => LpVtbl->Close();
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyBufferRegion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void CopyBufferRegion(ID3D12Resource pDstBuffer, [NativeTypeName("UINT64")] ulong DstOffset, ID3D12Resource pSrcBuffer, [NativeTypeName("UINT64")] ulong SrcOffset, [NativeTypeName("UINT64")] ulong NumBytes) => LpVtbl->CopyBufferRegion(pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public void CopyResource(ID3D12Resource pDstResource, ID3D12Resource pSrcResource) => LpVtbl->CopyResource(pDstResource, pSrcResource);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTextureRegion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] D3D12TextureCopyLocation* pSrc, [NativeTypeName("const D3D12_BOX *")] D3D12Box* pSrcBox) => LpVtbl->CopyTextureRegion(pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
    [VtblIndex(16)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CopyTextureRegion([NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pDst, uint DstX, uint DstY, uint DstZ, [NativeTypeName("const D3D12_TEXTURE_COPY_LOCATION *")] Ref<D3D12TextureCopyLocation> pSrc, [NativeTypeName("const D3D12_BOX *")] Ref<D3D12Box> pSrcBox)
    {
        fixed (D3D12Box* __dsl_pSrcBox = pSrcBox)
        fixed (D3D12TextureCopyLocation* __dsl_pSrc = pSrc)
        fixed (D3D12TextureCopyLocation* __dsl_pDst = pDst)
        {
            CopyTextureRegion(__dsl_pDst, DstX, DstY, DstZ, __dsl_pSrc, __dsl_pSrcBox);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.CopyTiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] D3D12TiledResourceCoordinate* pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] D3D12TileRegionSize* pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags) => LpVtbl->CopyTiles(pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
    [VtblIndex(18)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void CopyTiles(ID3D12Resource pTiledResource, [NativeTypeName("const D3D12_TILED_RESOURCE_COORDINATE *")] Ref<D3D12TiledResourceCoordinate> pTileRegionStartCoordinate, [NativeTypeName("const D3D12_TILE_REGION_SIZE *")] Ref<D3D12TileRegionSize> pTileRegionSize, ID3D12Resource pBuffer, [NativeTypeName("UINT64")] ulong BufferStartOffsetInBytes, D3D12TileCopyFlags Flags)
    {
        fixed (D3D12TileRegionSize* __dsl_pTileRegionSize = pTileRegionSize)
        fixed (D3D12TiledResourceCoordinate* __dsl_pTileRegionStartCoordinate = pTileRegionStartCoordinate)
        {
            CopyTiles(pTiledResource, __dsl_pTileRegionStartCoordinate, __dsl_pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DiscardResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] D3D12DiscardRegion* pRegion) => LpVtbl->DiscardResource(pResource, pRegion);
    [VtblIndex(51)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void DiscardResource(ID3D12Resource pResource, [NativeTypeName("const D3D12_DISCARD_REGION *")] Ref<D3D12DiscardRegion> pRegion)
    {
        fixed (D3D12DiscardRegion* __dsl_pRegion = pRegion)
        {
            DiscardResource(pResource, __dsl_pRegion);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Dispatch"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ) => LpVtbl->Dispatch(ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawIndexedInstanced"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation) => LpVtbl->DrawIndexedInstanced(IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.DrawInstanced"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation) => LpVtbl->DrawInstanced(VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndEvent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public void EndEvent() => LpVtbl->EndEvent();
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.EndQuery"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public void EndQuery(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint Index) => LpVtbl->EndQuery(pQueryHeap, Type, Index);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteBundle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public void ExecuteBundle(ID3D12GraphicsCommandList pCommandList) => LpVtbl->ExecuteBundle(pCommandList);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ExecuteIndirect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public void ExecuteIndirect(ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource pArgumentBuffer, [NativeTypeName("UINT64")] ulong ArgumentBufferOffset, ID3D12Resource pCountBuffer, [NativeTypeName("UINT64")] ulong CountBufferOffset) => LpVtbl->ExecuteIndirect(pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
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
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetIndexBuffer"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] D3D12IndexBufferView* pView) => LpVtbl->IASetIndexBuffer(pView);
    [VtblIndex(43)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void IASetIndexBuffer([NativeTypeName("const D3D12_INDEX_BUFFER_VIEW *")] Ref<D3D12IndexBufferView> pView)
    {
        fixed (D3D12IndexBufferView* __dsl_pView = pView)
        {
            IASetIndexBuffer(__dsl_pView);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetPrimitiveTopology"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public void IASetPrimitiveTopology([NativeTypeName("D3D12_PRIMITIVE_TOPOLOGY")] D3DPrimitiveTopology PrimitiveTopology) => LpVtbl->IASetPrimitiveTopology(PrimitiveTopology);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.IASetVertexBuffers"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] D3D12VertexBufferView* pViews) => LpVtbl->IASetVertexBuffers(StartSlot, NumViews, pViews);
    [VtblIndex(44)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void IASetVertexBuffers(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_VERTEX_BUFFER_VIEW *")] Ref<D3D12VertexBufferView> pViews)
    {
        fixed (D3D12VertexBufferView* __dsl_pViews = pViews)
        {
            IASetVertexBuffers(StartSlot, NumViews, __dsl_pViews);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetBlendFactor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] float* BlendFactor) => LpVtbl->OMSetBlendFactor(BlendFactor);
    [VtblIndex(23)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void OMSetBlendFactor([NativeTypeName("const FLOAT[4]")] Ref<float> BlendFactor)
    {
        fixed (float* __dsl_BlendFactor = BlendFactor)
        {
            OMSetBlendFactor(__dsl_BlendFactor);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetRenderTargets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] D3D12CpuDescriptorHandle* pDepthStencilDescriptor) => LpVtbl->OMSetRenderTargets(NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
    [VtblIndex(46)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void OMSetRenderTargets(uint NumRenderTargetDescriptors, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pRenderTargetDescriptors, [NativeTypeName("BOOL")] MaybeBool<int> RTsSingleHandleToDescriptorRange, [NativeTypeName("const D3D12_CPU_DESCRIPTOR_HANDLE *")] Ref<D3D12CpuDescriptorHandle> pDepthStencilDescriptor)
    {
        fixed (D3D12CpuDescriptorHandle* __dsl_pDepthStencilDescriptor = pDepthStencilDescriptor)
        fixed (D3D12CpuDescriptorHandle* __dsl_pRenderTargetDescriptors = pRenderTargetDescriptors)
        {
            OMSetRenderTargets(NumRenderTargetDescriptors, __dsl_pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, __dsl_pDepthStencilDescriptor);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.OMSetStencilRef"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public void OMSetStencilRef(uint StencilRef) => LpVtbl->OMSetStencilRef(StencilRef);
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
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult Reset(ID3D12CommandAllocator pAllocator, ID3D12PipelineState pInitialState) => LpVtbl->Reset(pAllocator, pInitialState);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveQueryData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public void ResolveQueryData(ID3D12QueryHeap pQueryHeap, D3D12QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource pDestinationBuffer, [NativeTypeName("UINT64")] ulong AlignedDestinationBufferOffset) => LpVtbl->ResolveQueryData(pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResolveSubresource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void ResolveSubresource(ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource pSrcResource, uint SrcSubresource, DxgiFormat Format) => LpVtbl->ResolveSubresource(pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.ResourceBarrier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] D3D12ResourceBarrier* pBarriers) => LpVtbl->ResourceBarrier(NumBarriers, pBarriers);
    [VtblIndex(26)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void ResourceBarrier(uint NumBarriers, [NativeTypeName("const D3D12_RESOURCE_BARRIER *")] Ref<D3D12ResourceBarrier> pBarriers)
    {
        fixed (D3D12ResourceBarrier* __dsl_pBarriers = pBarriers)
        {
            ResourceBarrier(NumBarriers, __dsl_pBarriers);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetScissorRects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] RECT* pRects) => LpVtbl->RSSetScissorRects(NumRects, pRects);
    [VtblIndex(22)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RSSetScissorRects(uint NumRects, [NativeTypeName("const D3D12_RECT *")] Ref<RECT> pRects)
    {
        fixed (RECT* __dsl_pRects = pRects)
        {
            RSSetScissorRects(NumRects, __dsl_pRects);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.RSSetViewports"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] D3D12Viewport* pViewports) => LpVtbl->RSSetViewports(NumViewports, pViewports);
    [VtblIndex(21)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void RSSetViewports(uint NumViewports, [NativeTypeName("const D3D12_VIEWPORT *")] Ref<D3D12Viewport> pViewports)
    {
        fixed (D3D12Viewport* __dsl_pViewports = pViewports)
        {
            RSSetViewports(NumViewports, __dsl_pViewports);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues) => LpVtbl->SetComputeRoot32BitConstant(RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRoot32BitConstants"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues) => LpVtbl->SetComputeRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    [VtblIndex(35)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues)
    {
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            SetComputeRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, __dsl_pSrcData, DestOffsetIn32BitValues);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootConstantBufferView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public void SetComputeRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetComputeRootConstantBufferView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootDescriptorTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public void SetComputeRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor) => LpVtbl->SetComputeRootDescriptorTable(RootParameterIndex, BaseDescriptor);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootShaderResourceView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public void SetComputeRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetComputeRootShaderResourceView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public void SetComputeRootSignature(ID3D12RootSignature pRootSignature) => LpVtbl->SetComputeRootSignature(pRootSignature);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetComputeRootUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public void SetComputeRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetComputeRootUnorderedAccessView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetDescriptorHeaps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] ID3D12DescriptorHeap* ppDescriptorHeaps) => LpVtbl->SetDescriptorHeaps(NumDescriptorHeaps, ppDescriptorHeaps);
    [VtblIndex(28)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SetDescriptorHeaps(uint NumDescriptorHeaps, [NativeTypeName("ID3D12DescriptorHeap *const *")] Ref<ID3D12DescriptorHeap> ppDescriptorHeaps)
    {
        fixed (ID3D12DescriptorHeap* __dsl_ppDescriptorHeaps = ppDescriptorHeaps)
        {
            SetDescriptorHeaps(NumDescriptorHeaps, __dsl_ppDescriptorHeaps);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues) => LpVtbl->SetGraphicsRoot32BitConstant(RootParameterIndex, SrcData, DestOffsetIn32BitValues);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRoot32BitConstants"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] void* pSrcData, uint DestOffsetIn32BitValues) => LpVtbl->SetGraphicsRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
    [VtblIndex(36)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, [NativeTypeName("const void *")] Ref pSrcData, uint DestOffsetIn32BitValues)
    {
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            SetGraphicsRoot32BitConstants(RootParameterIndex, Num32BitValuesToSet, __dsl_pSrcData, DestOffsetIn32BitValues);
        }
    }

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootConstantBufferView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetGraphicsRootConstantBufferView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetGraphicsRootConstantBufferView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootDescriptorTable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public void SetGraphicsRootDescriptorTable(uint RootParameterIndex, D3D12GpuDescriptorHandle BaseDescriptor) => LpVtbl->SetGraphicsRootDescriptorTable(RootParameterIndex, BaseDescriptor);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootShaderResourceView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public void SetGraphicsRootShaderResourceView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetGraphicsRootShaderResourceView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootSignature"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public void SetGraphicsRootSignature(ID3D12RootSignature pRootSignature) => LpVtbl->SetGraphicsRootSignature(pRootSignature);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetGraphicsRootUnorderedAccessView"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")] ulong BufferLocation) => LpVtbl->SetGraphicsRootUnorderedAccessView(RootParameterIndex, BufferLocation);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetMarker"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public void SetMarker(uint Metadata, [NativeTypeName("const void *")] void* pData, uint Size) => LpVtbl->SetMarker(Metadata, pData, Size);
    [VtblIndex(56)]
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

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPipelineState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SetPipelineState(ID3D12PipelineState pPipelineState) => LpVtbl->SetPipelineState(pPipelineState);
    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SetPredication"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
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

    /// <include file='ID3D12GraphicsCommandList.xml' path='doc/member[@name="ID3D12GraphicsCommandList.SOSetTargets"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] D3D12StreamOutputBufferView* pViews) => LpVtbl->SOSetTargets(StartSlot, NumViews, pViews);
    [VtblIndex(45)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void SOSetTargets(uint StartSlot, uint NumViews, [NativeTypeName("const D3D12_STREAM_OUTPUT_BUFFER_VIEW *")] Ref<D3D12StreamOutputBufferView> pViews)
    {
        fixed (D3D12StreamOutputBufferView* __dsl_pViews = pViews)
        {
            SOSetTargets(StartSlot, NumViews, __dsl_pViews);
        }
    }
}