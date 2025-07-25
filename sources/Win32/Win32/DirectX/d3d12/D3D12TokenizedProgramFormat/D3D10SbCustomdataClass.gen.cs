// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS"]/*'/>
public enum D3D10SbCustomdataClass
{
    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D10_SB_CUSTOMDATA_COMMENT"]/*'/>

    X10SbCustomdataComment = 0,

    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D10_SB_CUSTOMDATA_DEBUGINFO"]/*'/>

    X10SbCustomdataDebuginfo,

    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D10_SB_CUSTOMDATA_OPAQUE"]/*'/>

    X10SbCustomdataOpaque,

    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D10_SB_CUSTOMDATA_DCL_IMMEDIATE_CONSTANT_BUFFER"]/*'/>

    X10SbCustomdataDclImmediateConstantBuffer,

    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D11_SB_CUSTOMDATA_SHADER_MESSAGE"]/*'/>

    X11SbCustomdataShaderMessage,

    /// <include file='D3D10_SB_CUSTOMDATA_CLASS.xml' path='doc/member[@name="D3D10_SB_CUSTOMDATA_CLASS.D3D11_SB_CUSTOMDATA_SHADER_CLIP_PLANE_CONSTANT_MAPPINGS_FOR_DX9"]/*'/>

    X11SbCustomdataShaderClipPlaneConstantMappingsForDx9,
}
