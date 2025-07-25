// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_DRED_VERSION.xml' path='doc/member[@name="D3D12_DRED_VERSION"]/*'/>
public enum D3D12DredVersion
{
    /// <include file='D3D12_DRED_VERSION.xml' path='doc/member[@name="D3D12_DRED_VERSION.D3D12_DRED_VERSION_1_0"]/*'/>

    X1X0 = 0x1,

    /// <include file='D3D12_DRED_VERSION.xml' path='doc/member[@name="D3D12_DRED_VERSION.D3D12_DRED_VERSION_1_1"]/*'/>

    X1X1 = 0x2,

    /// <include file='D3D12_DRED_VERSION.xml' path='doc/member[@name="D3D12_DRED_VERSION.D3D12_DRED_VERSION_1_2"]/*'/>

    X1X2 = 0x3,

    /// <include file='D3D12_DRED_VERSION.xml' path='doc/member[@name="D3D12_DRED_VERSION.D3D12_DRED_VERSION_1_3"]/*'/>

    X1X3 = 0x4,
}
