// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
using Silk.NET.Win32;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;
/// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3"]/*'/>
[Guid("4243ADB4-3A32-4666-973C-0CCC5625DC44")]
[NativeTypeName("struct ID3D12VideoDevice3 : ID3D12VideoDevice2")]
[NativeInheritance("ID3D12VideoDevice2")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct ID3D12VideoDevice3 : ID3D12VideoDevice3.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice3));

    public interface Interface : ID3D12VideoDevice2.Interface
    {
        [VtblIndex(14)]
        HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] D3D12VideoEncoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoder);
        [VtblIndex(14)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] Ref<D3D12VideoEncoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoder);
        [VtblIndex(15)]
        HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] D3D12VideoEncoderHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoderHeap);
        [VtblIndex(15)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] Ref<D3D12VideoEncoderHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoderHeap);
    }

    /// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3"]/*'/>
    [Guid("4243ADB4-3A32-4666-973C-0CCC5625DC44")]
    [NativeTypeName("struct ID3D12VideoDevice3 : ID3D12VideoDevice2")]
    [NativeInheritance("ID3D12VideoDevice2")]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice3));

        public void** lpVtbl;
        public partial struct Vtbl<TSelf>
            where TSelf : unmanaged, Interface
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, Guid*, void**, HResult> QueryInterface;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> AddRef;
            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint> Release;
            [NativeTypeName("HRESULT (D3D12_FEATURE_VIDEO, void *, UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12FeatureVideo, void*, uint, HResult> CheckFeatureSupport;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderDesc*, Guid*, void**, HResult> CreateVideoDecoder;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderHeapDesc*, Guid*, void**, HResult> CreateVideoDecoderHeap;
            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, Guid*, void**, HResult> CreateVideoProcessor;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoMotionEstimator;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoMotionVectorHeap;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoDecoder1;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_DECODER_HEAP_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoDecoderHeap1;
            [NativeTypeName("HRESULT (UINT, const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *, UINT, const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoProcessor1;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_EXTENSION_COMMAND_DESC *, const void *, SIZE_T, ID3D12ProtectedResourceSession *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> CreateVideoExtensionCommand;
            [NativeTypeName("HRESULT (ID3D12VideoExtensionCommand *, const void *, SIZE_T, void *, SIZE_T) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, ID3D12VideoExtensionCommand.Native*, void*, nuint, void*, nuint, HResult> ExecuteExtensionCommand;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_ENCODER_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoEncoderDesc*, Guid*, void**, HResult> CreateVideoEncoder;
            [NativeTypeName("HRESULT (const D3D12_VIDEO_ENCODER_HEAP_DESC *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<TSelf*, D3D12VideoEncoderHeapDesc*, Guid*, void**, HResult> CreateVideoEncoderHeap;
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, uint> )(lpVtbl[1]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12VideoDevice.CheckFeatureSupport"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12FeatureVideo, void*, uint, HResult> )(lpVtbl[3]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, Ref pFeatureSupportData, uint FeatureSupportDataSize)
        {
            fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
            {
                return (HResult)CheckFeatureSupport(FeatureVideo, __dsl_pFeatureSupportData, FeatureSupportDataSize);
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoDecoder"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoDecoderDesc*, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
        {
            fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoDecoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoDecoder);
            }
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, out TCom ppVideoDecoder)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                ppVideoDecoder = default;
                return CreateVideoDecoder(__dsl_pDesc, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoDecoder1"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoDecoderDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[9]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoDecoder);
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
        {
            fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoDecoder1(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoDecoder);
            }
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoder1<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoDecoder)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
            {
                ppVideoDecoder = default;
                return CreateVideoDecoder1(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoDecoderHeap"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoDecoderHeapDesc*, Guid*, void**, HResult> )(lpVtbl[5]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
        {
            fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                return (HResult)CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, __dsl_riid, __dsl_ppVideoDecoderHeap);
            }
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, out TCom ppVideoDecoderHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                ppVideoDecoderHeap = default;
                return CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoDecoderHeap1"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoDecoderHeapDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[10]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoDecoderHeap);
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
        {
            fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                return (HResult)CreateVideoDecoderHeap1(__dsl_pVideoDecoderHeapDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoDecoderHeap);
            }
        }

        [VtblIndex(10)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoDecoderHeap1<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoDecoderHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
            {
                ppVideoDecoderHeap = default;
                return CreateVideoDecoderHeap1(__dsl_pVideoDecoderHeapDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
            }
        }

        /// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3.CreateVideoEncoder"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] D3D12VideoEncoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoder)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoEncoderDesc*, Guid*, void**, HResult> )(lpVtbl[14]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoEncoder);
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] Ref<D3D12VideoEncoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoder)
        {
            fixed (void** __dsl_ppVideoEncoder = ppVideoEncoder)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoEncoderDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoEncoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoEncoder);
            }
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoEncoder<TCom>([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] Ref<D3D12VideoEncoderDesc> pDesc, out TCom ppVideoEncoder)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoEncoderDesc* __dsl_pDesc = pDesc)
            {
                ppVideoEncoder = default;
                return CreateVideoEncoder(__dsl_pDesc, TCom.NativeGuid, ppVideoEncoder.GetAddressOf());
            }
        }

        /// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3.CreateVideoEncoderHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] D3D12VideoEncoderHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoEncoderHeapDesc*, Guid*, void**, HResult> )(lpVtbl[15]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoEncoderHeap);
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] Ref<D3D12VideoEncoderHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoderHeap)
        {
            fixed (void** __dsl_ppVideoEncoderHeap = ppVideoEncoderHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoEncoderHeapDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoEncoderHeap(__dsl_pDesc, __dsl_riid, __dsl_ppVideoEncoderHeap);
            }
        }

        [VtblIndex(15)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoEncoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] Ref<D3D12VideoEncoderHeapDesc> pDesc, out TCom ppVideoEncoderHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoEncoderHeapDesc* __dsl_pDesc = pDesc)
            {
                ppVideoEncoderHeap = default;
                return CreateVideoEncoderHeap(__dsl_pDesc, TCom.NativeGuid, ppVideoEncoderHeap.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoExtensionCommand"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] D3D12VideoExtensionCommandDesc* pDesc, [NativeTypeName("const void *")] void* pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoExtensionCommand)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoExtensionCommandDesc*, void*, nuint, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[12]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession.LpVtbl, riid, ppVideoExtensionCommand);
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] Ref<D3D12VideoExtensionCommandDesc> pDesc, [NativeTypeName("const void *")] Ref pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoExtensionCommand)
        {
            fixed (void** __dsl_ppVideoExtensionCommand = ppVideoExtensionCommand)
            fixed (Guid* __dsl_riid = riid)
            fixed (void* __dsl_pCreationParameters = pCreationParameters)
            fixed (D3D12VideoExtensionCommandDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoExtensionCommand(__dsl_pDesc, __dsl_pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoExtensionCommand);
            }
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoExtensionCommand<TCom>([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] Ref<D3D12VideoExtensionCommandDesc> pDesc, [NativeTypeName("const void *")] Ref pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoExtensionCommand)
            where TCom : unmanaged, IComVtbl
        {
            fixed (void* __dsl_pCreationParameters = pCreationParameters)
            fixed (D3D12VideoExtensionCommandDesc* __dsl_pDesc = pDesc)
            {
                ppVideoExtensionCommand = default;
                return CreateVideoExtensionCommand(__dsl_pDesc, __dsl_pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, TCom.NativeGuid, ppVideoExtensionCommand.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice1.CreateVideoMotionEstimator"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionEstimator)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoMotionEstimator);
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] Ref<D3D12VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionEstimator)
        {
            fixed (void** __dsl_ppVideoMotionEstimator = ppVideoMotionEstimator)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoMotionEstimatorDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoMotionEstimator(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoMotionEstimator);
            }
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoMotionEstimator<TCom>([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] Ref<D3D12VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoMotionEstimator)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoMotionEstimatorDesc* __dsl_pDesc = pDesc)
            {
                ppVideoMotionEstimator = default;
                return CreateVideoMotionEstimator(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoMotionEstimator.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice1.CreateVideoMotionVectorHeap"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionVectorHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, D3D12VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[8]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoMotionVectorHeap);
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] Ref<D3D12VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionVectorHeap)
        {
            fixed (void** __dsl_ppVideoMotionVectorHeap = ppVideoMotionVectorHeap)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoMotionVectorHeapDesc* __dsl_pDesc = pDesc)
            {
                return (HResult)CreateVideoMotionVectorHeap(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoMotionVectorHeap);
            }
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoMotionVectorHeap<TCom>([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] Ref<D3D12VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoMotionVectorHeap)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoMotionVectorHeapDesc* __dsl_pDesc = pDesc)
            {
                ppVideoMotionVectorHeap = default;
                return CreateVideoMotionVectorHeap(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoMotionVectorHeap.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoProcessor"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, Guid*, void**, HResult> )(lpVtbl[6]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
        {
            fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                return (HResult)CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, __dsl_riid, __dsl_ppVideoProcessor);
            }
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, out TCom ppVideoProcessor)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                ppVideoProcessor = default;
                return CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoProcessor1"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult CreateVideoProcessor1(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[11]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession.LpVtbl, riid, ppVideoProcessor);
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor1(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
        {
            fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
            fixed (Guid* __dsl_riid = riid)
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                return (HResult)CreateVideoProcessor1(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoProcessor);
            }
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult CreateVideoProcessor1<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoProcessor)
            where TCom : unmanaged, IComVtbl
        {
            fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
            fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
            {
                ppVideoProcessor = default;
                return CreateVideoProcessor1(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, pProtectedResourceSession, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
            }
        }

        /// <inheritdoc cref = "ID3D12VideoDevice2.ExecuteExtensionCommand"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, void* pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, ID3D12VideoExtensionCommand.Native*, void*, nuint, void*, nuint, HResult> )(lpVtbl[13]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), pExtensionCommand.LpVtbl, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, [NativeTypeName("const void *")] Ref pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, Ref pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes)
        {
            fixed (void* __dsl_pOutputData = pOutputData)
            fixed (void* __dsl_pExecutionParameters = pExecutionParameters)
            {
                return (HResult)ExecuteExtensionCommand(pExtensionCommand, __dsl_pExecutionParameters, ExecutionParametersSizeInBytes, __dsl_pOutputData, OutputDataSizeInBytes);
            }
        }

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        /// <inheritdoc cref = "IUnknown.Release"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice3.Native*, uint> )(lpVtbl[2]))((ID3D12VideoDevice3.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice3(Ptr3D vtbl) => LpVtbl = (ID3D12VideoDevice3.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice3(Ptr<ID3D12VideoDevice3.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VideoDevice3.Native"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice3(ID3D12VideoDevice3.Native* value) => new ID3D12VideoDevice3((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice3"/> to <see cref = "ID3D12VideoDevice3.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice3.Native*(ID3D12VideoDevice3 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Ptr3D value) => new ID3D12VideoDevice3(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VideoDevice3 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(Ptr<ID3D12VideoDevice3.Native> value) => new ID3D12VideoDevice3(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice3"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VideoDevice3.Native>(ID3D12VideoDevice3 value) => (Ptr<ID3D12VideoDevice3.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(void*** value) => new ID3D12VideoDevice3((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice3"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VideoDevice3 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VideoDevice3"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice3(nuint value) => new ID3D12VideoDevice3((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VideoDevice3"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice3"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VideoDevice3 value) => (nuint)value.LpVtbl;
    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();
    /// <inheritdoc cref = "ID3D12VideoDevice.CheckFeatureSupport"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize) => LpVtbl->CheckFeatureSupport(FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, Ref pFeatureSupportData, uint FeatureSupportDataSize)
    {
        fixed (void* __dsl_pFeatureSupportData = pFeatureSupportData)
        {
            return (HResult)CheckFeatureSupport(FeatureVideo, __dsl_pFeatureSupportData, FeatureSupportDataSize);
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoDecoder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder) => LpVtbl->CreateVideoDecoder(pDesc, riid, ppVideoDecoder);
    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
    {
        fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoDecoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoDecoder);
        }
    }

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, out TCom ppVideoDecoder)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            ppVideoDecoder = default;
            return CreateVideoDecoder(__dsl_pDesc, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoDecoder1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] D3D12VideoDecoderDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoder) => LpVtbl->CreateVideoDecoder1(pDesc, pProtectedResourceSession, riid, ppVideoDecoder);
    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder1([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoder)
    {
        fixed (void** __dsl_ppVideoDecoder = ppVideoDecoder)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoDecoder1(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoDecoder);
        }
    }

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoder1<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_DESC *")] Ref<D3D12VideoDecoderDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoDecoder)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderDesc* __dsl_pDesc = pDesc)
        {
            ppVideoDecoder = default;
            return CreateVideoDecoder1(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoDecoder.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoDecoderHeap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap) => LpVtbl->CreateVideoDecoderHeap(pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
    {
        fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            return (HResult)CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, __dsl_riid, __dsl_ppVideoDecoderHeap);
        }
    }

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, out TCom ppVideoDecoderHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            ppVideoDecoderHeap = default;
            return CreateVideoDecoderHeap(__dsl_pVideoDecoderHeapDesc, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoDecoderHeap1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap) => LpVtbl->CreateVideoDecoderHeap1(pVideoDecoderHeapDesc, pProtectedResourceSession, riid, ppVideoDecoderHeap);
    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap1([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoDecoderHeap)
    {
        fixed (void** __dsl_ppVideoDecoderHeap = ppVideoDecoderHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            return (HResult)CreateVideoDecoderHeap1(__dsl_pVideoDecoderHeapDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoDecoderHeap);
        }
    }

    [VtblIndex(10)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoDecoderHeap1<TCom>([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] Ref<D3D12VideoDecoderHeapDesc> pVideoDecoderHeapDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoDecoderHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoDecoderHeapDesc* __dsl_pVideoDecoderHeapDesc = pVideoDecoderHeapDesc)
        {
            ppVideoDecoderHeap = default;
            return CreateVideoDecoderHeap1(__dsl_pVideoDecoderHeapDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoDecoderHeap.GetAddressOf());
        }
    }

    /// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3.CreateVideoEncoder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] D3D12VideoEncoderDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoder) => LpVtbl->CreateVideoEncoder(pDesc, riid, ppVideoEncoder);
    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoEncoder([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] Ref<D3D12VideoEncoderDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoder)
    {
        fixed (void** __dsl_ppVideoEncoder = ppVideoEncoder)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoEncoderDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoEncoder(__dsl_pDesc, __dsl_riid, __dsl_ppVideoEncoder);
        }
    }

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoEncoder<TCom>([NativeTypeName("const D3D12_VIDEO_ENCODER_DESC *")] Ref<D3D12VideoEncoderDesc> pDesc, out TCom ppVideoEncoder)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoEncoderDesc* __dsl_pDesc = pDesc)
        {
            ppVideoEncoder = default;
            return CreateVideoEncoder(__dsl_pDesc, TCom.NativeGuid, ppVideoEncoder.GetAddressOf());
        }
    }

    /// <include file='ID3D12VideoDevice3.xml' path='doc/member[@name="ID3D12VideoDevice3.CreateVideoEncoderHeap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] D3D12VideoEncoderHeapDesc* pDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoEncoderHeap) => LpVtbl->CreateVideoEncoderHeap(pDesc, riid, ppVideoEncoderHeap);
    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoEncoderHeap([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] Ref<D3D12VideoEncoderHeapDesc> pDesc, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoEncoderHeap)
    {
        fixed (void** __dsl_ppVideoEncoderHeap = ppVideoEncoderHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoEncoderHeapDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoEncoderHeap(__dsl_pDesc, __dsl_riid, __dsl_ppVideoEncoderHeap);
        }
    }

    [VtblIndex(15)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoEncoderHeap<TCom>([NativeTypeName("const D3D12_VIDEO_ENCODER_HEAP_DESC *")] Ref<D3D12VideoEncoderHeapDesc> pDesc, out TCom ppVideoEncoderHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoEncoderHeapDesc* __dsl_pDesc = pDesc)
        {
            ppVideoEncoderHeap = default;
            return CreateVideoEncoderHeap(__dsl_pDesc, TCom.NativeGuid, ppVideoEncoderHeap.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoExtensionCommand"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] D3D12VideoExtensionCommandDesc* pDesc, [NativeTypeName("const void *")] void* pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoExtensionCommand) => LpVtbl->CreateVideoExtensionCommand(pDesc, pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, riid, ppVideoExtensionCommand);
    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoExtensionCommand([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] Ref<D3D12VideoExtensionCommandDesc> pDesc, [NativeTypeName("const void *")] Ref pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoExtensionCommand)
    {
        fixed (void** __dsl_ppVideoExtensionCommand = ppVideoExtensionCommand)
        fixed (Guid* __dsl_riid = riid)
        fixed (void* __dsl_pCreationParameters = pCreationParameters)
        fixed (D3D12VideoExtensionCommandDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoExtensionCommand(__dsl_pDesc, __dsl_pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoExtensionCommand);
        }
    }

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoExtensionCommand<TCom>([NativeTypeName("const D3D12_VIDEO_EXTENSION_COMMAND_DESC *")] Ref<D3D12VideoExtensionCommandDesc> pDesc, [NativeTypeName("const void *")] Ref pCreationParameters, [NativeTypeName("SIZE_T")] nuint CreationParametersDataSizeInBytes, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoExtensionCommand)
        where TCom : unmanaged, IComVtbl
    {
        fixed (void* __dsl_pCreationParameters = pCreationParameters)
        fixed (D3D12VideoExtensionCommandDesc* __dsl_pDesc = pDesc)
        {
            ppVideoExtensionCommand = default;
            return CreateVideoExtensionCommand(__dsl_pDesc, __dsl_pCreationParameters, CreationParametersDataSizeInBytes, pProtectedResourceSession, TCom.NativeGuid, ppVideoExtensionCommand.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice1.CreateVideoMotionEstimator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionEstimator) => LpVtbl->CreateVideoMotionEstimator(pDesc, pProtectedResourceSession, riid, ppVideoMotionEstimator);
    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] Ref<D3D12VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionEstimator)
    {
        fixed (void** __dsl_ppVideoMotionEstimator = ppVideoMotionEstimator)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoMotionEstimatorDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoMotionEstimator(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoMotionEstimator);
        }
    }

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoMotionEstimator<TCom>([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] Ref<D3D12VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoMotionEstimator)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoMotionEstimatorDesc* __dsl_pDesc = pDesc)
        {
            ppVideoMotionEstimator = default;
            return CreateVideoMotionEstimator(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoMotionEstimator.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice1.CreateVideoMotionVectorHeap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionVectorHeap) => LpVtbl->CreateVideoMotionVectorHeap(pDesc, pProtectedResourceSession, riid, ppVideoMotionVectorHeap);
    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] Ref<D3D12VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionVectorHeap)
    {
        fixed (void** __dsl_ppVideoMotionVectorHeap = ppVideoMotionVectorHeap)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoMotionVectorHeapDesc* __dsl_pDesc = pDesc)
        {
            return (HResult)CreateVideoMotionVectorHeap(__dsl_pDesc, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoMotionVectorHeap);
        }
    }

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoMotionVectorHeap<TCom>([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] Ref<D3D12VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoMotionVectorHeap)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoMotionVectorHeapDesc* __dsl_pDesc = pDesc)
        {
            ppVideoMotionVectorHeap = default;
            return CreateVideoMotionVectorHeap(__dsl_pDesc, pProtectedResourceSession, TCom.NativeGuid, ppVideoMotionVectorHeap.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoProcessor"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor) => LpVtbl->CreateVideoProcessor(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
    {
        fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            return (HResult)CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, __dsl_riid, __dsl_ppVideoProcessor);
        }
    }

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, out TCom ppVideoProcessor)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            ppVideoProcessor = default;
            return CreateVideoProcessor(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice2.CreateVideoProcessor1"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult CreateVideoProcessor1(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] D3D12VideoProcessOutputStreamDesc* pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] D3D12VideoProcessInputStreamDesc* pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoProcessor) => LpVtbl->CreateVideoProcessor1(NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, pProtectedResourceSession, riid, ppVideoProcessor);
    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor1(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoProcessor)
    {
        fixed (void** __dsl_ppVideoProcessor = ppVideoProcessor)
        fixed (Guid* __dsl_riid = riid)
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            return (HResult)CreateVideoProcessor1(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, pProtectedResourceSession, __dsl_riid, __dsl_ppVideoProcessor);
        }
    }

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult CreateVideoProcessor1<TCom>(uint NodeMask, [NativeTypeName("const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")] Ref<D3D12VideoProcessOutputStreamDesc> pOutputStreamDesc, uint NumInputStreamDescs, [NativeTypeName("const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")] Ref<D3D12VideoProcessInputStreamDesc> pInputStreamDescs, ID3D12ProtectedResourceSession pProtectedResourceSession, out TCom ppVideoProcessor)
        where TCom : unmanaged, IComVtbl
    {
        fixed (D3D12VideoProcessInputStreamDesc* __dsl_pInputStreamDescs = pInputStreamDescs)
        fixed (D3D12VideoProcessOutputStreamDesc* __dsl_pOutputStreamDesc = pOutputStreamDesc)
        {
            ppVideoProcessor = default;
            return CreateVideoProcessor1(NodeMask, __dsl_pOutputStreamDesc, NumInputStreamDescs, __dsl_pInputStreamDescs, pProtectedResourceSession, TCom.NativeGuid, ppVideoProcessor.GetAddressOf());
        }
    }

    /// <inheritdoc cref = "ID3D12VideoDevice2.ExecuteExtensionCommand"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, [NativeTypeName("const void *")] void* pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, void* pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes) => LpVtbl->ExecuteExtensionCommand(pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes, pOutputData, OutputDataSizeInBytes);
    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult ExecuteExtensionCommand(ID3D12VideoExtensionCommand pExtensionCommand, [NativeTypeName("const void *")] Ref pExecutionParameters, [NativeTypeName("SIZE_T")] nuint ExecutionParametersSizeInBytes, Ref pOutputData, [NativeTypeName("SIZE_T")] nuint OutputDataSizeInBytes)
    {
        fixed (void* __dsl_pOutputData = pOutputData)
        fixed (void* __dsl_pExecutionParameters = pExecutionParameters)
        {
            return (HResult)ExecuteExtensionCommand(pExtensionCommand, __dsl_pExecutionParameters, ExecutionParametersSizeInBytes, __dsl_pOutputData, OutputDataSizeInBytes);
        }
    }

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) => LpVtbl->QueryInterface(riid, ppvObject);
    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}