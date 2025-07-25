// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE"]/*'/>
public enum D3D11SbTessellatorOutputPrimitive
{
    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_UNDEFINED"]/*'/>

    Undefined = 0,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_POINT"]/*'/>

    Point = 1,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_LINE"]/*'/>

    Line = 2,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*'/>

    TriangleCw = 3,

    /// <include file='D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D11_SB_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_SB_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*'/>

    TriangleCcw = 4,
}
