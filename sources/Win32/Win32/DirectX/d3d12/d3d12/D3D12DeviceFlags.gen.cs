// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS"]/*'/>
[Flags]
public enum D3D12DeviceFlags
{
    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DEBUG_LAYER_ENABLED"]/*'/>

    DebugLayerEnabled = 0x1,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_GPU_BASED_VALIDATION_ENABLED"]/*'/>

    GpuBasedValidationEnabled = 0x2,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_SYNCHRONIZED_COMMAND_QUEUE_VALIDATION_DISABLED"]/*'/>

    SynchronizedCommandQueueValidationDisabled = 0x4,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_AUTO_BREADCRUMBS_ENABLED"]/*'/>

    DredAutoBreadcrumbsEnabled = 0x8,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_PAGE_FAULT_REPORTING_ENABLED"]/*'/>

    DredPageFaultReportingEnabled = 0x10,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_WATSON_REPORTING_ENABLED"]/*'/>

    DredWatsonReportingEnabled = 0x20,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_BREADCRUMB_CONTEXT_ENABLED"]/*'/>

    DredBreadcrumbContextEnabled = 0x40,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_DRED_USE_MARKERS_ONLY_BREADCRUMBS"]/*'/>

    DredUseMarkersOnlyBreadcrumbs = 0x80,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_SHADER_INSTRUMENTATION_ENABLED"]/*'/>

    ShaderInstrumentationEnabled = 0x100,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_AUTO_DEBUG_NAME_ENABLED"]/*'/>

    AutoDebugNameEnabled = 0x200,

    /// <include file='D3D12_DEVICE_FLAGS.xml' path='doc/member[@name="D3D12_DEVICE_FLAGS.D3D12_DEVICE_FLAG_FORCE_LEGACY_STATE_VALIDATION"]/*'/>

    ForceLegacyStateValidation = 0x400,
}
