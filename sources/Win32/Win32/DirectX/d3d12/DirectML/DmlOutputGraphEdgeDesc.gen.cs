// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_OUTPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_OUTPUT_GRAPH_EDGE_DESC"]/*'/>
public unsafe partial struct DmlOutputGraphEdgeDesc
{
    /// <include file='DML_OUTPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_OUTPUT_GRAPH_EDGE_DESC.FromNodeIndex"]/*'/>

    public uint FromNodeIndex;

    /// <include file='DML_OUTPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_OUTPUT_GRAPH_EDGE_DESC.FromNodeOutputIndex"]/*'/>

    public uint FromNodeOutputIndex;

    /// <include file='DML_OUTPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_OUTPUT_GRAPH_EDGE_DESC.GraphOutputIndex"]/*'/>

    public uint GraphOutputIndex;

    /// <include file='DML_OUTPUT_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_OUTPUT_GRAPH_EDGE_DESC.Name"]/*'/>

    [NativeTypeName("const char *")]
    public sbyte* Name;
}
