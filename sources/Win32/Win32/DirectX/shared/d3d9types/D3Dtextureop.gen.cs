// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP"]/*'/>
public enum D3Dtextureop
{
    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_DISABLE"]/*'/>

    Disable = 1,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SELECTARG1"]/*'/>

    Selectarg1 = 2,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SELECTARG2"]/*'/>

    Selectarg2 = 3,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE"]/*'/>

    Modulate = 4,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE2X"]/*'/>

    Modulate2X = 5,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATE4X"]/*'/>

    Modulate4X = 6,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADD"]/*'/>

    Add = 7,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSIGNED"]/*'/>

    Addsigned = 8,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSIGNED2X"]/*'/>

    Addsigned2X = 9,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_SUBTRACT"]/*'/>

    Subtract = 10,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_ADDSMOOTH"]/*'/>

    Addsmooth = 11,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDDIFFUSEALPHA"]/*'/>

    Blenddiffusealpha = 12,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDTEXTUREALPHA"]/*'/>

    Blendtexturealpha = 13,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDFACTORALPHA"]/*'/>

    Blendfactoralpha = 14,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDTEXTUREALPHAPM"]/*'/>

    Blendtexturealphapm = 15,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BLENDCURRENTALPHA"]/*'/>

    Blendcurrentalpha = 16,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_PREMODULATE"]/*'/>

    Premodulate = 17,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEALPHA_ADDCOLOR"]/*'/>

    ModulatealphaAddcolor = 18,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATECOLOR_ADDALPHA"]/*'/>

    ModulatecolorAddalpha = 19,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEINVALPHA_ADDCOLOR"]/*'/>

    ModulateinvalphaAddcolor = 20,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MODULATEINVCOLOR_ADDALPHA"]/*'/>

    ModulateinvcolorAddalpha = 21,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BUMPENVMAP"]/*'/>

    Bumpenvmap = 22,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_BUMPENVMAPLUMINANCE"]/*'/>

    Bumpenvmapluminance = 23,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_DOTPRODUCT3"]/*'/>

    Dotproduct3 = 24,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_MULTIPLYADD"]/*'/>

    Multiplyadd = 25,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_LERP"]/*'/>

    Lerp = 26,

    /// <include file='D3DTEXTUREOP.xml' path='doc/member[@name="D3DTEXTUREOP.D3DTOP_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
