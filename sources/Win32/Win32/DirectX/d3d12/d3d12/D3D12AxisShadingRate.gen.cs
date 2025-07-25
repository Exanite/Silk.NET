// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE"]/*'/>
public enum D3D12AxisShadingRate
{
    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_1X"]/*'/>

    Rate1X = 0,

    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_2X"]/*'/>

    Rate2X = 0x1,

    /// <include file='D3D12_AXIS_SHADING_RATE.xml' path='doc/member[@name="D3D12_AXIS_SHADING_RATE.D3D12_AXIS_SHADING_RATE_4X"]/*'/>

    Rate4X = 0x2,
}
