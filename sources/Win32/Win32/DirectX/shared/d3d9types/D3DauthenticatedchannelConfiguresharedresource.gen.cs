// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE"]/*'/>
public partial struct D3DauthenticatedchannelConfiguresharedresource
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.Parameters"]/*'/>

    public D3DauthenticatedchannelConfigureInput Parameters;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.ProcessIdentiferType"]/*'/>

    public D3DauthenticatedchannelProcessidentifiertype ProcessIdentiferType;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.ProcessHandle"]/*'/>

    public Handle ProcessHandle;

    /// <include file='D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE.AllowAccess"]/*'/>

    [NativeTypeName("BOOL")]
    public MaybeBool<int> AllowAccess;
}
