// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public struct Cd3Dx12PipelineStateStreamViewInstancing
{
    [FieldOffset(0)]
    private readonly unsafe void* AnonymousEAlignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12PipelineStateSubobjectType pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref D3D12ViewInstancingDesc pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING()
    {
        pssType = D3D12PipelineStateSubobjectType.ViewInstancing;
        pssInner = D3D12ViewInstancingDesc.DEFAULT;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_VIEW_INSTANCING(
        [NativeTypeName("D3D12_VIEW_INSTANCING_DESC const &")] in D3D12ViewInstancingDesc i
    )
    {
        pssType = D3D12PipelineStateSubobjectType.ViewInstancing;
        pssInner = i;
    }

    public static implicit operator Cd3Dx12PipelineStateStreamViewInstancing(
        in D3D12ViewInstancingDesc value
    ) => new Cd3Dx12PipelineStateStreamViewInstancing(value);

    public static implicit operator D3D12ViewInstancingDesc(
        in Cd3Dx12PipelineStateStreamViewInstancing value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12PipelineStateSubobjectType pssType;
        public D3D12ViewInstancingDesc pssInner;
    }
}
