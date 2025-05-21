// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangTypeKind")]
    public enum SlangTypeKind : uint
    {
        [NativeName("Name", "SLANG_TYPE_KIND_NONE")]
        None = 0x0,
        [NativeName("Name", "SLANG_TYPE_KIND_STRUCT")]
        Struct = 0x1,
        [NativeName("Name", "SLANG_TYPE_KIND_ARRAY")]
        Array = 0x2,
        [NativeName("Name", "SLANG_TYPE_KIND_MATRIX")]
        Matrix = 0x3,
        [NativeName("Name", "SLANG_TYPE_KIND_VECTOR")]
        Vector = 0x4,
        [NativeName("Name", "SLANG_TYPE_KIND_SCALAR")]
        Scalar = 0x5,
        [NativeName("Name", "SLANG_TYPE_KIND_CONSTANT_BUFFER")]
        ConstantBuffer = 0x6,
        [NativeName("Name", "SLANG_TYPE_KIND_RESOURCE")]
        Resource = 0x7,
        [NativeName("Name", "SLANG_TYPE_KIND_SAMPLER_STATE")]
        SamplerState = 0x8,
        [NativeName("Name", "SLANG_TYPE_KIND_TEXTURE_BUFFER")]
        TextureBuffer = 0x9,
        [NativeName("Name", "SLANG_TYPE_KIND_SHADER_STORAGE_BUFFER")]
        ShaderStorageBuffer = 0xA,
        [NativeName("Name", "SLANG_TYPE_KIND_PARAMETER_BLOCK")]
        ParameterBlock = 0xB,
        [NativeName("Name", "SLANG_TYPE_KIND_GENERIC_TYPE_PARAMETER")]
        GenericTypeParameter = 0xC,
        [NativeName("Name", "SLANG_TYPE_KIND_INTERFACE")]
        Interface = 0xD,
        [NativeName("Name", "SLANG_TYPE_KIND_OUTPUT_STREAM")]
        OutputStream = 0xE,
        [NativeName("Name", "SLANG_TYPE_KIND_MESH_OUTPUT")]
        MeshOutput = 0xF,
        [NativeName("Name", "SLANG_TYPE_KIND_SPECIALIZED")]
        Specialized = 0x10,
        [NativeName("Name", "SLANG_TYPE_KIND_FEEDBACK")]
        Feedback = 0x11,
        [NativeName("Name", "SLANG_TYPE_KIND_POINTER")]
        Pointer = 0x12,
        [NativeName("Name", "SLANG_TYPE_KIND_DYNAMIC_RESOURCE")]
        DynamicResource = 0x13,
        [NativeName("Name", "SLANG_TYPE_KIND_COUNT")]
        Count = 0x14,
    }
}
