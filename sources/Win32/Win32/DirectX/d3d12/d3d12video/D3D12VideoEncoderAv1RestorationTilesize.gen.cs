// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE"]/*'/>
public enum D3D12VideoEncoderAv1RestorationTilesize
{
    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_DISABLED"]/*'/>

    TilesizeDisabled = 0,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_32x32"]/*'/>

    Tilesize32X32 = 1,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_64x64"]/*'/>

    Tilesize64X64 = 2,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_128x128"]/*'/>

    Tilesize128X128 = 3,

    /// <include file='D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE.D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE_256x256"]/*'/>

    Tilesize256X256 = 4,
}
