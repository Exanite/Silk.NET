// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC"]/*'/>
public partial struct D3D12RenderPassDepthStencilDesc
{
    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.cpuDescriptor"]/*'/>

    public D3D12CpuDescriptorHandle CpuDescriptor;

    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.DepthBeginningAccess"]/*'/>

    public D3D12RenderPassBeginningAccess DepthBeginningAccess;

    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.StencilBeginningAccess"]/*'/>

    public D3D12RenderPassBeginningAccess StencilBeginningAccess;

    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.DepthEndingAccess"]/*'/>

    public D3D12RenderPassEndingAccess DepthEndingAccess;

    /// <include file='D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_DEPTH_STENCIL_DESC.StencilEndingAccess"]/*'/>

    public D3D12RenderPassEndingAccess StencilEndingAccess;
}
