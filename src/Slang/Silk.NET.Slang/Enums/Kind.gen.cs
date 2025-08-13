// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "Kind")]
    public enum Kind : int
    {
        [NativeName("Name", "None")]
        None = 0x0,
        [NativeName("Name", "Struct")]
        Struct = 0x1,
        [NativeName("Name", "Array")]
        Array = 0x2,
        [NativeName("Name", "Matrix")]
        Matrix = 0x3,
        [NativeName("Name", "Vector")]
        Vector = 0x4,
        [NativeName("Name", "Scalar")]
        Scalar = 0x5,
        [NativeName("Name", "ConstantBuffer")]
        ConstantBuffer = 0x6,
        [NativeName("Name", "Resource")]
        Resource = 0x7,
        [NativeName("Name", "SamplerState")]
        SamplerState = 0x8,
        [NativeName("Name", "TextureBuffer")]
        TextureBuffer = 0x9,
        [NativeName("Name", "ShaderStorageBuffer")]
        ShaderStorageBuffer = 0xA,
        [NativeName("Name", "ParameterBlock")]
        ParameterBlock = 0xB,
        [NativeName("Name", "GenericTypeParameter")]
        GenericTypeParameter = 0xC,
        [NativeName("Name", "Interface")]
        Interface = 0xD,
        [NativeName("Name", "OutputStream")]
        OutputStream = 0xE,
        [NativeName("Name", "Specialized")]
        Specialized = 0x10,
        [NativeName("Name", "Feedback")]
        Feedback = 0x11,
        [NativeName("Name", "Pointer")]
        Pointer = 0x12,
        [NativeName("Name", "DynamicResource")]
        DynamicResource = 0x13,
        [NativeName("Name", "MeshOutput")]
        MeshOutput = 0xF,
    }
}
