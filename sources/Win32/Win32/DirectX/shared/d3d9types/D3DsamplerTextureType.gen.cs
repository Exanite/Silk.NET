// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE"]/*'/>
public enum D3DsamplerTextureType
{
    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_UNKNOWN"]/*'/>

    Unknown = 0 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_2D"]/*'/>

    X2D = 2 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_CUBE"]/*'/>

    Cube = 3 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_VOLUME"]/*'/>

    Volume = 4 << 27,

    /// <include file='D3DSAMPLER_TEXTURE_TYPE.xml' path='doc/member[@name="D3DSAMPLER_TEXTURE_TYPE.D3DSTT_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
