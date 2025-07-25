// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION"]/*'/>
public partial struct D3D12VideoDecodeConfiguration
{
    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.DecodeProfile"]/*'/>

    public Guid DecodeProfile;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.BitstreamEncryption"]/*'/>

    public D3D12BitstreamEncryptionType BitstreamEncryption;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.InterlaceType"]/*'/>

    public D3D12VideoFrameCodedInterlaceType InterlaceType;
}
