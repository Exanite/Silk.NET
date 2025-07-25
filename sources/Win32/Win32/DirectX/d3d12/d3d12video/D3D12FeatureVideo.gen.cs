// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO"]/*'/>
public enum D3D12FeatureVideo
{
    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_SUPPORT"]/*'/>

    DecodeSupport = 0,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_PROFILES"]/*'/>

    DecodeProfiles = 1,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_FORMATS"]/*'/>

    DecodeFormats = 2,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_CONVERSION_SUPPORT"]/*'/>

    DecodeConversionSupport = 3,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESS_SUPPORT"]/*'/>

    ProcessSupport = 5,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESS_MAX_INPUT_STREAMS"]/*'/>

    ProcessMaxInputStreams = 6,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESS_REFERENCE_INFO"]/*'/>

    ProcessReferenceInfo = 7,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE"]/*'/>

    DecoderHeapSize = 8,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESSOR_SIZE"]/*'/>

    ProcessorSize = 9,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_PROFILE_COUNT"]/*'/>

    DecodeProfileCount = 10,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_FORMAT_COUNT"]/*'/>

    DecodeFormatCount = 11,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ARCHITECTURE"]/*'/>

    Architecture = 17,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_HISTOGRAM"]/*'/>

    DecodeHistogram = 18,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_FEATURE_AREA_SUPPORT"]/*'/>

    FeatureAreaSupport = 19,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR"]/*'/>

    MotionEstimator = 20,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_SIZE"]/*'/>

    MotionEstimatorSize = 21,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_COUNT"]/*'/>

    ExtensionCommandCount = 22,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMANDS"]/*'/>

    ExtensionCommands = 23,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT"]/*'/>

    ExtensionCommandParameterCount = 24,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_PARAMETERS"]/*'/>

    ExtensionCommandParameters = 25,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SUPPORT"]/*'/>

    ExtensionCommandSupport = 26,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_EXTENSION_COMMAND_SIZE"]/*'/>

    ExtensionCommandSize = 27,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODE_PROTECTED_RESOURCES"]/*'/>

    DecodeProtectedResources = 28,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESS_PROTECTED_RESOURCES"]/*'/>

    ProcessProtectedResources = 29,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_MOTION_ESTIMATOR_PROTECTED_RESOURCES"]/*'/>

    MotionEstimatorProtectedResources = 30,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_DECODER_HEAP_SIZE1"]/*'/>

    DecoderHeapSize1 = 31,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_PROCESSOR_SIZE1"]/*'/>

    ProcessorSize1 = 32,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_CODEC"]/*'/>

    EncoderCodec = 33,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_PROFILE_LEVEL"]/*'/>

    EncoderProfileLevel = 34,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION_RATIOS_COUNT"]/*'/>

    EncoderOutputResolutionRatiosCount = 35,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_OUTPUT_RESOLUTION"]/*'/>

    EncoderOutputResolution = 36,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_INPUT_FORMAT"]/*'/>

    EncoderInputFormat = 37,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_RATE_CONTROL_MODE"]/*'/>

    EncoderRateControlMode = 38,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_INTRA_REFRESH_MODE"]/*'/>

    EncoderIntraRefreshMode = 39,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE"]/*'/>

    EncoderFrameSubregionLayoutMode = 40,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_HEAP_SIZE"]/*'/>

    EncoderHeapSize = 41,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_CODEC_CONFIGURATION_SUPPORT"]/*'/>

    EncoderCodecConfigurationSupport = 42,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_SUPPORT"]/*'/>

    EncoderSupport = 43,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT"]/*'/>

    EncoderCodecPictureControlSupport = 44,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_RESOURCE_REQUIREMENTS"]/*'/>

    EncoderResourceRequirements = 45,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_CONFIG"]/*'/>

    EncoderFrameSubregionLayoutConfig = 46,

    /// <include file='D3D12_FEATURE_VIDEO.xml' path='doc/member[@name="D3D12_FEATURE_VIDEO.D3D12_FEATURE_VIDEO_ENCODER_SUPPORT1"]/*'/>

    EncoderSupport1 = 47,
}
