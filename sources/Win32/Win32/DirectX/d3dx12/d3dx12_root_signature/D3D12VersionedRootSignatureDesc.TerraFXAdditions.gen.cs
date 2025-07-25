// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='D3D12_VERSIONED_ROOT_SIGNATURE_DESC.xml' path='doc/member[@name="D3D12_VERSIONED_ROOT_SIGNATURE_DESC"]/*'/>
[NativeTypeName(
    "struct CD3DX12_VERSIONED_ROOT_SIGNATURE_DESC : D3D12_VERSIONED_ROOT_SIGNATURE_DESC"
)]
[NativeInheritance("D3D12_VERSIONED_ROOT_SIGNATURE_DESC")]
public unsafe partial struct D3D12VersionedRootSignatureDesc
{
    public static ref readonly D3D12VersionedRootSignatureDesc DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;
            if (Environment.Is64BitProcess)
            {
                data =
                [
                    0x02,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                ];
            }
            else
            {
                data =
                [
                    0x02,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                ];
            }
            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12VersionedRootSignatureDesc>());
            return ref Unsafe.As<byte, D3D12VersionedRootSignatureDesc>(
                ref MemoryMarshal.GetReference(data)
            );
        }
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC &")] in D3D12RootSignatureDesc o
    )
    {
        Version = D3DRootSignatureVersion.Version1X0;
        Anonymous.Desc_1_0 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC1 &")] in D3D12RootSignatureDesc1 o
    )
    {
        Version = D3DRootSignatureVersion.Version1X1;
        Anonymous.Desc_1_1 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        [NativeTypeName("const D3D12_ROOT_SIGNATURE_DESC2 &")] in D3D12RootSignatureDesc2 o
    )
    {
        Version = D3DRootSignatureVersion.Version1X2;
        Anonymous.Desc_1_2 = o;
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12RootParameter* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        Init_1_0(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public D3D12_VERSIONED_ROOT_SIGNATURE_DESC(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12RootParameter1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        Init_1_1(numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    public void Init_1_0(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12RootParameter* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        Init_1_0(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init_1_0(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] Ref<D3D12RootParameter> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12StaticSamplerDesc> _pStaticSamplers = default,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        fixed (D3D12StaticSamplerDesc* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12RootParameter* __dsl__pParameters = _pParameters)
        {
            Init_1_0(
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_0(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] D3D12RootParameter* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        desc.Version = D3DRootSignatureVersion.Version1X0;
        desc.Anonymous.Desc_1_0.NumParameters = numParameters;
        desc.Anonymous.Desc_1_0.PParameters = _pParameters;
        desc.Anonymous.Desc_1_0.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_0.PStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_0.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_0(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER *")] Ref<D3D12RootParameter> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12StaticSamplerDesc> _pStaticSamplers = default,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        fixed (D3D12StaticSamplerDesc* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12RootParameter* __dsl__pParameters = _pParameters)
        {
            Init_1_0(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public void Init_1_1(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12RootParameter1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        Init_1_1(ref this, numParameters, _pParameters, numStaticSamplers, _pStaticSamplers, flags);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Init_1_1(
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12RootParameter1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12StaticSamplerDesc> _pStaticSamplers = default,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        fixed (D3D12StaticSamplerDesc* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12RootParameter1* __dsl__pParameters = _pParameters)
        {
            Init_1_1(
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_1(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12RootParameter1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            D3D12StaticSamplerDesc* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        desc.Version = D3DRootSignatureVersion.Version1X1;
        desc.Anonymous.Desc_1_1.NumParameters = numParameters;
        desc.Anonymous.Desc_1_1.PParameters = _pParameters;
        desc.Anonymous.Desc_1_1.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_1.PStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_1.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_1(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12RootParameter1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC *")]
            Ref<D3D12StaticSamplerDesc> _pStaticSamplers = default,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        fixed (D3D12StaticSamplerDesc* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12RootParameter1* __dsl__pParameters = _pParameters)
        {
            Init_1_1(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }

    public static void Init_1_2(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] D3D12RootParameter1* _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")]
            D3D12StaticSamplerDesc1* _pStaticSamplers = null,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        desc.Version = D3DRootSignatureVersion.Version1X2;
        desc.Anonymous.Desc_1_2.NumParameters = numParameters;
        desc.Anonymous.Desc_1_2.PParameters = _pParameters;
        desc.Anonymous.Desc_1_2.NumStaticSamplers = numStaticSamplers;
        desc.Anonymous.Desc_1_2.PStaticSamplers = _pStaticSamplers;
        desc.Anonymous.Desc_1_2.Flags = flags;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Init_1_2(
        [NativeTypeName("D3D12_VERSIONED_ROOT_SIGNATURE_DESC &")]
            ref D3D12VersionedRootSignatureDesc desc,
        uint numParameters,
        [NativeTypeName("const D3D12_ROOT_PARAMETER1 *")] Ref<D3D12RootParameter1> _pParameters,
        uint numStaticSamplers = 0,
        [NativeTypeName("const D3D12_STATIC_SAMPLER_DESC1 *")]
            Ref<D3D12StaticSamplerDesc1> _pStaticSamplers = default,
        D3D12RootSignatureFlags flags = D3D12RootSignatureFlags.None
    )
    {
        fixed (D3D12StaticSamplerDesc1* __dsl__pStaticSamplers = _pStaticSamplers)
        fixed (D3D12RootParameter1* __dsl__pParameters = _pParameters)
        {
            Init_1_2(
                ref desc,
                numParameters,
                __dsl__pParameters,
                numStaticSamplers,
                __dsl__pStaticSamplers,
                flags
            );
        }
    }
}
