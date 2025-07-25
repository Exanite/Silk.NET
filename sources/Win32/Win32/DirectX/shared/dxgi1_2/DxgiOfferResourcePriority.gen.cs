// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY"]/*'/>
public enum DxgiOfferResourcePriority
{
    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_LOW"]/*'/>

    Low = 1,

    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_NORMAL"]/*'/>

    Normal = (Low + 1),

    /// <include file='DXGI_OFFER_RESOURCE_PRIORITY.xml' path='doc/member[@name="DXGI_OFFER_RESOURCE_PRIORITY.DXGI_OFFER_RESOURCE_PRIORITY_HIGH"]/*'/>

    High = (Normal + 1),
}
