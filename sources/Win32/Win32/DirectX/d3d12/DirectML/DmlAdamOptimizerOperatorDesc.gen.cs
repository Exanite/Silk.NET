// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlAdamOptimizerOperatorDesc
{
    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.InputParametersTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputParametersTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.InputFirstMomentTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputFirstMomentTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.InputSecondMomentTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputSecondMomentTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.GradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* GradientTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.TrainingStepTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* TrainingStepTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.OutputParametersTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputParametersTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.OutputFirstMomentTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputFirstMomentTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.OutputSecondMomentTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputSecondMomentTensor;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.LearningRate"]/*'/>

    public float LearningRate;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.Beta1"]/*'/>

    public float Beta1;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.Beta2"]/*'/>

    public float Beta2;

    /// <include file='DML_ADAM_OPTIMIZER_OPERATOR_DESC.xml' path='doc/member[@name="DML_ADAM_OPTIMIZER_OPERATOR_DESC.Epsilon"]/*'/>

    public float Epsilon;
}
