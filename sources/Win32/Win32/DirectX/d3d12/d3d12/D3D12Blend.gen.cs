// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND"]/*'/>
public enum D3D12Blend
{
    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_ZERO"]/*'/>

    Zero = 1,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_ONE"]/*'/>

    One = 2,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_SRC_COLOR"]/*'/>

    SrcColor = 3,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_SRC_COLOR"]/*'/>

    InvSrcColor = 4,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_SRC_ALPHA"]/*'/>

    SrcAlpha = 5,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_SRC_ALPHA"]/*'/>

    InvSrcAlpha = 6,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_DEST_ALPHA"]/*'/>

    DestAlpha = 7,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_DEST_ALPHA"]/*'/>

    InvDestAlpha = 8,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_DEST_COLOR"]/*'/>

    DestColor = 9,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_DEST_COLOR"]/*'/>

    InvDestColor = 10,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_SRC_ALPHA_SAT"]/*'/>

    SrcAlphaSat = 11,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_BLEND_FACTOR"]/*'/>

    BlendFactor = 14,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_BLEND_FACTOR"]/*'/>

    InvBlendFactor = 15,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_SRC1_COLOR"]/*'/>

    Src1Color = 16,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_SRC1_COLOR"]/*'/>

    InvSrc1Color = 17,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_SRC1_ALPHA"]/*'/>

    Src1Alpha = 18,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_SRC1_ALPHA"]/*'/>

    InvSrc1Alpha = 19,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_ALPHA_FACTOR"]/*'/>

    AlphaFactor = 20,

    /// <include file='D3D12_BLEND.xml' path='doc/member[@name="D3D12_BLEND.D3D12_BLEND_INV_ALPHA_FACTOR"]/*'/>

    InvAlphaFactor = 21,
}
