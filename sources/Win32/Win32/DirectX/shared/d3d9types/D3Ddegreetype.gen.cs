// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE"]/*'/>
public enum D3Ddegreetype
{
    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_LINEAR"]/*'/>

    Linear = 1,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_QUADRATIC"]/*'/>

    Quadratic = 2,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_CUBIC"]/*'/>

    Cubic = 3,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_QUINTIC"]/*'/>

    Quintic = 5,

    /// <include file='D3DDEGREETYPE.xml' path='doc/member[@name="D3DDEGREETYPE.D3DDEGREE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
