// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1"]/*'/>
public partial struct D3D12DepthStencilDesc1
{
    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DepthEnable;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthWriteMask"]/*'/>

    public D3D12DepthWriteMask DepthWriteMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthFunc"]/*'/>

    public D3D12ComparisonFunc DepthFunc;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> StencilEnable;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilReadMask"]/*'/>

    [NativeTypeName("UINT8")]
    public byte StencilReadMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.StencilWriteMask"]/*'/>

    [NativeTypeName("UINT8")]
    public byte StencilWriteMask;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.FrontFace"]/*'/>

    public D3D12DepthStencilopDesc FrontFace;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.BackFace"]/*'/>

    public D3D12DepthStencilopDesc BackFace;

    /// <include file='D3D12_DEPTH_STENCIL_DESC1.xml' path='doc/member[@name="D3D12_DEPTH_STENCIL_DESC1.DepthBoundsTestEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DepthBoundsTestEnable;
}
