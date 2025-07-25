// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_5.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OFFER_RESOURCE_FLAGS.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_FLAGS"]/*'/>
[Flags]
public enum DxgiOfferResourceFlags
{
    /// <include file='DXGI_OFFER_RESOURCE_FLAGS.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_FLAGS.DXGI_OFFER_RESOURCE_FLAG_ALLOW_DECOMMIT"]/*'/>

    FlagAllowDecommit = 0x1,
}
