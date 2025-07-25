// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2"]/*'/>
[Flags]
public enum D3D12FormatSupport2
{
    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_NONE"]/*'/>

    None = 0,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_ADD"]/*'/>

    UavAtomicAdd = 0x1,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS"]/*'/>

    UavAtomicBitwiseOps = 0x2,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE"]/*'/>

    UavAtomicCompareStoreOrCompareExchange = 0x4,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE"]/*'/>

    UavAtomicExchange = 0x8,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX"]/*'/>

    UavAtomicSignedMinOrMax = 0x10,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX"]/*'/>

    UavAtomicUnsignedMinOrMax = 0x20,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD"]/*'/>

    UavTypedLoad = 0x40,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_UAV_TYPED_STORE"]/*'/>

    UavTypedStore = 0x80,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP"]/*'/>

    OutputMergerLogicOp = 0x100,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_TILED"]/*'/>

    Tiled = 0x200,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY"]/*'/>

    MultiplaneOverlay = 0x4000,

    /// <include file='D3D12_FORMAT_SUPPORT2.xml' path='doc/member[@name="D3D12_FORMAT_SUPPORT2.D3D12_FORMAT_SUPPORT2_SAMPLER_FEEDBACK"]/*'/>

    SamplerFeedback = 0x8000,
}
