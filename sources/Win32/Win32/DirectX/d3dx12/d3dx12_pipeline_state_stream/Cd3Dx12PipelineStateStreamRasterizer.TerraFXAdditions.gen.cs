// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct Cd3Dx12PipelineStateStreamRasterizer
{
    [FieldOffset(0)]
    private readonly unsafe void* AnonymousEAlignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12PipelineStateSubobjectType pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12RasterizerDesc pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER()
    {
        pssType = D3D12PipelineStateSubobjectType.Rasterizer;
        pssInner = D3D12RasterizerDesc.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER(
        [NativeTypeName("D3D12_RASTERIZER_DESC const &")] in D3D12RasterizerDesc i
    )
    {
        pssType = D3D12PipelineStateSubobjectType.Rasterizer;
        pssInner = i;
    }

    public static implicit operator Cd3Dx12PipelineStateStreamRasterizer(
        in D3D12RasterizerDesc value
    ) => new Cd3Dx12PipelineStateStreamRasterizer(value);

    public static implicit operator D3D12RasterizerDesc(
        in Cd3Dx12PipelineStateStreamRasterizer value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12PipelineStateSubobjectType pssType;
        public D3D12RasterizerDesc pssInner;
    }
}
