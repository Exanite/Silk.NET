// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE"]/*'/>
public enum D3DmultisampleType
{
    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_NONE"]/*'/>

    None = 0,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_NONMASKABLE"]/*'/>

    Nonmaskable = 1,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_2_SAMPLES"]/*'/>

    X2Samples = 2,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_3_SAMPLES"]/*'/>

    X3Samples = 3,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_4_SAMPLES"]/*'/>

    X4Samples = 4,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_5_SAMPLES"]/*'/>

    X5Samples = 5,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_6_SAMPLES"]/*'/>

    X6Samples = 6,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_7_SAMPLES"]/*'/>

    X7Samples = 7,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_8_SAMPLES"]/*'/>

    X8Samples = 8,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_9_SAMPLES"]/*'/>

    X9Samples = 9,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_10_SAMPLES"]/*'/>

    X10Samples = 10,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_11_SAMPLES"]/*'/>

    X11Samples = 11,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_12_SAMPLES"]/*'/>

    X12Samples = 12,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_13_SAMPLES"]/*'/>

    X13Samples = 13,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_14_SAMPLES"]/*'/>

    X14Samples = 14,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_15_SAMPLES"]/*'/>

    X15Samples = 15,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_16_SAMPLES"]/*'/>

    X16Samples = 16,

    /// <include file='D3DMULTISAMPLE_TYPE.xml' path='doc/member[@name="D3DMULTISAMPLE_TYPE.D3DMULTISAMPLE_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
