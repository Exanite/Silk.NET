// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangBindingType")]
    public enum BindingType : uint
    {
        [NativeName("Name", "SLANG_BINDING_TYPE_UNKNOWN")]
        BindingTypeUnknown = 0x0,
        [NativeName("Name", "SLANG_BINDING_TYPE_SAMPLER")]
        BindingTypeSampler = 0x1,
        [NativeName("Name", "SLANG_BINDING_TYPE_TEXTURE")]
        BindingTypeTexture = 0x2,
        [NativeName("Name", "SLANG_BINDING_TYPE_CONSTANT_BUFFER")]
        BindingTypeConstantBuffer = 0x3,
        [NativeName("Name", "SLANG_BINDING_TYPE_PARAMETER_BLOCK")]
        BindingTypeParameterBlock = 0x4,
        [NativeName("Name", "SLANG_BINDING_TYPE_TYPED_BUFFER")]
        BindingTypeTypedBuffer = 0x5,
        [NativeName("Name", "SLANG_BINDING_TYPE_RAW_BUFFER")]
        BindingTypeRawBuffer = 0x6,
        [NativeName("Name", "SLANG_BINDING_TYPE_COMBINED_TEXTURE_SAMPLER")]
        BindingTypeCombinedTextureSampler = 0x7,
        [NativeName("Name", "SLANG_BINDING_TYPE_INPUT_RENDER_TARGET")]
        BindingTypeInputRenderTarget = 0x8,
        [NativeName("Name", "SLANG_BINDING_TYPE_INLINE_UNIFORM_DATA")]
        BindingTypeInlineUniformData = 0x9,
        [NativeName("Name", "SLANG_BINDING_TYPE_RAY_TRACING_ACCELERATION_STRUCTURE")]
        BindingTypeRayTracingAccelerationStructure = 0xA,
        [NativeName("Name", "SLANG_BINDING_TYPE_VARYING_INPUT")]
        BindingTypeVaryingInput = 0xB,
        [NativeName("Name", "SLANG_BINDING_TYPE_VARYING_OUTPUT")]
        BindingTypeVaryingOutput = 0xC,
        [NativeName("Name", "SLANG_BINDING_TYPE_EXISTENTIAL_VALUE")]
        BindingTypeExistentialValue = 0xD,
        [NativeName("Name", "SLANG_BINDING_TYPE_PUSH_CONSTANT")]
        BindingTypePushConstant = 0xE,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_FLAG")]
        BindingTypeMutableFlag = 0x100,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_TETURE")]
        BindingTypeMutableTeture = 0x102,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_TYPED_BUFFER")]
        BindingTypeMutableTypedBuffer = 0x105,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_RAW_BUFFER")]
        BindingTypeMutableRawBuffer = 0x106,
        [NativeName("Name", "SLANG_BINDING_TYPE_BASE_MASK")]
        BindingTypeBaseMask = 0xFF,
        [NativeName("Name", "SLANG_BINDING_TYPE_EXT_MASK")]
        BindingTypeExtMask = 0xFF00,
        [NativeName("Name", "Unknown")]
        Unknown = 0x0,
        [NativeName("Name", "Sampler")]
        Sampler = 0x1,
        [NativeName("Name", "Texture")]
        Texture = 0x2,
        [NativeName("Name", "ConstantBuffer")]
        ConstantBuffer = 0x3,
        [NativeName("Name", "ParameterBlock")]
        ParameterBlock = 0x4,
        [NativeName("Name", "TypedBuffer")]
        TypedBuffer = 0x5,
        [NativeName("Name", "RawBuffer")]
        RawBuffer = 0x6,
        [NativeName("Name", "CombinedTextureSampler")]
        CombinedTextureSampler = 0x7,
        [NativeName("Name", "InputRenderTarget")]
        InputRenderTarget = 0x8,
        [NativeName("Name", "InlineUniformData")]
        InlineUniformData = 0x9,
        [NativeName("Name", "RayTracingAccelerationStructure")]
        RayTracingAccelerationStructure = 0xA,
        [NativeName("Name", "VaryingInput")]
        VaryingInput = 0xB,
        [NativeName("Name", "VaryingOutput")]
        VaryingOutput = 0xC,
        [NativeName("Name", "ExistentialValue")]
        ExistentialValue = 0xD,
        [NativeName("Name", "PushConstant")]
        PushConstant = 0xE,
        [NativeName("Name", "MutableFlag")]
        MutableFlag = 0x100,
        [NativeName("Name", "MutableTexture")]
        MutableTexture = 0x102,
        [NativeName("Name", "MutableTypedBuffer")]
        MutableTypedBuffer = 0x105,
        [NativeName("Name", "MutableRawBuffer")]
        MutableRawBuffer = 0x106,
        [NativeName("Name", "BaseMask")]
        BaseMask = 0xFF,
        [NativeName("Name", "ExtMask")]
        ExtMask = 0xFF00,
    }
}
