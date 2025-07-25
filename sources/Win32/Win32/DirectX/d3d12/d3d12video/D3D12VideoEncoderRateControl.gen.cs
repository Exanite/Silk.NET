// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL"]/*'/>
public partial struct D3D12VideoEncoderRateControl
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.Mode"]/*'/>

    public D3D12VideoEncoderRateControlMode Mode;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.Flags"]/*'/>

    public D3D12VideoEncoderRateControlFlags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.ConfigParams"]/*'/>

    public D3D12VideoEncoderRateControlConfigurationParams ConfigParams;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL.TargetFrameRate"]/*'/>

    public DxgiRational TargetFrameRate;
}
