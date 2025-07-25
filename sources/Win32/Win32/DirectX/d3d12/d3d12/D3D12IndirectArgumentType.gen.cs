// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE"]/*'/>
public enum D3D12IndirectArgumentType
{
    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DRAW"]/*'/>

    Draw = 0,

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DRAW_INDEXED"]/*'/>

    DrawIndexed = (Draw + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH"]/*'/>

    Dispatch = (DrawIndexed + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_VERTEX_BUFFER_VIEW"]/*'/>

    VertexBufferView = (Dispatch + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_INDEX_BUFFER_VIEW"]/*'/>

    IndexBufferView = (VertexBufferView + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT"]/*'/>

    Constant = (IndexBufferView + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_CONSTANT_BUFFER_VIEW"]/*'/>

    ConstantBufferView = (Constant + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_SHADER_RESOURCE_VIEW"]/*'/>

    ShaderResourceView = (ConstantBufferView + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_UNORDERED_ACCESS_VIEW"]/*'/>

    UnorderedAccessView = (ShaderResourceView + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_RAYS"]/*'/>

    DispatchRays = (UnorderedAccessView + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_DISPATCH_MESH"]/*'/>

    DispatchMesh = (DispatchRays + 1),

    /// <include file='D3D12_INDIRECT_ARGUMENT_TYPE.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_TYPE.D3D12_INDIRECT_ARGUMENT_TYPE_INCREMENTING_CONSTANT"]/*'/>

    IncrementingConstant = (DispatchMesh + 1),
}
