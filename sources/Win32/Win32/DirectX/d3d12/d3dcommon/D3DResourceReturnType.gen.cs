// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE"]/*'/>
public enum D3DResourceReturnType
{
    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UNORM"]/*'/>

    DReturnTypeUnorm = 1,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SNORM"]/*'/>

    DReturnTypeSnorm = 2,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_SINT"]/*'/>

    DReturnTypeSint = 3,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_UINT"]/*'/>

    DReturnTypeUint = 4,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_FLOAT"]/*'/>

    DReturnTypeFloat = 5,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_MIXED"]/*'/>

    DReturnTypeMixed = 6,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_DOUBLE"]/*'/>

    DReturnTypeDouble = 7,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D_RETURN_TYPE_CONTINUED"]/*'/>

    DReturnTypeContinued = 8,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UNORM"]/*'/>

    D10ReturnTypeUnorm = DReturnTypeUnorm,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SNORM"]/*'/>

    D10ReturnTypeSnorm = DReturnTypeSnorm,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_SINT"]/*'/>

    D10ReturnTypeSint = DReturnTypeSint,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_UINT"]/*'/>

    D10ReturnTypeUint = DReturnTypeUint,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_FLOAT"]/*'/>

    D10ReturnTypeFloat = DReturnTypeFloat,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D10_RETURN_TYPE_MIXED"]/*'/>

    D10ReturnTypeMixed = DReturnTypeMixed,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UNORM"]/*'/>

    D11ReturnTypeUnorm = DReturnTypeUnorm,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SNORM"]/*'/>

    D11ReturnTypeSnorm = DReturnTypeSnorm,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_SINT"]/*'/>

    D11ReturnTypeSint = DReturnTypeSint,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_UINT"]/*'/>

    D11ReturnTypeUint = DReturnTypeUint,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_FLOAT"]/*'/>

    D11ReturnTypeFloat = DReturnTypeFloat,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_MIXED"]/*'/>

    D11ReturnTypeMixed = DReturnTypeMixed,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_DOUBLE"]/*'/>

    D11ReturnTypeDouble = DReturnTypeDouble,

    /// <include file='D3D_RESOURCE_RETURN_TYPE.xml' path='doc/member[@name="D3D_RESOURCE_RETURN_TYPE.D3D11_RETURN_TYPE_CONTINUED"]/*'/>

    D11ReturnTypeContinued = DReturnTypeContinued,
}
