// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING"]/*'/>
public enum D3D11SbTessellatorPartitioning
{
    /// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING.D3D11_SB_TESSELLATOR_PARTITIONING_UNDEFINED"]/*'/>

    Undefined = 0,

    /// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING.D3D11_SB_TESSELLATOR_PARTITIONING_INTEGER"]/*'/>

    Integer = 1,

    /// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING.D3D11_SB_TESSELLATOR_PARTITIONING_POW2"]/*'/>

    Pow2 = 2,

    /// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING.D3D11_SB_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD"]/*'/>

    FractionalOdd = 3,

    /// <include file='D3D11_SB_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_PARTITIONING.D3D11_SB_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN"]/*'/>

    FractionalEven = 4,
}
