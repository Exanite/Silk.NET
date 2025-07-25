// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL"]/*'/>
public enum D3DShaderModel
{
    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_NONE"]/*'/>

    ShaderModelNone = 0,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_5_1"]/*'/>

    ShaderModel5X1 = 0x51,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_0"]/*'/>

    ShaderModel6X0 = 0x60,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_1"]/*'/>

    ShaderModel6X1 = 0x61,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_2"]/*'/>

    ShaderModel6X2 = 0x62,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_3"]/*'/>

    ShaderModel6X3 = 0x63,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_4"]/*'/>

    ShaderModel6X4 = 0x64,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_5"]/*'/>

    ShaderModel6X5 = 0x65,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_6"]/*'/>

    ShaderModel6X6 = 0x66,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_7"]/*'/>

    ShaderModel6X7 = 0x67,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_8"]/*'/>

    ShaderModel6X8 = 0x68,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_SHADER_MODEL_6_9"]/*'/>

    ShaderModel6X9 = 0x69,

    /// <include file='D3D_SHADER_MODEL.xml' path='doc/member[@name="D3D_SHADER_MODEL.D3D_HIGHEST_SHADER_MODEL"]/*'/>

    HighestShaderModel = ShaderModel6X9,
}
