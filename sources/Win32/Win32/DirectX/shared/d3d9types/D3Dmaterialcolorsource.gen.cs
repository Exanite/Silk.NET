// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE"]/*'/>
public enum D3Dmaterialcolorsource
{
    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_MATERIAL"]/*'/>

    Material = 0,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_COLOR1"]/*'/>

    Color1 = 1,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_COLOR2"]/*'/>

    Color2 = 2,

    /// <include file='D3DMATERIALCOLORSOURCE.xml' path='doc/member[@name="D3DMATERIALCOLORSOURCE.D3DMCS_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
