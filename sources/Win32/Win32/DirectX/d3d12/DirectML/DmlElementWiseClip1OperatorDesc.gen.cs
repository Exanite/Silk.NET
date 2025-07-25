// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlElementWiseClip1OperatorDesc
{
    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.OutputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputTensor;

    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.ScaleBias"]/*'/>

    [NativeTypeName("const DML_SCALE_BIAS *")]
    public DmlScaleBias* ScaleBias;

    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.MinMaxDataType"]/*'/>

    public DmlTensorDataType MinMaxDataType;

    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.Min"]/*'/>

    public DmlScalarUnion Min;

    /// <include file='DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ELEMENT_WISE_CLIP1_OPERATOR_DESC.Max"]/*'/>

    public DmlScalarUnion Max;
}
