// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dx12_property_format_table.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Win32;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct D3D12PropertyLayoutFormatTable
{
    private const int INTSAFE_E_ARITHMETIC_OVERFLOW = unchecked((int)(0x80070216));
    private const D3DFormatComponentName R = D3DFormatComponentName.R;
    private const D3DFormatComponentName G = D3DFormatComponentName.G;
    private const D3DFormatComponentName B = D3DFormatComponentName.B;
    private const D3DFormatComponentName A = D3DFormatComponentName.A;
    private const D3DFormatComponentName D = D3DFormatComponentName.D;
    private const D3DFormatComponentName S = D3DFormatComponentName.S;
    private const D3DFormatComponentName X = D3DFormatComponentName.X;
    private const D3DFormatComponentInterpretation _TYPELESS =
        D3DFormatComponentInterpretation.Typeless;
    private const D3DFormatComponentInterpretation _FLOAT = D3DFormatComponentInterpretation.Float;
    private const D3DFormatComponentInterpretation _SNORM = D3DFormatComponentInterpretation.Snorm;
    private const D3DFormatComponentInterpretation _UNORM = D3DFormatComponentInterpretation.Unorm;
    private const D3DFormatComponentInterpretation _SINT = D3DFormatComponentInterpretation.Sint;
    private const D3DFormatComponentInterpretation _UINT = D3DFormatComponentInterpretation.Uint;
    private const D3DFormatComponentInterpretation _UNORM_SRGB =
        D3DFormatComponentInterpretation.UnormSrgb;
    private const D3DFormatComponentInterpretation _FIXED_2_8 =
        D3DFormatComponentInterpretation.BiasedFixed2X8;

    public partial struct FORMAT_DETAIL
    {
        public FORMAT_DETAIL(
            DxgiFormat DXGIFormat,
            DxgiFormat ParentFormat,
            ReadOnlySpan<DxgiFormat> DefaultFormatCastSet,
            ReadOnlySpan<byte> BitsPerComponent,
            byte BitsPerUnit,
            bool SRGBFormat,
            uint WidthAlignment,
            uint HeightAlignment,
            uint DepthAlignment,
            D3DFormatLayout Layout,
            D3DFormatTypeLevel TypeLevel,
            ReadOnlySpan<D3DFormatComponentName> ComponentNames,
            ReadOnlySpan<D3DFormatComponentInterpretation> ComponentInterpretations,
            bool bDX9VertexOrIndexFormat,
            bool bDX9TextureFormat,
            bool bFloatNormFormat,
            bool bPlanar,
            bool bYUV,
            bool bDependentFormatCastSet,
            bool bInternal
        )
        {
            Debug.Assert(BitsPerComponent.Length == 4);
            Debug.Assert(ComponentNames.Length == 4);
            Debug.Assert(ComponentInterpretations.Length == 4);
            this.DXGIFormat = DXGIFormat;
            this.ParentFormat = ParentFormat;
            pDefaultFormatCastSet = (DxgiFormat*)(
                Unsafe.AsPointer(ref MemoryMarshal.GetReference(DefaultFormatCastSet))
            );
            this.BitsPerComponent[0] = BitsPerComponent[0];
            this.BitsPerComponent[1] = BitsPerComponent[1];
            this.BitsPerComponent[2] = BitsPerComponent[2];
            this.BitsPerComponent[3] = BitsPerComponent[3];
            this.BitsPerUnit = BitsPerUnit;
            this.SRGBFormat = SRGBFormat;
            this.WidthAlignment = WidthAlignment;
            this.HeightAlignment = HeightAlignment;
            this.DepthAlignment = DepthAlignment;
            this.Layout = Layout;
            this.TypeLevel = TypeLevel;
            ComponentName0 = ComponentNames[0];
            ComponentName1 = ComponentNames[1];
            ComponentName2 = ComponentNames[2];
            ComponentName3 = ComponentNames[3];
            ComponentInterpretation0 = ComponentInterpretations[0];
            ComponentInterpretation1 = ComponentInterpretations[1];
            ComponentInterpretation2 = ComponentInterpretations[2];
            ComponentInterpretation3 = ComponentInterpretations[3];
            this.bDX9VertexOrIndexFormat = bDX9VertexOrIndexFormat;
            this.bDX9TextureFormat = bDX9TextureFormat;
            this.bFloatNormFormat = bFloatNormFormat;
            this.bPlanar = bPlanar;
            this.bYUV = bYUV;
            this.bDependentFormatCastSet = bDependentFormatCastSet;
            this.bInternal = bInternal;
        }

        public DxgiFormat DXGIFormat;
        public DxgiFormat ParentFormat;

        [NativeTypeName("const DXGI_FORMAT *")]
        public DxgiFormat* pDefaultFormatCastSet;

        [NativeTypeName("UINT8[4]")]
        public _BitsPerComponent_e__FixedBuffer BitsPerComponent;

        [NativeTypeName("UINT8")]
        public byte BitsPerUnit;
        public byte _bitfield1;

        [NativeTypeName("byte : 1")]
        public bool SRGBFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield1 & 0x1u) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield1 = (byte)((_bitfield1 & ~0x1u) | (value ? 1u : 0u)); }
        }
        public uint _bitfield2;

        [NativeTypeName("uint : 4")]
        public uint WidthAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield2 & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~0xFu) | (value & 0xFu); }
        }

        [NativeTypeName("uint : 4")]
        public uint HeightAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield2 >> 4) & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4); }
        }

        [NativeTypeName("uint : 1")]
        public uint DepthAlignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield2 >> 8) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x1u << 8)) | ((value & 0x1u) << 8); }
        }

        [NativeTypeName("D3D_FORMAT_LAYOUT : 1")]
        public D3DFormatLayout Layout
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatLayout)((_bitfield2 << 22) >> 31); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x1u << 9)) | (((uint)(value) & 0x1) << 9); }
        }

        [NativeTypeName("D3D_FORMAT_TYPE_LEVEL : 2")]
        public D3DFormatTypeLevel TypeLevel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatTypeLevel)((_bitfield2 << 20) >> 30); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x3u << 10)) | (((uint)(value) & 0x3) << 10); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3DFormatComponentName ComponentName0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentName)((_bitfield2 << 17) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 12)) | (((uint)(value) & 0x7) << 12); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3DFormatComponentName ComponentName1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentName)((_bitfield2 << 14) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 15)) | (((uint)(value) & 0x7) << 15); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3DFormatComponentName ComponentName2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentName)((_bitfield2 << 11) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 18)) | (((uint)(value) & 0x7) << 18); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_NAME : 3")]
        public D3DFormatComponentName ComponentName3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentName)((_bitfield2 << 8) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 21)) | (((uint)(value) & 0x7) << 21); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3DFormatComponentInterpretation ComponentInterpretation0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentInterpretation)((_bitfield2 << 5) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 24)) | (((uint)(value) & 0x7) << 24); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3DFormatComponentInterpretation ComponentInterpretation1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentInterpretation)((_bitfield2 << 2) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield2 = (_bitfield2 & ~(0x7u << 27)) | (((uint)(value) & 0x7) << 27); }
        }
        public int _bitfield3;

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3DFormatComponentInterpretation ComponentInterpretation2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentInterpretation)((_bitfield3 << 29) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield3 = (_bitfield3 & ~0x7) | ((int)(value) & 0x7); }
        }

        [NativeTypeName("D3D_FORMAT_COMPONENT_INTERPRETATION : 3")]
        public D3DFormatComponentInterpretation ComponentInterpretation3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (D3DFormatComponentInterpretation)((_bitfield3 << 26) >> 29); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield3 = (_bitfield3 & ~(0x7 << 3)) | (((int)(value) & 0x7) << 3); }
        }
        public byte _bitfield4;

        [NativeTypeName("bool : 1")]
        public bool bDX9VertexOrIndexFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield4 & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~0x1) | (value ? 1 : 0)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bDX9TextureFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 1) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 1)) | ((value ? 1 : 0) << 1)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bFloatNormFormat
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 2) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 2)) | ((value ? 1 : 0) << 2)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bPlanar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 3) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 3)) | ((value ? 1 : 0) << 3)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 4) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 4)) | ((value ? 1 : 0) << 4)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bDependentFormatCastSet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 5) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 5)) | ((value ? 1 : 0) << 5)); }
        }

        [NativeTypeName("bool : 1")]
        public bool bInternal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return ((_bitfield4 >> 6) & 0x1) != 0; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield4 = (byte)((_bitfield4 & ~(0x1 << 6)) | ((value ? 1 : 0) << 6)); }
        }

        [InlineArray(4)]
        public partial struct _BitsPerComponent_e__FixedBuffer
        {
            public byte e0;
        }
    }

    private static ReadOnlySpan<DxgiFormat> D3DFCS_UNKNOWN => [DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R32G32B32A32 =>
        [
            DxgiFormat.FormatR32G32B32A32Typeless,
            DxgiFormat.FormatR32G32B32A32Float,
            DxgiFormat.FormatR32G32B32A32Uint,
            DxgiFormat.FormatR32G32B32A32Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R32G32B32 =>
        [
            DxgiFormat.FormatR32G32B32Typeless,
            DxgiFormat.FormatR32G32B32Float,
            DxgiFormat.FormatR32G32B32Uint,
            DxgiFormat.FormatR32G32B32Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R16G16B16A16 =>
        [
            DxgiFormat.FormatR16G16B16A16Typeless,
            DxgiFormat.FormatR16G16B16A16Float,
            DxgiFormat.FormatR16G16B16A16Unorm,
            DxgiFormat.FormatR16G16B16A16Uint,
            DxgiFormat.FormatR16G16B16A16Snorm,
            DxgiFormat.FormatR16G16B16A16Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R32G32 =>
        [
            DxgiFormat.FormatR32G32Typeless,
            DxgiFormat.FormatR32G32Float,
            DxgiFormat.FormatR32G32Uint,
            DxgiFormat.FormatR32G32Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R32G8X24 =>
        [
            DxgiFormat.FormatR32G8X24Typeless,
            DxgiFormat.FormatD32FloatS8X24Uint,
            DxgiFormat.FormatR32FloatX8X24Typeless,
            DxgiFormat.FormatX32TypelessG8X24Uint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R11G11B10 =>
        [DxgiFormat.FormatR11G11B10Float, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R8G8B8A8 =>
        [
            DxgiFormat.FormatR8G8B8A8Typeless,
            DxgiFormat.FormatR8G8B8A8Unorm,
            DxgiFormat.FormatR8G8B8A8UnormSrgb,
            DxgiFormat.FormatR8G8B8A8Uint,
            DxgiFormat.FormatR8G8B8A8Snorm,
            DxgiFormat.FormatR8G8B8A8Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R16G16 =>
        [
            DxgiFormat.FormatR16G16Typeless,
            DxgiFormat.FormatR16G16Float,
            DxgiFormat.FormatR16G16Unorm,
            DxgiFormat.FormatR16G16Uint,
            DxgiFormat.FormatR16G16Snorm,
            DxgiFormat.FormatR16G16Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R32 =>
        [
            DxgiFormat.FormatR32Typeless,
            DxgiFormat.FormatD32Float,
            DxgiFormat.FormatR32Float,
            DxgiFormat.FormatR32Uint,
            DxgiFormat.FormatR32Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R24G8 =>
        [
            DxgiFormat.FormatR24G8Typeless,
            DxgiFormat.FormatD24UnormS8Uint,
            DxgiFormat.FormatR24UnormX8Typeless,
            DxgiFormat.FormatX24TypelessG8Uint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R8G8 =>
        [
            DxgiFormat.FormatR8G8Typeless,
            DxgiFormat.FormatR8G8Unorm,
            DxgiFormat.FormatR8G8Uint,
            DxgiFormat.FormatR8G8Snorm,
            DxgiFormat.FormatR8G8Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R16 =>
        [
            DxgiFormat.FormatR16Typeless,
            DxgiFormat.FormatR16Float,
            DxgiFormat.FormatD16Unorm,
            DxgiFormat.FormatR16Unorm,
            DxgiFormat.FormatR16Uint,
            DxgiFormat.FormatR16Snorm,
            DxgiFormat.FormatR16Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R8 =>
        [
            DxgiFormat.FormatR8Typeless,
            DxgiFormat.FormatR8Unorm,
            DxgiFormat.FormatR8Uint,
            DxgiFormat.FormatR8Snorm,
            DxgiFormat.FormatR8Sint,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_A8 =>
        [DxgiFormat.FormatA8Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R1 =>
        [DxgiFormat.FormatR1Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R9G9B9E5 =>
        [DxgiFormat.FormatR9G9B9E5Sharedexp, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R8G8_B8G8 =>
        [DxgiFormat.FormatR8G8B8G8Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_G8R8_G8B8 =>
        [DxgiFormat.FormatG8R8G8B8Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC1 =>
        [
            DxgiFormat.FormatBc1Typeless,
            DxgiFormat.FormatBc1Unorm,
            DxgiFormat.FormatBc1UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC2 =>
        [
            DxgiFormat.FormatBc2Typeless,
            DxgiFormat.FormatBc2Unorm,
            DxgiFormat.FormatBc2UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC3 =>
        [
            DxgiFormat.FormatBc3Typeless,
            DxgiFormat.FormatBc3Unorm,
            DxgiFormat.FormatBc3UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC4 =>
        [
            DxgiFormat.FormatBc4Typeless,
            DxgiFormat.FormatBc4Unorm,
            DxgiFormat.FormatBc4Snorm,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC5 =>
        [
            DxgiFormat.FormatBc5Typeless,
            DxgiFormat.FormatBc5Unorm,
            DxgiFormat.FormatBc5Snorm,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_B5G6R5 =>
        [DxgiFormat.FormatB5G6R5Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_B5G5R5A1 =>
        [DxgiFormat.FormatB5G5R5A1Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_B8G8R8A8 =>
        [
            DxgiFormat.FormatB8G8R8A8Typeless,
            DxgiFormat.FormatB8G8R8A8Unorm,
            DxgiFormat.FormatB8G8R8A8UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_B8G8R8X8 =>
        [
            DxgiFormat.FormatB8G8R8X8Typeless,
            DxgiFormat.FormatB8G8R8X8Unorm,
            DxgiFormat.FormatB8G8R8X8UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_R10G10B10A2 =>
        [
            DxgiFormat.FormatR10G10B10A2Typeless,
            DxgiFormat.FormatR10G10B10A2Unorm,
            DxgiFormat.FormatR10G10B10A2Uint,
            DxgiFormat.FormatR10G10B10XrBiasA2Unorm,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC6H =>
        [
            DxgiFormat.FormatBc6HTypeless,
            DxgiFormat.FormatBc6HUf16,
            DxgiFormat.FormatBc6HSf16,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_BC7 =>
        [
            DxgiFormat.FormatBc7Typeless,
            DxgiFormat.FormatBc7Unorm,
            DxgiFormat.FormatBc7UnormSrgb,
            DxgiFormat.FormatUnknown,
        ];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_AYUV =>
        [DxgiFormat.FormatAyuv, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_NV12 =>
        [DxgiFormat.FormatNv12, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_YUY2 =>
        [DxgiFormat.FormatYuy2, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_P010 =>
        [DxgiFormat.FormatP010, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_P016 =>
        [DxgiFormat.FormatP016, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_NV11 =>
        [DxgiFormat.FormatNv11, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_420_OPAQUE =>
        [DxgiFormat.Format420Opaque, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_Y410 =>
        [DxgiFormat.FormatY410, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_Y416 =>
        [DxgiFormat.FormatY416, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_Y210 =>
        [DxgiFormat.FormatY210, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_Y216 =>
        [DxgiFormat.FormatY216, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_AI44 =>
        [DxgiFormat.FormatAi44, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_IA44 =>
        [DxgiFormat.FormatIa44, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_P8 =>
        [DxgiFormat.FormatP8, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_A8P8 =>
        [DxgiFormat.FormatA8P8, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_B4G4R4A4 =>
        [DxgiFormat.FormatB4G4R4A4Unorm, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_P208 =>
        [DxgiFormat.FormatP208, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_V208 =>
        [DxgiFormat.FormatV208, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_V408 =>
        [DxgiFormat.FormatV408, DxgiFormat.FormatUnknown];
    private static ReadOnlySpan<DxgiFormat> D3DFCS_A4B4G4R4 =>
        [DxgiFormat.FormatA4B4G4R4Unorm, DxgiFormat.FormatUnknown];
    private static readonly FORMAT_DETAIL[] s_FormatDetail =
    [
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatUnknown,
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32A32Typeless,
            ParentFormat: DxgiFormat.FormatR32G32B32A32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32A32Float,
            ParentFormat: DxgiFormat.FormatR32G32B32A32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32A32Uint,
            ParentFormat: DxgiFormat.FormatR32G32B32A32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32A32Sint,
            ParentFormat: DxgiFormat.FormatR32G32B32A32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32A32,
            BitsPerComponent: [32, 32, 32, 32],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32Typeless,
            ParentFormat: DxgiFormat.FormatR32G32B32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32Float,
            ParentFormat: DxgiFormat.FormatR32G32B32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32Uint,
            ParentFormat: DxgiFormat.FormatR32G32B32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32B32Sint,
            ParentFormat: DxgiFormat.FormatR32G32B32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32B32,
            BitsPerComponent: [32, 32, 32, 0],
            BitsPerUnit: 96,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Float,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Unorm,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Uint,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Snorm,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SNORM, _SNORM, _SNORM, _SNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16B16A16Sint,
            ParentFormat: DxgiFormat.FormatR16G16B16A16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16B16A16,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32Typeless,
            ParentFormat: DxgiFormat.FormatR32G32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32Float,
            ParentFormat: DxgiFormat.FormatR32G32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32Uint,
            ParentFormat: DxgiFormat.FormatR32G32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G32Sint,
            ParentFormat: DxgiFormat.FormatR32G32Typeless,
            DefaultFormatCastSet: D3DFCS_R32G32,
            BitsPerComponent: [32, 32, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32G8X24Typeless,
            ParentFormat: DxgiFormat.FormatR32G8X24Typeless,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatD32FloatS8X24Uint,
            ParentFormat: DxgiFormat.FormatR32G8X24Typeless,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [D, S, X, X],
            ComponentInterpretations: [_FLOAT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32FloatX8X24Typeless,
            ParentFormat: DxgiFormat.FormatR32G8X24Typeless,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatX32TypelessG8X24Uint,
            ParentFormat: DxgiFormat.FormatR32G8X24Typeless,
            DefaultFormatCastSet: D3DFCS_R32G8X24,
            BitsPerComponent: [32, 8, 24, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [X, G, X, X],
            ComponentInterpretations: [_TYPELESS, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR10G10B10A2Typeless,
            ParentFormat: DxgiFormat.FormatR10G10B10A2Typeless,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR10G10B10A2Unorm,
            ParentFormat: DxgiFormat.FormatR10G10B10A2Typeless,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR10G10B10A2Uint,
            ParentFormat: DxgiFormat.FormatR10G10B10A2Typeless,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: true,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR11G11B10Float,
            ParentFormat: DxgiFormat.FormatR11G11B10Float,
            DefaultFormatCastSet: D3DFCS_R11G11B10,
            BitsPerComponent: [11, 11, 10, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8Unorm,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8UnormSrgb,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8Uint,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UINT, _UINT, _UINT, _UINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8Snorm,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SNORM, _SNORM, _SNORM, _SNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8A8Sint,
            ParentFormat: DxgiFormat.FormatR8G8B8A8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8B8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_SINT, _SINT, _SINT, _SINT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Typeless,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Float,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Unorm,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Uint,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Snorm,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16G16Sint,
            ParentFormat: DxgiFormat.FormatR16G16Typeless,
            DefaultFormatCastSet: D3DFCS_R16G16,
            BitsPerComponent: [16, 16, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32Typeless,
            ParentFormat: DxgiFormat.FormatR32Typeless,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatD32Float,
            ParentFormat: DxgiFormat.FormatR32Typeless,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [D, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32Float,
            ParentFormat: DxgiFormat.FormatR32Typeless,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: true,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32Uint,
            ParentFormat: DxgiFormat.FormatR32Typeless,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR32Sint,
            ParentFormat: DxgiFormat.FormatR32Typeless,
            DefaultFormatCastSet: D3DFCS_R32,
            BitsPerComponent: [32, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR24G8Typeless,
            ParentFormat: DxgiFormat.FormatR24G8Typeless,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatD24UnormS8Uint,
            ParentFormat: DxgiFormat.FormatR24G8Typeless,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [D, S, X, X],
            ComponentInterpretations: [_UNORM, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR24UnormX8Typeless,
            ParentFormat: DxgiFormat.FormatR24G8Typeless,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatX24TypelessG8Uint,
            ParentFormat: DxgiFormat.FormatR24G8Typeless,
            DefaultFormatCastSet: D3DFCS_R24G8,
            BitsPerComponent: [24, 8, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [X, G, X, X],
            ComponentInterpretations: [_TYPELESS, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8Typeless,
            ParentFormat: DxgiFormat.FormatR8G8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8Unorm,
            ParentFormat: DxgiFormat.FormatR8G8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8Uint,
            ParentFormat: DxgiFormat.FormatR8G8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UINT, _UINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8Snorm,
            ParentFormat: DxgiFormat.FormatR8G8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8Sint,
            ParentFormat: DxgiFormat.FormatR8G8Typeless,
            DefaultFormatCastSet: D3DFCS_R8G8,
            BitsPerComponent: [8, 8, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SINT, _SINT, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Typeless,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Float,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_FLOAT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatD16Unorm,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [D, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Unorm,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Uint,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Snorm,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR16Sint,
            ParentFormat: DxgiFormat.FormatR16Typeless,
            DefaultFormatCastSet: D3DFCS_R16,
            BitsPerComponent: [16, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8Typeless,
            ParentFormat: DxgiFormat.FormatR8Typeless,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8Unorm,
            ParentFormat: DxgiFormat.FormatR8Typeless,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8Uint,
            ParentFormat: DxgiFormat.FormatR8Typeless,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8Snorm,
            ParentFormat: DxgiFormat.FormatR8Typeless,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8Sint,
            ParentFormat: DxgiFormat.FormatR8Typeless,
            DefaultFormatCastSet: D3DFCS_R8,
            BitsPerComponent: [8, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SINT, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatA8Unorm,
            ParentFormat: DxgiFormat.FormatA8Unorm,
            DefaultFormatCastSet: D3DFCS_A8,
            BitsPerComponent: [0, 0, 0, 8],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [X, X, X, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR1Unorm,
            ParentFormat: DxgiFormat.FormatR1Unorm,
            DefaultFormatCastSet: D3DFCS_R1,
            BitsPerComponent: [1, 0, 0, 0],
            BitsPerUnit: 1,
            SRGBFormat: false,
            WidthAlignment: 8,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR9G9B9E5Sharedexp,
            ParentFormat: DxgiFormat.FormatR9G9B9E5Sharedexp,
            DefaultFormatCastSet: D3DFCS_R9G9B9E5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _FLOAT],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR8G8B8G8Unorm,
            ParentFormat: DxgiFormat.FormatR8G8B8G8Unorm,
            DefaultFormatCastSet: D3DFCS_R8G8_B8G8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatG8R8G8B8Unorm,
            ParentFormat: DxgiFormat.FormatG8R8G8B8Unorm,
            DefaultFormatCastSet: D3DFCS_G8R8_G8B8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc1Typeless,
            ParentFormat: DxgiFormat.FormatBc1Typeless,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc1Unorm,
            ParentFormat: DxgiFormat.FormatBc1Typeless,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc1UnormSrgb,
            ParentFormat: DxgiFormat.FormatBc1Typeless,
            DefaultFormatCastSet: D3DFCS_BC1,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc2Typeless,
            ParentFormat: DxgiFormat.FormatBc2Typeless,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc2Unorm,
            ParentFormat: DxgiFormat.FormatBc2Typeless,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc2UnormSrgb,
            ParentFormat: DxgiFormat.FormatBc2Typeless,
            DefaultFormatCastSet: D3DFCS_BC2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc3Typeless,
            ParentFormat: DxgiFormat.FormatBc3Typeless,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc3Unorm,
            ParentFormat: DxgiFormat.FormatBc3Typeless,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc3UnormSrgb,
            ParentFormat: DxgiFormat.FormatBc3Typeless,
            DefaultFormatCastSet: D3DFCS_BC3,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc4Typeless,
            ParentFormat: DxgiFormat.FormatBc4Typeless,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc4Unorm,
            ParentFormat: DxgiFormat.FormatBc4Typeless,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc4Snorm,
            ParentFormat: DxgiFormat.FormatBc4Typeless,
            DefaultFormatCastSet: D3DFCS_BC4,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_SNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc5Typeless,
            ParentFormat: DxgiFormat.FormatBc5Typeless,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc5Unorm,
            ParentFormat: DxgiFormat.FormatBc5Typeless,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_UNORM, _UNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc5Snorm,
            ParentFormat: DxgiFormat.FormatBc5Typeless,
            DefaultFormatCastSet: D3DFCS_BC5,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, X, X],
            ComponentInterpretations: [_SNORM, _SNORM, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB5G6R5Unorm,
            ParentFormat: DxgiFormat.FormatB5G6R5Unorm,
            DefaultFormatCastSet: D3DFCS_B5G6R5,
            BitsPerComponent: [5, 6, 5, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB5G5R5A1Unorm,
            ParentFormat: DxgiFormat.FormatB5G5R5A1Unorm,
            DefaultFormatCastSet: D3DFCS_B5G5R5A1,
            BitsPerComponent: [5, 5, 5, 1],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8A8Unorm,
            ParentFormat: DxgiFormat.FormatB8G8R8A8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8X8Unorm,
            ParentFormat: DxgiFormat.FormatB8G8R8X8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatR10G10B10XrBiasA2Unorm,
            ParentFormat: DxgiFormat.FormatR10G10B10A2Typeless,
            DefaultFormatCastSet: D3DFCS_R10G10B10A2,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_FIXED_2_8, _FIXED_2_8, _FIXED_2_8, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8A8Typeless,
            ParentFormat: DxgiFormat.FormatB8G8R8A8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8A8UnormSrgb,
            ParentFormat: DxgiFormat.FormatB8G8R8A8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8A8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8X8Typeless,
            ParentFormat: DxgiFormat.FormatB8G8R8X8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB8G8R8X8UnormSrgb,
            ParentFormat: DxgiFormat.FormatB8G8R8X8Typeless,
            DefaultFormatCastSet: D3DFCS_B8G8R8X8,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: true,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, X],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc6HTypeless,
            ParentFormat: DxgiFormat.FormatBc6HTypeless,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc6HSf16,
            ParentFormat: DxgiFormat.FormatBc6HTypeless,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc6HUf16,
            ParentFormat: DxgiFormat.FormatBc6HTypeless,
            DefaultFormatCastSet: D3DFCS_BC6H,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_FLOAT, _FLOAT, _FLOAT, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc7Typeless,
            ParentFormat: DxgiFormat.FormatBc7Typeless,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.PartialType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc7Unorm,
            ParentFormat: DxgiFormat.FormatBc7Typeless,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatBc7UnormSrgb,
            ParentFormat: DxgiFormat.FormatBc7Typeless,
            DefaultFormatCastSet: D3DFCS_BC7,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 128,
            SRGBFormat: true,
            WidthAlignment: 4,
            HeightAlignment: 4,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, A],
            ComponentInterpretations: [_UNORM_SRGB, _UNORM_SRGB, _UNORM_SRGB, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ), // YUV 4:4:4 formats
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatAyuv,
            ParentFormat: DxgiFormat.FormatAyuv,
            DefaultFormatCastSet: D3DFCS_AYUV,
            BitsPerComponent: [8, 8, 8, 8],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatY410,
            ParentFormat: DxgiFormat.FormatY410,
            DefaultFormatCastSet: D3DFCS_Y410,
            BitsPerComponent: [10, 10, 10, 2],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatY416,
            ParentFormat: DxgiFormat.FormatY416,
            DefaultFormatCastSet: D3DFCS_Y416,
            BitsPerComponent: [16, 16, 16, 16],
            BitsPerUnit: 64,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ), // YUV 4:2:0 formats
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatNv12,
            ParentFormat: DxgiFormat.FormatNv12,
            DefaultFormatCastSet: D3DFCS_NV12,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatP010,
            ParentFormat: DxgiFormat.FormatP010,
            DefaultFormatCastSet: D3DFCS_P010,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatP016,
            ParentFormat: DxgiFormat.FormatP016,
            DefaultFormatCastSet: D3DFCS_P016,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.Format420Opaque,
            ParentFormat: DxgiFormat.Format420Opaque,
            DefaultFormatCastSet: D3DFCS_420_OPAQUE,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ), // YUV 4:2:2 formats
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatYuy2,
            ParentFormat: DxgiFormat.FormatYuy2,
            DefaultFormatCastSet: D3DFCS_YUY2,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatY210,
            ParentFormat: DxgiFormat.FormatY210,
            DefaultFormatCastSet: D3DFCS_Y210,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatY216,
            ParentFormat: DxgiFormat.FormatY216,
            DefaultFormatCastSet: D3DFCS_Y216,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 32,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, G, B, X],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ), // YUV 4:1:1 formats
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatNv11,
            ParentFormat: DxgiFormat.FormatNv11,
            DefaultFormatCastSet: D3DFCS_NV11,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 4,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ), // Legacy substream formats
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatAi44,
            ParentFormat: DxgiFormat.FormatAi44,
            DefaultFormatCastSet: D3DFCS_AI44,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatIa44,
            ParentFormat: DxgiFormat.FormatIa44,
            DefaultFormatCastSet: D3DFCS_IA44,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatP8,
            ParentFormat: DxgiFormat.FormatP8,
            DefaultFormatCastSet: D3DFCS_P8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatA8P8,
            ParentFormat: DxgiFormat.FormatA8P8,
            DefaultFormatCastSet: D3DFCS_A8P8,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatB4G4R4A4Unorm,
            ParentFormat: DxgiFormat.FormatB4G4R4A4Unorm,
            DefaultFormatCastSet: D3DFCS_B4G4R4A4,
            BitsPerComponent: [4, 4, 4, 4],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [B, G, R, A],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: true,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(116),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(117),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(118),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(119),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(120),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(121),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(122),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(123),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(124),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(125),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(126),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(127),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(128),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(129),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatP208,
            ParentFormat: DxgiFormat.FormatP208,
            DefaultFormatCastSet: D3DFCS_P208,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 2,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatV208,
            ParentFormat: DxgiFormat.FormatV208,
            DefaultFormatCastSet: D3DFCS_V208,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 2,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatV408,
            ParentFormat: DxgiFormat.FormatV408,
            DefaultFormatCastSet: D3DFCS_V408,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: true,
            bFloatNormFormat: false,
            bPlanar: true,
            bYUV: true,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(133),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(134),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(135),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(136),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(137),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(138),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(139),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(140),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(141),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(142),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(143),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(144),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(145),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(146),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(147),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(148),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(149),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(150),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(151),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(152),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(153),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(154),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(155),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(156),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(157),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(158),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(159),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(160),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(161),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(162),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(163),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(164),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(165),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(166),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(167),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(168),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(169),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(170),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(171),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(172),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(173),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(174),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(175),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(176),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(177),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(178),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(179),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(180),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(181),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(182),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(183),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(184),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(185),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(186),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(187),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: (DxgiFormat)(188),
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 0,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.NoType,
            ComponentNames: [X, X, X, X],
            ComponentInterpretations: [_TYPELESS, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: true
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatSamplerFeedbackMinMipOpaque,
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatSamplerFeedbackMipRegionUsedOpaque,
            ParentFormat: DxgiFormat.FormatUnknown,
            DefaultFormatCastSet: D3DFCS_UNKNOWN,
            BitsPerComponent: [0, 0, 0, 0],
            BitsPerUnit: 8,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Custom,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [R, X, X, X],
            ComponentInterpretations: [_UNORM, _TYPELESS, _TYPELESS, _TYPELESS],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
        new FORMAT_DETAIL(
            DXGIFormat: DxgiFormat.FormatA4B4G4R4Unorm,
            ParentFormat: DxgiFormat.FormatA4B4G4R4Unorm,
            DefaultFormatCastSet: D3DFCS_A4B4G4R4,
            BitsPerComponent: [4, 4, 4, 4],
            BitsPerUnit: 16,
            SRGBFormat: false,
            WidthAlignment: 1,
            HeightAlignment: 1,
            DepthAlignment: 1,
            Layout: D3DFormatLayout.Standard,
            TypeLevel: D3DFormatTypeLevel.FullType,
            ComponentNames: [A, B, G, R],
            ComponentInterpretations: [_UNORM, _UNORM, _UNORM, _UNORM],
            bDX9VertexOrIndexFormat: false,
            bDX9TextureFormat: false,
            bFloatNormFormat: false,
            bPlanar: false,
            bYUV: false,
            bDependentFormatCastSet: false,
            bInternal: false
        ),
    ];
    private static uint s_NumFormats => (uint)(s_FormatDetail.Length);

    [NativeTypeName("LPCSTR")]
    private static readonly string[] s_FormatNames =
    [
        "UNKNOWN",
        "R32G32B32A32_TYPELESS",
        "R32G32B32A32_FLOAT",
        "R32G32B32A32_UINT",
        "R32G32B32A32_SINT",
        "R32G32B32_TYPELESS",
        "R32G32B32_FLOAT",
        "R32G32B32_UINT",
        "R32G32B32_SINT",
        "R16G16B16A16_TYPELESS",
        "R16G16B16A16_FLOAT",
        "R16G16B16A16_UNORM",
        "R16G16B16A16_UINT",
        "R16G16B16A16_SNORM",
        "R16G16B16A16_SINT",
        "R32G32_TYPELESS",
        "R32G32_FLOAT",
        "R32G32_UINT",
        "R32G32_SINT",
        "R32G8X24_TYPELESS",
        "D32_FLOAT_S8X24_UINT",
        "R32_FLOAT_X8X24_TYPELESS",
        "X32_TYPELESS_G8X24_UINT",
        "R10G10B10A2_TYPELESS",
        "R10G10B10A2_UNORM",
        "R10G10B10A2_UINT",
        "R11G11B10_FLOAT",
        "R8G8B8A8_TYPELESS",
        "R8G8B8A8_UNORM",
        "R8G8B8A8_UNORM_SRGB",
        "R8G8B8A8_UINT",
        "R8G8B8A8_SNORM",
        "R8G8B8A8_SINT",
        "R16G16_TYPELESS",
        "R16G16_FLOAT",
        "R16G16_UNORM",
        "R16G16_UINT",
        "R16G16_SNORM",
        "R16G16_SINT",
        "R32_TYPELESS",
        "D32_FLOAT",
        "R32_FLOAT",
        "R32_UINT",
        "R32_SINT",
        "R24G8_TYPELESS",
        "D24_UNORM_S8_UINT",
        "R24_UNORM_X8_TYPELESS",
        "X24_TYPELESS_G8_UINT",
        "R8G8_TYPELESS",
        "R8G8_UNORM",
        "R8G8_UINT",
        "R8G8_SNORM",
        "R8G8_SINT",
        "R16_TYPELESS",
        "R16_FLOAT",
        "D16_UNORM",
        "R16_UNORM",
        "R16_UINT",
        "R16_SNORM",
        "R16_SINT",
        "R8_TYPELESS",
        "R8_UNORM",
        "R8_UINT",
        "R8_SNORM",
        "R8_SINT",
        "A8_UNORM",
        "R1_UNORM",
        "R9G9B9E5_SHAREDEXP",
        "R8G8_B8G8_UNORM",
        "G8R8_G8B8_UNORM",
        "BC1_TYPELESS",
        "BC1_UNORM",
        "BC1_UNORM_SRGB",
        "BC2_TYPELESS",
        "BC2_UNORM",
        "BC2_UNORM_SRGB",
        "BC3_TYPELESS",
        "BC3_UNORM",
        "BC3_UNORM_SRGB",
        "BC4_TYPELESS",
        "BC4_UNORM",
        "BC4_SNORM",
        "BC5_TYPELESS",
        "BC5_UNORM",
        "BC5_SNORM",
        "B5G6R5_UNORM",
        "B5G5R5A1_UNORM",
        "B8G8R8A8_UNORM",
        "B8G8R8X8_UNORM",
        "R10G10B10_XR_BIAS_A2_UNORM",
        "B8G8R8A8_TYPELESS",
        "B8G8R8A8_UNORM_SRGB",
        "B8G8R8X8_TYPELESS",
        "B8G8R8X8_UNORM_SRGB",
        "BC6H_TYPELESS",
        "BC6H_UF16",
        "BC6H_SF16",
        "BC7_TYPELESS",
        "BC7_UNORM",
        "BC7_UNORM_SRGB",
        "AYUV",
        "Y410",
        "Y416",
        "NV12",
        "P010",
        "P016",
        "420_OPAQUE",
        "YUY2",
        "Y210",
        "Y216",
        "NV11",
        "AI44",
        "IA44",
        "P8",
        "A8P8",
    ];

    public static HResult CalculateExtraPlanarRows(
        DxgiFormat format,
        uint plane0Height,
        [NativeTypeName("UINT &")] out uint totalHeight
    )
    {
        Unsafe.SkipInit(out totalHeight);
        if (!Planar(format))
        {
            totalHeight = plane0Height;
            return S_OK;
        }
        // blockWidth, blockHeight, and blockSize only reflect the size of plane 0.  Each planar format has additional planes that must
        // be counted.  Each format increases size by another 0.5x, 1x, or 2x.  Grab the number of "half allocation" increments so integer
        // math can be used to calculate the extra size.
        uint extraHalfHeight;
        uint round;
        switch (GetParentFormat(format))
        {
            case DxgiFormat.FormatNv12:
            case DxgiFormat.FormatP010:
            case DxgiFormat.FormatP016:
            case DxgiFormat.Format420Opaque:
            {
                extraHalfHeight = 1;
                round = 1;
                break;
            }
            case DxgiFormat.FormatNv11:
            case DxgiFormat.FormatP208:
            {
                extraHalfHeight = 2;
                round = 0;
                break;
            }
            case DxgiFormat.FormatV208:
            {
                extraHalfHeight = 2;
                round = 1;
                break;
            }
            case DxgiFormat.FormatV408:
            {
                extraHalfHeight = 4;
                round = 0;
                break;
            }
            case DxgiFormat.FormatR24G8Typeless:
            case DxgiFormat.FormatR32G8X24Typeless:
            {
                totalHeight = plane0Height;
                return S_OK;
            }
            default:
            {
                Debug.Assert(false);
                return S_OK;
            }
        }
        if (
            Windows.Failed(Safe_UIntMult(plane0Height, extraHalfHeight, out uint extraPlaneHeight))
            || FAILED(Safe_UIntAdd(extraPlaneHeight, round, out extraPlaneHeight))
            || FAILED(Safe_UIntAdd(plane0Height, (extraPlaneHeight >> 1), out totalHeight))
        )
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        return S_OK;
    }

    // This helper function calculates the Row Pitch for a given format. For Planar formats this function returns
    // the row major RowPitch of the resource. The RowPitch is the same for all the planes. For Planar
    // also use the CalculateExtraPlanarRows function to calculate the corresponding height or use the CalculateMinimumRowMajorSlicePitch
    // function. For Block Compressed Formats, this function returns the RowPitch of a row of blocks. For packed subsampled formats and other formats,
    // this function returns the row pitch of one single row of pixels.
    public static HResult CalculateMinimumRowMajorRowPitch(
        DxgiFormat Format,
        uint Width,
        [NativeTypeName("UINT &")] out uint RowPitch
    )
    {
        Unsafe.SkipInit(out RowPitch);
        // Early out for DXGI_FORMAT_UNKNOWN special case.
        if (Format == DxgiFormat.FormatUnknown)
        {
            RowPitch = Width;
            return S_OK;
        }
        uint WidthAlignment = GetWidthAlignment(Format);
        uint NumUnits;
        if (IsBlockCompressFormat(Format))
        {
            // This function calculates the minimum stride needed for a block row when the format
            // is block compressed.The GetBitsPerUnit value stored in the format table indicates
            // the size of a compressed block for block compressed formats.
            Debug.Assert(WidthAlignment != 0);
            if (Windows.Failed(DivideAndRoundUp(Width, WidthAlignment, out NumUnits)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
        }
        else
        {
            // All other formats must have strides aligned to their width alignment requirements.
            // The Width may not be aligned to the WidthAlignment.  This is not an error for this
            // function as we expect to allow formats like NV12 to have odd dimensions in the future.
            // The following alignement code expects only pow2 alignment requirements.  Only block
            // compressed formats currently have non-pow2 alignment requriements.
            Debug.Assert(IsPow2(WidthAlignment));
            uint Mask = WidthAlignment - 1;
            if (FAILED(Safe_UIntAdd(Width, Mask, out NumUnits)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            NumUnits &= ~Mask;
        }
        if (Windows.Failed(Safe_UIntMult(NumUnits, GetBitsPerUnit(Format), out RowPitch)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        // This must to always be Byte aligned.
        Debug.Assert((RowPitch & 7) == 0);
        RowPitch >>= 3;
        return S_OK;
    }

    // This helper function calculates the SlicePitch for a given format. For Planar formats the slice pitch includes the extra planes.
    public static HResult CalculateMinimumRowMajorSlicePitch(
        DxgiFormat Format,
        uint ContextBasedRowPitch,
        uint Height,
        [NativeTypeName("UINT &")] out uint SlicePitch
    )
    {
        Unsafe.SkipInit(out SlicePitch);
        if (Planar(Format))
        {
            if (Windows.Failed(CalculateExtraPlanarRows(Format, Height, out uint PlanarHeight)))
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            return Safe_UIntMult(ContextBasedRowPitch, PlanarHeight, out SlicePitch);
        }
        else if (Format == DxgiFormat.FormatUnknown)
        {
            return Safe_UIntMult(ContextBasedRowPitch, Height, out SlicePitch);
        }
        uint HeightAlignment = GetHeightAlignment(Format);
        // Caution assert to make sure that no new format breaks this assumption that all HeightAlignment formats are BC or Planar.
        // This is to make sure that Height handled correctly for this calculation.
        Debug.Assert(HeightAlignment == 1 || IsBlockCompressFormat(Format));
        if (Windows.Failed(DivideAndRoundUp(Height, HeightAlignment, out uint HeightOfPacked)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        if (Windows.Failed(Safe_UIntMult(HeightOfPacked, ContextBasedRowPitch, out SlicePitch)))
        {
            return INTSAFE_E_ARITHMETIC_OVERFLOW;
        }
        return S_OK;
    }

    public static HResult CalculateResourceSize(
        uint width,
        uint height,
        uint depth,
        DxgiFormat format,
        uint mipLevels,
        uint subresources,
        [NativeTypeName("SIZE_T &")] out nuint totalByteSize,
        D3D12MemcpyDest* pDst = null
    )
    {
        Unsafe.SkipInit(out totalByteSize);
        uint tableIndex = GetDetailTableIndexNoThrow(format);
        ref readonly FORMAT_DETAIL formatDetail = ref s_FormatDetail[tableIndex];
        bool fIsBlockCompressedFormat = IsBlockCompressFormat(format);
        // No format currently requires depth alignment.
        Debug.Assert(formatDetail.DepthAlignment == 1);
        uint subWidth = width;
        uint subHeight = height;
        uint subDepth = depth;
        for (uint s = 0, iM = 0; s < subresources; ++s)
        {
            if (
                Windows.Failed(
                    DivideAndRoundUp(subWidth, formatDetail.WidthAlignment, out uint blockWidth)
                )
            )
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            uint blockSize,
                blockHeight;
            if (fIsBlockCompressedFormat)
            {
                if (
                    Windows.Failed(
                        DivideAndRoundUp(subHeight, formatDetail.HeightAlignment, out blockHeight)
                    )
                )
                {
                    return INTSAFE_E_ARITHMETIC_OVERFLOW;
                }
                // Block Compressed formats use BitsPerUnit as block size.
                blockSize = formatDetail.BitsPerUnit;
            }
            else
            {
                // The height must *not* be aligned to HeightAlign.  As there is no plane pitch/stride, the expectation is that the 2nd plane
                // begins immediately after the first.  The only formats with HeightAlignment other than 1 are planar or block compressed, and
                // block compressed is handled above.
                Debug.Assert(formatDetail.bPlanar || (formatDetail.HeightAlignment == 1));
                blockHeight = subHeight;
                // Combined with the division os subWidth by the width alignment above, this helps achieve rounding the stride up to an even multiple of
                // block width.  This is especially important for formats like NV12 and P208 whose chroma plane is wider than the luma.
                blockSize = formatDetail.BitsPerUnit * formatDetail.WidthAlignment;
            }
            if (DxgiFormat.FormatUnknown == formatDetail.DXGIFormat)
            {
                blockSize = 8;
            }
            // Convert block width size to bytes.
            Debug.Assert((blockSize & 0x7) == 0);
            blockSize >>= 3;
            if (formatDetail.bPlanar)
            {
                if (Windows.Failed(CalculateExtraPlanarRows(format, blockHeight, out blockHeight)))
                {
                    return INTSAFE_E_ARITHMETIC_OVERFLOW;
                }
            }
            // Calculate rowPitch, depthPitch, and total subresource size.
            if (
                Windows.Failed(Safe_UIntMult(blockWidth, blockSize, out uint rowPitch))
                || Windows.Failed(Safe_UIntMult(blockHeight, rowPitch, out uint depthPitch))
            )
            {
                return INTSAFE_E_ARITHMETIC_OVERFLOW;
            }
            nuint subresourceByteSize = subDepth * depthPitch;
            if (pDst != null)
            {
                ref D3D12MemcpyDest dst = ref pDst[s];
                // This data will be returned straight from the API to satisfy Map. So, strides/ alignment must be API-correct.
                dst.PData = (void*)(totalByteSize);
                Debug.Assert((s != 0) || (dst.PData == null));
                dst.RowPitch = rowPitch;
                dst.SlicePitch = depthPitch;
            }
            // Align the subresource size.
            Debug.Assert(
                (MAP_ALIGN_REQUIREMENT & (MAP_ALIGN_REQUIREMENT - 1)) == 0,
                "This code expects MAP_ALIGN_REQUIREMENT to be a power of 2."
            );
            nuint subresourceByteSizeAligned = subresourceByteSize + MAP_ALIGN_REQUIREMENT - 1;
            subresourceByteSizeAligned &= ~(MAP_ALIGN_REQUIREMENT - 1u);
            totalByteSize += subresourceByteSizeAligned;
            // Iterate over mip levels and array elements
            if (++iM >= mipLevels)
            {
                iM = 0;
                subWidth = width;
                subHeight = height;
                subDepth = depth;
            }
            else
            {
                subWidth /= ((1 == subWidth) ? 1u : 2u);
                subHeight /= ((1 == subHeight) ? 1u : 2u);
                subDepth /= ((1 == subDepth) ? 1u : 2u);
            }
        }
        return S_OK;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static HResult CalculateResourceSize(
        uint width,
        uint height,
        uint depth,
        DxgiFormat format,
        uint mipLevels,
        uint subresources,
        [NativeTypeName("SIZE_T &")] out nuint totalByteSize,
        Ref<D3D12MemcpyDest> pDst = default
    )
    {
        fixed (D3D12MemcpyDest* __dsl_pDst = pDst)
        {
            return (HResult)CalculateResourceSize(
                width,
                height,
                depth,
                format,
                mipLevels,
                subresources,
                out totalByteSize,
                __dsl_pDst
            );
        }
    }

    public static bool CanBeCastEvenFullyTyped(DxgiFormat Format, D3DFeatureLevel fl)
    {
        //SRGB can be cast away/back, and XR_BIAS can be cast to/from UNORM
        switch (fl)
        {
            case D3DFeatureLevel.Level1X0Generic:
            case D3DFeatureLevel.Level1X0Core:
            {
                return false;
            }
            default:
            {
                break;
            }
        }
        switch (Format)
        {
            case DxgiFormat.FormatR8G8B8A8Unorm:
            case DxgiFormat.FormatR8G8B8A8UnormSrgb:
            case DxgiFormat.FormatB8G8R8A8Unorm:
            case DxgiFormat.FormatB8G8R8A8UnormSrgb:
            {
                return true;
            }
            case DxgiFormat.FormatR10G10B10A2Unorm:
            case DxgiFormat.FormatR10G10B10XrBiasA2Unorm:
            {
                return fl >= D3DFeatureLevel.Level10X0;
            }
            default:
            {
                return false;
            }
        }
    }

    public static bool DecodeHistogramAllowedForOutputFormatSupport(DxgiFormat Format)
    {
        return (Format == DxgiFormat.FormatNv12) || (Format == DxgiFormat.FormatP010);
    }

    public static bool DepthOnlyFormat(DxgiFormat Format)
    {
        switch (Format)
        {
            case DxgiFormat.FormatD32Float:
            case DxgiFormat.FormatD16Unorm:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HResult DivideAndRoundUp(
        uint dividend,
        uint divisor,
        [NativeTypeName("UINT &")] out uint result
    )
    {
        HResult hr = Safe_UIntAdd(dividend, (divisor - 1), out uint adjustedDividend);
        result = SUCCEEDED(hr) ? (adjustedDividend / divisor) : 0;
        return hr;
    }

    public static MaybeBool<int> DX9TextureFormat(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).bDX9TextureFormat;
    }

    public static MaybeBool<int> DX9VertexOrIndexFormat(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).bDX9VertexOrIndexFormat;
    }

    public static bool FamilySupportsStencil(DxgiFormat Format)
    {
        switch (GetParentFormat(Format))
        {
            case DxgiFormat.FormatR32G8X24Typeless:
            case DxgiFormat.FormatR24G8Typeless:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    public static bool FloatAndNotFloatFormats(DxgiFormat FormatA, DxgiFormat FormatB)
    {
        uint NumComponents = uint.Min(
            GetNumComponentsInFormat(FormatA),
            GetNumComponentsInFormat(FormatB)
        );
        for (uint c = 0; c < NumComponents; c++)
        {
            D3DFormatComponentInterpretation fciA = GetFormatComponentInterpretation(FormatA, c);
            D3DFormatComponentInterpretation fciB = GetFormatComponentInterpretation(FormatB, c);
            if (
                (fciA != fciB)
                && (
                    (fciA == D3DFormatComponentInterpretation.Float)
                    || (fciB == D3DFormatComponentInterpretation.Float)
                )
            )
            {
                return true;
            }
        }
        return false;
    }

    public static MaybeBool<int> FloatNormTextureFormat(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).bFloatNormFormat;
    }

    public static bool FormatExists(DxgiFormat Format)
    {
        return GetFormat((nuint)(Format)) != (DxgiFormat)(-1);
    }

    public static bool FormatExistsInHeader(DxgiFormat Format, bool bExternalHeader = true)
    {
        uint Index = GetDetailTableIndex(Format);
        if (
            (unchecked((uint)(-1)) == Index)
            || (bExternalHeader && GetFormatDetail(Format).bInternal)
        )
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void Get4KTileShape(
        D3D12TileShape* pTileShape,
        DxgiFormat Format,
        D3D12ResourceDimension Dimension,
        uint SampleCount
    )
    {
        uint BPU = GetBitsPerUnit(Format);
        switch (Dimension)
        {
            case D3D12ResourceDimension.Unknown:
            case D3D12ResourceDimension.Buffer:
            case D3D12ResourceDimension.Texture1D:
            {
                Debug.Assert(!IsBlockCompressFormat(Format));
                pTileShape->WidthInTexels = (BPU == 0) ? 4096 : 4096 * 8 / BPU;
                pTileShape->HeightInTexels = 1;
                pTileShape->DepthInTexels = 1;
                break;
            }
            case D3D12ResourceDimension.Texture2D:
            {
                pTileShape->DepthInTexels = 1;
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 16 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 16 * GetHeightAlignment(Format);
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DxgiFormat.FormatBc1Typeless
                                && Format <= DxgiFormat.FormatBc1UnormSrgb
                            )
                                || (
                                    Format >= DxgiFormat.FormatBc4Typeless
                                    && Format <= DxgiFormat.FormatBc4Snorm
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else
                {
                    if (BPU <= 8)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 64;
                    }
                    else if (BPU <= 16)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 32;
                    }
                    else if (BPU <= 32)
                    {
                        pTileShape->WidthInTexels = 32;
                        pTileShape->HeightInTexels = 32;
                    }
                    else if (BPU <= 64)
                    {
                        pTileShape->WidthInTexels = 32;
                        pTileShape->HeightInTexels = 16;
                    }
                    else if (BPU <= 128)
                    {
                        pTileShape->WidthInTexels = 16;
                        pTileShape->HeightInTexels = 16;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    if (SampleCount <= 1)
                    {
                        // Do nothing
                    }
                    else if (SampleCount <= 2)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 1;
                    }
                    else if (SampleCount <= 4)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 8)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 16)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 4;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    Debug.Assert(GetWidthAlignment(Format) == 1);
                    Debug.Assert(GetHeightAlignment(Format) == 1);
                    Debug.Assert(GetDepthAlignment(Format) == 1);
                }
                break;
            }
            case D3D12ResourceDimension.Texture3D:
                {
                    if (IsBlockCompressFormat(Format))
                    {
                        // Currently only supported block sizes are 64 and 128.
                        // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                        Debug.Assert(BPU == 64 || BPU == 128);
                        pTileShape->WidthInTexels = 8 * GetWidthAlignment(Format);
                        pTileShape->HeightInTexels = 8 * GetHeightAlignment(Format);
                        pTileShape->DepthInTexels = 4;
                        if (BPU == 64)
                        {
                            // If bits per block are 64 we double width so it takes up the full tile size.
                            // This is only true for BC1 and BC4
                            Debug.Assert(
                                (
                                    Format >= DxgiFormat.FormatBc1Typeless
                                    && Format <= DxgiFormat.FormatBc1UnormSrgb
                                )
                                    || (
                                        Format >= DxgiFormat.FormatBc4Typeless
                                        && Format <= DxgiFormat.FormatBc4Snorm
                                    )
                            );
                            pTileShape->DepthInTexels *= 2;
                        }
                    }
                    else
                    {
                        if (BPU <= 8)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                        }
                        else if (BPU <= 16)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 32)
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 64)
                        {
                            pTileShape->WidthInTexels = 8;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 8;
                        }
                        else if (BPU <= 128)
                        {
                            pTileShape->WidthInTexels = 8;
                            pTileShape->HeightInTexels = 8;
                            pTileShape->DepthInTexels = 4;
                        }
                        else
                        {
                            Debug.Assert(false);
                        }
                        Debug.Assert(GetWidthAlignment(Format) == 1);
                        Debug.Assert(GetHeightAlignment(Format) == 1);
                        Debug.Assert(GetDepthAlignment(Format) == 1);
                    }
                }
                break;
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Get4KTileShape(
        Ref<D3D12TileShape> pTileShape,
        DxgiFormat Format,
        D3D12ResourceDimension Dimension,
        uint SampleCount
    )
    {
        fixed (D3D12TileShape* __dsl_pTileShape = pTileShape)
        {
            Get4KTileShape(__dsl_pTileShape, Format, Dimension, SampleCount);
        }
    }

    [return: NativeTypeName("UINT8")]
    public static byte GetAddressingBitsPerAlignedSize(DxgiFormat Format)
    {
        uint byteAlignment = GetByteAlignment(Format);
        byte addressBitsPerElement;
        switch (byteAlignment)
        {
            case 1:
            {
                addressBitsPerElement = 0;
                break;
            }
            case 2:
            {
                addressBitsPerElement = 1;
                break;
            }
            case 4:
            {
                addressBitsPerElement = 2;
                break;
            }
            case 8:
            {
                addressBitsPerElement = 3;
                break;
            }
            case 16:
            {
                addressBitsPerElement = 4;
                break;
            }
            // The format is not supported
            default:
            {
                return unchecked((byte)(-1));
            }
        }
        return addressBitsPerElement;
    }

    public static uint GetBitsPerComponent(DxgiFormat Format, uint AbsoluteComponentIndex)
    {
        if (AbsoluteComponentIndex > 3)
        {
            ThrowHR(E_FAIL);
        }
        return Unsafe.Add(
            ref MemoryMarshal.GetReference(
                (ReadOnlySpan<byte>)(GetFormatDetailRefThrow(Format).BitsPerComponent)
            ),
            AbsoluteComponentIndex
        );
    }

    public static uint GetBitsPerStencil(DxgiFormat Format)
    {
        uint Index = GetDetailTableIndexThrow(Format);
        if (
            (GetFormatDetailRef(Index).TypeLevel != D3DFormatTypeLevel.PartialType)
            && (GetFormatDetailRef(Index).TypeLevel != D3DFormatTypeLevel.FullType)
        )
        {
            return 0;
        }
        for (uint comp = 0; comp < 4; comp++)
        {
            D3DFormatComponentName name = D3DFormatComponentName.D;
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name == D3DFormatComponentName.S)
            {
                return Unsafe.Add(
                    ref MemoryMarshal.GetReference(
                        (ReadOnlySpan<byte>)(GetFormatDetailRef(Index).BitsPerComponent)
                    ),
                    comp
                );
            }
        }
        return 0;
    }

    // Returns bits per pixel unless format is a block compress format then it returns bits per block.
    // Use IsBlockCompressFormat() to determine if block size is returned.
    public static uint GetBitsPerUnit(DxgiFormat Format)
    {
        return GetFormatDetailRefNoThrow(Format).BitsPerUnit;
    }

    public static uint GetBitsPerUnitThrow(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).BitsPerUnit;
    }

    public static uint GetByteAlignment(DxgiFormat Format)
    {
        uint bits = GetBitsPerUnit(Format);
        if (!IsBlockCompressFormat(Format))
        {
            bits *=
                GetWidthAlignment(Format) * GetHeightAlignment(Format) * GetDepthAlignment(Format);
        }
        Debug.Assert((bits & 0x7) == 0); // Unit must be byte-aligned
        return bits >> 3;
    }

    public static D3DFormatComponentName GetComponentName(
        DxgiFormat Format,
        uint AbsoluteComponentIndex
    )
    {
        Unsafe.SkipInit(out D3DFormatComponentName name);
        switch (AbsoluteComponentIndex)
        {
            case 0:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName0;
                break;
            }
            case 1:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName1;
                break;
            }
            case 2:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName2;
                break;
            }
            case 3:
            {
                name = GetFormatDetailRefThrow(Format).ComponentName3;
                break;
            }
            default:
            {
                ThrowHR(E_FAIL);
                break;
            }
        }
        return name;
    }

    public static uint GetDepthAlignment(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).DepthAlignment;
    }

    public static uint GetDetailTableIndex(DxgiFormat Format)
    {
        if ((uint)(Format) < s_FormatDetail.Length)
        {
            Debug.Assert(GetFormatDetailRef(Format).DXGIFormat == Format);
            return (uint)(Format);
        }
        return unchecked((uint)(-1));
    }

    public static uint GetDetailTableIndexNoThrow(DxgiFormat Format)
    {
        uint Index = GetDetailTableIndex(Format);
        Debug.Assert(unchecked((uint)(-1)) != Index); // Needs to be validated externally.
        return Index;
    }

    public static uint GetDetailTableIndexThrow(DxgiFormat Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            ThrowHR(E_FAIL);
        }
        return Index;
    }

    public static DxgiFormat GetFormat([NativeTypeName("SIZE_T")] nuint Index)
    {
        if (Index < GetNumFormats())
        {
            return GetFormatDetailRef(Index).DXGIFormat;
        }
        return (DxgiFormat)(-1);
    }

    [return: NativeTypeName("const DXGI_FORMAT *")]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Ptr<DxgiFormat> GetFormatCastSet(DxgiFormat Format) =>
        (DxgiFormat*)GetFormatCastSetRaw(Format);

    [return: NativeTypeName("const DXGI_FORMAT *")]
    public static DxgiFormat* GetFormatCastSetRaw(DxgiFormat Format)
    {
        return GetFormatDetailRef(Format).pDefaultFormatCastSet;
    }

    public static D3DFormatComponentInterpretation GetFormatComponentInterpretation(
        DxgiFormat Format,
        uint AbsoluteComponentIndex
    )
    {
        D3DFormatComponentInterpretation interp = new D3DFormatComponentInterpretation();
        switch (AbsoluteComponentIndex)
        {
            case 0:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation0;
                break;
            }
            case 1:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation1;
                break;
            }
            case 2:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation2;
                break;
            }
            case 3:
            {
                interp = GetFormatDetailRefThrow(Format).ComponentInterpretation3;
                break;
            }
            default:
            {
                ThrowHR(E_FAIL);
                break;
            }
        }
        return interp;
    }

    [return: NativeTypeName("const FORMAT_DETAILS *")]
    private static ref readonly FORMAT_DETAIL GetFormatDetail(DxgiFormat Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            return ref Unsafe.NullRef<FORMAT_DETAIL>();
        }
        return ref GetFormatDetailRef(Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRef(nuint Index)
    {
        return ref Unsafe.Add(ref MemoryMarshal.GetArrayDataReference(s_FormatDetail), Index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRef(DxgiFormat Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            (uint)(Format)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRefNoThrow(DxgiFormat Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            GetDetailTableIndexNoThrow(Format)
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static ref readonly FORMAT_DETAIL GetFormatDetailRefThrow(DxgiFormat Format)
    {
        return ref Unsafe.Add(
            ref MemoryMarshal.GetArrayDataReference(s_FormatDetail),
            GetDetailTableIndexThrow(Format)
        );
    }

    public static void GetFormatReturnTypes(
        DxgiFormat Format,
        D3DFormatComponentInterpretation* pInterpretations
    )
    {
        uint Index = GetDetailTableIndexThrow(Format);
        pInterpretations[(int)(D3D10Sb4ComponentName.R)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation0;
        pInterpretations[(int)(D3D10Sb4ComponentName.G)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation1;
        pInterpretations[(int)(D3D10Sb4ComponentName.B)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation2;
        pInterpretations[(int)(D3D10Sb4ComponentName.A)] = GetFormatDetailRef(
            Index
        ).ComponentInterpretation3;
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetFormatReturnTypes(
        DxgiFormat Format,
        Ref<D3DFormatComponentInterpretation> pInterpretations
    )
    {
        fixed (D3DFormatComponentInterpretation* __dsl_pInterpretations = pInterpretations)
        {
            GetFormatReturnTypes(Format, __dsl_pInterpretations);
        }
    }

    [return: NativeTypeName("const FORMAT_DETAIL *")]
    public static ReadOnlySpan<FORMAT_DETAIL> GetFormatTable()
    {
        return s_FormatDetail;
    }

    public static uint GetHeightAlignment(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).HeightAlignment;
    }

    public static D3DFeatureLevel GetHighestDefinedFeatureLevel()
    {
        return D3DFeatureLevel.Level12X2;
    }

    public static D3DFormatLayout GetLayout(DxgiFormat Format)
    {
        return GetFormatDetailRefNoThrow(Format).Layout;
    }

    public static void GetMipDimensions(
        [NativeTypeName("UINT8")] byte mipSlice,
        [NativeTypeName("UINT64")] ulong* pWidth,
        [NativeTypeName("UINT64")] ulong* pHeight = null,
        [NativeTypeName("UINT64")] ulong* pDepth = null
    )
    {
        uint denominator = (1u << mipSlice); // 2 ^ subresource
        ulong mipWidth = *pWidth / denominator;
        ulong mipHeight = (pHeight != null) ? *pHeight / denominator : 1;
        ulong mipDepth = (pDepth != null) ? *pDepth / denominator : 1;
        // Adjust dimensions for degenerate mips
        if (mipHeight == 0)
        {
            mipHeight = 1;
        }
        if (mipWidth == 0)
        {
            mipWidth = 1;
        }
        if (mipDepth == 0)
        {
            mipDepth = 1;
        }
        *pWidth = mipWidth;
        if (pHeight != null)
        {
            *pHeight = mipHeight;
        }
        if (pDepth != null)
        {
            *pDepth = mipDepth;
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetMipDimensions(
        [NativeTypeName("UINT8")] byte mipSlice,
        [NativeTypeName("UINT64")] Ref<ulong> pWidth,
        [NativeTypeName("UINT64")] Ref<ulong> pHeight = default,
        [NativeTypeName("UINT64")] Ref<ulong> pDepth = default
    )
    {
        fixed (ulong* __dsl_pDepth = pDepth)
        fixed (ulong* __dsl_pHeight = pHeight)
        fixed (ulong* __dsl_pWidth = pWidth)
        {
            GetMipDimensions(mipSlice, __dsl_pWidth, __dsl_pHeight, __dsl_pDepth);
        }
    }

    [return: NativeTypeName("LPCSTR")]
    public static string GetName(DxgiFormat Format, bool bHideInternalFormats = true)
    {
        uint Index = GetDetailTableIndex(Format);
        if (
            unchecked((uint)(-1)) == Index
            || (bHideInternalFormats && GetFormatDetail(Format).bInternal)
        )
        {
            return "Unrecognized";
        }
        else
        {
            return Unsafe.Add(ref MemoryMarshal.GetArrayDataReference(s_FormatNames), Index);
        }
    }

    public static uint GetNumComponentsInFormat(DxgiFormat Format)
    {
        uint n = 0;
        uint Index = GetDetailTableIndexThrow(Format);
        for (uint comp = 0; comp < 4; comp++)
        {
            D3DFormatComponentName name = D3DFormatComponentName.D;
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name != D3DFormatComponentName.X)
            {
                n++;
            }
        }
        return n;
    }

    public static uint GetNumFormats()
    {
        return s_NumFormats;
    }

    public static DxgiFormat GetParentFormat(DxgiFormat Format)
    {
        return GetFormatDetailRef(Format).ParentFormat;
    }

    [return: NativeTypeName("UINT8")]
    public static byte GetPlaneCount(DxgiFormat Format)
    {
        switch (GetParentFormat(Format))
        {
            case DxgiFormat.FormatNv12:
            case DxgiFormat.FormatNv11:
            case DxgiFormat.FormatP208:
            case DxgiFormat.FormatP016:
            case DxgiFormat.FormatP010:
            case DxgiFormat.FormatR24G8Typeless:
            case DxgiFormat.FormatR32G8X24Typeless:
            {
                return 2;
            }
            case DxgiFormat.FormatV208:
            case DxgiFormat.FormatV408:
            {
                return 3;
            }
            default:
            {
                return 1;
            }
        }
    }

    // Maps resource format + view format to a plane index for resource formats where the plane index can be inferred from this information.
    // For planar formats where the plane index is ambiguous given this information (examples: V208, V408), this function returns 0.
    // This function returns 0 for non-planar formats.
    [return: NativeTypeName("UINT8")]
    public static byte GetPlaneSliceFromViewFormat(DxgiFormat ResourceFormat, DxgiFormat ViewFormat)
    {
        switch (GetParentFormat(ResourceFormat))
        {
            case DxgiFormat.FormatR24G8Typeless:
            {
                switch (ViewFormat)
                {
                    case DxgiFormat.FormatR24UnormX8Typeless:
                    {
                        return 0;
                    }
                    case DxgiFormat.FormatX24TypelessG8Uint:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DxgiFormat.FormatR32G8X24Typeless:
            {
                switch (ViewFormat)
                {
                    case DxgiFormat.FormatR32FloatX8X24Typeless:
                    {
                        return 0;
                    }
                    case DxgiFormat.FormatX32TypelessG8X24Uint:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DxgiFormat.FormatNv12:
            case DxgiFormat.FormatNv11:
            case DxgiFormat.FormatP208:
            {
                switch (ViewFormat)
                {
                    case DxgiFormat.FormatR8Unorm:
                    case DxgiFormat.FormatR8Uint:
                    {
                        return 0;
                    }
                    case DxgiFormat.FormatR8G8Unorm:
                    case DxgiFormat.FormatR8G8Uint:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            case DxgiFormat.FormatP016:
            case DxgiFormat.FormatP010:
            {
                switch (ViewFormat)
                {
                    case DxgiFormat.FormatR16Unorm:
                    case DxgiFormat.FormatR16Uint:
                    {
                        return 0;
                    }
                    case DxgiFormat.FormatR16G16Unorm:
                    case DxgiFormat.FormatR16G16Uint:
                    case DxgiFormat.FormatR32Uint:
                    {
                        return 1;
                    }
                    default:
                    {
                        Debug.Assert(false);
                        break;
                    }
                }
                break;
            }
            default:
            {
                break;
            }
        }
        return 0;
    }

    public static void GetPlaneSubsampledSizeAndFormatForCopyableLayout(
        uint PlaneSlice,
        DxgiFormat Format,
        uint Width,
        uint Height,
        [NativeTypeName("DXGI_FORMAT &")] out DxgiFormat PlaneFormat,
        [NativeTypeName("UINT &")] out uint MinPlanePitchWidth,
        [NativeTypeName("UINT &")] out uint PlaneWidth,
        [NativeTypeName("UINT &")] out uint PlaneHeight
    )
    {
        Unsafe.SkipInit(out PlaneFormat);
        Unsafe.SkipInit(out MinPlanePitchWidth);
        Unsafe.SkipInit(out PlaneWidth);
        Unsafe.SkipInit(out PlaneHeight);
        DxgiFormat ParentFormat = GetParentFormat(Format);
        if (Planar(ParentFormat))
        {
            switch (ParentFormat)
            {
                // YCbCr 4:2:0
                case DxgiFormat.FormatNv12:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DxgiFormat.FormatR8Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DxgiFormat.FormatR8G8Typeless;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                case DxgiFormat.FormatP010:
                case DxgiFormat.FormatP016:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DxgiFormat.FormatR16Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DxgiFormat.FormatR16G16Typeless;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:2:2
                case DxgiFormat.FormatP208:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DxgiFormat.FormatR8Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DxgiFormat.FormatR8G8Typeless;
                            PlaneWidth = (Width + 1) >> 1;
                            PlaneHeight = Height;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:4:0
                case DxgiFormat.FormatV208:
                {
                    PlaneFormat = DxgiFormat.FormatR8Typeless;
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            break;
                        }
                        case 1:
                        case 2:
                        {
                            PlaneWidth = Width;
                            PlaneHeight = (Height + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    MinPlanePitchWidth = PlaneWidth;
                    break;
                }
                // YCbCr 4:4:4
                case DxgiFormat.FormatV408:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        case 1:
                        case 2:
                        {
                            PlaneFormat = DxgiFormat.FormatR8Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = PlaneWidth;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                // YCbCr 4:1:1
                case DxgiFormat.FormatNv11:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DxgiFormat.FormatR8Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DxgiFormat.FormatR8G8Typeless;
                            PlaneWidth = (Width + 3) >> 2;
                            PlaneHeight = Height;
                            // NV11 has unused padding to the right of the chroma plane in the RowMajor (linear) copyable layout.
                            MinPlanePitchWidth = (Width + 1) >> 1;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                case DxgiFormat.FormatR32G8X24Typeless:
                case DxgiFormat.FormatR24G8Typeless:
                {
                    switch (PlaneSlice)
                    {
                        case 0:
                        {
                            PlaneFormat = DxgiFormat.FormatR32Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        case 1:
                        {
                            PlaneFormat = DxgiFormat.FormatR8Typeless;
                            PlaneWidth = Width;
                            PlaneHeight = Height;
                            MinPlanePitchWidth = Width;
                            break;
                        }
                        default:
                        {
                            Debug.Assert(false);
                            break;
                        }
                    }
                    break;
                }
                default:
                {
                    Debug.Assert(false);
                    break;
                }
            }
        }
        else
        {
            Debug.Assert(PlaneSlice == 0);
            PlaneFormat = Format;
            PlaneWidth = Width;
            PlaneHeight = Height;
            MinPlanePitchWidth = PlaneWidth;
        }
    }

    public static void GetTileShape(
        D3D12TileShape* pTileShape,
        DxgiFormat Format,
        D3D12ResourceDimension Dimension,
        uint SampleCount
    )
    {
        uint BPU = GetBitsPerUnit(Format);
        switch (Dimension)
        {
            case D3D12ResourceDimension.Unknown:
            case D3D12ResourceDimension.Buffer:
            case D3D12ResourceDimension.Texture1D:
            {
                Debug.Assert(!IsBlockCompressFormat(Format));
                pTileShape->WidthInTexels =
                    (BPU == 0)
                        ? D3D12.TiledResourceTileSizeInBytes
                        : D3D12.TiledResourceTileSizeInBytes * 8 / BPU;
                pTileShape->HeightInTexels = 1;
                pTileShape->DepthInTexels = 1;
                break;
            }
            case D3D12ResourceDimension.Texture2D:
            {
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 64 * 64 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 64 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 64 * GetHeightAlignment(Format);
                    pTileShape->DepthInTexels = 1;
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DxgiFormat.FormatBc1Typeless
                                && Format <= DxgiFormat.FormatBc1UnormSrgb
                            )
                                || (
                                    Format >= DxgiFormat.FormatBc4Typeless
                                    && Format <= DxgiFormat.FormatBc4Snorm
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else
                {
                    pTileShape->DepthInTexels = 1;
                    if (BPU <= 8)
                    {
                        pTileShape->WidthInTexels = 256;
                        pTileShape->HeightInTexels = 256;
                    }
                    else if (BPU <= 16)
                    {
                        pTileShape->WidthInTexels = 256;
                        pTileShape->HeightInTexels = 128;
                    }
                    else if (BPU <= 32)
                    {
                        pTileShape->WidthInTexels = 128;
                        pTileShape->HeightInTexels = 128;
                    }
                    else if (BPU <= 64)
                    {
                        pTileShape->WidthInTexels = 128;
                        pTileShape->HeightInTexels = 64;
                    }
                    else if (BPU <= 128)
                    {
                        pTileShape->WidthInTexels = 64;
                        pTileShape->HeightInTexels = 64;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                    if (SampleCount <= 1)
                    {
                        // Do nothing
                    }
                    else if (SampleCount <= 2)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 1;
                    }
                    else if (SampleCount <= 4)
                    {
                        pTileShape->WidthInTexels /= 2;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 8)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 2;
                    }
                    else if (SampleCount <= 16)
                    {
                        pTileShape->WidthInTexels /= 4;
                        pTileShape->HeightInTexels /= 4;
                    }
                    else
                    {
                        Debug.Assert(false);
                    }
                }
                break;
            }
            case D3D12ResourceDimension.Texture3D:
            {
                if (IsBlockCompressFormat(Format))
                {
                    // Currently only supported block sizes are 64 and 128.
                    // These equations calculate the size in texels for a tile. It relies on the fact that 16*16*16 blocks fit in a tile if the block size is 128 bits.
                    Debug.Assert(BPU == 64 || BPU == 128);
                    pTileShape->WidthInTexels = 16 * GetWidthAlignment(Format);
                    pTileShape->HeightInTexels = 16 * GetHeightAlignment(Format);
                    pTileShape->DepthInTexels = 16 * GetDepthAlignment(Format);
                    if (BPU == 64)
                    {
                        // If bits per block are 64 we double width so it takes up the full tile size.
                        // This is only true for BC1 and BC4
                        Debug.Assert(
                            (
                                Format >= DxgiFormat.FormatBc1Typeless
                                && Format <= DxgiFormat.FormatBc1UnormSrgb
                            )
                                || (
                                    Format >= DxgiFormat.FormatBc4Typeless
                                    && Format <= DxgiFormat.FormatBc4Snorm
                                )
                        );
                        pTileShape->WidthInTexels *= 2;
                    }
                }
                else if (
                    (Format == DxgiFormat.FormatR8G8B8G8Unorm)
                    || (Format == DxgiFormat.FormatG8R8G8B8Unorm)
                )
                {
                    //RGBG and GRGB are treated as 2x1 block format
                    pTileShape->WidthInTexels = 64;
                    pTileShape->HeightInTexels = 32;
                    pTileShape->DepthInTexels = 16;
                }
                else
                {
                    // Not a block format so BPU is bits per pixel.
                    Debug.Assert(
                        (GetWidthAlignment(Format) == 1)
                            && (GetHeightAlignment(Format) == 1)
                            && (GetDepthAlignment(Format) != 0)
                    );
                    switch (BPU)
                    {
                        case 8:
                        {
                            pTileShape->WidthInTexels = 64;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 32;
                            break;
                        }
                        case 16:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 32;
                            break;
                        }
                        case 32:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 32;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                        case 64:
                        {
                            pTileShape->WidthInTexels = 32;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                        case 128:
                        {
                            pTileShape->WidthInTexels = 16;
                            pTileShape->HeightInTexels = 16;
                            pTileShape->DepthInTexels = 16;
                            break;
                        }
                    }
                }
                break;
            }
        }
    }

    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void GetTileShape(
        Ref<D3D12TileShape> pTileShape,
        DxgiFormat Format,
        D3D12ResourceDimension Dimension,
        uint SampleCount
    )
    {
        fixed (D3D12TileShape* __dsl_pTileShape = pTileShape)
        {
            GetTileShape(__dsl_pTileShape, Format, Dimension, SampleCount);
        }
    }

    public static D3DFormatTypeLevel GetTypeLevel(DxgiFormat Format)
    {
        return GetFormatDetailRefNoThrow(Format).TypeLevel;
    }

    public static uint GetWidthAlignment(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).WidthAlignment;
    }

    public static void GetYCbCrChromaSubsampling(
        DxgiFormat Format,
        [NativeTypeName("UINT &")] out uint HorizontalSubsampling,
        [NativeTypeName("UINT &")] out uint VerticalSubsampling
    )
    {
        switch (Format)
        {
            // YCbCr 4:2:0
            case DxgiFormat.FormatNv12:
            case DxgiFormat.FormatP010:
            case DxgiFormat.FormatP016:
            case DxgiFormat.Format420Opaque:
            {
                HorizontalSubsampling = 2;
                VerticalSubsampling = 2;
                break;
            }
            // YCbCr 4:2:2
            case DxgiFormat.FormatP208:
            case DxgiFormat.FormatYuy2:
            case DxgiFormat.FormatY210:
            {
                HorizontalSubsampling = 2;
                VerticalSubsampling = 1;
                break;
            }
            // YCbCr 4:4:0
            case DxgiFormat.FormatV208:
            {
                HorizontalSubsampling = 1;
                VerticalSubsampling = 2;
                break;
            }
            // YCbCr 4:4:4
            case DxgiFormat.FormatAyuv:
            case DxgiFormat.FormatV408:
            case DxgiFormat.FormatY410:
            case DxgiFormat.FormatY416:
            {
                // Fallthrough
                goto case DxgiFormat.FormatAi44;
            }
            // YCbCr palletized  4:4:4:
            case DxgiFormat.FormatAi44:
            case DxgiFormat.FormatIa44:
            case DxgiFormat.FormatP8:
            case DxgiFormat.FormatA8P8:
            {
                HorizontalSubsampling = 1;
                VerticalSubsampling = 1;
                break;
            }
            // YCbCr 4:1:1
            case DxgiFormat.FormatNv11:
            {
                HorizontalSubsampling = 4;
                VerticalSubsampling = 1;
                break;
            }
            default:
            {
                // All YCbCr formats should be in this list.
                Debug.Assert(!YUV(Format));
                HorizontalSubsampling = 1;
                VerticalSubsampling = 1;
                break;
            }
        }
    }

    // Returns true if format is block compressed. This function is a helper function for GetBitsPerUnit and
    // if this function returns true then GetBitsPerUnit returns block size.
    public static bool IsBlockCompressFormat(DxgiFormat Format)
    {
        // Returns true if BC1, BC2, BC3, BC4, BC5, BC6, BC7, or ASTC
        return (Format >= DxgiFormat.FormatBc1Typeless && Format <= DxgiFormat.FormatBc5Snorm)
            || (Format >= DxgiFormat.FormatBc6HTypeless && Format <= DxgiFormat.FormatBc7UnormSrgb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static bool IsPow2(uint Val)
    {
        return 0 == (Val & (Val - 1));
    }

    public static bool IsSRGBFormat(DxgiFormat Format)
    {
        uint Index = GetDetailTableIndex(Format);
        if (unchecked((uint)(-1)) == Index)
        {
            return false;
        }
        return GetFormatDetailRef(Index).SRGBFormat;
    }

    public static bool IsSupportedTextureDisplayableFormat(DxgiFormat Format, bool bMediaFormatOnly)
    {
        if (bMediaFormatOnly)
        {
            return (Format == DxgiFormat.FormatNv12) || (Format == DxgiFormat.FormatYuy2);
        }
        else
        {
            return (Format == DxgiFormat.FormatB8G8R8A8Unorm)
                || (Format == DxgiFormat.FormatR8G8B8A8Unorm)
                || (Format == DxgiFormat.FormatR16G16B16A16Float)
                || (Format == DxgiFormat.FormatR10G10B10A2Unorm)
                || (Format == DxgiFormat.FormatNv12)
                || (Format == DxgiFormat.FormatYuy2);
        }
    }

    public static bool MotionEstimatorAllowedInputFormat(DxgiFormat Format)
    {
        return Format == DxgiFormat.FormatNv12;
    }

    public static MaybeBool<int> NonOpaquePlanar(DxgiFormat Format)
    {
        return Planar(Format) && !Opaque(Format);
    }

    public static uint NonOpaquePlaneCount(DxgiFormat Format)
    {
        if (!NonOpaquePlanar(Format))
        {
            return 1;
        }
        // V208 and V408 are the only 3-plane formats.
        return ((Format == DxgiFormat.FormatV208) || (Format == DxgiFormat.FormatV408)) ? 3u : 2u;
    }

    public static MaybeBool<int> Opaque(DxgiFormat Format)
    {
        return Format == DxgiFormat.Format420Opaque;
    }

    public static BOOL Planar(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).bPlanar;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HRESULT Safe_UIntAdd(
        uint uAugend,
        uint uAddend,
        [NativeTypeName("UINT *")] out uint puResult
    )
    {
        if ((uAugend + uAddend) >= uAugend)
        {
            puResult = (uAugend + uAddend);
            return S_OK;
        }
        puResult = uint.MaxValue;
        return E_FAIL;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static HResult Safe_UIntMult(
        uint uMultiplicand,
        uint uMultiplier,
        [NativeTypeName("UINT *")] out uint puResult
    )
    {
        ulong ull64Result = (ulong)(uMultiplicand) * (ulong)(uMultiplier);
        if (ull64Result <= uint.MaxValue)
        {
            puResult = (uint)(ull64Result);
            return S_OK;
        }
        puResult = uint.MaxValue;
        return E_FAIL;
    }

    public static uint Sequential2AbsoluteComponentIndex(
        DxgiFormat Format,
        uint SequentialComponentIndex
    )
    {
        uint n = 0;
        uint Index = GetDetailTableIndexThrow(Format);
        for (uint comp = 0; comp < 4; comp++)
        {
            D3DFormatComponentName name = (D3DFormatComponentName)(0);
            switch (comp)
            {
                case 0:
                {
                    name = GetFormatDetailRef(Index).ComponentName0;
                    break;
                }
                case 1:
                {
                    name = GetFormatDetailRef(Index).ComponentName1;
                    break;
                }
                case 2:
                {
                    name = GetFormatDetailRef(Index).ComponentName2;
                    break;
                }
                case 3:
                {
                    name = GetFormatDetailRef(Index).ComponentName3;
                    break;
                }
            }
            if (name != D3DFormatComponentName.X)
            {
                if (SequentialComponentIndex == n)
                {
                    return comp;
                }
                n++;
            }
        }
        return unchecked((uint)(-1));
    }

    public static bool SNORMAndUNORMFormats(DxgiFormat FormatA, DxgiFormat FormatB)
    {
        uint NumComponents = uint.Min(
            GetNumComponentsInFormat(FormatA),
            GetNumComponentsInFormat(FormatB)
        );
        for (uint c = 0; c < NumComponents; c++)
        {
            D3DFormatComponentInterpretation fciA = GetFormatComponentInterpretation(FormatA, c);
            D3DFormatComponentInterpretation fciB = GetFormatComponentInterpretation(FormatB, c);
            if (
                (
                    (fciA == D3DFormatComponentInterpretation.Snorm)
                    && (fciB == D3DFormatComponentInterpretation.Unorm)
                )
                || (
                    (fciB == D3DFormatComponentInterpretation.Snorm)
                    && (fciA == D3DFormatComponentInterpretation.Unorm)
                )
            )
            {
                return true;
            }
        }
        return false;
    }

    public static bool SupportsSamplerFeedback(DxgiFormat Format)
    {
        switch (Format)
        {
            case DxgiFormat.FormatSamplerFeedbackMinMipOpaque:
            case DxgiFormat.FormatSamplerFeedbackMipRegionUsedOpaque:
            {
                return true;
            }
            default:
            {
                return false;
            }
        }
    }

    [DoesNotReturn]
    private static void ThrowHR(HResult hr)
    {
        throw new ExternalException(null, hr);
    }

    // D3D11 has a limitation on typed UAVs (e.g. Texture1D/2D/3D) whereby the only format that can be read is R32_*.  Lots of formats
    // can be written though, with type conversion (e.g. R8G8B8A8_*).  If an API user wants to do image processing in-place, in either
    // the Compute Shader or the Pixel Shader, the only format available is R32_* (since it can be read and written at the same time).
    //
    // We were able to allow resources (Texture1D/2D/3D), created with a format from a small set of families that have 32 bits per element
    // (such as R8G8B8A8_TYPELESS), to be cast to R32_* when creating a UAV.  This means the Compute Shader or Pixel Shader can
    // do simultaneous read+write on the resource when bound as an R32_* UAV, with the caveat that the shader code has to do manual
    // type conversion manually, but later on the resource can be used as an SRV or RT as the desired type (e.g. R8G8B8A8_UNORM), and
    // thus have access to filtering/blending where the hardware knows what the format is.
    //
    // If we didn't have this ability to cast some formats to R32_* UAVs, applications would have to keep an extra allocation around
    // and do a rendering pass that copies from the R32_* UAV to whatever typed resource they really wanted.  For formats not included
    // in this list, such as any format that doesn't have 32-bits per component, as well as some 32-bit per component formats like
    // R24G8 or R11G11B10_FLOAT there is no alternative for an application but to do the extra copy as mentioned, or avoid in-place
    // image editing in favor of ping-ponging between buffers with multiple passes.
    public static bool ValidCastToR32UAV(DxgiFormat from, DxgiFormat to)
    {
        // Allow casting of 32 bit formats to R32_*
        if (
            (
                (to == DxgiFormat.FormatR32Uint)
                || (to == DxgiFormat.FormatR32Sint)
                || (to == DxgiFormat.FormatR32Float)
            )
        )
        {
            if (
                (from == DxgiFormat.FormatR10G10B10A2Typeless)
                || (from == DxgiFormat.FormatR8G8B8A8Typeless)
                || (from == DxgiFormat.FormatB8G8R8A8Typeless)
                || (from == DxgiFormat.FormatB8G8R8X8Typeless)
                || (from == DxgiFormat.FormatR16G16Typeless)
                || (from == DxgiFormat.FormatR32Typeless)
            )
            {
                return true;
            }
        }
        return false;
    }

    public static MaybeBool<int> YUV(DxgiFormat Format)
    {
        return GetFormatDetailRefThrow(Format).bYUV;
    }
}
