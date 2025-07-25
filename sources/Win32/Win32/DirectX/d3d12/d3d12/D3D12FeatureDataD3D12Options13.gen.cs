// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13"]/*'/>
public partial struct D3D12FeatureDataD3D12Options13
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.UnrestrictedBufferTextureCopyPitchSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> UnrestrictedBufferTextureCopyPitchSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.UnrestrictedVertexElementAlignmentSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> UnrestrictedVertexElementAlignmentSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.InvertedViewportHeightFlipsYSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> InvertedViewportHeightFlipsYSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.InvertedViewportDepthFlipsZSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> InvertedViewportDepthFlipsZSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.TextureCopyBetweenDimensionsSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> TextureCopyBetweenDimensionsSupported;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS13.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS13.AlphaBlendFactorSupported"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AlphaBlendFactorSupported;
}
