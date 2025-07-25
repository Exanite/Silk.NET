// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE"]/*'/>
public enum D3D10SbPrimitive
{
    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_UNDEFINED"]/*'/>

    X10SbPrimitiveUndefined = 0,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_POINT"]/*'/>

    X10SbPrimitivePoint = 1,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_LINE"]/*'/>

    X10SbPrimitiveLine = 2,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_TRIANGLE"]/*'/>

    X10SbPrimitiveTriangle = 3,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_LINE_ADJ"]/*'/>

    X10SbPrimitiveLineAdj = 6,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D10_SB_PRIMITIVE_TRIANGLE_ADJ"]/*'/>

    X10SbPrimitiveTriangleAdj = 7,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_1_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive1ControlPointPatch = 8,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_2_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive2ControlPointPatch = 9,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_3_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive3ControlPointPatch = 10,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_4_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive4ControlPointPatch = 11,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_5_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive5ControlPointPatch = 12,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_6_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive6ControlPointPatch = 13,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_7_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive7ControlPointPatch = 14,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_8_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive8ControlPointPatch = 15,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_9_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive9ControlPointPatch = 16,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_10_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive10ControlPointPatch = 17,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_11_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive11ControlPointPatch = 18,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_12_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive12ControlPointPatch = 19,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_13_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive13ControlPointPatch = 20,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_14_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive14ControlPointPatch = 21,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_15_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive15ControlPointPatch = 22,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_16_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive16ControlPointPatch = 23,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_17_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive17ControlPointPatch = 24,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_18_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive18ControlPointPatch = 25,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_19_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive19ControlPointPatch = 26,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_20_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive20ControlPointPatch = 27,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_21_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive21ControlPointPatch = 28,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_22_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive22ControlPointPatch = 29,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_23_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive23ControlPointPatch = 30,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_24_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive24ControlPointPatch = 31,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_25_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive25ControlPointPatch = 32,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_26_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive26ControlPointPatch = 33,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_27_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive27ControlPointPatch = 34,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_28_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive28ControlPointPatch = 35,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_29_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive29ControlPointPatch = 36,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_30_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive30ControlPointPatch = 37,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_31_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive31ControlPointPatch = 38,

    /// <include file='D3D10_SB_PRIMITIVE.xml' path='doc/member[@name="D3D10_SB_PRIMITIVE.D3D11_SB_PRIMITIVE_32_CONTROL_POINT_PATCH"]/*'/>

    X11SbPrimitive32ControlPointPatch = 39,
}
