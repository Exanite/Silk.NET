// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING"]/*'/>
public enum D3DTessellatorPartitioning
{
    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_UNDEFINED"]/*'/>

    DTessellatorPartitioningUndefined = 0,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_INTEGER"]/*'/>

    DTessellatorPartitioningInteger = 1,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_POW2"]/*'/>

    DTessellatorPartitioningPow2 = 2,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD"]/*'/>

    DTessellatorPartitioningFractionalOdd = 3,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN"]/*'/>

    DTessellatorPartitioningFractionalEven = 4,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_UNDEFINED"]/*'/>

    D11TessellatorPartitioningUndefined = DTessellatorPartitioningUndefined,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_INTEGER"]/*'/>

    D11TessellatorPartitioningInteger = DTessellatorPartitioningInteger,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_POW2"]/*'/>

    D11TessellatorPartitioningPow2 = DTessellatorPartitioningPow2,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_ODD"]/*'/>

    D11TessellatorPartitioningFractionalOdd = DTessellatorPartitioningFractionalOdd,

    /// <include file='D3D_TESSELLATOR_PARTITIONING.xml' path='doc/member[@name="D3D_TESSELLATOR_PARTITIONING.D3D11_TESSELLATOR_PARTITIONING_FRACTIONAL_EVEN"]/*'/>

    D11TessellatorPartitioningFractionalEven = DTessellatorPartitioningFractionalEven,
}
