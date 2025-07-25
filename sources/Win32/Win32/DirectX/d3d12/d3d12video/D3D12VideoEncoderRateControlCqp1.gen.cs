// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1"]/*'/>
public partial struct D3D12VideoEncoderRateControlCqp1
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.ConstantQP_FullIntracodedFrame"]/*'/>

    public uint ConstantQPFullIntracodedFrame;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.ConstantQP_InterPredictedFrame_PrevRefOnly"]/*'/>

    public uint ConstantQPInterPredictedFramePrevRefOnly;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.ConstantQP_InterPredictedFrame_BiDirectionalRef"]/*'/>

    public uint ConstantQPInterPredictedFrameBiDirectionalRef;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1.QualityVsSpeed"]/*'/>

    public uint QualityVsSpeed;
}
