// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OUTDUPL_POINTER_SHAPE_TYPE.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_TYPE"]/*'/>
public enum DxgiOutduplPointerShapeType
{
    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_TYPE.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_TYPE.DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MONOCHROME"]/*'/>

    Monochrome = 0x1,

    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_TYPE.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_TYPE.DXGI_OUTDUPL_POINTER_SHAPE_TYPE_COLOR"]/*'/>

    Color = 0x2,

    /// <include file='DXGI_OUTDUPL_POINTER_SHAPE_TYPE.xml' path='doc/member[@name="DXGI_OUTDUPL_POINTER_SHAPE_TYPE.DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MASKED_COLOR"]/*'/>

    MaskedColor = 0x4,
}
