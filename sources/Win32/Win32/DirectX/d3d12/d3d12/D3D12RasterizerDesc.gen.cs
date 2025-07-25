// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC"]/*'/>
public partial struct D3D12RasterizerDesc
{
    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.FillMode"]/*'/>

    public D3D12FillMode FillMode;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.CullMode"]/*'/>

    public D3D12CullMode CullMode;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.FrontCounterClockwise"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> FrontCounterClockwise;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthBias"]/*'/>

    public int DepthBias;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthBiasClamp"]/*'/>

    public float DepthBiasClamp;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.SlopeScaledDepthBias"]/*'/>

    public float SlopeScaledDepthBias;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.DepthClipEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> DepthClipEnable;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.MultisampleEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> MultisampleEnable;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.AntialiasedLineEnable"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AntialiasedLineEnable;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.ForcedSampleCount"]/*'/>

    public uint ForcedSampleCount;

    /// <include file='D3D12_RASTERIZER_DESC.xml' path='doc/member[@name="D3D12_RASTERIZER_DESC.ConservativeRaster"]/*'/>

    public D3D12ConservativeRasterizationMode ConservativeRaster;
}
