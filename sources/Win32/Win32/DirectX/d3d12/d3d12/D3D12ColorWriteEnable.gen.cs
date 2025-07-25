// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE"]/*'/>
public enum D3D12ColorWriteEnable
{
    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_RED"]/*'/>

    Red = 1,

    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_GREEN"]/*'/>

    Green = 2,

    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_BLUE"]/*'/>

    Blue = 4,

    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_ALPHA"]/*'/>

    Alpha = 8,

    /// <include file='D3D12_COLOR_WRITE_ENABLE.xml' path='doc/member[@name="D3D12_COLOR_WRITE_ENABLE.D3D12_COLOR_WRITE_ENABLE_ALL"]/*'/>

    All = (((Red | Green) | Blue) | Alpha),
}
