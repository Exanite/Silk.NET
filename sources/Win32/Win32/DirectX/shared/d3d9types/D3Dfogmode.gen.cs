// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE"]/*'/>
public enum D3Dfogmode
{
    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_NONE"]/*'/>

    None = 0,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_EXP"]/*'/>

    Exp = 1,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_EXP2"]/*'/>

    Exp2 = 2,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_LINEAR"]/*'/>

    Linear = 3,

    /// <include file='D3DFOGMODE.xml' path='doc/member[@name="D3DFOGMODE.D3DFOG_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
