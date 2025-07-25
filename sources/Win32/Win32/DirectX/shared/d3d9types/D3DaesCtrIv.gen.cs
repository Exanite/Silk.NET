// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DAES_CTR_IV.xml' path='doc/member[@name="D3DAES_CTR_IV"]/*'/>
public partial struct D3DaesCtrIv
{
    /// <include file='D3DAES_CTR_IV.xml' path='doc/member[@name="D3DAES_CTR_IV.IV"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Iv;

    /// <include file='D3DAES_CTR_IV.xml' path='doc/member[@name="D3DAES_CTR_IV.Count"]/*'/>

    [NativeTypeName("UINT64")]
    public ulong Count;
}
