// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from D3D12TokenizedProgramFormat.hpp in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE"]/*'/>
public enum D3D10SbResourceReturnType
{
    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_UNORM"]/*'/>

    X10SbReturnTypeUnorm = 1,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_SNORM"]/*'/>

    X10SbReturnTypeSnorm = 2,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_SINT"]/*'/>

    X10SbReturnTypeSint = 3,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_UINT"]/*'/>

    X10SbReturnTypeUint = 4,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_FLOAT"]/*'/>

    X10SbReturnTypeFloat = 5,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D10_SB_RETURN_TYPE_MIXED"]/*'/>

    X10SbReturnTypeMixed = 6,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_DOUBLE"]/*'/>

    X11SbReturnTypeDouble = 7,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_CONTINUED"]/*'/>

    X11SbReturnTypeContinued = 8,

    /// <include file='D3D10_SB_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D10_SB_RESOURCE_RETURN_TYPE.D3D11_SB_RETURN_TYPE_UNUSED"]/*'/>

    X11SbReturnTypeUnused = 9,
}
