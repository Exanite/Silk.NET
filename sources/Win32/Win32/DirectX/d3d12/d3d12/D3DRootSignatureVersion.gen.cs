// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION"]/*'/>
public enum D3DRootSignatureVersion
{
    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1"]/*'/>

    Version1 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_0"]/*'/>

    Version1X0 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_1"]/*'/>

    Version1X1 = 0x2,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_2"]/*'/>

    Version1X2 = 0x3,
}
