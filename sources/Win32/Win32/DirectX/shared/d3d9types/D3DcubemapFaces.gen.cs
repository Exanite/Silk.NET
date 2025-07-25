// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES"]/*'/>
public enum D3DcubemapFaces
{
    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_X"]/*'/>

    PositiveX = 0,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_X"]/*'/>

    NegativeX = 1,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_Y"]/*'/>

    PositiveY = 2,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_Y"]/*'/>

    NegativeY = 3,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_POSITIVE_Z"]/*'/>

    PositiveZ = 4,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_NEGATIVE_Z"]/*'/>

    NegativeZ = 5,

    /// <include file='D3DCUBEMAP_FACES.xml' path='doc/member[@name="D3DCUBEMAP_FACES.D3DCUBEMAP_FACE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
