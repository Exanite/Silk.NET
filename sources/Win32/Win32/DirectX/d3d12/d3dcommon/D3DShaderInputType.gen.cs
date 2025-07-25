// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE"]/*'/>
public enum D3DShaderInputType
{
    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_CBUFFER"]/*'/>

    DSitCbuffer = 0,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TBUFFER"]/*'/>

    DSitTbuffer = (DSitCbuffer + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_TEXTURE"]/*'/>

    DSitTexture = (DSitTbuffer + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_SAMPLER"]/*'/>

    DSitSampler = (DSitTexture + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWTYPED"]/*'/>

    DSitUavRwtyped = (DSitSampler + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_STRUCTURED"]/*'/>

    DSitStructured = (DSitUavRwtyped + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED"]/*'/>

    DSitUavRwstructured = (DSitStructured + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_BYTEADDRESS"]/*'/>

    DSitByteaddress = (DSitUavRwstructured + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWBYTEADDRESS"]/*'/>

    DSitUavRwbyteaddress = (DSitByteaddress + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_APPEND_STRUCTURED"]/*'/>

    DSitUavAppendStructured = (DSitUavRwbyteaddress + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_CONSUME_STRUCTURED"]/*'/>

    DSitUavConsumeStructured = (DSitUavAppendStructured + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*'/>

    DSitUavRwstructuredWithCounter = (DSitUavConsumeStructured + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_RTACCELERATIONSTRUCTURE"]/*'/>

    DSitRtaccelerationstructure = (DSitUavRwstructuredWithCounter + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D_SIT_UAV_FEEDBACKTEXTURE"]/*'/>

    DSitUavFeedbacktexture = (DSitRtaccelerationstructure + 1),

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_CBUFFER"]/*'/>

    D10SitCbuffer = DSitCbuffer,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TBUFFER"]/*'/>

    D10SitTbuffer = DSitTbuffer,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_TEXTURE"]/*'/>

    D10SitTexture = DSitTexture,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D10_SIT_SAMPLER"]/*'/>

    D10SitSampler = DSitSampler,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWTYPED"]/*'/>

    D11SitUavRwtyped = DSitUavRwtyped,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_STRUCTURED"]/*'/>

    D11SitStructured = DSitStructured,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED"]/*'/>

    D11SitUavRwstructured = DSitUavRwstructured,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_BYTEADDRESS"]/*'/>

    D11SitByteaddress = DSitByteaddress,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWBYTEADDRESS"]/*'/>

    D11SitUavRwbyteaddress = DSitUavRwbyteaddress,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_APPEND_STRUCTURED"]/*'/>

    D11SitUavAppendStructured = DSitUavAppendStructured,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_CONSUME_STRUCTURED"]/*'/>

    D11SitUavConsumeStructured = DSitUavConsumeStructured,

    /// <include file='D3D_SHADER_INPUT_TYPE.xml' path='doc/member[@name="D3D_SHADER_INPUT_TYPE.D3D11_SIT_UAV_RWSTRUCTURED_WITH_COUNTER"]/*'/>

    D11SitUavRwstructuredWithCounter = DSitUavRwstructuredWithCounter,
}
