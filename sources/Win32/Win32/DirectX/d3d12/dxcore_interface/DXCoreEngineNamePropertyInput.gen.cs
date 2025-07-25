// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput"]/*'/>
public unsafe partial struct DXCoreEngineNamePropertyInput
{
    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.adapterEngineIndex"]/*'/>

    public DXCoreAdapterEngineIndex AdapterEngineIndex;

    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.engineNameLength"]/*'/>

    [NativeTypeName("uint32_t")]
    public uint EngineNameLength;

    /// <include file='DXCoreEngineNamePropertyInput.xml' path='doc/member[@name="DXCoreEngineNamePropertyInput.engineName"]/*'/>

    [NativeTypeName("wchar_t *")]
    public ushort* EngineName;
}
