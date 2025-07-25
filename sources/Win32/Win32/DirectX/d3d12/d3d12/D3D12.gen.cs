// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class D3D12
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid ProtectedResourcesSessionHardwareProtected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0x08,
                0xB0,
                0x62,
                0x0E,
                0xC7,
                0xAA,
                0x4D,
                0xA1,
                0x09,
                0x30,
                0xFF,
                0x8D,
                0x5A,
                0x04,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define D3D12_16BIT_INDEX_STRIP_CUT_VALUE ( 0xffff )")]
    public const int X16BitIndexStripCutValue = (0xffff);

    [NativeTypeName("#define D3D12_32BIT_INDEX_STRIP_CUT_VALUE ( 0xffffffff )")]
    public const uint X32BitIndexStripCutValue = (0xffffffff);

    [NativeTypeName("#define D3D12_8BIT_INDEX_STRIP_CUT_VALUE ( 0xff )")]
    public const int X8BitIndexStripCutValue = (0xff);

    [NativeTypeName("#define D3D12_APPEND_ALIGNED_ELEMENT ( 0xffffffff )")]
    public const uint AppendAlignedElement = (0xffffffff);

    [NativeTypeName("#define D3D12_ARRAY_AXIS_ADDRESS_RANGE_BIT_COUNT ( 9 )")]
    public const int ArrayAxisAddressRangeBitCount = (9);

    [NativeTypeName("#define D3D12_CLIP_OR_CULL_DISTANCE_COUNT ( 8 )")]
    public const int ClipOrCullDistanceCount = (8);

    [NativeTypeName("#define D3D12_CLIP_OR_CULL_DISTANCE_ELEMENT_COUNT ( 2 )")]
    public const int ClipOrCullDistanceElementCount = (2);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT ( 14 )")]
    public const int CommonshaderConstantBufferApiSlotCount = (14);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS ( 4 )")]
    public const int CommonshaderConstantBufferComponents = (4);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int CommonshaderConstantBufferComponentBitCount = (32);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT ( 15 )")]
    public const int CommonshaderConstantBufferHwSlotCount = (15);

    [NativeTypeName(
        "#define D3D12_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT ( 16 )"
    )]
    public const int CommonshaderConstantBufferPartialUpdateExtentsByteAlignment = (16);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )")]
    public const int CommonshaderConstantBufferRegisterComponents = (4);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT ( 15 )")]
    public const int CommonshaderConstantBufferRegisterCount = (15);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )")]
    public const int CommonshaderConstantBufferRegisterReadsPerInst = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )")]
    public const int CommonshaderConstantBufferRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT ( 64 )")]
    public const int CommonshaderFlowcontrolNestingLimit = (64);

    [NativeTypeName(
        "#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS ( 4 )"
    )]
    public const int CommonshaderImmediateConstantBufferRegisterComponents = (4);

    [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT ( 1 )")]
    public const int CommonshaderImmediateConstantBufferRegisterCount = (1);

    [NativeTypeName(
        "#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST ( 1 )"
    )]
    public const int CommonshaderImmediateConstantBufferRegisterReadsPerInst = (1);

    [NativeTypeName(
        "#define D3D12_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS ( 1 )"
    )]
    public const int CommonshaderImmediateConstantBufferRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT ( 32 )")]
    public const int CommonshaderImmediateValueComponentBitCount = (32);

    [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int CommonshaderInputResourceRegisterComponents = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT ( 128 )")]
    public const int CommonshaderInputResourceRegisterCount = (128);

    [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST ( 1 )")]
    public const int CommonshaderInputResourceRegisterReadsPerInst = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int CommonshaderInputResourceRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT ( 128 )")]
    public const int CommonshaderInputResourceSlotCount = (128);

    [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS ( 1 )")]
    public const int CommonshaderSamplerRegisterComponents = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_COUNT ( 16 )")]
    public const int CommonshaderSamplerRegisterCount = (16);

    [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST ( 1 )")]
    public const int CommonshaderSamplerRegisterReadsPerInst = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS ( 1 )")]
    public const int CommonshaderSamplerRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_COMMONSHADER_SAMPLER_SLOT_COUNT ( 16 )")]
    public const int CommonshaderSamplerSlotCount = (16);

    [NativeTypeName("#define D3D12_COMMONSHADER_SUBROUTINE_NESTING_LIMIT ( 32 )")]
    public const int CommonshaderSubroutineNestingLimit = (32);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENTS ( 4 )")]
    public const int CommonshaderTempRegisterComponents = (4);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int CommonshaderTempRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_COUNT ( 4096 )")]
    public const int CommonshaderTempRegisterCount = (4096);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_READS_PER_INST ( 3 )")]
    public const int CommonshaderTempRegisterReadsPerInst = (3);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEMP_REGISTER_READ_PORTS ( 3 )")]
    public const int CommonshaderTempRegisterReadPorts = (3);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX ( 10 )")]
    public const int CommonshaderTexcoordRangeReductionMax = (10);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN ( -10 )")]
    public const int CommonshaderTexcoordRangeReductionMin = (-10);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE ( -8 )")]
    public const int CommonshaderTexelOffsetMaxNegative = (-8);

    [NativeTypeName("#define D3D12_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE ( 7 )")]
    public const int CommonshaderTexelOffsetMaxPositive = (7);

    [NativeTypeName("#define D3D12_CONSTANT_BUFFER_DATA_PLACEMENT_ALIGNMENT ( 256 )")]
    public const int ConstantBufferDataPlacementAlignment = (256);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET00_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 256 )")]
    public const int Cs4XBucket00MaxBytesTgsmWritablePerThread = (256);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET00_MAX_NUM_THREADS_PER_GROUP ( 64 )")]
    public const int Cs4XBucket00MaxNumThreadsPerGroup = (64);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET01_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 240 )")]
    public const int Cs4XBucket01MaxBytesTgsmWritablePerThread = (240);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET01_MAX_NUM_THREADS_PER_GROUP ( 68 )")]
    public const int Cs4XBucket01MaxNumThreadsPerGroup = (68);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET02_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 224 )")]
    public const int Cs4XBucket02MaxBytesTgsmWritablePerThread = (224);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET02_MAX_NUM_THREADS_PER_GROUP ( 72 )")]
    public const int Cs4XBucket02MaxNumThreadsPerGroup = (72);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET03_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 208 )")]
    public const int Cs4XBucket03MaxBytesTgsmWritablePerThread = (208);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET03_MAX_NUM_THREADS_PER_GROUP ( 76 )")]
    public const int Cs4XBucket03MaxNumThreadsPerGroup = (76);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET04_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 192 )")]
    public const int Cs4XBucket04MaxBytesTgsmWritablePerThread = (192);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET04_MAX_NUM_THREADS_PER_GROUP ( 84 )")]
    public const int Cs4XBucket04MaxNumThreadsPerGroup = (84);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET05_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 176 )")]
    public const int Cs4XBucket05MaxBytesTgsmWritablePerThread = (176);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET05_MAX_NUM_THREADS_PER_GROUP ( 92 )")]
    public const int Cs4XBucket05MaxNumThreadsPerGroup = (92);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET06_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 160 )")]
    public const int Cs4XBucket06MaxBytesTgsmWritablePerThread = (160);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET06_MAX_NUM_THREADS_PER_GROUP ( 100 )")]
    public const int Cs4XBucket06MaxNumThreadsPerGroup = (100);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET07_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 144 )")]
    public const int Cs4XBucket07MaxBytesTgsmWritablePerThread = (144);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET07_MAX_NUM_THREADS_PER_GROUP ( 112 )")]
    public const int Cs4XBucket07MaxNumThreadsPerGroup = (112);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET08_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 128 )")]
    public const int Cs4XBucket08MaxBytesTgsmWritablePerThread = (128);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET08_MAX_NUM_THREADS_PER_GROUP ( 128 )")]
    public const int Cs4XBucket08MaxNumThreadsPerGroup = (128);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET09_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 112 )")]
    public const int Cs4XBucket09MaxBytesTgsmWritablePerThread = (112);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET09_MAX_NUM_THREADS_PER_GROUP ( 144 )")]
    public const int Cs4XBucket09MaxNumThreadsPerGroup = (144);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET10_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 96 )")]
    public const int Cs4XBucket10MaxBytesTgsmWritablePerThread = (96);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET10_MAX_NUM_THREADS_PER_GROUP ( 168 )")]
    public const int Cs4XBucket10MaxNumThreadsPerGroup = (168);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET11_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 80 )")]
    public const int Cs4XBucket11MaxBytesTgsmWritablePerThread = (80);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET11_MAX_NUM_THREADS_PER_GROUP ( 204 )")]
    public const int Cs4XBucket11MaxNumThreadsPerGroup = (204);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET12_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 64 )")]
    public const int Cs4XBucket12MaxBytesTgsmWritablePerThread = (64);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET12_MAX_NUM_THREADS_PER_GROUP ( 256 )")]
    public const int Cs4XBucket12MaxNumThreadsPerGroup = (256);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET13_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 48 )")]
    public const int Cs4XBucket13MaxBytesTgsmWritablePerThread = (48);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET13_MAX_NUM_THREADS_PER_GROUP ( 340 )")]
    public const int Cs4XBucket13MaxNumThreadsPerGroup = (340);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET14_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 32 )")]
    public const int Cs4XBucket14MaxBytesTgsmWritablePerThread = (32);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET14_MAX_NUM_THREADS_PER_GROUP ( 512 )")]
    public const int Cs4XBucket14MaxNumThreadsPerGroup = (512);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET15_MAX_BYTES_TGSM_WRITABLE_PER_THREAD ( 16 )")]
    public const int Cs4XBucket15MaxBytesTgsmWritablePerThread = (16);

    [NativeTypeName("#define D3D12_CS_4_X_BUCKET15_MAX_NUM_THREADS_PER_GROUP ( 768 )")]
    public const int Cs4XBucket15MaxNumThreadsPerGroup = (768);

    [NativeTypeName("#define D3D12_CS_4_X_DISPATCH_MAX_THREAD_GROUPS_IN_Z_DIMENSION ( 1 )")]
    public const int Cs4XDispatchMaxThreadGroupsInZDimension = (1);

    [NativeTypeName("#define D3D12_CS_4_X_RAW_UAV_BYTE_ALIGNMENT ( 256 )")]
    public const int Cs4XRawUavByteAlignment = (256);

    [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 768 )")]
    public const int Cs4XThreadGroupMaxThreadsPerGroup = (768);

    [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_X ( 768 )")]
    public const int Cs4XThreadGroupMaxX = (768);

    [NativeTypeName("#define D3D12_CS_4_X_THREAD_GROUP_MAX_Y ( 768 )")]
    public const int Cs4XThreadGroupMaxY = (768);

    [NativeTypeName("#define D3D12_CS_4_X_UAV_REGISTER_COUNT ( 1 )")]
    public const int Cs4XUavRegisterCount = (1);

    [NativeTypeName("#define D3D12_CS_DISPATCH_MAX_THREAD_GROUPS_PER_DIMENSION ( 65535 )")]
    public const int CsDispatchMaxThreadGroupsPerDimension = (65535);

    [NativeTypeName("#define D3D12_CS_TGSM_REGISTER_COUNT ( 8192 )")]
    public const int CsTgsmRegisterCount = (8192);

    [NativeTypeName("#define D3D12_CS_TGSM_REGISTER_READS_PER_INST ( 1 )")]
    public const int CsTgsmRegisterReadsPerInst = (1);

    [NativeTypeName("#define D3D12_CS_TGSM_RESOURCE_REGISTER_COMPONENTS ( 1 )")]
    public const int CsTgsmResourceRegisterComponents = (1);

    [NativeTypeName("#define D3D12_CS_TGSM_RESOURCE_REGISTER_READ_PORTS ( 1 )")]
    public const int CsTgsmResourceRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_CS_THREADGROUPID_REGISTER_COMPONENTS ( 3 )")]
    public const int CsThreadgroupidRegisterComponents = (3);

    [NativeTypeName("#define D3D12_CS_THREADGROUPID_REGISTER_COUNT ( 1 )")]
    public const int CsThreadgroupidRegisterCount = (1);

    [NativeTypeName("#define D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COMPONENTS ( 1 )")]
    public const int CsThreadidingroupflattenedRegisterComponents = (1);

    [NativeTypeName("#define D3D12_CS_THREADIDINGROUPFLATTENED_REGISTER_COUNT ( 1 )")]
    public const int CsThreadidingroupflattenedRegisterCount = (1);

    [NativeTypeName("#define D3D12_CS_THREADIDINGROUP_REGISTER_COMPONENTS ( 3 )")]
    public const int CsThreadidingroupRegisterComponents = (3);

    [NativeTypeName("#define D3D12_CS_THREADIDINGROUP_REGISTER_COUNT ( 1 )")]
    public const int CsThreadidingroupRegisterCount = (1);

    [NativeTypeName("#define D3D12_CS_THREADID_REGISTER_COMPONENTS ( 3 )")]
    public const int CsThreadidRegisterComponents = (3);

    [NativeTypeName("#define D3D12_CS_THREADID_REGISTER_COUNT ( 1 )")]
    public const int CsThreadidRegisterCount = (1);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_THREADS_PER_GROUP ( 1024 )")]
    public const int CsThreadGroupMaxThreadsPerGroup = (1024);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_X ( 1024 )")]
    public const int CsThreadGroupMaxX = (1024);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_Y ( 1024 )")]
    public const int CsThreadGroupMaxY = (1024);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MAX_Z ( 64 )")]
    public const int CsThreadGroupMaxZ = (64);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_X ( 1 )")]
    public const int CsThreadGroupMinX = (1);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_Y ( 1 )")]
    public const int CsThreadGroupMinY = (1);

    [NativeTypeName("#define D3D12_CS_THREAD_GROUP_MIN_Z ( 1 )")]
    public const int CsThreadGroupMinZ = (1);

    [NativeTypeName("#define D3D12_CS_THREAD_LOCAL_TEMP_REGISTER_POOL ( 16384 )")]
    public const int CsThreadLocalTempRegisterPool = (16384);

    [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_ALPHA ( 1.0f )")]
    public const float DefaultBlendFactorAlpha = (1.0f);

    [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_BLUE ( 1.0f )")]
    public const float DefaultBlendFactorBlue = (1.0f);

    [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_GREEN ( 1.0f )")]
    public const float DefaultBlendFactorGreen = (1.0f);

    [NativeTypeName("#define D3D12_DEFAULT_BLEND_FACTOR_RED ( 1.0f )")]
    public const float DefaultBlendFactorRed = (1.0f);

    [NativeTypeName("#define D3D12_DEFAULT_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float DefaultBorderColorComponent = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_DEPTH_BIAS ( 0 )")]
    public const int DefaultDepthBias = (0);

    [NativeTypeName("#define D3D12_DEFAULT_DEPTH_BIAS_CLAMP ( 0.0f )")]
    public const float DefaultDepthBiasClamp = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_MAX_ANISOTROPY ( 16 )")]
    public const int DefaultMaxAnisotropy = (16);

    [NativeTypeName("#define D3D12_DEFAULT_MIP_LOD_BIAS ( 0.0f )")]
    public const float DefaultMipLodBias = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 4194304 )")]
    public const int DefaultMsaaResourcePlacementAlignment = (4194304);

    [NativeTypeName("#define D3D12_DEFAULT_RENDER_TARGET_ARRAY_INDEX ( 0 )")]
    public const int DefaultRenderTargetArrayIndex = (0);

    [NativeTypeName("#define D3D12_DEFAULT_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
    public const int DefaultResourcePlacementAlignment = (65536);

    [NativeTypeName("#define D3D12_DEFAULT_SAMPLE_MASK ( 0xffffffff )")]
    public const uint DefaultSampleMask = (0xffffffff);

    [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_ENDX ( 0 )")]
    public const int DefaultScissorEndx = (0);

    [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_ENDY ( 0 )")]
    public const int DefaultScissorEndy = (0);

    [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_STARTX ( 0 )")]
    public const int DefaultScissorStartx = (0);

    [NativeTypeName("#define D3D12_DEFAULT_SCISSOR_STARTY ( 0 )")]
    public const int DefaultScissorStarty = (0);

    [NativeTypeName("#define D3D12_DEFAULT_SLOPE_SCALED_DEPTH_BIAS ( 0.0f )")]
    public const float DefaultSlopeScaledDepthBias = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_STENCIL_READ_MASK ( 0xff )")]
    public const int DefaultStencilReadMask = (0xff);

    [NativeTypeName("#define D3D12_DEFAULT_STENCIL_REFERENCE ( 0 )")]
    public const int DefaultStencilReference = (0);

    [NativeTypeName("#define D3D12_DEFAULT_STENCIL_WRITE_MASK ( 0xff )")]
    public const int DefaultStencilWriteMask = (0xff);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_AND_SCISSORRECT_INDEX ( 0 )")]
    public const int DefaultViewportAndScissorrectIndex = (0);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_HEIGHT ( 0 )")]
    public const int DefaultViewportHeight = (0);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_MAX_DEPTH ( 0.0f )")]
    public const float DefaultViewportMaxDepth = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_MIN_DEPTH ( 0.0f )")]
    public const float DefaultViewportMinDepth = (0.0f);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_TOPLEFTX ( 0 )")]
    public const int DefaultViewportTopleftx = (0);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_TOPLEFTY ( 0 )")]
    public const int DefaultViewportToplefty = (0);

    [NativeTypeName("#define D3D12_DEFAULT_VIEWPORT_WIDTH ( 0 )")]
    public const int DefaultViewportWidth = (0);

    [NativeTypeName("#define D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND ( 0xffffffff )")]
    public const uint DescriptorRangeOffsetAppend = (0xffffffff);

    [NativeTypeName("#define D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_END ( 0xfffffff7 )")]
    public const uint DriverReservedRegisterSpaceValuesEnd = (0xfffffff7);

    [NativeTypeName("#define D3D12_DRIVER_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff0 )")]
    public const uint DriverReservedRegisterSpaceValuesStart = (0xfffffff0);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int DsInputControlPointsMaxTotalScalars = (3968);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int DsInputControlPointRegisterComponents = (4);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int DsInputControlPointRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_COUNT ( 32 )")]
    public const int DsInputControlPointRegisterCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int DsInputControlPointRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_DS_INPUT_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int DsInputControlPointRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENTS ( 3 )")]
    public const int DsInputDomainPointRegisterComponents = (3);

    [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int DsInputDomainPointRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_COUNT ( 1 )")]
    public const int DsInputDomainPointRegisterCount = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int DsInputDomainPointRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_DS_INPUT_DOMAIN_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int DsInputDomainPointRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int DsInputPatchConstantRegisterComponents = (4);

    [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int DsInputPatchConstantRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int DsInputPatchConstantRegisterCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int DsInputPatchConstantRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_DS_INPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int DsInputPatchConstantRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int DsInputPrimitiveIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int DsInputPrimitiveIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int DsInputPrimitiveIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int DsInputPrimitiveIdRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_DS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int DsInputPrimitiveIdRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int DsOutputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int DsOutputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_DS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int DsOutputRegisterCount = (32);

    [NativeTypeName("#define D3D12_FLOAT16_FUSED_TOLERANCE_IN_ULP ( 0.6 )")]
    public const double Float16FusedToleranceInUlp = (0.6);

    [NativeTypeName("#define D3D12_FLOAT32_MAX ( 3.402823466e+38f )")]
    public const float Float32Max = (3.402823466e+38f);

    [NativeTypeName("#define D3D12_FLOAT32_TO_INTEGER_TOLERANCE_IN_ULP ( 0.6f )")]
    public const float Float32ToIntegerToleranceInUlp = (0.6f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_EXPONENT_DENOMINATOR ( 2.4f )")]
    public const float FloatToSrgbExponentDenominator = (2.4f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_EXPONENT_NUMERATOR ( 1.0f )")]
    public const float FloatToSrgbExponentNumerator = (1.0f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_OFFSET ( 0.055f )")]
    public const float FloatToSrgbOffset = (0.055f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_SCALE_1 ( 12.92f )")]
    public const float FloatToSrgbScale1 = (12.92f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_SCALE_2 ( 1.055f )")]
    public const float FloatToSrgbScale2 = (1.055f);

    [NativeTypeName("#define D3D12_FLOAT_TO_SRGB_THRESHOLD ( 0.0031308f )")]
    public const float FloatToSrgbThreshold = (0.0031308f);

    [NativeTypeName("#define D3D12_FTOI_INSTRUCTION_MAX_INPUT ( 2147483647.999f )")]
    public const float FtoiInstructionMaxInput = (2147483647.999f);

    [NativeTypeName("#define D3D12_FTOI_INSTRUCTION_MIN_INPUT ( -2147483648.999f )")]
    public const float FtoiInstructionMinInput = (-2147483648.999f);

    [NativeTypeName("#define D3D12_FTOU_INSTRUCTION_MAX_INPUT ( 4294967295.999f )")]
    public const float FtouInstructionMaxInput = (4294967295.999f);

    [NativeTypeName("#define D3D12_FTOU_INSTRUCTION_MIN_INPUT ( 0.0f )")]
    public const float FtouInstructionMinInput = (0.0f);

    [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_READS_PER_INST ( 2 )")]
    public const int GsInputInstanceIdReadsPerInst = (2);

    [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_READ_PORTS ( 1 )")]
    public const int GsInputInstanceIdReadPorts = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int GsInputInstanceIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int GsInputInstanceIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_GS_INPUT_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int GsInputInstanceIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENTS ( 1 )")]
    public const int GsInputPrimConstRegisterComponents = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int GsInputPrimConstRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_COUNT ( 1 )")]
    public const int GsInputPrimConstRegisterCount = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_READS_PER_INST ( 2 )")]
    public const int GsInputPrimConstRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_GS_INPUT_PRIM_CONST_REGISTER_READ_PORTS ( 1 )")]
    public const int GsInputPrimConstRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int GsInputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int GsInputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int GsInputRegisterCount = (32);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int GsInputRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int GsInputRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_GS_INPUT_REGISTER_VERTICES ( 32 )")]
    public const int GsInputRegisterVertices = (32);

    [NativeTypeName("#define D3D12_GS_MAX_INSTANCE_COUNT ( 32 )")]
    public const int GsMaxInstanceCount = (32);

    [NativeTypeName("#define D3D12_GS_MAX_OUTPUT_VERTEX_COUNT_ACROSS_INSTANCES ( 1024 )")]
    public const int GsMaxOutputVertexCountAcrossInstances = (1024);

    [NativeTypeName("#define D3D12_GS_OUTPUT_ELEMENTS ( 32 )")]
    public const int GsOutputElements = (32);

    [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int GsOutputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int GsOutputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_GS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int GsOutputRegisterCount = (32);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_PHASE_INPUT_REGISTER_COUNT ( 32 )")]
    public const int HsControlPointPhaseInputRegisterCount = (32);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_PHASE_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int HsControlPointPhaseOutputRegisterCount = (32);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_COMPONENTS ( 4 )")]
    public const int HsControlPointRegisterComponents = (4);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsControlPointRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsControlPointRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_CONTROL_POINT_REGISTER_READ_PORTS ( 1 )")]
    public const int HsControlPointRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_FORK_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint HsForkPhaseInstanceCountUpperBound = (0xffffffff);

    [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int HsInputForkInstanceIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsInputForkInstanceIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int HsInputForkInstanceIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsInputForkInstanceIdRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_INPUT_FORK_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int HsInputForkInstanceIdRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int HsInputJoinInstanceIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsInputJoinInstanceIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_COUNT ( 1 )")]
    public const int HsInputJoinInstanceIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsInputJoinInstanceIdRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_INPUT_JOIN_INSTANCE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int HsInputJoinInstanceIdRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int HsInputPrimitiveIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsInputPrimitiveIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_COUNT ( 1 )")]
    public const int HsInputPrimitiveIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsInputPrimitiveIdRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_INPUT_PRIMITIVE_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int HsInputPrimitiveIdRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_JOIN_PHASE_INSTANCE_COUNT_UPPER_BOUND ( 0xffffffff )")]
    public const uint HsJoinPhaseInstanceCountUpperBound = (0xffffffff);

    [NativeTypeName("#define D3D12_HS_MAXTESSFACTOR_LOWER_BOUND ( 1.0f )")]
    public const float HsMaxtessfactorLowerBound = (1.0f);

    [NativeTypeName("#define D3D12_HS_MAXTESSFACTOR_UPPER_BOUND ( 64.0f )")]
    public const float HsMaxtessfactorUpperBound = (64.0f);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINTS_MAX_TOTAL_SCALARS ( 3968 )")]
    public const int HsOutputControlPointsMaxTotalScalars = (3968);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENTS ( 1 )")]
    public const int HsOutputControlPointIdRegisterComponents = (1);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsOutputControlPointIdRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_COUNT ( 1 )")]
    public const int HsOutputControlPointIdRegisterCount = (1);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsOutputControlPointIdRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_OUTPUT_CONTROL_POINT_ID_REGISTER_READ_PORTS ( 1 )")]
    public const int HsOutputControlPointIdRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENTS ( 4 )")]
    public const int HsOutputPatchConstantRegisterComponents = (4);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int HsOutputPatchConstantRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_COUNT ( 32 )")]
    public const int HsOutputPatchConstantRegisterCount = (32);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READS_PER_INST ( 2 )")]
    public const int HsOutputPatchConstantRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_READ_PORTS ( 1 )")]
    public const int HsOutputPatchConstantRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_HS_OUTPUT_PATCH_CONSTANT_REGISTER_SCALAR_COMPONENTS ( 128 )")]
    public const int HsOutputPatchConstantRegisterScalarComponents = (128);

    [NativeTypeName("#define D3D12_IA_DEFAULT_INDEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int IaDefaultIndexBufferOffsetInBytes = (0);

    [NativeTypeName("#define D3D12_IA_DEFAULT_PRIMITIVE_TOPOLOGY ( 0 )")]
    public const int IaDefaultPrimitiveTopology = (0);

    [NativeTypeName("#define D3D12_IA_DEFAULT_VERTEX_BUFFER_OFFSET_IN_BYTES ( 0 )")]
    public const int IaDefaultVertexBufferOffsetInBytes = (0);

    [NativeTypeName("#define D3D12_IA_INDEX_INPUT_RESOURCE_SLOT_COUNT ( 1 )")]
    public const int IaIndexInputResourceSlotCount = (1);

    [NativeTypeName("#define D3D12_IA_INSTANCE_ID_BIT_COUNT ( 32 )")]
    public const int IaInstanceIdBitCount = (32);

    [NativeTypeName("#define D3D12_IA_INTEGER_ARITHMETIC_BIT_COUNT ( 32 )")]
    public const int IaIntegerArithmeticBitCount = (32);

    [NativeTypeName("#define D3D12_IA_PATCH_MAX_CONTROL_POINT_COUNT ( 32 )")]
    public const int IaPatchMaxControlPointCount = (32);

    [NativeTypeName("#define D3D12_IA_PRIMITIVE_ID_BIT_COUNT ( 32 )")]
    public const int IaPrimitiveIdBitCount = (32);

    [NativeTypeName("#define D3D12_IA_VERTEX_ID_BIT_COUNT ( 32 )")]
    public const int IaVertexIdBitCount = (32);

    [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT ( 32 )")]
    public const int IaVertexInputResourceSlotCount = (32);

    [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENTS_COMPONENTS ( 128 )")]
    public const int IaVertexInputStructureElementsComponents = (128);

    [NativeTypeName("#define D3D12_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ( 32 )")]
    public const int IaVertexInputStructureElementCount = (32);

    [NativeTypeName("#define D3D12_INTEGER_DIVIDE_BY_ZERO_QUOTIENT ( 0xffffffff )")]
    public const uint IntegerDivideByZeroQuotient = (0xffffffff);

    [NativeTypeName("#define D3D12_INTEGER_DIVIDE_BY_ZERO_REMAINDER ( 0xffffffff )")]
    public const uint IntegerDivideByZeroRemainder = (0xffffffff);

    [NativeTypeName("#define D3D12_KEEP_RENDER_TARGETS_AND_DEPTH_STENCIL ( 0xffffffff )")]
    public const uint KeepRenderTargetsAndDepthStencil = (0xffffffff);

    [NativeTypeName("#define D3D12_KEEP_UNORDERED_ACCESS_VIEWS ( 0xffffffff )")]
    public const uint KeepUnorderedAccessViews = (0xffffffff);

    [NativeTypeName("#define D3D12_LINEAR_GAMMA ( 1.0f )")]
    public const float LinearGamma = (1.0f);

    [NativeTypeName("#define D3D12_MAJOR_VERSION ( 12 )")]
    public const int MajorVersion = (12);

    [NativeTypeName("#define D3D12_MAX_BORDER_COLOR_COMPONENT ( 1.0f )")]
    public const float MaxBorderColorComponent = (1.0f);

    [NativeTypeName("#define D3D12_MAX_DEPTH ( 1.0f )")]
    public const float MaxDepth = (1.0f);

    [NativeTypeName("#define D3D12_MAX_LIVE_STATIC_SAMPLERS ( 2032 )")]
    public const int MaxLiveStaticSamplers = (2032);

    [NativeTypeName("#define D3D12_MAX_MAXANISOTROPY ( 16 )")]
    public const int MaxMaxanisotropy = (16);

    [NativeTypeName("#define D3D12_MAX_MULTISAMPLE_SAMPLE_COUNT ( 32 )")]
    public const int MaxMultisampleSampleCount = (32);

    [NativeTypeName("#define D3D12_MAX_POSITION_VALUE ( 3.402823466e+34f )")]
    public const float MaxPositionValue = (3.402823466e+34f);

    [NativeTypeName("#define D3D12_MAX_ROOT_COST ( 64 )")]
    public const int MaxRootCost = (64);

    [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_1 ( 1000000 )")]
    public const int MaxShaderVisibleDescriptorHeapSizeTier1 = (1000000);

    [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_DESCRIPTOR_HEAP_SIZE_TIER_2 ( 1000000 )")]
    public const int MaxShaderVisibleDescriptorHeapSizeTier2 = (1000000);

    [NativeTypeName("#define D3D12_MAX_SHADER_VISIBLE_SAMPLER_HEAP_SIZE ( 2048 )")]
    public const int MaxShaderVisibleSamplerHeapSize = (2048);

    [NativeTypeName("#define D3D12_MAX_TEXTURE_DIMENSION_2_TO_EXP ( 17 )")]
    public const int MaxTextureDimension2ToExp = (17);

    [NativeTypeName("#define D3D12_MAX_VIEW_INSTANCE_COUNT ( 4 )")]
    public const int MaxViewInstanceCount = (4);

    [NativeTypeName("#define D3D12_MINOR_VERSION ( 0 )")]
    public const int MinorVersion = (0);

    [NativeTypeName("#define D3D12_MIN_BORDER_COLOR_COMPONENT ( 0.0f )")]
    public const float MinBorderColorComponent = (0.0f);

    [NativeTypeName("#define D3D12_MIN_DEPTH ( 0.0f )")]
    public const float MinDepth = (0.0f);

    [NativeTypeName("#define D3D12_MIN_MAXANISOTROPY ( 0 )")]
    public const int MinMaxanisotropy = (0);

    [NativeTypeName("#define D3D12_MIP_LOD_BIAS_MAX ( 15.99f )")]
    public const float MipLodBiasMax = (15.99f);

    [NativeTypeName("#define D3D12_MIP_LOD_BIAS_MIN ( -16.0f )")]
    public const float MipLodBiasMin = (-16.0f);

    [NativeTypeName("#define D3D12_MIP_LOD_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int MipLodFractionalBitCount = (8);

    [NativeTypeName("#define D3D12_MIP_LOD_RANGE_BIT_COUNT ( 8 )")]
    public const int MipLodRangeBitCount = (8);

    [NativeTypeName("#define D3D12_MULTISAMPLE_ANTIALIAS_LINE_WIDTH ( 1.4f )")]
    public const float MultisampleAntialiasLineWidth = (1.4f);

    [NativeTypeName("#define D3D12_NONSAMPLE_FETCH_OUT_OF_RANGE_ACCESS_RESULT ( 0 )")]
    public const int NonsampleFetchOutOfRangeAccessResult = (0);

    [NativeTypeName("#define D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_END ( 0xffffffff )")]
    public const uint OsReservedRegisterSpaceValuesEnd = (0xffffffff);

    [NativeTypeName("#define D3D12_OS_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff8 )")]
    public const uint OsReservedRegisterSpaceValuesStart = (0xfffffff8);

    [NativeTypeName("#define D3D12_PACKED_TILE ( 0xffffffff )")]
    public const uint PackedTile = (0xffffffff);

    [NativeTypeName("#define D3D12_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 15 )")]
    public const int PixelAddressRangeBitCount = (15);

    [NativeTypeName("#define D3D12_PREVIEW_SDK_VERSION ( 714 )")]
    public const int PreviewSdkVersion = (714);

    [NativeTypeName("#define D3D12_PRE_SCISSOR_PIXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int PreScissorPixelAddressRangeBitCount = (16);

    [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_COMPONENTS ( 1 )")]
    public const int PsCsUavRegisterComponents = (1);

    [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_COUNT ( 8 )")]
    public const int PsCsUavRegisterCount = (8);

    [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_READS_PER_INST ( 1 )")]
    public const int PsCsUavRegisterReadsPerInst = (1);

    [NativeTypeName("#define D3D12_PS_CS_UAV_REGISTER_READ_PORTS ( 1 )")]
    public const int PsCsUavRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_PS_FRONTFACING_DEFAULT_VALUE ( 0xffffffff )")]
    public const uint PsFrontfacingDefaultValue = (0xffffffff);

    [NativeTypeName("#define D3D12_PS_FRONTFACING_FALSE_VALUE ( 0 )")]
    public const int PsFrontfacingFalseValue = (0);

    [NativeTypeName("#define D3D12_PS_FRONTFACING_TRUE_VALUE ( 0xffffffff )")]
    public const uint PsFrontfacingTrueValue = (0xffffffff);

    [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int PsInputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int PsInputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int PsInputRegisterCount = (32);

    [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int PsInputRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_PS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int PsInputRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_PS_LEGACY_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.0f )")]
    public const float PsLegacyPixelCenterFractionalComponent = (0.0f);

    [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENTS ( 1 )")]
    public const int PsOutputDepthRegisterComponents = (1);

    [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int PsOutputDepthRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_PS_OUTPUT_DEPTH_REGISTER_COUNT ( 1 )")]
    public const int PsOutputDepthRegisterCount = (1);

    [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENTS ( 1 )")]
    public const int PsOutputMaskRegisterComponents = (1);

    [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int PsOutputMaskRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_PS_OUTPUT_MASK_REGISTER_COUNT ( 1 )")]
    public const int PsOutputMaskRegisterCount = (1);

    [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int PsOutputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int PsOutputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_PS_OUTPUT_REGISTER_COUNT ( 8 )")]
    public const int PsOutputRegisterCount = (8);

    [NativeTypeName("#define D3D12_PS_PIXEL_CENTER_FRACTIONAL_COMPONENT ( 0.5f )")]
    public const float PsPixelCenterFractionalComponent = (0.5f);

    [NativeTypeName("#define D3D12_RAW_UAV_SRV_BYTE_ALIGNMENT ( 16 )")]
    public const int RawUavSrvByteAlignment = (16);

    [NativeTypeName("#define D3D12_RAYTRACING_AABB_BYTE_ALIGNMENT ( 8 )")]
    public const int RaytracingAabbByteAlignment = (8);

    [NativeTypeName("#define D3D12_RAYTRACING_ACCELERATION_STRUCTURE_BYTE_ALIGNMENT ( 256 )")]
    public const int RaytracingAccelerationStructureByteAlignment = (256);

    [NativeTypeName("#define D3D12_RAYTRACING_INSTANCE_DESCS_BYTE_ALIGNMENT ( 16 )")]
    public const int RaytracingInstanceDescsByteAlignment = (16);

    [NativeTypeName("#define D3D12_RAYTRACING_MAX_ATTRIBUTE_SIZE_IN_BYTES ( 32 )")]
    public const int RaytracingMaxAttributeSizeInBytes = (32);

    [NativeTypeName("#define D3D12_RAYTRACING_MAX_DECLARABLE_TRACE_RECURSION_DEPTH ( 31 )")]
    public const int RaytracingMaxDeclarableTraceRecursionDepth = (31);

    [NativeTypeName(
        "#define D3D12_RAYTRACING_MAX_GEOMETRIES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE ( 16777216 )"
    )]
    public const int RaytracingMaxGeometriesPerBottomLevelAccelerationStructure = (16777216);

    [NativeTypeName(
        "#define D3D12_RAYTRACING_MAX_INSTANCES_PER_TOP_LEVEL_ACCELERATION_STRUCTURE ( 16777216 )"
    )]
    public const int RaytracingMaxInstancesPerTopLevelAccelerationStructure = (16777216);

    [NativeTypeName(
        "#define D3D12_RAYTRACING_MAX_PRIMITIVES_PER_BOTTOM_LEVEL_ACCELERATION_STRUCTURE ( 536870912 )"
    )]
    public const int RaytracingMaxPrimitivesPerBottomLevelAccelerationStructure = (536870912);

    [NativeTypeName("#define D3D12_RAYTRACING_MAX_RAY_GENERATION_SHADER_THREADS ( 1073741824 )")]
    public const int RaytracingMaxRayGenerationShaderThreads = (1073741824);

    [NativeTypeName("#define D3D12_RAYTRACING_MAX_SHADER_RECORD_STRIDE ( 4096 )")]
    public const int RaytracingMaxShaderRecordStride = (4096);

    [NativeTypeName("#define D3D12_RAYTRACING_SHADER_RECORD_BYTE_ALIGNMENT ( 32 )")]
    public const int RaytracingShaderRecordByteAlignment = (32);

    [NativeTypeName("#define D3D12_RAYTRACING_SHADER_TABLE_BYTE_ALIGNMENT ( 64 )")]
    public const int RaytracingShaderTableByteAlignment = (64);

    [NativeTypeName("#define D3D12_RAYTRACING_TRANSFORM3X4_BYTE_ALIGNMENT ( 16 )")]
    public const int RaytracingTransform3X4ByteAlignment = (16);

    [NativeTypeName("#define D3D12_REQ_BLEND_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int ReqBlendObjectCountPerDevice = (4096);

    [NativeTypeName("#define D3D12_REQ_BUFFER_RESOURCE_TEXEL_COUNT_2_TO_EXP ( 27 )")]
    public const int ReqBufferResourceTexelCount2ToExp = (27);

    [NativeTypeName("#define D3D12_REQ_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int ReqConstantBufferElementCount = (4096);

    [NativeTypeName("#define D3D12_REQ_DEPTH_STENCIL_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int ReqDepthStencilObjectCountPerDevice = (4096);

    [NativeTypeName("#define D3D12_REQ_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 32 )")]
    public const int ReqDrawindexedIndexCount2ToExp = (32);

    [NativeTypeName("#define D3D12_REQ_DRAW_VERTEX_COUNT_2_TO_EXP ( 32 )")]
    public const int ReqDrawVertexCount2ToExp = (32);

    [NativeTypeName("#define D3D12_REQ_FILTERING_HW_ADDRESSABLE_RESOURCE_DIMENSION ( 16384 )")]
    public const int ReqFilteringHwAddressableResourceDimension = (16384);

    [NativeTypeName("#define D3D12_REQ_GS_INVOCATION_32BIT_OUTPUT_COMPONENT_LIMIT ( 1024 )")]
    public const int ReqGsInvocation32BitOutputComponentLimit = (1024);

    [NativeTypeName("#define D3D12_REQ_IMMEDIATE_CONSTANT_BUFFER_ELEMENT_COUNT ( 4096 )")]
    public const int ReqImmediateConstantBufferElementCount = (4096);

    [NativeTypeName("#define D3D12_REQ_MAXANISOTROPY ( 16 )")]
    public const int ReqMaxanisotropy = (16);

    [NativeTypeName("#define D3D12_REQ_MIP_LEVELS ( 15 )")]
    public const int ReqMipLevels = (15);

    [NativeTypeName("#define D3D12_REQ_MULTI_ELEMENT_STRUCTURE_SIZE_IN_BYTES ( 2048 )")]
    public const int ReqMultiElementStructureSizeInBytes = (2048);

    [NativeTypeName("#define D3D12_REQ_RASTERIZER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int ReqRasterizerObjectCountPerDevice = (4096);

    [NativeTypeName("#define D3D12_REQ_RENDER_TO_BUFFER_WINDOW_WIDTH ( 16384 )")]
    public const int ReqRenderToBufferWindowWidth = (16384);

    [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_A_TERM ( 128 )")]
    public const int ReqResourceSizeInMegabytesExpressionATerm = (128);

    [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_B_TERM ( 0.25f )")]
    public const float ReqResourceSizeInMegabytesExpressionBTerm = (0.25f);

    [NativeTypeName("#define D3D12_REQ_RESOURCE_SIZE_IN_MEGABYTES_EXPRESSION_C_TERM ( 2048 )")]
    public const int ReqResourceSizeInMegabytesExpressionCTerm = (2048);

    [NativeTypeName("#define D3D12_REQ_RESOURCE_VIEW_COUNT_PER_DEVICE_2_TO_EXP ( 20 )")]
    public const int ReqResourceViewCountPerDevice2ToExp = (20);

    [NativeTypeName("#define D3D12_REQ_SAMPLER_OBJECT_COUNT_PER_DEVICE ( 4096 )")]
    public const int ReqSamplerObjectCountPerDevice = (4096);

    [NativeTypeName("#define D3D12_REQ_SUBRESOURCES ( 30720 )")]
    public const int ReqSubresources = (30720);

    [NativeTypeName("#define D3D12_REQ_TEXTURE1D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int ReqTexture1DArrayAxisDimension = (2048);

    [NativeTypeName("#define D3D12_REQ_TEXTURE1D_U_DIMENSION ( 16384 )")]
    public const int ReqTexture1DUDimension = (16384);

    [NativeTypeName("#define D3D12_REQ_TEXTURE2D_ARRAY_AXIS_DIMENSION ( 2048 )")]
    public const int ReqTexture2DArrayAxisDimension = (2048);

    [NativeTypeName("#define D3D12_REQ_TEXTURE2D_U_OR_V_DIMENSION ( 16384 )")]
    public const int ReqTexture2DUOrVDimension = (16384);

    [NativeTypeName("#define D3D12_REQ_TEXTURE3D_U_V_OR_W_DIMENSION ( 2048 )")]
    public const int ReqTexture3DUVOrWDimension = (2048);

    [NativeTypeName("#define D3D12_REQ_TEXTURECUBE_DIMENSION ( 16384 )")]
    public const int ReqTexturecubeDimension = (16384);

    [NativeTypeName("#define D3D12_RESINFO_INSTRUCTION_MISSING_COMPONENT_RETVAL ( 0 )")]
    public const int ResinfoInstructionMissingComponentRetval = (0);

    [NativeTypeName("#define D3D12_RESOURCE_BARRIER_ALL_SUBRESOURCES ( 0xffffffff )")]
    public const uint ResourceBarrierAllSubresources = (0xffffffff);

    [NativeTypeName("#define D3D12_RS_SET_SHADING_RATE_COMBINER_COUNT ( 2 )")]
    public const int RsSetShadingRateCombinerCount = (2);

    [NativeTypeName("#define D3D12_SDK_VERSION ( 614 )")]
    public const int SdkVersion = (614);

    [NativeTypeName("#define D3D12_SHADER_IDENTIFIER_SIZE_IN_BYTES ( 32 )")]
    public const int ShaderIdentifierSizeInBytes = (32);

    [NativeTypeName("#define D3D12_SHADER_MAJOR_VERSION ( 5 )")]
    public const int ShaderMajorVersion = (5);

    [NativeTypeName("#define D3D12_SHADER_MAX_INSTANCES ( 65535 )")]
    public const int ShaderMaxInstances = (65535);

    [NativeTypeName("#define D3D12_SHADER_MAX_INTERFACES ( 253 )")]
    public const int ShaderMaxInterfaces = (253);

    [NativeTypeName("#define D3D12_SHADER_MAX_INTERFACE_CALL_SITES ( 4096 )")]
    public const int ShaderMaxInterfaceCallSites = (4096);

    [NativeTypeName("#define D3D12_SHADER_MAX_TYPES ( 65535 )")]
    public const int ShaderMaxTypes = (65535);

    [NativeTypeName("#define D3D12_SHADER_MINOR_VERSION ( 1 )")]
    public const int ShaderMinorVersion = (1);

    [NativeTypeName("#define D3D12_SHIFT_INSTRUCTION_PAD_VALUE ( 0 )")]
    public const int ShiftInstructionPadValue = (0);

    [NativeTypeName("#define D3D12_SHIFT_INSTRUCTION_SHIFT_VALUE_BIT_COUNT ( 5 )")]
    public const int ShiftInstructionShiftValueBitCount = (5);

    [NativeTypeName("#define D3D12_SIMULTANEOUS_RENDER_TARGET_COUNT ( 8 )")]
    public const int SimultaneousRenderTargetCount = (8);

    [NativeTypeName("#define D3D12_SMALL_MSAA_RESOURCE_PLACEMENT_ALIGNMENT ( 65536 )")]
    public const int SmallMsaaResourcePlacementAlignment = (65536);

    [NativeTypeName("#define D3D12_SMALL_RESOURCE_PLACEMENT_ALIGNMENT ( 4096 )")]
    public const int SmallResourcePlacementAlignment = (4096);

    [NativeTypeName("#define D3D12_SO_BUFFER_MAX_STRIDE_IN_BYTES ( 2048 )")]
    public const int SoBufferMaxStrideInBytes = (2048);

    [NativeTypeName("#define D3D12_SO_BUFFER_MAX_WRITE_WINDOW_IN_BYTES ( 512 )")]
    public const int SoBufferMaxWriteWindowInBytes = (512);

    [NativeTypeName("#define D3D12_SO_BUFFER_SLOT_COUNT ( 4 )")]
    public const int SoBufferSlotCount = (4);

    [NativeTypeName("#define D3D12_SO_DDI_REGISTER_INDEX_DENOTING_GAP ( 0xffffffff )")]
    public const uint SoDdiRegisterIndexDenotingGap = (0xffffffff);

    [NativeTypeName("#define D3D12_SO_NO_RASTERIZED_STREAM ( 0xffffffff )")]
    public const uint SoNoRasterizedStream = (0xffffffff);

    [NativeTypeName("#define D3D12_SO_OUTPUT_COMPONENT_COUNT ( 128 )")]
    public const int SoOutputComponentCount = (128);

    [NativeTypeName("#define D3D12_SO_STREAM_COUNT ( 4 )")]
    public const int SoStreamCount = (4);

    [NativeTypeName("#define D3D12_SPEC_DATE_DAY ( 14 )")]
    public const int SpecDateDay = (14);

    [NativeTypeName("#define D3D12_SPEC_DATE_MONTH ( 11 )")]
    public const int SpecDateMonth = (11);

    [NativeTypeName("#define D3D12_SPEC_DATE_YEAR ( 2014 )")]
    public const int SpecDateYear = (2014);

    [NativeTypeName("#define D3D12_SPEC_VERSION ( 1.16 )")]
    public const double SpecVersion = (1.16);

    [NativeTypeName("#define D3D12_SRGB_GAMMA ( 2.2f )")]
    public const float SrgbGamma = (2.2f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_DENOMINATOR_1 ( 12.92f )")]
    public const float SrgbToFloatDenominator1 = (12.92f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_DENOMINATOR_2 ( 1.055f )")]
    public const float SrgbToFloatDenominator2 = (1.055f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_EXPONENT ( 2.4f )")]
    public const float SrgbToFloatExponent = (2.4f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_OFFSET ( 0.055f )")]
    public const float SrgbToFloatOffset = (0.055f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_THRESHOLD ( 0.04045f )")]
    public const float SrgbToFloatThreshold = (0.04045f);

    [NativeTypeName("#define D3D12_SRGB_TO_FLOAT_TOLERANCE_IN_ULP ( 0.5f )")]
    public const float SrgbToFloatToleranceInUlp = (0.5f);

    [NativeTypeName("#define D3D12_STANDARD_COMPONENT_BIT_COUNT ( 32 )")]
    public const int StandardComponentBitCount = (32);

    [NativeTypeName("#define D3D12_STANDARD_COMPONENT_BIT_COUNT_DOUBLED ( 64 )")]
    public const int StandardComponentBitCountDoubled = (64);

    [NativeTypeName("#define D3D12_STANDARD_MAXIMUM_ELEMENT_ALIGNMENT_BYTE_MULTIPLE ( 4 )")]
    public const int StandardMaximumElementAlignmentByteMultiple = (4);

    [NativeTypeName("#define D3D12_STANDARD_PIXEL_COMPONENT_COUNT ( 128 )")]
    public const int StandardPixelComponentCount = (128);

    [NativeTypeName("#define D3D12_STANDARD_PIXEL_ELEMENT_COUNT ( 32 )")]
    public const int StandardPixelElementCount = (32);

    [NativeTypeName("#define D3D12_STANDARD_VECTOR_SIZE ( 4 )")]
    public const int StandardVectorSize = (4);

    [NativeTypeName("#define D3D12_STANDARD_VERTEX_ELEMENT_COUNT ( 32 )")]
    public const int StandardVertexElementCount = (32);

    [NativeTypeName("#define D3D12_STANDARD_VERTEX_TOTAL_COMPONENT_COUNT ( 64 )")]
    public const int StandardVertexTotalComponentCount = (64);

    [NativeTypeName("#define D3D12_SUBPIXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int SubpixelFractionalBitCount = (8);

    [NativeTypeName("#define D3D12_SUBTEXEL_FRACTIONAL_BIT_COUNT ( 8 )")]
    public const int SubtexelFractionalBitCount = (8);

    [NativeTypeName("#define D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_END ( 0xffffffff )")]
    public const uint SystemReservedRegisterSpaceValuesEnd = (0xffffffff);

    [NativeTypeName("#define D3D12_SYSTEM_RESERVED_REGISTER_SPACE_VALUES_START ( 0xfffffff0 )")]
    public const uint SystemReservedRegisterSpaceValuesStart = (0xfffffff0);

    [NativeTypeName("#define D3D12_TESSELLATOR_MAX_EVEN_TESSELLATION_FACTOR ( 64 )")]
    public const int TessellatorMaxEvenTessellationFactor = (64);

    [NativeTypeName("#define D3D12_TESSELLATOR_MAX_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 64 )")]
    public const int TessellatorMaxIsolineDensityTessellationFactor = (64);

    [NativeTypeName("#define D3D12_TESSELLATOR_MAX_ODD_TESSELLATION_FACTOR ( 63 )")]
    public const int TessellatorMaxOddTessellationFactor = (63);

    [NativeTypeName("#define D3D12_TESSELLATOR_MAX_TESSELLATION_FACTOR ( 64 )")]
    public const int TessellatorMaxTessellationFactor = (64);

    [NativeTypeName("#define D3D12_TESSELLATOR_MIN_EVEN_TESSELLATION_FACTOR ( 2 )")]
    public const int TessellatorMinEvenTessellationFactor = (2);

    [NativeTypeName("#define D3D12_TESSELLATOR_MIN_ISOLINE_DENSITY_TESSELLATION_FACTOR ( 1 )")]
    public const int TessellatorMinIsolineDensityTessellationFactor = (1);

    [NativeTypeName("#define D3D12_TESSELLATOR_MIN_ODD_TESSELLATION_FACTOR ( 1 )")]
    public const int TessellatorMinOddTessellationFactor = (1);

    [NativeTypeName("#define D3D12_TEXEL_ADDRESS_RANGE_BIT_COUNT ( 16 )")]
    public const int TexelAddressRangeBitCount = (16);

    [NativeTypeName("#define D3D12_TEXTURE_DATA_PITCH_ALIGNMENT ( 256 )")]
    public const int TextureDataPitchAlignment = (256);

    [NativeTypeName("#define D3D12_TEXTURE_DATA_PLACEMENT_ALIGNMENT ( 512 )")]
    public const int TextureDataPlacementAlignment = (512);

    [NativeTypeName("#define D3D12_TILED_RESOURCE_TILE_SIZE_IN_BYTES ( 65536 )")]
    public const int TiledResourceTileSizeInBytes = (65536);

    [NativeTypeName("#define D3D12_TRACKED_WORKLOAD_MAX_INSTANCES ( 32 )")]
    public const int TrackedWorkloadMaxInstances = (32);

    [NativeTypeName("#define D3D12_UAV_COUNTER_PLACEMENT_ALIGNMENT ( 4096 )")]
    public const int UavCounterPlacementAlignment = (4096);

    [NativeTypeName("#define D3D12_UAV_SLOT_COUNT ( 64 )")]
    public const int UavSlotCount = (64);

    [NativeTypeName("#define D3D12_UNBOUND_MEMORY_ACCESS_RESULT ( 0 )")]
    public const int UnboundMemoryAccessResult = (0);

    [NativeTypeName("#define D3D12_VIDEO_DECODE_MAX_ARGUMENTS ( 10 )")]
    public const int VideoDecodeMaxArguments = (10);

    [NativeTypeName("#define D3D12_VIDEO_DECODE_MAX_HISTOGRAM_COMPONENTS ( 4 )")]
    public const int VideoDecodeMaxHistogramComponents = (4);

    [NativeTypeName("#define D3D12_VIDEO_DECODE_MIN_BITSTREAM_OFFSET_ALIGNMENT ( 256 )")]
    public const int VideoDecodeMinBitstreamOffsetAlignment = (256);

    [NativeTypeName("#define D3D12_VIDEO_DECODE_MIN_HISTOGRAM_OFFSET_ALIGNMENT ( 256 )")]
    public const int VideoDecodeMinHistogramOffsetAlignment = (256);

    [NativeTypeName(
        "#define D3D12_VIDEO_DECODE_STATUS_MACROBLOCKS_AFFECTED_UNKNOWN ( 0xffffffff )"
    )]
    public const uint VideoDecodeStatusMacroblocksAffectedUnknown = (0xffffffff);

    [NativeTypeName("#define D3D12_VIDEO_ENCODER_AV1_INVALID_DPB_RESOURCE_INDEX ( 0xff )")]
    public const int VideoEncoderAv1InvalidDpbResourceIndex = (0xff);

    [NativeTypeName("#define D3D12_VIDEO_ENCODER_AV1_MAX_TILE_COLS ( 64 )")]
    public const int VideoEncoderAv1MaxTileCols = (64);

    [NativeTypeName("#define D3D12_VIDEO_ENCODER_AV1_MAX_TILE_ROWS ( 64 )")]
    public const int VideoEncoderAv1MaxTileRows = (64);

    [NativeTypeName("#define D3D12_VIDEO_ENCODER_AV1_SUPERRES_DENOM_MIN ( 9 )")]
    public const int VideoEncoderAv1SuperresDenomMin = (9);

    [NativeTypeName("#define D3D12_VIDEO_ENCODER_AV1_SUPERRES_NUM ( 8 )")]
    public const int VideoEncoderAv1SuperresNum = (8);

    [NativeTypeName("#define D3D12_VIDEO_PROCESS_MAX_FILTERS ( 32 )")]
    public const int VideoProcessMaxFilters = (32);

    [NativeTypeName("#define D3D12_VIDEO_PROCESS_STEREO_VIEWS ( 2 )")]
    public const int VideoProcessStereoViews = (2);

    [NativeTypeName("#define D3D12_VIEWPORT_AND_SCISSORRECT_MAX_INDEX ( 15 )")]
    public const int ViewportAndScissorrectMaxIndex = (15);

    [NativeTypeName("#define D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ( 16 )")]
    public const int ViewportAndScissorrectObjectCountPerPipeline = (16);

    [NativeTypeName("#define D3D12_VIEWPORT_BOUNDS_MAX ( 32767 )")]
    public const int ViewportBoundsMax = (32767);

    [NativeTypeName("#define D3D12_VIEWPORT_BOUNDS_MIN ( -32768 )")]
    public const int ViewportBoundsMin = (-32768);

    [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int VsInputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int VsInputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_COUNT ( 32 )")]
    public const int VsInputRegisterCount = (32);

    [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_READS_PER_INST ( 2 )")]
    public const int VsInputRegisterReadsPerInst = (2);

    [NativeTypeName("#define D3D12_VS_INPUT_REGISTER_READ_PORTS ( 1 )")]
    public const int VsInputRegisterReadPorts = (1);

    [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COMPONENTS ( 4 )")]
    public const int VsOutputRegisterComponents = (4);

    [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COMPONENT_BIT_COUNT ( 32 )")]
    public const int VsOutputRegisterComponentBitCount = (32);

    [NativeTypeName("#define D3D12_VS_OUTPUT_REGISTER_COUNT ( 32 )")]
    public const int VsOutputRegisterCount = (32);

    [NativeTypeName("#define D3D12_WHQL_CONTEXT_COUNT_FOR_RESOURCE_LIMIT ( 10 )")]
    public const int WhqlContextCountForResourceLimit = (10);

    [NativeTypeName("#define D3D12_WHQL_DRAWINDEXED_INDEX_COUNT_2_TO_EXP ( 25 )")]
    public const int WhqlDrawindexedIndexCount2ToExp = (25);

    [NativeTypeName("#define D3D12_WHQL_DRAW_VERTEX_COUNT_2_TO_EXP ( 25 )")]
    public const int WhqlDrawVertexCount2ToExp = (25);

    [NativeTypeName("#define D3D12_WORK_GRAPHS_BACKING_MEMORY_ALIGNMENT_IN_BYTES ( 8 )")]
    public const int WorkGraphsBackingMemoryAlignmentInBytes = (8);

    [NativeTypeName("#define D3D12_WORK_GRAPHS_MAX_NODE_DEPTH ( 32 )")]
    public const int WorkGraphsMaxNodeDepth = (32);

    [NativeTypeName("#define D3D12_SHADER_COMPONENT_MAPPING_MASK 0x7")]
    public const int ShaderComponentMappingMask = 0x7;

    [NativeTypeName("#define D3D12_SHADER_COMPONENT_MAPPING_SHIFT 3")]
    public const int ShaderComponentMappingShift = 3;

    [NativeTypeName(
        "#define D3D12_SHADER_COMPONENT_MAPPING_ALWAYS_SET_BIT_AVOIDING_ZEROMEM_MISTAKES (1<<(D3D12_SHADER_COMPONENT_MAPPING_SHIFT*4))"
    )]
    public const int ShaderComponentMappingAlwaysSetBitAvoidingZeromemMistakes = (1 << (3 * 4));

    [NativeTypeName(
        "#define D3D12_DEFAULT_SHADER_4_COMPONENT_MAPPING D3D12_ENCODE_SHADER_4_COMPONENT_MAPPING(0,1,2,3)"
    )]
    public const int DefaultShader4ComponentMapping = (
        (
            ((0) & 0x7)
            | (((1) & 0x7) << 3)
            | (((2) & 0x7) << (3 * 2))
            | (((3) & 0x7) << (3 * 3))
            | (1 << (3 * 4))
        )
    );

    [NativeTypeName("#define D3D12_FILTER_REDUCTION_TYPE_MASK ( 0x3 )")]
    public const int FilterReductionTypeMask = (0x3);

    [NativeTypeName("#define D3D12_FILTER_REDUCTION_TYPE_SHIFT ( 7 )")]
    public const int FilterReductionTypeShift = (7);

    [NativeTypeName("#define D3D12_FILTER_TYPE_MASK ( 0x3 )")]
    public const int FilterTypeMask = (0x3);

    [NativeTypeName("#define D3D12_MIN_FILTER_SHIFT ( 4 )")]
    public const int MinFilterShift = (4);

    [NativeTypeName("#define D3D12_MAG_FILTER_SHIFT ( 2 )")]
    public const int MagFilterShift = (2);

    [NativeTypeName("#define D3D12_MIP_FILTER_SHIFT ( 0 )")]
    public const int MipFilterShift = (0);

    [NativeTypeName("#define D3D12_ANISOTROPIC_FILTERING_BIT ( 0x40 )")]
    public const int AnisotropicFilteringBit = (0x40);

    [NativeTypeName("#define D3D12_SHADING_RATE_X_AXIS_SHIFT 2")]
    public const int ShadingRateXAxisShift = 2;

    [NativeTypeName("#define D3D12_SHADING_RATE_VALID_MASK 3")]
    public const int ShadingRateValidMask = 3;
}
