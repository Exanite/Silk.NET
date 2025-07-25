// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT"]/*'/>
public partial struct D3D12FeatureDataFormatSupport
{
    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Format"]/*'/>

    public DxgiFormat Format;

    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Support1"]/*'/>

    public D3D12FormatSupport1 Support1;

    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Support2"]/*'/>

    public D3D12FormatSupport2 Support2;
}
