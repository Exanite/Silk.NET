// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE"]/*'/>
public enum D3Dquerytype
{
    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VCACHE"]/*'/>

    Vcache = 4,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_RESOURCEMANAGER"]/*'/>

    Resourcemanager = 5,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VERTEXSTATS"]/*'/>

    Vertexstats = 6,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_EVENT"]/*'/>

    Event = 8,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_OCCLUSION"]/*'/>

    Occlusion = 9,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMP"]/*'/>

    Timestamp = 10,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMPDISJOINT"]/*'/>

    Timestampdisjoint = 11,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMPFREQ"]/*'/>

    Timestampfreq = 12,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_PIPELINETIMINGS"]/*'/>

    Pipelinetimings = 13,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_INTERFACETIMINGS"]/*'/>

    Interfacetimings = 14,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VERTEXTIMINGS"]/*'/>

    Vertextimings = 15,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_PIXELTIMINGS"]/*'/>

    Pixeltimings = 16,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_BANDWIDTHTIMINGS"]/*'/>

    Bandwidthtimings = 17,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_CACHEUTILIZATION"]/*'/>

    Cacheutilization = 18,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_MEMORYPRESSURE"]/*'/>

    Memorypressure = 19,
}
