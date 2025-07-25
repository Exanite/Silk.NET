// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION"]/*'/>
public enum D3Ddisplayrotation
{
    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_IDENTITY"]/*'/>

    Identity = 1,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_90"]/*'/>

    X90 = 2,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_180"]/*'/>

    X180 = 3,

    /// <include file='D3DDISPLAYROTATION.xml' path='doc/member[@name="D3DDISPLAYROTATION.D3DDISPLAYROTATION_270"]/*'/>

    X270 = 4,
}
