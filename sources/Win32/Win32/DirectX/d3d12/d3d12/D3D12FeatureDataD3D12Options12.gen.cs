// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12"]/*'/>
public partial struct D3D12FeatureDataD3D12Options12
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.MSPrimitivesPipelineStatisticIncludesCulledPrimitives"]/*'/>

    public D3D12TriState MSPrimitivesPipelineStatisticIncludesCulledPrimitives;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.EnhancedBarriersSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> EnhancedBarriersSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS12.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS12.RelaxedFormatCastingSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> RelaxedFormatCastingSupported;
}
