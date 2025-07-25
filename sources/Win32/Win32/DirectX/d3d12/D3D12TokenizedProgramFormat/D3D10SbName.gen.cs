// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME"]/*'/>
public enum D3D10SbName
{
    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_UNDEFINED"]/*'/>

    X10SbNameUndefined = 0,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_POSITION"]/*'/>

    X10SbNamePosition = 1,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_CLIP_DISTANCE"]/*'/>

    X10SbNameClipDistance = 2,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_CULL_DISTANCE"]/*'/>

    X10SbNameCullDistance = 3,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_RENDER_TARGET_ARRAY_INDEX"]/*'/>

    X10SbNameRenderTargetArrayIndex = 4,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_VIEWPORT_ARRAY_INDEX"]/*'/>

    X10SbNameViewportArrayIndex = 5,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_VERTEX_ID"]/*'/>

    X10SbNameVertexId = 6,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_PRIMITIVE_ID"]/*'/>

    X10SbNamePrimitiveId = 7,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_INSTANCE_ID"]/*'/>

    X10SbNameInstanceId = 8,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_IS_FRONT_FACE"]/*'/>

    X10SbNameIsFrontFace = 9,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D10_SB_NAME_SAMPLE_INDEX"]/*'/>

    X10SbNameSampleIndex = 10,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_EQ_0_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadUEq0EdgeTessfactor = 11,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_EQ_0_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadVEq0EdgeTessfactor = 12,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_EQ_1_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadUEq1EdgeTessfactor = 13,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_EQ_1_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadVEq1EdgeTessfactor = 14,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_U_INSIDE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadUInsideTessfactor = 15,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_QUAD_V_INSIDE_TESSFACTOR"]/*'/>

    X11SbNameFinalQuadVInsideTessfactor = 16,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_U_EQ_0_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalTriUEq0EdgeTessfactor = 17,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_V_EQ_0_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalTriVEq0EdgeTessfactor = 18,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_W_EQ_0_EDGE_TESSFACTOR"]/*'/>

    X11SbNameFinalTriWEq0EdgeTessfactor = 19,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_TRI_INSIDE_TESSFACTOR"]/*'/>

    X11SbNameFinalTriInsideTessfactor = 20,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_LINE_DETAIL_TESSFACTOR"]/*'/>

    X11SbNameFinalLineDetailTessfactor = 21,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D11_SB_NAME_FINAL_LINE_DENSITY_TESSFACTOR"]/*'/>

    X11SbNameFinalLineDensityTessfactor = 22,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_BARYCENTRICS"]/*'/>

    X12SbNameBarycentrics = 23,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_SHADINGRATE"]/*'/>

    X12SbNameShadingrate = 24,

    /// <include file='D3D10_SB_NAME.xml' path='doc/member[@name="D3D10_SB_NAME.D3D12_SB_NAME_CULLPRIMITIVE"]/*'/>

    X12SbNameCullprimitive = 25,
}
