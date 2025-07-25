// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION"]/*'/>
public enum D3D12DsvDimension
{
    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE1D"]/*'/>

    Texture1D = 1,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    Texture1Darray = 2,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2D"]/*'/>

    Texture2D = 3,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    Texture2Darray = 4,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DMS"]/*'/>

    Texture2Dms = 5,

    /// <include file='D3D12_DSV_DIMENSION.xml' path='doc/member[@name="D3D12_DSV_DIMENSION.D3D12_DSV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    Texture2Dmsarray = 6,
}
