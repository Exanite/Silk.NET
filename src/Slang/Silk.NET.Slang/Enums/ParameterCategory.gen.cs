// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangParameterCategory")]
    public enum ParameterCategory : uint
    {
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_NONE")]
        ParameterCategoryNone = 0x0,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_MIXED")]
        ParameterCategoryMixed = 0x1,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_CONSTANT_BUFFER")]
        ParameterCategoryConstantBuffer = 0x2,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SHADER_RESOURCE")]
        ParameterCategoryShaderResource = 0x3,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_UNORDERED_ACCESS")]
        ParameterCategoryUnorderedAccess = 0x4,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VARYING_INPUT")]
        ParameterCategoryVaryingInput = 0x5,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VARYING_OUTPUT")]
        ParameterCategoryVaryingOutput = 0x6,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SAMPLER_STATE")]
        ParameterCategorySamplerState = 0x7,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_UNIFORM")]
        ParameterCategoryUniform = 0x8,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_DESCRIPTOR_TABLE_SLOT")]
        ParameterCategoryDescriptorTableSlot = 0x9,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SPECIALIZATION_CONSTANT")]
        ParameterCategorySpecializationConstant = 0xA,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_PUSH_CONSTANT_BUFFER")]
        ParameterCategoryPushConstantBuffer = 0xB,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_REGISTER_SPACE")]
        ParameterCategoryRegisterSpace = 0xC,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_GENERIC")]
        ParameterCategoryGeneric = 0xD,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_RAY_PAYLOAD")]
        ParameterCategoryRayPayload = 0xE,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_HIT_ATTRIBUTES")]
        ParameterCategoryHitAttributes = 0xF,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_CALLABLE_PAYLOAD")]
        ParameterCategoryCallablePayload = 0x10,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SHADER_RECORD")]
        ParameterCategoryShaderRecord = 0x11,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_EXISTENTIAL_TYPE_PARAM")]
        ParameterCategoryExistentialTypeParam = 0x12,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_EXISTENTIAL_OBJECT_PARAM")]
        ParameterCategoryExistentialObjectParam = 0x13,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SUB_ELEMENT_REGISTER_SPACE")]
        ParameterCategorySubElementRegisterSpace = 0x14,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_SUBPASS")]
        ParameterCategorySubpass = 0x15,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_ARGUMENT_BUFFER_ELEMENT")]
        ParameterCategoryMetalArgumentBufferElement = 0x16,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_ATTRIBUTE")]
        ParameterCategoryMetalAttribute = 0x17,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_PAYLOAD")]
        ParameterCategoryMetalPayload = 0x18,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_COUNT")]
        ParameterCategoryCount = 0x19,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_BUFFER")]
        ParameterCategoryMetalBuffer = 0x2,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_TEXTURE")]
        ParameterCategoryMetalTexture = 0x3,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_METAL_SAMPLER")]
        ParameterCategoryMetalSampler = 0x7,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_VERTEX_INPUT")]
        ParameterCategoryVertexInput = 0x5,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_FRAGMENT_OUTPUT")]
        ParameterCategoryFragmentOutput = 0x6,
        [NativeName("Name", "SLANG_PARAMETER_CATEGORY_COUNT_V1")]
        ParameterCategoryCountV1 = 0x15,
        [NativeName("Name", "None")]
        None = 0x0,
        [NativeName("Name", "Mixed")]
        Mixed = 0x1,
        [NativeName("Name", "ConstantBuffer")]
        ConstantBuffer = 0x2,
        [NativeName("Name", "ShaderResource")]
        ShaderResource = 0x3,
        [NativeName("Name", "UnorderedAccess")]
        UnorderedAccess = 0x4,
        [NativeName("Name", "VaryingInput")]
        VaryingInput = 0x5,
        [NativeName("Name", "VaryingOutput")]
        VaryingOutput = 0x6,
        [NativeName("Name", "SamplerState")]
        SamplerState = 0x7,
        [NativeName("Name", "Uniform")]
        Uniform = 0x8,
        [NativeName("Name", "DescriptorTableSlot")]
        DescriptorTableSlot = 0x9,
        [NativeName("Name", "SpecializationConstant")]
        SpecializationConstant = 0xA,
        [NativeName("Name", "PushConstantBuffer")]
        PushConstantBuffer = 0xB,
        [NativeName("Name", "RegisterSpace")]
        RegisterSpace = 0xC,
        [NativeName("Name", "GenericResource")]
        GenericResource = 0xD,
        [NativeName("Name", "RayPayload")]
        RayPayload = 0xE,
        [NativeName("Name", "HitAttributes")]
        HitAttributes = 0xF,
        [NativeName("Name", "CallablePayload")]
        CallablePayload = 0x10,
        [NativeName("Name", "ShaderRecord")]
        ShaderRecord = 0x11,
        [NativeName("Name", "ExistentialTypeParam")]
        ExistentialTypeParam = 0x12,
        [NativeName("Name", "ExistentialObjectParam")]
        ExistentialObjectParam = 0x13,
        [NativeName("Name", "SubElementRegisterSpace")]
        SubElementRegisterSpace = 0x14,
        [NativeName("Name", "InputAttachmentIndex")]
        InputAttachmentIndex = 0x15,
        [NativeName("Name", "MetalBuffer")]
        MetalBuffer = 0x2,
        [NativeName("Name", "MetalTexture")]
        MetalTexture = 0x3,
        [NativeName("Name", "MetalArgumentBufferElement")]
        MetalArgumentBufferElement = 0x16,
        [NativeName("Name", "MetalAttribute")]
        MetalAttribute = 0x17,
        [NativeName("Name", "MetalPayload")]
        MetalPayload = 0x18,
        [NativeName("Name", "VertexInput")]
        VertexInput = 0x5,
        [NativeName("Name", "FragmentOutput")]
        FragmentOutput = 0x6,
    }
}
