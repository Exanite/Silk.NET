// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION"]/*'/>
public enum D3D12RtvDimension
{
    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_BUFFER"]/*'/>

    Buffer = 1,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE1D"]/*'/>

    Texture1D = 2,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE1DARRAY"]/*'/>

    Texture1Darray = 3,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE2D"]/*'/>

    Texture2D = 4,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE2DARRAY"]/*'/>

    Texture2Darray = 5,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE2DMS"]/*'/>

    Texture2Dms = 6,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    Texture2Dmsarray = 7,

    /// <include file='D3D12_RTV_DIMENSION.xml' path='doc/member[@name="D3D12_RTV_DIMENSION.D3D12_RTV_DIMENSION_TEXTURE3D"]/*'/>

    Texture3D = 8,
}
