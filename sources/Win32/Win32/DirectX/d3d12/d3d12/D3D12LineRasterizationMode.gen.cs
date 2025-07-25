// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_LINE_RASTERIZATION_MODE.xml' path='doc/member[@name="D3D12_LINE_RASTERIZATION_MODE"]/*'/>
public enum D3D12LineRasterizationMode
{
    /// <include file='D3D12_LINE_RASTERIZATION_MODE.xml' path='doc/member[@name="D3D12_LINE_RASTERIZATION_MODE.D3D12_LINE_RASTERIZATION_MODE_ALIASED"]/*'/>

    Aliased = 0,

    /// <include file='D3D12_LINE_RASTERIZATION_MODE.xml' path='doc/member[@name="D3D12_LINE_RASTERIZATION_MODE.D3D12_LINE_RASTERIZATION_MODE_ALPHA_ANTIALIASED"]/*'/>

    AlphaAntialiased = (Aliased + 1),

    /// <include file='D3D12_LINE_RASTERIZATION_MODE.xml' path='doc/member[@name="D3D12_LINE_RASTERIZATION_MODE.D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_WIDE"]/*'/>

    QuadrilateralWide = (AlphaAntialiased + 1),

    /// <include file='D3D12_LINE_RASTERIZATION_MODE.xml' path='doc/member[@name="D3D12_LINE_RASTERIZATION_MODE.D3D12_LINE_RASTERIZATION_MODE_QUADRILATERAL_NARROW"]/*'/>

    QuadrilateralNarrow = (QuadrilateralWide + 1),
}
