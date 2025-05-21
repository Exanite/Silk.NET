// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangBindingType")]
    public enum SlangBindingType : uint
    {
        [NativeName("Name", "SLANG_BINDING_TYPE_UNKNOWN")]
        Unknown = 0x0,
        [NativeName("Name", "SLANG_BINDING_TYPE_SAMPLER")]
        Sampler = 0x1,
        [NativeName("Name", "SLANG_BINDING_TYPE_TEXTURE")]
        Texture = 0x2,
        [NativeName("Name", "SLANG_BINDING_TYPE_CONSTANT_BUFFER")]
        ConstantBuffer = 0x3,
        [NativeName("Name", "SLANG_BINDING_TYPE_PARAMETER_BLOCK")]
        ParameterBlock = 0x4,
        [NativeName("Name", "SLANG_BINDING_TYPE_TYPED_BUFFER")]
        TypedBuffer = 0x5,
        [NativeName("Name", "SLANG_BINDING_TYPE_RAW_BUFFER")]
        RawBuffer = 0x6,
        [NativeName("Name", "SLANG_BINDING_TYPE_COMBINED_TEXTURE_SAMPLER")]
        CombinedTextureSampler = 0x7,
        [NativeName("Name", "SLANG_BINDING_TYPE_INPUT_RENDER_TARGET")]
        InputRenderTarget = 0x8,
        [NativeName("Name", "SLANG_BINDING_TYPE_INLINE_UNIFORM_DATA")]
        InlineUniformData = 0x9,
        [NativeName("Name", "SLANG_BINDING_TYPE_RAY_TRACING_ACCELERATION_STRUCTURE")]
        RayTracingAccelerationStructure = 0xA,
        [NativeName("Name", "SLANG_BINDING_TYPE_VARYING_INPUT")]
        VaryingInput = 0xB,
        [NativeName("Name", "SLANG_BINDING_TYPE_VARYING_OUTPUT")]
        VaryingOutput = 0xC,
        [NativeName("Name", "SLANG_BINDING_TYPE_EXISTENTIAL_VALUE")]
        ExistentialValue = 0xD,
        [NativeName("Name", "SLANG_BINDING_TYPE_PUSH_CONSTANT")]
        PushConstant = 0xE,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_FLAG")]
        MutableFlag = 0x100,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_TETURE")]
        MutableTeture = 0x102,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_TYPED_BUFFER")]
        MutableTypedBuffer = 0x105,
        [NativeName("Name", "SLANG_BINDING_TYPE_MUTABLE_RAW_BUFFER")]
        MutableRawBuffer = 0x106,
        [NativeName("Name", "SLANG_BINDING_TYPE_BASE_MASK")]
        BaseMask = 0xFF,
        [NativeName("Name", "SLANG_BINDING_TYPE_EXT_MASK")]
        ExtMask = 0xFF00,
    }
}
