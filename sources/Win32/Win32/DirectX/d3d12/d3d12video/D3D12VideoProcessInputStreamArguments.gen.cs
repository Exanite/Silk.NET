// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS"]/*'/>
public partial struct D3D12VideoProcessInputStreamArguments
{
    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.InputStream"]/*'/>

    [NativeTypeName("D3D12_VIDEO_PROCESS_INPUT_STREAM[2]")]
    public _InputStream_e__FixedBuffer InputStream;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.Transform"]/*'/>

    public D3D12VideoProcessTransform Transform;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.Flags"]/*'/>

    public D3D12VideoProcessInputStreamFlags Flags;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.RateInfo"]/*'/>

    public D3D12VideoProcessInputStreamRate RateInfo;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.FilterLevels"]/*'/>

    [NativeTypeName("INT[32]")]
    public _FilterLevels_e__FixedBuffer FilterLevels;

    /// <include file='D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS.AlphaBlending"]/*'/>

    public D3D12VideoProcessAlphaBlending AlphaBlending;

    /// <include file='_InputStream_e__FixedBuffer.xml' path='doc/member[@name="_InputStream_e__FixedBuffer"]/*'/>

    [InlineArray(2)]
    public partial struct _InputStream_e__FixedBuffer
    {
        public D3D12VideoProcessInputStream e0;
    }

    /// <include file='_FilterLevels_e__FixedBuffer.xml' path='doc/member[@name="_FilterLevels_e__FixedBuffer"]/*'/>

    [InlineArray(32)]
    public partial struct _FilterLevels_e__FixedBuffer
    {
        public int e0;
    }
}
