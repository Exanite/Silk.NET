// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlLocalResponseNormalizationGradOperatorDesc
{
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.InputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputGradientTensor;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputGradientTensor;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.CrossChannel"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CrossChannel;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.LocalSize"]/*'/>

    public uint LocalSize;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Alpha"]/*'/>

    public float Alpha;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Beta"]/*'/>

    public float Beta;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_GRAD_OPERATOR_DESC.Bias"]/*'/>

    public float Bias;
}
