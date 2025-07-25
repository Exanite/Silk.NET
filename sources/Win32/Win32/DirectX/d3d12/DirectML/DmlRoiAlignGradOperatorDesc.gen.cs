// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC"]/*'/>
public unsafe partial struct DmlRoiAlignGradOperatorDesc
{
    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.InputTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputTensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.InputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* InputGradientTensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.ROITensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* ROITensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.BatchIndicesTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* BatchIndicesTensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.OutputGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputGradientTensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.OutputROIGradientTensor"]/*'/>

    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DmlTensorDesc* OutputROIGradientTensor;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.ReductionFunction"]/*'/>

    public DmlReduceFunction ReductionFunction;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.InterpolationMode"]/*'/>

    public DmlInterpolationMode InterpolationMode;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.SpatialScaleX"]/*'/>

    public float SpatialScaleX;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.SpatialScaleY"]/*'/>

    public float SpatialScaleY;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.InputPixelOffset"]/*'/>

    public float InputPixelOffset;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.OutputPixelOffset"]/*'/>

    public float OutputPixelOffset;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.MinimumSamplesPerOutput"]/*'/>

    public uint MinimumSamplesPerOutput;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.MaximumSamplesPerOutput"]/*'/>

    public uint MaximumSamplesPerOutput;

    /// <include file='DML_ROI_ALIGN_GRAD_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN_GRAD_OPERATOR_DESC.AlignRegionsToCorners"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AlignRegionsToCorners;
}
