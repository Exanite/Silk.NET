// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlJoinOperatorDesc
{
    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.InputCount"]/*'/>

    public uint InputCount;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.InputTensors"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensors;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.Axis"]/*'/>

    public uint Axis;
}
