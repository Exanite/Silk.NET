// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES"]/*'/>
public unsafe partial struct D3D12FeatureDataProtectedResourceSessionTypes
{
    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.Count"]/*'/>

    public uint Count;

    /// <include file='D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.xml' path='doc/member[@name="D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES.pTypes"]/*'/>

    public Guid* PTypes;
}
