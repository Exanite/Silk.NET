// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoEncoderAv1TxModeFlags
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_ONLY4x4"]/*'/>

    ONLY4X4 = (1 << D3D12VideoEncoderAv1TxMode.ONLY4X4),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_LARGEST"]/*'/>

    Largest = (1 << D3D12VideoEncoderAv1TxMode.Largest),

    /// <include file='D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAGS.D3D12_VIDEO_ENCODER_AV1_TX_MODE_FLAG_SELECT"]/*'/>

    Select = (1 << D3D12VideoEncoderAv1TxMode.Select),
}
