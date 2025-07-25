// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxgiformat.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

/// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT"]/*'/>
public enum DxgiFormat
{
    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_UNKNOWN"]/*'/>

    FormatUnknown = 0,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_TYPELESS"]/*'/>

    FormatR32G32B32A32Typeless = 1,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT"]/*'/>

    FormatR32G32B32A32Float = 2,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_UINT"]/*'/>

    FormatR32G32B32A32Uint = 3,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_SINT"]/*'/>

    FormatR32G32B32A32Sint = 4,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32_TYPELESS"]/*'/>

    FormatR32G32B32Typeless = 5,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT"]/*'/>

    FormatR32G32B32Float = 6,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32_UINT"]/*'/>

    FormatR32G32B32Uint = 7,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32B32_SINT"]/*'/>

    FormatR32G32B32Sint = 8,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_TYPELESS"]/*'/>

    FormatR16G16B16A16Typeless = 9,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT"]/*'/>

    FormatR16G16B16A16Float = 10,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM"]/*'/>

    FormatR16G16B16A16Unorm = 11,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UINT"]/*'/>

    FormatR16G16B16A16Uint = 12,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SNORM"]/*'/>

    FormatR16G16B16A16Snorm = 13,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SINT"]/*'/>

    FormatR16G16B16A16Sint = 14,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32_TYPELESS"]/*'/>

    FormatR32G32Typeless = 15,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT"]/*'/>

    FormatR32G32Float = 16,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32_UINT"]/*'/>

    FormatR32G32Uint = 17,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G32_SINT"]/*'/>

    FormatR32G32Sint = 18,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32G8X24_TYPELESS"]/*'/>

    FormatR32G8X24Typeless = 19,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT_S8X24_UINT"]/*'/>

    FormatD32FloatS8X24Uint = 20,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS"]/*'/>

    FormatR32FloatX8X24Typeless = 21,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_X32_TYPELESS_G8X24_UINT"]/*'/>

    FormatX32TypelessG8X24Uint = 22,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_TYPELESS"]/*'/>

    FormatR10G10B10A2Typeless = 23,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM"]/*'/>

    FormatR10G10B10A2Unorm = 24,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UINT"]/*'/>

    FormatR10G10B10A2Uint = 25,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R11G11B10_FLOAT"]/*'/>

    FormatR11G11B10Float = 26,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_TYPELESS"]/*'/>

    FormatR8G8B8A8Typeless = 27,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM"]/*'/>

    FormatR8G8B8A8Unorm = 28,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB"]/*'/>

    FormatR8G8B8A8UnormSrgb = 29,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UINT"]/*'/>

    FormatR8G8B8A8Uint = 30,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SNORM"]/*'/>

    FormatR8G8B8A8Snorm = 31,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SINT"]/*'/>

    FormatR8G8B8A8Sint = 32,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_TYPELESS"]/*'/>

    FormatR16G16Typeless = 33,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_FLOAT"]/*'/>

    FormatR16G16Float = 34,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_UNORM"]/*'/>

    FormatR16G16Unorm = 35,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_UINT"]/*'/>

    FormatR16G16Uint = 36,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_SNORM"]/*'/>

    FormatR16G16Snorm = 37,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16G16_SINT"]/*'/>

    FormatR16G16Sint = 38,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32_TYPELESS"]/*'/>

    FormatR32Typeless = 39,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT"]/*'/>

    FormatD32Float = 40,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT"]/*'/>

    FormatR32Float = 41,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32_UINT"]/*'/>

    FormatR32Uint = 42,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R32_SINT"]/*'/>

    FormatR32Sint = 43,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R24G8_TYPELESS"]/*'/>

    FormatR24G8Typeless = 44,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_D24_UNORM_S8_UINT"]/*'/>

    FormatD24UnormS8Uint = 45,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R24_UNORM_X8_TYPELESS"]/*'/>

    FormatR24UnormX8Typeless = 46,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_X24_TYPELESS_G8_UINT"]/*'/>

    FormatX24TypelessG8Uint = 47,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_TYPELESS"]/*'/>

    FormatR8G8Typeless = 48,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM"]/*'/>

    FormatR8G8Unorm = 49,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_UINT"]/*'/>

    FormatR8G8Uint = 50,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_SNORM"]/*'/>

    FormatR8G8Snorm = 51,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_SINT"]/*'/>

    FormatR8G8Sint = 52,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_TYPELESS"]/*'/>

    FormatR16Typeless = 53,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT"]/*'/>

    FormatR16Float = 54,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_D16_UNORM"]/*'/>

    FormatD16Unorm = 55,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_UNORM"]/*'/>

    FormatR16Unorm = 56,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_UINT"]/*'/>

    FormatR16Uint = 57,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_SNORM"]/*'/>

    FormatR16Snorm = 58,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R16_SINT"]/*'/>

    FormatR16Sint = 59,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8_TYPELESS"]/*'/>

    FormatR8Typeless = 60,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8_UNORM"]/*'/>

    FormatR8Unorm = 61,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8_UINT"]/*'/>

