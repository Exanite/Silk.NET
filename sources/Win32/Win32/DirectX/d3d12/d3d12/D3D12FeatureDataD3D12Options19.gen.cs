// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19"]/*'/>
public partial struct D3D12FeatureDataD3D12Options19
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MismatchingOutputDimensionsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> MismatchingOutputDimensionsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.SupportedSampleCountsWithNoOutputs"]/*'/>

    public uint SupportedSampleCountsWithNoOutputs;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.PointSamplingAddressesNeverRoundUp"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> PointSamplingAddressesNeverRoundUp;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.RasterizerDesc2Supported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> RasterizerDesc2Supported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.NarrowQuadrilateralLinesSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> NarrowQuadrilateralLinesSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.AnisoFilterWithPointMipSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AnisoFilterWithPointMipSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxSamplerDescriptorHeapSize"]/*'/>

    public uint MaxSamplerDescriptorHeapSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxSamplerDescriptorHeapSizeWithStaticSamplers"]/*'/>

    public uint MaxSamplerDescriptorHeapSizeWithStaticSamplers;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.MaxViewDescriptorHeapSize"]/*'/>

    public uint MaxViewDescriptorHeapSize;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS19.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS19.ComputeOnlyCustomHeapSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> ComputeOnlyCustomHeapSupported;
}
