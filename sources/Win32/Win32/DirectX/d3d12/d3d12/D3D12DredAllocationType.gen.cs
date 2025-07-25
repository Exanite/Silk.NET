// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE"]/*'/>
public enum D3D12DredAllocationType
{
    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_QUEUE"]/*'/>

    CommandQueue = 19,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_ALLOCATOR"]/*'/>

    CommandAllocator = 20,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PIPELINE_STATE"]/*'/>

    PipelineState = 21,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_LIST"]/*'/>

    CommandList = 22,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_FENCE"]/*'/>

    Fence = 23,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_DESCRIPTOR_HEAP"]/*'/>

    DescriptorHeap = 24,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_HEAP"]/*'/>

    Heap = 25,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_QUERY_HEAP"]/*'/>

    QueryHeap = 27,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_SIGNATURE"]/*'/>

    CommandSignature = 28,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PIPELINE_LIBRARY"]/*'/>

    PipelineLibrary = 29,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER"]/*'/>

    VideoDecoder = 30,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_PROCESSOR"]/*'/>

    VideoProcessor = 32,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_RESOURCE"]/*'/>

    Resource = 34,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PASS"]/*'/>

    Pass = 35,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSION"]/*'/>

    Cryptosession = 36,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_CRYPTOSESSIONPOLICY"]/*'/>

    Cryptosessionpolicy = 37,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_PROTECTEDRESOURCESESSION"]/*'/>

    Protectedresourcesession = 38,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_DECODER_HEAP"]/*'/>

    VideoDecoderHeap = 39,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_POOL"]/*'/>

    CommandPool = 40,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_COMMAND_RECORDER"]/*'/>

    CommandRecorder = 41,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_STATE_OBJECT"]/*'/>

    StateObject = 42,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_METACOMMAND"]/*'/>

    Metacommand = 43,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_SCHEDULINGGROUP"]/*'/>

    Schedulinggroup = 44,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_ESTIMATOR"]/*'/>

    VideoMotionEstimator = 45,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_MOTION_VECTOR_HEAP"]/*'/>

    VideoMotionVectorHeap = 46,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_EXTENSION_COMMAND"]/*'/>

    VideoExtensionCommand = 47,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER"]/*'/>

    VideoEncoder = 48,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_VIDEO_ENCODER_HEAP"]/*'/>

    VideoEncoderHeap = 49,

    /// <include file='D3D12_DRED_ALLOCATION_TYPE.xml' path='doc/member[@name="D3D12_DRED_ALLOCATION_TYPE.D3D12_DRED_ALLOCATION_TYPE_INVALID"]/*'/>

    Invalid = unchecked((int)(0xffffffff)),
}
