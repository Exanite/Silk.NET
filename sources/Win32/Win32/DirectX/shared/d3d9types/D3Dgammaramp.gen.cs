// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DGAMMARAMP.xml' path='doc/member[@name="D3DGAMMARAMP"]/*'/>
public partial struct D3Dgammaramp
{
    /// <include file='D3DGAMMARAMP.xml' path='doc/member[@name="D3DGAMMARAMP.red"]/*'/>

    [NativeTypeName("WORD[256]")]
    public _red_e__FixedBuffer Red;

    /// <include file='D3DGAMMARAMP.xml' path='doc/member[@name="D3DGAMMARAMP.green"]/*'/>

    [NativeTypeName("WORD[256]")]
    public _green_e__FixedBuffer Green;

    /// <include file='D3DGAMMARAMP.xml' path='doc/member[@name="D3DGAMMARAMP.blue"]/*'/>

    [NativeTypeName("WORD[256]")]
    public _blue_e__FixedBuffer Blue;

    /// <include file='_red_e__FixedBuffer.xml' path='doc/member[@name="_red_e__FixedBuffer"]/*'/>

    [InlineArray(256)]
    public partial struct _red_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_green_e__FixedBuffer.xml' path='doc/member[@name="_green_e__FixedBuffer"]/*'/>

    [InlineArray(256)]
    public partial struct _green_e__FixedBuffer
    {
        public ushort e0;
    }

    /// <include file='_blue_e__FixedBuffer.xml' path='doc/member[@name="_blue_e__FixedBuffer"]/*'/>

    [InlineArray(256)]
    public partial struct _blue_e__FixedBuffer
    {
        public ushort e0;
    }
}
