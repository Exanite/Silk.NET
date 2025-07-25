// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE"]/*'/>
public enum DmlGraphEdgeType
{
    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INVALID"]/*'/>

    Invalid,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INPUT"]/*'/>

    Input,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_OUTPUT"]/*'/>

    Output,

    /// <include file='DML_GRAPH_EDGE_TYPE.xml' path='doc/member[@name="DML_GRAPH_EDGE_TYPE.DML_GRAPH_EDGE_TYPE_INTERMEDIATE"]/*'/>

    Intermediate,
}