    FormatR8Uint = 62,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8_SNORM"]/*'/>

    FormatR8Snorm = 63,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8_SINT"]/*'/>

    FormatR8Sint = 64,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_A8_UNORM"]/*'/>

    FormatA8Unorm = 65,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R1_UNORM"]/*'/>

    FormatR1Unorm = 66,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R9G9B9E5_SHAREDEXP"]/*'/>

    FormatR9G9B9E5Sharedexp = 67,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R8G8_B8G8_UNORM"]/*'/>

    FormatR8G8B8G8Unorm = 68,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_G8R8_G8B8_UNORM"]/*'/>

    FormatG8R8G8B8Unorm = 69,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC1_TYPELESS"]/*'/>

    FormatBc1Typeless = 70,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM"]/*'/>

    FormatBc1Unorm = 71,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB"]/*'/>

    FormatBc1UnormSrgb = 72,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC2_TYPELESS"]/*'/>

    FormatBc2Typeless = 73,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM"]/*'/>

    FormatBc2Unorm = 74,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM_SRGB"]/*'/>

    FormatBc2UnormSrgb = 75,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC3_TYPELESS"]/*'/>

    FormatBc3Typeless = 76,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM"]/*'/>

    FormatBc3Unorm = 77,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB"]/*'/>

    FormatBc3UnormSrgb = 78,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC4_TYPELESS"]/*'/>

    FormatBc4Typeless = 79,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM"]/*'/>

    FormatBc4Unorm = 80,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC4_SNORM"]/*'/>

    FormatBc4Snorm = 81,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC5_TYPELESS"]/*'/>

    FormatBc5Typeless = 82,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM"]/*'/>

    FormatBc5Unorm = 83,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC5_SNORM"]/*'/>

    FormatBc5Snorm = 84,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B5G6R5_UNORM"]/*'/>

    FormatB5G6R5Unorm = 85,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B5G5R5A1_UNORM"]/*'/>

    FormatB5G5R5A1Unorm = 86,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM"]/*'/>

    FormatB8G8R8A8Unorm = 87,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8X8_UNORM"]/*'/>

    FormatB8G8R8X8Unorm = 88,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM"]/*'/>

    FormatR10G10B10XrBiasA2Unorm = 89,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_TYPELESS"]/*'/>

    FormatB8G8R8A8Typeless = 90,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM_SRGB"]/*'/>

    FormatB8G8R8A8UnormSrgb = 91,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8X8_TYPELESS"]/*'/>

    FormatB8G8R8X8Typeless = 92,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B8G8R8X8_UNORM_SRGB"]/*'/>

    FormatB8G8R8X8UnormSrgb = 93,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC6H_TYPELESS"]/*'/>

    FormatBc6HTypeless = 94,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC6H_UF16"]/*'/>

    FormatBc6HUf16 = 95,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC6H_SF16"]/*'/>

    FormatBc6HSf16 = 96,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC7_TYPELESS"]/*'/>

    FormatBc7Typeless = 97,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM"]/*'/>

    FormatBc7Unorm = 98,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB"]/*'/>

    FormatBc7UnormSrgb = 99,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_AYUV"]/*'/>

    FormatAyuv = 100,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_Y410"]/*'/>

    FormatY410 = 101,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_Y416"]/*'/>

    FormatY416 = 102,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_NV12"]/*'/>

    FormatNv12 = 103,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_P010"]/*'/>

    FormatP010 = 104,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_P016"]/*'/>

    FormatP016 = 105,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_420_OPAQUE"]/*'/>

    Format420Opaque = 106,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_YUY2"]/*'/>

    FormatYuy2 = 107,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_Y210"]/*'/>

    FormatY210 = 108,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_Y216"]/*'/>

    FormatY216 = 109,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_NV11"]/*'/>

    FormatNv11 = 110,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_AI44"]/*'/>

    FormatAi44 = 111,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_IA44"]/*'/>

    FormatIa44 = 112,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_P8"]/*'/>

    FormatP8 = 113,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_A8P8"]/*'/>

    FormatA8P8 = 114,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_B4G4R4A4_UNORM"]/*'/>

    FormatB4G4R4A4Unorm = 115,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_P208"]/*'/>

    FormatP208 = 130,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_V208"]/*'/>

    FormatV208 = 131,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_V408"]/*'/>

    FormatV408 = 132,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_SAMPLER_FEEDBACK_MIN_MIP_OPAQUE"]/*'/>

    FormatSamplerFeedbackMinMipOpaque = 189,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_SAMPLER_FEEDBACK_MIP_REGION_USED_OPAQUE"]/*'/>

    FormatSamplerFeedbackMipRegionUsedOpaque = 190,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_A4B4G4R4_UNORM"]/*'/>

    FormatA4B4G4R4Unorm = 191,

    /// <include file='DXGI_FORMAT.xml' path='doc/member[@name="DXGI_FORMAT.DXGI_FORMAT_FORCE_UINT"]/*'/>

    FormatForceUint = unchecked((int)(0xffffffff)),
}
