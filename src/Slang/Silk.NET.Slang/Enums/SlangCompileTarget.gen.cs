// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Slang
{
    [NativeName("Name", "SlangCompileTarget")]
    public enum SlangCompileTarget : int
    {
        [NativeName("Name", "SLANG_TARGET_UNKNOWN")]
        TargetUnknown = 0x0,
        [NativeName("Name", "SLANG_TARGET_NONE")]
        TargetNone = 0x1,
        [NativeName("Name", "SLANG_GLSL")]
        Glsl = 0x2,
        [NativeName("Name", "SLANG_GLSL_VULKAN_DEPRECATED")]
        GlslVulkanDeprecated = 0x3,
        [NativeName("Name", "SLANG_GLSL_VULKAN_ONE_DESC_DEPRECATED")]
        GlslVulkanOneDescDeprecated = 0x4,
        [NativeName("Name", "SLANG_HLSL")]
        Hlsl = 0x5,
        [NativeName("Name", "SLANG_SPIRV")]
        Spirv = 0x6,
        [NativeName("Name", "SLANG_SPIRV_ASM")]
        SpirvAsm = 0x7,
        [NativeName("Name", "SLANG_DXBC")]
        Dxbc = 0x8,
        [NativeName("Name", "SLANG_DXBC_ASM")]
        DxbcAsm = 0x9,
        [NativeName("Name", "SLANG_DXIL")]
        Dxil = 0xA,
        [NativeName("Name", "SLANG_DXIL_ASM")]
        DxilAsm = 0xB,
        [NativeName("Name", "SLANG_C_SOURCE")]
        CSource = 0xC,
        [NativeName("Name", "SLANG_CPP_SOURCE")]
        CppSource = 0xD,
        [NativeName("Name", "SLANG_HOST_EXECUTABLE")]
        HostExecutable = 0xE,
        [NativeName("Name", "SLANG_SHADER_SHARED_LIBRARY")]
        ShaderSharedLibrary = 0xF,
        [NativeName("Name", "SLANG_SHADER_HOST_CALLABLE")]
        ShaderHostCallable = 0x10,
        [NativeName("Name", "SLANG_CUDA_SOURCE")]
        CudaSource = 0x11,
        [NativeName("Name", "SLANG_PTX")]
        Ptx = 0x12,
        [NativeName("Name", "SLANG_CUDA_OBJECT_CODE")]
        CudaObjectCode = 0x13,
        [NativeName("Name", "SLANG_OBJECT_CODE")]
        ObjectCode = 0x14,
        [NativeName("Name", "SLANG_HOST_CPP_SOURCE")]
        HostCppSource = 0x15,
        [NativeName("Name", "SLANG_HOST_HOST_CALLABLE")]
        HostHostCallable = 0x16,
        [NativeName("Name", "SLANG_CPP_PYTORCH_BINDING")]
        CppPytorchBinding = 0x17,
        [NativeName("Name", "SLANG_METAL")]
        Metal = 0x18,
        [NativeName("Name", "SLANG_METAL_LIB")]
        MetalLib = 0x19,
        [NativeName("Name", "SLANG_METAL_LIB_ASM")]
        MetalLibAsm = 0x1A,
        [NativeName("Name", "SLANG_HOST_SHARED_LIBRARY")]
        HostSharedLibrary = 0x1B,
        [NativeName("Name", "SLANG_WGSL")]
        Wgsl = 0x1C,
        [NativeName("Name", "SLANG_WGSL_SPIRV_ASM")]
        WgslSpirvAsm = 0x1D,
        [NativeName("Name", "SLANG_WGSL_SPIRV")]
        WgslSpirv = 0x1E,
        [NativeName("Name", "SLANG_HOST_VM")]
        HostVM = 0x1F,
        [NativeName("Name", "SLANG_TARGET_COUNT_OF")]
        TargetCountOf = 0x20,
    }
}
