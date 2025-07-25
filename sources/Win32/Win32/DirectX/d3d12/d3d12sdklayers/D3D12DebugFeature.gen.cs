// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE"]/*'/>
[Flags]
public enum D3D12DebugFeature
{
    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_ALLOW_BEHAVIOR_CHANGING_DEBUG_AIDS"]/*'/>

    AllowBehaviorChangingDebugAids = 0x1,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_CONSERVATIVE_RESOURCE_STATE_TRACKING"]/*'/>

    ConservativeResourceStateTracking = 0x2,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_DISABLE_VIRTUALIZED_BUNDLES_VALIDATION"]/*'/>

    DisableVirtualizedBundlesValidation = 0x4,

    /// <include file='D3D12_DEBUG_FEATURE.xml' path='doc/member[@name="D3D12_DEBUG_FEATURE.D3D12_DEBUG_FEATURE_EMULATE_WINDOWS7"]/*'/>

    EmulateWindows7 = 0x8,
}
