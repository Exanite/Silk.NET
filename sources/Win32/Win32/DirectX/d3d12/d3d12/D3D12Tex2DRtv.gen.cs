// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_TEX2D_RTV.xml' path='doc/member[@name="D3D12_TEX2D_RTV"]/*'/>
public partial struct D3D12Tex2DRtv
{
    /// <include file='D3D12_TEX2D_RTV.xml' path='doc/member[@name="D3D12_TEX2D_RTV.MipSlice"]/*'/>

    public uint MipSlice;

    /// <include file='D3D12_TEX2D_RTV.xml' path='doc/member[@name="D3D12_TEX2D_RTV.PlaneSlice"]/*'/>

    public uint PlaneSlice;
}
