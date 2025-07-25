// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS"]/*'/>
public unsafe partial struct D3D12FeatureDataFeatureLevels
{
    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.NumFeatureLevels"]/*'/>

    public uint NumFeatureLevels;

    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.pFeatureLevelsRequested"]/*'/>

    [NativeTypeName("const D3D_FEATURE_LEVEL *")]
    public D3DFeatureLevel* PFeatureLevelsRequested;

    /// <include file='D3D12_FEATURE_DATA_FEATURE_LEVELS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FEATURE_LEVELS.MaxSupportedFeatureLevel"]/*'/>

    public D3DFeatureLevel MaxSupportedFeatureLevel;
}
