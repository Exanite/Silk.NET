// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    public static ref readonly Guid D3D12ComputeOnlyDevices
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x08,
                0xAB,
                0xF7,
                0x50,
                0x6D,
                0x4B,
                0x14,
                0x4E,
                0x89,
                0xA5,
                0x5D,
                0x16,
                0xCD,
                0x27,
                0x25,
                0x94,
            ];
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static D3D12FilterReductionType D3D12DecodeFilterReduction(D3D12Filter D3D12Filter) =>
        (D3D12FilterReductionType)(
            ((uint)D3D12Filter >> unchecked((int)D3D12.FilterReductionTypeShift))
            & D3D12.FilterReductionTypeMask
        );

    public static bool D3D12DecodeIsAnisotropicFilter(D3D12Filter D3D12Filter)
    {
        return (((uint)D3D12Filter & D3D12.AnisotropicFilteringBit) != 0)
            && (D3D12FilterType.Linear == D3D12DecodeMinFilter(D3D12Filter))
            && (D3D12FilterType.Linear == D3D12DecodeMagFilter(D3D12Filter))
            && (D3D12FilterType.Linear == D3D12DecodeMipFilter(D3D12Filter));
    }

    public static bool D3D12DecodeIsComparisonFilter(D3D12Filter D3D12Filter) =>
        D3D12DecodeFilterReduction(D3D12Filter) == D3D12FilterReductionType.Comparison;

    public static D3D12FilterType D3D12DecodeMagFilter(D3D12Filter D3D12Filter) =>
        (D3D12FilterType)(
            ((uint)D3D12Filter >> unchecked((int)D3D12.MagFilterShift)) & D3D12.FilterTypeMask
        );

    public static D3D12FilterType D3D12DecodeMinFilter(D3D12Filter D3D12Filter) =>
        (D3D12FilterType)(
            ((uint)D3D12Filter >> unchecked((int)D3D12.MinFilterShift)) & D3D12.FilterTypeMask
        );

    public static D3D12FilterType D3D12DecodeMipFilter(D3D12Filter D3D12Filter) =>
        (D3D12FilterType)(
            ((uint)D3D12Filter >> unchecked((int)D3D12.MipFilterShift)) & D3D12.FilterTypeMask
        );

    public static D3D12ShaderComponentMapping D3D12DecodeShader4ComponentMapping(
        int ComponentToExtract,
        uint Mapping
    ) =>
        (D3D12ShaderComponentMapping)(
            (Mapping >> (unchecked((int)D3D12.ShaderComponentMappingShift) * ComponentToExtract))
            & D3D12.ShaderComponentMappingMask
        );

    public static D3D12Filter D3D12EncodeAnisotropicFilter(D3D12FilterReductionType reduction) =>
        (D3D12Filter)(
            D3D12.AnisotropicFilteringBit
            | (uint)D3D12EncodeBasicFilter(
                D3D12FilterType.Linear,
                D3D12FilterType.Linear,
                D3D12FilterType.Linear,
                reduction
            )
        );

    public static D3D12Filter D3D12EncodeBasicFilter(
        D3D12FilterType min,
        D3D12FilterType mag,
        D3D12FilterType mip,
        D3D12FilterReductionType reduction
    )
    {
        return (D3D12Filter)(
            (((uint)min & D3D12.FilterTypeMask) << unchecked((int)D3D12.MinFilterShift))
            | (((uint)mag & D3D12.FilterTypeMask) << unchecked((int)D3D12.MagFilterShift))
            | (((uint)mip & D3D12.FilterTypeMask) << unchecked((int)D3D12.MipFilterShift))
            | (
                ((uint)reduction & D3D12.FilterReductionTypeMask)
                << unchecked((int)D3D12.FilterReductionTypeShift)
            )
        );
    }

    public static D3D12Filter D3D12EncodeMinMagAnisotropicMipPointFilter(
        D3D12FilterReductionType reduction
    ) =>
        (D3D12Filter)(D3D12.AnisotropicFilteringBit)
        | D3D12EncodeBasicFilter(
            D3D12FilterType.Linear,
            D3D12FilterType.Linear,
            D3D12FilterType.Point,
            reduction
        );

    public static uint D3D12EncodeShader4ComponentMapping(
        D3D12ShaderComponentMapping Src0,
        D3D12ShaderComponentMapping Src1,
        D3D12ShaderComponentMapping Src2,
        D3D12ShaderComponentMapping Src3
    )
    {
        return ((uint)Src0 & D3D12.ShaderComponentMappingMask)
            | (
                ((uint)Src1 & D3D12.ShaderComponentMappingMask)
                << unchecked((int)D3D12.ShaderComponentMappingShift)
            )
            | (
                ((uint)Src2 & D3D12.ShaderComponentMappingMask)
                << (unchecked((int)D3D12.ShaderComponentMappingShift) * 2)
            )
            | (
                ((uint)Src3 & D3D12.ShaderComponentMappingMask)
                << (unchecked((int)D3D12.ShaderComponentMappingShift) * 3)
            )
            | D3D12.ShaderComponentMappingAlwaysSetBitAvoidingZeromemMistakes;
    }

    public static uint D3D12GetCoarseShadingRateXAxis(uint x) =>
        (x >> unchecked((int)D3D12.ShadingRateXAxisShift)) & D3D12.ShadingRateValidMask;

    public static uint D3D12GetCoarseShadingRateYAxis(uint y) => y & D3D12.ShadingRateValidMask;

    public static uint D3D12MakeCoarseShadingRate(uint x, uint y) =>
        (x << unchecked((int)D3D12.ShadingRateXAxisShift)) | y;

    public static HResult D3D12SetObjectNameA<TD3D12Object>(TD3D12Object* pObject, sbyte* pName)
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        return D3D12SetObjectNameNA(pObject, (uint)lstrlenA(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SetObjectNameA<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        Ref<sbyte> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HResult)D3D12SetObjectNameA(__dsl_pObject, __dsl_pName);
        }
    }

    public static HResult D3D12SetObjectNameNA<TD3D12Object>(
        TD3D12Object* pObject,
        uint Chars,
        sbyte* pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        var guid = WkpdidD3DDebugObjectName;
        return pObject->SetPrivateData(&guid, Chars, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SetObjectNameNA<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        uint Chars,
        Ref<sbyte> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (sbyte* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HResult)D3D12SetObjectNameNA(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HResult D3D12SetObjectNameNW<TD3D12Object>(
        TD3D12Object* pObject,
        uint Chars,
        char* pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        var guid = WkpdidD3DDebugObjectNameW;
        return pObject->SetPrivateData(&guid, Chars * 2, pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SetObjectNameNW<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        uint Chars,
        Ref<char> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HResult)D3D12SetObjectNameNW(__dsl_pObject, Chars, __dsl_pName);
        }
    }

    public static HResult D3D12SetObjectNameW<TD3D12Object>(TD3D12Object* pObject, char* pName)
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        return D3D12SetObjectNameNW(pObject, (uint)lstrlenW(pName), pName);
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12SetObjectNameW<TD3D12Object>(
        Ref<TD3D12Object> pObject,
        Ref<char> pName
    )
        where TD3D12Object : unmanaged, ID3D12Object.Interface
    {
        fixed (char* __dsl_pName = pName)
        fixed (TD3D12Object* __dsl_pObject = pObject)
        {
            return (HResult)D3D12SetObjectNameW(__dsl_pObject, __dsl_pName);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12Reflect"]/*'/>

    public static HResult D3D12Reflect(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3D11ShaderReflection** ppReflector
    )
    {
        return D3DReflect(
            pSrcData,
            SrcDataSize,
            __uuidof<ID3D12ShaderReflection.Native>(),
            unchecked((void**)(ppReflector))
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12Reflect(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        Ref2D<ID3D11ShaderReflection> ppReflector
    )
    {
        fixed (ID3D11ShaderReflection** __dsl_ppReflector = ppReflector)
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HResult)D3D12Reflect(__dsl_pSrcData, SrcDataSize, __dsl_ppReflector);
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12ReflectLibrary"]/*'/>

    public static HResult D3D12ReflectLibrary(
        [NativeTypeName("LPCVOID")] void* pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        ID3D12LibraryReflection* ppReflector
    )
    {
        return D3DReflectLibrary(
            pSrcData,
            SrcDataSize,
            __uuidof<ID3D12LibraryReflection.Native>(),
            (void**)ppReflector
        );
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult D3D12ReflectLibrary(
        [NativeTypeName("LPCVOID")] Ref pSrcData,
        [NativeTypeName("SIZE_T")] nuint SrcDataSize,
        Ref<ID3D12LibraryReflection> ppReflector
    )
    {
        fixed (ID3D12LibraryReflection* __dsl_ppReflector = ppReflector)
        fixed (void* __dsl_pSrcData = pSrcData)
        {
            return (HResult)D3D12ReflectLibrary(__dsl_pSrcData, SrcDataSize, __dsl_ppReflector);
        }
    }
}
