// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE"]/*'/>
public enum D3D12DebugDeviceParameterType
{
    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS"]/*'/>

    FeatureFlags = 0,

    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS"]/*'/>

    GpuBasedValidationSettings = (FeatureFlags + 1),

    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR"]/*'/>

    GpuSlowdownPerformanceFactor = (GpuBasedValidationSettings + 1),
}
