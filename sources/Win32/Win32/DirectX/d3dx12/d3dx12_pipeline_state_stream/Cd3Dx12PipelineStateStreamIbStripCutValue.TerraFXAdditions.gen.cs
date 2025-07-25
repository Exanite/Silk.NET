// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct Cd3Dx12PipelineStateStreamIbStripCutValue
{
    [FieldOffset(0)]
    private readonly unsafe void* AnonymousEAlignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12PipelineStateSubobjectType pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12IndexBufferStripCutValue pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE()
    {
        pssType = D3D12PipelineStateSubobjectType.IbStripCutValue;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_IB_STRIP_CUT_VALUE(
        [NativeTypeName("D3D12_INDEX_BUFFER_STRIP_CUT_VALUE const &")]
            in D3D12IndexBufferStripCutValue i
    )
    {
        pssType = D3D12PipelineStateSubobjectType.IbStripCutValue;
        pssInner = i;
    }

    public static implicit operator Cd3Dx12PipelineStateStreamIbStripCutValue(
        in D3D12IndexBufferStripCutValue value
    ) => new Cd3Dx12PipelineStateStreamIbStripCutValue(value);

    public static implicit operator D3D12IndexBufferStripCutValue(
        in Cd3Dx12PipelineStateStreamIbStripCutValue value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12PipelineStateSubobjectType pssType;
        public D3D12IndexBufferStripCutValue pssInner;
    }
}
