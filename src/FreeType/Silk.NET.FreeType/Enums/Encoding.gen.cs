// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.FreeType
{
    [NativeName("Name", "FT_Encoding_")]
    public enum Encoding : int
    {
        [NativeName("Name", "FT_ENCODING_NONE")]
        None = 0x0,
        [NativeName("Name", "FT_ENCODING_MS_SYMBOL")]
        MSSymbol = 0x73796D62,
        [NativeName("Name", "FT_ENCODING_UNICODE")]
        Unicode = 0x756E6963,
        [NativeName("Name", "FT_ENCODING_SJIS")]
        Sjis = 0x736A6973,
        [NativeName("Name", "FT_ENCODING_PRC")]
        Prc = 0x67622020,
        [NativeName("Name", "FT_ENCODING_BIG5")]
        Big5 = 0x62696735,
        [NativeName("Name", "FT_ENCODING_WANSUNG")]
        Wansung = 0x77616E73,
        [NativeName("Name", "FT_ENCODING_JOHAB")]
        Johab = 0x6A6F6861,
        [NativeName("Name", "FT_ENCODING_GB2312")]
        GB2312 = 0x67622020,
        [NativeName("Name", "FT_ENCODING_MS_SJIS")]
        MSSjis = 0x736A6973,
        [NativeName("Name", "FT_ENCODING_MS_GB2312")]
        MSGB2312 = 0x67622020,
        [NativeName("Name", "FT_ENCODING_MS_BIG5")]
        MSBig5 = 0x62696735,
        [NativeName("Name", "FT_ENCODING_MS_WANSUNG")]
        MSWansung = 0x77616E73,
        [NativeName("Name", "FT_ENCODING_MS_JOHAB")]
        MSJohab = 0x6A6F6861,
        [NativeName("Name", "FT_ENCODING_ADOBE_STANDARD")]
        AdobeStandard = 0x41444F42,
        [NativeName("Name", "FT_ENCODING_ADOBE_EXPERT")]
        AdobeExpert = 0x41444245,
        [NativeName("Name", "FT_ENCODING_ADOBE_CUSTOM")]
        AdobeCustom = 0x41444243,
        [NativeName("Name", "FT_ENCODING_ADOBE_LATIN_1")]
        AdobeLatin1 = 0x6C617431,
        [NativeName("Name", "FT_ENCODING_OLD_LATIN_2")]
        OldLatin2 = 0x6C617432,
        [NativeName("Name", "FT_ENCODING_APPLE_ROMAN")]
        AppleRoman = 0x61726D6E,
    }
}
