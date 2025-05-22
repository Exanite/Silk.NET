// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangResourceShape")]
    public enum ResourceShape : uint
    {
        [NativeName("Name", "SLANG_RESOURCE_BASE_SHAPE_MASK")]
        ResourceBaseShapeMask = 0xF,
        [NativeName("Name", "SLANG_RESOURCE_NONE")]
        ResourceNone = 0x0,
        [NativeName("Name", "SLANG_TEXTURE_1D")]
        Texture1D = 0x1,
        [NativeName("Name", "SLANG_TEXTURE_2D")]
        Texture2D = 0x2,
        [NativeName("Name", "SLANG_TEXTURE_3D")]
        Texture3D = 0x3,
        [NativeName("Name", "SLANG_TEXTURE_CUBE")]
        TextureCube = 0x4,
        [NativeName("Name", "SLANG_TEXTURE_BUFFER")]
        TextureBuffer = 0x5,
        [NativeName("Name", "SLANG_STRUCTURED_BUFFER")]
        StructuredBuffer = 0x6,
        [NativeName("Name", "SLANG_BYTE_ADDRESS_BUFFER")]
        ByteAddressBuffer = 0x7,
        [NativeName("Name", "SLANG_RESOURCE_UNKNOWN")]
        ResourceUnknown = 0x8,
        [NativeName("Name", "SLANG_ACCELERATION_STRUCTURE")]
        AccelerationStructure = 0x9,
        [NativeName("Name", "SLANG_TEXTURE_SUBPASS")]
        TextureSubpass = 0xA,
        [NativeName("Name", "SLANG_RESOURCE_EXT_SHAPE_MASK")]
        ResourceExtShapeMask = 0xF0,
        [NativeName("Name", "SLANG_TEXTURE_FEEDBACK_FLAG")]
        TextureFeedbackFlag = 0x10,
        [NativeName("Name", "SLANG_TEXTURE_SHADOW_FLAG")]
        TextureShadowFlag = 0x20,
        [NativeName("Name", "SLANG_TEXTURE_ARRAY_FLAG")]
        TextureArrayFlag = 0x40,
        [NativeName("Name", "SLANG_TEXTURE_MULTISAMPLE_FLAG")]
        TextureMultisampleFlag = 0x80,
        [NativeName("Name", "SLANG_TEXTURE_1D_ARRAY")]
        Texture1DArray = 0x41,
        [NativeName("Name", "SLANG_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x42,
        [NativeName("Name", "SLANG_TEXTURE_CUBE_ARRAY")]
        TextureCubeArray = 0x44,
        [NativeName("Name", "SLANG_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x82,
        [NativeName("Name", "SLANG_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0xC2,
        [NativeName("Name", "SLANG_TEXTURE_SUBPASS_MULTISAMPLE")]
        TextureSubpassMultisample = 0x8A,
    }
}
