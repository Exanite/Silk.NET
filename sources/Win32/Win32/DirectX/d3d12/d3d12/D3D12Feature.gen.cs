// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE"]/*'/>
public enum D3D12Feature
{
    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS"]/*'/>

    D3D12Options = 0,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ARCHITECTURE"]/*'/>

    Architecture = 1,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FEATURE_LEVELS"]/*'/>

    FeatureLevels = 2,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FORMAT_SUPPORT"]/*'/>

    FormatSupport = 3,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_MULTISAMPLE_QUALITY_LEVELS"]/*'/>

    MultisampleQualityLevels = 4,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_FORMAT_INFO"]/*'/>

    FormatInfo = 5,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_GPU_VIRTUAL_ADDRESS_SUPPORT"]/*'/>

    GpuVirtualAddressSupport = 6,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SHADER_MODEL"]/*'/>

    ShaderModel = 7,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS1"]/*'/>

    D3D12Options1 = 8,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_SUPPORT"]/*'/>

    ProtectedResourceSessionSupport = 10,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ROOT_SIGNATURE"]/*'/>

    RootSignature = 12,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_ARCHITECTURE1"]/*'/>

    Architecture1 = 16,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS2"]/*'/>

    D3D12Options2 = 18,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SHADER_CACHE"]/*'/>

    ShaderCache = 19,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_COMMAND_QUEUE_PRIORITY"]/*'/>

    CommandQueuePriority = 20,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS3"]/*'/>

    D3D12Options3 = 21,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_EXISTING_HEAPS"]/*'/>

    ExistingHeaps = 22,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS4"]/*'/>

    D3D12Options4 = 23,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_SERIALIZATION"]/*'/>

    Serialization = 24,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_CROSS_NODE"]/*'/>

    CrossNode = 25,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS5"]/*'/>

    D3D12Options5 = 27,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_DISPLAYABLE"]/*'/>

    Displayable = 28,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS6"]/*'/>

    D3D12Options6 = 30,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_QUERY_META_COMMAND"]/*'/>

    QueryMetaCommand = 31,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS7"]/*'/>

    D3D12Options7 = 32,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPE_COUNT"]/*'/>

    ProtectedResourceSessionTypeCount = 33,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PROTECTED_RESOURCE_SESSION_TYPES"]/*'/>

    ProtectedResourceSessionTypes = 34,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS8"]/*'/>

    D3D12Options8 = 36,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS9"]/*'/>

    D3D12Options9 = 37,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS10"]/*'/>

    D3D12Options10 = 39,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS11"]/*'/>

    D3D12Options11 = 40,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS12"]/*'/>

    D3D12Options12 = 41,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS13"]/*'/>

    D3D12Options13 = 42,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS14"]/*'/>

    D3D12Options14 = 43,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS15"]/*'/>

    D3D12Options15 = 44,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS16"]/*'/>

    D3D12Options16 = 45,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS17"]/*'/>

    D3D12Options17 = 46,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS18"]/*'/>

    D3D12Options18 = 47,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS19"]/*'/>

    D3D12Options19 = 48,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS20"]/*'/>

    D3D12Options20 = 49,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PREDICATION"]/*'/>

    Predication = 50,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_PLACED_RESOURCE_SUPPORT_INFO"]/*'/>

    PlacedResourceSupportInfo = 51,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_HARDWARE_COPY"]/*'/>

    HardwareCopy = 52,

    /// <include file='D3D12_FEATURE.xml' path='doc/member[@name="D3D12_FEATURE.D3D12_FEATURE_D3D12_OPTIONS21"]/*'/>

    D3D12Options21 = 53,
}
