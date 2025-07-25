// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION"]/*'/>
public enum D3D10SbResourceDimension
{
    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_UNKNOWN"]/*'/>

    X10SbResourceDimensionUnknown = 0,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_BUFFER"]/*'/>

    X10SbResourceDimensionBuffer = 1,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE1D"]/*'/>

    X10SbResourceDimensionTexture1D = 2,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE2D"]/*'/>

    X10SbResourceDimensionTexture2D = 3,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE2DMS"]/*'/>

    X10SbResourceDimensionTexture2Dms = 4,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE3D"]/*'/>

    X10SbResourceDimensionTexture3D = 5,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURECUBE"]/*'/>

    X10SbResourceDimensionTexturecube = 6,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE1DARRAY"]/*'/>

    X10SbResourceDimensionTexture1Darray = 7,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE2DARRAY"]/*'/>

    X10SbResourceDimensionTexture2Darray = 8,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURE2DMSARRAY"]/*'/>

    X10SbResourceDimensionTexture2Dmsarray = 9,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D10_SB_RESOURCE_DIMENSION_TEXTURECUBEARRAY"]/*'/>

    X10SbResourceDimensionTexturecubearray = 10,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D11_SB_RESOURCE_DIMENSION_RAW_BUFFER"]/*'/>

    X11SbResourceDimensionRawBuffer = 11,

    /// <include file='D3D10_SB_RESOURCE_DIMENSION.xml' path='doc/member[@name="D3D10_SB_RESOURCE_DIMENSION.D3D11_SB_RESOURCE_DIMENSION_STRUCTURED_BUFFER"]/*'/>

    X11SbResourceDimensionStructuredBuffer = 12,
}
