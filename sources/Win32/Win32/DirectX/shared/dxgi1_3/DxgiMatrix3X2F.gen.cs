// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct DxgiMatrix3X2F
{
    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._11"]/*'/>

    public float X11;

    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._12"]/*'/>

    public float X12;

    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._21"]/*'/>

    public float X21;

    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._22"]/*'/>

    public float X22;

    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._31"]/*'/>

    public float X31;

    /// <include file='DXGI_MATRIX_3X2_F.xml' path='doc/member[@name="DXGI_MATRIX_3X2_F._32"]/*'/>

    public float X32;
}
