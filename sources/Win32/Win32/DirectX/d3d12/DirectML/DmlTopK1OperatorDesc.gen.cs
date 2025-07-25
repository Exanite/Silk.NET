// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlTopK1OperatorDesc
{
    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.OutputValueTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputValueTensor;

    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.OutputIndexTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputIndexTensor;

    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.Axis"]/*'/>

    public uint Axis;

    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.K"]/*'/>

    public uint K;

    /// <include file='DML_TOP_K1_OPERATOR_DESC.xml' path='doc/member[@name="DML_TOP_K1_OPERATOR_DESC.AxisDirection"]/*'/>

    public DmlAxisDirection AxisDirection;
}
