// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC"]/*'/>
public partial struct D3D12VideoEncoderDesc
{
    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.NodeMask"]/*'/>

    public uint NodeMask;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.Flags"]/*'/>

    public D3D12VideoEncoderFlags Flags;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.EncodeCodec"]/*'/>

    public D3D12VideoEncoderCodec EncodeCodec;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.EncodeProfile"]/*'/>

    public D3D12VideoEncoderProfileDesc EncodeProfile;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.InputFormat"]/*'/>

    public DxgiFormat InputFormat;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.CodecConfiguration"]/*'/>

    public D3D12VideoEncoderCodecConfiguration CodecConfiguration;

    /// <include file='D3D12_VIDEO_ENCODER_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_DESC.MaxMotionEstimationPrecision"]/*'/>

    public D3D12VideoEncoderMotionEstimationPrecisionMode MaxMotionEstimationPrecision;
}
