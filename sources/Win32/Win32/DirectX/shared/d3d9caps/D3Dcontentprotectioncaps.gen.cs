// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS"]/*'/>
public partial struct D3Dcontentprotectioncaps
{
    /// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS.Caps"]/*'/>

    [NativeTypeName("DWORD")]
    public uint Caps;

    /// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS.KeyExchangeType"]/*'/>

    public Guid KeyExchangeType;

    /// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS.BufferAlignmentStart"]/*'/>

    public uint BufferAlignmentStart;

    /// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS.BlockAlignmentSize"]/*'/>

    public uint BlockAlignmentSize;

    /// <include file='D3DCONTENTPROTECTIONCAPS.xml' path='doc/member[@name="D3DCONTENTPROTECTIONCAPS.ProtectedMemorySize"]/*'/>

    [NativeTypeName("ULONGLONG")]
    public ulong ProtectedMemorySize;
}
