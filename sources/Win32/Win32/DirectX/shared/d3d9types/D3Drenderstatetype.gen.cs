// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE"]/*'/>
public enum D3Drenderstatetype
{
    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZENABLE"]/*'/>

    Zenable = 7,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FILLMODE"]/*'/>

    Fillmode = 8,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SHADEMODE"]/*'/>

    Shademode = 9,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZWRITEENABLE"]/*'/>

    Zwriteenable = 14,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHATESTENABLE"]/*'/>

    Alphatestenable = 15,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LASTPIXEL"]/*'/>

    Lastpixel = 16,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRCBLEND"]/*'/>

    Srcblend = 19,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DESTBLEND"]/*'/>

    Destblend = 20,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CULLMODE"]/*'/>

    Cullmode = 22,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ZFUNC"]/*'/>

    Zfunc = 23,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHAREF"]/*'/>

    Alpharef = 24,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHAFUNC"]/*'/>

    Alphafunc = 25,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DITHERENABLE"]/*'/>

    Ditherenable = 26,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ALPHABLENDENABLE"]/*'/>

    Alphablendenable = 27,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGENABLE"]/*'/>

    Fogenable = 28,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SPECULARENABLE"]/*'/>

    Specularenable = 29,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGCOLOR"]/*'/>

    Fogcolor = 34,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGTABLEMODE"]/*'/>

    Fogtablemode = 35,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGSTART"]/*'/>

    Fogstart = 36,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGEND"]/*'/>

    Fogend = 37,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGDENSITY"]/*'/>

    Fogdensity = 38,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_RANGEFOGENABLE"]/*'/>

    Rangefogenable = 48,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILENABLE"]/*'/>

    Stencilenable = 52,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILFAIL"]/*'/>

    Stencilfail = 53,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILZFAIL"]/*'/>

    Stencilzfail = 54,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILPASS"]/*'/>

    Stencilpass = 55,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILFUNC"]/*'/>

    Stencilfunc = 56,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILREF"]/*'/>

    Stencilref = 57,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILMASK"]/*'/>

    Stencilmask = 58,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_STENCILWRITEMASK"]/*'/>

    Stencilwritemask = 59,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TEXTUREFACTOR"]/*'/>

    Texturefactor = 60,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP0"]/*'/>

    Wrap0 = 128,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP1"]/*'/>

    Wrap1 = 129,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP2"]/*'/>

    Wrap2 = 130,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP3"]/*'/>

    Wrap3 = 131,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP4"]/*'/>

    Wrap4 = 132,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP5"]/*'/>

    Wrap5 = 133,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP6"]/*'/>

    Wrap6 = 134,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP7"]/*'/>

    Wrap7 = 135,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CLIPPING"]/*'/>

    Clipping = 136,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LIGHTING"]/*'/>

    Lighting = 137,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_AMBIENT"]/*'/>

    Ambient = 139,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FOGVERTEXMODE"]/*'/>

    Fogvertexmode = 140,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORVERTEX"]/*'/>

    Colorvertex = 141,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_LOCALVIEWER"]/*'/>

    Localviewer = 142,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_NORMALIZENORMALS"]/*'/>

    Normalizenormals = 143,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DIFFUSEMATERIALSOURCE"]/*'/>

    Diffusematerialsource = 145,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SPECULARMATERIALSOURCE"]/*'/>

    Specularmaterialsource = 146,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_AMBIENTMATERIALSOURCE"]/*'/>

    Ambientmaterialsource = 147,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_EMISSIVEMATERIALSOURCE"]/*'/>

    Emissivematerialsource = 148,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_VERTEXBLEND"]/*'/>

    Vertexblend = 151,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CLIPPLANEENABLE"]/*'/>

    Clipplaneenable = 152,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE"]/*'/>

    Pointsize = 154,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE_MIN"]/*'/>

    PointsizeMin = 155,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSPRITEENABLE"]/*'/>

