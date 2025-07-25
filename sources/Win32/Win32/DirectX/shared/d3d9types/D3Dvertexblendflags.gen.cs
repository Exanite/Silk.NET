// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS"]/*'/>
public enum D3Dvertexblendflags
{
    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_DISABLE"]/*'/>

    Disable = 0,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_1WEIGHTS"]/*'/>

    X1Weights = 1,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_2WEIGHTS"]/*'/>

    X2Weights = 2,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_3WEIGHTS"]/*'/>

    X3Weights = 3,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_TWEENING"]/*'/>

    Tweening = 255,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_0WEIGHTS"]/*'/>

    X0Weights = 256,

    /// <include file='D3DVERTEXBLENDFLAGS.xml' path='doc/member[@name="D3DVERTEXBLENDFLAGS.D3DVBF_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
