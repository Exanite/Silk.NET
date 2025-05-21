// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangParameterCategory")]
    public enum SlangParameterCategory : uint
    {
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_MIXED")]
        Mixed = 0x1,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_CONSTANT_BUFFER")]
        ConstantBuffer = 0x2,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SHADER_RESOURCE")]
        ShaderResource = 0x3,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_UNORDERED_ACCESS")]
        UnorderedAccess = 0x4,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VARYING_INPUT")]
        VaryingInput = 0x5,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT")]
        VaryingOutput = 0x6,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SAMPLER_STATE")]
        SamplerState = 0x7,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_UNIFORM")]
        Uniform = 0x8,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_DESCRIPTOR_TABLE_SLOT")]
        DescriptorTableSlot = 0x9,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SPECIALIZATION_CONSTANT")]
        SpecializationConstant = 0xA,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_PUSH_CONSTANT_BUFFER")]
        PushConstantBuffer = 0xB,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_REGISTER_SPACE")]
        RegisterSpace = 0xC,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_GENERIC")]
        Generic = 0xD,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_RAY_PAYLOAD")]
        RayPayload = 0xE,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_HIT_ATTRIBUTES")]
        HitAttributes = 0xF,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_CALLABLE_PAYLOAD")]
        CallablePayload = 0x10,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SHADER_RECORD")]
        ShaderRecord = 0x11,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_EXISTENTIAL_TYPE_PARAM")]
        ExistentialTypeParam = 0x12,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_EXISTENTIAL_OBJECT_PARAM")]
        ExistentialObjectParam = 0x13,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SUB_ELEMENT_REGISTER_SPACE")]
        SubElementRegisterSpace = 0x14,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SUBPASS")]
        Subpass = 0x15,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_ARGUMENT_BUFFER_ELEMENT")]
        MetalArgumentBufferElement = 0x16,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_ATTRIBUTE")]
        MetalAttribute = 0x17,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_PAYLOAD")]
        MetalPayload = 0x18,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_COUNT")]
        Count = 0x19,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_BUFFER")]
        MetalBuffer = 0x2,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_TEXTURE")]
        MetalTexture = 0x3,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_SAMPLER")]
        MetalSampler = 0x7,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VERTEX_INPUT")]
        VertexInput = 0x5,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_FRAGMENT_OUTPUT")]
        FragmentOutput = 0x6,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_COUNT_V1")]
        CountV1 = 0x15,
    }
}
