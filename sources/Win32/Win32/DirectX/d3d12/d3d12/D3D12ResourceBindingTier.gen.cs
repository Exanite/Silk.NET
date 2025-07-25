// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RESOURCE_BINDING_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_BINDING_TIER"]/*'/>
public enum D3D12ResourceBindingTier
{
    /// <include file='D3D12_RESOURCE_BINDING_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_BINDING_TIER.D3D12_RESOURCE_BINDING_TIER_1"]/*'/>

    Tier1 = 1,

    /// <include file='D3D12_RESOURCE_BINDING_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_BINDING_TIER.D3D12_RESOURCE_BINDING_TIER_2"]/*'/>

    Tier2 = 2,

    /// <include file='D3D12_RESOURCE_BINDING_TIER.xml' path='doc/member[@name="D3D12_RESOURCE_BINDING_TIER.D3D12_RESOURCE_BINDING_TIER_3"]/*'/>

    Tier3 = 3,
}
