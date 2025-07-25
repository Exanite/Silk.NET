// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC"]/*'/>
public partial struct D3D12RenderPassRenderTargetDesc
{
    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.cpuDescriptor"]/*'/>

    public D3D12CpuDescriptorHandle CpuDescriptor;

    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.BeginningAccess"]/*'/>

    public D3D12RenderPassBeginningAccess BeginningAccess;

    /// <include file='D3D12_RENDER_PASS_RENDER_TARGET_DESC.xml' path='doc/member[@name="D3D12_RENDER_PASS_RENDER_TARGET_DESC.EndingAccess"]/*'/>

    public D3D12RenderPassEndingAccess EndingAccess;
}
