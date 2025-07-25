// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct Cd3Dx12PipelineStateStreamRasterizer1
{
    [FieldOffset(0)]
    private readonly unsafe void* AnonymousEAlignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12PipelineStateSubobjectType pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12RasterizerDesc1 pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER1()
    {
        pssType = D3D12PipelineStateSubobjectType.Rasterizer1;
        pssInner = D3D12RasterizerDesc1.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_RASTERIZER1(
        [NativeTypeName("D3D12_RASTERIZER_DESC1 const &")] in D3D12RasterizerDesc1 i
    )
    {
        pssType = D3D12PipelineStateSubobjectType.Rasterizer1;
        pssInner = i;
    }

    public static implicit operator Cd3Dx12PipelineStateStreamRasterizer1(
        in D3D12RasterizerDesc1 value
    ) => new Cd3Dx12PipelineStateStreamRasterizer1(value);

    public static implicit operator D3D12RasterizerDesc1(
        in Cd3Dx12PipelineStateStreamRasterizer1 value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12PipelineStateSubobjectType pssType;
        public D3D12RasterizerDesc1 pssInner;
    }
}
