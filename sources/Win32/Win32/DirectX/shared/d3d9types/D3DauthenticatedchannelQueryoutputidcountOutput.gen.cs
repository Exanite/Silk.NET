// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT"]/*'/>
public partial struct D3DauthenticatedchannelQueryoutputidcountOutput
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.Output"]/*'/>

    public D3DauthenticatedchannelQueryOutput Output;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.DeviceHandle"]/*'/>

    public Handle DeviceHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.CryptoSessionHandle"]/*'/>

    public Handle CryptoSessionHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTIDCOUNT_OUTPUT.NumOutputIDs"]/*'/>

    public uint NumOutputIDs;
}
