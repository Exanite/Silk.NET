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
/// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1"]/*'/>
[Guid("981611AD-A144-4C83-9890-F30E26D658AB")]
[NativeTypeName("struct ID3D12VideoDevice1 : ID3D12VideoDevice")]
[NativeInheritance("ID3D12VideoDevice")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct ID3D12VideoDevice1 : ID3D12VideoDevice1.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice1));

    public interface Interface : ID3D12VideoDevice.Interface
    {
        [VtblIndex(7)]
        HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionEstimator);
        [VtblIndex(7)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] Ref<D3D12VideoMotionEstimatorDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionEstimator);
        [VtblIndex(8)]
        HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionVectorHeap);
        [VtblIndex(8)]
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] Ref<D3D12VideoMotionVectorHeapDesc> pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppVideoMotionVectorHeap);
    }

    /// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1"]/*'/>
    [Guid("981611AD-A144-4C83-9890-F30E26D658AB")]
    [NativeTypeName("struct ID3D12VideoDevice1 : ID3D12VideoDevice")]
    [NativeInheritance("ID3D12VideoDevice")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public unsafe partial struct Native : Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.ID3D12VideoDevice1));

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
        }

        /// <inheritdoc cref = "IUnknown.AddRef"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, uint> )(lpVtbl[1]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this));
        }

        /// <inheritdoc cref = "ID3D12VideoDevice.CheckFeatureSupport"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult CheckFeatureSupport(D3D12FeatureVideo FeatureVideo, void* pFeatureSupportData, uint FeatureSupportDataSize)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, D3D12FeatureVideo, void*, uint, HResult> )(lpVtbl[3]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), FeatureVideo, pFeatureSupportData, FeatureSupportDataSize);
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
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, D3D12VideoDecoderDesc*, Guid*, void**, HResult> )(lpVtbl[4]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), pDesc, riid, ppVideoDecoder);
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

        /// <inheritdoc cref = "ID3D12VideoDevice.CreateVideoDecoderHeap"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult CreateVideoDecoderHeap([NativeTypeName("const D3D12_VIDEO_DECODER_HEAP_DESC *")] D3D12VideoDecoderHeapDesc* pVideoDecoderHeapDesc, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoDecoderHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, D3D12VideoDecoderHeapDesc*, Guid*, void**, HResult> )(lpVtbl[5]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), pVideoDecoderHeapDesc, riid, ppVideoDecoderHeap);
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

        /// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1.CreateVideoMotionEstimator"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult CreateVideoMotionEstimator([NativeTypeName("const D3D12_VIDEO_MOTION_ESTIMATOR_DESC *")] D3D12VideoMotionEstimatorDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionEstimator)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, D3D12VideoMotionEstimatorDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[7]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoMotionEstimator);
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

        /// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1.CreateVideoMotionVectorHeap"]/*'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult CreateVideoMotionVectorHeap([NativeTypeName("const D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC *")] D3D12VideoMotionVectorHeapDesc* pDesc, ID3D12ProtectedResourceSession pProtectedResourceSession, [NativeTypeName("const IID &")] Guid* riid, void** ppVideoMotionVectorHeap)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, D3D12VideoMotionVectorHeapDesc*, ID3D12ProtectedResourceSession.Native*, Guid*, void**, HResult> )(lpVtbl[8]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), pDesc, pProtectedResourceSession.LpVtbl, riid, ppVideoMotionVectorHeap);
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
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, uint, D3D12VideoProcessOutputStreamDesc*, uint, D3D12VideoProcessInputStreamDesc*, Guid*, void**, HResult> )(lpVtbl[6]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), NodeMask, pOutputStreamDesc, NumInputStreamDescs, pInputStreamDescs, riid, ppVideoProcessor);
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

        /// <inheritdoc cref = "IUnknown.QueryInterface"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, Guid*, void**, HResult> )(lpVtbl[0]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this), riid, ppvObject);
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
            return ((delegate* unmanaged<ID3D12VideoDevice1.Native*, uint> )(lpVtbl[2]))((ID3D12VideoDevice1.Native*)Unsafe.AsPointer(ref this));
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice1(Ptr3D vtbl) => LpVtbl = (ID3D12VideoDevice1.Native*)vtbl;
    /// <summary>Initializes a new instance of the <see cref = "ID3D12VideoDevice1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D12VideoDevice1(Ptr<ID3D12VideoDevice1.Native> vtbl) => LpVtbl = vtbl;
    /// <summary>casts <see cref = "ID3D12VideoDevice1.Native"/> to <see cref = "ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1.Native"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice1(ID3D12VideoDevice1.Native* value) => new ID3D12VideoDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice1"/> to <see cref = "ID3D12VideoDevice1.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1"/> instance to be converted </param>
    public static implicit operator ID3D12VideoDevice1.Native*(ID3D12VideoDevice1 value) => value.LpVtbl;
    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice1(Ptr3D value) => new ID3D12VideoDevice1(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice1"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1"/> instance to be converted </param>
    public static implicit operator Ptr3D(ID3D12VideoDevice1 value) => (Ptr3D)value.LpVtbl;
    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice1(Ptr<ID3D12VideoDevice1.Native> value) => new ID3D12VideoDevice1(value);
    /// <summary>casts <see cref = "ID3D12VideoDevice1"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1"/> instance to be converted </param>
    public static implicit operator Ptr<ID3D12VideoDevice1.Native>(ID3D12VideoDevice1 value) => (Ptr<ID3D12VideoDevice1.Native>)value.LpVtbl;
    /// <summary>casts void*** to <see cref = "ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>
    public static explicit operator ID3D12VideoDevice1(void*** value) => new ID3D12VideoDevice1((Ptr<Native>)value);
    /// <summary>casts <see cref = "ID3D12VideoDevice1"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1"/> instance to be converted </param>
    public static implicit operator void***(ID3D12VideoDevice1 value) => (void***)value.LpVtbl;
    /// <summary>casts <see cref = "nuint"/> to <see cref = "ID3D12VideoDevice1"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>
    public static explicit operator ID3D12VideoDevice1(nuint value) => new ID3D12VideoDevice1((Ptr<Native>)value.ToPointer());
    /// <summary>casts <see cref = "ID3D12VideoDevice1"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "ID3D12VideoDevice1"/> instance to be converted </param>
    public static implicit operator nuint(ID3D12VideoDevice1 value) => (nuint)value.LpVtbl;
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

    /// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1.CreateVideoMotionEstimator"]/*'/>
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

    /// <include file='ID3D12VideoDevice1.xml' path='doc/member[@name="ID3D12VideoDevice1.CreateVideoMotionVectorHeap"]/*'/>
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