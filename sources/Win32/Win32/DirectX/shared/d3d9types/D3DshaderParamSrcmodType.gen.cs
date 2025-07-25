// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE"]/*'/>
public enum D3DshaderParamSrcmodType
{
    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NONE"]/*'/>

    None = 0 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NEG"]/*'/>

    Neg = 1 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIAS"]/*'/>

    Bias = 2 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_BIASNEG"]/*'/>

    Biasneg = 3 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGN"]/*'/>

    Sign = 4 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_SIGNNEG"]/*'/>

    Signneg = 5 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_COMP"]/*'/>

    Comp = 6 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2"]/*'/>

    X2 = 7 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_X2NEG"]/*'/>

    X2Neg = 8 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DZ"]/*'/>

    Dz = 9 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_DW"]/*'/>

    Dw = 10 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABS"]/*'/>

    Abs = 11 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_ABSNEG"]/*'/>

    Absneg = 12 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_NOT"]/*'/>

    Not = 13 << 24,

    /// <include file='D3DSHADER_PARAM_SRCMOD_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_SRCMOD_TYPE.D3DSPSM_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
