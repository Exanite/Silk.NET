// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE"]/*'/>
public enum D3DDriverType
{
    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_UNKNOWN"]/*'/>

    Unknown = 0,

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE"]/*'/>

    Hardware = (Unknown + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_REFERENCE"]/*'/>

    Reference = (Hardware + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_NULL"]/*'/>

    Null = (Reference + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_SOFTWARE"]/*'/>

    Software = (Null + 1),

    /// <include file='D3D_DRIVER_TYPE.xml' path='doc/member[@name="D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_WARP"]/*'/>

    Warp = (Software + 1),
}
