// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS"]/*'/>
public enum D3D12VideoDecodeStatus
{
    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_OK"]/*'/>

    Ok = 0,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_CONTINUE"]/*'/>

    Continue = 1,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_CONTINUE_SKIP_DISPLAY"]/*'/>

    ContinueSkipDisplay = 2,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_RESTART"]/*'/>

    Restart = 3,

    /// <include file='D3D12_VIDEO_DECODE_STATUS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_STATUS.D3D12_VIDEO_DECODE_STATUS_RATE_EXCEEDED"]/*'/>

    RateExceeded = 4,
}
