// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE"]/*'/>
public enum D3DshaderParamRegisterType
{
    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMP"]/*'/>

    Temp = 0,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_INPUT"]/*'/>

    Input = 1,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST"]/*'/>

    Const = 2,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ADDR"]/*'/>

    Addr = 3,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXTURE"]/*'/>

    Texture = 3,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_RASTOUT"]/*'/>

    Rastout = 4,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_ATTROUT"]/*'/>

    Attrout = 5,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEXCRDOUT"]/*'/>

    Texcrdout = 6,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_OUTPUT"]/*'/>

    Output = 6,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTINT"]/*'/>

    Constint = 7,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_COLOROUT"]/*'/>

    Colorout = 8,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_DEPTHOUT"]/*'/>

    Depthout = 9,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_SAMPLER"]/*'/>

    Sampler = 10,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST2"]/*'/>

    Const2 = 11,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST3"]/*'/>

    Const3 = 12,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONST4"]/*'/>

    Const4 = 13,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_CONSTBOOL"]/*'/>

    Constbool = 14,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LOOP"]/*'/>

    Loop = 15,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_TEMPFLOAT16"]/*'/>

    Tempfloat16 = 16,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_MISCTYPE"]/*'/>

    Misctype = 17,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_LABEL"]/*'/>

    Label = 18,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_PREDICATE"]/*'/>

    Predicate = 19,

    /// <include file='D3DSHADER_PARAM_REGISTER_TYPE.xml' path='doc/member[@name="D3DSHADER_PARAM_REGISTER_TYPE.D3DSPR_FORCE_DWORD"]/*'/>

    ForceDword = 0x7fffffff,
}
