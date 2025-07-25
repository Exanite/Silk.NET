// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreEngineQueryInput.xml' path='doc/member[@name="DXCoreEngineQueryInput"]/*'/>
public partial struct DXCoreEngineQueryInput
{
    /// <include file='DXCoreEngineQueryInput.xml' path='doc/member[@name="DXCoreEngineQueryInput.adapterEngineIndex"]/*'/>

    public DXCoreAdapterEngineIndex AdapterEngineIndex;

    /// <include file='DXCoreEngineQueryInput.xml' path='doc/member[@name="DXCoreEngineQueryInput.processId"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint ProcessId;
}
