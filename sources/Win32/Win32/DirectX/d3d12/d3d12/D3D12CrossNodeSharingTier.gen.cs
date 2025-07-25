// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER"]/*'/>
public enum D3D12CrossNodeSharingTier
{
    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_NOT_SUPPORTED"]/*'/>

    TierNotSupported = 0,

    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_1_EMULATED"]/*'/>

    Tier1Emulated = 1,

    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_1"]/*'/>

    Tier1 = 2,

    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_2"]/*'/>

    Tier2 = 3,

    /// <include file='D3D12_CROSS_NODE_SHARING_TIER.xml' path='doc/member[@name="D3D12_CROSS_NODE_SHARING_TIER.D3D12_CROSS_NODE_SHARING_TIER_3"]/*'/>

    Tier3 = 4,
}
