// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3Dsp
{
    [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_MASK 0x00ff0000")]
    public const int OpcodespecificcontrolMask = 0x00ff0000;

    [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_SHIFT 16")]
    public const int OpcodespecificcontrolShift = 16;

    [NativeTypeName("#define D3DSP_DCL_USAGE_SHIFT 0")]
    public const int DclUsageShift = 0;

    [NativeTypeName("#define D3DSP_DCL_USAGE_MASK 0x0000000f")]
    public const int DclUsageMask = 0x0000000f;

    [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_SHIFT 16")]
    public const int DclUsageindexShift = 16;

    [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_MASK 0x000f0000")]
    public const int DclUsageindexMask = 0x000f0000;

    [NativeTypeName("#define D3DSP_TEXTURETYPE_SHIFT 27")]
    public const int TexturetypeShift = 27;

    [NativeTypeName("#define D3DSP_TEXTURETYPE_MASK 0x78000000")]
    public const int TexturetypeMask = 0x78000000;

    [NativeTypeName("#define D3DSP_REGNUM_MASK 0x000007FF")]
    public const int RegnumMask = 0x000007FF;

    [NativeTypeName("#define D3DSP_WRITEMASK_0 0x00010000")]
    public const int Writemask0 = 0x00010000;

    [NativeTypeName("#define D3DSP_WRITEMASK_1 0x00020000")]
    public const int Writemask1 = 0x00020000;

    [NativeTypeName("#define D3DSP_WRITEMASK_2 0x00040000")]
    public const int Writemask2 = 0x00040000;

    [NativeTypeName("#define D3DSP_WRITEMASK_3 0x00080000")]
    public const int Writemask3 = 0x00080000;

    [NativeTypeName("#define D3DSP_WRITEMASK_ALL 0x000F0000")]
    public const int WritemaskAll = 0x000F0000;

    [NativeTypeName("#define D3DSP_DSTMOD_SHIFT 20")]
    public const int DstmodShift = 20;

    [NativeTypeName("#define D3DSP_DSTMOD_MASK 0x00F00000")]
    public const int DstmodMask = 0x00F00000;

    [NativeTypeName("#define D3DSP_DSTSHIFT_SHIFT 24")]
    public const int DstshiftShift = 24;

    [NativeTypeName("#define D3DSP_DSTSHIFT_MASK 0x0F000000")]
    public const int DstshiftMask = 0x0F000000;

    [NativeTypeName("#define D3DSP_REGTYPE_SHIFT 28")]
    public const int RegtypeShift = 28;

    [NativeTypeName("#define D3DSP_REGTYPE_SHIFT2 8")]
    public const int RegtypeShift2 = 8;

    [NativeTypeName("#define D3DSP_REGTYPE_MASK 0x70000000")]
    public const int RegtypeMask = 0x70000000;

    [NativeTypeName("#define D3DSP_REGTYPE_MASK2 0x00001800")]
    public const int RegtypeMask2 = 0x00001800;

    [NativeTypeName("#define D3DSP_SWIZZLE_SHIFT 16")]
    public const int SwizzleShift = 16;

    [NativeTypeName("#define D3DSP_SWIZZLE_MASK 0x00FF0000")]
    public const int SwizzleMask = 0x00FF0000;

    [NativeTypeName(
        "#define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )"
    )]
    public const int Noswizzle = (
        (0 << (16 + 0)) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6))
    );

    [NativeTypeName(
        "#define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )"
    )]
    public const int Replicatered = (
        (0 << (16 + 0)) | (0 << (16 + 2)) | (0 << (16 + 4)) | (0 << (16 + 6))
    );

    [NativeTypeName(
        "#define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )"
    )]
    public const int Replicategreen = (
        (1 << (16 + 0)) | (1 << (16 + 2)) | (1 << (16 + 4)) | (1 << (16 + 6))
    );

    [NativeTypeName(
        "#define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )"
    )]
    public const int Replicateblue = (
        (2 << (16 + 0)) | (2 << (16 + 2)) | (2 << (16 + 4)) | (2 << (16 + 6))
    );

    [NativeTypeName(
        "#define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )"
    )]
    public const int Replicatealpha = (
        (3 << (16 + 0)) | (3 << (16 + 2)) | (3 << (16 + 4)) | (3 << (16 + 6))
    );

    [NativeTypeName("#define D3DSP_SRCMOD_SHIFT 24")]
    public const int SrcmodShift = 24;

    [NativeTypeName("#define D3DSP_SRCMOD_MASK 0x0F000000")]
    public const int SrcmodMask = 0x0F000000;

    [NativeTypeName("#define D3DSP_MIN_PRECISION_SHIFT 14")]
    public const int MinPrecisionShift = 14;

    [NativeTypeName("#define D3DSP_MIN_PRECISION_MASK 0x0000C000")]
    public const int MinPrecisionMask = 0x0000C000;
}
