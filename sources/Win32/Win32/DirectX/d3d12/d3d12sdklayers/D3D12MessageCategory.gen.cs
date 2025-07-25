// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY"]/*'/>
public enum D3D12MessageCategory
{
    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_APPLICATION_DEFINED"]/*'/>

    ApplicationDefined = 0,

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_MISCELLANEOUS"]/*'/>

    Miscellaneous = (ApplicationDefined + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_INITIALIZATION"]/*'/>

    Initialization = (Miscellaneous + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_CLEANUP"]/*'/>

    Cleanup = (Initialization + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_COMPILATION"]/*'/>

    Compilation = (Cleanup + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_CREATION"]/*'/>

    StateCreation = (Compilation + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_SETTING"]/*'/>

    StateSetting = (StateCreation + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_STATE_GETTING"]/*'/>

    StateGetting = (StateSetting + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_RESOURCE_MANIPULATION"]/*'/>

    ResourceManipulation = (StateGetting + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_EXECUTION"]/*'/>

    Execution = (ResourceManipulation + 1),

    /// <include file='D3D12_MESSAGE_CATEGORY.xml' path='doc/member[@name="D3D12_MESSAGE_CATEGORY.D3D12_MESSAGE_CATEGORY_SHADER"]/*'/>

    Shader = (Execution + 1),
}
