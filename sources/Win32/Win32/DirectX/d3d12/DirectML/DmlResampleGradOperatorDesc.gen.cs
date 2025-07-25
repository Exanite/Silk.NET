// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlResampleGradOperatorDesc
{
    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputGradientTensor;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputGradientTensor;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InterpolationMode"]/*'/>

    public DmlInterpolationMode InterpolationMode;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.DimensionCount"]/*'/>

    public uint DimensionCount;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.Scales"]/*'/>

    [NativeTypeName("const FLOAT *")]
    public float* Scales;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.InputPixelOffsets"]/*'/>

    [NativeTypeName("const FLOAT *")]
    public float* InputPixelOffsets;

    /// <include file='DML_RESAMPLE_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_RESAMPLE_GRAD_OPERATOR_DESC.OutputPixelOffsets"]/*'/>

    [NativeTypeName("const FLOAT *")]
    public float* OutputPixelOffsets;
}
