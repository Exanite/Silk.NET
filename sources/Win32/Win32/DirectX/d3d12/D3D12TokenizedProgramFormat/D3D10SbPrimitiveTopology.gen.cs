// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY"]/*'/>
public enum D3D10SbPrimitiveTopology
{
    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*'/>

    Undefined = 0,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_POINTLIST"]/*'/>

    Pointlist = 1,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_LINELIST"]/*'/>

    Linelist = 2,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*'/>

    Linestrip = 3,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*'/>

    Trianglelist = 4,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*'/>

    Trianglestrip = 5,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*'/>

    LinelistAdj = 10,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*'/>

    LinestripAdj = 11,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*'/>

    TrianglelistAdj = 12,

    /// <include file='D3D10_SB_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE_TOPOLOGY.D3D10_SB_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*'/>

    TrianglestripAdj = 13,
}
