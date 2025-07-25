// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL"]/*'/>
public enum D3Dpool
{
    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_DEFAULT"]/*'/>

    Default = 0,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_MANAGED"]/*'/>

    Managed = 1,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_SYSTEMMEM"]/*'/>

    Systemmem = 2,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_SCRATCH"]/*'/>

    Scratch = 3,

    /// <include file='D3DPOOL.xml' path='doc/member[@name="D3DPOOL.D3DPOOL_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
