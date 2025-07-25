// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR"]/*'/>
public enum D3D12StaticBorderColor
{
    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_TRANSPARENT_BLACK"]/*'/>

    TransparentBlack = 0,

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK"]/*'/>

    OpaqueBlack = (TransparentBlack + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE"]/*'/>

    OpaqueWhite = (OpaqueBlack + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_BLACK_UINT"]/*'/>

    OpaqueBlackUint = (OpaqueWhite + 1),

    /// <include file='D3D12_STATIC_BORDER_COLOR.xml' path='doc/member[@name="D3D12_STATIC_BORDER_COLOR.D3D12_STATIC_BORDER_COLOR_OPAQUE_WHITE_UINT"]/*'/>

    OpaqueWhiteUint = (OpaqueBlackUint + 1),
}
