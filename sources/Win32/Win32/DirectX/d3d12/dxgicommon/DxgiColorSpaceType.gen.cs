// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgicommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum DxgiColorSpaceType
{
    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709"]/*'/>

    RgbFullG22NoneP709 = 0,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709"]/*'/>

    RgbFullG10NoneP709 = 1,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P709"]/*'/>

    RgbStudioG22NoneP709 = 2,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G22_NONE_P2020"]/*'/>

    RgbStudioG22NoneP2020 = 3,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RESERVED"]/*'/>

    Reserved = 4,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601"]/*'/>

    YcbcrFullG22NoneP709X601 = 5,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601"]/*'/>

    YcbcrStudioG22LeftP601 = 6,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P601"]/*'/>

    YcbcrFullG22LeftP601 = 7,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P709"]/*'/>

    YcbcrStudioG22LeftP709 = 8,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P709"]/*'/>

    YcbcrFullG22LeftP709 = 9,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020"]/*'/>

    YcbcrStudioG22LeftP2020 = 10,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020"]/*'/>

    YcbcrFullG22LeftP2020 = 11,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020"]/*'/>

    RgbFullG2084NoneP2020 = 12,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_LEFT_P2020"]/*'/>

    YcbcrStudioG2084LeftP2020 = 13,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G2084_NONE_P2020"]/*'/>

    RgbStudioG2084NoneP2020 = 14,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_TOPLEFT_P2020"]/*'/>

    YcbcrStudioG22TopleftP2020 = 15,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G2084_TOPLEFT_P2020"]/*'/>

    YcbcrStudioG2084TopleftP2020 = 16,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P2020"]/*'/>

    RgbFullG22NoneP2020 = 17,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_GHLG_TOPLEFT_P2020"]/*'/>

    YcbcrStudioGhlgTopleftP2020 = 18,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_FULL_GHLG_TOPLEFT_P2020"]/*'/>

    YcbcrFullGhlgTopleftP2020 = 19,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P709"]/*'/>

    RgbStudioG24NoneP709 = 20,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_RGB_STUDIO_G24_NONE_P2020"]/*'/>

    RgbStudioG24NoneP2020 = 21,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P709"]/*'/>

    YcbcrStudioG24LeftP709 = 22,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_LEFT_P2020"]/*'/>

    YcbcrStudioG24LeftP2020 = 23,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_YCBCR_STUDIO_G24_TOPLEFT_P2020"]/*'/>

    YcbcrStudioG24TopleftP2020 = 24,

    /// <include file='DXGI_COLOR_SPACE_TYPE.xml' path='doc/member[@name="DXGI_COLOR_SPACE_TYPE.DXGI_COLOR_SPACE_CUSTOM"]/*'/>

    Custom = unchecked((int)(0xFFFFFFFF)),
}
