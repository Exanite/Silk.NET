// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE"]/*'/>
public partial struct D3D12FeatureDataArchitecture
{
    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.NodeIndex"]/*'/>

    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.TileBasedRenderer"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> TileBasedRenderer;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.UMA"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> Uma;

    /// <include file='D3D12_FEATURE_DATA_ARCHITECTURE.xml' path='doc/member[@name="D3D12_FEATURE_DATA_ARCHITECTURE.CacheCoherentUMA"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> CacheCoherentUMA;
}
