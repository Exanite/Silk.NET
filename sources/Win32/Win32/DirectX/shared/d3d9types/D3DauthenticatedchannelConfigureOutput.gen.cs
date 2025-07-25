// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT"]/*'/>
public partial struct D3DauthenticatedchannelConfigureOutput
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.omac"]/*'/>

    public D3DOmac Omac;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.ConfigureType"]/*'/>

    public Guid ConfigureType;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.hChannel"]/*'/>

    public Handle HChannel;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.SequenceNumber"]/*'/>

    public uint SequenceNumber;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT.ReturnCode"]/*'/>

    public HResult ReturnCode;
}