    Pointspriteenable = 156,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALEENABLE"]/*'/>

    Pointscaleenable = 157,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_A"]/*'/>

    PointscaleA = 158,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_B"]/*'/>

    PointscaleB = 159,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSCALE_C"]/*'/>

    PointscaleC = 160,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MULTISAMPLEANTIALIAS"]/*'/>

    Multisampleantialias = 161,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MULTISAMPLEMASK"]/*'/>

    Multisamplemask = 162,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_PATCHEDGESTYLE"]/*'/>

    Patchedgestyle = 163,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DEBUGMONITORTOKEN"]/*'/>

    Debugmonitortoken = 165,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POINTSIZE_MAX"]/*'/>

    PointsizeMax = 166,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_INDEXEDVERTEXBLENDENABLE"]/*'/>

    Indexedvertexblendenable = 167,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE"]/*'/>

    Colorwriteenable = 168,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TWEENFACTOR"]/*'/>

    Tweenfactor = 170,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDOP"]/*'/>

    Blendop = 171,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_POSITIONDEGREE"]/*'/>

    Positiondegree = 172,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_NORMALDEGREE"]/*'/>

    Normaldegree = 173,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SCISSORTESTENABLE"]/*'/>

    Scissortestenable = 174,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SLOPESCALEDEPTHBIAS"]/*'/>

    Slopescaledepthbias = 175,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ANTIALIASEDLINEENABLE"]/*'/>

    Antialiasedlineenable = 176,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MINTESSELLATIONLEVEL"]/*'/>

    Mintessellationlevel = 178,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_MAXTESSELLATIONLEVEL"]/*'/>

    Maxtessellationlevel = 179,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_X"]/*'/>

    AdaptivetessX = 180,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_Y"]/*'/>

    AdaptivetessY = 181,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_Z"]/*'/>

    AdaptivetessZ = 182,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ADAPTIVETESS_W"]/*'/>

    AdaptivetessW = 183,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_ENABLEADAPTIVETESSELLATION"]/*'/>

    Enableadaptivetessellation = 184,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_TWOSIDEDSTENCILMODE"]/*'/>

    Twosidedstencilmode = 185,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILFAIL"]/*'/>

    CcwStencilfail = 186,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILZFAIL"]/*'/>

    CcwStencilzfail = 187,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILPASS"]/*'/>

    CcwStencilpass = 188,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_CCW_STENCILFUNC"]/*'/>

    CcwStencilfunc = 189,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE1"]/*'/>

    Colorwriteenable1 = 190,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE2"]/*'/>

    Colorwriteenable2 = 191,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_COLORWRITEENABLE3"]/*'/>

    Colorwriteenable3 = 192,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDFACTOR"]/*'/>

    Blendfactor = 193,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRGBWRITEENABLE"]/*'/>

    Srgbwriteenable = 194,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DEPTHBIAS"]/*'/>

    Depthbias = 195,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP8"]/*'/>

    Wrap8 = 198,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP9"]/*'/>

    Wrap9 = 199,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP10"]/*'/>

    Wrap10 = 200,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP11"]/*'/>

    Wrap11 = 201,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP12"]/*'/>

    Wrap12 = 202,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP13"]/*'/>

    Wrap13 = 203,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP14"]/*'/>

    Wrap14 = 204,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_WRAP15"]/*'/>

    Wrap15 = 205,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SEPARATEALPHABLENDENABLE"]/*'/>

    Separatealphablendenable = 206,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_SRCBLENDALPHA"]/*'/>

    Srcblendalpha = 207,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_DESTBLENDALPHA"]/*'/>

    Destblendalpha = 208,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_BLENDOPALPHA"]/*'/>

    Blendopalpha = 209,

    /// <include file='D3DRENDERSTATETYPE.xml' path='doc/member[@name="D3DRENDERSTATETYPE.D3DRS_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
