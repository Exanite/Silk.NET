// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE"]/*'/>
public enum D3Dsamplerstatetype
{
    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSU"]/*'/>

    Addressu = 1,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSV"]/*'/>

    Addressv = 2,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ADDRESSW"]/*'/>

    Addressw = 3,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_BORDERCOLOR"]/*'/>

    Bordercolor = 4,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAGFILTER"]/*'/>

    Magfilter = 5,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MINFILTER"]/*'/>

    Minfilter = 6,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MIPFILTER"]/*'/>

    Mipfilter = 7,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MIPMAPLODBIAS"]/*'/>

    Mipmaplodbias = 8,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAXMIPLEVEL"]/*'/>

    Maxmiplevel = 9,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_MAXANISOTROPY"]/*'/>

    Maxanisotropy = 10,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_SRGBTEXTURE"]/*'/>

    Srgbtexture = 11,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_ELEMENTINDEX"]/*'/>

    Elementindex = 12,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_DMAPOFFSET"]/*'/>

    Dmapoffset = 13,

    /// <include file='D3DSAMPLERSTATETYPE.xml' path='doc/member[@name="D3DSAMPLERSTATETYPE.D3DSAMP_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
