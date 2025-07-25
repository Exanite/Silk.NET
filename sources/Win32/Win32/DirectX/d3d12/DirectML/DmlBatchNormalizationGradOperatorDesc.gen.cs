// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlBatchNormalizationGradOperatorDesc
{
    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.InputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.MeanTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* MeanTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.VarianceTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* VarianceTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.ScaleTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* ScaleTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.OutputScaleGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputScaleGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.OutputBiasGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputBiasGradientTensor;

    /// <include file='DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_BATCH_NORMALIZATION_GRAD_OPERATOR_DESC.Epsilon"]/*'/>

    public float Epsilon;
}
