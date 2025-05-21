// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "ParameterCategory")]
    public enum ParameterCategory : uint
    {
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
