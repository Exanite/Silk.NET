// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE"]/*'/>
public enum D3DTessellatorOutputPrimitive
{
    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_UNDEFINED"]/*'/>

    DTessellatorOutputUndefined = 0,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_POINT"]/*'/>

    DTessellatorOutputPoint = 1,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_LINE"]/*'/>

    DTessellatorOutputLine = 2,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*'/>

    DTessellatorOutputTriangleCw = 3,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*'/>

    DTessellatorOutputTriangleCcw = 4,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_UNDEFINED"]/*'/>

    D11TessellatorOutputUndefined = DTessellatorOutputUndefined,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_POINT"]/*'/>

    D11TessellatorOutputPoint = DTessellatorOutputPoint,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_LINE"]/*'/>

    D11TessellatorOutputLine = DTessellatorOutputLine,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CW"]/*'/>

    D11TessellatorOutputTriangleCw = DTessellatorOutputTriangleCw,

    /// <include file='D3D_TESSELLATOR_OUTPUT_PRIMITIVE.xml' path='doc/member[@name="D3D_TESSELLATOR_OUTPUT_PRIMITIVE.D3D11_TESSELLATOR_OUTPUT_TRIANGLE_CCW"]/*'/>

    D11TessellatorOutputTriangleCcw = DTessellatorOutputTriangleCcw,
}
