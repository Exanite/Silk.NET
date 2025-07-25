// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE"]/*'/>
public enum D3DvsAddressmodeType
{
    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_ABSOLUTE"]/*'/>

    Absolute = (0 << 13),

    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_RELATIVE"]/*'/>

    Relative = (1 << 13),

    /// <include file='D3DVS_ADDRESSMODE_TYPE.xml' path='doc/member[@name="D3DVS_ADDRESSMODE_TYPE.D3DVS_ADDRMODE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
