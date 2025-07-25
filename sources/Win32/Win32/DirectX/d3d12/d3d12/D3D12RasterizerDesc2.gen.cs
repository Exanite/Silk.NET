// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2"]/*'/>
public partial struct D3D12RasterizerDesc2
{
    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.FillMode"]/*'/>

    public D3D12FillMode FillMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.CullMode"]/*'/>

    public D3D12CullMode CullMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.FrontCounterClockwise"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> FrontCounterClockwise;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthBias"]/*'/>

    public float DepthBias;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthBiasClamp"]/*'/>

    public float DepthBiasClamp;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.SlopeScaledDepthBias"]/*'/>

    public float SlopeScaledDepthBias;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.DepthClipEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DepthClipEnable;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.LineRasterizationMode"]/*'/>

    public D3D12LineRasterizationMode LineRasterizationMode;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.ForcedSampleCount"]/*'/>

    public uint ForcedSampleCount;

    /// <include file='D3D12_RASTERIZER_DESC2.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC2.ConservativeRaster"]/*'/>

    public D3D12ConservativeRasterizationMode ConservativeRaster;
}
