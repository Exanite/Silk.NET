// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoEncoderAv1RestorationSupportFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_NOT_SUPPORTED"]/*'/>

    FlagNotSupported = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_32x32"]/*'/>

    FLAG32X32 = 0x1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_64x64"]/*'/>

    FLAG64X64 = 0x2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_128x128"]/*'/>

    FLAG128X128 = 0x4,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAGS.D3D12_VIDEO_ENCODER_AV1_RESTORATION_SUPPORT_FLAG_256x256"]/*'/>

    FLAG256X256 = 0x8,
}
