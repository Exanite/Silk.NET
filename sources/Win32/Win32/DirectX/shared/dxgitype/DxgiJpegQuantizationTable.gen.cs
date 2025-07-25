// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE"]/*'/>
public partial struct DxgiJpegQuantizationTable
{
    /// <include file='DXGI_JPEG_QUANTIZATION_TABLE.xml' path='doc/member[@name="DXGI_JPEG_QUANTIZATION_TABLE.Elements"]/*'/>

    [NativeTypeName("BYTE[64]")]
    public _Elements_e__FixedBuffer Elements;

    /// <include file='_Elements_e__FixedBuffer.xml' path='doc/member[@name="_Elements_e__FixedBuffer"]/*'/>

    [InlineArray(64)]
    public partial struct _Elements_e__FixedBuffer
    {
        public byte e0;
    }
}
