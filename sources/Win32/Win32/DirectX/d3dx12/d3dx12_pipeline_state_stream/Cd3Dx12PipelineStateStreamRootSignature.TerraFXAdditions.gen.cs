// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_pipeline_state_stream.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public unsafe struct Cd3Dx12PipelineStateStreamRootSignature
{
    [FieldOffset(0)]
    private readonly unsafe void* AnonymousEAlignment;

    [FieldOffset(0)]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref D3D12PipelineStateSubobjectType pssType => ref Anonymous.pssType;

    [UnscopedRef]
    public ref ID3D12RootSignature pssInner => ref Anonymous.pssInner;

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE()
    {
        pssType = D3D12PipelineStateSubobjectType.RootSignature;
        pssInner = default;
    }

    public CD3DX12_PIPELINE_STATE_STREAM_ROOT_SIGNATURE(
        [NativeTypeName("ID3D12RootSignature* const &")] in ID3D12RootSignature i
    )
    {
        pssType = D3D12PipelineStateSubobjectType.RootSignature;
        pssInner = i;
    }

    public static implicit operator Cd3Dx12PipelineStateStreamRootSignature(
        in ID3D12RootSignature value
    ) => new Cd3Dx12PipelineStateStreamRootSignature(value);

    public static implicit operator ID3D12RootSignature(
        in Cd3Dx12PipelineStateStreamRootSignature value
    ) => value.pssInner;

    public struct _Anonymous_e__Struct
    {
        public D3D12PipelineStateSubobjectType pssType;
        public ID3D12RootSignature pssInner;
    }
}
