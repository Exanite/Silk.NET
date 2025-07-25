// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON"]/*'/>
public enum D3DshaderComparison
{
    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_RESERVED0"]/*'/>

    Reserved0 = 0,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_GT"]/*'/>

    Gt = 1,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_EQ"]/*'/>

    Eq = 2,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_GE"]/*'/>

    Ge = 3,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_LT"]/*'/>

    Lt = 4,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_NE"]/*'/>

    Ne = 5,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_LE"]/*'/>

    Le = 6,

    /// <include file='D3DSHADER_COMPARISON.xml' path='doc/member[@name="D3DSHADER_COMPARISON.D3DSPC_RESERVED1"]/*'/>

    Reserved1 = 7,
}
