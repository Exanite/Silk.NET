// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS"]/*'/>
[Flags]
public enum D3DShaderCbufferFlags
{
    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_USERPACKED"]/*'/>

    DCbfUserpacked = 1,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D10_CBF_USERPACKED"]/*'/>

    D10CbfUserpacked = DCbfUserpacked,

    /// <include file='D3D_SHADER_CBUFFER_FLAGS.xml' path='doc/member[@name="D3D_SHADER_CBUFFER_FLAGS.D3D_CBF_FORCE_DWORD"]/*'/>

    DCbfForceDword = 0x7fffffff,
}
