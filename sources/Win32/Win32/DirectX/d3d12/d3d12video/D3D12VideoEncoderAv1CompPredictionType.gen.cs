// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE"]/*'/>
public enum D3D12VideoEncoderAv1CompPredictionType
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE.D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_SINGLE_REFERENCE"]/*'/>

    SingleReference = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE.D3D12_VIDEO_ENCODER_AV1_COMP_PREDICTION_TYPE_COMPOUND_REFERENCE"]/*'/>

    CompoundReference = 1,
}
