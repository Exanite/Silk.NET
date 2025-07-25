// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE"]/*'/>
public enum D3D12VideoEncoderRateControlMode
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_ABSOLUTE_QP_MAP"]/*'/>

    AbsoluteQpMap = 0,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CQP"]/*'/>

    Cqp = 1,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_CBR"]/*'/>

    Cbr = 2,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_VBR"]/*'/>

    Vbr = 3,

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE.D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE_QVBR"]/*'/>

    Qvbr = 4,
}
