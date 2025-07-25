// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS"]/*'/>
[Flags]
public enum D3D12GpuBasedValidationPipelineStateCreateFlags
{
    /// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_NONE"]/*'/>

    FlagNone = 0,

    /// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_TRACKING_ONLY_SHADERS"]/*'/>

    FlagFrontLoadCreateTrackingOnlyShaders = 0x1,

    /// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_UNGUARDED_VALIDATION_SHADERS"]/*'/>

    FlagFrontLoadCreateUnguardedValidationShaders = 0x2,

    /// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAG_FRONT_LOAD_CREATE_GUARDED_VALIDATION_SHADERS"]/*'/>

    FlagFrontLoadCreateGuardedValidationShaders = 0x4,

    /// <include file='D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.xml' path='doc/member[@name="D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS.D3D12_GPU_BASED_VALIDATION_PIPELINE_STATE_CREATE_FLAGS_VALID_MASK"]/*'/>

    FlagsValidMask = 0x7,
}
