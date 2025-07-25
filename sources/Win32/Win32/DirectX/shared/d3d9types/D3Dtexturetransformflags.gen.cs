// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS"]/*'/>
public enum D3Dtexturetransformflags
{
    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_DISABLE"]/*'/>

    Disable = 0,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT1"]/*'/>

    Count1 = 1,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT2"]/*'/>

    Count2 = 2,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT3"]/*'/>

    Count3 = 3,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_COUNT4"]/*'/>

    Count4 = 4,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_PROJECTED"]/*'/>

    Projected = 256,

    /// <include file='D3DTEXTURETRANSFORMFLAGS.xml' path='doc/member[@name="D3DTEXTURETRANSFORMFLAGS.D3DTTFF_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
