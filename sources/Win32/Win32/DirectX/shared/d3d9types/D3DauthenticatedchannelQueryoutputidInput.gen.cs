// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT"]/*'/>
public partial struct D3DauthenticatedchannelQueryoutputidInput
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.Input"]/*'/>

    public D3DauthenticatedchannelQueryInput Input;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.DeviceHandle"]/*'/>

    public Handle DeviceHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.CryptoSessionHandle"]/*'/>

    public Handle CryptoSessionHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_INPUT.OutputIDIndex"]/*'/>

    public uint OutputIDIndex;
}
