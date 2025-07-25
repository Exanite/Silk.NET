// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC"]/*'/>
public partial struct D3D12RenderTargetBlendDesc
{
    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> BlendEnable;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.LogicOpEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> LogicOpEnable;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.SrcBlend"]/*'/>

    public D3D12Blend SrcBlend;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.DestBlend"]/*'/>

    public D3D12Blend DestBlend;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendOp"]/*'/>

    public D3D12BlendOp BlendOp;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.SrcBlendAlpha"]/*'/>

    public D3D12Blend SrcBlendAlpha;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.DestBlendAlpha"]/*'/>

    public D3D12Blend DestBlendAlpha;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.BlendOpAlpha"]/*'/>

    public D3D12BlendOp BlendOpAlpha;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.LogicOp"]/*'/>

    public D3D12LogicOp LogicOp;

    /// <include file='D3D12_RENDER_TARGET_BLEND_DESC.xml' path='doc/member[@name="D3D12_RENDER_TARGET_BLEND_DESC.RenderTargetWriteMask"]/*'/>

    [NativeTypeName("UINT8")]
    public byte RenderTargetWriteMask;
}
