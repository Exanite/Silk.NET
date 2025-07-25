// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS"]/*'/>
[Flags]
public enum D3D12VideoProcessAutoProcessingFlags
{
    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE"]/*'/>

    Denoise = 0x1,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING"]/*'/>

    Deringing = 0x2,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT"]/*'/>

    EdgeEnhancement = 0x4,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION"]/*'/>

    ColorCorrection = 0x8,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING"]/*'/>

    FleshToneMapping = 0x10,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION"]/*'/>

    ImageStabilization = 0x20,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION"]/*'/>

    SuperResolution = 0x40,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING"]/*'/>

    AnamorphicScaling = 0x80,

    /// <include file='D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS.D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM"]/*'/>

    Custom = unchecked((int)(0x80000000)),
}
